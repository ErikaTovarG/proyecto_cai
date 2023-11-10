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
            cmbHost = new ComboBox();
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
            pictureBox1.Location = new Point(38, 57);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(131, 112);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // grbAgregarUsuario
            // 
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
            grbAgregarUsuario.Controls.Add(cmbHost);
            grbAgregarUsuario.Controls.Add(lblHost);
            grbAgregarUsuario.Controls.Add(txtDNI);
            grbAgregarUsuario.Controls.Add(lblDNI);
            grbAgregarUsuario.Controls.Add(txtApellido);
            grbAgregarUsuario.Controls.Add(lblApellido);
            grbAgregarUsuario.Controls.Add(txtNombre);
            grbAgregarUsuario.Controls.Add(lblNombre);
            grbAgregarUsuario.Location = new Point(225, 57);
            grbAgregarUsuario.Margin = new Padding(3, 2, 3, 2);
            grbAgregarUsuario.Name = "grbAgregarUsuario";
            grbAgregarUsuario.Padding = new Padding(3, 2, 3, 2);
            grbAgregarUsuario.Size = new Size(734, 410);
            grbAgregarUsuario.TabIndex = 14;
            grbAgregarUsuario.TabStop = false;
            grbAgregarUsuario.Text = "Registar nuevo Clientes";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(383, 113);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(131, 112);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(40, 202);
            txtTelefono.Margin = new Padding(3, 2, 3, 2);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(279, 23);
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
            btnAgregar.Location = new Point(164, 338);
            btnAgregar.Margin = new Padding(4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(101, 30);
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
            btnCancelar.Location = new Point(383, 338);
            btnCancelar.Margin = new Padding(4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(101, 30);
            btnCancelar.TabIndex = 31;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // txtFechaNacimiento
            // 
            txtFechaNacimiento.Location = new Point(40, 282);
            txtFechaNacimiento.Margin = new Padding(3, 2, 3, 2);
            txtFechaNacimiento.Name = "txtFechaNacimiento";
            txtFechaNacimiento.Size = new Size(279, 23);
            txtFechaNacimiento.TabIndex = 30;
            // 
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.Location = new Point(40, 264);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new Size(101, 15);
            lblFechaNacimiento.TabIndex = 29;
            lblFechaNacimiento.Text = "Fecha nacimiento";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(40, 242);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(279, 23);
            txtEmail.TabIndex = 26;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(40, 224);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 25;
            lblEmail.Text = "Email";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(40, 184);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(52, 15);
            lblTelefono.TabIndex = 23;
            lblTelefono.Text = "Telefono";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(40, 163);
            txtDireccion.Margin = new Padding(3, 2, 3, 2);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(279, 23);
            txtDireccion.TabIndex = 22;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(40, 145);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(57, 15);
            lblDireccion.TabIndex = 21;
            lblDireccion.Text = "Dirección";
            // 
            // cmbHost
            // 
            cmbHost.FormattingEnabled = true;
            cmbHost.Location = new Point(383, 44);
            cmbHost.Margin = new Padding(3, 2, 3, 2);
            cmbHost.Name = "cmbHost";
            cmbHost.Size = new Size(132, 23);
            cmbHost.TabIndex = 20;
            // 
            // lblHost
            // 
            lblHost.AutoSize = true;
            lblHost.Location = new Point(383, 25);
            lblHost.Name = "lblHost";
            lblHost.Size = new Size(32, 15);
            lblHost.TabIndex = 18;
            lblHost.Text = "Host";
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(40, 123);
            txtDNI.Margin = new Padding(3, 2, 3, 2);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(279, 23);
            txtDNI.TabIndex = 17;
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Location = new Point(40, 105);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(27, 15);
            lblDNI.TabIndex = 16;
            lblDNI.Text = "DNI";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(40, 83);
            txtApellido.Margin = new Padding(3, 2, 3, 2);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(279, 23);
            txtApellido.TabIndex = 13;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(40, 65);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(51, 15);
            lblApellido.TabIndex = 12;
            lblApellido.Text = "Apellido";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(40, 44);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(279, 23);
            txtNombre.TabIndex = 11;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(40, 25);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 10;
            lblNombre.Text = "Nombre";
            // 
            // FormRegistrarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1165, 697);
            Controls.Add(pictureBox1);
            Controls.Add(grbAgregarUsuario);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormRegistrarCliente";
            Text = "FormRegistrarCliente";
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
        private ComboBox cmbHost;
        private Label lblHost;
        private TextBox txtDNI;
        private Label lblDNI;
        private TextBox txtApellido;
        private Label lblApellido;
        private TextBox txtNombre;
        private Label lblNombre;
    }
}