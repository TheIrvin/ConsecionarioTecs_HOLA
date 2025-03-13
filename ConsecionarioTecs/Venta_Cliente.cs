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
    }
}
