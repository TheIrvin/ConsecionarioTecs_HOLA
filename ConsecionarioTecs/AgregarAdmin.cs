using FormularioDeInicio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsecionarioTecs
{
    public partial class AgregarAdmin : Form
    {
        Conexion_BDD conSQL = new Conexion_BDD();
        string cadena;
        int tipo; //tipo=1 entonces inserto datos, tipo=2 entonces modificar datos
        public AgregarAdmin(int t)
        {
            tipo = t;
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnGuardarAdmin_Click(object sender, EventArgs e)
        {
            Administradores frmAdmin = Owner as Administradores;
            switch (tipo)
            {
                case 1:
                    // Insertar en la tabla Usuarios
                    cadena = "'" + txtNombreUsuario.Text + "','" + txtEmail.Text + "','" +
                             txtSucursal.Text + "','"  + cboxPaisUsu.Text + "','" + txtCiudad.Text + "','" +
                             cboxCargo.Text + "','" + txtRegion.Text + "','" + txtTelefono.Text + "','" + txtUsuarioUsu.Text + "','" + txtContraseñaUsuario.Text + "'";

                    conSQL.insertarDatos("Usuarios",
                        "UsuarioNombre,Email,Sucursal,Pais,Ciudad,RolApp,Region,Telefono,[User],[Password]",
                        cadena);
                    break;

                case 2:
                    // Actualizar datos en la tabla Administradores
                    cadena = "UsuarioNombre='" + txtNombreUsuario.Text +
                             "', Email='" + txtEmail.Text +
                             "', Sucursal='" + txtSucursal.Text +
                             "', Pais='" + cboxPaisUsu.Text +
                             "', Ciudad='" + txtCiudad.Text +
                             "', RolApp='" + cboxCargo.Text +
                             "', Region='" + txtRegion.Text +
                             "', Telefono='" + txtTelefono.Text +
                             "', [User]='" + txtUsuarioUsu.Text +
                             "', [Password]='" + txtContraseñaUsuario.Text + "'";

                    conSQL.actualizarDatos("Usuarios", cadena, "UsuarioID='" + txtID.Text + "'");
                    break;
            }

            frmAdmin.dtgvContenedorUsuarios.DataSource = conSQL.retornaRegistros("SELECT * FROM Usuarios");
            this.Close();
        }

        private void btnCancelarAdmin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCerrarA_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelAggAdmin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtNombreUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsWhiteSpace(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;  // Si el caracter no es una letra ni un espacio, no lo deja escribir
            }
        }

        private void txtSucursal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsWhiteSpace(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtCiudad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsWhiteSpace(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtRegion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsWhiteSpace(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void AgregarAdmin_Load(object sender, EventArgs e)
        {
            txtNombreUsuario.KeyPress += new KeyPressEventHandler(txtNombreUsuario_KeyPress);
            txtSucursal.KeyPress += new KeyPressEventHandler(txtSucursal_KeyPress);
            txtCiudad.KeyPress += new KeyPressEventHandler(txtCiudad_KeyPress);
            txtRegion.KeyPress += new KeyPressEventHandler(txtRegion_KeyPress);
            txtTelefono.KeyPress += new KeyPressEventHandler(txtTelefono_KeyPress);

        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                txtEmail.BackColor = Color.White; // Restaura el color si está vacío
                return;
            }

            // Expresión regular para validar un correo electrónico
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(txtEmail.Text, emailPattern))
            {
                // Si no es válido, se pinta el campo de rosa y muestra el mensaje
                txtEmail.BackColor = Color.LightPink;
                MessageBox.Show("Ingrese un correo electrónico válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus(); // Regresa el foco al TextBox
            }
            else
            {
                // Si es válido, se restaura el color
                txtEmail.BackColor = Color.White;
            }
        }
    }
}
