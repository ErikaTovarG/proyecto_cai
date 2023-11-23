namespace FormPresentacion
{
    partial class FormRegistrarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistrarCliente));
            pictureBox1 = new PictureBox();
            grbAgregarUsuario = new GroupBox();
            txtHost = new TextBox();
            pictureBox2 = new PictureBox();
            txtTelefono = new TextBox();
            btnAgregar = new Button();
            btnCancelar = new Button();
            txtFechaNacimiento = new TextBox();
            lblFechaNacimiento = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            lblTelefono = new Label();
            txtDireccion = new TextBox();
            lblDireccion = new Label();
            lblHost = new Label();
            txtDNI = new TextBox();
            lblDNI = new Label();
            txtApellido = new TextBox();
            lblApellido = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            grbAgregarUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(32, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 149);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // grbAgregarUsuario
            // 
            grbAgregarUsuario.Controls.Add(txtHost);
            grbAgregarUsuario.Controls.Add(pictureBox2);
            grbAgregarUsuario.Controls.Add(txtTelefono);
            grbAgregarUsuario.Controls.Add(btnAgregar);
            grbAgregarUsuario.Controls.Add(btnCancelar);
            grbAgregarUsuario.Controls.Add(txtFechaNacimiento);
            grbAgregarUsuario.Controls.Add(lblFechaNacimiento);
            grbAgregarUsuario.Controls.Add(txtEmail);
            grbAgregarUsuario.Controls.Add(lblEmail);
            grbAgregarUsuario.Controls.Add(lblTelefono);
            grbAgregarUsuario.Controls.Add(txtDireccion);
            grbAgregarUsuario.Controls.Add(lblDireccion);
            grbAgregarUsuario.Controls.Add(lblHost);
            grbAgregarUsuario.Controls.Add(txtDNI);
            grbAgregarUsuario.Controls.Add(lblDNI);
            grbAgregarUsuario.Controls.Add(txtApellido);
            grbAgregarUsuario.Controls.Add(lblApellido);
            grbAgregarUsuario.Controls.Add(txtNombre);
            grbAgregarUsuario.Controls.Add(lblNombre);
            grbAgregarUsuario.Location = new Point(246, 42);
            grbAgregarUsuario.Name = "grbAgregarUsuario";
            grbAgregarUsuario.Size = new Size(839, 547);
            grbAgregarUsuario.TabIndex = 14;
            grbAgregarUsuario.TabStop = false;
            grbAgregarUsuario.Text = "Registar nuevo Clientes";
            // 
            // txtHost
            // 
            txtHost.Location = new Point(438, 59);
            txtHost.Name = "txtHost";
            txtHost.Size = new Size(150, 27);
            txtHost.TabIndex = 34;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(438, 151);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(150, 149);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(46, 269);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(318, 27);
            txtTelefono.TabIndex = 33;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.DarkGray;
            btnAgregar.FlatAppearance.BorderColor = Color.FromArgb(192, 192, 255);
            btnAgregar.FlatAppearance.CheckedBackColor = Color.Black;
            btnAgregar.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnAgregar.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Location = new Point(187, 451);
            btnAgregar.Margin = new Padding(5);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(115, 40);
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
            btnCancelar.Location = new Point(438, 451);
            btnCancelar.Margin = new Padding(5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(115, 40);
            btnCancelar.TabIndex = 31;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtFechaNacimiento
            // 
            txtFechaNacimiento.Location = new Point(46, 376);
            txtFechaNacimiento.Name = "txtFechaNacimiento";
            txtFechaNacimiento.Size = new Size(318, 27);
            txtFechaNacimiento.TabIndex = 30;
            // 
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.Location = new Point(46, 352);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new Size(125, 20);
            lblFechaNacimiento.TabIndex = 29;
            lblFechaNacimiento.Text = "Fecha nacimiento";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(46, 323);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(318, 27);
            txtEmail.TabIndex = 26;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(46, 299);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 25;
            lblEmail.Text = "Email";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(46, 245);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(67, 20);
            lblTelefono.TabIndex = 23;
            lblTelefono.Text = "Telefono";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(46, 217);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(318, 27);
            txtDireccion.TabIndex = 22;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(46, 193);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(72, 20);
            lblDireccion.TabIndex = 21;
            lblDireccion.Text = "Dirección";
            // 
            // lblHost
            // 
            lblHost.AutoSize = true;
            lblHost.Location = new Point(438, 33);
            lblHost.Name = "lblHost";
            lblHost.Size = new Size(40, 20);
            lblHost.TabIndex = 18;
            lblHost.Text = "Host";
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(46, 164);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(318, 27);
            txtDNI.TabIndex = 17;
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Location = new Point(46, 140);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(35, 20);
            lblDNI.TabIndex = 16;
            lblDNI.Text = "DNI";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(46, 111);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(318, 27);
            txtApellido.TabIndex = 13;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(46, 87);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(66, 20);
            lblApellido.TabIndex = 12;
            lblApellido.Text = "Apellido";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(46, 59);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(318, 27);
            txtNombre.TabIndex = 11;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(46, 33);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 10;
            lblNombre.Text = "Nombre";
            // 
            // FormRegistrarCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1126, 637);
            Controls.Add(pictureBox1);
            Controls.Add(grbAgregarUsuario);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormRegistrarCliente";
            Text = "Registar usuario";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            grbAgregarUsuario.ResumeLayout(false);
            grbAgregarUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private GroupBox grbAgregarUsuario;
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
        private Label lblHost;
        private TextBox txtDNI;
        private Label lblDNI;
        private TextBox txtApellido;
        private Label lblApellido;
        private TextBox txtNombre;
        private Label lblNombre;
        private TextBox txtHost;
    }
}