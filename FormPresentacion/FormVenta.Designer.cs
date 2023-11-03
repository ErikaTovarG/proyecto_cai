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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVenta));
            gbDevVenta = new GroupBox();
            tbFecha = new TextBox();
            label1 = new Label();
            tbEmpresa = new TextBox();
            lblEmpresa = new Label();
            btnEliminar = new Button();
            btnEditar = new Button();
            dgvDatosCliente = new DataGridView();
            idCliente = new DataGridViewTextBoxColumn();
            DNI = new DataGridViewTextBoxColumn();
            nomCliente = new DataGridViewTextBoxColumn();
            direCliente = new DataGridViewTextBoxColumn();
            Contacto = new DataGridViewTextBoxColumn();
            label3 = new Label();
            lblPromocion = new Label();
            dgvPromo = new DataGridView();
            nomPromocion = new DataGridViewTextBoxColumn();
            monDescuento = new DataGridViewTextBoxColumn();
            lblDetalle = new Label();
            tbTotalPagado = new TextBox();
            lblTotal = new Label();
            dgvDetalle = new DataGridView();
            idProducto = new DataGridViewTextBoxColumn();
            desProducto = new DataGridViewTextBoxColumn();
            cant = new DataGridViewTextBoxColumn();
            mUnitario = new DataGridViewTextBoxColumn();
            mTotal = new DataGridViewTextBoxColumn();
            tboxIdVenta = new TextBox();
            btnBuscarVentaporIdVenta = new Button();
            lblnroFactura = new Label();
            gbDevVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatosCliente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPromo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).BeginInit();
            SuspendLayout();
            // 
            // gbDevVenta
            // 
            gbDevVenta.Controls.Add(tbFecha);
            gbDevVenta.Controls.Add(label1);
            gbDevVenta.Controls.Add(tbEmpresa);
            gbDevVenta.Controls.Add(lblEmpresa);
            gbDevVenta.Controls.Add(btnEliminar);
            gbDevVenta.Controls.Add(btnEditar);
            gbDevVenta.Controls.Add(dgvDatosCliente);
            gbDevVenta.Controls.Add(label3);
            gbDevVenta.Controls.Add(lblPromocion);
            gbDevVenta.Controls.Add(dgvPromo);
            gbDevVenta.Controls.Add(lblDetalle);
            gbDevVenta.Controls.Add(tbTotalPagado);
            gbDevVenta.Controls.Add(lblTotal);
            gbDevVenta.Controls.Add(dgvDetalle);
            gbDevVenta.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            gbDevVenta.Location = new Point(46, 72);
            gbDevVenta.Name = "gbDevVenta";
            gbDevVenta.Size = new Size(593, 477);
            gbDevVenta.TabIndex = 34;
            gbDevVenta.TabStop = false;
            gbDevVenta.Text = "   Devolución:   ";
            // 
            // tbFecha
            // 
            tbFecha.Enabled = false;
            tbFecha.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tbFecha.Location = new Point(420, 31);
            tbFecha.Margin = new Padding(3, 2, 3, 2);
            tbFecha.Name = "tbFecha";
            tbFecha.Size = new Size(144, 25);
            tbFecha.TabIndex = 42;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(311, 36);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 41;
            label1.Text = "Fecha Operación: ";
            // 
            // tbEmpresa
            // 
            tbEmpresa.Enabled = false;
            tbEmpresa.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tbEmpresa.Location = new Point(134, 31);
            tbEmpresa.Margin = new Padding(3, 2, 3, 2);
            tbEmpresa.Name = "tbEmpresa";
            tbEmpresa.Size = new Size(144, 25);
            tbEmpresa.TabIndex = 40;
            // 
            // lblEmpresa
            // 
            lblEmpresa.AutoSize = true;
            lblEmpresa.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmpresa.Location = new Point(25, 36);
            lblEmpresa.Name = "lblEmpresa";
            lblEmpresa.Size = new Size(109, 15);
            lblEmpresa.TabIndex = 39;
            lblEmpresa.Text = "Nombre Empresa: ";
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.DarkGray;
            btnEliminar.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            btnEliminar.FlatAppearance.CheckedBackColor = Color.Black;
            btnEliminar.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnEliminar.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 192);
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Location = new Point(488, 435);
            btnEliminar.Margin = new Padding(4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(89, 26);
            btnEliminar.TabIndex = 35;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnRegistrar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.DarkGray;
            btnEditar.FlatAppearance.BorderColor = Color.FromArgb(192, 192, 255);
            btnEditar.FlatAppearance.CheckedBackColor = Color.Black;
            btnEditar.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnEditar.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Location = new Point(388, 435);
            btnEditar.Margin = new Padding(4);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(89, 26);
            btnEditar.TabIndex = 36;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // dgvDatosCliente
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvDatosCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDatosCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatosCliente.Columns.AddRange(new DataGridViewColumn[] { idCliente, DNI, nomCliente, direCliente, Contacto });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvDatosCliente.DefaultCellStyle = dataGridViewCellStyle2;
            dgvDatosCliente.Enabled = false;
            dgvDatosCliente.Location = new Point(22, 215);
            dgvDatosCliente.Name = "dgvDatosCliente";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvDatosCliente.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvDatosCliente.RowTemplate.Height = 25;
            dgvDatosCliente.Size = new Size(544, 64);
            dgvDatosCliente.TabIndex = 38;
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
            label3.Location = new Point(22, 193);
            label3.Name = "label3";
            label3.Size = new Size(106, 15);
            label3.TabIndex = 37;
            label3.Text = "Datos del cliente: ";
            // 
            // lblPromocion
            // 
            lblPromocion.AutoSize = true;
            lblPromocion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPromocion.Location = new Point(22, 290);
            lblPromocion.Name = "lblPromocion";
            lblPromocion.Size = new Size(70, 15);
            lblPromocion.TabIndex = 30;
            lblPromocion.Text = "Promocion:";
            // 
            // dgvPromo
            // 
            dgvPromo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPromo.Columns.AddRange(new DataGridViewColumn[] { nomPromocion, monDescuento });
            dgvPromo.Enabled = false;
            dgvPromo.Location = new Point(22, 312);
            dgvPromo.Name = "dgvPromo";
            dgvPromo.RowTemplate.Height = 25;
            dgvPromo.Size = new Size(229, 77);
            dgvPromo.TabIndex = 29;
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
            // lblDetalle
            // 
            lblDetalle.AutoSize = true;
            lblDetalle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblDetalle.Location = new Point(25, 82);
            lblDetalle.Name = "lblDetalle";
            lblDetalle.Size = new Size(50, 15);
            lblDetalle.TabIndex = 27;
            lblDetalle.Text = "Detalle:";
            // 
            // tbTotalPagado
            // 
            tbTotalPagado.Enabled = false;
            tbTotalPagado.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tbTotalPagado.Location = new Point(453, 391);
            tbTotalPagado.Margin = new Padding(3, 2, 3, 2);
            tbTotalPagado.Name = "tbTotalPagado";
            tbTotalPagado.Size = new Size(124, 25);
            tbTotalPagado.TabIndex = 26;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotal.Location = new Point(351, 394);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(106, 19);
            lblTotal.TabIndex = 25;
            lblTotal.Text = "Total pagado: ";
            lblTotal.Click += lblTotalVendido_Click;
            // 
            // dgvDetalle
            // 
            dgvDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalle.Columns.AddRange(new DataGridViewColumn[] { idProducto, desProducto, cant, mUnitario, mTotal });
            dgvDetalle.Enabled = false;
            dgvDetalle.Location = new Point(25, 104);
            dgvDetalle.Name = "dgvDetalle";
            dgvDetalle.RowTemplate.Height = 25;
            dgvDetalle.Size = new Size(541, 78);
            dgvDetalle.TabIndex = 23;
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
            // tboxIdVenta
            // 
            tboxIdVenta.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tboxIdVenta.Location = new Point(64, 37);
            tboxIdVenta.Margin = new Padding(3, 2, 3, 2);
            tboxIdVenta.Name = "tboxIdVenta";
            tboxIdVenta.Size = new Size(144, 25);
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
            btnBuscarVentaporIdVenta.Location = new Point(215, 37);
            btnBuscarVentaporIdVenta.Margin = new Padding(4);
            btnBuscarVentaporIdVenta.Name = "btnBuscarVentaporIdVenta";
            btnBuscarVentaporIdVenta.Size = new Size(62, 25);
            btnBuscarVentaporIdVenta.TabIndex = 37;
            btnBuscarVentaporIdVenta.Text = "Buscar";
            btnBuscarVentaporIdVenta.UseVisualStyleBackColor = false;
            // 
            // lblnroFactura
            // 
            lblnroFactura.AutoSize = true;
            lblnroFactura.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblnroFactura.Location = new Point(63, 20);
            lblnroFactura.Name = "lblnroFactura";
            lblnroFactura.Size = new Size(75, 15);
            lblnroFactura.TabIndex = 38;
            lblnroFactura.Text = "Nro. Factura";
            // 
            // FormVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(686, 567);
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
            ((System.ComponentModel.ISupportInitialize)dgvDatosCliente).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPromo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbDevVenta;
        private TextBox tboxIdVenta;
        private Label lblPromocion;
        private DataGridView dgvPromo;
        private DataGridViewTextBoxColumn nomPromocion;
        private DataGridViewTextBoxColumn monDescuento;
        private Label lblDetalle;
        private TextBox tbTotalPagado;
        private Label lblTotal;
        private DataGridView dgvDetalle;
        private Button btnEliminar;
        private Button btnEditar;
        private DataGridView dgvDatosCliente;
        private DataGridViewTextBoxColumn idCliente;
        private DataGridViewTextBoxColumn DNI;
        private DataGridViewTextBoxColumn nomCliente;
        private DataGridViewTextBoxColumn direCliente;
        private DataGridViewTextBoxColumn Contacto;
        private Label label3;
        private DataGridViewTextBoxColumn idProducto;
        private DataGridViewTextBoxColumn desProducto;
        private DataGridViewTextBoxColumn cant;
        private DataGridViewTextBoxColumn mUnitario;
        private DataGridViewTextBoxColumn mTotal;
        private TextBox tbFecha;
        private Label label1;
        private TextBox tbEmpresa;
        private Label lblEmpresa;
        private Button btnBuscarVentaporIdVenta;
        private Label lblnroFactura;
    }
}