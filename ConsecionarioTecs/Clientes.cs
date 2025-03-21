using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsecionarioTecs;

namespace FormularioDeInicio
{
    public partial class Clientes : Form
    {
        Conexion_BDD conSQL = new Conexion_BDD();
        int Bandera = 0;
        int ClientexPag = 40;
        private Form formActivo = null;
        public Clientes()
        {
            InitializeComponent();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            dtgvContenedorClientes.DataSource = conSQL.retornaRegistros("Select * from Clientes");
        }

        private void tsbtnEliminar_Click(object sender, EventArgs e)
        {
            if (dtgvContenedorClientes.RowCount > 0)
            {
                DialogResult opc = MessageBox.Show(this, "Se eliminará la fila " + dtgvContenedorClientes.CurrentRow.Index + ", que pertenece al cliente " + dtgvContenedorClientes[0, dtgvContenedorClientes.CurrentRow.Index].Value.ToString(), "Confirmación de Borrado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (opc == DialogResult.Yes)
                {
                    conSQL.eliminarDatos("Clientes", "ClienteID='" + dtgvContenedorClientes[0, dtgvContenedorClientes.CurrentRow.Index].Value.ToString() + "'");
                    dtgvContenedorClientes.DataSource = conSQL.retornaRegistros("Select * from Clientes");
                }
            }
        }

        private void tstxtFiltrarCliente_KeyUp(object sender, KeyEventArgs e)
        {
            if (tstxtFiltrarCliente.Text.Length > 4)
            {
                dtgvContenedorClientes.DataSource = conSQL.retornaRegistros("Select * from Clientes where ClienteID like '%" + tstxtFiltrarCliente.Text + "%' or NombreCliente like '%" + tstxtFiltrarCliente.Text + "%'");
            }

            if (tstxtFiltrarCliente.Text.Length == 0)
                dtgvContenedorClientes.DataSource = conSQL.retornaRegistros("Select * from Clientes");
        }

        private void tsbtnFiltrarCliente_Click(object sender, EventArgs e)
        {
            dtgvContenedorClientes.DataSource = conSQL.retornaRegistros("Select * from Clientes where ClienteID like '%" + tstxtFiltrarCliente.Text + "%' or NombreCliente like '%" + tstxtFiltrarCliente.Text + "%'");
        }

        private void tsbtnAgregarCliente_Click(object sender, EventArgs e)
        {
            AbrirFormularioUnico(new frmNc(1, this));
            //frmNc nuevoCliente = new frmNc(1);
            //nuevoCliente.lblAgregarClientes.Visible = true;
            //nuevoCliente.lblModificarCliente.Visible = false;
            //this.AddOwnedForm(nuevoCliente);
            //nuevoCliente.Show();
        }

        private void tsBtnModificarCliente_Click(object sender, EventArgs e)
        {
            if (dtgvContenedorClientes.RowCount > 0)
            {
                frmNc modiC = new frmNc(2, this);
                modiC.lblAgregarClientes.Visible = false;
                modiC.lblModificarCliente.Visible = true;
                modiC.txtIDc.Text = dtgvContenedorClientes[0, dtgvContenedorClientes.CurrentRow.Index].Value.ToString();
                modiC.txtNombreC.Text = dtgvContenedorClientes[1, dtgvContenedorClientes.CurrentRow.Index].Value.ToString();
                modiC.txtCompañiaC.Text = dtgvContenedorClientes[2, dtgvContenedorClientes.CurrentRow.Index].Value.ToString();
                modiC.txtTituloC.Text = dtgvContenedorClientes[3, dtgvContenedorClientes.CurrentRow.Index].Value.ToString();
                modiC.txtDireccionC.Text = dtgvContenedorClientes[4, dtgvContenedorClientes.CurrentRow.Index].Value.ToString();
                modiC.txtCiudadC.Text = dtgvContenedorClientes[5, dtgvContenedorClientes.CurrentRow.Index].Value.ToString();
                modiC.txtRegionC.Text = dtgvContenedorClientes[6, dtgvContenedorClientes.CurrentRow.Index].Value.ToString();
                modiC.cboxPais.Text = dtgvContenedorClientes[7, dtgvContenedorClientes.CurrentRow.Index].Value.ToString();
                modiC.txtTelefonoC.Text = dtgvContenedorClientes[8, dtgvContenedorClientes.CurrentRow.Index].Value.ToString();
                modiC.txtEmailCli.Text = dtgvContenedorClientes[9, dtgvContenedorClientes.CurrentRow.Index].Value.ToString();
                modiC.mFechaRegistroC.Text = dtgvContenedorClientes[10, dtgvContenedorClientes.CurrentRow.Index].Value.ToString();
                modiC.cboxEstadoCli.Text = dtgvContenedorClientes[11, dtgvContenedorClientes.CurrentRow.Index].Value.ToString();
                modiC.txtCedulaCli.Text = dtgvContenedorClientes[12, dtgvContenedorClientes.CurrentRow.Index].Value.ToString();
                modiC.txtIDc.Enabled = false; //puedo cambiar lo que sea, menos el código y por eso está en false

                AbrirFormularioUnico(modiC);
            }

            //frmNc modiC = new frmNc(2);
            //this.AddOwnedForm(modiC);
            //modiC.lblAgregarClientes.Visible = false;
            //modiC.lblModificarCliente.Visible = true;
            //modiC.txtIDc.Text = dtgvContenedorClientes[0, dtgvContenedorClientes.CurrentRow.Index].Value.ToString();
            //modiC.txtNombreC.Text = dtgvContenedorClientes[1, dtgvContenedorClientes.CurrentRow.Index].Value.ToString();
            //modiC.txtCompañiaC.Text = dtgvContenedorClientes[2, dtgvContenedorClientes.CurrentRow.Index].Value.ToString();
            //modiC.txtTituloC.Text = dtgvContenedorClientes[3, dtgvContenedorClientes.CurrentRow.Index].Value.ToString();
            //modiC.txtDireccionC.Text = dtgvContenedorClientes[4, dtgvContenedorClientes.CurrentRow.Index].Value.ToString();
            //modiC.txtCiudadC.Text = dtgvContenedorClientes[5, dtgvContenedorClientes.CurrentRow.Index].Value.ToString();
            //modiC.txtRegionC.Text = dtgvContenedorClientes[6, dtgvContenedorClientes.CurrentRow.Index].Value.ToString();
            //modiC.cboxPais.Text = dtgvContenedorClientes[7, dtgvContenedorClientes.CurrentRow.Index].Value.ToString();
            //modiC.txtTelefonoC.Text = dtgvContenedorClientes[8, dtgvContenedorClientes.CurrentRow.Index].Value.ToString();
            //modiC.txtEmailCli.Text = dtgvContenedorClientes[9, dtgvContenedorClientes.CurrentRow.Index].Value.ToString();
            //modiC.mFechaRegistroC.Text = dtgvContenedorClientes[10, dtgvContenedorClientes.CurrentRow.Index].Value.ToString();
            //modiC.cboxEstadoCli.Text = dtgvContenedorClientes[11, dtgvContenedorClientes.CurrentRow.Index].Value.ToString();
            //modiC.txtCedulaCli.Text = dtgvContenedorClientes[12, dtgvContenedorClientes.CurrentRow.Index].Value.ToString();
            //modiC.txtIDc.Enabled = false; //puedo cambiar lo que sea, menos el código y por eso está en false
            //modiC.Show();
        }

        private void tsbtnImprimir_Click(object sender, EventArgs e)
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
            e.Graphics.DrawString("Listado de Clientes", fuente, Brushes.Red, new RectangleF(300, 70, 300, 35));
            fuente = new Font("Arial", 12, FontStyle.Bold);

            e.Graphics.DrawString("Num.", fuente, Brushes.Black, new RectangleF(0, 140, 40, 20));
            e.Graphics.DrawString("ID", fuente, Brushes.Black, new RectangleF(41, 140, 50, 20));
            e.Graphics.DrawString("Nombre", fuente, Brushes.Black, new RectangleF(92, 140, 150, 20));
            e.Graphics.DrawString("Empresa", fuente, Brushes.Black, new RectangleF(243, 140, 150, 20));
            e.Graphics.DrawString("Título", fuente, Brushes.Black, new RectangleF(394, 140, 120, 20));
            e.Graphics.DrawString("Dirección", fuente, Brushes.Black, new RectangleF(515, 140, 150, 20));
            e.Graphics.DrawString("Ciudad", fuente, Brushes.Black, new RectangleF(666, 140, 100, 20));
            e.Graphics.DrawLine(new Pen(Color.Black, 1), 0, 160, 800, 160);

            fuente = new Font("Arial", 12, FontStyle.Regular);
            Conexion_BDD sqlCon = new Conexion_BDD();
            string cadena = "SELECT [ClienteID], [NombreCliente], [EmpresaCliente], [TituloCliente], [Dirección], [Ciudad], [Región], [País], [Teléfono] FROM Clientes";
            DataTable dt = sqlCon.retornaRegistros(cadena);

            for (int i = 0; Bandera < dt.Rows.Count && i < ClientexPag; i++, Bandera++)
            {
                e.Graphics.DrawString((Bandera + 1).ToString(), fuente, Brushes.Black, new RectangleF(0, y, 40, 20));
                e.Graphics.DrawString(dt.Rows[Bandera]["ClienteID"].ToString().Trim(), fuente, Brushes.Black, new RectangleF(41, y, 50, 20));
                e.Graphics.DrawString(dt.Rows[Bandera]["NombreCliente"].ToString().Trim(), fuente, Brushes.Black, new RectangleF(92, y, 150, 20));
                e.Graphics.DrawString(dt.Rows[Bandera]["EmpresaCliente"].ToString().Trim(), fuente, Brushes.Black, new RectangleF(243, y, 150, 20));
                e.Graphics.DrawString(dt.Rows[Bandera]["TituloCliente"].ToString().Trim(), fuente, Brushes.Black, new RectangleF(394, y, 120, 20));
                e.Graphics.DrawString(dt.Rows[Bandera]["Dirección"].ToString().Trim(), fuente, Brushes.Black, new RectangleF(515, y, 150, 20));
                e.Graphics.DrawString(dt.Rows[Bandera]["Ciudad"].ToString().Trim(), fuente, Brushes.Black, new RectangleF(666, y, 100, 20));
                e.Graphics.DrawString(dt.Rows[Bandera]["Región"].ToString().Trim(), fuente, Brushes.Black, new RectangleF(767, y, 100, 20));
                e.Graphics.DrawString(dt.Rows[Bandera]["País"].ToString().Trim(), fuente, Brushes.Black, new RectangleF(868, y, 100, 20));
                e.Graphics.DrawString(dt.Rows[Bandera]["Teléfono"].ToString().Trim(), fuente, Brushes.Black, new RectangleF(969, y, 120, 20));

                y += 20;
            }
            e.HasMorePages = Bandera < dt.Rows.Count;
        }

        private void AbrirFormularioUnico(Form formHijo)
        {
            // Si ya hay un formulario abierto, lo cerramos antes de abrir uno nuevo
            if (formActivo != null)
            {
                formActivo.Close();
            }

            formActivo = formHijo; // Asignamos el nuevo formulario
            formHijo.FormClosed += (s, e) => formActivo = null; // Liberamos la variable cuando se cierra

            formHijo.StartPosition = FormStartPosition.CenterParent; // Centrado en la pantalla
            formHijo.ShowDialog(); // Abre el formulario como modal para evitar múltiples aperturas
        }

    }
}
