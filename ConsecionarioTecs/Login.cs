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
        string connectionString = "Server=DESKTOP-9SMDLH8\\SQLEXPRESS;Database=CompañiaTecsBDD;User id=AccesoChari;Password=accesochari;";
        bool mostrandoContraseña = false;
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
                txtContraseña.UseSystemPasswordChar = !mostrandoContraseña;
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "CONTRASEÑA";
                txtContraseña.ForeColor = Color.Black;
                txtContraseña.UseSystemPasswordChar = false;
                pbVerContraseña.Image = Properties.Resources.ojo_abierto;
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
                string query = "SELECT RolApp FROM Usuarios WHERE [User] = @usuario AND [Password] = @contrasena";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@contrasena", contrasena);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read()) // Si hay coincidencia
                    {
                        string rol = reader["RolApp"].ToString();
                        reader.Close(); // Cerrar reader antes de abrir el nuevo formulario

                        if (rol == "Administrador")
                        {
                            MessageBox.Show("¡Bienvenido Administrador!");
                            this.Hide();
                            MenuAdmin adminfrm = new MenuAdmin();
                            adminfrm.Show();
                        }
                        else if (rol == "Empleado")
                        {
                            MessageBox.Show("¡Bienvenido Empleado!");
                            this.Hide();
                            VistaCliente empleadoForm = new VistaCliente();
                            empleadoForm.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    reader.Close(); // Asegurar que siempre se cierre
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

        private void pbVerContraseña_Click(object sender, EventArgs e)
        {
            if (txtContraseña.Text != "" && txtContraseña.Text != "CONTRASEÑA")
            {
                mostrandoContraseña = !mostrandoContraseña;

                txtContraseña.UseSystemPasswordChar = !mostrandoContraseña; // Alternar estado

                if (mostrandoContraseña)
                {
                    pbVerContraseña.Image = Properties.Resources.ojo_cerrado; // Ojo cerrado = contraseña visible
                }
                else
                {
                    pbVerContraseña.Image = Properties.Resources.ojo_abierto; // Ojo abierto = contraseña oculta
                }
            }
        }
    }
}
