using ConsecionarioTecs;
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

namespace FormularioDeInicio
{
    public partial class SoporteEmpleados : Form
    {
        Conexion_BDD conSQL = new Conexion_BDD();
        public SoporteEmpleados()
        {
            InitializeComponent();
            
        }
        private void SoporteEmpleados_Load(object sender, EventArgs e)
        {
            CargarMensajes();
        }

        private void CargarMensajes()
        {
            dgvSoporteE.DataSource = conSQL.retornaRegistros("SELECT * FROM SoporteMensajes");
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string mensaje = txtSoporteE.Text;
            string consulta = $"INSERT INTO SoporteMensajes (Mensaje, FechaEnvio) VALUES ('{mensaje}', GETDATE())";
            conSQL.ejecutarSQL(consulta);

            MessageBox.Show("Mensaje enviado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtSoporteE.Clear();
            CargarMensajes();
        }
    }
}
