namespace FormularioDeInicio
{
    partial class SoporteEmpleados
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
            this.lblSoporteEmpleados = new System.Windows.Forms.Label();
            this.panaleta2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSoporteE = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.dgvSoporteE = new System.Windows.Forms.DataGridView();
            this.panaleta2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoporteE)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSoporteEmpleados
            // 
            this.lblSoporteEmpleados.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSoporteEmpleados.AutoSize = true;
            this.lblSoporteEmpleados.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoporteEmpleados.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSoporteEmpleados.Location = new System.Drawing.Point(3, 3);
            this.lblSoporteEmpleados.Name = "lblSoporteEmpleados";
            this.lblSoporteEmpleados.Size = new System.Drawing.Size(121, 26);
            this.lblSoporteEmpleados.TabIndex = 3;
            this.lblSoporteEmpleados.Text = "SOPORTE";
            // 
            // panaleta2
            // 
            this.panaleta2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panaleta2.Controls.Add(this.panel1);
            this.panaleta2.Controls.Add(this.lblSoporteEmpleados);
            this.panaleta2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panaleta2.Location = new System.Drawing.Point(0, 0);
            this.panaleta2.Margin = new System.Windows.Forms.Padding(2);
            this.panaleta2.Name = "panaleta2";
            this.panaleta2.Size = new System.Drawing.Size(800, 35);
            this.panaleta2.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 26);
            this.panel1.TabIndex = 5;
            // 
            // txtSoporteE
            // 
            this.txtSoporteE.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtSoporteE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSoporteE.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoporteE.Location = new System.Drawing.Point(8, 80);
            this.txtSoporteE.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoporteE.Multiline = true;
            this.txtSoporteE.Name = "txtSoporteE";
            this.txtSoporteE.Size = new System.Drawing.Size(781, 69);
            this.txtSoporteE.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(274, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Detalle inquietudes o problemas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(274, 173);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mensajes enviados y recibidos";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.Location = new System.Drawing.Point(693, 41);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(95, 34);
            this.btnEnviar.TabIndex = 10;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // dgvSoporteE
            // 
            this.dgvSoporteE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSoporteE.Location = new System.Drawing.Point(0, 209);
            this.dgvSoporteE.Name = "dgvSoporteE";
            this.dgvSoporteE.Size = new System.Drawing.Size(800, 239);
            this.dgvSoporteE.TabIndex = 11;
            // 
            // SoporteEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvSoporteE);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSoporteE);
            this.Controls.Add(this.panaleta2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SoporteEmpleados";
            this.Text = "SoporteClientes";
            this.Load += new System.EventHandler(this.SoporteEmpleados_Load);
            this.panaleta2.ResumeLayout(false);
            this.panaleta2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoporteE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSoporteEmpleados;
        private System.Windows.Forms.Panel panaleta2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSoporteE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.DataGridView dgvSoporteE;
    }
}