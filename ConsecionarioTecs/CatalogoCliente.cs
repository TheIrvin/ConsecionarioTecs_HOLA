using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsecionarioTecs;

namespace FormularioDeInicio
{
    public partial class CatalogoCliente : Form
    {
        public CatalogoCliente()
        {
            InitializeComponent();
            LlenarProductos();
        }
        private void LlenarProductos()
        {
            DBMotos obj = new DBMotos();
            obj.llenarBotones(flpMotosUsuario);

        }


        private void lblxCatalogoClientes_Click(object sender, EventArgs e)
        {
            
        }

        private void panelCatalogoMotos_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
