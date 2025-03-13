using ConsecionarioTecs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Reflection;

namespace FormularioDeInicio
{
    public partial class Administradores : Form
    {
        Conexion_BDD conSQL = new Conexion_BDD();
        int Bandera = 0;
        int ClientexPag = 40;
        public Administradores()
        {
            InitializeComponent();
        }

        private void Administradores_Load(object sender, EventArgs e)
        {
            dtgvContenedorAdministradores.DataSource = conSQL.retornaRegistros("Select * from Administradores");
        }

        private void tsbtnEliminarAdmin_Click(object sender, EventArgs e)
        {
            if (dtgvContenedorAdministradores.RowCount > 0)//Validar que tengo alguna fila seleccionada
            {
                DialogResult opc = MessageBox.Show(this, "Se eliminará la fila " + dtgvContenedorAdministradores.CurrentRow.Index + ", que pertenece al administrador " + dtgvContenedorAdministradores[0, dtgvContenedorAdministradores.CurrentRow.Index].Value.ToString(), "Confirmación de Borrado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (opc == DialogResult.Yes)
                {
                    conSQL.eliminarDatos("Administradores", "AdministradorID='" + dtgvContenedorAdministradores[0, dtgvContenedorAdministradores.CurrentRow.Index].Value.ToString() + "'");
                    dtgvContenedorAdministradores.DataSource = conSQL.retornaRegistros("Select * from Administradores");
                }
            }
        }

        private void tstxtFiltrarAdmin_KeyUp(object sender, KeyEventArgs e)
        {
            if (tstxtFiltrarAdmin.Text.Length > 4)
            {
                dtgvContenedorAdministradores.DataSource = conSQL.retornaRegistros("Select * from Administradores where AdministradorID like '%" + tstxtFiltrarAdmin.Text + "%' or NombreAdmin like '%" + tstxtFiltrarAdmin.Text + "%'");
            }

            if (tstxtFiltrarAdmin.Text.Length == 0)
                dtgvContenedorAdministradores.DataSource = conSQL.retornaRegistros("Select * from Administradores");
        }

        private void tsbtnFiltrarAdmin_Click(object sender, EventArgs e)
        {
            dtgvContenedorAdministradores.DataSource = conSQL.retornaRegistros("Select * from Administradores where AdministradorID like '%" + tstxtFiltrarAdmin.Text + "%' or NombreAdmin like '%" + tstxtFiltrarAdmin.Text + "%'");

        }

        private void tsbtnAgregarAdmin_Click(object sender, EventArgs e)
        {
            AgregarAdmin nuevoAdmin = new AgregarAdmin(1);
            nuevoAdmin.lblAggAdmin.Visible = true;
            nuevoAdmin.lblModificarAdmin.Visible = false;
            this.AddOwnedForm(nuevoAdmin);
            nuevoAdmin.Show();
        }

        private void tsBtnModificarAdmin_Click(object sender, EventArgs e)
        {
            AgregarAdmin modiAdmin = new AgregarAdmin(2);
            this.AddOwnedForm(modiAdmin);
            modiAdmin.lblAggAdmin.Visible = false;
            modiAdmin.lblModificarAdmin.Visible = true;
            modiAdmin.txtID.Text = dtgvContenedorAdministradores[0, dtgvContenedorAdministradores.CurrentRow.Index].Value.ToString();
            modiAdmin.txtNombreAdmin.Text = dtgvContenedorAdministradores[1, dtgvContenedorAdministradores.CurrentRow.Index].Value.ToString();
            modiAdmin.txtDireccion.Text = dtgvContenedorAdministradores[2, dtgvContenedorAdministradores.CurrentRow.Index].Value.ToString();
            modiAdmin.txtCiudad.Text = dtgvContenedorAdministradores[3, dtgvContenedorAdministradores.CurrentRow.Index].Value.ToString();
            modiAdmin.txtSucursal.Text = dtgvContenedorAdministradores[4, dtgvContenedorAdministradores.CurrentRow.Index].Value.ToString();
            modiAdmin.txtRegion.Text = dtgvContenedorAdministradores[5, dtgvContenedorAdministradores.CurrentRow.Index].Value.ToString();
            modiAdmin.txtPais.Text = dtgvContenedorAdministradores[6, dtgvContenedorAdministradores.CurrentRow.Index].Value.ToString();
            modiAdmin.txtTelefono.Text = dtgvContenedorAdministradores[7, dtgvContenedorAdministradores.CurrentRow.Index].Value.ToString();
            modiAdmin.txtCargo.Text = dtgvContenedorAdministradores[8, dtgvContenedorAdministradores.CurrentRow.Index].Value.ToString();
            modiAdmin.txtUsuarioAdmin.Text = dtgvContenedorAdministradores[9, dtgvContenedorAdministradores.CurrentRow.Index].Value.ToString();
            modiAdmin.txtContraseñaAdmin.Text = dtgvContenedorAdministradores[10, dtgvContenedorAdministradores.CurrentRow.Index].Value.ToString();
            modiAdmin.txtID.Enabled = false; //puedo cambiar lo que sea, menos el código y por eso está en false
            modiAdmin.Show();
        }

        private void tsbtnImprimirAdmin_Click(object sender, EventArgs e)
        {
            Bandera = 0;
            pdrImprimir = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            pdrImprimir.PrinterSettings = ps;
            pdrImprimir.PrintPage += Imprimir;
            pdrImprimir.Print();
        }
        private void Imprimir(object sender, PrintPageEventArgs e)
        {
            int y = 170;
            e.Graphics.DrawImage(imlImagenes.Images[0], new RectangleF(100, 0, imlImagenes.Images[0].Width / 2, imlImagenes.Images[0].Height / 2));
            Font fuente = new Font("Arial", 20, FontStyle.Bold);
            e.Graphics.DrawString("D'Ventas Cia Ltda", fuente, Brushes.BlueViolet, new RectangleF(300, 20, 300, 40));
            fuente = new Font("Arial", 16, FontStyle.Bold);
            e.Graphics.DrawString("Listado de Administradores", fuente, Brushes.Red, new RectangleF(300, 70, 300, 35));
            fuente = new Font("Arial", 12, FontStyle.Bold);

            e.Graphics.DrawString("Num.", fuente, Brushes.Black, new RectangleF(0, 140, 40, 20));
            e.Graphics.DrawString("Nombre", fuente, Brushes.Black, new RectangleF(50, 140, 150, 20));
            e.Graphics.DrawString("Dirección", fuente, Brushes.Black, new RectangleF(210, 140, 200, 20));
            e.Graphics.DrawString("Ciudad", fuente, Brushes.Black, new RectangleF(420, 140, 120, 20));
            e.Graphics.DrawString("Contacto", fuente, Brushes.Black, new RectangleF(550, 140, 100, 20));
            e.Graphics.DrawString("Región", fuente, Brushes.Black, new RectangleF(660, 140, 100, 20));
            e.Graphics.DrawString("País", fuente, Brushes.Black, new RectangleF(770, 140, 100, 20));
            e.Graphics.DrawString("Teléfono", fuente, Brushes.Black, new RectangleF(880, 140, 120, 20));
            e.Graphics.DrawString("Cargo", fuente, Brushes.Black, new RectangleF(1010, 140, 120, 20));
            e.Graphics.DrawString("Usuario", fuente, Brushes.Black, new RectangleF(1140, 140, 120, 20));
            e.Graphics.DrawString("Contraseña", fuente, Brushes.Black, new RectangleF(1270, 140, 150, 20));

            e.Graphics.DrawLine(new Pen(Color.Black, 1), 0, 160, 1430, 160);

            fuente = new Font("Arial", 12, FontStyle.Regular);
            Conexion_BDD sqlCon = new Conexion_BDD();
            string cadena = "SELECT NombreAdmin, Direccion, Ciudad, Contacto, Region, Pais, Telefono, Cargo, UsuarioAdmin, ContraseñaAdmin FROM Administradores";
            DataTable dt = sqlCon.retornaRegistros(cadena);

            for (int i = 0; Bandera < dt.Rows.Count && i < ClientexPag; i++, Bandera++)
            {
                e.Graphics.DrawString((Bandera + 1).ToString(), fuente, Brushes.Black, new RectangleF(0, y, 40, 20));
                e.Graphics.DrawString(dt.Rows[Bandera]["NombreAdmin"].ToString().Trim(), fuente, Brushes.Black, new RectangleF(50, y, 150, 20));
                e.Graphics.DrawString(dt.Rows[Bandera]["Direccion"].ToString().Trim(), fuente, Brushes.Black, new RectangleF(210, y, 200, 20));
                e.Graphics.DrawString(dt.Rows[Bandera]["Ciudad"].ToString().Trim(), fuente, Brushes.Black, new RectangleF(420, y, 120, 20));
                e.Graphics.DrawString(dt.Rows[Bandera]["Contacto"].ToString().Trim(), fuente, Brushes.Black, new RectangleF(550, y, 100, 20));
                e.Graphics.DrawString(dt.Rows[Bandera]["Region"].ToString().Trim(), fuente, Brushes.Black, new RectangleF(660, y, 100, 20));
                e.Graphics.DrawString(dt.Rows[Bandera]["Pais"].ToString().Trim(), fuente, Brushes.Black, new RectangleF(770, y, 100, 20));
                e.Graphics.DrawString(dt.Rows[Bandera]["Telefono"].ToString().Trim(), fuente, Brushes.Black, new RectangleF(880, y, 120, 20));
                e.Graphics.DrawString(dt.Rows[Bandera]["Cargo"].ToString().Trim(), fuente, Brushes.Black, new RectangleF(1010, y, 120, 20));
                e.Graphics.DrawString(dt.Rows[Bandera]["UsuarioAdmin"].ToString().Trim(), fuente, Brushes.Black, new RectangleF(1140, y, 120, 20));
                e.Graphics.DrawString(dt.Rows[Bandera]["ContraseñaAdmin"].ToString().Trim(), fuente, Brushes.Black, new RectangleF(1270, y, 150, 20));

                y += 20;
            }
            e.HasMorePages = Bandera < dt.Rows.Count;
        }

    }
}
