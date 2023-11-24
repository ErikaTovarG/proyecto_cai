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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            btnVentaProdCat = new Button();
            masVentasDetalle = new DataGridView();
            cmbClientes = new ComboBox();
            lblCliente = new Label();
            ventaId = new DataGridViewTextBoxColumn();
            ventaCantidad = new DataGridViewTextBoxColumn();
            ventaEstado = new DataGridViewTextBoxColumn();
            ventaFechaA = new DataGridViewTextBoxColumn();
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            masVentasDetalle.DefaultCellStyle = dataGridViewCellStyle1;
            masVentasDetalle.Enabled = false;
            masVentasDetalle.EnableHeadersVisualStyles = false;
            masVentasDetalle.Location = new Point(56, 26);
            masVentasDetalle.Name = "masVentasDetalle";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            masVentasDetalle.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            masVentasDetalle.RowTemplate.Height = 25;
            masVentasDetalle.Size = new Size(644, 283);
            masVentasDetalle.TabIndex = 40;
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
            // ventaId
            // 
            ventaId.HeaderText = "ID Venta";
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