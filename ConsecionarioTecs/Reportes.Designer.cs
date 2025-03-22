namespace FormularioDeInicio
{
    partial class Reportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reportes));
            this.pnl_Reportes = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgv_enseñarVentas = new System.Windows.Forms.DataGridView();
            this.tsClientes = new System.Windows.Forms.ToolStrip();
            this.ttlbFiltrar = new System.Windows.Forms.ToolStripLabel();
            this.tstxtFiltrarCliente = new System.Windows.Forms.ToolStripTextBox();
            this.tsbtnFiltrarCliente = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnImprimir = new System.Windows.Forms.ToolStripButton();
            this.pnl_Reportes.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_enseñarVentas)).BeginInit();
            this.tsClientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Reportes
            // 
            this.pnl_Reportes.BackColor = System.Drawing.SystemColors.Control;
            this.pnl_Reportes.Controls.Add(this.tsClientes);
            this.pnl_Reportes.Controls.Add(this.dgv_enseñarVentas);
            this.pnl_Reportes.Location = new System.Drawing.Point(0, 28);
            this.pnl_Reportes.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.pnl_Reportes.Name = "pnl_Reportes";
            this.pnl_Reportes.Size = new System.Drawing.Size(880, 512);
            this.pnl_Reportes.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Silver;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(880, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteVentasToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(154, 24);
            this.reportesToolStripMenuItem.Text = "Todos los Reportes";
            // 
            // reporteVentasToolStripMenuItem
            // 
            this.reporteVentasToolStripMenuItem.Name = "reporteVentasToolStripMenuItem";
            this.reporteVentasToolStripMenuItem.Size = new System.Drawing.Size(185, 24);
            this.reporteVentasToolStripMenuItem.Text = "Reporte Ventas";
            // 
            // dgv_enseñarVentas
            // 
            this.dgv_enseñarVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_enseñarVentas.Location = new System.Drawing.Point(0, 28);
            this.dgv_enseñarVentas.Name = "dgv_enseñarVentas";
            this.dgv_enseñarVentas.Size = new System.Drawing.Size(880, 492);
            this.dgv_enseñarVentas.TabIndex = 0;
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
            this.tsbtnImprimir});
            this.tsClientes.Location = new System.Drawing.Point(0, 0);
            this.tsClientes.Name = "tsClientes";
            this.tsClientes.Size = new System.Drawing.Size(880, 28);
            this.tsClientes.TabIndex = 1;
            this.tsClientes.Text = "toolStrip1";
            // 
            // ttlbFiltrar
            // 
            this.ttlbFiltrar.Name = "ttlbFiltrar";
            this.ttlbFiltrar.Size = new System.Drawing.Size(40, 25);
            this.ttlbFiltrar.Text = "Filtrar:";
            // 
            // tstxtFiltrarCliente
            // 
            this.tstxtFiltrarCliente.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tstxtFiltrarCliente.Name = "tstxtFiltrarCliente";
            this.tstxtFiltrarCliente.Size = new System.Drawing.Size(110, 28);
            // 
            // tsbtnFiltrarCliente
            // 
            this.tsbtnFiltrarCliente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnFiltrarCliente.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnFiltrarCliente.Image")));
            this.tsbtnFiltrarCliente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnFiltrarCliente.Name = "tsbtnFiltrarCliente";
            this.tsbtnFiltrarCliente.Size = new System.Drawing.Size(23, 25);
            this.tsbtnFiltrarCliente.Text = "Buscar";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(58, 25);
            this.toolStripLabel1.Text = "Acciones:";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 28);
            // 
            // tsbtnImprimir
            // 
            this.tsbtnImprimir.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbtnImprimir.Image = global::ConsecionarioTecs.Properties.Resources.reportes;
            this.tsbtnImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnImprimir.Name = "tsbtnImprimir";
            this.tsbtnImprimir.Size = new System.Drawing.Size(113, 25);
            this.tsbtnImprimir.Text = "    Reportes";
            this.tsbtnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 540);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnl_Reportes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Reportes";
            this.Text = "Estadisticas";
            this.Load += new System.EventHandler(this.Estadisticas_Load);
            this.pnl_Reportes.ResumeLayout(false);
            this.pnl_Reportes.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_enseñarVentas)).EndInit();
            this.tsClientes.ResumeLayout(false);
            this.tsClientes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnl_Reportes;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteVentasToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgv_enseñarVentas;
        private System.Windows.Forms.ToolStrip tsClientes;
        private System.Windows.Forms.ToolStripLabel ttlbFiltrar;
        private System.Windows.Forms.ToolStripTextBox tstxtFiltrarCliente;
        private System.Windows.Forms.ToolStripButton tsbtnFiltrarCliente;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbtnImprimir;
    }
}