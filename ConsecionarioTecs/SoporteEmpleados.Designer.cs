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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panaleta2.SuspendLayout();
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
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(8, 80);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(781, 69);
            this.textBox1.TabIndex = 7;
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
            // SoporteEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panaleta2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SoporteEmpleados";
            this.Text = "SoporteClientes";
            this.panaleta2.ResumeLayout(false);
            this.panaleta2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSoporteEmpleados;
        private System.Windows.Forms.Panel panaleta2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}