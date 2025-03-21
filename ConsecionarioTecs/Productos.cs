﻿using System;
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
using ConsecionarioTecs;

namespace FormularioDeInicio
{
    public partial class Productos : Form
    {

        public Productos()
        {
            InitializeComponent();
            LlenarProductos();
        }
       
        private void LlenarProductos()
        {
            DBMotos obj = new DBMotos();
            obj.llenarBotones(FlpContenedorMotos);
        }
       
        private void tsbtnAgregarVentas_Click(object sender, EventArgs e)
        {
            pnl_aggMotos.Visible = true;
            AbrirEnPanel(new AgregarMoto());
            AgregarMoto fmMoto = new AgregarMoto();

            this.AddOwnedForm(fmMoto);

        }
        private void AbrirEnPanel(Form formNij0)
        {
            if (this.pnl_aggMotos.Controls.Count > 0)
            {
                this.pnl_aggMotos.Controls.RemoveAt(0);
            }

            Form fn = formNij0 as Form;
            if (fn != null)
            {
                fn.TopLevel = false;
                fn.FormBorderStyle = FormBorderStyle.None;
                fn.Dock = DockStyle.Fill;
                this.pnl_aggMotos.Controls.Add(fn);
                this.pnl_aggMotos.Tag = fn;
                fn.Show();
            }
        }
        private void tsbtnModificarVenta_Click(object sender, EventArgs e)
        {


            AgregarMoto fmEdiMoto = new AgregarMoto();

            this.AddOwnedForm(fmEdiMoto);
            fmEdiMoto.Show();
        }
    }
}
