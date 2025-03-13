namespace ConsecionarioTecs
{
    partial class MotoInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MotoInfo));
            this.panelCabecerainfo = new System.Windows.Forms.Panel();
            this.btnCerrarLogin = new System.Windows.Forms.Button();
            this.lblModelo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ptbMotos = new System.Windows.Forms.PictureBox();
            this.panelCabecerainfo.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMotos)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCabecerainfo
            // 
            this.panelCabecerainfo.BackColor = System.Drawing.SystemColors.ControlText;
            this.panelCabecerainfo.Controls.Add(this.btnCerrarLogin);
            this.panelCabecerainfo.Controls.Add(this.lblModelo);
            this.panelCabecerainfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCabecerainfo.Location = new System.Drawing.Point(0, 0);
            this.panelCabecerainfo.Name = "panelCabecerainfo";
            this.panelCabecerainfo.Size = new System.Drawing.Size(522, 52);
            this.panelCabecerainfo.TabIndex = 0;
            // 
            // btnCerrarLogin
            // 
            this.btnCerrarLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarLogin.FlatAppearance.BorderSize = 0;
            this.btnCerrarLogin.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCerrarLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCerrarLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarLogin.Image = global::ConsecionarioTecs.Properties.Resources.Icono_cerrar_FN;
            this.btnCerrarLogin.Location = new System.Drawing.Point(486, 4);
            this.btnCerrarLogin.Name = "btnCerrarLogin";
            this.btnCerrarLogin.Size = new System.Drawing.Size(34, 34);
            this.btnCerrarLogin.TabIndex = 10;
            this.btnCerrarLogin.UseVisualStyleBackColor = true;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblModelo.Location = new System.Drawing.Point(193, 15);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(137, 22);
            this.lblModelo.TabIndex = 1;
            this.lblModelo.Text = "Modelo Moto";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.lblDescripcion);
            this.panel1.Controls.Add(this.lblPrecio);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ptbMotos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(522, 338);
            this.panel1.TabIndex = 1;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblDescripcion.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.White;
            this.lblDescripcion.Location = new System.Drawing.Point(281, 118);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(93, 18);
            this.lblDescripcion.TabIndex = 5;
            this.lblDescripcion.Text = "Descripción";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.BackColor = System.Drawing.Color.Transparent;
            this.lblPrecio.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.ForeColor = System.Drawing.Color.Gold;
            this.lblPrecio.Location = new System.Drawing.Point(290, 62);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(64, 20);
            this.lblPrecio.TabIndex = 4;
            this.lblPrecio.Text = "9000$";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(289, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Modelo Moto";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ptbMotos
            // 
            this.ptbMotos.Image = global::ConsecionarioTecs.Properties.Resources.MotoEjemplo;
            this.ptbMotos.Location = new System.Drawing.Point(12, 24);
            this.ptbMotos.Name = "ptbMotos";
            this.ptbMotos.Size = new System.Drawing.Size(238, 278);
            this.ptbMotos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbMotos.TabIndex = 2;
            this.ptbMotos.TabStop = false;
            // 
            // MotoInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 390);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelCabecerainfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MotoInfo";
            this.Text = "MotoInfo";
            this.panelCabecerainfo.ResumeLayout(false);
            this.panelCabecerainfo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMotos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCabecerainfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.PictureBox ptbMotos;
        private System.Windows.Forms.Button btnCerrarLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblDescripcion;
    }
}