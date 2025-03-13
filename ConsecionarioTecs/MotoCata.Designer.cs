namespace ConsecionarioTecs
{
    partial class MotoCata
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelControl = new System.Windows.Forms.Panel();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.btnDifiere = new System.Windows.Forms.Button();
            this.btnComprar = new System.Windows.Forms.Button();
            this.ptbMotos = new System.Windows.Forms.PictureBox();
            this.panelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMotos)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl
            // 
            this.panelControl.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelControl.Controls.Add(this.btnComprar);
            this.panelControl.Controls.Add(this.btnDifiere);
            this.panelControl.Controls.Add(this.lblPrecio);
            this.panelControl.Controls.Add(this.ptbMotos);
            this.panelControl.Controls.Add(this.lblModelo);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl.Location = new System.Drawing.Point(0, 0);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(359, 279);
            this.panelControl.TabIndex = 0;
            this.panelControl.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl_Paint);
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblModelo.Location = new System.Drawing.Point(193, 25);
            this.lblModelo.MaximumSize = new System.Drawing.Size(300, 0);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(117, 19);
            this.lblModelo.TabIndex = 0;
            this.lblModelo.Text = "Modelo Moto";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.ForeColor = System.Drawing.SystemColors.Info;
            this.lblPrecio.Location = new System.Drawing.Point(196, 61);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(64, 19);
            this.lblPrecio.TabIndex = 2;
            this.lblPrecio.Text = "9000$";
            // 
            // btnDifiere
            // 
            this.btnDifiere.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDifiere.FlatAppearance.BorderSize = 3;
            this.btnDifiere.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDifiere.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDifiere.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btnDifiere.Location = new System.Drawing.Point(211, 164);
            this.btnDifiere.Name = "btnDifiere";
            this.btnDifiere.Size = new System.Drawing.Size(131, 35);
            this.btnDifiere.TabIndex = 3;
            this.btnDifiere.Text = "SOLICITAR CREDITO";
            this.btnDifiere.UseVisualStyleBackColor = true;
            // 
            // btnComprar
            // 
            this.btnComprar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnComprar.FlatAppearance.BorderSize = 3;
            this.btnComprar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComprar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprar.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btnComprar.Location = new System.Drawing.Point(210, 216);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(131, 35);
            this.btnComprar.TabIndex = 4;
            this.btnComprar.Text = "COMPRAR";
            this.btnComprar.UseVisualStyleBackColor = true;
            // 
            // ptbMotos
            // 
            this.ptbMotos.Image = global::ConsecionarioTecs.Properties.Resources.MotoEjemplo;
            this.ptbMotos.Location = new System.Drawing.Point(9, 20);
            this.ptbMotos.Name = "ptbMotos";
            this.ptbMotos.Size = new System.Drawing.Size(181, 241);
            this.ptbMotos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbMotos.TabIndex = 1;
            this.ptbMotos.TabStop = false;
            // 
            // MotoCata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl);
            this.Name = "MotoCata";
            this.Size = new System.Drawing.Size(359, 279);
            this.panelControl.ResumeLayout(false);
            this.panelControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMotos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.PictureBox ptbMotos;
        private System.Windows.Forms.Button btnDifiere;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Button btnComprar;
    }
}
