using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsecionarioTecs;

namespace FormularioDeInicio
{
    public partial class CatalogoCliente : Form
    {
        public CatalogoCliente()
        {
            InitializeComponent();
            LlenarProductos();
        }

        private void AbrirEnPanel(Form formNij0)
        {
            if (this.pnl_EnseñarFACT.Controls.Count > 0)
            {
                this.pnl_EnseñarFACT.Controls.RemoveAt(0);
            }

            Form fn = formNij0 as Form;
            if (fn != null)
            {
                fn.TopLevel = false;
                fn.FormBorderStyle = FormBorderStyle.None;
                fn.Dock = DockStyle.Fill;
                this.pnl_EnseñarFACT.Controls.Add(fn);
                this.pnl_EnseñarFACT.Tag = fn;
                fn.Show();
            }
        }

        private void LlenarProductos()
        {
            DBMotos obj = new DBMotos();
            obj.llenarBotones(flpMotosUsuario);

        }


        private void lblxCatalogoClientes_Click(object sender, EventArgs e)
        {
            
        }

        private void panelCatalogoMotos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {

        }

        private void panelContenedorCatalogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CatalogoCliente_Load(object sender, EventArgs e)
        {

        }

        private void btn_EnseñarFactura_Click(object sender, EventArgs e)
        {
            pnl_EnseñarFACT.Visible = true;
            AbrirEnPanel(new FactTarjeta());
        }
    }
}
