namespace FormPresentacion
{
    partial class FormVenta
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVenta));
            gbDevVenta = new GroupBox();
            lblPromocion = new Label();
            txbFechaComprobante = new TextBox();
            btnEliminarVenta = new Button();
            dataGridView3 = new DataGridView();
            idCliente = new DataGridViewTextBoxColumn();
            nomCliente = new DataGridViewTextBoxColumn();
            tbTotalPagado = new TextBox();
            dataGridView1 = new DataGridView();
            idProducto = new DataGridViewTextBoxColumn();
            desProducto = new DataGridViewTextBoxColumn();
            cant = new DataGridViewTextBoxColumn();
            mUnitario = new DataGridViewTextBoxColumn();
            mTotal = new DataGridViewTextBoxColumn();
            label3 = new Label();
            lblDetalle = new Label();
            label2 = new Label();
            label1 = new Label();
            tboxIdVenta = new TextBox();
            btnBuscarVentaporIdVenta = new Button();
            lblnroFactura = new Label();
            dataGridView2 = new DataGridView();
            nomPromocion = new DataGridViewTextBoxColumn();
            monDescuento = new DataGridViewTextBoxColumn();
            txbtotalPagar = new TextBox();
            lblTotalVendido = new Label();
            gbDevVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // gbDevVenta
            // 
            gbDevVenta.Controls.Add(lblPromocion);
            gbDevVenta.Controls.Add(txbFechaComprobante);
            gbDevVenta.Controls.Add(btnEliminarVenta);
            gbDevVenta.Controls.Add(dataGridView3);
            gbDevVenta.Controls.Add(tbTotalPagado);
            gbDevVenta.Controls.Add(dataGridView1);
            gbDevVenta.Controls.Add(label3);
            gbDevVenta.Controls.Add(lblDetalle);
            gbDevVenta.Controls.Add(label2);
            gbDevVenta.Controls.Add(label1);
            gbDevVenta.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            gbDevVenta.Location = new Point(161, 79);
            gbDevVenta.Name = "gbDevVenta";
            gbDevVenta.Size = new Size(649, 394);
            gbDevVenta.TabIndex = 34;
            gbDevVenta.TabStop = false;
            gbDevVenta.Text = "Devolución venta por ID : ";
            gbDevVenta.Enter += gbDevVenta_Enter;
            // 
            // lblPromocion
            // 
            lblPromocion.AutoSize = true;
            lblPromocion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPromocion.Location = new Point(48, 300);
            lblPromocion.Name = "lblPromocion";
            lblPromocion.Size = new Size(70, 15);
            lblPromocion.TabIndex = 46;
            lblPromocion.Text = "Promocion:";
            // 
            // txbFechaComprobante
            // 
            txbFechaComprobante.Enabled = false;
            txbFechaComprobante.Location = new Point(501, 42);
            txbFechaComprobante.Name = "txbFechaComprobante";
            txbFechaComprobante.Size = new Size(112, 23);
            txbFechaComprobante.TabIndex = 49;
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
            btnEliminarVenta.Click += btnRegistrar_Click;
            // 
            // dataGridView3
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { idCliente, nomCliente });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView3.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView3.Enabled = false;
            dataGridView3.EnableHeadersVisualStyles = false;
            dataGridView3.Location = new Point(48, 78);
            dataGridView3.Name = "dataGridView3";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView3.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView3.RowTemplate.Height = 25;
            dataGridView3.Size = new Size(241, 56);
            dataGridView3.TabIndex = 48;
            // 
            // idCliente
            // 
            idCliente.HeaderText = "ID Cliente";
            idCliente.Name = "idCliente";
            // 
            // nomCliente
            // 
            nomCliente.HeaderText = "Nombre";
            nomCliente.Name = "nomCliente";
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
            // dataGridView1
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idProducto, desProducto, cant, mUnitario, mTotal });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.Enabled = false;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(47, 155);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(544, 58);
            dataGridView1.TabIndex = 39;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(48, 59);
            label3.Name = "label3";
            label3.Size = new Size(106, 15);
            label3.TabIndex = 47;
            label3.Text = "Datos del cliente: ";
            // 
            // lblDetalle
            // 
            lblDetalle.AutoSize = true;
            lblDetalle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblDetalle.Location = new Point(48, 137);
            lblDetalle.Name = "lblDetalle";
            lblDetalle.Size = new Size(53, 15);
            lblDetalle.TabIndex = 42;
            lblDetalle.Text = "Detalle: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(501, 25);
            label2.Name = "label2";
            label2.Size = new Size(103, 15);
            label2.TabIndex = 45;
            label2.Text = "Fecha operacion: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(48, 19);
            label1.Name = "label1";
            label1.Size = new Size(162, 25);
            label1.TabIndex = 43;
            label1.Text = "ElectroHogar S.A.";
            // 
            // tboxIdVenta
            // 
            tboxIdVenta.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tboxIdVenta.Location = new Point(161, 37);
            tboxIdVenta.Margin = new Padding(3, 2, 3, 2);
            tboxIdVenta.Name = "tboxIdVenta";
            tboxIdVenta.Size = new Size(129, 25);
            tboxIdVenta.TabIndex = 33;
            tboxIdVenta.TextChanged += tboxIdVenta_TextChanged;
            // 
            // btnBuscarVentaporIdVenta
            // 
            btnBuscarVentaporIdVenta.BackColor = Color.Silver;
            btnBuscarVentaporIdVenta.FlatAppearance.BorderColor = Color.Silver;
            btnBuscarVentaporIdVenta.FlatAppearance.CheckedBackColor = Color.Black;
            btnBuscarVentaporIdVenta.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnBuscarVentaporIdVenta.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            btnBuscarVentaporIdVenta.FlatStyle = FlatStyle.Flat;
            btnBuscarVentaporIdVenta.Location = new Point(297, 37);
            btnBuscarVentaporIdVenta.Margin = new Padding(4);
            btnBuscarVentaporIdVenta.Name = "btnBuscarVentaporIdVenta";
            btnBuscarVentaporIdVenta.Size = new Size(54, 25);
            btnBuscarVentaporIdVenta.TabIndex = 37;
            btnBuscarVentaporIdVenta.Text = "Buscar";
            btnBuscarVentaporIdVenta.UseVisualStyleBackColor = false;
            // 
            // lblnroFactura
            // 
            lblnroFactura.AutoSize = true;
            lblnroFactura.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblnroFactura.Location = new Point(160, 20);
            lblnroFactura.Name = "lblnroFactura";
            lblnroFactura.Size = new Size(55, 15);
            lblnroFactura.TabIndex = 38;
            lblnroFactura.Text = "ID Venta";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { nomPromocion, monDescuento });
            dataGridView2.Enabled = false;
            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.Location = new Point(209, 397);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(243, 60);
            dataGridView2.TabIndex = 44;
            // 
            // nomPromocion
            // 
            nomPromocion.HeaderText = "Nombre promoción";
            nomPromocion.Name = "nomPromocion";
            // 
            // monDescuento
            // 
            monDescuento.HeaderText = "Monto descuento";
            monDescuento.Name = "monDescuento";
            // 
            // txbtotalPagar
            // 
            txbtotalPagar.Enabled = false;
            txbtotalPagar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txbtotalPagar.Location = new Point(643, 432);
            txbtotalPagar.Margin = new Padding(3, 2, 3, 2);
            txbtotalPagar.Name = "txbtotalPagar";
            txbtotalPagar.Size = new Size(124, 25);
            txbtotalPagar.TabIndex = 41;
            // 
            // lblTotalVendido
            // 
            lblTotalVendido.AutoSize = true;
            lblTotalVendido.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalVendido.Location = new Point(643, 409);
            lblTotalVendido.Name = "lblTotalVendido";
            lblTotalVendido.Size = new Size(106, 19);
            lblTotalVendido.TabIndex = 40;
            lblTotalVendido.Text = "Total pagado: ";
            // 
            // FormVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(985, 478);
            Controls.Add(dataGridView2);
            Controls.Add(txbtotalPagar);
            Controls.Add(lblTotalVendido);
            Controls.Add(lblnroFactura);
            Controls.Add(btnBuscarVentaporIdVenta);
            Controls.Add(tboxIdVenta);
            Controls.Add(gbDevVenta);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormVenta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormVenta";
            Load += FormVenta_Load;
            gbDevVenta.ResumeLayout(false);
            gbDevVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbDevVenta;
        private TextBox tboxIdVenta;
        private TextBox tbTotalPagado;
        private Button btnEliminarVenta;
        private Button btnBuscarVentaporIdVenta;
        private Label lblnroFactura;
        private TextBox txbFechaComprobante;
        private DataGridView dataGridView3;
        private DataGridViewTextBoxColumn idCliente;
        private DataGridViewTextBoxColumn nomCliente;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idProducto;
        private DataGridViewTextBoxColumn desProducto;
        private DataGridViewTextBoxColumn cant;
        private DataGridViewTextBoxColumn mUnitario;
        private DataGridViewTextBoxColumn mTotal;
        private Label label3;
        private Label lblDetalle;
        private Label label2;
        private Label label1;
        private Label lblPromocion;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn nomPromocion;
        private DataGridViewTextBoxColumn monDescuento;
        private TextBox txbtotalPagar;
        private Label lblTotalVendido;
    }
}