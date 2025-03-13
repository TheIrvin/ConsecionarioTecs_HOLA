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
using FormularioDeInicio;
using System.Data.SqlClient;

namespace ConsecionarioTecs
{
    public partial class Login : Form
    {
        string connectionString = "Server=ALXJANDR07\\SQLEXPRESS;Database=CompañiaTecsBDD;User id=AleAdmin;Password=luis;";
        public Login()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text=="USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.Black;
            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "CONTRASEÑA")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.Black;
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "CONTRASEÑA";
                txtContraseña.ForeColor = Color.Black;
                txtContraseña.UseSystemPasswordChar = false;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string contrasena = txtContraseña.Text.Trim();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string queryAdmin = "SELECT * FROM Administradores WHERE UsuarioAdmin = @usuario AND ContraseñaAdmin = @contrasena";
                string queryCliente = "SELECT * FROM Clientes WHERE LoginUsuario = @usuario AND LoginContraseña = @contrasena";

                SqlCommand cmdAdmin = new SqlCommand(queryAdmin, conn);
                SqlCommand cmdCliente = new SqlCommand(queryCliente, conn);

                cmdAdmin.Parameters.AddWithValue("@usuario", usuario);
                cmdAdmin.Parameters.AddWithValue("@contrasena", contrasena);

                cmdCliente.Parameters.AddWithValue("@usuario", usuario);
                cmdCliente.Parameters.AddWithValue("@contrasena", contrasena);

                try
                {
                    conn.Open();

                    SqlDataReader readerAdmin = cmdAdmin.ExecuteReader();

                    if (readerAdmin.Read())
                    {
                        MessageBox.Show("¡Bienvenido Administrador!");
                        this.Hide();
                        MenuAdmin adminForm = new MenuAdmin();
                        adminForm.Show();
                        return;
                    }

                    readerAdmin.Close();

                    SqlDataReader readerCliente = cmdCliente.ExecuteReader();

                    if (readerCliente.Read())
                    {
                        MessageBox.Show("¡Bienvenido Cliente!");
                        this.Hide();
                        VistaCliente clienteForm = new VistaCliente();
                        clienteForm.Show();
                        return;
                    }

                    readerCliente.Close();

                    MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error en la conexión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

            //string usuario = txtUsuario.Text;
            //string contraseña = txtContraseña.Text;

            //if (usuario == "admin" && contraseña == "1234")
            //{
            //    MessageBox.Show("Acceso concedido","Exito", MessageBoxButtons.OK,MessageBoxIcon.Information);
            //    MenuAdmin adminForm = new MenuAdmin();
            //    adminForm.Show();
            //    this.Hide();
            //}
            //else if (usuario=="cliente" && contraseña == "5678")
            //{
            //    MessageBox.Show("Bienvenido a Tecs", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    VistaCliente ClienteForm = new VistaCliente();
            //    ClienteForm.Show();
            //    this.Hide();
            //}

            //else
            //{
            //    MessageBox.Show("Usuario o Contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

        private void btnCerrarLogin_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas salir?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Application.Exit(); // Cierra toda la aplicación si el usuario confirma
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
