using FormularioDeInicio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
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

                    // Insertar en la tabla Logins con el nombre del administrador
                    //string valoresLogin = "'" + txtNombreUsuario.Text + "','" + txtUsuarioAdmin.Text + "','" + txtContraseñaAdmin.Text + "','Administrador'";
                    //conSQL.insertarDatos("Logins", "Nombre,Usuario,Contraseña,Tipo_usuario", valoresLogin);
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

                    // También actualizar la contraseña en la tabla Logins si cambió
                    //string valoresActualizarLogin = "Contraseña='" + txtContraseñaUsuario.Text + "'";
                    //conSQL.actualizarDatos("Logins", valoresActualizarLogin, "Usuario='" + txtUsuarioUsu.Text + "'");
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

        private void AgregarAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
