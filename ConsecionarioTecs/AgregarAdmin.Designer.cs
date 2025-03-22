namespace ConsecionarioTecs
{
    partial class AgregarAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarAdmin));
            this.panelAggAdmin = new System.Windows.Forms.Panel();
            this.btnCerrarA = new System.Windows.Forms.Button();
            this.lblAggUsuario = new System.Windows.Forms.Label();
            this.lblModificarUsuario = new System.Windows.Forms.Label();
            this.lblIDAgg = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUsuarioUsu = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtContraseñaUsuario = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSucursal = new System.Windows.Forms.TextBox();
            this.btnGuardarAdmin = new System.Windows.Forms.Button();
            this.btnCancelarAdmin = new System.Windows.Forms.Button();
            this.cboxPaisUsu = new System.Windows.Forms.ComboBox();
            this.cboxCargo = new System.Windows.Forms.ComboBox();
            this.cboxCiudad = new System.Windows.Forms.ComboBox();
            this.panelAggAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAggAdmin
            // 
            this.panelAggAdmin.BackColor = System.Drawing.SystemColors.Highlight;
            this.panelAggAdmin.Controls.Add(this.btnCerrarA);
            this.panelAggAdmin.Controls.Add(this.lblAggUsuario);
            this.panelAggAdmin.Controls.Add(this.lblModificarUsuario);
            this.panelAggAdmin.Controls.Add(this.lblIDAgg);
            this.panelAggAdmin.Controls.Add(this.txtID);
            this.panelAggAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAggAdmin.Location = new System.Drawing.Point(0, 0);
            this.panelAggAdmin.Name = "panelAggAdmin";
            this.panelAggAdmin.Size = new System.Drawing.Size(714, 34);
            this.panelAggAdmin.TabIndex = 0;
            this.panelAggAdmin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelAggAdmin_MouseDown);
            // 
            // btnCerrarA
            // 
            this.btnCerrarA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarA.FlatAppearance.BorderSize = 0;
            this.btnCerrarA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btnCerrarA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCerrarA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarA.Image = global::ConsecionarioTecs.Properties.Resources.Icono_cerrar_FN;
            this.btnCerrarA.Location = new System.Drawing.Point(677, 0);
            this.btnCerrarA.Name = "btnCerrarA";
            this.btnCerrarA.Size = new System.Drawing.Size(35, 34);
            this.btnCerrarA.TabIndex = 13;
            this.btnCerrarA.UseVisualStyleBackColor = true;
            this.btnCerrarA.Click += new System.EventHandler(this.btnCerrarA_Click);
            // 
            // lblAggUsuario
            // 
            this.lblAggUsuario.AutoSize = true;
            this.lblAggUsuario.Font = new System.Drawing.Font("Perpetua", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAggUsuario.Location = new System.Drawing.Point(5, 7);
            this.lblAggUsuario.Name = "lblAggUsuario";
            this.lblAggUsuario.Size = new System.Drawing.Size(160, 24);
            this.lblAggUsuario.TabIndex = 30;
            this.lblAggUsuario.Text = "Agregar Usuario";
            this.lblAggUsuario.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblModificarUsuario
            // 
            this.lblModificarUsuario.AutoSize = true;
            this.lblModificarUsuario.Font = new System.Drawing.Font("Perpetua", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificarUsuario.Location = new System.Drawing.Point(5, 7);
            this.lblModificarUsuario.Name = "lblModificarUsuario";
            this.lblModificarUsuario.Size = new System.Drawing.Size(176, 24);
            this.lblModificarUsuario.TabIndex = 31;
            this.lblModificarUsuario.Text = "Modificar Usuario";
            this.lblModificarUsuario.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblModificarUsuario.Visible = false;
            // 
            // lblIDAgg
            // 
            this.lblIDAgg.AutoSize = true;
            this.lblIDAgg.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDAgg.Location = new System.Drawing.Point(365, 9);
            this.lblIDAgg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIDAgg.Name = "lblIDAgg";
            this.lblIDAgg.Size = new System.Drawing.Size(32, 19);
            this.lblIDAgg.TabIndex = 45;
            this.lblIDAgg.Text = "ID:";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtID.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(405, 4);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtID.MaxLength = 5;
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(51, 25);
            this.txtID.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtEmail.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(106, 93);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.MaxLength = 60;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(594, 29);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtTelefono.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(529, 237);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTelefono.MaxLength = 10;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(171, 29);
            this.txtTelefono.TabIndex = 8;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtNombreUsuario.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreUsuario.Location = new System.Drawing.Point(107, 54);
            this.txtNombreUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombreUsuario.MaxLength = 40;
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(594, 29);
            this.txtNombreUsuario.TabIndex = 2;
            this.txtNombreUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreUsuario_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 95);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 22);
            this.label7.TabIndex = 53;
            this.label7.Text = "Email :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(417, 244);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 22);
            this.label4.TabIndex = 50;
            this.label4.Text = "Teléfono :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 190);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 22);
            this.label5.TabIndex = 49;
            this.label5.Text = "País :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(417, 191);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 22);
            this.label6.TabIndex = 48;
            this.label6.Text = "Ciudad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 237);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 22);
            this.label3.TabIndex = 47;
            this.label3.Text = "Cargo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 22);
            this.label2.TabIndex = 46;
            this.label2.Text = "Nombre :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(36, 299);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 22);
            this.label8.TabIndex = 67;
            this.label8.Text = "Usuario:";
            // 
            // txtUsuarioUsu
            // 
            this.txtUsuarioUsu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtUsuarioUsu.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarioUsu.Location = new System.Drawing.Point(136, 293);
            this.txtUsuarioUsu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUsuarioUsu.MaxLength = 50;
            this.txtUsuarioUsu.Name = "txtUsuarioUsu";
            this.txtUsuarioUsu.Size = new System.Drawing.Size(171, 29);
            this.txtUsuarioUsu.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(346, 299);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 22);
            this.label9.TabIndex = 69;
            this.label9.Text = "Contraseña:";
            // 
            // txtContraseñaUsuario
            // 
            this.txtContraseñaUsuario.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtContraseñaUsuario.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseñaUsuario.Location = new System.Drawing.Point(466, 297);
            this.txtContraseñaUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtContraseñaUsuario.MaxLength = 50;
            this.txtContraseñaUsuario.Name = "txtContraseñaUsuario";
            this.txtContraseñaUsuario.Size = new System.Drawing.Size(191, 29);
            this.txtContraseñaUsuario.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Location = new System.Drawing.Point(1, 233);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 26);
            this.panel2.TabIndex = 71;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 187);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 26);
            this.panel1.TabIndex = 72;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel3.Location = new System.Drawing.Point(0, 53);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 26);
            this.panel3.TabIndex = 72;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel4.Location = new System.Drawing.Point(405, 240);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 26);
            this.panel4.TabIndex = 73;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel6.Location = new System.Drawing.Point(339, 296);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(5, 26);
            this.panel6.TabIndex = 72;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel7.Location = new System.Drawing.Point(405, 190);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(5, 26);
            this.panel7.TabIndex = 74;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel8.Location = new System.Drawing.Point(1, 93);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(5, 26);
            this.panel8.TabIndex = 72;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel9.Location = new System.Drawing.Point(32, 296);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(5, 26);
            this.panel9.TabIndex = 75;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel10.Location = new System.Drawing.Point(1, 135);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(5, 26);
            this.panel10.TabIndex = 76;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 137);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 22);
            this.label10.TabIndex = 77;
            this.label10.Text = "Sucursal :";
            // 
            // txtSucursal
            // 
            this.txtSucursal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtSucursal.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSucursal.Location = new System.Drawing.Point(106, 132);
            this.txtSucursal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSucursal.MaxLength = 20;
            this.txtSucursal.Name = "txtSucursal";
            this.txtSucursal.Size = new System.Drawing.Size(594, 29);
            this.txtSucursal.TabIndex = 4;
            this.txtSucursal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSucursal_KeyPress);
            // 
            // btnGuardarAdmin
            // 
            this.btnGuardarAdmin.BackColor = System.Drawing.Color.DarkGray;
            this.btnGuardarAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarAdmin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnGuardarAdmin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btnGuardarAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarAdmin.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarAdmin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGuardarAdmin.Location = new System.Drawing.Point(80, 366);
            this.btnGuardarAdmin.Name = "btnGuardarAdmin";
            this.btnGuardarAdmin.Size = new System.Drawing.Size(214, 43);
            this.btnGuardarAdmin.TabIndex = 11;
            this.btnGuardarAdmin.Text = "Guardar";
            this.btnGuardarAdmin.UseVisualStyleBackColor = false;
            this.btnGuardarAdmin.Click += new System.EventHandler(this.btnGuardarAdmin_Click);
            // 
            // btnCancelarAdmin
            // 
            this.btnCancelarAdmin.BackColor = System.Drawing.Color.DarkGray;
            this.btnCancelarAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarAdmin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnCancelarAdmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCancelarAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarAdmin.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarAdmin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancelarAdmin.Location = new System.Drawing.Point(405, 366);
            this.btnCancelarAdmin.Name = "btnCancelarAdmin";
            this.btnCancelarAdmin.Size = new System.Drawing.Size(214, 43);
            this.btnCancelarAdmin.TabIndex = 12;
            this.btnCancelarAdmin.Text = "Cancelar";
            this.btnCancelarAdmin.UseVisualStyleBackColor = false;
            this.btnCancelarAdmin.Click += new System.EventHandler(this.btnCancelarAdmin_Click);
            // 
            // cboxPaisUsu
            // 
            this.cboxPaisUsu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cboxPaisUsu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxPaisUsu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboxPaisUsu.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxPaisUsu.FormattingEnabled = true;
            this.cboxPaisUsu.Items.AddRange(new object[] {
            "Ecuador"});
            this.cboxPaisUsu.Location = new System.Drawing.Point(129, 191);
            this.cboxPaisUsu.Name = "cboxPaisUsu";
            this.cboxPaisUsu.Size = new System.Drawing.Size(148, 25);
            this.cboxPaisUsu.TabIndex = 5;
            // 
            // cboxCargo
            // 
            this.cboxCargo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cboxCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxCargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboxCargo.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxCargo.FormattingEnabled = true;
            this.cboxCargo.Items.AddRange(new object[] {
            "Administrador",
            "Empleado"});
            this.cboxCargo.Location = new System.Drawing.Point(129, 237);
            this.cboxCargo.Name = "cboxCargo";
            this.cboxCargo.Size = new System.Drawing.Size(148, 25);
            this.cboxCargo.TabIndex = 7;
            // 
            // cboxCiudad
            // 
            this.cboxCiudad.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cboxCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxCiudad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboxCiudad.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxCiudad.FormattingEnabled = true;
            this.cboxCiudad.Items.AddRange(new object[] {
            "Ambato",
            "Azogues",
            "Babahoyo",
            "Buena Fe",
            "Cayambe",
            "Chone",
            "Cuenca",
            "Durán",
            "Esmeraldas",
            "Guaranda",
            "Guayaquil",
            "Ibarra",
            "Jipijapa",
            "La Tronca",
            "Latacunga",
            "Loja",
            "Macas",
            "Machala",
            "Manta",
            "Milagro",
            "Montecristi",
            "Nueva Loja (Lago Agrio)",
            "Otavalo",
            "Pasaje",
            "Portoviejo",
            "Puyo",
            "Quevedo",
            "Quito",
            "Riobamba",
            "Salinas",
            "San Gabriel",
            "Santa Elena",
            "Santa Rosa",
            "Santo Domingo",
            "Tulcán",
            "Zamora"});
            this.cboxCiudad.Location = new System.Drawing.Point(529, 190);
            this.cboxCiudad.Name = "cboxCiudad";
            this.cboxCiudad.Size = new System.Drawing.Size(171, 25);
            this.cboxCiudad.TabIndex = 6;
            // 
            // AgregarAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(714, 436);
            this.Controls.Add(this.cboxCiudad);
            this.Controls.Add(this.cboxCargo);
            this.Controls.Add(this.cboxPaisUsu);
            this.Controls.Add(this.btnCancelarAdmin);
            this.Controls.Add(this.btnGuardarAdmin);
            this.Controls.Add(this.txtSucursal);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtContraseñaUsuario);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtUsuarioUsu);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtNombreUsuario);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelAggAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AgregarAdmin";
            this.Text = "AgregarAdmin";
            this.Load += new System.EventHandler(this.AgregarAdmin_Load);
            this.panelAggAdmin.ResumeLayout(false);
            this.panelAggAdmin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelAggAdmin;
        private System.Windows.Forms.Button btnCerrarA;
        public System.Windows.Forms.TextBox txtEmail;
        public System.Windows.Forms.TextBox txtTelefono;
        public System.Windows.Forms.TextBox txtNombreUsuario;
        public System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblIDAgg;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtUsuarioUsu;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txtContraseñaUsuario;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox txtSucursal;
        private System.Windows.Forms.Button btnGuardarAdmin;
        private System.Windows.Forms.Button btnCancelarAdmin;
        public System.Windows.Forms.Label lblAggUsuario;
        public System.Windows.Forms.Label lblModificarUsuario;
        public System.Windows.Forms.ComboBox cboxPaisUsu;
        public System.Windows.Forms.ComboBox cboxCargo;
        public System.Windows.Forms.ComboBox cboxCiudad;
    }
}