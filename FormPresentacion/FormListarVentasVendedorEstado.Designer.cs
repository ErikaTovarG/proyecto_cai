namespace FormPresentacion
{
    partial class FormListarVentasVendedorEstado
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
            ventasEstado = new DataGridView();
            ventaId = new DataGridViewTextBoxColumn();
            ventaCantidad = new DataGridViewTextBoxColumn();
            ventaEstado = new DataGridViewTextBoxColumn();
            ventaFechaA = new DataGridViewTextBoxColumn();
            btnVentaEstado = new Button();
            cmbEstado = new ComboBox();
            cmbClientes = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)ventasEstado).BeginInit();
            SuspendLayout();
            // 
            // ventasEstado
            // 
            ventasEstado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ventasEstado.Columns.AddRange(new DataGridViewColumn[] { ventaId, ventaCantidad, ventaEstado, ventaFechaA });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            ventasEstado.DefaultCellStyle = dataGridViewCellStyle1;
            ventasEstado.Enabled = false;
            ventasEstado.EnableHeadersVisualStyles = false;
            ventasEstado.Location = new Point(93, 49);
            ventasEstado.Name = "ventasEstado";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            ventasEstado.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            ventasEstado.RowTemplate.Height = 25;
            ventasEstado.Size = new Size(642, 283);
            ventasEstado.TabIndex = 43;
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
            // btnVentaEstado
            // 
            btnVentaEstado.BackColor = Color.DarkGray;
            btnVentaEstado.FlatAppearance.BorderSize = 0;
            btnVentaEstado.FlatAppearance.CheckedBackColor = Color.Black;
            btnVentaEstado.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnVentaEstado.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnVentaEstado.FlatStyle = FlatStyle.Flat;
            btnVentaEstado.Location = new Point(103, 362);
            btnVentaEstado.Margin = new Padding(4);
            btnVentaEstado.Name = "btnVentaEstado";
            btnVentaEstado.Size = new Size(101, 30);
            btnVentaEstado.TabIndex = 41;
            btnVentaEstado.Text = "Listar";
            btnVentaEstado.UseVisualStyleBackColor = false;
            btnVentaEstado.Click += btnVentaEstado_Click;
            // 
            // cmbEstado
            // 
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new Point(522, 369);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(185, 23);
            cmbEstado.TabIndex = 77;
            // 
            // cmbClientes
            // 
            cmbClientes.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbClientes.FormattingEnabled = true;
            cmbClientes.Location = new Point(284, 367);
            cmbClientes.Name = "cmbClientes";
            cmbClientes.Size = new Size(185, 23);
            cmbClientes.TabIndex = 78;
            // 
            // FormListarVentasVendedorEstado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbClientes);
            Controls.Add(cmbEstado);
            Controls.Add(ventasEstado);
            Controls.Add(btnVentaEstado);
            Name = "FormListarVentasVendedorEstado";
            Text = "Reporte de Ventas Por Cliente / Estado";
            Load += FormListarVentasVendedorEstado_Load;
            ((System.ComponentModel.ISupportInitialize)ventasEstado).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView ventasEstado;
        private DataGridViewTextBoxColumn ventaId;
        private DataGridViewTextBoxColumn ventaCantidad;
        private DataGridViewTextBoxColumn ventaEstado;
        private DataGridViewTextBoxColumn ventaFechaA;
        private Button btnVentaEstado;
        private ComboBox cmbEstado;
        private ComboBox cmbClientes;
    }
}