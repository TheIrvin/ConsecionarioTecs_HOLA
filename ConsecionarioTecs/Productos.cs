using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsecionarioTecs;

namespace FormularioDeInicio
{
    public partial class Productos : Form
    {

        public Productos()
        {
            InitializeComponent();
            LlenarProductos();
        }
        private void LlenarProductos()
        {
            DBMotos obj = new DBMotos();
            obj.llenarBotones(FlpContenedorMotos);

        }

        private void tsbtnAgregarVentas_Click(object sender, EventArgs e)
        {
            AgregarMoto fmMoto = new AgregarMoto();
            fmMoto.lblAggMoto.Visible = true;
            fmMoto.lblModiMoto.Visible = false;
            this.AddOwnedForm(fmMoto);
            fmMoto.Show();
        }

        private void tsbtnModificarVenta_Click(object sender, EventArgs e)
        {
            //if (panelSeleccionado == null)
            //{
            //    MessageBox.Show("Seleccione una moto antes de modificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            //// Obtener los controles dentro del panel seleccionado
            //Label lblModelo = panelSeleccionado.Controls.OfType<Label>().FirstOrDefault(l => l.Name == "lblModelo");
            //Label lblDescripcion = panelSeleccionado.Controls.OfType<Label>().FirstOrDefault(l => l.Name == "lblDescripcion");
            //Label lblPrecio = panelSeleccionado.Controls.OfType<Label>().FirstOrDefault(l => l.Name == "lblPrecio");
            //Label lblValoracion = panelSeleccionado.Controls.OfType<Label>().FirstOrDefault(l => l.Name == "lblValoracion");
            //PictureBox pbMoto = panelSeleccionado.Controls.OfType<PictureBox>().FirstOrDefault();

            AgregarMoto fmEdiMoto = new AgregarMoto();
            fmEdiMoto.lblAggMoto.Visible = false;
            fmEdiMoto.lblModiMoto.Visible = true;
            this.AddOwnedForm(fmEdiMoto);
            fmEdiMoto.Show();
        }
    }
}
