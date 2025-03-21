﻿using System;
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
    public class DBMotos
    {
        private int id_Motos;
        private string modeloMoto;
        private string descripcion;
        private decimal precio;
        private byte[] imagen;

        public int Id_Motos { get => id_Motos; set => id_Motos = value; }
        public string ModeloMoto { get => modeloMoto; set => modeloMoto = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public decimal Precio { get => precio; set => precio = value; }
       
        public byte[] Imagen { get => imagen; set => imagen = value; }

        SqlConnection conexionsql1 = new SqlConnection("Server=THEIRVIN\\SQLEXPRESS;Database=CompañiaTecsBDD;User id=bbd_tecs;Password=123456;");

        public void llenarBotones(FlowLayoutPanel contenedor)
        {
            conexionsql1.Open();
            string transaSql = "SELECT * FROM VentasMotos";
            SqlCommand coman = new SqlCommand(transaSql, conexionsql1);
            coman.CommandType = CommandType.Text;
            SqlDataReader reader = coman.ExecuteReader();

            while (reader.Read())
            {
                id_Motos = Convert.ToInt32(reader[0]);
                ModeloMoto = reader[1].ToString();
                Descripcion = reader[2].ToString();
                Precio = Convert.ToDecimal(reader[3]);
                Imagen = ((byte[])reader[5]);

                MotoCata btn = new MotoCata();
                btn.Id = Id_Motos;
                btn.Modeloname = ModeloMoto;
                btn.Descripcion = Descripcion;
                btn.precio = "$" + Precio.ToString("N2");
                MemoryStream ms = new MemoryStream(Imagen);

                btn.ImgMoto = Image.FromStream(ms);

                contenedor.Controls.Add(btn);

            }

            conexionsql1.Close();
        }
        
            
        
    }


}
