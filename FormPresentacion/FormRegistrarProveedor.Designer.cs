namespace FormPresentacion
{
    partial class FormRegistrarProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistrarProveedor));
            pictureBox1 = new PictureBox();
            grbAgregarProveedor = new GroupBox();
            txtCUIT = new TextBox();
            lblCUIT = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtApellido = new TextBox();
            lblApellido = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            btnLimpiarDetalle = new Button();
            pictureBox2 = new PictureBox();
            btnAgregar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            grbAgregarProveedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(78, 62);
            pictureBox1.Margin = new Padding(4, 4, 4, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(188, 188);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // grbAgregarProveedor
            // 
            grbAgregarProveedor.Controls.Add(txtCUIT);
            grbAgregarProveedor.Controls.Add(lblCUIT);
            grbAgregarProveedor.Controls.Add(txtEmail);
            grbAgregarProveedor.Controls.Add(lblEmail);
            grbAgregarProveedor.Controls.Add(txtApellido);
            grbAgregarProveedor.Controls.Add(lblApellido);
            grbAgregarProveedor.Controls.Add(txtNombre);
            grbAgregarProveedor.Controls.Add(lblNombre);
            grbAgregarProveedor.Controls.Add(btnLimpiarDetalle);
            grbAgregarProveedor.Controls.Add(pictureBox2);
            grbAgregarProveedor.Controls.Add(btnAgregar);
            grbAgregarProveedor.Controls.Add(btnCancelar);
            grbAgregarProveedor.Location = new Point(326, 62);
            grbAgregarProveedor.Margin = new Padding(4, 4, 4, 4);
            grbAgregarProveedor.Name = "grbAgregarProveedor";
            grbAgregarProveedor.Padding = new Padding(4, 4, 4, 4);
            grbAgregarProveedor.Size = new Size(799, 479);
            grbAgregarProveedor.TabIndex = 16;
            grbAgregarProveedor.TabStop = false;
            grbAgregarProveedor.Text = "Registar nuevo proveedor";
            // 
            // txtCUIT
            // 
            txtCUIT.Location = new Point(58, 281);
            txtCUIT.Margin = new Padding(4, 4, 4, 4);
            txtCUIT.Name = "txtCUIT";
            txtCUIT.Size = new Size(396, 31);
            txtCUIT.TabIndex = 43;
            // 
            // lblCUIT
            // 
            lblCUIT.AutoSize = true;
            lblCUIT.Location = new Point(58, 252);
            lblCUIT.Margin = new Padding(4, 0, 4, 0);
            lblCUIT.Name = "lblCUIT";
            lblCUIT.Size = new Size(49, 25);
            lblCUIT.TabIndex = 42;
            lblCUIT.Text = "CUIT";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(58, 215);
            txtEmail.Margin = new Padding(4, 4, 4, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(396, 31);
            txtEmail.TabIndex = 40;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(58, 186);
            lblEmail.Margin = new Padding(4, 0, 4, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(54, 25);
            lblEmail.TabIndex = 39;
            lblEmail.Text = "Email";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(58, 149);
            txtApellido.Margin = new Padding(4, 4, 4, 4);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(396, 31);
            txtApellido.TabIndex = 38;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(58, 120);
            lblApellido.Margin = new Padding(4, 0, 4, 0);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(78, 25);
            lblApellido.TabIndex = 37;
            lblApellido.Text = "Apellido";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(58, 82);
            txtNombre.Margin = new Padding(4, 4, 4, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(396, 31);
            txtNombre.TabIndex = 36;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(58, 54);
            lblNombre.Margin = new Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(78, 25);
            lblNombre.TabIndex = 35;
            lblNombre.Text = "Nombre";
            // 
            // btnLimpiarDetalle
            // 
            btnLimpiarDetalle.BackColor = Color.DarkGray;
            btnLimpiarDetalle.FlatAppearance.BorderSize = 0;
            btnLimpiarDetalle.FlatAppearance.CheckedBackColor = Color.Black;
            btnLimpiarDetalle.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnLimpiarDetalle.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnLimpiarDetalle.FlatStyle = FlatStyle.Flat;
            btnLimpiarDetalle.Location = new Point(245, 348);
            btnLimpiarDetalle.Margin = new Padding(6, 6, 6, 6);
            btnLimpiarDetalle.Name = "btnLimpiarDetalle";
            btnLimpiarDetalle.Size = new Size(144, 50);
            btnLimpiarDetalle.TabIndex = 34;
            btnLimpiarDetalle.Text = "Limpiar";
            btnLimpiarDetalle.UseVisualStyleBackColor = false;
            btnLimpiarDetalle.Click += btnLimpiarDetalle_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(575, 72);
            pictureBox2.Margin = new Padding(4, 4, 4, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(188, 188);
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
            btnAgregar.Location = new Point(64, 348);
            btnAgregar.Margin = new Padding(6, 6, 6, 6);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(144, 50);
            btnAgregar.TabIndex = 32;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.DarkGray;
            btnCancelar.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            btnCancelar.FlatAppearance.CheckedBackColor = Color.Black;
            btnCancelar.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 192);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Location = new Point(420, 348);
            btnCancelar.Margin = new Padding(6, 6, 6, 6);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(144, 50);
            btnCancelar.TabIndex = 31;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormRegistrarProveedor
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1276, 688);
            Controls.Add(pictureBox1);
            Controls.Add(grbAgregarProveedor);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 4, 4, 4);
            Name = "FormRegistrarProveedor";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrar Proveedor";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            grbAgregarProveedor.ResumeLayout(false);
            grbAgregarProveedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private GroupBox grbAgregarProveedor;
        private Button btnLimpiarDetalle;
        private PictureBox pictureBox2;
        private Button btnAgregar;
        private Button btnCancelar;
        private TextBox txtApellido;
        private Label lblApellido;
        private TextBox txtNombre;
        private Label lblNombre;
        private TextBox txtCUIT;
        private Label lblCUIT;
        private TextBox txtEmail;
        private Label lblEmail;
    }
}