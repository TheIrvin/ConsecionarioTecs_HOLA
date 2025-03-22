using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
namespace ConsecionarioTecs
{
    internal class ProeevInfo_MotoComp_a_Enseñar
    {
        Conexion_BDD conSQL = new Conexion_BDD();


        public ProeevInfo_MotoComp_a_Enseñar(Conexion_BDD conexion)
        {
            this.conSQL = conexion;
        }
        public bool idMotoVF(string idMoto)
        {
            string query = "SELECT COUNT(*) FROM Clientes WHERE ClienteID = @ClienteID";
            using (SqlCommand cmd = new SqlCommand(query, conSQL.llevarConexion()))
            {
                cmd.Parameters.AddWithValue("@ClienteID", idMoto);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }
        public bool VerificarID_Moto(string idMoto)
        {
            string query = "SELECT COUNT(*) FROM Moto_Compra WHERE ID_Moto = @ID_Moto";
            using (SqlCommand cmd = new SqlCommand(query, conSQL.llevarConexion()))
            {
                cmd.Parameters.AddWithValue("@ID_Moto", idMoto);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }

        public int InsertarProveedor(string nombreEmpresa, string contacto, string direccion, string ciudad,
                                 string region, string codigoPostal, string pais, string ruc, string telefono, string email)
        {
            string cadenaProveedor = $"'{nombreEmpresa}', '{contacto}', '{direccion}', '{ciudad}', '{region}', '{codigoPostal}', '{pais}', '{ruc}', '{telefono}', '{email}'";

            conSQL.insertarDatos("Proveedor_info",
                "Nombre_Empresa, Nombre_Contacto, Dirección, Ciudad, Región, Código_Postal, País, RUC_Empresa, Teléfono, Email",
                cadenaProveedor);

            // 🔥 Obtener el ID del proveedor recién insertado
            string queryIDProveedor = "SELECT IDENT_CURRENT('Proveedor_info')";
            return Convert.ToInt32(conSQL.retornaValor(queryIDProveedor));
        }
        public bool agregarMoto(string idMoto, int idProveedor, string modelo, string marca, int año, decimal precio,int ganancia, int ivaVender, int totalMotos, byte[] fotoMoto)
        {
            using (SqlCommand cmd = new SqlCommand("INSERT INTO Moto_Compra " +
         "(ID_Moto, ID_Proveedor, Modelo_Moto, Marca_Moto, Año_Moto, Valoración, Precio_Moto, Ganancia_Moto, IVA_Vender, Total_Motos, Stock, Foto_Moto) " +
        "VALUES (@ID_Moto, @ID_Proveedor, @Modelo_Moto, @Marca_Moto, @Año_Moto, @Valoración, @Precio_Moto, @Ganancia_Moto, @IVA_Vender, @Total_Motos, @Stock, @Foto_Moto)", conSQL.llevarConexion()))
            {
                cmd.Parameters.AddWithValue("@ID_Moto", idMoto);
                cmd.Parameters.AddWithValue("@ID_Proveedor", idProveedor);
                cmd.Parameters.AddWithValue("@Modelo_Moto", modelo);
                cmd.Parameters.AddWithValue("@Marca_Moto", marca);
                cmd.Parameters.AddWithValue("@Año_Moto", año);
                cmd.Parameters.AddWithValue("@Valoración", 5);
                cmd.Parameters.AddWithValue("@Precio_Moto", precio);
                cmd.Parameters.AddWithValue("@Ganancia_Moto", ganancia); // 🔥 Se agrega la ganancia
                cmd.Parameters.AddWithValue("@IVA_Vender", ivaVender);  // 🔥 Nuevo campo
                cmd.Parameters.AddWithValue("@Total_Motos", totalMotos);
                cmd.Parameters.AddWithValue("@Stock", totalMotos);
                cmd.Parameters.Add("@Foto_Moto", SqlDbType.VarBinary).Value = (fotoMoto ?? (object)DBNull.Value);

                try
                {
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al insertar moto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        
    }
}
