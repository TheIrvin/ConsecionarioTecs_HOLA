namespace FormularioDeInicio
{
    partial class CatalogoCliente
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
            this.lblCatalogoMotos = new System.Windows.Forms.Label();
            this.lblxCatalogoMotos = new System.Windows.Forms.Label();
            this.panelCatalogoMotos = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelContenedorCatalogo = new System.Windows.Forms.Panel();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.txtFiltroMotos = new System.Windows.Forms.TextBox();
            this.flpMotosUsuario = new System.Windows.Forms.FlowLayoutPanel();
            this.panelCatalogoMotos.SuspendLayout();
            this.panelContenedorCatalogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCatalogoMotos
            // 
            this.lblCatalogoMotos.AutoSize = true;
            this.lblCatalogoMotos.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatalogoMotos.Location = new System.Drawing.Point(8, 0);
            this.lblCatalogoMotos.Name = "lblCatalogoMotos";
            this.lblCatalogoMotos.Size = new System.Drawing.Size(269, 26);
            this.lblCatalogoMotos.TabIndex = 1;
            this.lblCatalogoMotos.Text = "CATÁLOGO DE MOTOS";
            // 
            // lblxCatalogoMotos
            // 
            this.lblxCatalogoMotos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblxCatalogoMotos.AutoSize = true;
            this.lblxCatalogoMotos.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblxCatalogoMotos.Location = new System.Drawing.Point(770, 0);
            this.lblxCatalogoMotos.Name = "lblxCatalogoMotos";
            this.lblxCatalogoMotos.Size = new System.Drawing.Size(27, 26);
            this.lblxCatalogoMotos.TabIndex = 2;
            this.lblxCatalogoMotos.Text = "X";
            this.lblxCatalogoMotos.Click += new System.EventHandler(this.lblxCatalogoClientes_Click);
            // 
            // panelCatalogoMotos
            // 
            this.panelCatalogoMotos.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelCatalogoMotos.Controls.Add(this.txtFiltroMotos);
            this.panelCatalogoMotos.Controls.Add(this.btnFiltrar);
            this.panelCatalogoMotos.Controls.Add(this.panel2);
            this.panelCatalogoMotos.Controls.Add(this.lblCatalogoMotos);
            this.panelCatalogoMotos.Controls.Add(this.lblxCatalogoMotos);
            this.panelCatalogoMotos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCatalogoMotos.Location = new System.Drawing.Point(0, 0);
            this.panelCatalogoMotos.Name = "panelCatalogoMotos";
            this.panelCatalogoMotos.Size = new System.Drawing.Size(800, 65);
            this.panelCatalogoMotos.TabIndex = 3;
            this.panelCatalogoMotos.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCatalogoMotos_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 26);
            this.panel2.TabIndex = 5;
            // 
            // panelContenedorCatalogo
            // 
            this.panelContenedorCatalogo.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelContenedorCatalogo.Controls.Add(this.flpMotosUsuario);
            this.panelContenedorCatalogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedorCatalogo.Location = new System.Drawing.Point(0, 65);
            this.panelContenedorCatalogo.Name = "panelContenedorCatalogo";
            this.panelContenedorCatalogo.Size = new System.Drawing.Size(800, 385);
            this.panelContenedorCatalogo.TabIndex = 6;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFiltrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.Image = global::ConsecionarioTecs.Properties.Resources.cabeza;
            this.btnFiltrar.Location = new System.Drawing.Point(727, 35);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(73, 30);
            this.btnFiltrar.TabIndex = 6;
            this.btnFiltrar.Text = "Buscar";
            this.btnFiltrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFiltrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFiltrar.UseVisualStyleBackColor = true;
            // 
            // txtFiltroMotos
            // 
            this.txtFiltroMotos.Location = new System.Drawing.Point(611, 45);
            this.txtFiltroMotos.Name = "txtFiltroMotos";
            this.txtFiltroMotos.Size = new System.Drawing.Size(116, 20);
            this.txtFiltroMotos.TabIndex = 7;
            // 
            // flpMotosUsuario
            // 
            this.flpMotosUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpMotosUsuario.Location = new System.Drawing.Point(0, 0);
            this.flpMotosUsuario.Name = "flpMotosUsuario";
            this.flpMotosUsuario.Size = new System.Drawing.Size(800, 385);
            this.flpMotosUsuario.TabIndex = 0;
            // 
            // CatalogoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelContenedorCatalogo);
            this.Controls.Add(this.panelCatalogoMotos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CatalogoCliente";
            this.Text = "CatalogoCliente";
            this.panelCatalogoMotos.ResumeLayout(false);
            this.panelCatalogoMotos.PerformLayout();
            this.panelContenedorCatalogo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCatalogoMotos;
        private System.Windows.Forms.Label lblxCatalogoMotos;
        private System.Windows.Forms.Panel panelCatalogoMotos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelContenedorCatalogo;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.TextBox txtFiltroMotos;
        private System.Windows.Forms.FlowLayoutPanel flpMotosUsuario;
    }
}