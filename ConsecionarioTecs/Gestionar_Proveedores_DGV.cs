using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            pnl_EnseñarFoto_gestion_Provee.Visible = false;

            dgv_Gestionar_Proveedor.DataSource = conSQL.retornaRegistros(@" Select * from Moto_Compra;");

            dgv_Gestionar_Proveedor.Refresh();


        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            pnl_btn_Nuevo_proveedor.Visible = true;

            // ✅ Pasamos "this" como referencia del formulario principal
            Compra_Proveedor C_Proveedor = new Compra_Proveedor(1, this);

            // ✅ Llamamos al método que abre en el panel
            AbrirEnPanelProveedor(C_Proveedor);

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
                string idCompra = dgv_Gestionar_Proveedor.CurrentRow.Cells["ID_Compra"].Value.ToString();

                DialogResult opc = MessageBox.Show(this,
                    $"Se eliminará la compra {idCompra}. ¿Desea continuar?",
                    "Confirmación de Borrado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (opc == DialogResult.Yes)
                {
                    if (conSQL.eliminarDatos("Compra_Motos_Proveedores", "ID_Compra='" + idCompra + "'"))
                    {
                        dgv_Gestionar_Proveedor.DataSource = conSQL.retornaRegistros("SELECT * FROM Compra_Motos_Proveedores");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el registro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay filas seleccionadas.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void tstFiltro_Click(object sender, EventArgs e)
        {
            dgv_Gestionar_Proveedor.DataSource = conSQL.retornaRegistros(@"
             SELECT mc.ID_Moto, p.Nombre_Empresa, p.RUC_Empresa, mc.Modelo_Moto, mc.Marca_Moto, 
               mc.Año_Moto, mc.Valoración, mc.Precio_Moto, mc.Stock  
               FROM Moto_Compra mc
        INNER JOIN Proveedor_info p ON mc.ID_Proveedor = p.ID_Proveedor
        WHERE mc.ID_Moto LIKE '%" + tstFiltro.Text + "%' " +
           "OR p.Nombre_Empresa LIKE '%" + tstFiltro.Text + "%' " +
           "OR mc.Modelo_Moto LIKE '%" + tstFiltro.Text + "%'"
            );
        }

        private void tstFiltro_KeyUp(object sender, KeyEventArgs e)
        {
            if (tstFiltro.Text.Length > 2)
            {
                dgv_Gestionar_Proveedor.DataSource = conSQL.retornaRegistros(@"
            SELECT mc.ID_Moto, p.Nombre_Empresa, p.RUC_Empresa, mc.Modelo_Moto, mc.Marca_Moto, 
                   mc.Año_Moto, mc.Valoración, mc.Precio_Moto, mc.Stock  
            FROM Moto_Compra mc
            INNER JOIN Proveedor_info p ON mc.ID_Proveedor = p.ID_Proveedor
            WHERE mc.ID_Moto LIKE '%" + tstFiltro.Text + "%' " +
                      "OR p.Nombre_Empresa LIKE '%" + tstFiltro.Text + "%' " +
                      "OR mc.Modelo_Moto LIKE '%" + tstFiltro.Text + "%'"
                );
            }

            if (string.IsNullOrWhiteSpace(tstFiltro.Text))
            {
                dgv_Gestionar_Proveedor.DataSource = conSQL.retornaRegistros(@"
                  SELECT mc.ID_Moto, p.Nombre_Empresa, p.RUC_Empresa, mc.Modelo_Moto, mc.Marca_Moto, 
                  mc.Año_Moto, mc.Valoración, mc.Precio_Moto, mc.Stock  
                  FROM Moto_Compra mc
                  INNER JOIN Proveedor_info p ON mc.ID_Proveedor = p.ID_Proveedor"
                );
            }
        }

        private void dgv_Gestionar_Proveedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        // esto solo muestra la foto del dgv en agregarMotos en el picbox que esta ahi
        private void dgv_Gestionar_Proveedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgv_Gestionar_Proveedor.Columns["Foto_Moto"].Index && e.RowIndex >= 0)
            {
                byte[] imagenBytes = (byte[])dgv_Gestionar_Proveedor.Rows[e.RowIndex].Cells["Foto_Moto"].Value;

                using (MemoryStream ms = new MemoryStream(imagenBytes))
                {
                    Image imagen = Image.FromStream(ms);
                    picbox_verFoto_gestio_provee.Image = imagen;
                    pnl_EnseñarFoto_gestion_Provee.Visible = true;
                    btn_cerrarPanel.Visible = true;
                }
            }
        }

        private void btn_cerrarPanel_Click(object sender, EventArgs e)
        {
            pnl_EnseñarFoto_gestion_Provee.Visible = false;
            btn_cerrarPanel.Visible = false;
        }
    }
}
