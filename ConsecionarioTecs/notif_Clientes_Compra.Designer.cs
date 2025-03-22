namespace ConsecionarioTecs
{
    partial class notif_Clientes_Compra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(notif_Clientes_Compra));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_verProveedor = new System.Windows.Forms.DataGridView();
            this.tsClientes = new System.Windows.Forms.ToolStrip();
            this.ttlbFiltrar = new System.Windows.Forms.ToolStripLabel();
            this.tstxtFiltrarCliente = new System.Windows.Forms.ToolStripTextBox();
            this.tsbtnFiltrarCliente = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_verProveedor)).BeginInit();
            this.tsClientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.tsClientes);
            this.panel1.Controls.Add(this.dgv_verProveedor);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(880, 547);
            this.panel1.TabIndex = 0;
            // 
            // dgv_verProveedor
            // 
            this.dgv_verProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_verProveedor.Location = new System.Drawing.Point(0, 25);
            this.dgv_verProveedor.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.dgv_verProveedor.Name = "dgv_verProveedor";
            this.dgv_verProveedor.Size = new System.Drawing.Size(879, 517);
            this.dgv_verProveedor.TabIndex = 0;
            // 
            // tsClientes
            // 
            this.tsClientes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ttlbFiltrar,
            this.tstxtFiltrarCliente,
            this.tsbtnFiltrarCliente,
            this.toolStripSeparator1,
            this.toolStripSeparator2});
            this.tsClientes.Location = new System.Drawing.Point(0, 0);
            this.tsClientes.Name = "tsClientes";
            this.tsClientes.Size = new System.Drawing.Size(880, 25);
            this.tsClientes.TabIndex = 2;
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
            // 
            // tsbtnFiltrarCliente
            // 
            this.tsbtnFiltrarCliente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnFiltrarCliente.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnFiltrarCliente.Image")));
            this.tsbtnFiltrarCliente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnFiltrarCliente.Name = "tsbtnFiltrarCliente";
            this.tsbtnFiltrarCliente.Size = new System.Drawing.Size(23, 22);
            this.tsbtnFiltrarCliente.Text = "Buscar";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // notif_Clientes_Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 540);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "notif_Clientes_Compra";
            this.Text = "notif_Clientes_Compra";
            this.Load += new System.EventHandler(this.notif_Clientes_Compra_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_verProveedor)).EndInit();
            this.tsClientes.ResumeLayout(false);
            this.tsClientes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_verProveedor;
        private System.Windows.Forms.ToolStrip tsClientes;
        private System.Windows.Forms.ToolStripLabel ttlbFiltrar;
        private System.Windows.Forms.ToolStripTextBox tstxtFiltrarCliente;
        private System.Windows.Forms.ToolStripButton tsbtnFiltrarCliente;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}