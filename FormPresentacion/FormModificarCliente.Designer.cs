namespace FormPresentacion
{
    partial class FormModificarCliente
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
            btnLimpiar = new Button();
            btnListar = new Button();
            btnVerDetalle = new Button();
            grbDetalle = new GroupBox();
            txtDireccion = new TextBox();
            label1 = new Label();
            txtHost = new TextBox();
            label3 = new Label();
            txtFechaNacimiento = new TextBox();
            label4 = new Label();
            txtTelefono = new TextBox();
            label5 = new Label();
            btnLimpiarCmb = new Button();
            txtIDCliente = new TextBox();
            lblID = new Label();
            btnEditar = new Button();
            txtDni = new TextBox();
            lblCuit = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtApellido = new TextBox();
            lblApellido = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            lstClientes = new ListBox();
            grbDetalle.SuspendLayout();
            SuspendLayout();
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.DarkGray;
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatAppearance.CheckedBackColor = Color.Black;
            btnLimpiar.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnLimpiar.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Location = new Point(116, 470);
            btnLimpiar.Margin = new Padding(4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(101, 30);
            btnLimpiar.TabIndex = 16;
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
            btnListar.Location = new Point(57, 432);
            btnListar.Margin = new Padding(4);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(101, 30);
            btnListar.TabIndex = 15;
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
            btnVerDetalle.Location = new Point(183, 432);
            btnVerDetalle.Margin = new Padding(4);
            btnVerDetalle.Name = "btnVerDetalle";
            btnVerDetalle.Size = new Size(101, 30);
            btnVerDetalle.TabIndex = 14;
            btnVerDetalle.Text = "Ver detalle";
            btnVerDetalle.UseVisualStyleBackColor = false;
            btnVerDetalle.Click += btnVerDetalle_Click;
            // 
            // grbDetalle
            // 
            grbDetalle.Controls.Add(txtDireccion);
            grbDetalle.Controls.Add(label1);
            grbDetalle.Controls.Add(txtHost);
            grbDetalle.Controls.Add(label3);
            grbDetalle.Controls.Add(txtFechaNacimiento);
            grbDetalle.Controls.Add(label4);
            grbDetalle.Controls.Add(txtTelefono);
            grbDetalle.Controls.Add(label5);
            grbDetalle.Controls.Add(btnLimpiarCmb);
            grbDetalle.Controls.Add(txtIDCliente);
            grbDetalle.Controls.Add(lblID);
            grbDetalle.Controls.Add(btnEditar);
            grbDetalle.Controls.Add(txtDni);
            grbDetalle.Controls.Add(lblCuit);
            grbDetalle.Controls.Add(txtEmail);
            grbDetalle.Controls.Add(lblEmail);
            grbDetalle.Controls.Add(txtApellido);
            grbDetalle.Controls.Add(lblApellido);
            grbDetalle.Controls.Add(txtNombre);
            grbDetalle.Controls.Add(lblNombre);
            grbDetalle.Location = new Point(335, 48);
            grbDetalle.Margin = new Padding(3, 2, 3, 2);
            grbDetalle.Name = "grbDetalle";
            grbDetalle.Padding = new Padding(3, 2, 3, 2);
            grbDetalle.Size = new Size(590, 428);
            grbDetalle.TabIndex = 13;
            grbDetalle.TabStop = false;
            grbDetalle.Text = "Detalle del Cliente";
            // 
            // txtDireccion
            // 
            txtDireccion.Enabled = false;
            txtDireccion.Location = new Point(313, 63);
            txtDireccion.Margin = new Padding(3, 2, 3, 2);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(242, 23);
            txtDireccion.TabIndex = 30;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(313, 37);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 29;
            label1.Text = "Direccion";
            // 
            // txtHost
            // 
            txtHost.Location = new Point(313, 222);
            txtHost.Margin = new Padding(3, 2, 3, 2);
            txtHost.Name = "txtHost";
            txtHost.Size = new Size(242, 23);
            txtHost.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(313, 196);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 25;
            label3.Text = "Host";
            // 
            // txtFechaNacimiento
            // 
            txtFechaNacimiento.Location = new Point(313, 166);
            txtFechaNacimiento.Margin = new Padding(3, 2, 3, 2);
            txtFechaNacimiento.Name = "txtFechaNacimiento";
            txtFechaNacimiento.Size = new Size(242, 23);
            txtFechaNacimiento.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(313, 141);
            label4.Name = "label4";
            label4.Size = new Size(103, 15);
            label4.TabIndex = 23;
            label4.Text = "Fecha Nacimiento";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(313, 112);
            txtTelefono.Margin = new Padding(3, 2, 3, 2);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(242, 23);
            txtTelefono.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(313, 87);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 21;
            label5.Text = "Telefono";
            // 
            // btnLimpiarCmb
            // 
            btnLimpiarCmb.BackColor = Color.DarkGray;
            btnLimpiarCmb.FlatAppearance.BorderSize = 0;
            btnLimpiarCmb.FlatAppearance.CheckedBackColor = Color.Black;
            btnLimpiarCmb.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnLimpiarCmb.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnLimpiarCmb.FlatStyle = FlatStyle.Flat;
            btnLimpiarCmb.Location = new Point(386, 384);
            btnLimpiarCmb.Margin = new Padding(4);
            btnLimpiarCmb.Name = "btnLimpiarCmb";
            btnLimpiarCmb.Size = new Size(101, 30);
            btnLimpiarCmb.TabIndex = 20;
            btnLimpiarCmb.Text = "Limpiar";
            btnLimpiarCmb.UseVisualStyleBackColor = false;
            btnLimpiarCmb.Click += btnLimpiarCmb_Click;
            // 
            // txtIDCliente
            // 
            txtIDCliente.Enabled = false;
            txtIDCliente.Location = new Point(37, 63);
            txtIDCliente.Margin = new Padding(3, 2, 3, 2);
            txtIDCliente.Name = "txtIDCliente";
            txtIDCliente.Size = new Size(251, 23);
            txtIDCliente.TabIndex = 19;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(37, 37);
            lblID.Name = "lblID";
            lblID.Size = new Size(18, 15);
            lblID.TabIndex = 18;
            lblID.Text = "ID";
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.DarkGray;
            btnEditar.FlatAppearance.BorderColor = Color.FromArgb(192, 192, 255);
            btnEditar.FlatAppearance.CheckedBackColor = Color.Black;
            btnEditar.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnEditar.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Location = new Point(125, 384);
            btnEditar.Margin = new Padding(4);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(101, 30);
            btnEditar.TabIndex = 17;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(37, 280);
            txtDni.Margin = new Padding(3, 2, 3, 2);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(251, 23);
            txtDni.TabIndex = 7;
            // 
            // lblCuit
            // 
            lblCuit.AutoSize = true;
            lblCuit.Location = new Point(37, 255);
            lblCuit.Name = "lblCuit";
            lblCuit.Size = new Size(27, 15);
            lblCuit.TabIndex = 6;
            lblCuit.Text = "DNI";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(37, 222);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(251, 23);
            txtEmail.TabIndex = 5;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(37, 196);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(37, 166);
            txtApellido.Margin = new Padding(3, 2, 3, 2);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(251, 23);
            txtApellido.TabIndex = 3;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(37, 141);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(51, 15);
            lblApellido.TabIndex = 2;
            lblApellido.Text = "Apellido";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(37, 112);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(251, 23);
            txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(37, 87);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // lstClientes
            // 
            lstClientes.FormattingEnabled = true;
            lstClientes.ItemHeight = 15;
            lstClientes.Location = new Point(38, 48);
            lstClientes.Margin = new Padding(3, 2, 3, 2);
            lstClientes.Name = "lstClientes";
            lstClientes.Size = new Size(265, 379);
            lstClientes.TabIndex = 12;
            // 
            // FormModificarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1149, 658);
            Controls.Add(btnLimpiar);
            Controls.Add(btnListar);
            Controls.Add(btnVerDetalle);
            Controls.Add(grbDetalle);
            Controls.Add(lstClientes);
            Name = "FormModificarCliente";
            Text = "FormModificarCliente";
            grbDetalle.ResumeLayout(false);
            grbDetalle.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnLimpiar;
        private Button btnListar;
        private Button btnVerDetalle;
        private GroupBox grbDetalle;
        private Button btnLimpiarCmb;
        private TextBox txtIDCliente;
        private Label lblID;
        private Button btnEditar;
        private TextBox txtDni;
        private Label lblCuit;
        private TextBox txtEmail;
        private Label lblEmail;
        private TextBox txtApellido;
        private Label lblApellido;
        private TextBox txtNombre;
        private Label lblNombre;
        private ListBox lstClientes;
        private TextBox txtDireccion;
        private Label label1;
        private TextBox txtHost;
        private Label label3;
        private TextBox txtFechaNacimiento;
        private Label label4;
        private TextBox txtTelefono;
        private Label label5;
    }
}