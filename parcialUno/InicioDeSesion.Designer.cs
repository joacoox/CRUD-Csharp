namespace parcialUno
{
    partial class InicioDeSesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioDeSesion));
            panel1 = new Panel();
            pcbLogo = new PictureBox();
            txtNombre = new TextBox();
            txtContraseña = new TextBox();
            lblTitulo = new Label();
            btnAcceder = new Button();
            pcbSalir = new PictureBox();
            btnRegistrar = new Button();
            lblContraseña = new Label();
            lblUSUARIO = new Label();
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
            panel1.TabIndex = 0;
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
            // txtNombre
            // 
            txtNombre.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.ForeColor = Color.DimGray;
            txtNombre.Location = new Point(332, 95);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(400, 27);
            txtNombre.TabIndex = 1;
            // 
            // txtContraseña
            // 
            txtContraseña.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtContraseña.ForeColor = Color.DimGray;
            txtContraseña.Location = new Point(332, 157);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.Size = new Size(400, 27);
            txtContraseña.TabIndex = 2;
            txtContraseña.UseSystemPasswordChar = true;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.DimGray;
            lblTitulo.Location = new Point(406, 18);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(216, 33);
            lblTitulo.TabIndex = 3;
            lblTitulo.Text = "Inicio de Sesion";
            // 
            // btnAcceder
            // 
            btnAcceder.BackColor = Color.FromArgb(40, 40, 40);
            btnAcceder.FlatAppearance.BorderSize = 0;
            btnAcceder.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnAcceder.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnAcceder.FlatStyle = FlatStyle.Flat;
            btnAcceder.ForeColor = Color.Gainsboro;
            btnAcceder.Location = new Point(332, 234);
            btnAcceder.Name = "btnAcceder";
            btnAcceder.Size = new Size(400, 40);
            btnAcceder.TabIndex = 4;
            btnAcceder.Text = "ACCEDER";
            btnAcceder.UseVisualStyleBackColor = false;
            btnAcceder.Click += btnAcceder_Click;
            // 
            // pcbSalir
            // 
            pcbSalir.Image = (Image)resources.GetObject("pcbSalir.Image");
            pcbSalir.Location = new Point(752, 0);
            pcbSalir.Name = "pcbSalir";
            pcbSalir.Size = new Size(29, 31);
            pcbSalir.TabIndex = 5;
            pcbSalir.TabStop = false;
            pcbSalir.Click += pcbSalir_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.FromArgb(0, 122, 204);
            btnRegistrar.FlatAppearance.BorderSize = 0;
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegistrar.ForeColor = Color.White;
            btnRegistrar.Location = new Point(433, 280);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(204, 23);
            btnRegistrar.TabIndex = 14;
            btnRegistrar.Text = "No estas registrado? Pulsa aqui.";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblContraseña.ForeColor = Color.DimGray;
            lblContraseña.Location = new Point(332, 132);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(119, 22);
            lblContraseña.TabIndex = 15;
            lblContraseña.Text = "Contraseña";
            // 
            // lblUSUARIO
            // 
            lblUSUARIO.AutoSize = true;
            lblUSUARIO.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblUSUARIO.ForeColor = Color.DimGray;
            lblUSUARIO.Location = new Point(332, 70);
            lblUSUARIO.Name = "lblUSUARIO";
            lblUSUARIO.Size = new Size(75, 22);
            lblUSUARIO.TabIndex = 16;
            lblUSUARIO.Text = "Usuario";
            // 
            // InicioDeSesion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(780, 330);
            Controls.Add(lblUSUARIO);
            Controls.Add(lblContraseña);
            Controls.Add(btnRegistrar);
            Controls.Add(pcbSalir);
            Controls.Add(btnAcceder);
            Controls.Add(lblTitulo);
            Controls.Add(txtContraseña);
            Controls.Add(txtNombre);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(780, 330);
            MinimumSize = new Size(780, 330);
            Name = "InicioDeSesion";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InicioDeSesion";
            Load += InicioDeSesion_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pcbLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbSalir).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox txtNombre;
        private TextBox txtContraseña;
        private Label lblTitulo;
        private Button btnAcceder;
        private PictureBox pcbLogo;
        private PictureBox pcbSalir;
        private Button btnRegistrar;
        private Label lblContraseña;
        private Label lblUSUARIO;
    }
}