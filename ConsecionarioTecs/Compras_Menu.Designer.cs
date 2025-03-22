namespace ConsecionarioTecs
{
    partial class Compras_Menu
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
            this.pnl_Compra_Menu = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.verProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarProveedoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sugerenciaDeCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Compra_Menu
            // 
            this.pnl_Compra_Menu.Location = new System.Drawing.Point(0, 29);
            this.pnl_Compra_Menu.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.pnl_Compra_Menu.Name = "pnl_Compra_Menu";
            this.pnl_Compra_Menu.Size = new System.Drawing.Size(880, 535);
            this.pnl_Compra_Menu.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkGray;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verProveedoresToolStripMenuItem,
            this.sugerenciaDeCompraToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(880, 29);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // verProveedoresToolStripMenuItem
            // 
            this.verProveedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visualizarProveedoreToolStripMenuItem});
            this.verProveedoresToolStripMenuItem.Name = "verProveedoresToolStripMenuItem";
            this.verProveedoresToolStripMenuItem.Size = new System.Drawing.Size(119, 25);
            this.verProveedoresToolStripMenuItem.Text = " Proveedores";
            // 
            // visualizarProveedoreToolStripMenuItem
            // 
            this.visualizarProveedoreToolStripMenuItem.Name = "visualizarProveedoreToolStripMenuItem";
            this.visualizarProveedoreToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.visualizarProveedoreToolStripMenuItem.Text = " Comprar a Proveedor";
            this.visualizarProveedoreToolStripMenuItem.Click += new System.EventHandler(this.visualizarProveedoreToolStripMenuItem_Click_1);
            // 
            // sugerenciaDeCompraToolStripMenuItem
            // 
            this.sugerenciaDeCompraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem});
            this.sugerenciaDeCompraToolStripMenuItem.Name = "sugerenciaDeCompraToolStripMenuItem";
            this.sugerenciaDeCompraToolStripMenuItem.Size = new System.Drawing.Size(143, 25);
            this.sugerenciaDeCompraToolStripMenuItem.Text = "Ver Proveedores";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.clienteToolStripMenuItem.Text = "Comprar";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // Compras_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 540);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnl_Compra_Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Compras_Menu";
            this.Text = "Compras_Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem verProveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizarProveedoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sugerenciaDeCompraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        public System.Windows.Forms.Panel pnl_Compra_Menu;
    }
}