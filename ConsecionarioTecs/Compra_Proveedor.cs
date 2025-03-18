using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public partial class Compra_Proveedor: Form
    {
        public Compra_Proveedor()
        {
            InitializeComponent();
        }
        Conexion_BDD conSQL = new Conexion_BDD();
        string cadena;
        int tipo; //tipo=1 entonces inserto datos, tipo=2 entonces modificar datos
        public Compra_Proveedor(int t)
        {
            tipo = t;
            InitializeComponent();
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void label10_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btn_compra_Proveedor_Click(object sender, EventArgs e)
        {
            Gestionar_Proveedores_DGV frm_gestProveedor = Owner as Gestionar_Proveedores_DGV;

            // 🔥 Insertar Proveedor en Proveedor_info
            string cadenaProveedor = "'" + txtBox_PVD_nombreEmpresa.Text + "','" + txtBox_PVD_contacto.Text + "','" +
                                     txtBox_PVD_dirección.Text + "','" + txtBox_PVD_Ciudad.Text + "','" +
                                     txtBox_PVD_Región.Text + "','" + txtBox_PVD_codigoPostal.Text + "','" +
                                     cBox_País.Text + "','" + txtBox_PVD_RUC.Text + "','" +
                                     txtBox_PVD_teléfono.Text + "','" + txtBox_PVD_Email.Text + "'";

            conSQL.insertarDatos("Proveedor_info",
                "Nombre_Empresa, Nombre_Contacto, Dirección, Ciudad, Región, Codigo_Postal, País, RUC_Empresa, Teléfono, Email",
            cadenaProveedor);

            // 🔥 Obtener ID del proveedor recién insertado
            string queryIDProveedor = "SELECT IDENT_CURRENT('Proveedor_info')";
            int idProveedor = Convert.ToInt32(conSQL.retornaValor(queryIDProveedor));

            // 🔥 Convertir imagen a bytes para guardar en la base de datos
            byte[] imagenMoto = null;
            if (picBox_PVD_fotoMoto.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    picBox_PVD_fotoMoto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    imagenMoto = ms.ToArray();
                }
            }

            // 🔥 Insertar Moto en Moto_Compra
            using (SqlCommand cmd = new SqlCommand("INSERT INTO Moto_Compra " +
                "(ID_Moto, ID_Proveedor, Modelo_Moto, Marca_Moto, Año_Moto, Valoración, Precio_Moto, Total_Motos, Stock, Foto_Moto) " +
                "VALUES (@ID_Moto, @ID_Proveedor, @Modelo_Moto, @Marca_Moto, @Año_Moto, @Valoración, @Precio_Moto, @Total_Motos, @Stock, @Foto_Moto)", conSQL.llevarConexion()))
            {
                cmd.Parameters.AddWithValue("@ID_Moto", txtBox_PVD_idMoto.Text);
                cmd.Parameters.AddWithValue("@ID_Proveedor", idProveedor);
                cmd.Parameters.AddWithValue("@Modelo_Moto", txtBox_PVD_modeloMoto.Text);
                cmd.Parameters.AddWithValue("@Marca_Moto", txtBox_PVD_marcaMoto.Text);
                cmd.Parameters.AddWithValue("@Año_Moto", int.Parse(txtBox_PVD_añoMoto.Text));
                cmd.Parameters.AddWithValue("@Valoración", 5);
                cmd.Parameters.AddWithValue("@Precio_Moto", decimal.Parse(txtBox_PVD_precioMoto.Text));
                cmd.Parameters.AddWithValue("@Total_Motos", int.Parse(txtBox_PVD_totalMotos.Text));
                cmd.Parameters.AddWithValue("@Stock", int.Parse(txtBox_PVD_totalMotos.Text)); // 🔥 Stock igual a Total_Motos
                cmd.Parameters.Add("@Foto_Moto", SqlDbType.VarBinary).Value = (imagenMoto ?? (object)DBNull.Value);

                bool resultado = conSQL.ejecutarComando(cmd);
            }

            frm_gestProveedor.dgv_Gestionar_Proveedor.DataSource = conSQL.retornaRegistros(@"
                   SELECT mc.ID_Moto, p.Nombre_Empresa, p.RUC_Empresa, mc.Modelo_Moto, mc.Marca_Moto, 
                   mc.Año_Moto, mc.Valoración, mc.Precio_Moto, mc.Stock  
                   FROM Moto_Compra mc
                   INNER JOIN Proveedor_info p ON mc.ID_Proveedor = p.ID_Proveedor"
            );
            this.Close();
        }


        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Compra_Proveedor_Load(object sender, EventArgs e)
        {
            txtBox_PVD_idMoto.BringToFront();
            txtBox_PVD_nombreEmpresa.BringToFront();
            txtBox_PVD_RUC.BringToFront();
            txtBox_PVD_dirección.BringToFront();
            txtBox_PVD_contacto.BringToFront();
            txtBox_PVD_Email.BringToFront();
            txtBox_PVD_teléfono.BringToFront();
            txtBox_PVD_modeloMoto.BringToFront();
            txtBox_PVD_marcaMoto.BringToFront();
            txtBox_PVD_añoMoto.BringToFront();
            txtBox_PVD_precioMoto.BringToFront();
            txtBox_PVD_totalMotos.BringToFront();
        }

        private void txtBox_PVD_RUC_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtBox_PVD_dirección_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_Regresar_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void txtBox_PVD_teléfono_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBox_PVD_totalMotos_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
