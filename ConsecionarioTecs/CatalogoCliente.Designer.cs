namespace FormularioDeInicio
{
    partial class CatalogoCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCatalogoMotos = new System.Windows.Forms.Label();
            this.panelCatalogoMotos = new System.Windows.Forms.Panel();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelContenedorCatalogo = new System.Windows.Forms.Panel();
            this.flpMotosUsuario = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_EnseñarFactura = new System.Windows.Forms.Button();
            this.pnl_EnseñarFACT = new System.Windows.Forms.Panel();
            this.panelCatalogoMotos.SuspendLayout();
            this.panelContenedorCatalogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCatalogoMotos
            // 
            this.lblCatalogoMotos.AutoSize = true;
            this.lblCatalogoMotos.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatalogoMotos.Location = new System.Drawing.Point(3, 12);
            this.lblCatalogoMotos.Name = "lblCatalogoMotos";
            this.lblCatalogoMotos.Size = new System.Drawing.Size(269, 26);
            this.lblCatalogoMotos.TabIndex = 1;
            this.lblCatalogoMotos.Text = "CATÁLOGO DE MOTOS";
            // 
            // panelCatalogoMotos
            // 
            this.panelCatalogoMotos.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelCatalogoMotos.Controls.Add(this.btn_EnseñarFactura);
            this.panelCatalogoMotos.Controls.Add(this.btnFiltrar);
            this.panelCatalogoMotos.Controls.Add(this.panel2);
            this.panelCatalogoMotos.Controls.Add(this.lblCatalogoMotos);
            this.panelCatalogoMotos.Location = new System.Drawing.Point(0, 0);
            this.panelCatalogoMotos.Name = "panelCatalogoMotos";
            this.panelCatalogoMotos.Size = new System.Drawing.Size(881, 47);
            this.panelCatalogoMotos.TabIndex = 3;
            this.panelCatalogoMotos.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCatalogoMotos_Paint);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFiltrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.Image = global::ConsecionarioTecs.Properties.Resources.cabeza;
            this.btnFiltrar.Location = new System.Drawing.Point(334, 9);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(132, 30);
            this.btnFiltrar.TabIndex = 6;
            this.btnFiltrar.Text = "Realizar o Guardar";
            this.btnFiltrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFiltrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Visible = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Location = new System.Drawing.Point(0, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 26);
            this.panel2.TabIndex = 5;
            // 
            // panelContenedorCatalogo
            // 
            this.panelContenedorCatalogo.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelContenedorCatalogo.Controls.Add(this.pnl_EnseñarFACT);
            this.panelContenedorCatalogo.Controls.Add(this.panelCatalogoMotos);
            this.panelContenedorCatalogo.Controls.Add(this.flpMotosUsuario);
            this.panelContenedorCatalogo.Location = new System.Drawing.Point(0, 0);
            this.panelContenedorCatalogo.Name = "panelContenedorCatalogo";
            this.panelContenedorCatalogo.Size = new System.Drawing.Size(881, 542);
            this.panelContenedorCatalogo.TabIndex = 6;
            this.panelContenedorCatalogo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenedorCatalogo_Paint);
            // 
            // flpMotosUsuario
            // 
            this.flpMotosUsuario.AutoScroll = true;
            this.flpMotosUsuario.AutoSize = true;
            this.flpMotosUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpMotosUsuario.Location = new System.Drawing.Point(0, 0);
            this.flpMotosUsuario.Name = "flpMotosUsuario";
            this.flpMotosUsuario.Size = new System.Drawing.Size(881, 542);
            this.flpMotosUsuario.TabIndex = 0;
            // 
            // btn_EnseñarFactura
            // 
            this.btn_EnseñarFactura.BackColor = System.Drawing.Color.Black;
            this.btn_EnseñarFactura.ForeColor = System.Drawing.Color.White;
            this.btn_EnseñarFactura.Location = new System.Drawing.Point(693, 3);
            this.btn_EnseñarFactura.Name = "btn_EnseñarFactura";
            this.btn_EnseñarFactura.Size = new System.Drawing.Size(165, 42);
            this.btn_EnseñarFactura.TabIndex = 7;
            this.btn_EnseñarFactura.Text = "Buscar y Realizar Una Venta";
            this.btn_EnseñarFactura.UseVisualStyleBackColor = false;
            this.btn_EnseñarFactura.Click += new System.EventHandler(this.btn_EnseñarFactura_Click);
            // 
            // pnl_EnseñarFACT
            // 
            this.pnl_EnseñarFACT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnl_EnseñarFACT.Location = new System.Drawing.Point(0, 0);
            this.pnl_EnseñarFACT.Name = "pnl_EnseñarFACT";
            this.pnl_EnseñarFACT.Size = new System.Drawing.Size(881, 539);
            this.pnl_EnseñarFACT.TabIndex = 8;
            this.pnl_EnseñarFACT.Visible = false;
            // 
            // CatalogoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(880, 540);
            this.Controls.Add(this.panelContenedorCatalogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CatalogoCliente";
            this.Text = "CatalogoCliente";
            this.Load += new System.EventHandler(this.CatalogoCliente_Load);
            this.panelCatalogoMotos.ResumeLayout(false);
            this.panelCatalogoMotos.PerformLayout();
            this.panelContenedorCatalogo.ResumeLayout(false);
            this.panelContenedorCatalogo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCatalogoMotos;
        private System.Windows.Forms.Panel panelCatalogoMotos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelContenedorCatalogo;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.FlowLayoutPanel flpMotosUsuario;
        private System.Windows.Forms.Panel pnl_EnseñarFACT;
        private System.Windows.Forms.Button btn_EnseñarFactura;
    }
}