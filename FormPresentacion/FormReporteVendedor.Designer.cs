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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReporteVendedor));
            lblTotalVendido = new Label();
            txbtotalPagar = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            lblnroFactura = new Label();
            btnBuscarVentaporIdCliente = new Button();
            tboxIdVendedor = new TextBox();
            gbDevVenta = new GroupBox();
            btnEliminarVenta = new Button();
            tbTotalPagado = new TextBox();
            dgbDetalle = new DataGridView();
            IdVenta = new DataGridViewTextBoxColumn();
            fechaOp = new DataGridViewTextBoxColumn();
            idProducto = new DataGridViewTextBoxColumn();
            desProducto = new DataGridViewTextBoxColumn();
            cant = new DataGridViewTextBoxColumn();
            mUnitario = new DataGridViewTextBoxColumn();
            mTotal = new DataGridViewTextBoxColumn();
            lblDetalle = new Label();
            label5 = new Label();
            gbDevVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgbDetalle).BeginInit();
            SuspendLayout();
            // 
            // lblTotalVendido
            // 
            lblTotalVendido.AutoSize = true;
            lblTotalVendido.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalVendido.Location = new Point(6, 338);
            lblTotalVendido.Name = "lblTotalVendido";
            lblTotalVendido.Size = new Size(98, 15);
            lblTotalVendido.TabIndex = 25;
            lblTotalVendido.Text = "Monto vendido: ";
            lblTotalVendido.Click += lblTotalPagar_Click;
            // 
            // txbtotalPagar
            // 
            txbtotalPagar.Enabled = false;
            txbtotalPagar.Location = new Point(8, 355);
            txbtotalPagar.Margin = new Padding(3, 2, 3, 2);
            txbtotalPagar.Name = "txbtotalPagar";
            txbtotalPagar.Size = new Size(124, 23);
            txbtotalPagar.TabIndex = 26;
            txbtotalPagar.TextChanged += txbtotalPagar_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(9, 296);
            label1.Name = "label1";
            label1.Size = new Size(121, 15);
            label1.TabIndex = 39;
            label1.Text = "Cantidad de ventas:  ";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(9, 313);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(124, 23);
            textBox1.TabIndex = 40;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // lblnroFactura
            // 
            lblnroFactura.AutoSize = true;
            lblnroFactura.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblnroFactura.Location = new Point(104, 33);
            lblnroFactura.Name = "lblnroFactura";
            lblnroFactura.Size = new Size(77, 15);
            lblnroFactura.TabIndex = 55;
            lblnroFactura.Text = "ID Vendedor";
            // 
            // btnBuscarVentaporIdCliente
            // 
            btnBuscarVentaporIdCliente.BackColor = Color.Silver;
            btnBuscarVentaporIdCliente.FlatAppearance.BorderColor = Color.Silver;
            btnBuscarVentaporIdCliente.FlatAppearance.CheckedBackColor = Color.Black;
            btnBuscarVentaporIdCliente.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnBuscarVentaporIdCliente.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            btnBuscarVentaporIdCliente.FlatStyle = FlatStyle.Flat;
            btnBuscarVentaporIdCliente.Location = new Point(241, 50);
            btnBuscarVentaporIdCliente.Margin = new Padding(4);
            btnBuscarVentaporIdCliente.Name = "btnBuscarVentaporIdCliente";
            btnBuscarVentaporIdCliente.Size = new Size(54, 25);
            btnBuscarVentaporIdCliente.TabIndex = 54;
            btnBuscarVentaporIdCliente.Text = "Buscar";
            btnBuscarVentaporIdCliente.UseVisualStyleBackColor = false;
            // 
            // tboxIdVendedor
            // 
            tboxIdVendedor.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tboxIdVendedor.Location = new Point(105, 50);
            tboxIdVendedor.Margin = new Padding(3, 2, 3, 2);
            tboxIdVendedor.Name = "tboxIdVendedor";
            tboxIdVendedor.Size = new Size(129, 25);
            tboxIdVendedor.TabIndex = 52;
            // 
            // gbDevVenta
            // 
            gbDevVenta.Controls.Add(textBox1);
            gbDevVenta.Controls.Add(label1);
            gbDevVenta.Controls.Add(lblTotalVendido);
            gbDevVenta.Controls.Add(txbtotalPagar);
            gbDevVenta.Controls.Add(btnEliminarVenta);
            gbDevVenta.Controls.Add(tbTotalPagado);
            gbDevVenta.Controls.Add(dgbDetalle);
            gbDevVenta.Controls.Add(lblDetalle);
            gbDevVenta.Controls.Add(label5);
            gbDevVenta.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            gbDevVenta.Location = new Point(104, 82);
            gbDevVenta.Name = "gbDevVenta";
            gbDevVenta.Size = new Size(761, 386);
            gbDevVenta.TabIndex = 53;
            gbDevVenta.TabStop = false;
            gbDevVenta.Text = "Devolución venta por ID Cliente : ";
            // 
            // btnEliminarVenta
            // 
            btnEliminarVenta.BackColor = Color.DarkGray;
            btnEliminarVenta.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            btnEliminarVenta.FlatAppearance.CheckedBackColor = Color.Black;
            btnEliminarVenta.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnEliminarVenta.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 192);
            btnEliminarVenta.FlatStyle = FlatStyle.Flat;
            btnEliminarVenta.Location = new Point(486, 460);
            btnEliminarVenta.Margin = new Padding(4);
            btnEliminarVenta.Name = "btnEliminarVenta";
            btnEliminarVenta.Size = new Size(89, 26);
            btnEliminarVenta.TabIndex = 35;
            btnEliminarVenta.Text = "Eliminar";
            btnEliminarVenta.UseVisualStyleBackColor = false;
            // 
            // tbTotalPagado
            // 
            tbTotalPagado.Enabled = false;
            tbTotalPagado.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tbTotalPagado.Location = new Point(451, 416);
            tbTotalPagado.Margin = new Padding(3, 2, 3, 2);
            tbTotalPagado.Name = "tbTotalPagado";
            tbTotalPagado.Size = new Size(124, 25);
            tbTotalPagado.TabIndex = 26;
            // 
            // dgbDetalle
            // 
            dgbDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgbDetalle.Columns.AddRange(new DataGridViewColumn[] { IdVenta, fechaOp, idProducto, desProducto, cant, mUnitario, mTotal });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgbDetalle.DefaultCellStyle = dataGridViewCellStyle1;
            dgbDetalle.Enabled = false;
            dgbDetalle.EnableHeadersVisualStyles = false;
            dgbDetalle.Location = new Point(13, 76);
            dgbDetalle.Name = "dgbDetalle";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgbDetalle.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgbDetalle.RowTemplate.Height = 25;
            dgbDetalle.Size = new Size(737, 74);
            dgbDetalle.TabIndex = 39;
            // 
            // IdVenta
            // 
            IdVenta.HeaderText = "ID Venta";
            IdVenta.Name = "IdVenta";
            // 
            // fechaOp
            // 
            fechaOp.HeaderText = "Fecha";
            fechaOp.Name = "fechaOp";
            // 
            // idProducto
            // 
            idProducto.HeaderText = "ID Producto";
            idProducto.Name = "idProducto";
            // 
            // desProducto
            // 
            desProducto.HeaderText = "Descripción";
            desProducto.Name = "desProducto";
            // 
            // cant
            // 
            cant.HeaderText = "Cantidad";
            cant.Name = "cant";
            // 
            // mUnitario
            // 
            mUnitario.HeaderText = "Monto unitario";
            mUnitario.Name = "mUnitario";
            // 
            // mTotal
            // 
            mTotal.HeaderText = "Monto total";
            mTotal.Name = "mTotal";
            // 
            // lblDetalle
            // 
            lblDetalle.AutoSize = true;
            lblDetalle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblDetalle.Location = new Point(12, 58);
            lblDetalle.Name = "lblDetalle";
            lblDetalle.Size = new Size(53, 15);
            lblDetalle.TabIndex = 42;
            lblDetalle.Text = "Detalle: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(13, 19);
            label5.Name = "label5";
            label5.Size = new Size(162, 25);
            label5.TabIndex = 43;
            label5.Text = "ElectroHogar S.A.";
            // 
            // FormReporteVendedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(985, 478);
            Controls.Add(lblnroFactura);
            Controls.Add(btnBuscarVentaporIdCliente);
            Controls.Add(tboxIdVendedor);
            Controls.Add(gbDevVenta);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormReporteVendedor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormReporteVendedor";
            Load += FormReporteVendedor_Load;
            gbDevVenta.ResumeLayout(false);
            gbDevVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgbDetalle).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTotalVendido;
        private TextBox txbtotalPagar;
        private Label label1;
        private TextBox textBox1;
        private Label lblnroFactura;
        private Button btnBuscarVentaporIdCliente;
        private TextBox tboxIdVendedor;
        private GroupBox gbDevVenta;
        private Button btnEliminarVenta;
        private TextBox tbTotalPagado;
        private DataGridView dgbDetalle;
        private Label label5;
        private DataGridViewTextBoxColumn IdVenta;
        private DataGridViewTextBoxColumn fechaOp;
        private DataGridViewTextBoxColumn idProducto;
        private DataGridViewTextBoxColumn desProducto;
        private DataGridViewTextBoxColumn cant;
        private DataGridViewTextBoxColumn mUnitario;
        private DataGridViewTextBoxColumn mTotal;
        private Label lblDetalle;
    }
}