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
            textBox3 = new TextBox();
            lblnroFactura = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            dataGridView3 = new DataGridView();
            idCliente = new DataGridViewTextBoxColumn();
            DNI = new DataGridViewTextBoxColumn();
            nomCliente = new DataGridViewTextBoxColumn();
            direCliente = new DataGridViewTextBoxColumn();
            Contacto = new DataGridViewTextBoxColumn();
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
            txbDNI = new TextBox();
            label10 = new Label();
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
            txbDesc = new TextBox();
            label11 = new Label();
            txbIdProd = new TextBox();
            lblIDproducto = new Label();
            txtContacto = new TextBox();
            lblContacto = new Label();
            txtDireccion = new TextBox();
            label9 = new Label();
            tbxNombreCompleto = new TextBox();
            label8 = new Label();
            tbxIDcliente = new TextBox();
            label7 = new Label();
            tbxFecha = new TextBox();
            label6 = new Label();
            txbEmpresa = new TextBox();
            label5 = new Label();
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
            lblPromocion.Location = new Point(33, 401);
            lblPromocion.Name = "lblPromocion";
            lblPromocion.Size = new Size(70, 15);
            lblPromocion.TabIndex = 30;
            lblPromocion.Text = "Promocion:";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { nomPromocion, monDescuento });
            dataGridView2.Location = new Point(33, 423);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(229, 75);
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
            gbRegistrarVenta.Controls.Add(textBox3);
            gbRegistrarVenta.Controls.Add(lblnroFactura);
            gbRegistrarVenta.Controls.Add(textBox2);
            gbRegistrarVenta.Controls.Add(textBox1);
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
            gbRegistrarVenta.Location = new Point(387, 16);
            gbRegistrarVenta.Name = "gbRegistrarVenta";
            gbRegistrarVenta.Size = new Size(594, 514);
            gbRegistrarVenta.TabIndex = 31;
            gbRegistrarVenta.TabStop = false;
            gbRegistrarVenta.Text = " Comprobante:   ";
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(344, 50);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(126, 25);
            textBox3.TabIndex = 35;
            // 
            // lblnroFactura
            // 
            lblnroFactura.AutoSize = true;
            lblnroFactura.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblnroFactura.Location = new Point(343, 33);
            lblnroFactura.Name = "lblnroFactura";
            lblnroFactura.Size = new Size(75, 15);
            lblnroFactura.TabIndex = 34;
            lblnroFactura.Text = "Nro. Factura";
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(29, 50);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(144, 25);
            textBox2.TabIndex = 33;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(200, 50);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(126, 25);
            textBox1.TabIndex = 32;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { idCliente, DNI, nomCliente, direCliente, Contacto });
            dataGridView3.Location = new Point(30, 110);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowTemplate.Height = 25;
            dataGridView3.Size = new Size(544, 64);
            dataGridView3.TabIndex = 31;
            // 
            // idCliente
            // 
            idCliente.HeaderText = "ID Cliente";
            idCliente.Name = "idCliente";
            // 
            // DNI
            // 
            DNI.HeaderText = "DNI";
            DNI.Name = "DNI";
            // 
            // nomCliente
            // 
            nomCliente.HeaderText = "Nombre Completo";
            nomCliente.Name = "nomCliente";
            // 
            // direCliente
            // 
            direCliente.HeaderText = "Dirección";
            direCliente.Name = "direCliente";
            // 
            // Contacto
            // 
            Contacto.HeaderText = "Contacto";
            Contacto.Name = "Contacto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(30, 88);
            label3.Name = "label3";
            label3.Size = new Size(106, 15);
            label3.TabIndex = 30;
            label3.Text = "Datos del cliente: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(200, 33);
            label2.Name = "label2";
            label2.Size = new Size(103, 15);
            label2.TabIndex = 29;
            label2.Text = "Fecha operacion: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(29, 33);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 28;
            label1.Text = "Nombre Empresa: ";
            // 
            // lblDetalle
            // 
            lblDetalle.AutoSize = true;
            lblDetalle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblDetalle.Location = new Point(30, 193);
            lblDetalle.Name = "lblDetalle";
            lblDetalle.Size = new Size(50, 15);
            lblDetalle.TabIndex = 27;
            lblDetalle.Text = "Detalle:";
            // 
            // txbtotalPagar
            // 
            txbtotalPagar.Enabled = false;
            txbtotalPagar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txbtotalPagar.Location = new Point(450, 475);
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
            lblTotalVendido.Location = new Point(348, 478);
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
            dataGridView1.Location = new Point(30, 215);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(544, 59);
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
            btnRegistrar.Location = new Point(189, 386);
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
            btnLimpiar.Location = new Point(89, 386);
            btnLimpiar.Margin = new Padding(4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(81, 30);
            btnLimpiar.TabIndex = 33;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txbDNI);
            groupBox1.Controls.Add(label10);
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
            groupBox1.Controls.Add(txbDesc);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(txbIdProd);
            groupBox1.Controls.Add(lblIDproducto);
            groupBox1.Controls.Add(txtContacto);
            groupBox1.Controls.Add(lblContacto);
            groupBox1.Controls.Add(txtDireccion);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(tbxNombreCompleto);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(tbxIDcliente);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(tbxFecha);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txbEmpresa);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(12, 16);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(369, 434);
            groupBox1.TabIndex = 34;
            groupBox1.TabStop = false;
            groupBox1.Text = " Datos de Venta: ";
            // 
            // txbDNI
            // 
            txbDNI.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txbDNI.Location = new Point(21, 181);
            txbDNI.Margin = new Padding(3, 2, 3, 2);
            txbDNI.Name = "txbDNI";
            txbDNI.Size = new Size(149, 25);
            txbDNI.TabIndex = 65;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(21, 164);
            label10.Name = "label10";
            label10.Size = new Size(32, 15);
            label10.TabIndex = 64;
            label10.Text = "DNI:";
            // 
            // txtTotalDatos
            // 
            txtTotalDatos.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtTotalDatos.Location = new Point(140, 347);
            txtTotalDatos.Margin = new Padding(3, 2, 3, 2);
            txtTotalDatos.Name = "txtTotalDatos";
            txtTotalDatos.Size = new Size(149, 25);
            txtTotalDatos.TabIndex = 63;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label18.Location = new Point(54, 353);
            label18.Name = "label18";
            label18.Size = new Size(80, 15);
            label18.TabIndex = 62;
            label18.Text = "Total a pagar:";
            // 
            // txtMonPromocion
            // 
            txtMonPromocion.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtMonPromocion.Location = new Point(194, 315);
            txtMonPromocion.Margin = new Padding(3, 2, 3, 2);
            txtMonPromocion.Name = "txtMonPromocion";
            txtMonPromocion.Size = new Size(149, 25);
            txtMonPromocion.TabIndex = 59;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(194, 298);
            label16.Name = "label16";
            label16.Size = new Size(113, 15);
            label16.TabIndex = 58;
            label16.Text = "Monto promoción: ";
            // 
            // txtNomPromocion
            // 
            txtNomPromocion.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtNomPromocion.Location = new Point(194, 270);
            txtNomPromocion.Margin = new Padding(3, 2, 3, 2);
            txtNomPromocion.Name = "txtNomPromocion";
            txtNomPromocion.Size = new Size(149, 25);
            txtNomPromocion.TabIndex = 57;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(194, 253);
            label15.Name = "label15";
            label15.Size = new Size(119, 15);
            label15.TabIndex = 56;
            label15.Text = "Nombre Promoción:";
            // 
            // txbMonTot
            // 
            txbMonTot.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txbMonTot.Location = new Point(194, 226);
            txbMonTot.Margin = new Padding(3, 2, 3, 2);
            txbMonTot.Name = "txbMonTot";
            txbMonTot.Size = new Size(149, 25);
            txbMonTot.TabIndex = 55;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(194, 209);
            label14.Name = "label14";
            label14.Size = new Size(76, 15);
            label14.TabIndex = 54;
            label14.Text = "Monto total:";
            // 
            // txbMonUni
            // 
            txbMonUni.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txbMonUni.Location = new Point(194, 181);
            txbMonUni.Margin = new Padding(3, 2, 3, 2);
            txbMonUni.Name = "txbMonUni";
            txbMonUni.Size = new Size(149, 25);
            txbMonUni.TabIndex = 53;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(194, 164);
            label13.Name = "label13";
            label13.Size = new Size(93, 15);
            label13.TabIndex = 52;
            label13.Text = "Monto unitario:";
            // 
            // txbCant
            // 
            txbCant.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txbCant.Location = new Point(194, 137);
            txbCant.Margin = new Padding(3, 2, 3, 2);
            txbCant.Name = "txbCant";
            txbCant.Size = new Size(149, 25);
            txbCant.TabIndex = 51;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(194, 120);
            label12.Name = "label12";
            label12.Size = new Size(58, 15);
            label12.TabIndex = 50;
            label12.Text = "Cantidad:";
            // 
            // txbDesc
            // 
            txbDesc.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txbDesc.Location = new Point(194, 93);
            txbDesc.Margin = new Padding(3, 2, 3, 2);
            txbDesc.Name = "txbDesc";
            txbDesc.Size = new Size(149, 25);
            txbDesc.TabIndex = 49;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(194, 76);
            label11.Name = "label11";
            label11.Size = new Size(78, 15);
            label11.TabIndex = 48;
            label11.Text = "Descripción: ";
            // 
            // txbIdProd
            // 
            txbIdProd.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txbIdProd.Location = new Point(194, 50);
            txbIdProd.Margin = new Padding(3, 2, 3, 2);
            txbIdProd.Name = "txbIdProd";
            txbIdProd.Size = new Size(149, 25);
            txbIdProd.TabIndex = 47;
            // 
            // lblIDproducto
            // 
            lblIDproducto.AutoSize = true;
            lblIDproducto.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblIDproducto.Location = new Point(194, 33);
            lblIDproducto.Name = "lblIDproducto";
            lblIDproducto.Size = new Size(80, 15);
            lblIDproducto.TabIndex = 46;
            lblIDproducto.Text = "ID Producto: ";
            // 
            // txtContacto
            // 
            txtContacto.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtContacto.Location = new Point(21, 315);
            txtContacto.Margin = new Padding(3, 2, 3, 2);
            txtContacto.Name = "txtContacto";
            txtContacto.Size = new Size(149, 25);
            txtContacto.TabIndex = 45;
            // 
            // lblContacto
            // 
            lblContacto.AutoSize = true;
            lblContacto.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblContacto.Location = new Point(21, 298);
            lblContacto.Name = "lblContacto";
            lblContacto.Size = new Size(63, 15);
            lblContacto.TabIndex = 44;
            lblContacto.Text = "Contacto: ";
            // 
            // txtDireccion
            // 
            txtDireccion.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtDireccion.Location = new Point(21, 270);
            txtDireccion.Margin = new Padding(3, 2, 3, 2);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(149, 25);
            txtDireccion.TabIndex = 43;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(21, 253);
            label9.Name = "label9";
            label9.Size = new Size(63, 15);
            label9.TabIndex = 42;
            label9.Text = "Dirección:";
            // 
            // tbxNombreCompleto
            // 
            tbxNombreCompleto.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tbxNombreCompleto.Location = new Point(21, 226);
            tbxNombreCompleto.Margin = new Padding(3, 2, 3, 2);
            tbxNombreCompleto.Name = "tbxNombreCompleto";
            tbxNombreCompleto.Size = new Size(149, 25);
            tbxNombreCompleto.TabIndex = 41;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(21, 209);
            label8.Name = "label8";
            label8.Size = new Size(113, 15);
            label8.TabIndex = 40;
            label8.Text = "Nombre Completo:";
            // 
            // tbxIDcliente
            // 
            tbxIDcliente.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tbxIDcliente.Location = new Point(21, 135);
            tbxIDcliente.Margin = new Padding(3, 2, 3, 2);
            tbxIDcliente.Name = "tbxIDcliente";
            tbxIDcliente.Size = new Size(149, 25);
            tbxIDcliente.TabIndex = 39;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(21, 118);
            label7.Name = "label7";
            label7.Size = new Size(65, 15);
            label7.TabIndex = 38;
            label7.Text = "ID Cliente:";
            // 
            // tbxFecha
            // 
            tbxFecha.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tbxFecha.Location = new Point(21, 93);
            tbxFecha.Margin = new Padding(3, 2, 3, 2);
            tbxFecha.Name = "tbxFecha";
            tbxFecha.Size = new Size(149, 25);
            tbxFecha.TabIndex = 37;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(21, 76);
            label6.Name = "label6";
            label6.Size = new Size(103, 15);
            label6.TabIndex = 36;
            label6.Text = "Fecha operación: ";
            // 
            // txbEmpresa
            // 
            txbEmpresa.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txbEmpresa.Location = new Point(21, 50);
            txbEmpresa.Margin = new Padding(3, 2, 3, 2);
            txbEmpresa.Name = "txbEmpresa";
            txbEmpresa.Size = new Size(149, 25);
            txbEmpresa.TabIndex = 35;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(21, 33);
            label5.Name = "label5";
            label5.Size = new Size(109, 15);
            label5.TabIndex = 34;
            label5.Text = "Nombre Empresa: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 33);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 0;
            // 
            // FormRegistrarVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1041, 540);
            Controls.Add(groupBox1);
            Controls.Add(gbRegistrarVenta);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormRegistrarVenta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormRegistrarVenta";
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
        private DataGridViewTextBoxColumn idCliente;
        private DataGridViewTextBoxColumn DNI;
        private DataGridViewTextBoxColumn nomCliente;
        private DataGridViewTextBoxColumn direCliente;
        private DataGridViewTextBoxColumn Contacto;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
        private GroupBox groupBox1;
        private TextBox txbDNI;
        private Label label10;
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
        private TextBox txbDesc;
        private Label label11;
        private TextBox txbIdProd;
        private Label lblIDproducto;
        private TextBox txtContacto;
        private Label lblContacto;
        private TextBox txtDireccion;
        private Label label9;
        private TextBox tbxNombreCompleto;
        private Label label8;
        private TextBox tbxIDcliente;
        private Label label7;
        private TextBox tbxFecha;
        private Label label6;
        private TextBox txbEmpresa;
        private Label label5;
        private Label label4;
        private TextBox textBox3;
        private Label lblnroFactura;
    }
}