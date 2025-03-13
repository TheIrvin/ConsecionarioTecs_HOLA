using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace FormularioDeInicio
{
    public partial class VistaCliente : Form
    {
        public VistaCliente()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnCerrarCliente_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizarCliente_Click(object sender, EventArgs e)
        {
            btnMaximizarCliente.Visible = false;
            btnRestaurarClientes.Visible = true;
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnRestaurarClientes_Click(object sender, EventArgs e)
        {
            btnRestaurarClientes.Visible = false;
            btnMaximizarCliente.Visible = true;
            this.WindowState = FormWindowState.Normal;
        }

        private void btnMinimizarCliente_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelCabeceraCliente_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void tmOcultarMenuCliente_Tick(object sender, EventArgs e)
        {
            if (panelMenuCliente.Width < 84)
            {
                this.tmOcultarMenuCliente.Enabled = false;
            }
            else
            {
                this.panelMenuCliente.Width = panelMenuCliente.Width - 20;
            }
        }

        private void tmMostrarMenuCliente_Tick(object sender, EventArgs e)
        {
            if (this.panelMenuCliente.Width >= 220)
            {
                this.tmMostrarMenuCliente.Enabled = false;
            }
            else
            {
                this.panelMenuCliente.Width = panelMenuCliente.Width + 20;
            }
        }

        private void btnMenuCliente_Click(object sender, EventArgs e)
        {
            if (panelMenuCliente.Width >= 220)
            {
                this.tmOcultarMenuCliente.Enabled = true;
            }
            else if (panelMenuCliente.Width <= 84)
            {
                this.tmMostrarMenuCliente.Enabled = true;
            }
        }

        private void btnCatalogoCliente_Click(object sender, EventArgs e)
        {
            AbrirEnPanelCliente(new CatalogoCliente());
        }

        private void btnComprasCliente_Click(object sender, EventArgs e)
        {
            AbrirEnPanelCliente(new Venta_Cliente());
        }

        private void btnSoporteCliente_Click(object sender, EventArgs e)
        {
            AbrirEnPanelCliente(new SoporteClientes());
        }

        private void AbrirEnPanelCliente(Form formClientes)
        {
            if (this.PanelContenedorCliente.Controls.Count > 0)
            {
                this.PanelContenedorCliente.Controls.RemoveAt(0);
            }

            Form fn = formClientes as Form;
            if (fn != null)
            {
                fn.TopLevel = false;
                fn.FormBorderStyle = FormBorderStyle.None;
                fn.Dock = DockStyle.Fill;
                this.PanelContenedorCliente.Controls.Add(fn);
                this.PanelContenedorCliente.Tag = fn;
                fn.Show();
            }
        }

        private void btnCerrarSesionAdmin_Click(object sender, EventArgs e)
        {
            this.Close();

            Application.OpenForms["Login"].Show();
        }
    }
}
