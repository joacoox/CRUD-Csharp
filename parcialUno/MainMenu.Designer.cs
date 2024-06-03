namespace parcialUno
{
    partial class MainMenu
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            pnlMenuLateral = new Panel();
            btnDatosSucursal = new Button();
            btnSalir = new Button();
            btnClientes = new Button();
            btnMisDatos = new Button();
            btnHistorialCompras = new Button();
            pnlComponentes = new Panel();
            btnGabinete = new Button();
            btnFuenteAlimentacion = new Button();
            btnDisco = new Button();
            btnRam = new Button();
            btnProcesador = new Button();
            btnPlacaMadre = new Button();
            btnPlacaVideo = new Button();
            btnComponentes = new Button();
            pnlLogo = new Panel();
            btnHome = new Button();
            pnlNombreUsuario = new Panel();
            lblFecha = new Label();
            lblHora = new Label();
            lblBienvenido = new Label();
            btnNombre = new Button();
            pbUsuario = new PictureBox();
            pnlFormulario = new Panel();
            pnlProductosBajoStock = new Panel();
            label2 = new Label();
            dtgvProductosBajoStock = new DataGridView();
            pnlDatoss = new TableLayoutPanel();
            panel4 = new Panel();
            lblGanancias = new Label();
            pictureBox4 = new PictureBox();
            label3 = new Label();
            panel1 = new Panel();
            lblVentas = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            lblClientes = new Label();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            pnlDatos = new Panel();
            lblAdmins = new Label();
            pictureBox3 = new PictureBox();
            label6 = new Label();
            pnlTop = new Panel();
            lbldashboard = new Label();
            pbMinimizar = new PictureBox();
            pbMaximizar = new PictureBox();
            horaFecha = new System.Windows.Forms.Timer(components);
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            bindingSource1 = new BindingSource(components);
            pnlMenuLateral.SuspendLayout();
            pnlComponentes.SuspendLayout();
            pnlLogo.SuspendLayout();
            pnlNombreUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbUsuario).BeginInit();
            pnlFormulario.SuspendLayout();
            pnlProductosBajoStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvProductosBajoStock).BeginInit();
            pnlDatoss.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            pnlDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbMaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // pnlMenuLateral
            // 
            pnlMenuLateral.AutoScroll = true;
            pnlMenuLateral.BackColor = Color.FromArgb(31, 30, 68);
            pnlMenuLateral.Controls.Add(btnDatosSucursal);
            pnlMenuLateral.Controls.Add(btnSalir);
            pnlMenuLateral.Controls.Add(btnClientes);
            pnlMenuLateral.Controls.Add(btnMisDatos);
            pnlMenuLateral.Controls.Add(btnHistorialCompras);
            pnlMenuLateral.Controls.Add(pnlComponentes);
            pnlMenuLateral.Controls.Add(btnComponentes);
            pnlMenuLateral.Controls.Add(pnlLogo);
            pnlMenuLateral.Dock = DockStyle.Left;
            pnlMenuLateral.Location = new Point(0, 0);
            pnlMenuLateral.Name = "pnlMenuLateral";
            pnlMenuLateral.Size = new Size(205, 798);
            pnlMenuLateral.TabIndex = 0;
            // 
            // btnDatosSucursal
            // 
            btnDatosSucursal.BackColor = Color.FromArgb(200, 192, 255);
            btnDatosSucursal.Dock = DockStyle.Top;
            btnDatosSucursal.FlatAppearance.BorderSize = 0;
            btnDatosSucursal.FlatStyle = FlatStyle.Flat;
            btnDatosSucursal.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnDatosSucursal.ForeColor = SystemColors.ActiveCaptionText;
            btnDatosSucursal.Image = Properties.Resources.informacion;
            btnDatosSucursal.ImageAlign = ContentAlignment.MiddleLeft;
            btnDatosSucursal.Location = new Point(0, 561);
            btnDatosSucursal.Name = "btnDatosSucursal";
            btnDatosSucursal.Padding = new Padding(10, 0, 0, 0);
            btnDatosSucursal.Size = new Size(205, 47);
            btnDatosSucursal.TabIndex = 6;
            btnDatosSucursal.Text = "Datos Sucursal";
            btnDatosSucursal.UseVisualStyleBackColor = false;
            btnDatosSucursal.Click += btnDatosSucursal_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(200, 192, 255);
            btnSalir.Dock = DockStyle.Bottom;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalir.ForeColor = SystemColors.ActiveCaptionText;
            btnSalir.Image = Properties.Resources.salir;
            btnSalir.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalir.Location = new Point(0, 728);
            btnSalir.Name = "btnSalir";
            btnSalir.Padding = new Padding(10, 0, 0, 0);
            btnSalir.Size = new Size(205, 70);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnClientes
            // 
            btnClientes.BackColor = Color.FromArgb(200, 192, 255);
            btnClientes.Dock = DockStyle.Top;
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnClientes.ForeColor = SystemColors.ActiveCaptionText;
            btnClientes.Image = Properties.Resources.listaUsuarios;
            btnClientes.ImageAlign = ContentAlignment.MiddleLeft;
            btnClientes.Location = new Point(0, 514);
            btnClientes.Name = "btnClientes";
            btnClientes.Padding = new Padding(8, 0, 0, 0);
            btnClientes.Size = new Size(205, 47);
            btnClientes.TabIndex = 4;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = false;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnMisDatos
            // 
            btnMisDatos.BackColor = Color.FromArgb(200, 192, 255);
            btnMisDatos.Dock = DockStyle.Top;
            btnMisDatos.FlatAppearance.BorderSize = 0;
            btnMisDatos.FlatStyle = FlatStyle.Flat;
            btnMisDatos.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnMisDatos.ForeColor = SystemColors.ActiveCaptionText;
            btnMisDatos.Image = Properties.Resources.misDatos;
            btnMisDatos.ImageAlign = ContentAlignment.MiddleLeft;
            btnMisDatos.Location = new Point(0, 469);
            btnMisDatos.Name = "btnMisDatos";
            btnMisDatos.Padding = new Padding(10, 0, 0, 0);
            btnMisDatos.Size = new Size(205, 45);
            btnMisDatos.TabIndex = 3;
            btnMisDatos.Text = "Configuracion";
            btnMisDatos.UseVisualStyleBackColor = false;
            btnMisDatos.Click += btnMisDatos_Click;
            // 
            // btnHistorialCompras
            // 
            btnHistorialCompras.BackColor = Color.FromArgb(200, 192, 255);
            btnHistorialCompras.Dock = DockStyle.Top;
            btnHistorialCompras.FlatAppearance.BorderSize = 0;
            btnHistorialCompras.FlatStyle = FlatStyle.Flat;
            btnHistorialCompras.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnHistorialCompras.ForeColor = SystemColors.ActiveCaptionText;
            btnHistorialCompras.Image = Properties.Resources.historial;
            btnHistorialCompras.ImageAlign = ContentAlignment.MiddleLeft;
            btnHistorialCompras.Location = new Point(0, 424);
            btnHistorialCompras.Name = "btnHistorialCompras";
            btnHistorialCompras.Padding = new Padding(10, 0, 0, 0);
            btnHistorialCompras.Size = new Size(205, 45);
            btnHistorialCompras.TabIndex = 2;
            btnHistorialCompras.Text = "     Historial de compras";
            btnHistorialCompras.UseVisualStyleBackColor = false;
            btnHistorialCompras.Click += btnArmarCompu_Click;
            // 
            // pnlComponentes
            // 
            pnlComponentes.BackColor = Color.FromArgb(115, 35, 50);
            pnlComponentes.Controls.Add(btnGabinete);
            pnlComponentes.Controls.Add(btnFuenteAlimentacion);
            pnlComponentes.Controls.Add(btnDisco);
            pnlComponentes.Controls.Add(btnRam);
            pnlComponentes.Controls.Add(btnProcesador);
            pnlComponentes.Controls.Add(btnPlacaMadre);
            pnlComponentes.Controls.Add(btnPlacaVideo);
            pnlComponentes.Dock = DockStyle.Top;
            pnlComponentes.Location = new Point(0, 139);
            pnlComponentes.Name = "pnlComponentes";
            pnlComponentes.Size = new Size(205, 285);
            pnlComponentes.TabIndex = 1;
            // 
            // btnGabinete
            // 
            btnGabinete.BackColor = Color.FromArgb(255, 192, 255);
            btnGabinete.Dock = DockStyle.Top;
            btnGabinete.FlatAppearance.BorderSize = 0;
            btnGabinete.FlatStyle = FlatStyle.Flat;
            btnGabinete.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnGabinete.ForeColor = Color.Black;
            btnGabinete.Location = new Point(0, 240);
            btnGabinete.Name = "btnGabinete";
            btnGabinete.Padding = new Padding(35, 0, 0, 0);
            btnGabinete.RightToLeft = RightToLeft.No;
            btnGabinete.Size = new Size(205, 45);
            btnGabinete.TabIndex = 7;
            btnGabinete.Text = "Gabinetes";
            btnGabinete.TextAlign = ContentAlignment.MiddleLeft;
            btnGabinete.UseVisualStyleBackColor = false;
            btnGabinete.Click += btnGabinete_Click;
            // 
            // btnFuenteAlimentacion
            // 
            btnFuenteAlimentacion.BackColor = Color.FromArgb(255, 192, 255);
            btnFuenteAlimentacion.Dock = DockStyle.Top;
            btnFuenteAlimentacion.FlatAppearance.BorderSize = 0;
            btnFuenteAlimentacion.FlatStyle = FlatStyle.Flat;
            btnFuenteAlimentacion.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnFuenteAlimentacion.ForeColor = Color.Black;
            btnFuenteAlimentacion.Location = new Point(0, 200);
            btnFuenteAlimentacion.Name = "btnFuenteAlimentacion";
            btnFuenteAlimentacion.Padding = new Padding(35, 0, 0, 0);
            btnFuenteAlimentacion.Size = new Size(205, 40);
            btnFuenteAlimentacion.TabIndex = 6;
            btnFuenteAlimentacion.Text = "Fuente de alimentacion";
            btnFuenteAlimentacion.TextAlign = ContentAlignment.MiddleLeft;
            btnFuenteAlimentacion.UseVisualStyleBackColor = false;
            btnFuenteAlimentacion.Click += btnFuenteAlimentacion_Click;
            // 
            // btnDisco
            // 
            btnDisco.BackColor = Color.FromArgb(255, 192, 255);
            btnDisco.Dock = DockStyle.Top;
            btnDisco.FlatAppearance.BorderSize = 0;
            btnDisco.FlatStyle = FlatStyle.Flat;
            btnDisco.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnDisco.ForeColor = Color.Black;
            btnDisco.Location = new Point(0, 160);
            btnDisco.Name = "btnDisco";
            btnDisco.Padding = new Padding(35, 0, 0, 0);
            btnDisco.Size = new Size(205, 40);
            btnDisco.TabIndex = 5;
            btnDisco.Text = "Disco duro";
            btnDisco.TextAlign = ContentAlignment.MiddleLeft;
            btnDisco.UseVisualStyleBackColor = false;
            btnDisco.Click += btnDisco_Click;
            // 
            // btnRam
            // 
            btnRam.BackColor = Color.FromArgb(255, 192, 255);
            btnRam.Dock = DockStyle.Top;
            btnRam.FlatAppearance.BorderSize = 0;
            btnRam.FlatStyle = FlatStyle.Flat;
            btnRam.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnRam.ForeColor = Color.Black;
            btnRam.Location = new Point(0, 120);
            btnRam.Name = "btnRam";
            btnRam.Padding = new Padding(35, 0, 0, 0);
            btnRam.Size = new Size(205, 40);
            btnRam.TabIndex = 4;
            btnRam.Text = "Memoria Ram";
            btnRam.TextAlign = ContentAlignment.MiddleLeft;
            btnRam.UseVisualStyleBackColor = false;
            btnRam.Click += btnRam_Click;
            // 
            // btnProcesador
            // 
            btnProcesador.BackColor = Color.FromArgb(255, 192, 255);
            btnProcesador.Dock = DockStyle.Top;
            btnProcesador.FlatAppearance.BorderSize = 0;
            btnProcesador.FlatStyle = FlatStyle.Flat;
            btnProcesador.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnProcesador.ForeColor = Color.Black;
            btnProcesador.Location = new Point(0, 80);
            btnProcesador.Name = "btnProcesador";
            btnProcesador.Padding = new Padding(35, 0, 0, 0);
            btnProcesador.Size = new Size(205, 40);
            btnProcesador.TabIndex = 3;
            btnProcesador.Text = "Procesadores";
            btnProcesador.TextAlign = ContentAlignment.MiddleLeft;
            btnProcesador.UseVisualStyleBackColor = false;
            btnProcesador.Click += btnProcesador_Click;
            // 
            // btnPlacaMadre
            // 
            btnPlacaMadre.BackColor = Color.FromArgb(255, 192, 255);
            btnPlacaMadre.Dock = DockStyle.Top;
            btnPlacaMadre.FlatAppearance.BorderSize = 0;
            btnPlacaMadre.FlatStyle = FlatStyle.Flat;
            btnPlacaMadre.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnPlacaMadre.ForeColor = Color.Black;
            btnPlacaMadre.Location = new Point(0, 40);
            btnPlacaMadre.Name = "btnPlacaMadre";
            btnPlacaMadre.Padding = new Padding(35, 0, 0, 0);
            btnPlacaMadre.Size = new Size(205, 40);
            btnPlacaMadre.TabIndex = 2;
            btnPlacaMadre.Text = "Placas madre";
            btnPlacaMadre.TextAlign = ContentAlignment.MiddleLeft;
            btnPlacaMadre.UseVisualStyleBackColor = false;
            btnPlacaMadre.Click += btnPlacaMadre_Click;
            // 
            // btnPlacaVideo
            // 
            btnPlacaVideo.BackColor = Color.FromArgb(255, 192, 255);
            btnPlacaVideo.Dock = DockStyle.Top;
            btnPlacaVideo.FlatAppearance.BorderSize = 0;
            btnPlacaVideo.FlatStyle = FlatStyle.Flat;
            btnPlacaVideo.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnPlacaVideo.ForeColor = Color.Black;
            btnPlacaVideo.Location = new Point(0, 0);
            btnPlacaVideo.Name = "btnPlacaVideo";
            btnPlacaVideo.Padding = new Padding(35, 0, 0, 0);
            btnPlacaVideo.Size = new Size(205, 40);
            btnPlacaVideo.TabIndex = 1;
            btnPlacaVideo.Text = "Placas de video";
            btnPlacaVideo.TextAlign = ContentAlignment.MiddleLeft;
            btnPlacaVideo.UseVisualStyleBackColor = false;
            btnPlacaVideo.Click += btnPlacaVideo_Click;
            // 
            // btnComponentes
            // 
            btnComponentes.BackColor = Color.FromArgb(200, 192, 255);
            btnComponentes.Dock = DockStyle.Top;
            btnComponentes.FlatAppearance.BorderSize = 0;
            btnComponentes.FlatStyle = FlatStyle.Flat;
            btnComponentes.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnComponentes.ForeColor = SystemColors.ActiveCaptionText;
            btnComponentes.Image = Properties.Resources.componentes;
            btnComponentes.ImageAlign = ContentAlignment.MiddleLeft;
            btnComponentes.Location = new Point(0, 94);
            btnComponentes.Name = "btnComponentes";
            btnComponentes.Padding = new Padding(10, 0, 0, 0);
            btnComponentes.Size = new Size(205, 45);
            btnComponentes.TabIndex = 1;
            btnComponentes.Text = "Componentes";
            btnComponentes.UseVisualStyleBackColor = false;
            btnComponentes.Click += btnComponentes_Click;
            // 
            // pnlLogo
            // 
            pnlLogo.BackColor = Color.FromArgb(31, 30, 68);
            pnlLogo.Controls.Add(btnHome);
            pnlLogo.Dock = DockStyle.Top;
            pnlLogo.Location = new Point(0, 0);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Size = new Size(205, 94);
            pnlLogo.TabIndex = 1;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.FromArgb(200, 192, 255);
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Century Gothic", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnHome.ForeColor = SystemColors.ActiveCaptionText;
            btnHome.Image = Properties.Resources.home1;
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(25, 25);
            btnHome.Name = "btnHome";
            btnHome.Padding = new Padding(5, 0, 0, 0);
            btnHome.Size = new Size(140, 45);
            btnHome.TabIndex = 2;
            btnHome.Text = "HOME";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // pnlNombreUsuario
            // 
            pnlNombreUsuario.BackColor = Color.FromArgb(34, 33, 100);
            pnlNombreUsuario.Controls.Add(lblFecha);
            pnlNombreUsuario.Controls.Add(lblHora);
            pnlNombreUsuario.Controls.Add(lblBienvenido);
            pnlNombreUsuario.Controls.Add(btnNombre);
            pnlNombreUsuario.Controls.Add(pbUsuario);
            pnlNombreUsuario.Dock = DockStyle.Bottom;
            pnlNombreUsuario.Location = new Point(205, 714);
            pnlNombreUsuario.Name = "pnlNombreUsuario";
            pnlNombreUsuario.Size = new Size(1242, 84);
            pnlNombreUsuario.TabIndex = 1;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblFecha.ForeColor = Color.White;
            lblFecha.Location = new Point(42, 57);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(0, 22);
            lblFecha.TabIndex = 3;
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.FlatStyle = FlatStyle.Flat;
            lblHora.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblHora.ForeColor = Color.White;
            lblHora.Location = new Point(42, 8);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(0, 31);
            lblHora.TabIndex = 2;
            // 
            // lblBienvenido
            // 
            lblBienvenido.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblBienvenido.AutoSize = true;
            lblBienvenido.ForeColor = Color.White;
            lblBienvenido.Location = new Point(1125, 30);
            lblBienvenido.Name = "lblBienvenido";
            lblBienvenido.Size = new Size(71, 15);
            lblBienvenido.TabIndex = 1;
            lblBienvenido.Text = "Bienvenido!";
            // 
            // btnNombre
            // 
            btnNombre.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNombre.BackColor = Color.FromArgb(34, 33, 100);
            btnNombre.FlatAppearance.BorderSize = 0;
            btnNombre.FlatStyle = FlatStyle.Flat;
            btnNombre.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnNombre.ForeColor = Color.White;
            btnNombre.Location = new Point(1125, 48);
            btnNombre.Name = "btnNombre";
            btnNombre.Size = new Size(104, 24);
            btnNombre.TabIndex = 0;
            btnNombre.UseVisualStyleBackColor = false;
            btnNombre.Click += btnNombre_Click;
            // 
            // pbUsuario
            // 
            pbUsuario.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pbUsuario.BackColor = Color.FromArgb(34, 33, 100);
            pbUsuario.Image = Properties.Resources.misDatos;
            pbUsuario.InitialImage = Properties.Resources.account_avatar_face_man_people_profile_user_icon_123197;
            pbUsuario.Location = new Point(1047, 14);
            pbUsuario.Name = "pbUsuario";
            pbUsuario.Size = new Size(72, 58);
            pbUsuario.SizeMode = PictureBoxSizeMode.StretchImage;
            pbUsuario.TabIndex = 0;
            pbUsuario.TabStop = false;
            // 
            // pnlFormulario
            // 
            pnlFormulario.BackColor = Color.FromArgb(34, 33, 72);
            pnlFormulario.Controls.Add(pnlProductosBajoStock);
            pnlFormulario.Controls.Add(pnlDatoss);
            pnlFormulario.Controls.Add(pnlTop);
            pnlFormulario.Dock = DockStyle.Fill;
            pnlFormulario.Location = new Point(205, 0);
            pnlFormulario.Margin = new Padding(5);
            pnlFormulario.Name = "pnlFormulario";
            pnlFormulario.Size = new Size(1242, 714);
            pnlFormulario.TabIndex = 2;
            // 
            // pnlProductosBajoStock
            // 
            pnlProductosBajoStock.Controls.Add(label2);
            pnlProductosBajoStock.Controls.Add(dtgvProductosBajoStock);
            pnlProductosBajoStock.Dock = DockStyle.Left;
            pnlProductosBajoStock.Location = new Point(0, 200);
            pnlProductosBajoStock.Margin = new Padding(1, 5, 5, 25);
            pnlProductosBajoStock.Name = "pnlProductosBajoStock";
            pnlProductosBajoStock.Size = new Size(707, 514);
            pnlProductosBajoStock.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(243, 23);
            label2.TabIndex = 3;
            label2.Text = "Productos con bajo stock";
            // 
            // dtgvProductosBajoStock
            // 
            dtgvProductosBajoStock.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgvProductosBajoStock.BackgroundColor = Color.FromArgb(45, 66, 91);
            dtgvProductosBajoStock.BorderStyle = BorderStyle.None;
            dtgvProductosBajoStock.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtgvProductosBajoStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgvProductosBajoStock.ColumnHeadersHeight = 30;
            dtgvProductosBajoStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dtgvProductosBajoStock.EnableHeadersVisualStyles = false;
            dtgvProductosBajoStock.GridColor = Color.SteelBlue;
            dtgvProductosBajoStock.Location = new Point(0, 25);
            dtgvProductosBajoStock.Name = "dtgvProductosBajoStock";
            dtgvProductosBajoStock.ReadOnly = true;
            dtgvProductosBajoStock.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dtgvProductosBajoStock.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dtgvProductosBajoStock.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dtgvProductosBajoStock.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dtgvProductosBajoStock.RowTemplate.Height = 25;
            dtgvProductosBajoStock.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvProductosBajoStock.Size = new Size(707, 315);
            dtgvProductosBajoStock.TabIndex = 7;
            // 
            // pnlDatoss
            // 
            pnlDatoss.ColumnCount = 4;
            pnlDatoss.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pnlDatoss.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pnlDatoss.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pnlDatoss.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pnlDatoss.Controls.Add(panel4, 3, 0);
            pnlDatoss.Controls.Add(panel1, 0, 0);
            pnlDatoss.Controls.Add(panel2, 1, 0);
            pnlDatoss.Controls.Add(pnlDatos, 2, 0);
            pnlDatoss.Dock = DockStyle.Top;
            pnlDatoss.Location = new Point(0, 41);
            pnlDatoss.Name = "pnlDatoss";
            pnlDatoss.RowCount = 1;
            pnlDatoss.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pnlDatoss.Size = new Size(1242, 159);
            pnlDatoss.TabIndex = 6;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Gray;
            panel4.Controls.Add(lblGanancias);
            panel4.Controls.Add(pictureBox4);
            panel4.Controls.Add(label3);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(930, 0);
            panel4.Margin = new Padding(0, 0, 0, 10);
            panel4.Name = "panel4";
            panel4.Size = new Size(312, 149);
            panel4.TabIndex = 5;
            // 
            // lblGanancias
            // 
            lblGanancias.AutoSize = true;
            lblGanancias.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblGanancias.ForeColor = Color.White;
            lblGanancias.Location = new Point(142, 75);
            lblGanancias.Name = "lblGanancias";
            lblGanancias.Size = new Size(0, 23);
            lblGanancias.TabIndex = 2;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.dinero;
            pictureBox4.Location = new Point(15, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(66, 53);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(87, 30);
            label3.Name = "label3";
            label3.Size = new Size(191, 23);
            label3.TabIndex = 1;
            label3.Text = "Total de Ganancias";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 128, 255);
            panel1.Controls.Add(lblVentas);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0, 0, 10, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 149);
            panel1.TabIndex = 2;
            // 
            // lblVentas
            // 
            lblVentas.AutoSize = true;
            lblVentas.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblVentas.ForeColor = Color.White;
            lblVentas.Location = new Point(142, 75);
            lblVentas.Name = "lblVentas";
            lblVentas.Size = new Size(0, 23);
            lblVentas.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(85, 30);
            label1.Name = "label1";
            label1.Size = new Size(152, 23);
            label1.TabIndex = 1;
            label1.Text = "Total de Ventas";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.dinero;
            pictureBox1.Location = new Point(13, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(66, 53);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 128, 128);
            panel2.Controls.Add(lblClientes);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(pictureBox2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(310, 0);
            panel2.Margin = new Padding(0, 0, 10, 10);
            panel2.Name = "panel2";
            panel2.Size = new Size(300, 149);
            panel2.TabIndex = 3;
            // 
            // lblClientes
            // 
            lblClientes.AutoSize = true;
            lblClientes.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblClientes.ForeColor = Color.White;
            lblClientes.Location = new Point(142, 75);
            lblClientes.Name = "lblClientes";
            lblClientes.Size = new Size(0, 23);
            lblClientes.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(85, 30);
            label4.Name = "label4";
            label4.Size = new Size(163, 23);
            label4.TabIndex = 1;
            label4.Text = "Total de Clientes";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.dinero;
            pictureBox2.Location = new Point(13, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(66, 53);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // pnlDatos
            // 
            pnlDatos.BackColor = Color.FromArgb(0, 192, 192);
            pnlDatos.Controls.Add(lblAdmins);
            pnlDatos.Controls.Add(pictureBox3);
            pnlDatos.Controls.Add(label6);
            pnlDatos.Dock = DockStyle.Fill;
            pnlDatos.Location = new Point(620, 0);
            pnlDatos.Margin = new Padding(0, 0, 10, 10);
            pnlDatos.Name = "pnlDatos";
            pnlDatos.Size = new Size(300, 149);
            pnlDatos.TabIndex = 4;
            // 
            // lblAdmins
            // 
            lblAdmins.AutoSize = true;
            lblAdmins.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblAdmins.ForeColor = Color.White;
            lblAdmins.Location = new Point(142, 75);
            lblAdmins.Name = "lblAdmins";
            lblAdmins.Size = new Size(0, 23);
            lblAdmins.TabIndex = 2;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.dinero;
            pictureBox3.Location = new Point(15, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(66, 53);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(87, 30);
            label6.Name = "label6";
            label6.Size = new Size(158, 23);
            label6.TabIndex = 1;
            label6.Text = "Total de Admins";
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.FromArgb(34, 33, 100);
            pnlTop.Controls.Add(lbldashboard);
            pnlTop.Controls.Add(pbMinimizar);
            pnlTop.Controls.Add(pbMaximizar);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(1242, 41);
            pnlTop.TabIndex = 1;
            pnlTop.MouseDown += pnlTop_MouseDown;
            // 
            // lbldashboard
            // 
            lbldashboard.AutoSize = true;
            lbldashboard.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbldashboard.ForeColor = Color.White;
            lbldashboard.Location = new Point(3, 9);
            lbldashboard.Name = "lbldashboard";
            lbldashboard.Size = new Size(125, 23);
            lbldashboard.TabIndex = 3;
            lbldashboard.Text = "DASHBOARD";
            // 
            // pbMinimizar
            // 
            pbMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbMinimizar.BackColor = Color.FromArgb(128, 128, 255);
            pbMinimizar.Image = Properties.Resources.minimizar;
            pbMinimizar.Location = new Point(1173, 9);
            pbMinimizar.Name = "pbMinimizar";
            pbMinimizar.Size = new Size(30, 27);
            pbMinimizar.SizeMode = PictureBoxSizeMode.StretchImage;
            pbMinimizar.TabIndex = 2;
            pbMinimizar.TabStop = false;
            pbMinimizar.Click += pbMinimizar_Click;
            // 
            // pbMaximizar
            // 
            pbMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbMaximizar.BackColor = Color.FromArgb(128, 128, 255);
            pbMaximizar.Image = Properties.Resources.maximizar;
            pbMaximizar.Location = new Point(1209, 9);
            pbMaximizar.Name = "pbMaximizar";
            pbMaximizar.Size = new Size(30, 27);
            pbMaximizar.SizeMode = PictureBoxSizeMode.StretchImage;
            pbMaximizar.TabIndex = 1;
            pbMaximizar.TabStop = false;
            pbMaximizar.Click += pbMaximizar_Click;
            // 
            // horaFecha
            // 
            horaFecha.Enabled = true;
            horaFecha.Tick += horaFecha_Tick;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1447, 798);
            ControlBox = false;
            Controls.Add(pnlFormulario);
            Controls.Add(pnlNombreUsuario);
            Controls.Add(pnlMenuLateral);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(11, 7, 17);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1447, 798);
            Name = "MainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Compra Joaco - Menu Principal";
            Load += MainMenu_Load;
            pnlMenuLateral.ResumeLayout(false);
            pnlComponentes.ResumeLayout(false);
            pnlLogo.ResumeLayout(false);
            pnlNombreUsuario.ResumeLayout(false);
            pnlNombreUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbUsuario).EndInit();
            pnlFormulario.ResumeLayout(false);
            pnlProductosBajoStock.ResumeLayout(false);
            pnlProductosBajoStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvProductosBajoStock).EndInit();
            pnlDatoss.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            pnlDatos.ResumeLayout(false);
            pnlDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbMaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMenuLateral;
        private Panel pnlComponentes;
        private Button btnPlacaVideo;
        private Button btnComponentes;
        private Panel pnlLogo;
        private Button btnGabinete;
        private Button btnFuenteAlimentacion;
        private Button btnDisco;
        private Button btnRam;
        private Button btnProcesador;
        private Button btnPlacaMadre;
        private Button btnClientes;
        private Button btnMisDatos;
        private Button btnHistorialCompras;
        private Button btnSalir;
        private Panel pnlNombreUsuario;
        private PictureBox pbUsuario;
        private Button btnNombre;
        private Label lblBienvenido;
        private Panel pnlFormulario;
        private System.Windows.Forms.Timer horaFecha;
        private Label lblFecha;
        private Label lblHora;
        private Button btnDatosSucursal;
        private Panel pnlTop;
        private PictureBox pbMinimizar;
        private PictureBox pbMaximizar;
        private Panel pnlDatos;
        private Label lblAdmins;
        private Label label6;
        private PictureBox pictureBox3;
        private Panel panel2;
        private Label lblClientes;
        private Label label4;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Label lblVentas;
        private Label label1;
        private PictureBox pictureBox1;
        private TableLayoutPanel pnlDatoss;
        private Panel panel4;
        private Label lblGanancias;
        private PictureBox pictureBox4;
        private Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btnHome;
        private Label lbldashboard;
        private BindingSource bindingSource1;
        private Panel pnlProductosBajoStock;
        private DataGridView dtgvProductosBajoStock;
        private Label label2;
    }
}