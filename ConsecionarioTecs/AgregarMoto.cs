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

namespace ConsecionarioTecs
{
    public partial class AgregarMoto : Form
    {
        string connectionString = "Server=ALXJANDR07\\SQLEXPRESS;Database=CompañiaTecsBDD;User id=AleAdmin;Password=luis;";
        byte[] imagenBytes = null; // Para almacenar la imagen
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
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Imágenes|*.jpg;*.png;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbImagenMoto.Image = System.Drawing.Image.FromFile(ofd.FileName);
                imagenBytes = File.ReadAllBytes(ofd.FileName); // Convertir imagen a bytes
            }
        }

        private void btnAgregarMoto_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO VentasMotos (Modelo_Moto, Descripcion, Precio, Valoracion, Imagen) VALUES (@Modelo, @Descripcion, @Precio, @Valoracion, @Imagen)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Modelo", txtModelo.Text);
                        cmd.Parameters.AddWithValue("@Descripcion", rtxtDescripcion.Text);
                        cmd.Parameters.AddWithValue("@Precio", Convert.ToDecimal(txtPrecio.Text));
                        cmd.Parameters.AddWithValue("@Valoracion", Convert.ToSingle(cboxValoracion.Text));
                        cmd.Parameters.AddWithValue("@Imagen", (object)imagenBytes ?? DBNull.Value);

                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();

                        MessageBox.Show("Moto agregada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
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
    }
}
