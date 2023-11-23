namespace FormPresentacion
{
    partial class FormEditarProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditarProducto));
            grbAgregarUsuario = new GroupBox();
            button1 = new Button();
            btnLimpiarDetalle = new Button();
            btnCancelar = new Button();
            txtNuevoStock = new TextBox();
            lblApellido = new Label();
            txtNuevoPrecio = new TextBox();
            lblNombre = new Label();
            pictureBox1 = new PictureBox();
            grbAgregarUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // grbAgregarUsuario
            // 
            grbAgregarUsuario.Controls.Add(button1);
            grbAgregarUsuario.Controls.Add(btnLimpiarDetalle);
            grbAgregarUsuario.Controls.Add(btnCancelar);
            grbAgregarUsuario.Controls.Add(txtNuevoStock);
            grbAgregarUsuario.Controls.Add(lblApellido);
            grbAgregarUsuario.Controls.Add(txtNuevoPrecio);
            grbAgregarUsuario.Controls.Add(lblNombre);
            grbAgregarUsuario.Location = new Point(160, 31);
            grbAgregarUsuario.Margin = new Padding(3, 2, 3, 2);
            grbAgregarUsuario.Name = "grbAgregarUsuario";
            grbAgregarUsuario.Padding = new Padding(3, 2, 3, 2);
            grbAgregarUsuario.Size = new Size(382, 201);
            grbAgregarUsuario.TabIndex = 14;
            grbAgregarUsuario.TabStop = false;
            grbAgregarUsuario.Text = "Editar producto";
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGray;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.CheckedBackColor = Color.Black;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(23, 145);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(101, 30);
            button1.TabIndex = 35;
            button1.Text = "Editar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnLimpiarDetalle
            // 
            btnLimpiarDetalle.BackColor = Color.DarkGray;
            btnLimpiarDetalle.FlatAppearance.BorderSize = 0;
            btnLimpiarDetalle.FlatAppearance.CheckedBackColor = Color.Black;
            btnLimpiarDetalle.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnLimpiarDetalle.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnLimpiarDetalle.FlatStyle = FlatStyle.Flat;
            btnLimpiarDetalle.Location = new Point(138, 145);
            btnLimpiarDetalle.Margin = new Padding(4);
            btnLimpiarDetalle.Name = "btnLimpiarDetalle";
            btnLimpiarDetalle.Size = new Size(101, 30);
            btnLimpiarDetalle.TabIndex = 34;
            btnLimpiarDetalle.Text = "Limpiar";
            btnLimpiarDetalle.UseVisualStyleBackColor = false;
            btnLimpiarDetalle.Click += btnLimpiarDetalle_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.DarkGray;
            btnCancelar.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            btnCancelar.FlatAppearance.CheckedBackColor = Color.Black;
            btnCancelar.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 192);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Location = new Point(253, 145);
            btnCancelar.Margin = new Padding(4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(101, 30);
            btnCancelar.TabIndex = 31;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtNuevoStock
            // 
            txtNuevoStock.Location = new Point(50, 98);
            txtNuevoStock.Margin = new Padding(3, 2, 3, 2);
            txtNuevoStock.Name = "txtNuevoStock";
            txtNuevoStock.Size = new Size(279, 23);
            txtNuevoStock.TabIndex = 13;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(50, 80);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(73, 15);
            lblApellido.TabIndex = 12;
            lblApellido.Text = "Nuevo stock";
            // 
            // txtNuevoPrecio
            // 
            txtNuevoPrecio.Location = new Point(50, 55);
            txtNuevoPrecio.Margin = new Padding(3, 2, 3, 2);
            txtNuevoPrecio.Name = "txtNuevoPrecio";
            txtNuevoPrecio.Size = new Size(279, 23);
            txtNuevoPrecio.TabIndex = 11;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(50, 36);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(78, 15);
            lblNombre.TabIndex = 10;
            lblNombre.Text = "Nuevo precio";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(29, 38);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(115, 115);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // FormEditarProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(569, 259);
            Controls.Add(pictureBox1);
            Controls.Add(grbAgregarUsuario);
            Name = "FormEditarProducto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormEditarProducto";
            Load += FormEditarProducto_Load;
            grbAgregarUsuario.ResumeLayout(false);
            grbAgregarUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbAgregarUsuario;
        private Button button1;
        private Button btnLimpiarDetalle;
        private Button btnCancelar;
        private Label lblApellido;
        private Label lblNombre;
        private PictureBox pictureBox1;
        public TextBox txtNuevoStock;
        public TextBox txtNuevoPrecio;
    }
}