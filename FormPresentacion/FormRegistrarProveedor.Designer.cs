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
            pictureBox1.Location = new Point(62, 50);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 150);
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
            grbAgregarProveedor.Location = new Point(261, 50);
            grbAgregarProveedor.Name = "grbAgregarProveedor";
            grbAgregarProveedor.Size = new Size(639, 383);
            grbAgregarProveedor.TabIndex = 16;
            grbAgregarProveedor.TabStop = false;
            grbAgregarProveedor.Text = "Registar nuevo proveedor";
            // 
            // txtCUIT
            // 
            txtCUIT.Location = new Point(46, 225);
            txtCUIT.Name = "txtCUIT";
            txtCUIT.Size = new Size(318, 27);
            txtCUIT.TabIndex = 43;
            // 
            // lblCUIT
            // 
            lblCUIT.AutoSize = true;
            lblCUIT.Location = new Point(46, 202);
            lblCUIT.Name = "lblCUIT";
            lblCUIT.Size = new Size(40, 20);
            lblCUIT.TabIndex = 42;
            lblCUIT.Text = "CUIT";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(46, 172);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(318, 27);
            txtEmail.TabIndex = 40;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(46, 149);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 39;
            lblEmail.Text = "Email";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(46, 119);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(318, 27);
            txtApellido.TabIndex = 38;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(46, 96);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(66, 20);
            lblApellido.TabIndex = 37;
            lblApellido.Text = "Apellido";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(46, 66);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(318, 27);
            txtNombre.TabIndex = 36;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(46, 43);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
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
            btnLimpiarDetalle.Location = new Point(196, 278);
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
            btnAgregar.Location = new Point(51, 278);
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
            btnCancelar.Location = new Point(336, 278);
            btnCancelar.Margin = new Padding(5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(115, 40);
            btnCancelar.TabIndex = 31;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormRegistrarProveedor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1021, 550);
            Controls.Add(pictureBox1);
            Controls.Add(grbAgregarProveedor);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
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