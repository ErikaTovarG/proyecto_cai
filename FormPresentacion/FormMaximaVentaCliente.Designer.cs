namespace FormPresentacion
{
    partial class FormMaximaVentaCliente
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            cmbClientes = new ComboBox();
            masVentasDetalle = new DataGridView();
            btnVentaMaxCliente = new Button();
            btnLimpiar = new Button();
            ventaId = new DataGridViewTextBoxColumn();
            ventaCantidad = new DataGridViewTextBoxColumn();
            ventaEstado = new DataGridViewTextBoxColumn();
            ventaFechaA = new DataGridViewTextBoxColumn();
            lblCliente = new Label();
            ((System.ComponentModel.ISupportInitialize)masVentasDetalle).BeginInit();
            SuspendLayout();
            // 
            // cmbClientes
            // 
            cmbClientes.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbClientes.FormattingEnabled = true;
            cmbClientes.Location = new Point(333, 361);
            cmbClientes.Name = "cmbClientes";
            cmbClientes.Size = new Size(185, 23);
            cmbClientes.TabIndex = 82;
            // 
            // masVentasDetalle
            // 
            masVentasDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            masVentasDetalle.Columns.AddRange(new DataGridViewColumn[] { ventaId, ventaCantidad, ventaEstado, ventaFechaA });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            masVentasDetalle.DefaultCellStyle = dataGridViewCellStyle3;
            masVentasDetalle.Enabled = false;
            masVentasDetalle.EnableHeadersVisualStyles = false;
            masVentasDetalle.Location = new Point(69, 45);
            masVentasDetalle.Name = "masVentasDetalle";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            masVentasDetalle.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            masVentasDetalle.RowTemplate.Height = 25;
            masVentasDetalle.Size = new Size(644, 283);
            masVentasDetalle.TabIndex = 81;
            // 
            // btnVentaMaxCliente
            // 
            btnVentaMaxCliente.BackColor = Color.DarkGray;
            btnVentaMaxCliente.FlatAppearance.BorderSize = 0;
            btnVentaMaxCliente.FlatAppearance.CheckedBackColor = Color.Black;
            btnVentaMaxCliente.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnVentaMaxCliente.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnVentaMaxCliente.FlatStyle = FlatStyle.Flat;
            btnVentaMaxCliente.Location = new Point(69, 356);
            btnVentaMaxCliente.Margin = new Padding(4);
            btnVentaMaxCliente.Name = "btnVentaMaxCliente";
            btnVentaMaxCliente.Size = new Size(101, 30);
            btnVentaMaxCliente.TabIndex = 80;
            btnVentaMaxCliente.Text = "Listar";
            btnVentaMaxCliente.UseVisualStyleBackColor = false;
            btnVentaMaxCliente.Click += btnVentaMaxCliente_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.DarkGray;
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatAppearance.CheckedBackColor = Color.Black;
            btnLimpiar.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnLimpiar.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Location = new Point(612, 356);
            btnLimpiar.Margin = new Padding(4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(101, 30);
            btnLimpiar.TabIndex = 83;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
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
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(275, 367);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(52, 15);
            lblCliente.TabIndex = 84;
            lblCliente.Text = "Clientes:";
            // 
            // FormMaximaVentaCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblCliente);
            Controls.Add(btnLimpiar);
            Controls.Add(cmbClientes);
            Controls.Add(masVentasDetalle);
            Controls.Add(btnVentaMaxCliente);
            Name = "FormMaximaVentaCliente";
            Text = "Maximas Ventas a Clientes";
            Load += FormMaximaVentaCliente_Load;
            ((System.ComponentModel.ISupportInitialize)masVentasDetalle).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbClientes;
        private DataGridView masVentasDetalle;
        private Button btnVentaMaxCliente;
        private Button btnLimpiar;
        private DataGridViewTextBoxColumn ventaId;
        private DataGridViewTextBoxColumn ventaCantidad;
        private DataGridViewTextBoxColumn ventaEstado;
        private DataGridViewTextBoxColumn ventaFechaA;
        private Label lblCliente;
    }
}