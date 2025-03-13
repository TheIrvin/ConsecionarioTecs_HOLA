namespace FormularioDeInicio
{
    partial class ComprasClientes
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
            this.lblxComprasClientes = new System.Windows.Forms.Label();
            this.lblComprasClientes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblxComprasClientes
            // 
            this.lblxComprasClientes.AutoSize = true;
            this.lblxComprasClientes.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblxComprasClientes.Location = new System.Drawing.Point(0, 0);
            this.lblxComprasClientes.Name = "lblxComprasClientes";
            this.lblxComprasClientes.Size = new System.Drawing.Size(27, 26);
            this.lblxComprasClientes.TabIndex = 4;
            this.lblxComprasClientes.Text = "X";
            this.lblxComprasClientes.Click += new System.EventHandler(this.lblxComprasClientes_Click);
            // 
            // lblComprasClientes
            // 
            this.lblComprasClientes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblComprasClientes.AutoSize = true;
            this.lblComprasClientes.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComprasClientes.Location = new System.Drawing.Point(351, 0);
            this.lblComprasClientes.Name = "lblComprasClientes";
            this.lblComprasClientes.Size = new System.Drawing.Size(276, 26);
            this.lblComprasClientes.TabIndex = 3;
            this.lblComprasClientes.Text = "CARRITO DE COMPRAS";
            // 
            // ComprasClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblxComprasClientes);
            this.Controls.Add(this.lblComprasClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ComprasClientes";
            this.Text = "ComprasClientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblxComprasClientes;
        private System.Windows.Forms.Label lblComprasClientes;
    }
}