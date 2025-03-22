using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ConsecionarioTecs
{
    class Conexion_BDD
    {
            public SqlConnection oCon;
            public SqlCommand oCom;
            public SqlDataReader oDR;
            public SqlDataAdapter oDA;
            public DataTable oDT;

            string Server;
            string Database;
            string Usuario;
            string Clave;
            string Cadena;

            public Conexion_BDD()
            {
                //Server = "THEIRVIN\\SQLEXPRESS";
                //Database = "CompañiaTecsBDD";
                //Usuario = "bbd_tecs";
                //Clave = "123456";
                Server = "DESKTOP-9SMDLH8\\SQLEXPRESS";
                Database = "CompañiaTecsBDD";
                Usuario = "AccesoChari";
                Clave = "accesochari";

            }

        public Conexion_BDD(string Server, string Database, string Usuario, string Clave)
        {
            this.Server = Server;
            this.Database = Database;
            this.Usuario = Usuario;
            this.Clave = Clave;
        }

        public bool abrirConexion()
        {
            oCon = new SqlConnection();
            try
            {
                oCon.ConnectionString = Cadena = "Server=" + Server + "; Database=" + Database + "; User id=" + Usuario.Trim() + "; Password=" + Clave;
                oCon.Open();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public bool cerrarConexion()
        {
            oCon.Close();
            return true;
        }

        public bool eliminarDatos(string Tabla, string Condicion)
        {
            try
            {
                abrirConexion();
                Cadena = "Delete " + Tabla + " where " + Condicion;
                oCom = new SqlCommand(Cadena, oCon);
                oCom.ExecuteNonQuery();
                cerrarConexion();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        public SqlConnection llevarConexion()
        {
            SqlConnection oCon = new SqlConnection();
            try
            {
                // Definir la cadena de conexión
                Cadena = "Server=" + Server + "; Database=" + Database + "; User id=" + Usuario.Trim() + "; Password=" + Clave;
                oCon.ConnectionString = Cadena;
                oCon.Open();  // Intentar abrir la conexión

                return oCon;  // Si se abre correctamente, devolver la conexión
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Error al abrir la conexión: " + ex.Message);
            }
        }
        public bool ejecutarComando(SqlCommand cmd)
        {
            try
            {
                // Asegurarse de que la conexión esté abierta
                using (SqlConnection con = llevarConexion())
                {
                    cmd.Connection = con;  // Asignar la conexión al comando
                    cmd.ExecuteNonQuery(); // Ejecutar el comando (sin devolver resultados)
                }
                return true;  // Si la ejecución es exitosa, devolver true
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al ejecutar el comando: " + ex.Message);
                return false;  // Si ocurre un error, devolver false
            }
        }

        public bool insertarDatos(string Tabla, string Campos, string Datos)
        {
            abrirConexion();
            Cadena = "Insert into " + Tabla + " (" + Campos + ") values( " + Datos + ")";
            oCom = new SqlCommand(Cadena, oCon);
            oCom.ExecuteNonQuery();
            cerrarConexion();
            return true;
        }

        public bool actualizarDatos(string Tabla, string Datos, string Condicion)
        {
            try
            {
                abrirConexion();
                Cadena = "Update " + Tabla + " set " + Datos + " where " + Condicion;
                oCom = new SqlCommand(Cadena, oCon);
                oCom.ExecuteNonQuery();
                cerrarConexion();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public bool ejecutarSQL(string Sentencia)
        {
            abrirConexion();
            oCom = new SqlCommand(Sentencia, oCon);
            oCom.ExecuteNonQuery();
            cerrarConexion();
            return true;
        }

        public int retornaValor(string Seleccion, string Tabla, string Condicion)
        {
            int temporal;
            abrirConexion();
            Cadena = "Select isnull(cast(" + Seleccion + " as int),0) from " + Tabla + " where " + Condicion;
            oCom = new SqlCommand(Cadena, oCon);
            oDR = oCom.ExecuteReader();
            oDR.Read();
            temporal = (int)oDR[0];
            oDR.Close();
            cerrarConexion();
            return temporal;
        }
        public object retornaValor(string consulta)
        {
            try
            {
                if (!abrirConexion()) return null;

                oCom = new SqlCommand(consulta, oCon);
                object resultado = oCom.ExecuteScalar();
                cerrarConexion();

                return resultado ?? 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en retornaValor: " + ex.Message);
                return null;
            }
        }

        public String retornaCadena(string Seleccion, string Tabla, string Condicion)
        {
            string temporal;
            abrirConexion();
            Cadena = "Select isnull(cast(" + Seleccion + " as varchar(200)),'') from " + Tabla + " where " + Condicion;
            oCom = new SqlCommand(Cadena, oCon);
            oDR = oCom.ExecuteReader();

            if (oDR.Read())
            {
                temporal = (String)oDR[0];
            }
            else
            {
                temporal = "";
            }
            oDR.Close();
            cerrarConexion();
            return temporal;
        }

        public string retornaCadenaConsulta(string Consulta)
        {
            string temporal;
            abrirConexion();
            oCom = new SqlCommand(Consulta, oCon);
            oDR = oCom.ExecuteReader();
            oDR.Read();
            temporal = (string)oDR[0];
            oDR.Close();
            cerrarConexion();
            return temporal;
        }

        public decimal retornaValorConsulta(string Consulta)
        {
            decimal temporal;
            abrirConexion();
            oCom = new SqlCommand(Consulta, oCon);
            oDR = oCom.ExecuteReader();
            oDR.Read();
            temporal = (decimal)oDR[0];
            oDR.Close();
            cerrarConexion();
            return temporal;
        }

        public DataTable retornaRegistros(string Sentencia)
        {
            if (Sentencia.Length > 0)
            {
                abrirConexion();
                oCom = new SqlCommand(Sentencia, oCon);
                oDA = new SqlDataAdapter(oCom);
                oDT = new DataTable();
                oDA.Fill(oDT);
                cerrarConexion();
            }
            return oDT;
        }

    }
}
