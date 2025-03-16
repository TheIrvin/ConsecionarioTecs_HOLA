using ConsecionarioTecs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioDeInicio
{
    public partial class Venta_Cliente : Form
    {
        public Venta_Cliente()
        {
            InitializeComponent();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

      
        private void bt_aggImagen_ventaMoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp"; 

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                picBox_ventaCliente.Image = new Bitmap(openFileDialog.FileName); 
                picBox_ventaCliente.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void bt_enviarPropuesta_ventaCliente_Click(object sender, EventArgs e)
        {
            txtBox_idMoto_dueñoMoto.Text = "";
            txtBox_dueñoMoto.Text = "";
            txtBox_cédula_dueñoMoto.Text = "";
            txtBox_teléfono_dueñoMoto.Text = "";
            txtBox_email_dueñoMoto.Text = "";
            txtBox_modeloMoto_dueñoMoto.Text = "";
            txtBox_marcaMoto_dueñoMoto.Text = "";
            txtBox_añoMoto_dueñoMoto.Text = "";
            txtBox_estadoMoto_dueñoMoto.Text = "";
            txtBox_descripción_dueñoMoto.Text = "";
            txtBox_placaMoto_dueñoMoto.Text = "";
            txtBox_kilometraje_motoDueño.Text = "";
            txtBox_precio_motoDueño.Text = "";
            cBox_Valoracion_dueñoMoto.SelectedIndex = -1; 
            picBox_ventaCliente.Image = null;

            MessageBox.Show("Usted ha enviado correctamente la propuesta de venta de su moto. Espere la confirmación del Concesionario.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
