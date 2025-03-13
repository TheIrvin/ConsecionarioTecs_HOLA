namespace FormularioDeInicio
{
    partial class Estadisticas
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
            this.lblEstadisticas1 = new System.Windows.Forms.Label();
            this.lblxEst = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEstadisticas1
            // 
            this.lblEstadisticas1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEstadisticas1.AutoSize = true;
            this.lblEstadisticas1.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadisticas1.Location = new System.Drawing.Point(351, 0);
            this.lblEstadisticas1.Name = "lblEstadisticas1";
            this.lblEstadisticas1.Size = new System.Drawing.Size(180, 26);
            this.lblEstadisticas1.TabIndex = 0;
            this.lblEstadisticas1.Text = "ESTADÍSTICAS";
            this.lblEstadisticas1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblEstadisticas1.Click += new System.EventHandler(this.lblEstadisticas1_Click);
            // 
            // lblxEst
            // 
            this.lblxEst.AutoSize = true;
            this.lblxEst.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblxEst.Location = new System.Drawing.Point(0, 0);
            this.lblxEst.Name = "lblxEst";
            this.lblxEst.Size = new System.Drawing.Size(27, 26);
            this.lblxEst.TabIndex = 1;
            this.lblxEst.Text = "X";
            this.lblxEst.Click += new System.EventHandler(this.lblxEst_Click);
            // 
            // Estadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblxEst);
            this.Controls.Add(this.lblEstadisticas1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Estadisticas";
            this.Text = "Estadisticas";
            this.Load += new System.EventHandler(this.Estadisticas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEstadisticas1;
        private System.Windows.Forms.Label lblxEst;
    }
}