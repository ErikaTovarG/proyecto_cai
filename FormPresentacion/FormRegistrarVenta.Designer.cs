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
            txbFechaComprobante = new TextBox();
            dataGridView3 = new DataGridView();
            idCliente = new DataGridViewTextBoxColumn();
            nomCliente = new DataGridViewTextBoxColumn();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lblDetalle = new Label();
            txbtotalPagar = new TextBox();
            lblTotalVendido = new Label();
            dataGridView1 = new DataGridView();
            idProducto = new DataGridViewTextBoxColumn();
            desProducto = new DataGridViewTextBoxColumn();
            cant = new DataGridViewTextBoxColumn();
            mUnitario = new DataGridViewTextBoxColumn();
            mTotal = new DataGridViewTextBoxColumn();
            btnRegistrar = new Button();
            btnLimpiar = new Button();
            groupBox1 = new GroupBox();
            cmbClientes = new ComboBox();
            txtTotalDatos = new TextBox();
            label18 = new Label();
            txtMonPromocion = new TextBox();
            label16 = new Label();
            txtNomPromocion = new TextBox();
            label15 = new Label();
            txbMonTot = new TextBox();
            label14 = new Label();
            txbMonUni = new TextBox();
            label13 = new Label();
            txbCant = new TextBox();
            label12 = new Label();
            txbIdProd = new TextBox();
            lblIDproducto = new Label();
            label7 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            gbRegistrarVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblPromocion
            // 
            lblPromocion.AutoSize = true;
            lblPromocion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPromocion.Location = new Point(37, 347);
            lblPromocion.Name = "lblPromocion";
            lblPromocion.Size = new Size(70, 15);
            lblPromocion.TabIndex = 30;
            lblPromocion.Text = "Promocion:";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { nomPromocion, monDescuento });
            dataGridView2.Enabled = false;
            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.Location = new Point(37, 369);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(243, 60);
            dataGridView2.TabIndex = 29;
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
            // gbRegistrarVenta
            // 
            gbRegistrarVenta.Controls.Add(txbFechaComprobante);
            gbRegistrarVenta.Controls.Add(dataGridView3);
            gbRegistrarVenta.Controls.Add(lblPromocion);
            gbRegistrarVenta.Controls.Add(dataGridView2);
            gbRegistrarVenta.Controls.Add(label3);
            gbRegistrarVenta.Controls.Add(label2);
            gbRegistrarVenta.Controls.Add(label1);
            gbRegistrarVenta.Controls.Add(lblDetalle);
            gbRegistrarVenta.Controls.Add(txbtotalPagar);
            gbRegistrarVenta.Controls.Add(lblTotalVendido);
            gbRegistrarVenta.Controls.Add(dataGridView1);
            gbRegistrarVenta.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            gbRegistrarVenta.Location = new Point(301, 15);
            gbRegistrarVenta.Name = "gbRegistrarVenta";
            gbRegistrarVenta.Size = new Size(623, 447);
            gbRegistrarVenta.TabIndex = 31;
            gbRegistrarVenta.TabStop = false;
            gbRegistrarVenta.Text = " Comprobante:   ";
            // 
            // txbFechaComprobante
            // 
            txbFechaComprobante.Enabled = false;
            txbFechaComprobante.Location = new Point(492, 46);
            txbFechaComprobante.Name = "txbFechaComprobante";
            txbFechaComprobante.Size = new Size(112, 23);
            txbFechaComprobante.TabIndex = 35;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { idCliente, nomCliente });
            dataGridView3.Enabled = false;
            dataGridView3.EnableHeadersVisualStyles = false;
            dataGridView3.Location = new Point(39, 82);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowTemplate.Height = 25;
            dataGridView3.Size = new Size(241, 56);
            dataGridView3.TabIndex = 31;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(37, 60);
            label3.Name = "label3";
            label3.Size = new Size(106, 15);
            label3.TabIndex = 30;
            label3.Text = "Datos del cliente: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(492, 29);
            label2.Name = "label2";
            label2.Size = new Size(103, 15);
            label2.TabIndex = 29;
            label2.Text = "Fecha operacion: ";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(37, 23);
            label1.Name = "label1";
            label1.Size = new Size(162, 25);
            label1.TabIndex = 28;
            label1.Text = "ElectroHogar S.A.";
            label1.Click += label1_Click;
            // 
            // lblDetalle
            // 
            lblDetalle.AutoSize = true;
            lblDetalle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblDetalle.Location = new Point(37, 151);
            lblDetalle.Name = "lblDetalle";
            lblDetalle.Size = new Size(53, 15);
            lblDetalle.TabIndex = 27;
            lblDetalle.Text = "Detalle: ";
            // 
            // txbtotalPagar
            // 
            txbtotalPagar.Enabled = false;
            txbtotalPagar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txbtotalPagar.Location = new Point(471, 404);
            txbtotalPagar.Margin = new Padding(3, 2, 3, 2);
            txbtotalPagar.Name = "txbtotalPagar";
            txbtotalPagar.Size = new Size(124, 25);
            txbtotalPagar.TabIndex = 26;
            txbtotalPagar.TextChanged += txbtotalPagar_TextChanged;
            // 
            // lblTotalVendido
            // 
            lblTotalVendido.AutoSize = true;
            lblTotalVendido.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalVendido.Location = new Point(471, 381);
            lblTotalVendido.Name = "lblTotalVendido";
            lblTotalVendido.Size = new Size(107, 19);
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
            dataGridView1.Location = new Point(38, 173);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(544, 62);
            dataGridView1.TabIndex = 23;
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
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.DarkGray;
            btnRegistrar.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            btnRegistrar.FlatAppearance.CheckedBackColor = Color.Black;
            btnRegistrar.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnRegistrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 192);
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Location = new Point(115, 403);
            btnRegistrar.Margin = new Padding(4);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(81, 30);
            btnRegistrar.TabIndex = 32;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.DarkGray;
            btnLimpiar.FlatAppearance.BorderColor = Color.FromArgb(192, 192, 255);
            btnLimpiar.FlatAppearance.CheckedBackColor = Color.Black;
            btnLimpiar.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnLimpiar.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Location = new Point(15, 403);
            btnLimpiar.Margin = new Padding(4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(81, 30);
            btnLimpiar.TabIndex = 33;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbClientes);
            groupBox1.Controls.Add(btnRegistrar);
            groupBox1.Controls.Add(btnLimpiar);
            groupBox1.Controls.Add(txtTotalDatos);
            groupBox1.Controls.Add(label18);
            groupBox1.Controls.Add(txtMonPromocion);
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(txtNomPromocion);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(txbMonTot);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(txbMonUni);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(txbCant);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(txbIdProd);
            groupBox1.Controls.Add(lblIDproducto);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(61, 15);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(220, 447);
            groupBox1.TabIndex = 34;
            groupBox1.TabStop = false;
            groupBox1.Text = " Datos de Venta: ";
            // 
            // cmbClientes
            // 
            cmbClientes.FormattingEnabled = true;
            cmbClientes.Location = new Point(32, 48);
            cmbClientes.Name = "cmbClientes";
            cmbClientes.Size = new Size(148, 23);
            cmbClientes.TabIndex = 64;
            cmbClientes.Text = "Nombre";
            // 
            // txtTotalDatos
            // 
            txtTotalDatos.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtTotalDatos.Location = new Point(31, 367);
            txtTotalDatos.Margin = new Padding(3, 2, 3, 2);
            txtTotalDatos.Name = "txtTotalDatos";
            txtTotalDatos.Size = new Size(119, 25);
            txtTotalDatos.TabIndex = 63;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label18.Location = new Point(29, 345);
            label18.Name = "label18";
            label18.Size = new Size(103, 19);
            label18.TabIndex = 62;
            label18.Text = "Total a pagar:";
            // 
            // txtMonPromocion
            // 
            txtMonPromocion.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtMonPromocion.Location = new Point(32, 310);
            txtMonPromocion.Margin = new Padding(3, 2, 3, 2);
            txtMonPromocion.Name = "txtMonPromocion";
            txtMonPromocion.Size = new Size(149, 25);
            txtMonPromocion.TabIndex = 59;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(32, 293);
            label16.Name = "label16";
            label16.Size = new Size(113, 15);
            label16.TabIndex = 58;
            label16.Text = "Monto promoción: ";
            // 
            // txtNomPromocion
            // 
            txtNomPromocion.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtNomPromocion.Location = new Point(32, 266);
            txtNomPromocion.Margin = new Padding(3, 2, 3, 2);
            txtNomPromocion.Name = "txtNomPromocion";
            txtNomPromocion.Size = new Size(149, 25);
            txtNomPromocion.TabIndex = 57;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(32, 249);
            label15.Name = "label15";
            label15.Size = new Size(119, 15);
            label15.TabIndex = 56;
            label15.Text = "Nombre promoción:";
            // 
            // txbMonTot
            // 
            txbMonTot.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txbMonTot.Location = new Point(32, 222);
            txbMonTot.Margin = new Padding(3, 2, 3, 2);
            txbMonTot.Name = "txbMonTot";
            txbMonTot.Size = new Size(149, 25);
            txbMonTot.TabIndex = 55;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(32, 205);
            label14.Name = "label14";
            label14.Size = new Size(76, 15);
            label14.TabIndex = 54;
            label14.Text = "Monto total:";
            // 
            // txbMonUni
            // 
            txbMonUni.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txbMonUni.Location = new Point(32, 178);
            txbMonUni.Margin = new Padding(3, 2, 3, 2);
            txbMonUni.Name = "txbMonUni";
            txbMonUni.Size = new Size(149, 25);
            txbMonUni.TabIndex = 53;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(32, 161);
            label13.Name = "label13";
            label13.Size = new Size(93, 15);
            label13.TabIndex = 52;
            label13.Text = "Monto unitario:";
            // 
            // txbCant
            // 
            txbCant.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txbCant.Location = new Point(31, 134);
            txbCant.Margin = new Padding(3, 2, 3, 2);
            txbCant.Name = "txbCant";
            txbCant.Size = new Size(149, 25);
            txbCant.TabIndex = 51;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(31, 117);
            label12.Name = "label12";
            label12.Size = new Size(58, 15);
            label12.TabIndex = 50;
            label12.Text = "Cantidad:";
            // 
            // txbIdProd
            // 
            txbIdProd.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txbIdProd.Location = new Point(32, 90);
            txbIdProd.Margin = new Padding(3, 2, 3, 2);
            txbIdProd.Name = "txbIdProd";
            txbIdProd.Size = new Size(149, 25);
            txbIdProd.TabIndex = 47;
            // 
            // lblIDproducto
            // 
            lblIDproducto.AutoSize = true;
            lblIDproducto.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblIDproducto.Location = new Point(32, 73);
            lblIDproducto.Name = "lblIDproducto";
            lblIDproducto.Size = new Size(80, 15);
            lblIDproducto.TabIndex = 46;
            lblIDproducto.Text = "ID Producto: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(32, 31);
            label7.Name = "label7";
            label7.Size = new Size(52, 15);
            label7.TabIndex = 38;
            label7.Text = "Cliente: ";
            label7.Click += label7_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 47);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 0;
            // 
            // FormRegistrarVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(985, 478);
            Controls.Add(groupBox1);
            Controls.Add(gbRegistrarVenta);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormRegistrarVenta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormRegistrarVenta";
            Load += FormRegistrarVenta_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            gbRegistrarVenta.ResumeLayout(false);
            gbRegistrarVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
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
        private DataGridView dataGridView3;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtTotalDatos;
        private Label label18;
        private TextBox txtMonPromocion;
        private Label label16;
        private TextBox txtNomPromocion;
        private Label label15;
        private TextBox txbMonTot;
        private Label label14;
        private TextBox txbMonUni;
        private Label label13;
        private TextBox txbCant;
        private Label label12;
        private TextBox txbIdProd;
        private Label lblIDproducto;
        private Label label7;
        private Label label4;
        private TextBox txbFechaComprobante;
        private ComboBox cmbClientes;
        private DataGridViewTextBoxColumn idCliente;
        private DataGridViewTextBoxColumn nomCliente;
    }
}