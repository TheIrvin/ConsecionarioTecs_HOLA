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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnCerrarApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            btnMaximizar.Visible= false;
            btnRestaurar.Visible = true;
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
            this.WindowState = FormWindowState.Normal;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelCabecera_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void tmOcultarMenu_Tick(object sender, EventArgs e)
        {
            if (panelMenu.Width<84)
            {
                this.tmOcultarMenu.Enabled = false;
            }
            else
            {
                this.panelMenu.Width = panelMenu.Width - 20;
            }
        }

        private void tmMostrarMenu_Tick(object sender, EventArgs e)
        {
            if (this.panelMenu.Width >= 220)
            {
                this.tmMostrarMenu.Enabled = false;
            }
            else
            {
                this.panelMenu.Width = panelMenu.Width + 20;
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (panelMenu.Width >= 220)
            {
                this.tmOcultarMenu.Enabled = true;
            }
            else if (panelMenu.Width <= 84)
            {
                this.tmMostrarMenu.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirEnPanel(new Estadisticas());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            AbrirEnPanel(new Clientes());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirEnPanel(new Compras());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirEnPanel(new Clientes());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirEnPanel(new Ventas());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AbrirEnPanel(new Productos());
        }
        private void AbrirEnPanel(Form formNij0)
        {
            if (this.PanelContenedor.Controls.Count > 0)
            {
                this.PanelContenedor.Controls.RemoveAt(0);
            }

            Form fn = formNij0 as Form;
            if (fn != null)
            {
                fn.TopLevel = false;
                fn.FormBorderStyle = FormBorderStyle.None;
                fn.Dock = DockStyle.Fill;
                this.PanelContenedor.Controls.Add(fn);
                this.PanelContenedor.Tag = fn;
                fn.Show();
            }
        }
    }
}
