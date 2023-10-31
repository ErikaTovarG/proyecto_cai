namespace FormPresentacion
{
    partial class FormProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProductos));
            lstProductos = new ListBox();
            grbDetalle = new GroupBox();
            btnLimpiarDetalle = new Button();
            txtStock = new TextBox();
            lblStock = new Label();
            btnEditar = new Button();
            btnEliminar = new Button();
            txtPrecio = new TextBox();
            lblPrecio = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            txtCategoria = new TextBox();
            lblCategoria = new Label();
            txtIDProveedor = new TextBox();
            lblID = new Label();
            btnLimpiar = new Button();
            btnListar = new Button();
            btnVerDetalle = new Button();
            btnAgregarProducto = new Button();
            grbListaPorCategoria = new GroupBox();
            btnListarCategoria = new Button();
            btnLimpiarCategoria = new Button();
            lstProductosCategoria = new ListBox();
            cmbCategoria = new ComboBox();
            grbDetalle.SuspendLayout();
            grbListaPorCategoria.SuspendLayout();
            SuspendLayout();
            // 
            // lstProductos
            // 
            lstProductos.FormattingEnabled = true;
            lstProductos.ItemHeight = 20;
            lstProductos.Location = new Point(43, 27);
            lstProductos.Name = "lstProductos";
            lstProductos.Size = new Size(302, 504);
            lstProductos.TabIndex = 2;
            // 
            // grbDetalle
            // 
            grbDetalle.Controls.Add(btnLimpiarDetalle);
            grbDetalle.Controls.Add(txtStock);
            grbDetalle.Controls.Add(lblStock);
            grbDetalle.Controls.Add(btnEditar);
            grbDetalle.Controls.Add(btnEliminar);
            grbDetalle.Controls.Add(txtPrecio);
            grbDetalle.Controls.Add(lblPrecio);
            grbDetalle.Controls.Add(txtNombre);
            grbDetalle.Controls.Add(lblNombre);
            grbDetalle.Controls.Add(txtCategoria);
            grbDetalle.Controls.Add(lblCategoria);
            grbDetalle.Controls.Add(txtIDProveedor);
            grbDetalle.Controls.Add(lblID);
            grbDetalle.Location = new Point(371, 27);
            grbDetalle.Name = "grbDetalle";
            grbDetalle.Size = new Size(421, 445);
            grbDetalle.TabIndex = 3;
            grbDetalle.TabStop = false;
            grbDetalle.Text = "Detalle del producto";
            // 
            // btnLimpiarDetalle
            // 
            btnLimpiarDetalle.BackColor = Color.DarkGray;
            btnLimpiarDetalle.FlatAppearance.BorderSize = 0;
            btnLimpiarDetalle.FlatAppearance.CheckedBackColor = Color.Black;
            btnLimpiarDetalle.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnLimpiarDetalle.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnLimpiarDetalle.FlatStyle = FlatStyle.Flat;
            btnLimpiarDetalle.Location = new Point(274, 382);
            btnLimpiarDetalle.Margin = new Padding(5);
            btnLimpiarDetalle.Name = "btnLimpiarDetalle";
            btnLimpiarDetalle.Size = new Size(115, 40);
            btnLimpiarDetalle.TabIndex = 18;
            btnLimpiarDetalle.Text = "Limpiar";
            btnLimpiarDetalle.UseVisualStyleBackColor = false;
            btnLimpiarDetalle.Click += btnLimpiarDetalle_Click;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(25, 262);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(346, 27);
            txtStock.TabIndex = 17;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(25, 239);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(45, 20);
            lblStock.TabIndex = 16;
            lblStock.Text = "Stock";
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.DarkGray;
            btnEditar.FlatAppearance.BorderColor = Color.FromArgb(192, 192, 255);
            btnEditar.FlatAppearance.CheckedBackColor = Color.Black;
            btnEditar.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnEditar.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Location = new Point(24, 382);
            btnEditar.Margin = new Padding(5);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(115, 40);
            btnEditar.TabIndex = 15;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.DarkGray;
            btnEliminar.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            btnEliminar.FlatAppearance.CheckedBackColor = Color.Black;
            btnEliminar.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnEliminar.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 192);
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Location = new Point(149, 382);
            btnEliminar.Margin = new Padding(5);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(115, 40);
            btnEliminar.TabIndex = 14;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(25, 200);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(346, 27);
            txtPrecio.TabIndex = 7;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(25, 177);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(50, 20);
            lblPrecio.TabIndex = 6;
            lblPrecio.Text = "Precio";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(25, 137);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(346, 27);
            txtNombre.TabIndex = 5;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(25, 114);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 4;
            lblNombre.Text = "Nombre";
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(25, 325);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(87, 27);
            txtCategoria.TabIndex = 3;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(25, 302);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(74, 20);
            lblCategoria.TabIndex = 2;
            lblCategoria.Text = "Categoria";
            // 
            // txtIDProveedor
            // 
            txtIDProveedor.Enabled = false;
            txtIDProveedor.Location = new Point(25, 73);
            txtIDProveedor.Name = "txtIDProveedor";
            txtIDProveedor.Size = new Size(346, 27);
            txtIDProveedor.TabIndex = 1;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(25, 50);
            lblID.Name = "lblID";
            lblID.Size = new Size(24, 20);
            lblID.TabIndex = 0;
            lblID.Text = "ID";
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.DarkGray;
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatAppearance.CheckedBackColor = Color.Black;
            btnLimpiar.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnLimpiar.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Location = new Point(131, 589);
            btnLimpiar.Margin = new Padding(5);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(115, 40);
            btnLimpiar.TabIndex = 14;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnListar
            // 
            btnListar.BackColor = Color.DarkGray;
            btnListar.FlatAppearance.BorderSize = 0;
            btnListar.FlatAppearance.CheckedBackColor = Color.Black;
            btnListar.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnListar.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnListar.FlatStyle = FlatStyle.Flat;
            btnListar.Location = new Point(63, 539);
            btnListar.Margin = new Padding(5);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(115, 40);
            btnListar.TabIndex = 13;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = false;
            btnListar.Click += btnListar_Click;
            // 
            // btnVerDetalle
            // 
            btnVerDetalle.BackColor = Color.DarkGray;
            btnVerDetalle.FlatAppearance.BorderSize = 0;
            btnVerDetalle.FlatAppearance.CheckedBackColor = Color.Black;
            btnVerDetalle.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnVerDetalle.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnVerDetalle.FlatStyle = FlatStyle.Flat;
            btnVerDetalle.Location = new Point(207, 539);
            btnVerDetalle.Margin = new Padding(5);
            btnVerDetalle.Name = "btnVerDetalle";
            btnVerDetalle.Size = new Size(115, 40);
            btnVerDetalle.TabIndex = 12;
            btnVerDetalle.Text = "Ver detalle";
            btnVerDetalle.UseVisualStyleBackColor = false;
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.BackColor = Color.DarkGray;
            btnAgregarProducto.FlatAppearance.BorderColor = Color.FromArgb(192, 192, 255);
            btnAgregarProducto.FlatAppearance.CheckedBackColor = Color.Black;
            btnAgregarProducto.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnAgregarProducto.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            btnAgregarProducto.FlatStyle = FlatStyle.Flat;
            btnAgregarProducto.Location = new Point(844, 38);
            btnAgregarProducto.Margin = new Padding(5);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(255, 40);
            btnAgregarProducto.TabIndex = 22;
            btnAgregarProducto.Text = "Agregar producto";
            btnAgregarProducto.UseVisualStyleBackColor = false;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // grbListaPorCategoria
            // 
            grbListaPorCategoria.Controls.Add(btnListarCategoria);
            grbListaPorCategoria.Controls.Add(btnLimpiarCategoria);
            grbListaPorCategoria.Controls.Add(lstProductosCategoria);
            grbListaPorCategoria.Controls.Add(cmbCategoria);
            grbListaPorCategoria.Location = new Point(822, 100);
            grbListaPorCategoria.Name = "grbListaPorCategoria";
            grbListaPorCategoria.Size = new Size(302, 487);
            grbListaPorCategoria.TabIndex = 23;
            grbListaPorCategoria.TabStop = false;
            grbListaPorCategoria.Text = "Listado por categoria";
            // 
            // btnListarCategoria
            // 
            btnListarCategoria.BackColor = Color.DarkGray;
            btnListarCategoria.FlatAppearance.BorderSize = 0;
            btnListarCategoria.FlatAppearance.CheckedBackColor = Color.Black;
            btnListarCategoria.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnListarCategoria.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnListarCategoria.FlatStyle = FlatStyle.Flat;
            btnListarCategoria.Location = new Point(22, 74);
            btnListarCategoria.Margin = new Padding(5);
            btnListarCategoria.Name = "btnListarCategoria";
            btnListarCategoria.Size = new Size(78, 34);
            btnListarCategoria.TabIndex = 24;
            btnListarCategoria.Text = "Listar";
            btnListarCategoria.UseVisualStyleBackColor = false;
            // 
            // btnLimpiarCategoria
            // 
            btnLimpiarCategoria.BackColor = Color.DarkGray;
            btnLimpiarCategoria.FlatAppearance.BorderColor = Color.FromArgb(192, 192, 255);
            btnLimpiarCategoria.FlatAppearance.CheckedBackColor = Color.Black;
            btnLimpiarCategoria.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnLimpiarCategoria.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            btnLimpiarCategoria.FlatStyle = FlatStyle.Flat;
            btnLimpiarCategoria.Location = new Point(105, 74);
            btnLimpiarCategoria.Margin = new Padding(5);
            btnLimpiarCategoria.Name = "btnLimpiarCategoria";
            btnLimpiarCategoria.Size = new Size(78, 34);
            btnLimpiarCategoria.TabIndex = 21;
            btnLimpiarCategoria.Text = "Limpiar";
            btnLimpiarCategoria.UseVisualStyleBackColor = false;
            btnLimpiarCategoria.Click += btnLimpiarCategoria_Click;
            // 
            // lstProductosCategoria
            // 
            lstProductosCategoria.FormattingEnabled = true;
            lstProductosCategoria.ItemHeight = 20;
            lstProductosCategoria.Location = new Point(22, 116);
            lstProductosCategoria.Name = "lstProductosCategoria";
            lstProductosCategoria.Size = new Size(255, 344);
            lstProductosCategoria.TabIndex = 20;
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(22, 38);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(174, 28);
            cmbCategoria.TabIndex = 0;
            // 
            // FormProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1147, 650);
            Controls.Add(grbListaPorCategoria);
            Controls.Add(btnAgregarProducto);
            Controls.Add(btnLimpiar);
            Controls.Add(btnListar);
            Controls.Add(btnVerDetalle);
            Controls.Add(grbDetalle);
            Controls.Add(lstProductos);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormProductos";
            Text = "Listado de Productos";
            grbDetalle.ResumeLayout(false);
            grbDetalle.PerformLayout();
            grbListaPorCategoria.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private GroupBox grpLista;
        private ListBox lstProductos;
        private GroupBox grbDetalle;
        private TextBox txtIDProveedor;
        private Label lblID;
        private TextBox txtPrecio;
        private Label lblPrecio;
        private TextBox txtNombre;
        private Label lblNombre;
        private TextBox txtCategoria;
        private Label lblCategoria;
        private Button btnLimpiar;
        private Button btnListar;
        private Button btnVerDetalle;
        private Button btnEditar;
        private Button btnEliminar;
        private TextBox txtStock;
        private Label lblStock;
        private Button btnLimpiarDetalle;
        private Button btnAgregarProducto;
        private GroupBox grbListaPorCategoria;
        private Button btnListarCategoria;
        private Button btnLimpiarCategoria;
        private ListBox lstProductosCategoria;
        private ComboBox cmbCategoria;
    }
}