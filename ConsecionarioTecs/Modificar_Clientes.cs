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
using FormularioDeInicio;

namespace ConsecionarioTecs
{
    public partial class frmNc : Form
    {
        Conexion_BDD conSQL = new Conexion_BDD();
        string cadena;
        int tipo; 
        public frmNc(int t)
        {
            tipo = t;
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            Clientes frmCliente = Owner as Clientes;
            switch (tipo)
            {
                case 1:
                    cadena = "'" + txtNombreC.Text + "','" +
                             txtTituloC.Text + "','" + txtDireccionC.Text + "','" + cboCiudadC.Text + "','"  +
                             cboxPais.Text + "','" + txtTelefonoC.Text + "','" + txtEmailCli.Text + "','" + mFechaRegistroC.Text + "'" + txtCedulaCli.Text + "'";

                    conSQL.insertarDatos("Clientes",
                        "NombreCliente,TituloCliente,Dirección,Ciudad,País,Teléfono,Email,FechaRegistro,Cedula",
                        cadena);

                    break;

                case 2:
                    cadena = "NombreCliente='" + txtNombreC.Text +
                             "', TituloCliente='" + txtTituloC.Text +
                             "', Dirección='" + txtDireccionC.Text +
                             "', Ciudad='" + cboCiudadC.Text +
                             "', País='" + cboxPais.Text +
                             "', Teléfono='" + txtTelefonoC.Text +
                             "', Email='" + txtEmailCli.Text +
                             "', FechaRegistro='" + mFechaRegistroC.Text +
                             "', Cedula='" + txtCedulaCli.Text + "'";

                    conSQL.actualizarDatos("Clientes", cadena, "ClienteID='" + txtIDc.Text + "'");

                    break;
            }

            frmCliente.dtgvContenedorClientes.DataSource = conSQL.retornaRegistros("SELECT * FROM Clientes");
            this.Close();


            
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

        private void panelModificarC_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtCiudadC1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIDc_TextChanged(object sender, EventArgs e)
        {
            string idMoto = txtIDc.Text.Trim();

            if (idMoto.Length == 1)
            {
                ProeevInfo_MotoComp_a_Enseñar Enviar = new ProeevInfo_MotoComp_a_Enseñar(conSQL);

                if (Enviar.idMotoVF(idMoto))
                {
                    MessageBox.Show("El ID del Cliente ya está registrado. Ingrese un ID diferente.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    txtIDc.Focus(); 
                    txtIDc.SelectAll(); 
                }
            }
        }
    }
}
