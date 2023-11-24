namespace FormPresentacion
{
    partial class FormListarVentasPorCategorias
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            btnVentaProdCat = new Button();
            masVentasDetalle = new DataGridView();
            ventaId = new DataGridViewTextBoxColumn();
            ventaCantidad = new DataGridViewTextBoxColumn();
            ventaEstado = new DataGridViewTextBoxColumn();
            ventaFechaA = new DataGridViewTextBoxColumn();
            cmbClientes = new ComboBox();
            lblCliente = new Label();
            ((System.ComponentModel.ISupportInitialize)masVentasDetalle).BeginInit();
            SuspendLayout();
            // 
            // btnVentaProdCat
            // 
            btnVentaProdCat.BackColor = Color.DarkGray;
            btnVentaProdCat.FlatAppearance.BorderSize = 0;
            btnVentaProdCat.FlatAppearance.CheckedBackColor = Color.Black;
            btnVentaProdCat.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnVentaProdCat.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnVentaProdCat.FlatStyle = FlatStyle.Flat;
            btnVentaProdCat.Location = new Point(56, 345);
            btnVentaProdCat.Margin = new Padding(4);
            btnVentaProdCat.Name = "btnVentaProdCat";
            btnVentaProdCat.Size = new Size(101, 30);
            btnVentaProdCat.TabIndex = 7;
            btnVentaProdCat.Text = "Listar";
            btnVentaProdCat.UseVisualStyleBackColor = false;
            btnVentaProdCat.Click += btnVentaProdCat_Click;
            // 
            // masVentasDetalle
            // 
            masVentasDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            masVentasDetalle.Columns.AddRange(new DataGridViewColumn[] { ventaId, ventaCantidad, ventaEstado, ventaFechaA });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            masVentasDetalle.DefaultCellStyle = dataGridViewCellStyle5;
            masVentasDetalle.Enabled = false;
            masVentasDetalle.EnableHeadersVisualStyles = false;
            masVentasDetalle.Location = new Point(56, 26);
            masVentasDetalle.Name = "masVentasDetalle";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            masVentasDetalle.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            masVentasDetalle.RowTemplate.Height = 25;
            masVentasDetalle.Size = new Size(644, 283);
            masVentasDetalle.TabIndex = 40;
            // 
            // ventaId
            // 
            ventaId.HeaderText = "ID Cliente";
            ventaId.Name = "ventaId";
            ventaId.Width = 200;
            // 
            // ventaCantidad
            // 
            ventaCantidad.HeaderText = "Cantidad";
            ventaCantidad.Name = "ventaCantidad";
            // 
            // ventaEstado
            // 
            ventaEstado.HeaderText = "Estado";
            ventaEstado.Name = "ventaEstado";
            // 
            // ventaFechaA
            // 
            ventaFechaA.HeaderText = "Fecha Alta";
            ventaFechaA.Name = "ventaFechaA";
            ventaFechaA.Width = 200;
            // 
            // cmbClientes
            // 
            cmbClientes.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbClientes.FormattingEnabled = true;
            cmbClientes.Location = new Point(515, 352);
            cmbClientes.Name = "cmbClientes";
            cmbClientes.Size = new Size(185, 23);
            cmbClientes.TabIndex = 79;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(457, 360);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(52, 15);
            lblCliente.TabIndex = 85;
            lblCliente.Text = "Clientes:";
            // 
            // FormListarVentasPorCategorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblCliente);
            Controls.Add(cmbClientes);
            Controls.Add(masVentasDetalle);
            Controls.Add(btnVentaProdCat);
            Name = "FormListarVentasPorCategorias";
            Text = "Maximas Ventas por Cliente";
            Load += FormListarVentasPorCategorias_Load;
            ((System.ComponentModel.ISupportInitialize)masVentasDetalle).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnVentaProdCat;
        private DataGridView masVentasDetalle;
        private DataGridViewTextBoxColumn ventaId;
        private DataGridViewTextBoxColumn ventaCantidad;
        private DataGridViewTextBoxColumn ventaEstado;
        private DataGridViewTextBoxColumn ventaFechaA;
        private ComboBox cmbClientes;
        private Label lblCliente;
    }
}