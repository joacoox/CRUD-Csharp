namespace parcialUno
{
    partial class MostrarProductos
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
            dtgvMostrarProductos = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            clmProducto = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            btnEditar = new Button();
            btnBaja = new Button();
            btnAlta = new Button();
            txtMarca = new TextBox();
            txtPrecio = new TextBox();
            txtNombre = new TextBox();
            lblPrecio = new Label();
            lblMarca = new Label();
            lblNombre = new Label();
            lblComponente = new Label();
            txtDescripcion = new TextBox();
            txtStock = new TextBox();
            pnlMenuProductos = new Panel();
            btnCancelarEdicion = new Button();
            labelRgb = new Label();
            listbRgb = new ListBox();
            lsbColor = new ListBox();
            lblColor = new Label();
            lsbComponente = new ListBox();
            lblStock = new Label();
            lblDescripcion = new Label();
            btnMenuProductos = new Button();
            btnEsconder = new Button();
            btnComprar = new Button();
            btnOrdenarPorNombre = new Button();
            btnOrdenarPorPrecio = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgvMostrarProductos).BeginInit();
            pnlMenuProductos.SuspendLayout();
            SuspendLayout();
            // 
            // dtgvMostrarProductos
            // 
            dtgvMostrarProductos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgvMostrarProductos.BackgroundColor = Color.FromArgb(45, 66, 91);
            dtgvMostrarProductos.BorderStyle = BorderStyle.None;
            dtgvMostrarProductos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.Window;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dtgvMostrarProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dtgvMostrarProductos.ColumnHeadersHeight = 30;
            dtgvMostrarProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dtgvMostrarProductos.Columns.AddRange(new DataGridViewColumn[] { id, clmProducto, dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, Column1, Column3, Column2 });
            dtgvMostrarProductos.EnableHeadersVisualStyles = false;
            dtgvMostrarProductos.GridColor = Color.SteelBlue;
            dtgvMostrarProductos.Location = new Point(22, 198);
            dtgvMostrarProductos.Name = "dtgvMostrarProductos";
            dtgvMostrarProductos.ReadOnly = true;
            dtgvMostrarProductos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dtgvMostrarProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dtgvMostrarProductos.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle6.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dtgvMostrarProductos.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dtgvMostrarProductos.RowTemplate.Height = 25;
            dtgvMostrarProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvMostrarProductos.Size = new Size(978, 366);
            dtgvMostrarProductos.TabIndex = 5;
            dtgvMostrarProductos.CellClick += dtgvMostrarProductos_CellClick;
            // 
            // id
            // 
            id.HeaderText = "id";
            id.Name = "id";
            id.ReadOnly = true;
            // 
            // clmProducto
            // 
            clmProducto.HeaderText = "Componente";
            clmProducto.Name = "clmProducto";
            clmProducto.ReadOnly = true;
            clmProducto.Width = 200;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Marca";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Precio";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Rgb";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // Column1
            // 
            Column1.HeaderText = "Descripcion Producto";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 250;
            // 
            // Column3
            // 
            Column3.HeaderText = "Color";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Stock";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(0, 60, 200);
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.ForeColor = SystemColors.Control;
            btnEditar.Location = new Point(3, 65);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 8;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnBaja
            // 
            btnBaja.BackColor = Color.FromArgb(0, 60, 200);
            btnBaja.FlatAppearance.BorderSize = 0;
            btnBaja.FlatStyle = FlatStyle.Flat;
            btnBaja.ForeColor = SystemColors.ButtonFace;
            btnBaja.Location = new Point(3, 36);
            btnBaja.Name = "btnBaja";
            btnBaja.Size = new Size(75, 23);
            btnBaja.TabIndex = 7;
            btnBaja.Text = "Eliminar";
            btnBaja.UseVisualStyleBackColor = false;
            btnBaja.Click += btnBaja_Click;
            // 
            // btnAlta
            // 
            btnAlta.BackColor = Color.FromArgb(0, 60, 200);
            btnAlta.FlatAppearance.BorderSize = 0;
            btnAlta.FlatStyle = FlatStyle.Flat;
            btnAlta.ForeColor = SystemColors.ButtonFace;
            btnAlta.Location = new Point(3, 7);
            btnAlta.Name = "btnAlta";
            btnAlta.Size = new Size(75, 23);
            btnAlta.TabIndex = 6;
            btnAlta.Text = "Agregar";
            btnAlta.UseVisualStyleBackColor = false;
            btnAlta.Click += btnAlta_Click;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(176, 77);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(157, 23);
            txtMarca.TabIndex = 23;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(176, 106);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(157, 23);
            txtPrecio.TabIndex = 22;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(176, 47);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(157, 23);
            txtNombre.TabIndex = 21;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.BackColor = Color.FromArgb(32, 30, 45);
            lblPrecio.ForeColor = SystemColors.Control;
            lblPrecio.Location = new Point(127, 114);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(40, 15);
            lblPrecio.TabIndex = 19;
            lblPrecio.Text = "Precio";
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.ForeColor = SystemColors.Control;
            lblMarca.Location = new Point(127, 80);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(40, 15);
            lblMarca.TabIndex = 18;
            lblMarca.Text = "Marca";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.ForeColor = SystemColors.Control;
            lblNombre.Location = new Point(119, 50);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 17;
            lblNombre.Text = "Nombre";
            // 
            // lblComponente
            // 
            lblComponente.AutoSize = true;
            lblComponente.ForeColor = SystemColors.Control;
            lblComponente.Location = new Point(93, 21);
            lblComponente.Name = "lblComponente";
            lblComponente.Size = new Size(77, 15);
            lblComponente.TabIndex = 16;
            lblComponente.Text = "Componente";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(439, 47);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(157, 23);
            txtDescripcion.TabIndex = 25;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(439, 106);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(157, 23);
            txtStock.TabIndex = 26;
            // 
            // pnlMenuProductos
            // 
            pnlMenuProductos.Controls.Add(btnCancelarEdicion);
            pnlMenuProductos.Controls.Add(labelRgb);
            pnlMenuProductos.Controls.Add(listbRgb);
            pnlMenuProductos.Controls.Add(lsbColor);
            pnlMenuProductos.Controls.Add(lblColor);
            pnlMenuProductos.Controls.Add(lsbComponente);
            pnlMenuProductos.Controls.Add(btnBaja);
            pnlMenuProductos.Controls.Add(lblStock);
            pnlMenuProductos.Controls.Add(btnAlta);
            pnlMenuProductos.Controls.Add(lblDescripcion);
            pnlMenuProductos.Controls.Add(btnEditar);
            pnlMenuProductos.Controls.Add(txtStock);
            pnlMenuProductos.Controls.Add(lblComponente);
            pnlMenuProductos.Controls.Add(txtDescripcion);
            pnlMenuProductos.Controls.Add(lblNombre);
            pnlMenuProductos.Controls.Add(lblMarca);
            pnlMenuProductos.Controls.Add(txtMarca);
            pnlMenuProductos.Controls.Add(lblPrecio);
            pnlMenuProductos.Controls.Add(txtPrecio);
            pnlMenuProductos.Controls.Add(txtNombre);
            pnlMenuProductos.Location = new Point(320, 1);
            pnlMenuProductos.Name = "pnlMenuProductos";
            pnlMenuProductos.Size = new Size(638, 191);
            pnlMenuProductos.TabIndex = 27;
            // 
            // btnCancelarEdicion
            // 
            btnCancelarEdicion.BackColor = Color.FromArgb(0, 60, 200);
            btnCancelarEdicion.FlatAppearance.BorderSize = 0;
            btnCancelarEdicion.FlatStyle = FlatStyle.Flat;
            btnCancelarEdicion.ForeColor = SystemColors.Control;
            btnCancelarEdicion.Location = new Point(3, 94);
            btnCancelarEdicion.Name = "btnCancelarEdicion";
            btnCancelarEdicion.Size = new Size(75, 44);
            btnCancelarEdicion.TabIndex = 36;
            btnCancelarEdicion.Text = "Cancelar edicion";
            btnCancelarEdicion.UseVisualStyleBackColor = false;
            btnCancelarEdicion.Click += btnCancelarEdicion_Click;
            // 
            // labelRgb
            // 
            labelRgb.AutoSize = true;
            labelRgb.ForeColor = SystemColors.Control;
            labelRgb.Location = new Point(397, 21);
            labelRgb.Name = "labelRgb";
            labelRgb.Size = new Size(28, 15);
            labelRgb.TabIndex = 34;
            labelRgb.Text = "Rgb";
            // 
            // listbRgb
            // 
            listbRgb.FormattingEnabled = true;
            listbRgb.ItemHeight = 15;
            listbRgb.Location = new Point(439, 18);
            listbRgb.Name = "listbRgb";
            listbRgb.Size = new Size(157, 19);
            listbRgb.TabIndex = 32;
            // 
            // lsbColor
            // 
            lsbColor.FormattingEnabled = true;
            lsbColor.ItemHeight = 15;
            lsbColor.Location = new Point(439, 76);
            lsbColor.Name = "lsbColor";
            lsbColor.Size = new Size(157, 19);
            lsbColor.TabIndex = 31;
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.ForeColor = SystemColors.Control;
            lblColor.Location = new Point(389, 84);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(36, 15);
            lblColor.TabIndex = 31;
            lblColor.Text = "Color";
            // 
            // lsbComponente
            // 
            lsbComponente.FormattingEnabled = true;
            lsbComponente.ItemHeight = 15;
            lsbComponente.Location = new Point(176, 18);
            lsbComponente.Name = "lsbComponente";
            lsbComponente.Size = new Size(157, 19);
            lsbComponente.TabIndex = 29;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.ForeColor = SystemColors.Control;
            lblStock.Location = new Point(389, 114);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(36, 15);
            lblStock.TabIndex = 29;
            lblStock.Text = "Stock";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.ForeColor = SystemColors.Control;
            lblDescripcion.Location = new Point(364, 55);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(69, 15);
            lblDescripcion.TabIndex = 28;
            lblDescripcion.Text = "Descripcion";
            // 
            // btnMenuProductos
            // 
            btnMenuProductos.BackColor = Color.FromArgb(0, 60, 200);
            btnMenuProductos.FlatAppearance.BorderSize = 0;
            btnMenuProductos.FlatStyle = FlatStyle.Flat;
            btnMenuProductos.ForeColor = SystemColors.ButtonFace;
            btnMenuProductos.Location = new Point(22, 42);
            btnMenuProductos.Name = "btnMenuProductos";
            btnMenuProductos.Size = new Size(169, 33);
            btnMenuProductos.TabIndex = 27;
            btnMenuProductos.Text = "Mostrar Menu Productos";
            btnMenuProductos.UseVisualStyleBackColor = false;
            btnMenuProductos.Click += btnMenuProductos_Click;
            // 
            // btnEsconder
            // 
            btnEsconder.BackColor = Color.FromArgb(0, 60, 200);
            btnEsconder.FlatAppearance.BorderSize = 0;
            btnEsconder.FlatStyle = FlatStyle.Flat;
            btnEsconder.ForeColor = SystemColors.ButtonFace;
            btnEsconder.Location = new Point(22, 81);
            btnEsconder.Name = "btnEsconder";
            btnEsconder.Size = new Size(169, 33);
            btnEsconder.TabIndex = 28;
            btnEsconder.Text = "Esconder Menu Productos";
            btnEsconder.UseVisualStyleBackColor = false;
            btnEsconder.Click += btnEsconder_Click;
            // 
            // btnComprar
            // 
            btnComprar.BackColor = Color.FromArgb(0, 60, 200);
            btnComprar.FlatAppearance.BorderSize = 0;
            btnComprar.FlatStyle = FlatStyle.Flat;
            btnComprar.ForeColor = SystemColors.Control;
            btnComprar.Location = new Point(38, 48);
            btnComprar.Name = "btnComprar";
            btnComprar.Size = new Size(124, 48);
            btnComprar.TabIndex = 29;
            btnComprar.Text = "Comprar";
            btnComprar.UseVisualStyleBackColor = false;
            btnComprar.Click += btnComprar_Click;
            // 
            // btnOrdenarPorNombre
            // 
            btnOrdenarPorNombre.BackColor = Color.FromArgb(0, 60, 200);
            btnOrdenarPorNombre.FlatAppearance.BorderSize = 0;
            btnOrdenarPorNombre.FlatStyle = FlatStyle.Flat;
            btnOrdenarPorNombre.ForeColor = SystemColors.Control;
            btnOrdenarPorNombre.Location = new Point(38, 120);
            btnOrdenarPorNombre.Name = "btnOrdenarPorNombre";
            btnOrdenarPorNombre.Size = new Size(81, 55);
            btnOrdenarPorNombre.TabIndex = 37;
            btnOrdenarPorNombre.Text = "Ordenar por nombre (A-Z)";
            btnOrdenarPorNombre.UseVisualStyleBackColor = false;
            btnOrdenarPorNombre.Click += btnOrdenarPorNombre_Click;
            // 
            // btnOrdenarPorPrecio
            // 
            btnOrdenarPorPrecio.BackColor = Color.FromArgb(0, 60, 200);
            btnOrdenarPorPrecio.FlatAppearance.BorderSize = 0;
            btnOrdenarPorPrecio.FlatStyle = FlatStyle.Flat;
            btnOrdenarPorPrecio.ForeColor = SystemColors.Control;
            btnOrdenarPorPrecio.Location = new Point(125, 120);
            btnOrdenarPorPrecio.Name = "btnOrdenarPorPrecio";
            btnOrdenarPorPrecio.Size = new Size(75, 55);
            btnOrdenarPorPrecio.TabIndex = 38;
            btnOrdenarPorPrecio.Text = "Ordenar por precio";
            btnOrdenarPorPrecio.UseVisualStyleBackColor = false;
            btnOrdenarPorPrecio.Click += btnOrdenarPorPrecio_Click;
            // 
            // MostrarProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 30, 45);
            ClientSize = new Size(1028, 603);
            Controls.Add(btnOrdenarPorPrecio);
            Controls.Add(btnOrdenarPorNombre);
            Controls.Add(btnComprar);
            Controls.Add(btnEsconder);
            Controls.Add(btnMenuProductos);
            Controls.Add(pnlMenuProductos);
            Controls.Add(dtgvMostrarProductos);
            Name = "MostrarProductos";
            Text = "MostrarProductos";
            Load += MostrarProductos_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvMostrarProductos).EndInit();
            pnlMenuProductos.ResumeLayout(false);
            pnlMenuProductos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtgvMostrarProductos;
        private Button btnEditar;
        private Button btnBaja;
        private Button btnAlta;
        private TextBox txtMarca;
        private TextBox txtPrecio;
        private TextBox txtNombre;
        private Label lblPrecio;
        private Label lblMarca;
        private Label lblNombre;
        private Label lblComponente;
        private TextBox txtDescripcion;
        private TextBox txtStock;
        private Panel pnlMenuProductos;
        private Button btnMenuProductos;
        private Label lblStock;
        private Label lblDescripcion;
        private Button btnEsconder;
        private Label lblColor;
        private ListBox lsbComponente;
        private ListBox lsbRgb;
        private ListBox lsbColor;
        private Button btnComprar;
        private ListBox listbRgb;
        private Label labelRgb;
        private Button btnCancelarEdicion;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn clmProducto;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column2;
        private Button btnOrdenarPorNombre;
        private Button btnOrdenarPorPrecio;
    }
}