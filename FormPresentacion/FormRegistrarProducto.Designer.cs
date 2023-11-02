namespace FormPresentacion
{
    partial class FormRegistrarProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistrarProducto));
            pictureBox1 = new PictureBox();
            grbAgregarProducto = new GroupBox();
            cmbStock = new ComboBox();
            lblStock = new Label();
            txtPrecio = new TextBox();
            lblPrecio = new Label();
            cmbCategoria = new ComboBox();
            btnLimpiarDetalle = new Button();
            pictureBox2 = new PictureBox();
            btnAgregar = new Button();
            btnCancelar = new Button();
            cmbProveedor = new ComboBox();
            lblProveedor = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            lblCategoriaProducto = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            grbAgregarProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(64, 54);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // grbAgregarProducto
            // 
            grbAgregarProducto.Controls.Add(cmbStock);
            grbAgregarProducto.Controls.Add(lblStock);
            grbAgregarProducto.Controls.Add(txtPrecio);
            grbAgregarProducto.Controls.Add(lblPrecio);
            grbAgregarProducto.Controls.Add(cmbCategoria);
            grbAgregarProducto.Controls.Add(btnLimpiarDetalle);
            grbAgregarProducto.Controls.Add(pictureBox2);
            grbAgregarProducto.Controls.Add(btnAgregar);
            grbAgregarProducto.Controls.Add(btnCancelar);
            grbAgregarProducto.Controls.Add(cmbProveedor);
            grbAgregarProducto.Controls.Add(lblProveedor);
            grbAgregarProducto.Controls.Add(txtNombre);
            grbAgregarProducto.Controls.Add(lblNombre);
            grbAgregarProducto.Controls.Add(lblCategoriaProducto);
            grbAgregarProducto.Location = new Point(263, 54);
            grbAgregarProducto.Name = "grbAgregarProducto";
            grbAgregarProducto.Size = new Size(639, 548);
            grbAgregarProducto.TabIndex = 14;
            grbAgregarProducto.TabStop = false;
            grbAgregarProducto.Text = "Registar nuevo producto";
            // 
            // cmbStock
            // 
            cmbStock.FormattingEnabled = true;
            cmbStock.Location = new Point(46, 272);
            cmbStock.Name = "cmbStock";
            cmbStock.Size = new Size(150, 28);
            cmbStock.TabIndex = 40;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(46, 249);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(45, 20);
            lblStock.TabIndex = 38;
            lblStock.Text = "Stock";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(46, 219);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(294, 27);
            txtPrecio.TabIndex = 37;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(46, 196);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(50, 20);
            lblPrecio.TabIndex = 36;
            lblPrecio.Text = "Precio";
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(46, 58);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(150, 28);
            cmbCategoria.TabIndex = 35;
            // 
            // btnLimpiarDetalle
            // 
            btnLimpiarDetalle.BackColor = Color.DarkGray;
            btnLimpiarDetalle.FlatAppearance.BorderSize = 0;
            btnLimpiarDetalle.FlatAppearance.CheckedBackColor = Color.Black;
            btnLimpiarDetalle.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnLimpiarDetalle.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnLimpiarDetalle.FlatStyle = FlatStyle.Flat;
            btnLimpiarDetalle.Location = new Point(191, 330);
            btnLimpiarDetalle.Margin = new Padding(5);
            btnLimpiarDetalle.Name = "btnLimpiarDetalle";
            btnLimpiarDetalle.Size = new Size(115, 40);
            btnLimpiarDetalle.TabIndex = 34;
            btnLimpiarDetalle.Text = "Limpiar";
            btnLimpiarDetalle.UseVisualStyleBackColor = false;
            btnLimpiarDetalle.Click += btnLimpiarDetalle_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(460, 58);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(150, 150);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.DarkGray;
            btnAgregar.FlatAppearance.BorderColor = Color.FromArgb(192, 192, 255);
            btnAgregar.FlatAppearance.CheckedBackColor = Color.Black;
            btnAgregar.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnAgregar.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Location = new Point(46, 330);
            btnAgregar.Margin = new Padding(5);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(115, 40);
            btnAgregar.TabIndex = 32;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.DarkGray;
            btnCancelar.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            btnCancelar.FlatAppearance.CheckedBackColor = Color.Black;
            btnCancelar.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 192);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Location = new Point(331, 330);
            btnCancelar.Margin = new Padding(5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(115, 40);
            btnCancelar.TabIndex = 31;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // cmbProveedor
            // 
            cmbProveedor.FormattingEnabled = true;
            cmbProveedor.Location = new Point(46, 111);
            cmbProveedor.Name = "cmbProveedor";
            cmbProveedor.Size = new Size(294, 28);
            cmbProveedor.TabIndex = 20;
            // 
            // lblProveedor
            // 
            lblProveedor.AutoSize = true;
            lblProveedor.Location = new Point(46, 88);
            lblProveedor.Name = "lblProveedor";
            lblProveedor.Size = new Size(77, 20);
            lblProveedor.TabIndex = 18;
            lblProveedor.Text = "Proveedor";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(46, 166);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(294, 27);
            txtNombre.TabIndex = 15;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(46, 143);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 14;
            lblNombre.Text = "Nombre";
            // 
            // lblCategoriaProducto
            // 
            lblCategoriaProducto.AutoSize = true;
            lblCategoriaProducto.Location = new Point(46, 35);
            lblCategoriaProducto.Name = "lblCategoriaProducto";
            lblCategoriaProducto.Size = new Size(74, 20);
            lblCategoriaProducto.TabIndex = 10;
            lblCategoriaProducto.Text = "Categoria";
            // 
            // FormRegistrarProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 657);
            Controls.Add(pictureBox1);
            Controls.Add(grbAgregarProducto);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormRegistrarProducto";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormRegistrarProducto";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            grbAgregarProducto.ResumeLayout(false);
            grbAgregarProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private GroupBox grbAgregarProducto;
        private Button btnLimpiarDetalle;
        private PictureBox pictureBox2;
        private TextBox txtTelefono;
        private Button btnAgregar;
        private Button btnCancelar;
        private TextBox txtFechaNacimiento;
        private Label lblFechaNacimiento;
        private TextBox txtEmail;
        private Label lblEmail;
        private Label lblTelefono;
        private TextBox txtDireccion;
        private Label lblDireccion;
        private ComboBox cmbProveedor;
        private Label lblProveedor;
        private TextBox txtDNI;
        private Label lblDNI;
        private TextBox txtUsuario;
        private Label lblNombre;
        private TextBox txtApellido;
        private Label lblApellido;
        private TextBox txtNombre;
        private Label lblCategoriaProducto;
        private ComboBox cmbCategoria;
        private Label lblStock;
        private TextBox txtPrecio;
        private Label lblPrecio;
        private ComboBox cmbStock;
    }
}