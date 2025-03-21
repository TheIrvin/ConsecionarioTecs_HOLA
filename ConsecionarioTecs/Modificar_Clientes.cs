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
using FormularioDeInicio;

namespace ConsecionarioTecs
{
    public partial class frmNc : Form
    {
        Conexion_BDD conSQL = new Conexion_BDD();
        string cadena;
        int tipo; //tipo=1 entonces inserto datos, tipo=2 entonces modificar datos
        private Clientes clientesForm;

        public frmNc(int t, Clientes clientesForm)
        {
            tipo = t;
            InitializeComponent();
            this.clientesForm = clientesForm;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            //Clientes frmCliente = Owner as Clientes;
            switch (tipo)
            {
                case 1:
                    // Insertar en la tabla Clientes
                    cadena = "'" + txtNombreC.Text + "','" + txtCompañiaC.Text + "','" +
                             txtTituloC.Text + "','" + txtDireccionC.Text + "','" + txtCiudadC.Text + "','" + txtRegionC.Text + "','" +
                             cboxPais.Text + "','" + txtTelefonoC.Text + "','" + txtEmailCli.Text + "','" + mFechaRegistroC.Text + "','" +
                             cboxEstadoCli.Text + "','" + txtCedulaCli.Text + "'";

                    // Ejecutamos la consulta para insertar
                    conSQL.insertarDatos("Clientes",
                        "NombreCliente,EmpresaCliente,TituloCliente,Dirección,Ciudad,Región,País,Teléfono,Email,FechaRegistro,EstadoCliente,Cedula",
                        cadena);

                    break;

                case 2:
                    // Actualizar datos en la tabla Clientes
                    cadena = "NombreCliente='" + txtNombreC.Text +
                             "', EmpresaCliente='" + txtCompañiaC.Text +
                             "', TituloCliente='" + txtTituloC.Text +
                             "', Dirección='" + txtDireccionC.Text +
                             "', Ciudad='" + txtCiudadC.Text +
                             "', Región='" + txtRegionC.Text +
                             "', País='" + cboxPais.Text +
                             "', Teléfono='" + txtTelefonoC.Text +
                             "', Email='" + txtEmailCli.Text +
                             "', FechaRegistro='" + mFechaRegistroC.Text +
                             "', EstadoCliente='" + cboxEstadoCli.Text +
                             "', Cedula='" + txtCedulaCli.Text + "'";

                    // Ejecutamos la consulta para actualizar
                    conSQL.actualizarDatos("Clientes", cadena, "ClienteID='" + txtIDc.Text + "'");

                    break;
            }

            // Actualizamos el DataGridView
            //frmCliente.dtgvContenedorClientes.DataSource = conSQL.retornaRegistros("SELECT * FROM Clientes");
            //this.Close();

            if (clientesForm != null)
            {
                clientesForm.dtgvContenedorClientes.DataSource = conSQL.retornaRegistros("SELECT * FROM Clientes");
            }

            LimpiarCampos();
            MessageBox.Show("Cliente agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LimpiarCampos()
        {
            txtIDc.Clear();
            txtNombreC.Clear();
            txtCompañiaC.Clear();
            txtTituloC.Clear();
            txtDireccionC.Clear();
            txtCiudadC.Clear();
            txtRegionC.Clear();
            cboxPais.SelectedIndex = -1;
            txtTelefonoC.Clear();
            txtEmailCli.Clear();
            mFechaRegistroC.Clear();
            cboxEstadoCli.SelectedIndex = -1;
            txtCedulaCli.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrarAggC_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelarC_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelModificarC_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtNombreC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsWhiteSpace(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;  // Si el caracter no es una letra ni un espacio, no lo deja escribir
            }
        }

        private void txtCompañiaC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsWhiteSpace(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;  // Si el caracter no es una letra ni un espacio, no lo deja escribir
            }
        }

        private void txtTituloC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsWhiteSpace(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;  // Si el caracter no es una letra ni un espacio, no lo deja escribir
            }
        }

        private void txtDireccionC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetterOrDigit(e.KeyChar) && !Char.IsWhiteSpace(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.' && e.KeyChar != '-' && e.KeyChar != '#' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtRegionC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsWhiteSpace(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtCiudadC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsWhiteSpace(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtTelefonoC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtCedulaCli_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void frmNc_Load(object sender, EventArgs e)
        {
            txtNombreC.KeyPress += new KeyPressEventHandler(txtNombreC_KeyPress);
            txtCompañiaC.KeyPress += new KeyPressEventHandler(txtCompañiaC_KeyPress);
            txtTituloC.KeyPress += new KeyPressEventHandler(txtTituloC_KeyPress);
            txtDireccionC.KeyPress += new KeyPressEventHandler(txtDireccionC_KeyPress);
            txtCiudadC.KeyPress += new KeyPressEventHandler(txtCiudadC_KeyPress);
            txtRegionC.KeyPress += new KeyPressEventHandler(txtRegionC_KeyPress);
            txtTelefonoC.KeyPress += new KeyPressEventHandler(txtTelefonoC_KeyPress);
            txtCedulaCli.KeyPress += new KeyPressEventHandler(txtCedulaCli_KeyPress);

        }

        private void txtEmailCli_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmailCli.Text))
            {
                txtEmailCli.BackColor = Color.White; // Restaura el color si está vacío
                return;
            }

            // Expresión regular para validar un correo electrónico
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(txtEmailCli.Text, emailPattern))
            {
                // Si no es válido, se pinta el campo de rosa y muestra el mensaje
                txtEmailCli.BackColor = Color.LightPink;
                MessageBox.Show("Ingrese un correo electrónico válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmailCli.Focus(); // Regresa el foco al TextBox
            }
            else
            {
                // Si es válido, se restaura el color
                txtEmailCli.BackColor = Color.White;
            }
        }
    }
}
