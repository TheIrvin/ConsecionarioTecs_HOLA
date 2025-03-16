using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsecionarioTecs
{
    public partial class Compras_Menu : Form
    {
        public Compras_Menu()
        {
            InitializeComponent();
        }
        
        private void AbrirEnPanel(Form formNij0)
        {
            if (this.pnl_Compra_Menu.Controls.Count > 0)
            {
                this.pnl_Compra_Menu.Controls.RemoveAt(0);
            }

            Form fn = formNij0 as Form;
            if (fn != null)
            {
                fn.TopLevel = false;
                fn.FormBorderStyle = FormBorderStyle.None;
                fn.Dock = DockStyle.Fill;
                this.pnl_Compra_Menu.Controls.Add(fn);
                this.pnl_Compra_Menu.Tag = fn;
                fn.Show();
            }
        }
       

        private void visualizarProveedoreToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AbrirEnPanel(new Gestionar_Proveedores_DGV());

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirEnPanel(new notif_Clientes_Compra());
        }
    }
}
