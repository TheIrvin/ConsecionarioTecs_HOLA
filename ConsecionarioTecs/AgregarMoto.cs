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
                //ARREGLAR PARA QUE SE DESABILITEN cuando se agregue una moto en AgregarMotos en el dgv
                if (dgv_EnseñarMotos.SelectedRows.Count > 0)
                {
                    DataGridViewRow filaSeleccionada = dgv_EnseñarMotos.SelectedRows[0];

                    foreach (DataGridViewCell celda in filaSeleccionada.Cells)
                    {
                        celda.ReadOnly = true; 
                        celda.Style.BackColor = Color.LightGray; 
                        celda.Style.ForeColor = Color.DarkGray;
                    }

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
                if (e.Value is Image img)
                {
                    e.Value = AjustarIMG(img, 1, 1); 
                }
            }
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

        private void btn_Regresar_aggMoto_Click(object sender, EventArgs e)
        {
            
        }
        
    }
}
