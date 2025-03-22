using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsecionarioTecs
{
    public partial class notif_Clientes_Compra : Form
    {
        public notif_Clientes_Compra()
        {
            InitializeComponent();
        }
        Conexion_BDD conSQL = new Conexion_BDD();

        private void bt_evaluarMoto_ntf_clt_Click(object sender, EventArgs e)
        {
        }
        private void txtNombreC_TextChanged(object sender, EventArgs e)
        {

        }

        private void notif_Clientes_Compra_Load(object sender, EventArgs e)
        {


            dgv_verProveedor.DataSource = conSQL.retornaRegistros(@" Select * from Proveedor_info;");

            dgv_verProveedor.Refresh();
        }
    }
}
