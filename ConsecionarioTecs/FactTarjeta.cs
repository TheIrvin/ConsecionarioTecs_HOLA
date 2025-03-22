using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ConsecionarioTecs
{
    public partial class FactTarjeta: Form
    {
        public FactTarjeta()
        {
            InitializeComponent();
        }
        public string Conectarsql = "Server=THEIRVIN\\SQLEXPRESS;Database=CompañiaTecsBDD;User id=bbd_tecs;Password=123456;";
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_REALIZARF_Click(object sender, EventArgs e)
        {

        }

        private void FactTarjeta_Load(object sender, EventArgs e)
        {
            CargarDatosMotoCompra();
            CargarDatosClientes();
        }
        private void CargarDatosMotoCompra()
        {
            using (SqlConnection con = new SqlConnection(Conectarsql))
            {
                con.Open();
                string query = @"
                SELECT 
                mc.ID_Moto, mc.IVA_Vender, mc.Stock, mc.Foto_Moto, em.Precio_Moto 
                FROM Moto_Compra mc
                INNER JOIN Enseñar_Motos em ON mc.ID_Moto = em.ID_Moto";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DGV_enseñar_F.DataSource = dt;
            }
        }
        private void CargarDatosClientes()
        {
            using (SqlConnection con = new SqlConnection(Conectarsql))
            {
                con.Open();
                string query = @"
                SELECT ClienteID, NombreCliente, Cedula, Ciudad, Teléfono, Email FROM Clientes";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DGV_enseñar_CLIEN.DataSource = dt;
            }
        }

        private void cbox_tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbox_tipo.SelectedItem.ToString() == "Cuotas")
            {
                lbl_nCuotas.Visible = true;
                updw_num.Visible = true;
            }
            else
            {
                lbl_nCuotas.Visible = false;
                updw_num.Visible = false;
            }

        }

        private void lbl_PrecioMoto4_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbxMetodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_Metodo.SelectedItem != null && cbx_Metodo.SelectedItem.ToString() == "Tarjeta")
            {
                lbl_Tarjeta.Visible = true;
                txt_Tarjeta.Visible = true;
            }
            else
            {
                lbl_Tarjeta.Visible = false;
                txt_Tarjeta.Visible = false;
            }

        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            
        }
        
        private void DGV_enseñar_F_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DGV_enseñar_F.Rows[e.RowIndex];

                txt_IdMoto.Text = row.Cells["ID_Moto"].Value.ToString();
                lbl_enseñarIVA.Text = row.Cells["IVA_Vender"].Value.ToString();
                lbl_PrecioMoto.Text = row.Cells["Precio_Moto"].Value.ToString(); 

                if (row.Cells["Foto_Moto"].Value != DBNull.Value)
                {
                    byte[] imgBytes = (byte[])row.Cells["Foto_Moto"].Value;
                    using (MemoryStream ms = new MemoryStream(imgBytes))
                    {
                        picBox_FotoMoto.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    picBox_FotoMoto.Image = null;
                }
            }
        }

        private void DGV_enseñar_CLIEN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DGV_enseñar_CLIEN.Rows[e.RowIndex];

                txt_clienteID.Text = row.Cells["ClienteID"].Value.ToString();
                txtBox_NombreClien.Text = row.Cells["NombreCliente"].Value.ToString(); 
                txtBox_cedula.Text = row.Cells["Cedula"].Value.ToString();
                txtBox_CiudadC.Text = row.Cells["Ciudad"].Value.ToString();
                txtBox_telfC.Text = row.Cells["Teléfono"].Value.ToString();
                txtBox_GmailC.Text = row.Cells["Email"].Value.ToString();
            }
        }

        private void btn_F_Realizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_clienteID.Text) || string.IsNullOrEmpty(txt_IdMoto.Text))
            {
                MessageBox.Show("Debe seleccionar un cliente y una moto antes de Realizar el Registro.");
                return;
            }

            using (SqlConnection con = new SqlConnection(Conectarsql))
            {
                con.Open();
                SqlTransaction transaction = con.BeginTransaction();

                try
                {
                    string modeloMoto = "";
                    string queryObtenerModelo = "SELECT Modelo_Moto FROM Moto_Compra WHERE ID_Moto = @ID_Moto";

                    using (SqlCommand cmdModelo = new SqlCommand(queryObtenerModelo, con, transaction))
                    {
                        cmdModelo.Parameters.AddWithValue("@ID_Moto", txt_IdMoto.Text);
                        object result = cmdModelo.ExecuteScalar();
                        if (result != null)
                        {
                            modeloMoto = result.ToString();
                        }
                    }

                    decimal precioCompra = 0;
                    string queryPrecioCompra = "SELECT Precio_Compra FROM Moto_Compra WHERE ID_Moto = @ID_Moto";

                    using (SqlCommand cmdPrecio = new SqlCommand(queryPrecioCompra, con, transaction))
                    {
                        cmdPrecio.Parameters.AddWithValue("@ID_Moto", txt_IdMoto.Text);
                        object resultPrecio = cmdPrecio.ExecuteScalar();
                        if (resultPrecio != null)
                        {
                            precioCompra = Convert.ToDecimal(resultPrecio);
                        }
                    }

                    decimal precioVenta = 0;
                    if (!decimal.TryParse(lbl_PrecioMoto.Text, out precioVenta))
                    {
                        MessageBox.Show("Error: El precio de venta no es válido.");
                        return;
                    }


                    string queryVenta = @"
                INSERT INTO Motos_Vendidas (ID_Moto, ClienteID, Nombre_Cliente, Modelo_Moto, Precio_Compra, Precio_Venta)
                VALUES (@ID_Moto, @ClienteID, @Nombre_Cliente, @Modelo_Moto, @Precio_Compra, @Precio_Venta)";

                    using (SqlCommand cmdVenta = new SqlCommand(queryVenta, con, transaction))
                    {
                        cmdVenta.Parameters.AddWithValue("@ID_Moto", txt_IdMoto.Text);
                        cmdVenta.Parameters.AddWithValue("@ClienteID", txt_clienteID.Text);
                        cmdVenta.Parameters.AddWithValue("@Nombre_Cliente", txtBox_NombreClien.Text);
                        cmdVenta.Parameters.AddWithValue("@Modelo_Moto", modeloMoto);
                        cmdVenta.Parameters.AddWithValue("@Precio_Compra", precioCompra);
                        cmdVenta.Parameters.AddWithValue("@Precio_Venta", precioVenta);

                        cmdVenta.ExecuteNonQuery();
                    }

                    string queryActualizarStock = "UPDATE Moto_Compra SET Stock = Stock - 1 WHERE ID_Moto = @ID_Moto";

                    using (SqlCommand cmdStock = new SqlCommand(queryActualizarStock, con, transaction))
                    {
                        cmdStock.Parameters.AddWithValue("@ID_Moto", txt_IdMoto.Text);
                        cmdStock.ExecuteNonQuery();
                    }

                    string queryVerificarStock = "SELECT Stock FROM Moto_Compra WHERE ID_Moto = @ID_Moto";
                    using (SqlCommand cmdVerificarStock = new SqlCommand(queryVerificarStock, con, transaction))
                    {
                        cmdVerificarStock.Parameters.AddWithValue("@ID_Moto", txt_IdMoto.Text);
                        object stockResult = cmdVerificarStock.ExecuteScalar();

                        if (stockResult != null && Convert.ToInt32(stockResult) == 0)
                        {
                            string queryEliminarMoto = "DELETE FROM Moto_Compra WHERE ID_Moto = @ID_Moto";
                            using (SqlCommand cmdEliminarMoto = new SqlCommand(queryEliminarMoto, con, transaction))
                            {
                                cmdEliminarMoto.Parameters.AddWithValue("@ID_Moto", txt_IdMoto.Text);
                                cmdEliminarMoto.ExecuteNonQuery();
                            }
                        }
                    }

                    transaction.Commit();

                    MessageBox.Show("registro realizado con éxito y stock actualizado.");
                    DGV_enseñar_F.Refresh();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
