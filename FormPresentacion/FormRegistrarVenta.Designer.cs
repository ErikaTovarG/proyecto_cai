namespace FormPresentacion
{
    partial class FormRegistrarVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistrarVenta));
            lblPromocion = new Label();
            dataGridView2 = new DataGridView();
            nomPromocion = new DataGridViewTextBoxColumn();
            monDescuento = new DataGridViewTextBoxColumn();
            gbRegistrarVenta = new GroupBox();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            lblFechaOperacion = new Label();
            label1 = new Label();
            lblDetalle = new Label();
            txbtotalPagar = new TextBox();
            btnRegistrar = new Button();
            cmbClientes = new ComboBox();
            lblTotalVendido = new Label();
            dataGridView1 = new DataGridView();
            idProducto = new DataGridViewTextBoxColumn();
            desProducto = new DataGridViewTextBoxColumn();
            cant = new DataGridViewTextBoxColumn();
            mUnitario = new DataGridViewTextBoxColumn();
            mTotal = new DataGridViewTextBoxColumn();
            btnLimpiar = new Button();
            groupBox1 = new GroupBox();
            btnAgregar = new Button();
            txtNombrePromocion = new TextBox();
            lblNombrePromo = new Label();
            lblPrecioUnitario = new Label();
            lblCantidad = new Label();
            cmbProducto = new ComboBox();
            cmbCantidad = new ComboBox();
            cmbCategoria = new ComboBox();
            lblProducto = new Label();
            txtMonPromocion = new TextBox();
            label16 = new Label();
            txbMonTot = new TextBox();
            label14 = new Label();
            txbMonUni = new TextBox();
            lblCategoria = new Label();
            label7 = new Label();
            label4 = new Label();
            label13 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            gbRegistrarVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblPromocion
            // 
            lblPromocion.AutoSize = true;
            lblPromocion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPromocion.Location = new Point(15, 482);
            lblPromocion.Name = "lblPromocion";
            lblPromocion.Size = new Size(89, 20);
            lblPromocion.TabIndex = 30;
            lblPromocion.Text = "Promocion:";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { nomPromocion, monDescuento });
            dataGridView2.Enabled = false;
            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.Location = new Point(15, 506);
            dataGridView2.Margin = new Padding(3, 4, 3, 4);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(309, 87);
            dataGridView2.TabIndex = 29;
            // 
            // nomPromocion
            // 
            nomPromocion.HeaderText = "Nombre promoción";
            nomPromocion.MinimumWidth = 6;
            nomPromocion.Name = "nomPromocion";
            nomPromocion.Width = 125;
            // 
            // monDescuento
            // 
            monDescuento.HeaderText = "Monto descuento";
            monDescuento.MinimumWidth = 6;
            monDescuento.Name = "monDescuento";
            monDescuento.Width = 125;
            // 
            // gbRegistrarVenta
            // 
            gbRegistrarVenta.Controls.Add(dateTimePicker1);
            gbRegistrarVenta.Controls.Add(lblPromocion);
            gbRegistrarVenta.Controls.Add(dataGridView2);
            gbRegistrarVenta.Controls.Add(label3);
            gbRegistrarVenta.Controls.Add(lblFechaOperacion);
            gbRegistrarVenta.Controls.Add(label1);
            gbRegistrarVenta.Controls.Add(lblDetalle);
            gbRegistrarVenta.Controls.Add(txbtotalPagar);
            gbRegistrarVenta.Controls.Add(btnRegistrar);
            gbRegistrarVenta.Controls.Add(cmbClientes);
            gbRegistrarVenta.Controls.Add(lblTotalVendido);
            gbRegistrarVenta.Controls.Add(dataGridView1);
            gbRegistrarVenta.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            gbRegistrarVenta.Location = new Point(344, 17);
            gbRegistrarVenta.Margin = new Padding(3, 4, 3, 4);
            gbRegistrarVenta.Name = "gbRegistrarVenta";
            gbRegistrarVenta.Padding = new Padding(3, 4, 3, 4);
            gbRegistrarVenta.Size = new Size(770, 601);
            gbRegistrarVenta.TabIndex = 31;
            gbRegistrarVenta.TabStop = false;
            gbRegistrarVenta.Text = " Comprobante:   ";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(151, 64);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(102, 27);
            dateTimePicker1.TabIndex = 32;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(15, 98);
            label3.Name = "label3";
            label3.Size = new Size(133, 20);
            label3.TabIndex = 30;
            label3.Text = "Datos del cliente: ";
            // 
            // lblFechaOperacion
            // 
            lblFechaOperacion.AutoSize = true;
            lblFechaOperacion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblFechaOperacion.Location = new Point(15, 68);
            lblFechaOperacion.Name = "lblFechaOperacion";
            lblFechaOperacion.Size = new Size(130, 20);
            lblFechaOperacion.TabIndex = 29;
            lblFechaOperacion.Text = "Fecha operacion: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(15, 31);
            label1.Name = "label1";
            label1.Size = new Size(195, 30);
            label1.TabIndex = 28;
            label1.Text = "ElectroHogar S.A.";
            // 
            // lblDetalle
            // 
            lblDetalle.AutoSize = true;
            lblDetalle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblDetalle.Location = new Point(19, 157);
            lblDetalle.Name = "lblDetalle";
            lblDetalle.Size = new Size(66, 20);
            lblDetalle.TabIndex = 27;
            lblDetalle.Text = "Detalle: ";
            // 
            // txbtotalPagar
            // 
            txbtotalPagar.Enabled = false;
            txbtotalPagar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txbtotalPagar.Location = new Point(520, 506);
            txbtotalPagar.Name = "txbtotalPagar";
            txbtotalPagar.Size = new Size(200, 30);
            txbtotalPagar.TabIndex = 26;
            txbtotalPagar.TextChanged += txbtotalPagar_TextChanged;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.DarkGray;
            btnRegistrar.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            btnRegistrar.FlatAppearance.CheckedBackColor = Color.Black;
            btnRegistrar.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnRegistrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 192);
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Location = new Point(569, 551);
            btnRegistrar.Margin = new Padding(5);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(150, 41);
            btnRegistrar.TabIndex = 32;
            btnRegistrar.Text = "Registrar Venta";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // cmbClientes
            // 
            cmbClientes.FormattingEnabled = true;
            cmbClientes.Location = new Point(19, 122);
            cmbClientes.Margin = new Padding(3, 4, 3, 4);
            cmbClientes.Name = "cmbClientes";
            cmbClientes.Size = new Size(412, 28);
            cmbClientes.TabIndex = 64;
            cmbClientes.Text = "Nombre";
            // 
            // lblTotalVendido
            // 
            lblTotalVendido.AutoSize = true;
            lblTotalVendido.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalVendido.Location = new Point(388, 509);
            lblTotalVendido.Name = "lblTotalVendido";
            lblTotalVendido.Size = new Size(126, 23);
            lblTotalVendido.TabIndex = 25;
            lblTotalVendido.Text = "Total a pagar: ";
            lblTotalVendido.Click += lblTotalVendido_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idProducto, desProducto, cant, mUnitario, mTotal });
            dataGridView1.Enabled = false;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(20, 187);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(700, 278);
            dataGridView1.TabIndex = 23;
            // 
            // idProducto
            // 
            idProducto.HeaderText = "ID Producto";
            idProducto.MinimumWidth = 6;
            idProducto.Name = "idProducto";
            idProducto.Width = 125;
            // 
            // desProducto
            // 
            desProducto.HeaderText = "Descripción";
            desProducto.MinimumWidth = 6;
            desProducto.Name = "desProducto";
            desProducto.Width = 125;
            // 
            // cant
            // 
            cant.HeaderText = "Cantidad";
            cant.MinimumWidth = 6;
            cant.Name = "cant";
            cant.Width = 125;
            // 
            // mUnitario
            // 
            mUnitario.HeaderText = "Monto unitario";
            mUnitario.MinimumWidth = 6;
            mUnitario.Name = "mUnitario";
            mUnitario.Width = 125;
            // 
            // mTotal
            // 
            mTotal.HeaderText = "Monto total";
            mTotal.MinimumWidth = 6;
            mTotal.Name = "mTotal";
            mTotal.Width = 125;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.DarkGray;
            btnLimpiar.FlatAppearance.BorderColor = Color.FromArgb(192, 192, 255);
            btnLimpiar.FlatAppearance.CheckedBackColor = Color.Black;
            btnLimpiar.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnLimpiar.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Location = new Point(33, 509);
            btnLimpiar.Margin = new Padding(5);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(105, 41);
            btnLimpiar.TabIndex = 33;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Controls.Add(txtNombrePromocion);
            groupBox1.Controls.Add(lblNombrePromo);
            groupBox1.Controls.Add(lblPrecioUnitario);
            groupBox1.Controls.Add(lblCantidad);
            groupBox1.Controls.Add(cmbProducto);
            groupBox1.Controls.Add(cmbCantidad);
            groupBox1.Controls.Add(cmbCategoria);
            groupBox1.Controls.Add(lblProducto);
            groupBox1.Controls.Add(btnLimpiar);
            groupBox1.Controls.Add(txtMonPromocion);
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(txbMonTot);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(txbMonUni);
            groupBox1.Controls.Add(lblCategoria);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(26, 17);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(295, 564);
            groupBox1.TabIndex = 34;
            groupBox1.TabStop = false;
            groupBox1.Text = " Datos de Venta: ";
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.DarkGray;
            btnAgregar.FlatAppearance.BorderColor = Color.FromArgb(192, 192, 255);
            btnAgregar.FlatAppearance.CheckedBackColor = Color.Black;
            btnAgregar.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnAgregar.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Location = new Point(150, 509);
            btnAgregar.Margin = new Padding(5);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(102, 41);
            btnAgregar.TabIndex = 74;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtNombrePromocion
            // 
            txtNombrePromocion.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombrePromocion.Location = new Point(41, 348);
            txtNombrePromocion.Name = "txtNombrePromocion";
            txtNombrePromocion.Size = new Size(212, 30);
            txtNombrePromocion.TabIndex = 73;
            // 
            // lblNombrePromo
            // 
            lblNombrePromo.AutoSize = true;
            lblNombrePromo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombrePromo.Location = new Point(41, 325);
            lblNombrePromo.Name = "lblNombrePromo";
            lblNombrePromo.Size = new Size(151, 20);
            lblNombrePromo.TabIndex = 72;
            lblNombrePromo.Text = "Nombre promocion:";
            // 
            // lblPrecioUnitario
            // 
            lblPrecioUnitario.AutoSize = true;
            lblPrecioUnitario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrecioUnitario.Location = new Point(43, 213);
            lblPrecioUnitario.Name = "lblPrecioUnitario";
            lblPrecioUnitario.Size = new Size(117, 20);
            lblPrecioUnitario.TabIndex = 71;
            lblPrecioUnitario.Text = "Precio Unitario:";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCantidad.Location = new Point(43, 157);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(75, 20);
            lblCantidad.TabIndex = 70;
            lblCantidad.Text = "Cantidad:";
            // 
            // cmbProducto
            // 
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Location = new Point(41, 123);
            cmbProducto.Margin = new Padding(3, 4, 3, 4);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(211, 28);
            cmbProducto.TabIndex = 69;
            cmbProducto.Text = "<Seleccionar>";
            // 
            // cmbCantidad
            // 
            cmbCantidad.FormattingEnabled = true;
            cmbCantidad.Location = new Point(43, 181);
            cmbCantidad.Margin = new Padding(3, 4, 3, 4);
            cmbCantidad.Name = "cmbCantidad";
            cmbCantidad.Size = new Size(211, 28);
            cmbCantidad.TabIndex = 68;
            cmbCantidad.Text = "<Seleccionar>";
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(41, 65);
            cmbCategoria.Margin = new Padding(3, 4, 3, 4);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(211, 28);
            cmbCategoria.TabIndex = 67;
            cmbCategoria.Text = "<Seleccionar>";
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblProducto.Location = new Point(42, 99);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(77, 20);
            lblProducto.TabIndex = 65;
            lblProducto.Text = "Producto:";
            // 
            // txtMonPromocion
            // 
            txtMonPromocion.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtMonPromocion.Location = new Point(43, 403);
            txtMonPromocion.Name = "txtMonPromocion";
            txtMonPromocion.Size = new Size(212, 30);
            txtMonPromocion.TabIndex = 59;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(43, 380);
            label16.Name = "label16";
            label16.Size = new Size(144, 20);
            label16.TabIndex = 58;
            label16.Text = "Monto promoción: ";
            // 
            // txbMonTot
            // 
            txbMonTot.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txbMonTot.Location = new Point(43, 292);
            txbMonTot.Name = "txbMonTot";
            txbMonTot.Size = new Size(212, 30);
            txbMonTot.TabIndex = 55;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(43, 269);
            label14.Name = "label14";
            label14.Size = new Size(97, 20);
            label14.TabIndex = 54;
            label14.Text = "Monto total:";
            // 
            // txbMonUni
            // 
            txbMonUni.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txbMonUni.Location = new Point(42, 236);
            txbMonUni.Name = "txbMonUni";
            txbMonUni.Size = new Size(212, 30);
            txbMonUni.TabIndex = 53;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCategoria.Location = new Point(42, 41);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(80, 20);
            lblCategoria.TabIndex = 46;
            lblCategoria.Text = "Categoria:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(42, 31);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 38;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 73);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 0;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(42, 249);
            label13.Name = "label13";
            label13.Size = new Size(119, 20);
            label13.TabIndex = 52;
            label13.Text = "Monto unitario:";
            // 
            // FormRegistrarVenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1126, 637);
            Controls.Add(groupBox1);
            Controls.Add(gbRegistrarVenta);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormRegistrarVenta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormRegistrarVenta";
            Load += FormRegistrarVenta_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            gbRegistrarVenta.ResumeLayout(false);
            gbRegistrarVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblPromocion;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn nomPromocion;
        private DataGridViewTextBoxColumn monDescuento;
        private GroupBox gbRegistrarVenta;
        private Label lblDetalle;
        private TextBox txbtotalPagar;
        private Label lblTotalVendido;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idProducto;
        private DataGridViewTextBoxColumn desProducto;
        private DataGridViewTextBoxColumn cant;
        private DataGridViewTextBoxColumn mUnitario;
        private DataGridViewTextBoxColumn mTotal;
        private Button btnRegistrar;
        private Button btnLimpiar;
        private Label label3;
        private Label lblFechaOperacion;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtMonPromocion;
        private Label label16;
        private TextBox txbMonTot;
        private Label label14;
        private TextBox txbMonUni;
        private Label label13;
        private TextBox txbCant;
        private Label label12;
        private TextBox txbIdProd;
        private Label lblCategoria;
        private Label label7;
        private Label label4;
        private ComboBox cmbClientes;
        private TextBox tbxDescripcion;
        private Label lblProducto;
        private ComboBox cmbCategoria;
        private ComboBox cmbProducto;
        private ComboBox cmbCantidad;
        private Label lblCantidad;
        private DateTimePicker dateTimePicker1;
        private Label lblPrecioUnitario;
        private TextBox txtNombrePromocion;
        private Label lblNombrePromo;
        private Button btnAgregar;
    }
}