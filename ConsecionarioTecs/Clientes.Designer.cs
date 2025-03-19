namespace FormularioDeInicio
{
    partial class Clientes
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clientes));
            this.tsClientes = new System.Windows.Forms.ToolStrip();
            this.ttlbFiltrar = new System.Windows.Forms.ToolStripLabel();
            this.tstxtFiltrarCliente = new System.Windows.Forms.ToolStripTextBox();
            this.tsbtnFiltrarCliente = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnAgregarCliente = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnModificarCliente = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnEliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnImprimir = new System.Windows.Forms.ToolStripButton();
            this.panelClientes = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblClientes = new System.Windows.Forms.Label();
            this.dtgvContenedorClientes = new System.Windows.Forms.DataGridView();
            this.panelContenedorCliente = new System.Windows.Forms.Panel();
            this.imlImagenes = new System.Windows.Forms.ImageList(this.components);
            this.pdrImprimir = new System.Drawing.Printing.PrintDocument();
            this.tsClientes.SuspendLayout();
            this.panelClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvContenedorClientes)).BeginInit();
            this.panelContenedorCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsClientes
            // 
            this.tsClientes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ttlbFiltrar,
            this.tstxtFiltrarCliente,
            this.tsbtnFiltrarCliente,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.tsbtnAgregarCliente,
            this.toolStripSeparator3,
            this.tsBtnModificarCliente,
            this.toolStripSeparator4,
            this.tsbtnEliminar,
            this.toolStripSeparator5,
            this.tsbtnImprimir});
            this.tsClientes.Location = new System.Drawing.Point(0, 0);
            this.tsClientes.Name = "tsClientes";
            this.tsClientes.Size = new System.Drawing.Size(800, 25);
            this.tsClientes.TabIndex = 0;
            this.tsClientes.Text = "toolStrip1";
            // 
            // ttlbFiltrar
            // 
            this.ttlbFiltrar.Name = "ttlbFiltrar";
            this.ttlbFiltrar.Size = new System.Drawing.Size(40, 22);
            this.ttlbFiltrar.Text = "Filtrar:";
            // 
            // tstxtFiltrarCliente
            // 
            this.tstxtFiltrarCliente.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tstxtFiltrarCliente.Name = "tstxtFiltrarCliente";
            this.tstxtFiltrarCliente.Size = new System.Drawing.Size(110, 25);
            this.tstxtFiltrarCliente.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tstxtFiltrarCliente_KeyUp);
            // 
            // tsbtnFiltrarCliente
            // 
            this.tsbtnFiltrarCliente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnFiltrarCliente.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnFiltrarCliente.Image")));
            this.tsbtnFiltrarCliente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnFiltrarCliente.Name = "tsbtnFiltrarCliente";
            this.tsbtnFiltrarCliente.Size = new System.Drawing.Size(23, 22);
            this.tsbtnFiltrarCliente.Text = "Buscar";
            this.tsbtnFiltrarCliente.Click += new System.EventHandler(this.tsbtnFiltrarCliente_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(58, 22);
            this.toolStripLabel1.Text = "Acciones:";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbtnAgregarCliente
            // 
            this.tsbtnAgregarCliente.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnAgregarCliente.Image")));
            this.tsbtnAgregarCliente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnAgregarCliente.Name = "tsbtnAgregarCliente";
            this.tsbtnAgregarCliente.Size = new System.Drawing.Size(69, 22);
            this.tsbtnAgregarCliente.Text = "Agregar";
            this.tsbtnAgregarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsbtnAgregarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.tsbtnAgregarCliente.Click += new System.EventHandler(this.tsbtnAgregarCliente_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tsBtnModificarCliente
            // 
            this.tsBtnModificarCliente.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnModificarCliente.Image")));
            this.tsBtnModificarCliente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnModificarCliente.Name = "tsBtnModificarCliente";
            this.tsBtnModificarCliente.Size = new System.Drawing.Size(78, 22);
            this.tsBtnModificarCliente.Text = "Modificar";
            this.tsBtnModificarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.tsBtnModificarCliente.Click += new System.EventHandler(this.tsBtnModificarCliente_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbtnEliminar
            // 
            this.tsbtnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnEliminar.Image")));
            this.tsbtnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnEliminar.Name = "tsbtnEliminar";
            this.tsbtnEliminar.Size = new System.Drawing.Size(70, 22);
            this.tsbtnEliminar.Text = "Eliminar";
            this.tsbtnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.tsbtnEliminar.Click += new System.EventHandler(this.tsbtnEliminar_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbtnImprimir
            // 
            this.tsbtnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnImprimir.Image")));
            this.tsbtnImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnImprimir.Name = "tsbtnImprimir";
            this.tsbtnImprimir.Size = new System.Drawing.Size(73, 22);
            this.tsbtnImprimir.Text = "Imprimir";
            this.tsbtnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.tsbtnImprimir.Click += new System.EventHandler(this.tsbtnImprimir_Click);
            // 
            // panelClientes
            // 
            this.panelClientes.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelClientes.Controls.Add(this.panel2);
            this.panelClientes.Controls.Add(this.lblClientes);
            this.panelClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelClientes.Location = new System.Drawing.Point(0, 0);
            this.panelClientes.Name = "panelClientes";
            this.panelClientes.Size = new System.Drawing.Size(800, 35);
            this.panelClientes.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 26);
            this.panel2.TabIndex = 6;
            // 
            // lblClientes
            // 
            this.lblClientes.AutoSize = true;
            this.lblClientes.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientes.Location = new System.Drawing.Point(3, 6);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(124, 26);
            this.lblClientes.TabIndex = 2;
            this.lblClientes.Text = "CLIENTES";
            this.lblClientes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dtgvContenedorClientes
            // 
            this.dtgvContenedorClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvContenedorClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvContenedorClientes.Location = new System.Drawing.Point(0, 25);
            this.dtgvContenedorClientes.Name = "dtgvContenedorClientes";
            this.dtgvContenedorClientes.Size = new System.Drawing.Size(800, 390);
            this.dtgvContenedorClientes.TabIndex = 1;
            // 
            // panelContenedorCliente
            // 
            this.panelContenedorCliente.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelContenedorCliente.Controls.Add(this.dtgvContenedorClientes);
            this.panelContenedorCliente.Controls.Add(this.tsClientes);
            this.panelContenedorCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedorCliente.Location = new System.Drawing.Point(0, 35);
            this.panelContenedorCliente.Name = "panelContenedorCliente";
            this.panelContenedorCliente.Size = new System.Drawing.Size(800, 415);
            this.panelContenedorCliente.TabIndex = 10;
            // 
            // imlImagenes
            // 
            this.imlImagenes.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlImagenes.ImageStream")));
            this.imlImagenes.TransparentColor = System.Drawing.Color.Transparent;
            this.imlImagenes.Images.SetKeyName(0, "Logo_TECS.jpg");
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelContenedorCliente);
            this.Controls.Add(this.panelClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Clientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Clientes_Load);
            this.tsClientes.ResumeLayout(false);
            this.tsClientes.PerformLayout();
            this.panelClientes.ResumeLayout(false);
            this.panelClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvContenedorClientes)).EndInit();
            this.panelContenedorCliente.ResumeLayout(false);
            this.panelContenedorCliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStrip tsClientes;
        private System.Windows.Forms.ToolStripLabel ttlbFiltrar;
        private System.Windows.Forms.ToolStripTextBox tstxtFiltrarCliente;
        private System.Windows.Forms.ToolStripButton tsbtnFiltrarCliente;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbtnAgregarCliente;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsBtnModificarCliente;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsbtnEliminar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton tsbtnImprimir;
        private System.Windows.Forms.Panel panelClientes;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblClientes;
        public System.Windows.Forms.DataGridView dtgvContenedorClientes;
        private System.Windows.Forms.Panel panelContenedorCliente;
        private System.Windows.Forms.ImageList imlImagenes;
        private System.Drawing.Printing.PrintDocument pdrImprimir;
    }
}