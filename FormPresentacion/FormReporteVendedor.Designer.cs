namespace FormPresentacion
{
    partial class FormReporteVendedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReporteVendedor));
            groupBox1 = new GroupBox();
            lblIDvendedor = new Label();
            txtIDUsuario = new TextBox();
            lblDetalle = new Label();
            txbtotalPagar = new TextBox();
            lblTotalVendido = new Label();
            dataGridView1 = new DataGridView();
            idVenta = new DataGridViewTextBoxColumn();
            fechaOp = new DataGridViewTextBoxColumn();
            nomEmpresa = new DataGridViewTextBoxColumn();
            idCliente = new DataGridViewTextBoxColumn();
            idProd = new DataGridViewTextBoxColumn();
            descProd = new DataGridViewTextBoxColumn();
            monUni = new DataGridViewTextBoxColumn();
            monTot = new DataGridViewTextBoxColumn();
            btnBuscarVentaporIdVenta = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnBuscarVentaporIdVenta);
            groupBox1.Controls.Add(lblIDvendedor);
            groupBox1.Controls.Add(txtIDUsuario);
            groupBox1.Controls.Add(lblDetalle);
            groupBox1.Controls.Add(txbtotalPagar);
            groupBox1.Controls.Add(lblTotalVendido);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(22, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(883, 413);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Reporte de ventas por vendedor";
            // 
            // lblIDvendedor
            // 
            lblIDvendedor.AutoSize = true;
            lblIDvendedor.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblIDvendedor.Location = new Point(23, 31);
            lblIDvendedor.Name = "lblIDvendedor";
            lblIDvendedor.Size = new Size(77, 15);
            lblIDvendedor.TabIndex = 0;
            lblIDvendedor.Text = "ID Vendedor";
            // 
            // txtIDUsuario
            // 
            txtIDUsuario.Location = new Point(23, 48);
            txtIDUsuario.Margin = new Padding(3, 2, 3, 2);
            txtIDUsuario.Name = "txtIDUsuario";
            txtIDUsuario.Size = new Size(162, 23);
            txtIDUsuario.TabIndex = 22;
            // 
            // lblDetalle
            // 
            lblDetalle.AutoSize = true;
            lblDetalle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblDetalle.Location = new Point(23, 87);
            lblDetalle.Name = "lblDetalle";
            lblDetalle.Size = new Size(50, 15);
            lblDetalle.TabIndex = 27;
            lblDetalle.Text = "Detalle:";
            // 
            // txbtotalPagar
            // 
            txbtotalPagar.Enabled = false;
            txbtotalPagar.Location = new Point(737, 375);
            txbtotalPagar.Margin = new Padding(3, 2, 3, 2);
            txbtotalPagar.Name = "txbtotalPagar";
            txbtotalPagar.Size = new Size(124, 23);
            txbtotalPagar.TabIndex = 26;
            // 
            // lblTotalVendido
            // 
            lblTotalVendido.AutoSize = true;
            lblTotalVendido.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalVendido.Location = new Point(643, 378);
            lblTotalVendido.Name = "lblTotalVendido";
            lblTotalVendido.Size = new Size(88, 15);
            lblTotalVendido.TabIndex = 25;
            lblTotalVendido.Text = "Total Vendido: ";
            lblTotalVendido.Click += lblTotalPagar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idVenta, fechaOp, nomEmpresa, idCliente, idProd, descProd, monUni, monTot });
            dataGridView1.Enabled = false;
            dataGridView1.Location = new Point(23, 105);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(838, 79);
            dataGridView1.TabIndex = 23;
            // 
            // idVenta
            // 
            idVenta.HeaderText = "ID Venta";
            idVenta.Name = "idVenta";
            // 
            // fechaOp
            // 
            fechaOp.HeaderText = "Fecha";
            fechaOp.Name = "fechaOp";
            // 
            // nomEmpresa
            // 
            nomEmpresa.HeaderText = "Empresa";
            nomEmpresa.Name = "nomEmpresa";
            // 
            // idCliente
            // 
            idCliente.HeaderText = "ID Cliente";
            idCliente.Name = "idCliente";
            // 
            // idProd
            // 
            idProd.HeaderText = "ID Producto";
            idProd.Name = "idProd";
            // 
            // descProd
            // 
            descProd.HeaderText = "Descripción ";
            descProd.Name = "descProd";
            // 
            // monUni
            // 
            monUni.HeaderText = "Monto Unitario";
            monUni.Name = "monUni";
            // 
            // monTot
            // 
            monTot.HeaderText = "Monto total";
            monTot.Name = "monTot";
            // 
            // btnBuscarVentaporIdVenta
            // 
            btnBuscarVentaporIdVenta.BackColor = Color.Silver;
            btnBuscarVentaporIdVenta.FlatAppearance.BorderColor = Color.Silver;
            btnBuscarVentaporIdVenta.FlatAppearance.CheckedBackColor = Color.Black;
            btnBuscarVentaporIdVenta.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnBuscarVentaporIdVenta.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            btnBuscarVentaporIdVenta.FlatStyle = FlatStyle.Flat;
            btnBuscarVentaporIdVenta.Location = new Point(192, 48);
            btnBuscarVentaporIdVenta.Margin = new Padding(4);
            btnBuscarVentaporIdVenta.Name = "btnBuscarVentaporIdVenta";
            btnBuscarVentaporIdVenta.Size = new Size(61, 23);
            btnBuscarVentaporIdVenta.TabIndex = 38;
            btnBuscarVentaporIdVenta.Text = "Buscar";
            btnBuscarVentaporIdVenta.UseVisualStyleBackColor = false;
            // 
            // FormReporteVendedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(925, 437);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormReporteVendedor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormReporteVentas";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label lblIDvendedor;
        private Label lblDetalle;
        private TextBox txbtotalPagar;
        private Label lblTotalVendido;
        private DataGridView dataGridView1;
        private TextBox txtIDUsuario;
        private DataGridViewTextBoxColumn idVenta;
        private DataGridViewTextBoxColumn fechaOp;
        private DataGridViewTextBoxColumn nomEmpresa;
        private DataGridViewTextBoxColumn idCliente;
        private DataGridViewTextBoxColumn idProd;
        private DataGridViewTextBoxColumn descProd;
        private DataGridViewTextBoxColumn monUni;
        private DataGridViewTextBoxColumn monTot;
        private Button btnBuscarVentaporIdVenta;
    }
}