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
                    pbImagenMoto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg); // Usa el formato adecuado
                    imagenBytes = ms.ToArray();
                }

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO VentasMotos (Modelo_Moto, Descripcion, Precio, Imagen) VALUES (@Modelo, @Descripcion, @Precio, @Imagen)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Modelo", txtModelo.Text);
                        cmd.Parameters.AddWithValue("@Descripcion", rtxtDescripcion.Text);
                        cmd.Parameters.AddWithValue("@Precio", Convert.ToDecimal(txtPrecio.Text));
                        cmd.Parameters.Add("@Imagen", SqlDbType.VarBinary).Value = imagenBytes;

                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();

                        MessageBox.Show("Moto agregada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (dgv_EnseñarMotos.SelectedRows.Count > 0)
                {
                    DataGridViewRow filaSeleccionada = dgv_EnseñarMotos.SelectedRows[0];

                    // Deshabilitar todas las celdas de la fila
                    foreach (DataGridViewCell celda in filaSeleccionada.Cells)
                    {
                        celda.ReadOnly = true; // Hace que no se puedan editar
                        celda.Style.BackColor = Color.LightGray; // Cambia el fondo
                        celda.Style.ForeColor = Color.DarkGray; // Cambia el color del texto
                    }

                    // Evitar que el usuario seleccione nuevamente la fila
                    filaSeleccionada.Selected = false;
                    dgv_EnseñarMotos.ClearSelection();
                    txtModelo.Text = "";
                    txtPrecio.Text = "";
                    pbImagenMoto.Image = null;
                    rtxtDescripcion.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

            dgv_EnseñarMotos.DataSource = conSQL.retornaRegistros(@" Select * from Enseñar_Motos;");

            dgv_EnseñarMotos.Refresh();

        }

        private void dgv_EnseñarMotos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && dgv_EnseñarMotos.Columns[e.ColumnIndex].Name == "Foto_Moto")
            {
                // Verifica si la celda contiene una imagen
                if (e.Value is Image img)
                {
                    // Establece el tamaño de la imagen
                    e.Value = AjustarIMG(img, 1, 1); // 50x50 es el tamaño que deseas para la imagen pequeña
                }
            }
        }
        private Image AjustarIMG(Image img, int width, int height)
        {
            return new Bitmap(img, new Size(width, height));
        }

        private void dgv_EnseñarMotos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            // Verifica que se haya hecho clic en una fila, no en el encabezado
            if (e.RowIndex >= 0)
            {
                // Obtén los datos de la fila seleccionada
                DataGridViewRow row = dgv_EnseñarMotos.Rows[e.RowIndex];

                // Asigna los valores a los controles correspondientes
                txtModelo.Text = row.Cells["Modelo_Moto"].Value.ToString();
                txtPrecio.Text = row.Cells["Precio_Moto"].Value.ToString();

                // Cargar la imagen desde la base de datos
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
            if (e.ColumnIndex == dgv_EnseñarMotos.Columns["Foto_Moto"].Index && e.RowIndex >= 0)
            {
                byte[] imagenBytes = (byte[])dgv_EnseñarMotos.Rows[e.RowIndex].Cells["Foto_Moto"].Value;

                using (MemoryStream ms = new MemoryStream(imagenBytes))
                {
                    Image imagen = Image.FromStream(ms);

                    pbImagenMoto.Image = imagen;

                   
                }
            }
        }
        public Panel panelContenedorMotosss;

        private void btn_Regresar_aggMoto_Click(object sender, EventArgs e)
        {
            
        }
        
    }
}
