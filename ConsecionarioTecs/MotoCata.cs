using FormularioDeInicio;
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
            get { return txtBox_DescripcionMC.Text; }
            set { txtBox_DescripcionMC.Text = value; }
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

        private void lblModelo_Click(object sender, EventArgs e)
        {

        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            CatalogoCliente form4 = new CatalogoCliente();
            form4.Show();

            AbrirEnPanel(new CatalogoCliente());
        }
        public Panel pnl_AbrirCtgEmpld;
        private void AbrirEnPanel(Form formNij0)
        {
            if (this.pnl_AbrirCtgEmpld.Controls.Count > 0)
            {
                this.pnl_AbrirCtgEmpld.Controls.RemoveAt(0);
            }

            Form fn = formNij0 as Form;
            if (fn != null)
            {
                fn.TopLevel = false;
                fn.FormBorderStyle = FormBorderStyle.None;
                fn.Dock = DockStyle.Fill;
                this.pnl_AbrirCtgEmpld.Controls.Add(fn);
                this.pnl_AbrirCtgEmpld.Tag = fn;
                fn.Show();
            }
        }
    }
}
