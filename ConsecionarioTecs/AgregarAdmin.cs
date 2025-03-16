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
                    // Insertar en la tabla Administradores
                    cadena = "'" + txtNombreUsuario.Text + "','" + txtEmail.Text + "','" +
                             txtCiudad.Text + "','"  + txtRegion.Text + "','" + cboxPaisUsu.Text + "','" +
                             txtTelefono.Text + "','" + txtUsuarioAdmin.Text + "','" + txtContraseñaAdmin.Text + "','" + cboxCargo.Text + "','" + txtSucursal.Text + "'";

                    conSQL.insertarDatos("Administradores",
                        "UsuarioNombre,Email,Ciudad,Region,Pais,Telefono,[User],[Password],RolApp,Sucursal",
                        cadena);

                    // Insertar en la tabla Logins con el nombre del administrador
                    string valoresLogin = "'" + txtNombreUsuario.Text + "','" + txtUsuarioAdmin.Text + "','" + txtContraseñaAdmin.Text + "','Administrador'";
                    conSQL.insertarDatos("Logins", "Nombre,Usuario,Contraseña,Tipo_usuario", valoresLogin);
                    break;

                case 2:
                    // Actualizar datos en la tabla Administradores
                    cadena = "UsuarioNombre='" + txtNombreUsuario.Text +
                             "', Email='" + txtEmail.Text +
                             "', Ciudad='" + txtCiudad.Text +
                             "', Region='" + txtRegion.Text +
                             "', Pais='" + cboxPaisUsu.Text +
                             "', Telefono='" + txtTelefono.Text +
                             "', UsuarioAdmin='" + txtUsuarioAdmin.Text +
                             "', ContraseñaAdmin='" + txtContraseñaAdmin.Text +
                             "', Cargo='" + cboxCargo.Text +
                             "', Sucursal='" + txtSucursal.Text + "'";

                    conSQL.actualizarDatos("Administradores", cadena, "UsuarioID='" + txtID.Text + "'");

                    // También actualizar la contraseña en la tabla Logins si cambió
                    string valoresActualizarLogin = "Contraseña='" + txtContraseñaAdmin.Text + "'";
                    conSQL.actualizarDatos("Logins", valoresActualizarLogin, "Usuario='" + txtUsuarioAdmin.Text + "'");
                    break;
            }

            frmAdmin.dtgvContenedorUsuarios.DataSource = conSQL.retornaRegistros("SELECT * FROM Administradores");
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
