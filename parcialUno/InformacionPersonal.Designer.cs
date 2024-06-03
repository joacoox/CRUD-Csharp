namespace parcialUno
{
    partial class InformacionPersonal
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
            lblNombre = new Label();
            lblContraseña = new Label();
            txtContraseña = new TextBox();
            txtNombre = new TextBox();
            btnVer = new Button();
            btnNoVer = new Button();
            lblNumeroTarjeta = new Label();
            lblCodigoSeguridad = new Label();
            lblBanco = new Label();
            lblFechaVencimiento = new Label();
            txtFechaVencimiento = new TextBox();
            txtCodigoSeguridad = new TextBox();
            txtNumeroTarjeta = new TextBox();
            pnlDatosBancarios = new Panel();
            lsbBanco = new ListBox();
            btnCargar = new Button();
            txtAgregarSaldo = new TextBox();
            lblAgregarSaldo = new Label();
            btnMostrarDatos = new Button();
            btnEsconderDatos = new Button();
            btnAceptar = new Button();
            txtSaldo = new TextBox();
            lblSaldo = new Label();
            pnlSaldo = new Panel();
            cmbBaseDeDatos = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            cmbVentas = new ComboBox();
            btnAplicarCambios = new Button();
            pnlConfiguraciones = new Panel();
            pnlDatosBancarios.SuspendLayout();
            pnlSaldo.SuspendLayout();
            pnlConfiguraciones.SuspendLayout();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.ForeColor = SystemColors.ButtonHighlight;
            lblNombre.Location = new Point(268, 97);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(123, 33);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.BackColor = Color.Transparent;
            lblContraseña.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblContraseña.ForeColor = SystemColors.ButtonHighlight;
            lblContraseña.Location = new Point(268, 153);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(169, 33);
            lblContraseña.TabIndex = 1;
            lblContraseña.Text = "Contraseña";
            // 
            // txtContraseña
            // 
            txtContraseña.BackColor = Color.FromArgb(11, 7, 17);
            txtContraseña.BorderStyle = BorderStyle.FixedSingle;
            txtContraseña.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtContraseña.ForeColor = SystemColors.Window;
            txtContraseña.Location = new Point(450, 145);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.ReadOnly = true;
            txtContraseña.Size = new Size(128, 41);
            txtContraseña.TabIndex = 5;
            txtContraseña.UseSystemPasswordChar = true;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.FromArgb(11, 7, 17);
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.ForeColor = Color.White;
            txtNombre.Location = new Point(450, 89);
            txtNombre.Name = "txtNombre";
            txtNombre.ReadOnly = true;
            txtNombre.Size = new Size(128, 41);
            txtNombre.TabIndex = 4;
            // 
            // btnVer
            // 
            btnVer.FlatAppearance.BorderSize = 0;
            btnVer.FlatStyle = FlatStyle.Flat;
            btnVer.Image = Properties.Resources.ver;
            btnVer.Location = new Point(597, 145);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(75, 41);
            btnVer.TabIndex = 6;
            btnVer.UseVisualStyleBackColor = true;
            btnVer.Click += btnVer_Click;
            // 
            // btnNoVer
            // 
            btnNoVer.FlatAppearance.BorderSize = 0;
            btnNoVer.FlatStyle = FlatStyle.Flat;
            btnNoVer.Image = Properties.Resources.nover;
            btnNoVer.Location = new Point(597, 145);
            btnNoVer.Name = "btnNoVer";
            btnNoVer.Size = new Size(75, 41);
            btnNoVer.TabIndex = 7;
            btnNoVer.UseVisualStyleBackColor = true;
            btnNoVer.Click += btnNoVer_Click;
            // 
            // lblNumeroTarjeta
            // 
            lblNumeroTarjeta.AutoSize = true;
            lblNumeroTarjeta.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblNumeroTarjeta.ForeColor = SystemColors.ActiveCaptionText;
            lblNumeroTarjeta.Location = new Point(81, 3);
            lblNumeroTarjeta.Name = "lblNumeroTarjeta";
            lblNumeroTarjeta.Size = new Size(260, 33);
            lblNumeroTarjeta.TabIndex = 8;
            lblNumeroTarjeta.Text = "Numero de tarjeta";
            // 
            // lblCodigoSeguridad
            // 
            lblCodigoSeguridad.AutoSize = true;
            lblCodigoSeguridad.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblCodigoSeguridad.ForeColor = SystemColors.ActiveCaptionText;
            lblCodigoSeguridad.Location = new Point(42, 45);
            lblCodigoSeguridad.Name = "lblCodigoSeguridad";
            lblCodigoSeguridad.Size = new Size(299, 33);
            lblCodigoSeguridad.TabIndex = 9;
            lblCodigoSeguridad.Text = "Codigo de seguridad";
            // 
            // lblBanco
            // 
            lblBanco.AutoSize = true;
            lblBanco.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblBanco.ForeColor = SystemColors.ActiveCaptionText;
            lblBanco.Location = new Point(231, 84);
            lblBanco.Name = "lblBanco";
            lblBanco.Size = new Size(100, 33);
            lblBanco.TabIndex = 10;
            lblBanco.Text = "Banco";
            // 
            // lblFechaVencimiento
            // 
            lblFechaVencimiento.AutoSize = true;
            lblFechaVencimiento.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblFechaVencimiento.ForeColor = SystemColors.ActiveCaptionText;
            lblFechaVencimiento.Location = new Point(25, 117);
            lblFechaVencimiento.Name = "lblFechaVencimiento";
            lblFechaVencimiento.Size = new Size(316, 33);
            lblFechaVencimiento.TabIndex = 11;
            lblFechaVencimiento.Text = "Fecha de vencimiento";
            // 
            // txtFechaVencimiento
            // 
            txtFechaVencimiento.BackColor = Color.FromArgb(11, 7, 17);
            txtFechaVencimiento.BorderStyle = BorderStyle.FixedSingle;
            txtFechaVencimiento.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtFechaVencimiento.ForeColor = Color.White;
            txtFechaVencimiento.Location = new Point(356, 123);
            txtFechaVencimiento.MaxLength = 5;
            txtFechaVencimiento.Name = "txtFechaVencimiento";
            txtFechaVencimiento.Size = new Size(111, 33);
            txtFechaVencimiento.TabIndex = 12;
            txtFechaVencimiento.Text = "00/00";
            // 
            // txtCodigoSeguridad
            // 
            txtCodigoSeguridad.BackColor = Color.FromArgb(11, 7, 17);
            txtCodigoSeguridad.BorderStyle = BorderStyle.FixedSingle;
            txtCodigoSeguridad.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtCodigoSeguridad.ForeColor = Color.White;
            txtCodigoSeguridad.Location = new Point(356, 45);
            txtCodigoSeguridad.MaxLength = 3;
            txtCodigoSeguridad.Name = "txtCodigoSeguridad";
            txtCodigoSeguridad.Size = new Size(111, 33);
            txtCodigoSeguridad.TabIndex = 13;
            txtCodigoSeguridad.Text = "000";
            // 
            // txtNumeroTarjeta
            // 
            txtNumeroTarjeta.BackColor = Color.FromArgb(11, 7, 17);
            txtNumeroTarjeta.BorderStyle = BorderStyle.FixedSingle;
            txtNumeroTarjeta.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtNumeroTarjeta.ForeColor = Color.White;
            txtNumeroTarjeta.Location = new Point(356, 3);
            txtNumeroTarjeta.MaxLength = 16;
            txtNumeroTarjeta.Name = "txtNumeroTarjeta";
            txtNumeroTarjeta.Size = new Size(218, 33);
            txtNumeroTarjeta.TabIndex = 15;
            txtNumeroTarjeta.Text = "0000000000000000";
            // 
            // pnlDatosBancarios
            // 
            pnlDatosBancarios.BackColor = Color.FromArgb(200, 192, 255);
            pnlDatosBancarios.Controls.Add(lsbBanco);
            pnlDatosBancarios.Controls.Add(txtCodigoSeguridad);
            pnlDatosBancarios.Controls.Add(txtNumeroTarjeta);
            pnlDatosBancarios.Controls.Add(lblNumeroTarjeta);
            pnlDatosBancarios.Controls.Add(lblCodigoSeguridad);
            pnlDatosBancarios.Controls.Add(lblBanco);
            pnlDatosBancarios.Controls.Add(txtFechaVencimiento);
            pnlDatosBancarios.Controls.Add(lblFechaVencimiento);
            pnlDatosBancarios.Location = new Point(12, 235);
            pnlDatosBancarios.Name = "pnlDatosBancarios";
            pnlDatosBancarios.Size = new Size(577, 166);
            pnlDatosBancarios.TabIndex = 16;
            // 
            // lsbBanco
            // 
            lsbBanco.BackColor = Color.FromArgb(11, 7, 17);
            lsbBanco.BorderStyle = BorderStyle.None;
            lsbBanco.ForeColor = SystemColors.Window;
            lsbBanco.FormattingEnabled = true;
            lsbBanco.ItemHeight = 15;
            lsbBanco.Location = new Point(356, 96);
            lsbBanco.Name = "lsbBanco";
            lsbBanco.Size = new Size(111, 15);
            lsbBanco.TabIndex = 16;
            // 
            // btnCargar
            // 
            btnCargar.BackColor = Color.FromArgb(255, 192, 255);
            btnCargar.FlatAppearance.BorderSize = 0;
            btnCargar.FlatStyle = FlatStyle.Flat;
            btnCargar.ForeColor = SystemColors.ActiveCaptionText;
            btnCargar.Location = new Point(371, 34);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(112, 33);
            btnCargar.TabIndex = 23;
            btnCargar.Text = "Cargar";
            btnCargar.UseVisualStyleBackColor = false;
            btnCargar.Click += btnCargar_Click;
            // 
            // txtAgregarSaldo
            // 
            txtAgregarSaldo.BackColor = Color.FromArgb(11, 7, 17);
            txtAgregarSaldo.BorderStyle = BorderStyle.FixedSingle;
            txtAgregarSaldo.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtAgregarSaldo.ForeColor = SystemColors.Window;
            txtAgregarSaldo.Location = new Point(225, 32);
            txtAgregarSaldo.Name = "txtAgregarSaldo";
            txtAgregarSaldo.Size = new Size(140, 41);
            txtAgregarSaldo.TabIndex = 23;
            // 
            // lblAgregarSaldo
            // 
            lblAgregarSaldo.AutoSize = true;
            lblAgregarSaldo.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblAgregarSaldo.ForeColor = SystemColors.ActiveCaptionText;
            lblAgregarSaldo.Location = new Point(16, 34);
            lblAgregarSaldo.Name = "lblAgregarSaldo";
            lblAgregarSaldo.Size = new Size(203, 33);
            lblAgregarSaldo.TabIndex = 24;
            lblAgregarSaldo.Text = "Agregar Saldo";
            // 
            // btnMostrarDatos
            // 
            btnMostrarDatos.BackColor = Color.FromArgb(255, 192, 255);
            btnMostrarDatos.FlatAppearance.BorderSize = 0;
            btnMostrarDatos.FlatStyle = FlatStyle.Flat;
            btnMostrarDatos.ForeColor = SystemColors.ActiveCaptionText;
            btnMostrarDatos.Location = new Point(597, 254);
            btnMostrarDatos.Name = "btnMostrarDatos";
            btnMostrarDatos.Size = new Size(112, 42);
            btnMostrarDatos.TabIndex = 18;
            btnMostrarDatos.Text = "Mostrar datos";
            btnMostrarDatos.UseVisualStyleBackColor = false;
            btnMostrarDatos.Click += btnMostrarDatos_Click;
            // 
            // btnEsconderDatos
            // 
            btnEsconderDatos.BackColor = Color.FromArgb(255, 192, 255);
            btnEsconderDatos.FlatAppearance.BorderSize = 0;
            btnEsconderDatos.FlatStyle = FlatStyle.Flat;
            btnEsconderDatos.ForeColor = SystemColors.ActiveCaptionText;
            btnEsconderDatos.Location = new Point(597, 302);
            btnEsconderDatos.Name = "btnEsconderDatos";
            btnEsconderDatos.Size = new Size(112, 42);
            btnEsconderDatos.TabIndex = 19;
            btnEsconderDatos.Text = "Esconder datos";
            btnEsconderDatos.UseVisualStyleBackColor = false;
            btnEsconderDatos.Click += btnEsconderDatos_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.FromArgb(255, 192, 255);
            btnAceptar.FlatAppearance.BorderSize = 0;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.ForeColor = SystemColors.ActiveCaptionText;
            btnAceptar.Location = new Point(597, 349);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(112, 42);
            btnAceptar.TabIndex = 20;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // txtSaldo
            // 
            txtSaldo.BackColor = Color.FromArgb(11, 7, 17);
            txtSaldo.BorderStyle = BorderStyle.FixedSingle;
            txtSaldo.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtSaldo.ForeColor = SystemColors.Window;
            txtSaldo.Location = new Point(779, 12);
            txtSaldo.Name = "txtSaldo";
            txtSaldo.ReadOnly = true;
            txtSaldo.Size = new Size(128, 41);
            txtSaldo.TabIndex = 21;
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblSaldo.ForeColor = SystemColors.ButtonHighlight;
            lblSaldo.Location = new Point(677, 14);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(96, 33);
            lblSaldo.TabIndex = 22;
            lblSaldo.Text = "Saldo:";
            // 
            // pnlSaldo
            // 
            pnlSaldo.BackColor = Color.FromArgb(200, 192, 255);
            pnlSaldo.Controls.Add(btnCargar);
            pnlSaldo.Controls.Add(lblAgregarSaldo);
            pnlSaldo.Controls.Add(txtAgregarSaldo);
            pnlSaldo.Location = new Point(12, 397);
            pnlSaldo.Name = "pnlSaldo";
            pnlSaldo.Size = new Size(577, 110);
            pnlSaldo.TabIndex = 23;
            // 
            // cmbBaseDeDatos
            // 
            cmbBaseDeDatos.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBaseDeDatos.FormattingEnabled = true;
            cmbBaseDeDatos.Location = new Point(229, 14);
            cmbBaseDeDatos.Name = "cmbBaseDeDatos";
            cmbBaseDeDatos.Size = new Size(121, 23);
            cmbBaseDeDatos.TabIndex = 24;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(58, 11);
            label1.Name = "label1";
            label1.Size = new Size(165, 22);
            label1.TabIndex = 25;
            label1.Text = "Conexion a base";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(58, 33);
            label2.Name = "label2";
            label2.Size = new Size(92, 22);
            label2.TabIndex = 26;
            label2.Text = "de datos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(-3, 81);
            label3.Name = "label3";
            label3.Size = new Size(226, 22);
            label3.TabIndex = 27;
            label3.Text = "Generador automatico";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(18, 108);
            label4.Name = "label4";
            label4.Size = new Size(205, 22);
            label4.TabIndex = 28;
            label4.Text = "de registro de ventas";
            // 
            // cmbVentas
            // 
            cmbVentas.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVentas.FormattingEnabled = true;
            cmbVentas.Location = new Point(229, 84);
            cmbVentas.Name = "cmbVentas";
            cmbVentas.Size = new Size(121, 23);
            cmbVentas.TabIndex = 29;
            // 
            // btnAplicarCambios
            // 
            btnAplicarCambios.BackColor = Color.FromArgb(255, 192, 255);
            btnAplicarCambios.FlatAppearance.BorderSize = 0;
            btnAplicarCambios.FlatStyle = FlatStyle.Flat;
            btnAplicarCambios.ForeColor = SystemColors.ActiveCaptionText;
            btnAplicarCambios.Location = new Point(229, 128);
            btnAplicarCambios.Name = "btnAplicarCambios";
            btnAplicarCambios.Size = new Size(112, 42);
            btnAplicarCambios.TabIndex = 30;
            btnAplicarCambios.Text = "Aplicar cambios";
            btnAplicarCambios.UseVisualStyleBackColor = false;
            btnAplicarCambios.Click += btnAplicarCambios_Click;
            // 
            // pnlConfiguraciones
            // 
            pnlConfiguraciones.Controls.Add(btnAplicarCambios);
            pnlConfiguraciones.Controls.Add(cmbBaseDeDatos);
            pnlConfiguraciones.Controls.Add(cmbVentas);
            pnlConfiguraciones.Controls.Add(label1);
            pnlConfiguraciones.Controls.Add(label4);
            pnlConfiguraciones.Controls.Add(label2);
            pnlConfiguraciones.Controls.Add(label3);
            pnlConfiguraciones.Location = new Point(768, 211);
            pnlConfiguraciones.Name = "pnlConfiguraciones";
            pnlConfiguraciones.Size = new Size(360, 190);
            pnlConfiguraciones.TabIndex = 31;
            // 
            // InformacionPersonal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 72);
            ClientSize = new Size(1140, 684);
            ControlBox = false;
            Controls.Add(pnlConfiguraciones);
            Controls.Add(pnlSaldo);
            Controls.Add(lblSaldo);
            Controls.Add(txtSaldo);
            Controls.Add(btnAceptar);
            Controls.Add(btnEsconderDatos);
            Controls.Add(btnMostrarDatos);
            Controls.Add(pnlDatosBancarios);
            Controls.Add(btnNoVer);
            Controls.Add(btnVer);
            Controls.Add(txtContraseña);
            Controls.Add(txtNombre);
            Controls.Add(lblContraseña);
            Controls.Add(lblNombre);
            FormBorderStyle = FormBorderStyle.None;
            Name = "InformacionPersonal";
            Text = "InformacionPersonal";
            Load += InformacionPersonal_Load;
            pnlDatosBancarios.ResumeLayout(false);
            pnlDatosBancarios.PerformLayout();
            pnlSaldo.ResumeLayout(false);
            pnlSaldo.PerformLayout();
            pnlConfiguraciones.ResumeLayout(false);
            pnlConfiguraciones.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblContraseña;
        private TextBox txtContraseña;
        private TextBox txtNombre;
        private Button btnVer;
        private Button btnNoVer;
        private Label lblNumeroTarjeta;
        private Label lblCodigoSeguridad;
        private Label lblBanco;
        private Label lblFechaVencimiento;
        private TextBox txtFechaVencimiento;
        private TextBox txtCodigoSeguridad;
        private TextBox txtNumeroTarjeta;
        private Panel pnlDatosBancarios;
        private Button btnMostrarDatos;
        private Button btnEsconderDatos;
        private Button btnAceptar;
        private ListBox lsbBanco;
        private TextBox txtSaldo;
        private Label lblSaldo;
        private Button btnCargar;
        private TextBox txtAgregarSaldo;
        private Label lblAgregarSaldo;
        private Panel pnlSaldo;
        private ComboBox cmbBaseDeDatos;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cmbVentas;
        private Button btnAplicarCambios;
        private Panel pnlConfiguraciones;
    }
}