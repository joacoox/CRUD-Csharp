namespace parcialUno
{
    partial class RegistroCompras
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dtgvHistorialCompras = new DataGridView();
            btnGenerarPdf = new Button();
            lblNombre = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgvHistorialCompras).BeginInit();
            SuspendLayout();
            // 
            // dtgvHistorialCompras
            // 
            dtgvHistorialCompras.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgvHistorialCompras.BackgroundColor = Color.FromArgb(45, 66, 91);
            dtgvHistorialCompras.BorderStyle = BorderStyle.None;
            dtgvHistorialCompras.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtgvHistorialCompras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgvHistorialCompras.ColumnHeadersHeight = 30;
            dtgvHistorialCompras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dtgvHistorialCompras.EnableHeadersVisualStyles = false;
            dtgvHistorialCompras.GridColor = Color.SteelBlue;
            dtgvHistorialCompras.Location = new Point(12, 12);
            dtgvHistorialCompras.Name = "dtgvHistorialCompras";
            dtgvHistorialCompras.ReadOnly = true;
            dtgvHistorialCompras.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dtgvHistorialCompras.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dtgvHistorialCompras.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dtgvHistorialCompras.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dtgvHistorialCompras.RowTemplate.Height = 25;
            dtgvHistorialCompras.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvHistorialCompras.Size = new Size(810, 483);
            dtgvHistorialCompras.TabIndex = 6;
            // 
            // btnGenerarPdf
            // 
            btnGenerarPdf.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGenerarPdf.BackColor = Color.FromArgb(0, 60, 200);
            btnGenerarPdf.FlatAppearance.BorderSize = 0;
            btnGenerarPdf.FlatStyle = FlatStyle.Flat;
            btnGenerarPdf.ForeColor = SystemColors.Control;
            btnGenerarPdf.Location = new Point(828, 98);
            btnGenerarPdf.Name = "btnGenerarPdf";
            btnGenerarPdf.Size = new Size(75, 41);
            btnGenerarPdf.TabIndex = 22;
            btnGenerarPdf.Text = "Generar";
            btnGenerarPdf.UseVisualStyleBackColor = false;
            btnGenerarPdf.Click += btnGenerarPdf_Click;
            // 
            // lblNombre
            // 
            lblNombre.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.ForeColor = SystemColors.ButtonHighlight;
            lblNombre.Location = new Point(828, 32);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(214, 24);
            lblNombre.TabIndex = 23;
            lblNombre.Text = "Generar Registro de";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(828, 62);
            label1.Name = "label1";
            label1.Size = new Size(192, 24);
            label1.TabIndex = 24;
            label1.Text = " las ventas en pdf";
            // 
            // RegistroCompras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 30, 45);
            ClientSize = new Size(1089, 571);
            Controls.Add(label1);
            Controls.Add(lblNombre);
            Controls.Add(btnGenerarPdf);
            Controls.Add(dtgvHistorialCompras);
            Name = "RegistroCompras";
            Text = "RegistroCompras";
            Load += RegistroCompras_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvHistorialCompras).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgvHistorialCompras;
        private Button btnGenerarPdf;
        private Label lblNombre;
        private Label label1;
    }
}