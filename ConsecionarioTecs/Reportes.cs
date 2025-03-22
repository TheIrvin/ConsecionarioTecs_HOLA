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

namespace FormularioDeInicio
{
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
        }
        Conexion_BDD conSQL = new Conexion_BDD();

        private void lblEstadisticas1_Click(object sender, EventArgs e)
        {

        }

        private void lblxEst_Click(object sender, EventArgs e)
        {
            
        }

        private void Estadisticas_Load(object sender, EventArgs e)
        {
            dgv_enseñarVentas.DataSource = conSQL.retornaRegistros(@" Select * from Motos_Vendidas;");

            dgv_enseñarVentas.Refresh();

        }
    }
}
