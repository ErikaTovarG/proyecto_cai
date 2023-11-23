namespace FormPresentacion
{
    partial class FormVentaCliente
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            dgvPromo = new DataGridView();
            nomPromocion = new DataGridViewTextBoxColumn();
            monDescuento = new DataGridViewTextBoxColumn();
            txbtotalPagar = new TextBox();
            lblTotalVendido = new Label();
            lblnroFactura = new Label();
            btnBuscarVentaporIdCliente = new Button();
            tboxIdCliente = new TextBox();
            gbDevVenta = new GroupBox();
            lblPromocion = new Label();
            txbFechaComprobante = new TextBox();
            btnEliminarVenta = new Button();
            dgbDatosCliente = new DataGridView();
            idCliente = new DataGridViewTextBoxColumn();
            nomCliente = new DataGridViewTextBoxColumn();
            tbTotalPagado = new TextBox();
            dgbDetalle = new DataGridView();
            idProducto = new DataGridViewTextBoxColumn();
            desProducto = new DataGridViewTextBoxColumn();
            cant = new DataGridViewTextBoxColumn();
            mUnitario = new DataGridViewTextBoxColumn();
            mTotal = new DataGridViewTextBoxColumn();
            label3 = new Label();
            lblDetalle = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPromo).BeginInit();
            gbDevVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgbDatosCliente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgbDetalle).BeginInit();
            SuspendLayout();
            // 
            // dgvPromo
            // 
            dgvPromo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPromo.Columns.AddRange(new DataGridViewColumn[] { nomPromocion, monDescuento });
            dgvPromo.Enabled = false;
            dgvPromo.EnableHeadersVisualStyles = false;
            dgvPromo.Location = new Point(209, 397);
            dgvPromo.Name = "dgvPromo";
            dgvPromo.RowTemplate.Height = 25;
            dgvPromo.Size = new Size(243, 60);
            dgvPromo.TabIndex = 51;
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
            txbtotalPagar.TabIndex = 50;
            // 
            // lblTotalVendido
            // 
            lblTotalVendido.AutoSize = true;
            lblTotalVendido.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalVendido.Location = new Point(643, 409);
            lblTotalVendido.Name = "lblTotalVendido";
            lblTotalVendido.Size = new Size(106, 19);
            lblTotalVendido.TabIndex = 49;
            lblTotalVendido.Text = "Total pagado: ";
            // 
            // lblnroFactura
            // 
            lblnroFactura.AutoSize = true;
            lblnroFactura.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblnroFactura.Location = new Point(160, 20);
            lblnroFactura.Name = "lblnroFactura";
            lblnroFactura.Size = new Size(62, 15);
            lblnroFactura.TabIndex = 48;
            lblnroFactura.Text = "ID Cliente";
            // 
            // btnBuscarVentaporIdCliente
            // 
            btnBuscarVentaporIdCliente.BackColor = Color.Silver;
            btnBuscarVentaporIdCliente.FlatAppearance.BorderColor = Color.Silver;
            btnBuscarVentaporIdCliente.FlatAppearance.CheckedBackColor = Color.Black;
            btnBuscarVentaporIdCliente.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnBuscarVentaporIdCliente.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            btnBuscarVentaporIdCliente.FlatStyle = FlatStyle.Flat;
            btnBuscarVentaporIdCliente.Location = new Point(297, 37);
            btnBuscarVentaporIdCliente.Margin = new Padding(4);
            btnBuscarVentaporIdCliente.Name = "btnBuscarVentaporIdCliente";
            btnBuscarVentaporIdCliente.Size = new Size(54, 25);
            btnBuscarVentaporIdCliente.TabIndex = 47;
            btnBuscarVentaporIdCliente.Text = "Buscar";
            btnBuscarVentaporIdCliente.UseVisualStyleBackColor = false;
            // 
            // tboxIdCliente
            // 
            tboxIdCliente.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tboxIdCliente.Location = new Point(161, 37);
            tboxIdCliente.Margin = new Padding(3, 2, 3, 2);
            tboxIdCliente.Name = "tboxIdCliente";
            tboxIdCliente.Size = new Size(129, 25);
            tboxIdCliente.TabIndex = 45;
            // 
            // gbDevVenta
            // 
            gbDevVenta.Controls.Add(lblPromocion);
            gbDevVenta.Controls.Add(txbFechaComprobante);
            gbDevVenta.Controls.Add(btnEliminarVenta);
            gbDevVenta.Controls.Add(dgbDatosCliente);
            gbDevVenta.Controls.Add(tbTotalPagado);
            gbDevVenta.Controls.Add(dgbDetalle);
            gbDevVenta.Controls.Add(label3);
            gbDevVenta.Controls.Add(lblDetalle);
            gbDevVenta.Controls.Add(label2);
            gbDevVenta.Controls.Add(label1);
            gbDevVenta.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            gbDevVenta.Location = new Point(161, 79);
            gbDevVenta.Name = "gbDevVenta";
            gbDevVenta.Size = new Size(649, 394);
            gbDevVenta.TabIndex = 46;
            gbDevVenta.TabStop = false;
            gbDevVenta.Text = "Devolución venta por ID Cliente : ";
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
            // 
            // dgbDatosCliente
            // 
            dgbDatosCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgbDatosCliente.Columns.AddRange(new DataGridViewColumn[] { idCliente, nomCliente });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgbDatosCliente.DefaultCellStyle = dataGridViewCellStyle5;
            dgbDatosCliente.Enabled = false;
            dgbDatosCliente.EnableHeadersVisualStyles = false;
            dgbDatosCliente.Location = new Point(48, 78);
            dgbDatosCliente.Name = "dgbDatosCliente";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgbDatosCliente.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgbDatosCliente.RowTemplate.Height = 25;
            dgbDatosCliente.Size = new Size(241, 56);
            dgbDatosCliente.TabIndex = 48;
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
            // dgbDetalle
            // 
            dgbDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgbDetalle.Columns.AddRange(new DataGridViewColumn[] { idProducto, desProducto, cant, mUnitario, mTotal });
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Window;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dgbDetalle.DefaultCellStyle = dataGridViewCellStyle7;
            dgbDetalle.Enabled = false;
            dgbDetalle.EnableHeadersVisualStyles = false;
            dgbDetalle.Location = new Point(47, 155);
            dgbDetalle.Name = "dgbDetalle";
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Control;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dgbDetalle.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dgbDetalle.RowTemplate.Height = 25;
            dgbDetalle.Size = new Size(544, 58);
            dgbDetalle.TabIndex = 39;
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
            // FormVentaCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            ClientSize = new Size(985, 478);
            Controls.Add(dgvPromo);
            Controls.Add(txbtotalPagar);
            Controls.Add(lblTotalVendido);
            Controls.Add(lblnroFactura);
            Controls.Add(btnBuscarVentaporIdCliente);
            Controls.Add(tboxIdCliente);
            Controls.Add(gbDevVenta);
            Cursor = Cursors.IBeam;
            Name = "FormVentaCliente";
            Text = "FormVentaCliente";
            ((System.ComponentModel.ISupportInitialize)dgvPromo).EndInit();
            gbDevVenta.ResumeLayout(false);
            gbDevVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgbDatosCliente).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgbDetalle).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPromo;
        private DataGridViewTextBoxColumn nomPromocion;
        private DataGridViewTextBoxColumn monDescuento;
        private TextBox txbtotalPagar;
        private Label lblTotalVendido;
        private Label lblnroFactura;
        private Button btnBuscarVentaporIdCliente;
        private TextBox tboxIdCliente;
        private GroupBox gbDevVenta;
        private Label lblPromocion;
        private TextBox txbFechaComprobante;
        private Button btnEliminarVenta;
        private DataGridView dgbDatosCliente;
        private DataGridViewTextBoxColumn idCliente;
        private DataGridViewTextBoxColumn nomCliente;
        private TextBox tbTotalPagado;
        private DataGridView dgbDetalle;
        private DataGridViewTextBoxColumn idProducto;
        private DataGridViewTextBoxColumn desProducto;
        private DataGridViewTextBoxColumn cant;
        private DataGridViewTextBoxColumn mUnitario;
        private DataGridViewTextBoxColumn mTotal;
        private Label label3;
        private Label lblDetalle;
        private Label label2;
        private Label label1;
    }
}