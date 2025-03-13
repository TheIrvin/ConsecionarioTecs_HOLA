using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;

namespace ConsecionarioTecs
{
    public partial class MotoCata : UserControl
    {
        private int id;
        private string descripcion = "Descripción de la moto";
        public MotoCata()
        {
            InitializeComponent();
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        public Image ImgMoto
        {
            get { return ptbMotos.Image; }
            set { ptbMotos.Image = value; }
        }
        public string Modeloname
        {
            get { return lblModelo.Text; }
            set { lblModelo.Text = value; }
        }
        public string precio
        {
            get { return lblPrecio.Text; }
            set { lblPrecio.Text = value; }
        }

        



        private void panelControl_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
