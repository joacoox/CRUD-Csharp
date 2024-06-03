namespace parcialUno
{
    partial class Registrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registrar));
            panel1 = new Panel();
            pcbLogo = new PictureBox();
            pcbSalir = new PictureBox();
            btnAcceder = new Button();
            lblTitulo = new Label();
            txtContraseña = new TextBox();
            txtNombre = new TextBox();
            txtContraseña2 = new TextBox();
            lblUSUARIO = new Label();
            lblContraseña = new Label();
            lblConfirmarContraseña = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbSalir).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 122, 204);
            panel1.Controls.Add(pcbLogo);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 330);
            panel1.TabIndex = 1;
            // 
            // pcbLogo
            // 
            pcbLogo.Image = Properties.Resources.logo;
            pcbLogo.Location = new Point(56, 95);
            pcbLogo.Name = "pcbLogo";
            pcbLogo.Size = new Size(129, 101);
            pcbLogo.TabIndex = 5;
            pcbLogo.TabStop = false;
            // 
            // pcbSalir
            // 
            pcbSalir.Image = (Image)resources.GetObject("pcbSalir.Image");
            pcbSalir.Location = new Point(750, 0);
            pcbSalir.Name = "pcbSalir";
            pcbSalir.Size = new Size(29, 31);
            pcbSalir.TabIndex = 10;
            pcbSalir.TabStop = false;
            pcbSalir.Click += pcbSalir_Click;
            // 
            // btnAcceder
            // 
            btnAcceder.BackColor = Color.FromArgb(40, 40, 40);
            btnAcceder.FlatAppearance.BorderSize = 0;
            btnAcceder.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnAcceder.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnAcceder.FlatStyle = FlatStyle.Flat;
            btnAcceder.ForeColor = Color.Gainsboro;
            btnAcceder.Location = new Point(332, 261);
            btnAcceder.Name = "btnAcceder";
            btnAcceder.Size = new Size(400, 40);
            btnAcceder.TabIndex = 9;
            btnAcceder.Text = "ACCEDER";
            btnAcceder.UseVisualStyleBackColor = false;
            btnAcceder.Click += btnAcceder_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.DimGray;
            lblTitulo.Location = new Point(386, 24);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(155, 33);
            lblTitulo.TabIndex = 8;
            lblTitulo.Text = "Registrarse";
            // 
            // txtContraseña
            // 
            txtContraseña.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtContraseña.ForeColor = Color.DimGray;
            txtContraseña.Location = new Point(332, 160);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.Size = new Size(400, 27);
            txtContraseña.TabIndex = 7;
            txtContraseña.UseSystemPasswordChar = true;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.ForeColor = Color.DimGray;
            txtNombre.Location = new Point(332, 95);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(400, 27);
            txtNombre.TabIndex = 6;
            // 
            // txtContraseña2
            // 
            txtContraseña2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtContraseña2.ForeColor = Color.DimGray;
            txtContraseña2.Location = new Point(332, 215);
            txtContraseña2.Name = "txtContraseña2";
            txtContraseña2.Size = new Size(400, 27);
            txtContraseña2.TabIndex = 11;
            txtContraseña2.UseSystemPasswordChar = true;
            // 
            // lblUSUARIO
            // 
            lblUSUARIO.AutoSize = true;
            lblUSUARIO.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblUSUARIO.ForeColor = Color.DimGray;
            lblUSUARIO.Location = new Point(332, 70);
            lblUSUARIO.Name = "lblUSUARIO";
            lblUSUARIO.Size = new Size(75, 22);
            lblUSUARIO.TabIndex = 17;
            lblUSUARIO.Text = "Usuario";
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblContraseña.ForeColor = Color.DimGray;
            lblContraseña.Location = new Point(332, 135);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(119, 22);
            lblContraseña.TabIndex = 18;
            lblContraseña.Text = "Contraseña";
            // 
            // lblConfirmarContraseña
            // 
            lblConfirmarContraseña.AutoSize = true;
            lblConfirmarContraseña.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblConfirmarContraseña.ForeColor = Color.DimGray;
            lblConfirmarContraseña.Location = new Point(332, 190);
            lblConfirmarContraseña.Name = "lblConfirmarContraseña";
            lblConfirmarContraseña.Size = new Size(214, 22);
            lblConfirmarContraseña.TabIndex = 19;
            lblConfirmarContraseña.Text = "Confirmar Contraseña";
            // 
            // Registrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(780, 330);
            Controls.Add(lblConfirmarContraseña);
            Controls.Add(lblContraseña);
            Controls.Add(lblUSUARIO);
            Controls.Add(txtContraseña2);
            Controls.Add(pcbSalir);
            Controls.Add(btnAcceder);
            Controls.Add(lblTitulo);
            Controls.Add(txtContraseña);
            Controls.Add(txtNombre);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(780, 330);
            MinimumSize = new Size(780, 330);
            Name = "Registrar";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrar";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pcbLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbSalir).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pcbLogo;
        private PictureBox pcbSalir;
        private Button btnAcceder;
        private Label lblTitulo;
        private TextBox txtContraseña;
        private TextBox txtNombre;
        private TextBox txtContraseña2;
        private Label lblUSUARIO;
        private Label lblContraseña;
        private Label lblConfirmarContraseña;
    }
}