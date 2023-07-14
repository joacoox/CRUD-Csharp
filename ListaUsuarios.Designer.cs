namespace parcialUno
{
    partial class ListaUsuarios
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            btnAlta = new Button();
            btnBaja = new Button();
            btnEditar = new Button();
            txtContra = new TextBox();
            txtNombre = new TextBox();
            txtId = new TextBox();
            lblAdmin = new Label();
            lblContra = new Label();
            lblNombre = new Label();
            lblId = new Label();
            pictureBox1 = new PictureBox();
            btnSalir = new Button();
            dtgvListaUsuarios = new DataGridView();
            clmCliente = new DataGridViewTextBoxColumn();
            clmNombre = new DataGridViewTextBoxColumn();
            clmnContraseña = new DataGridViewTextBoxColumn();
            clmAdmin = new DataGridViewTextBoxColumn();
            btnCancelarEdicion = new Button();
            cbAdmin = new ComboBox();
            btnOrdenarNumero = new Button();
            btnOrdenarNombre = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgvListaUsuarios).BeginInit();
            SuspendLayout();
            // 
            // btnAlta
            // 
            btnAlta.BackColor = Color.FromArgb(0, 60, 200);
            btnAlta.FlatAppearance.BorderSize = 0;
            btnAlta.FlatStyle = FlatStyle.Flat;
            btnAlta.ForeColor = SystemColors.ButtonFace;
            btnAlta.Location = new Point(372, 8);
            btnAlta.Name = "btnAlta";
            btnAlta.Size = new Size(75, 23);
            btnAlta.TabIndex = 3;
            btnAlta.Text = "Agregar";
            btnAlta.UseVisualStyleBackColor = false;
            btnAlta.Click += btnAlta_Click;
            // 
            // btnBaja
            // 
            btnBaja.BackColor = Color.FromArgb(0, 60, 200);
            btnBaja.FlatAppearance.BorderSize = 0;
            btnBaja.FlatStyle = FlatStyle.Flat;
            btnBaja.ForeColor = SystemColors.ButtonFace;
            btnBaja.Location = new Point(372, 34);
            btnBaja.Name = "btnBaja";
            btnBaja.Size = new Size(75, 23);
            btnBaja.TabIndex = 4;
            btnBaja.Text = "Eliminar";
            btnBaja.UseVisualStyleBackColor = false;
            btnBaja.Click += btnBaja_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(0, 60, 200);
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.ForeColor = SystemColors.Control;
            btnEditar.Location = new Point(372, 63);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 5;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // txtContra
            // 
            txtContra.Location = new Point(539, 68);
            txtContra.Name = "txtContra";
            txtContra.Size = new Size(156, 23);
            txtContra.TabIndex = 15;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(539, 38);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(156, 23);
            txtNombre.TabIndex = 13;
            // 
            // txtId
            // 
            txtId.Location = new Point(539, 9);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(156, 23);
            txtId.TabIndex = 12;
            // 
            // lblAdmin
            // 
            lblAdmin.AutoSize = true;
            lblAdmin.BackColor = Color.FromArgb(32, 30, 45);
            lblAdmin.ForeColor = SystemColors.Control;
            lblAdmin.Location = new Point(486, 105);
            lblAdmin.Name = "lblAdmin";
            lblAdmin.Size = new Size(43, 15);
            lblAdmin.TabIndex = 11;
            lblAdmin.Text = "Admin";
            // 
            // lblContra
            // 
            lblContra.AutoSize = true;
            lblContra.ForeColor = SystemColors.Control;
            lblContra.Location = new Point(462, 71);
            lblContra.Name = "lblContra";
            lblContra.Size = new Size(67, 15);
            lblContra.TabIndex = 10;
            lblContra.Text = "Contraseña";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.ForeColor = SystemColors.Control;
            lblNombre.Location = new Point(478, 41);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 9;
            lblNombre.Text = "Nombre";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.ForeColor = SystemColors.Control;
            lblId.Location = new Point(497, 17);
            lblId.Name = "lblId";
            lblId.Size = new Size(18, 15);
            lblId.TabIndex = 8;
            lblId.Text = "ID";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(32, 30, 45);
            pictureBox1.Image = Properties.Resources.persona;
            pictureBox1.Location = new Point(713, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(130, 121);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(0, 60, 200);
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.ForeColor = SystemColors.ButtonFace;
            btnSalir.Location = new Point(913, 450);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(112, 42);
            btnSalir.TabIndex = 17;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // dtgvListaUsuarios
            // 
            dtgvListaUsuarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgvListaUsuarios.BackgroundColor = Color.FromArgb(45, 66, 91);
            dtgvListaUsuarios.BorderStyle = BorderStyle.None;
            dtgvListaUsuarios.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.Window;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dtgvListaUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dtgvListaUsuarios.ColumnHeadersHeight = 30;
            dtgvListaUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dtgvListaUsuarios.Columns.AddRange(new DataGridViewColumn[] { clmCliente, clmNombre, clmnContraseña, clmAdmin });
            dtgvListaUsuarios.EnableHeadersVisualStyles = false;
            dtgvListaUsuarios.GridColor = Color.SteelBlue;
            dtgvListaUsuarios.Location = new Point(55, 136);
            dtgvListaUsuarios.MultiSelect = false;
            dtgvListaUsuarios.Name = "dtgvListaUsuarios";
            dtgvListaUsuarios.ReadOnly = true;
            dtgvListaUsuarios.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dtgvListaUsuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dtgvListaUsuarios.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle6.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dtgvListaUsuarios.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dtgvListaUsuarios.RowTemplate.Height = 25;
            dtgvListaUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvListaUsuarios.Size = new Size(970, 308);
            dtgvListaUsuarios.TabIndex = 19;
            dtgvListaUsuarios.CellClick += dtgvListaUsuarios_CellClick;
            // 
            // clmCliente
            // 
            clmCliente.HeaderText = "N° Cliente";
            clmCliente.Name = "clmCliente";
            clmCliente.ReadOnly = true;
            // 
            // clmNombre
            // 
            clmNombre.HeaderText = "Nombre";
            clmNombre.Name = "clmNombre";
            clmNombre.ReadOnly = true;
            clmNombre.Width = 125;
            // 
            // clmnContraseña
            // 
            clmnContraseña.HeaderText = "Contraseña";
            clmnContraseña.Name = "clmnContraseña";
            clmnContraseña.ReadOnly = true;
            clmnContraseña.Width = 125;
            // 
            // clmAdmin
            // 
            clmAdmin.HeaderText = "Admin";
            clmAdmin.Name = "clmAdmin";
            clmAdmin.ReadOnly = true;
            clmAdmin.Width = 125;
            // 
            // btnCancelarEdicion
            // 
            btnCancelarEdicion.BackColor = Color.FromArgb(0, 60, 200);
            btnCancelarEdicion.FlatAppearance.BorderSize = 0;
            btnCancelarEdicion.FlatStyle = FlatStyle.Flat;
            btnCancelarEdicion.ForeColor = SystemColors.Control;
            btnCancelarEdicion.Location = new Point(372, 89);
            btnCancelarEdicion.Name = "btnCancelarEdicion";
            btnCancelarEdicion.Size = new Size(75, 41);
            btnCancelarEdicion.TabIndex = 21;
            btnCancelarEdicion.Text = "Cancelar edicion";
            btnCancelarEdicion.UseVisualStyleBackColor = false;
            btnCancelarEdicion.Click += btnCancelarEdicion_Click;
            // 
            // cbAdmin
            // 
            cbAdmin.FormattingEnabled = true;
            cbAdmin.Location = new Point(539, 97);
            cbAdmin.Name = "cbAdmin";
            cbAdmin.Size = new Size(156, 23);
            cbAdmin.TabIndex = 22;
            // 
            // btnOrdenarNumero
            // 
            btnOrdenarNumero.BackColor = Color.FromArgb(0, 60, 200);
            btnOrdenarNumero.FlatAppearance.BorderSize = 0;
            btnOrdenarNumero.FlatStyle = FlatStyle.Flat;
            btnOrdenarNumero.ForeColor = SystemColors.Control;
            btnOrdenarNumero.Location = new Point(76, 79);
            btnOrdenarNumero.Name = "btnOrdenarNumero";
            btnOrdenarNumero.Size = new Size(89, 41);
            btnOrdenarNumero.TabIndex = 23;
            btnOrdenarNumero.Text = "Ordenar por Numero";
            btnOrdenarNumero.UseVisualStyleBackColor = false;
            btnOrdenarNumero.Click += btnOrdenarNumero_Click;
            // 
            // btnOrdenarNombre
            // 
            btnOrdenarNombre.BackColor = Color.FromArgb(0, 60, 200);
            btnOrdenarNombre.FlatAppearance.BorderSize = 0;
            btnOrdenarNombre.FlatStyle = FlatStyle.Flat;
            btnOrdenarNombre.ForeColor = SystemColors.Control;
            btnOrdenarNombre.Location = new Point(171, 79);
            btnOrdenarNombre.Name = "btnOrdenarNombre";
            btnOrdenarNombre.Size = new Size(89, 41);
            btnOrdenarNombre.TabIndex = 24;
            btnOrdenarNombre.Text = "Ordenar por Nombre(A-Z)";
            btnOrdenarNombre.UseVisualStyleBackColor = false;
            btnOrdenarNombre.Click += btnOrdenarNombre_Click;
            // 
            // ListaUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 30, 45);
            ClientSize = new Size(1033, 506);
            Controls.Add(btnOrdenarNombre);
            Controls.Add(btnOrdenarNumero);
            Controls.Add(cbAdmin);
            Controls.Add(btnCancelarEdicion);
            Controls.Add(dtgvListaUsuarios);
            Controls.Add(btnSalir);
            Controls.Add(pictureBox1);
            Controls.Add(txtContra);
            Controls.Add(txtNombre);
            Controls.Add(txtId);
            Controls.Add(lblAdmin);
            Controls.Add(lblContra);
            Controls.Add(lblNombre);
            Controls.Add(lblId);
            Controls.Add(btnEditar);
            Controls.Add(btnBaja);
            Controls.Add(btnAlta);
            ForeColor = SystemColors.Control;
            Name = "ListaUsuarios";
            Text = "ListaUsuarios";
            Load += ListaUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgvListaUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAlta;
        private Button btnBaja;
        private Button btnEditar;
        private Label lblAdmin;
        private Label lblContra;
        private Label lblNombre;
        private Label lblId;
        private PictureBox pictureBox1;
        private Button btnSalir;
        private TextBox txtContra;
        private TextBox txtNombre;
        private TextBox txtId;
        private DataGridView dtgvListaUsuarios;
        private DataGridViewTextBoxColumn clmCliente;
        private DataGridViewTextBoxColumn clmNombre;
        private DataGridViewTextBoxColumn clmnContraseña;
        private DataGridViewTextBoxColumn clmAdmin;
        private Button btnCancelarEdicion;
        private ComboBox cbAdmin;
        private Button btnOrdenarNumero;
        private Button btnOrdenarNombre;
    }
}