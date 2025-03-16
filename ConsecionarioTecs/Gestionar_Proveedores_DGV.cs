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
    public partial class Gestionar_Proveedores_DGV : Form
    {
        public Gestionar_Proveedores_DGV()
        {
            InitializeComponent();
        }
        Conexion_BDD conSQL = new Conexion_BDD();

        private void Gestionar_Proveedores_DGV_Load(object sender, EventArgs e)
        {
            dgv_Gestionar_Proveedor.DataSource = conSQL.retornaRegistros("SELECT * FROM Compra_Motos_Proveedores");

            dgv_Gestionar_Proveedor.Refresh();

        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {

            Compra_Proveedor C_Proveedor = new Compra_Proveedor(1);
            this.AddOwnedForm(C_Proveedor);
            pnl_btn_Nuevo_proveedor.Visible = true;
            AbrirEnPanelProveedor(new Compra_Proveedor());

        }
        private void AbrirEnPanelProveedor(Form formClientes)
        {
            if (this.pnl_btn_Nuevo_proveedor.Controls.Count > 0)
            {
                this.pnl_btn_Nuevo_proveedor.Controls.RemoveAt(0);
            }

            Form fn = formClientes as Form;
            if (fn != null)
            {
                fn.TopLevel = false;
                fn.FormBorderStyle = FormBorderStyle.None;
                fn.Dock = DockStyle.Fill;
                this.pnl_btn_Nuevo_proveedor.Controls.Add(fn);
                this.pnl_btn_Nuevo_proveedor.Tag = fn;
                fn.Show();
            }
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (dgv_Gestionar_Proveedor.RowCount > 0)
            {
                string idCompra = dgv_Gestionar_Proveedor[1, dgv_Gestionar_Proveedor.CurrentRow.Index].Value.ToString(); 
                DialogResult opc = MessageBox.Show(this,
                    "Se eliminará la fila " + dgv_Gestionar_Proveedor.CurrentRow.Index + ", que pertenece a la compra " + idCompra,
                    "Confirmación de Borrado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (opc == DialogResult.Yes)
                {
                    conSQL.eliminarDatos("Compra_Motos_Proveedores", "ID_Compra='" + idCompra + "'");
                    dgv_Gestionar_Proveedor.DataSource = conSQL.retornaRegistros("SELECT * FROM Compra_Motos_Proveedores");
                }
            }

        }

        private void tstFiltro_Click(object sender, EventArgs e)
        {
            dgv_Gestionar_Proveedor.DataSource = conSQL.retornaRegistros(
            "SELECT * FROM Compra_Motos_Proveedores " +
            "WHERE ID_Compra LIKE '%" + tstFiltro.Text + "%' " +
            "OR Nombre_Empresa LIKE '%" + tstFiltro.Text + "%' " +
            "OR Modelo_Moto LIKE '%" + tstFiltro.Text + "%'"
            );
        }

        private void tstFiltro_KeyUp(object sender, KeyEventArgs e)
        {
            if (tstFiltro.Text.Length > 2) 
            {
                dgv_Gestionar_Proveedor.DataSource = conSQL.retornaRegistros(
                    "SELECT * FROM Compra_Motos_Proveedores " +
                    "WHERE ID_Compra LIKE '%" + tstFiltro.Text + "%' " +
                    "OR Nombre_Empresa LIKE '%" + tstFiltro.Text + "%' " +
                    "OR Modelo_Moto LIKE '%" + tstFiltro.Text + "%'"
                );
            }

            if (string.IsNullOrWhiteSpace(tstFiltro.Text))
            {
                dgv_Gestionar_Proveedor.DataSource = conSQL.retornaRegistros("SELECT * FROM Compra_Motos_Proveedores");
            }
        }

        private void dgv_Gestionar_Proveedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
