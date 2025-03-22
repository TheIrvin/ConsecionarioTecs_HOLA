using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using FormularioDeInicio;

namespace ConsecionarioTecs
{
    public partial class AgregarMoto : Form
    {
        string connectionString = "Server=THEIRVIN\\SQLEXPRESS;Database=CompañiaTecsBDD;User id=bbd_tecs;Password=123456;";
        byte[] imagenBytes = null;
        Conexion_BDD conSQL = new Conexion_BDD();

        public AgregarMoto()
        {
            InitializeComponent();
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnCerrarAggC_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCargarIma_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAgregarMoto_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] imagenBytes;
                using (MemoryStream ms = new MemoryStream())
                {
                    pbImagenMoto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    imagenBytes = ms.ToArray();
                }

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // INSERTAR LA MOTO EN VentasMotos
                    string queryInsert = "INSERT INTO VentasMotos (Modelo_Moto, Descripcion, Precio, Imagen) VALUES (@Modelo, @Descripcion, @Precio, @Imagen)";
                    using (SqlCommand cmd = new SqlCommand(queryInsert, con))
                    {
                        cmd.Parameters.AddWithValue("@Modelo", txtModelo.Text);
                        cmd.Parameters.AddWithValue("@Descripcion", rtxtDescripcion.Text);
                        cmd.Parameters.AddWithValue("@Precio", Convert.ToDecimal(txtPrecio.Text));
                        cmd.Parameters.Add("@Imagen", SqlDbType.VarBinary).Value = imagenBytes;
                        cmd.ExecuteNonQuery();
                    }

                    // MARCAR COMO RESERVADA EN Enseñar_Motos
                    string queryUpdate = "UPDATE Enseñar_Motos SET Reservado = 1 WHERE Modelo_Moto = @Modelo";
                    using (SqlCommand cmdUpdate = new SqlCommand(queryUpdate, con))
                    {
                        cmdUpdate.Parameters.AddWithValue("@Modelo", txtModelo.Text);
                        cmdUpdate.ExecuteNonQuery();
                    }

                    con.Close();
                    MessageBox.Show("Moto agregada y reservada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // RECARGAR DATOS Y DESHABILITAR FILAS RESERVADAS

                // LIMPIAR CAMPOS
                txtModelo.Text = "";
                txtPrecio.Text = "";
                pbImagenMoto.Image = null;
                rtxtDescripcion.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarDatos()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT * FROM Enseñar_Motos";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv_EnseñarMotos.DataSource = dt;
            }

            DesabilitarFIla();
        }
        private void panelTopaggMoto_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelTopaggMoto_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AgregarMoto_Load(object sender, EventArgs e)
        {

            CargarDatos();

        }
        private void DesabilitarFIla()
        {
            foreach (DataGridViewRow fila in dgv_EnseñarMotos.Rows)
            {
                if (fila.Cells["Reservado"].Value != DBNull.Value && Convert.ToBoolean(fila.Cells["Reservado"].Value))
                {
                    // 🔴 OPCIÓN 1: ROJO para indicar reservada
                    fila.DefaultCellStyle.BackColor = Color.LightCoral;
                    fila.DefaultCellStyle.ForeColor = Color.White;

                    // 🔹 OPCIÓN 2: GRIS (si prefieres esta opción, descomenta y comenta la anterior)
                    // fila.DefaultCellStyle.BackColor = Color.LightGray;
                    // fila.DefaultCellStyle.ForeColor = Color.DarkGray;

                    // 🔒 Bloquear selección y edición
                    fila.Selected = false;
                    fila.ReadOnly = true;
                    foreach (DataGridViewCell celda in fila.Cells)
                    {
                        celda.ReadOnly = true;
                    }
                }
            }
            dgv_EnseñarMotos.Refresh();


        }
        private void CargarMotos()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT * FROM Enseñar_Motos WHERE Reservado = 0"; // Solo motos NO reservadas
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv_EnseñarMotos.DataSource = dt;
            }
        }
        private void dgv_EnseñarMotos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
        }
        private Image AjustarIMG(Image img, int width, int height)
        {
            return new Bitmap(img, new Size(width, height));
        }

        private void dgv_EnseñarMotos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_EnseñarMotos.Rows[e.RowIndex];

                // Si la fila está reservada, no hacer nada y deseleccionarla
                if (row.Cells["Reservado"].Value != DBNull.Value && Convert.ToBoolean(row.Cells["Reservado"].Value))
                {
                    dgv_EnseñarMotos.ClearSelection(); // Evita que quede seleccionada
                    return;
                }

                // Llenar los campos solo si la moto NO está reservada
                txtModelo.Text = row.Cells["Modelo_Moto"].Value.ToString();
                txtPrecio.Text = row.Cells["Precio_Moto"].Value.ToString();

                byte[] imageBytes = row.Cells["Foto_Moto"].Value as byte[];
                if (imageBytes != null)
                {
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        pbImagenMoto.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    pbImagenMoto.Image = null;
                }
            }
        }

        private void btn_Regresar_aggMoto_Click(object sender, EventArgs e)
        {
            
        }

        private void dgv_EnseñarMotos_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgv_EnseñarMotos.SelectedRows)
            {
                if (row.Cells["Reservado"].Value != DBNull.Value && Convert.ToBoolean(row.Cells["Reservado"].Value))
                {
                    row.Selected = false; // Quita la selección si está reservada
                }
            }
        }

        private void dgv_EnseñarMotos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DesabilitarFIla();
        }
    }
}
