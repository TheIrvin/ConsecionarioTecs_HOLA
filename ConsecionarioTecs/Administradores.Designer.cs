namespace FormularioDeInicio
{
    partial class Administradores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administradores));
            this.lblAdministradores = new System.Windows.Forms.Label();
            this.panelAdmin = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelContenedorAdministradores = new System.Windows.Forms.Panel();
            this.dtgvContenedorAdministradores = new System.Windows.Forms.DataGridView();
            this.tsAdministradores = new System.Windows.Forms.ToolStrip();
            this.ttlbFiltrarAdmin = new System.Windows.Forms.ToolStripLabel();
            this.tstxtFiltrarAdmin = new System.Windows.Forms.ToolStripTextBox();
            this.tsbtnFiltrarAdmin = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnAgregarAdmin = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnModificarAdmin = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnEliminarAdmin = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnImprimirAdmin = new System.Windows.Forms.ToolStripButton();
            this.pdrImprimir = new System.Drawing.Printing.PrintDocument();
            this.imlImagenes = new System.Windows.Forms.ImageList(this.components);
            this.panelAdmin.SuspendLayout();
            this.panelContenedorAdministradores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvContenedorAdministradores)).BeginInit();
            this.tsAdministradores.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAdministradores
            // 
            this.lblAdministradores.AutoSize = true;
            this.lblAdministradores.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdministradores.Location = new System.Drawing.Point(3, 6);
            this.lblAdministradores.Name = "lblAdministradores";
            this.lblAdministradores.Size = new System.Drawing.Size(238, 26);
            this.lblAdministradores.TabIndex = 2;
            this.lblAdministradores.Text = "ADMINISTRADORES";
            this.lblAdministradores.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelAdmin
            // 
            this.panelAdmin.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelAdmin.Controls.Add(this.panel2);
            this.panelAdmin.Controls.Add(this.lblAdministradores);
            this.panelAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAdmin.Location = new System.Drawing.Point(0, 0);
            this.panelAdmin.Name = "panelAdmin";
            this.panelAdmin.Size = new System.Drawing.Size(800, 35);
            this.panelAdmin.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 26);
            this.panel2.TabIndex = 6;
            // 
            // panelContenedorAdministradores
            // 
            this.panelContenedorAdministradores.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelContenedorAdministradores.Controls.Add(this.dtgvContenedorAdministradores);
            this.panelContenedorAdministradores.Controls.Add(this.tsAdministradores);
            this.panelContenedorAdministradores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedorAdministradores.Location = new System.Drawing.Point(0, 35);
            this.panelContenedorAdministradores.Name = "panelContenedorAdministradores";
            this.panelContenedorAdministradores.Size = new System.Drawing.Size(800, 415);
            this.panelContenedorAdministradores.TabIndex = 9;
            // 
            // dtgvContenedorAdministradores
            // 
            this.dtgvContenedorAdministradores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvContenedorAdministradores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvContenedorAdministradores.Location = new System.Drawing.Point(0, 25);
            this.dtgvContenedorAdministradores.Name = "dtgvContenedorAdministradores";
            this.dtgvContenedorAdministradores.Size = new System.Drawing.Size(800, 390);
            this.dtgvContenedorAdministradores.TabIndex = 10;
            // 
            // tsAdministradores
            // 
            this.tsAdministradores.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ttlbFiltrarAdmin,
            this.tstxtFiltrarAdmin,
            this.tsbtnFiltrarAdmin,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.tsbtnAgregarAdmin,
            this.toolStripSeparator3,
            this.tsBtnModificarAdmin,
            this.toolStripSeparator4,
            this.tsbtnEliminarAdmin,
            this.toolStripSeparator5,
            this.tsbtnImprimirAdmin});
            this.tsAdministradores.Location = new System.Drawing.Point(0, 0);
            this.tsAdministradores.Name = "tsAdministradores";
            this.tsAdministradores.Size = new System.Drawing.Size(800, 25);
            this.tsAdministradores.TabIndex = 9;
            this.tsAdministradores.Text = "toolStrip1";
            // 
            // ttlbFiltrarAdmin
            // 
            this.ttlbFiltrarAdmin.Name = "ttlbFiltrarAdmin";
            this.ttlbFiltrarAdmin.Size = new System.Drawing.Size(40, 22);
            this.ttlbFiltrarAdmin.Text = "Filtrar:";
            // 
            // tstxtFiltrarAdmin
            // 
            this.tstxtFiltrarAdmin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tstxtFiltrarAdmin.Name = "tstxtFiltrarAdmin";
            this.tstxtFiltrarAdmin.Size = new System.Drawing.Size(110, 25);
            this.tstxtFiltrarAdmin.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tstxtFiltrarAdmin_KeyUp);
            // 
            // tsbtnFiltrarAdmin
            // 
            this.tsbtnFiltrarAdmin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnFiltrarAdmin.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnFiltrarAdmin.Image")));
            this.tsbtnFiltrarAdmin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnFiltrarAdmin.Name = "tsbtnFiltrarAdmin";
            this.tsbtnFiltrarAdmin.Size = new System.Drawing.Size(23, 22);
            this.tsbtnFiltrarAdmin.Text = "toolStripButton1";
            this.tsbtnFiltrarAdmin.Click += new System.EventHandler(this.tsbtnFiltrarAdmin_Click);
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
            // tsbtnAgregarAdmin
            // 
            this.tsbtnAgregarAdmin.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnAgregarAdmin.Image")));
            this.tsbtnAgregarAdmin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnAgregarAdmin.Name = "tsbtnAgregarAdmin";
            this.tsbtnAgregarAdmin.Size = new System.Drawing.Size(69, 22);
            this.tsbtnAgregarAdmin.Text = "Agregar";
            this.tsbtnAgregarAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsbtnAgregarAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.tsbtnAgregarAdmin.Click += new System.EventHandler(this.tsbtnAgregarAdmin_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tsBtnModificarAdmin
            // 
            this.tsBtnModificarAdmin.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnModificarAdmin.Image")));
            this.tsBtnModificarAdmin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnModificarAdmin.Name = "tsBtnModificarAdmin";
            this.tsBtnModificarAdmin.Size = new System.Drawing.Size(78, 22);
            this.tsBtnModificarAdmin.Text = "Modificar";
            this.tsBtnModificarAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.tsBtnModificarAdmin.Click += new System.EventHandler(this.tsBtnModificarAdmin_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbtnEliminarAdmin
            // 
            this.tsbtnEliminarAdmin.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnEliminarAdmin.Image")));
            this.tsbtnEliminarAdmin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnEliminarAdmin.Name = "tsbtnEliminarAdmin";
            this.tsbtnEliminarAdmin.Size = new System.Drawing.Size(70, 22);
            this.tsbtnEliminarAdmin.Text = "Eliminar";
            this.tsbtnEliminarAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.tsbtnEliminarAdmin.Click += new System.EventHandler(this.tsbtnEliminarAdmin_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbtnImprimirAdmin
            // 
            this.tsbtnImprimirAdmin.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnImprimirAdmin.Image")));
            this.tsbtnImprimirAdmin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnImprimirAdmin.Name = "tsbtnImprimirAdmin";
            this.tsbtnImprimirAdmin.Size = new System.Drawing.Size(73, 22);
            this.tsbtnImprimirAdmin.Text = "Imprimir";
            this.tsbtnImprimirAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.tsbtnImprimirAdmin.Click += new System.EventHandler(this.tsbtnImprimirAdmin_Click);
            // 
            // imlImagenes
            // 
            this.imlImagenes.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlImagenes.ImageStream")));
            this.imlImagenes.TransparentColor = System.Drawing.Color.Transparent;
            this.imlImagenes.Images.SetKeyName(0, "Logo_TECS.jpg");
            // 
            // Administradores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelContenedorAdministradores);
            this.Controls.Add(this.panelAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Administradores";
            this.Text = "Administradores";
            this.Load += new System.EventHandler(this.Administradores_Load);
            this.panelAdmin.ResumeLayout(false);
            this.panelAdmin.PerformLayout();
            this.panelContenedorAdministradores.ResumeLayout(false);
            this.panelContenedorAdministradores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvContenedorAdministradores)).EndInit();
            this.tsAdministradores.ResumeLayout(false);
            this.tsAdministradores.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblAdministradores;
        private System.Windows.Forms.Panel panelAdmin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelContenedorAdministradores;
        private System.Windows.Forms.ToolStrip tsAdministradores;
        private System.Windows.Forms.ToolStripLabel ttlbFiltrarAdmin;
        private System.Windows.Forms.ToolStripTextBox tstxtFiltrarAdmin;
        private System.Windows.Forms.ToolStripButton tsbtnFiltrarAdmin;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbtnAgregarAdmin;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsBtnModificarAdmin;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsbtnEliminarAdmin;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton tsbtnImprimirAdmin;
        public System.Windows.Forms.DataGridView dtgvContenedorAdministradores;
        private System.Drawing.Printing.PrintDocument pdrImprimir;
        private System.Windows.Forms.ImageList imlImagenes;
    }
}