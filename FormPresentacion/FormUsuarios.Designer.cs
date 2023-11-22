namespace FormPresentacion
{
    partial class FormUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsuarios));
            grbDetalle = new GroupBox();
            btnLimpiarDetalle = new Button();
            txtIDUsuario = new TextBox();
            lblID = new Label();
            btnEditar = new Button();
            btnEliminar = new Button();
            txtHost = new TextBox();
            lblHost = new Label();
            txtDNI = new TextBox();
            lblDNI = new Label();
            txtUsuario = new TextBox();
            lblUsuario = new Label();
            txtApellido = new TextBox();
            lblApellido = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            lstUsuarios = new ListBox();
            btnVerDetalle = new Button();
            btnListar = new Button();
            btnLimpiar = new Button();
            btnAgregarUsuario = new Button();
            btnReactivarUsuario = new Button();
            btnUsuariosActivos = new Button();
            lstUsuariosActivos = new ListBox();
            grbUsuariosActivos = new GroupBox();
            btnCambiarContraseña = new Button();
            grbDetalle.SuspendLayout();
            grbUsuariosActivos.SuspendLayout();
            SuspendLayout();
            // 
            // grbDetalle
            // 
            grbDetalle.Controls.Add(btnLimpiarDetalle);
            grbDetalle.Controls.Add(txtIDUsuario);
            grbDetalle.Controls.Add(lblID);
            grbDetalle.Controls.Add(btnEditar);
            grbDetalle.Controls.Add(btnEliminar);
            grbDetalle.Controls.Add(txtHost);
            grbDetalle.Controls.Add(lblHost);
            grbDetalle.Controls.Add(txtDNI);
            grbDetalle.Controls.Add(lblDNI);
            grbDetalle.Controls.Add(txtUsuario);
            grbDetalle.Controls.Add(lblUsuario);
            grbDetalle.Controls.Add(txtApellido);
            grbDetalle.Controls.Add(lblApellido);
            grbDetalle.Controls.Add(txtNombre);
            grbDetalle.Controls.Add(lblNombre);
            grbDetalle.Location = new Point(374, 25);
            grbDetalle.Name = "grbDetalle";
            grbDetalle.Size = new Size(407, 565);
            grbDetalle.TabIndex = 6;
            grbDetalle.TabStop = false;
            grbDetalle.Text = "Detalle del usuario";
            // 
            // btnLimpiarDetalle
            // 
            btnLimpiarDetalle.BackColor = Color.DarkGray;
            btnLimpiarDetalle.FlatAppearance.BorderSize = 0;
            btnLimpiarDetalle.FlatAppearance.CheckedBackColor = Color.Black;
            btnLimpiarDetalle.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnLimpiarDetalle.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnLimpiarDetalle.FlatStyle = FlatStyle.Flat;
            btnLimpiarDetalle.Location = new Point(275, 512);
            btnLimpiarDetalle.Margin = new Padding(5, 5, 5, 5);
            btnLimpiarDetalle.Name = "btnLimpiarDetalle";
            btnLimpiarDetalle.Size = new Size(115, 40);
            btnLimpiarDetalle.TabIndex = 20;
            btnLimpiarDetalle.Text = "Limpiar";
            btnLimpiarDetalle.UseVisualStyleBackColor = false;
            btnLimpiarDetalle.Click += btnLimpiarDetalle_Click;
            // 
            // txtIDUsuario
            // 
            txtIDUsuario.Enabled = false;
            txtIDUsuario.Location = new Point(25, 68);
            txtIDUsuario.Name = "txtIDUsuario";
            txtIDUsuario.Size = new Size(346, 27);
            txtIDUsuario.TabIndex = 19;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(25, 35);
            lblID.Name = "lblID";
            lblID.Size = new Size(24, 20);
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
            btnEditar.Location = new Point(25, 512);
            btnEditar.Margin = new Padding(5, 5, 5, 5);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(115, 40);
            btnEditar.TabIndex = 17;
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
            btnEliminar.Location = new Point(150, 512);
            btnEliminar.Margin = new Padding(5, 5, 5, 5);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(115, 40);
            btnEliminar.TabIndex = 16;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtHost
            // 
            txtHost.Location = new Point(25, 465);
            txtHost.Name = "txtHost";
            txtHost.Size = new Size(94, 27);
            txtHost.TabIndex = 9;
            // 
            // lblHost
            // 
            lblHost.AutoSize = true;
            lblHost.Location = new Point(25, 432);
            lblHost.Name = "lblHost";
            lblHost.Size = new Size(40, 20);
            lblHost.TabIndex = 8;
            lblHost.Text = "Host";
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(25, 381);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(346, 27);
            txtDNI.TabIndex = 7;
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Location = new Point(25, 349);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(35, 20);
            lblDNI.TabIndex = 6;
            lblDNI.Text = "DNI";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(25, 303);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(346, 27);
            txtUsuario.TabIndex = 5;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(25, 269);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(59, 20);
            lblUsuario.TabIndex = 4;
            lblUsuario.Text = "Usuario";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(25, 213);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(346, 27);
            txtApellido.TabIndex = 3;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(25, 180);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(66, 20);
            lblApellido.TabIndex = 2;
            lblApellido.Text = "Apellido";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(25, 132);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(346, 27);
            txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(25, 99);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // lstUsuarios
            // 
            lstUsuarios.FormattingEnabled = true;
            lstUsuarios.ItemHeight = 20;
            lstUsuarios.Location = new Point(43, 25);
            lstUsuarios.Name = "lstUsuarios";
            lstUsuarios.Size = new Size(302, 504);
            lstUsuarios.TabIndex = 5;
            // 
            // btnVerDetalle
            // 
            btnVerDetalle.BackColor = Color.DarkGray;
            btnVerDetalle.FlatAppearance.BorderSize = 0;
            btnVerDetalle.FlatAppearance.CheckedBackColor = Color.Black;
            btnVerDetalle.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnVerDetalle.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnVerDetalle.FlatStyle = FlatStyle.Flat;
            btnVerDetalle.Location = new Point(208, 537);
            btnVerDetalle.Margin = new Padding(5, 5, 5, 5);
            btnVerDetalle.Name = "btnVerDetalle";
            btnVerDetalle.Size = new Size(115, 40);
            btnVerDetalle.TabIndex = 4;
            btnVerDetalle.Text = "Ver detalle";
            btnVerDetalle.UseVisualStyleBackColor = false;
            btnVerDetalle.Click += btnVerDetalle_Click;
            // 
            // btnListar
            // 
            btnListar.BackColor = Color.DarkGray;
            btnListar.FlatAppearance.BorderSize = 0;
            btnListar.FlatAppearance.CheckedBackColor = Color.Black;
            btnListar.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnListar.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnListar.FlatStyle = FlatStyle.Flat;
            btnListar.Location = new Point(64, 537);
            btnListar.Margin = new Padding(5, 5, 5, 5);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(115, 40);
            btnListar.TabIndex = 7;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = false;
            btnListar.Click += btnListar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.DarkGray;
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatAppearance.CheckedBackColor = Color.Black;
            btnLimpiar.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnLimpiar.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Location = new Point(133, 587);
            btnLimpiar.Margin = new Padding(5, 5, 5, 5);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(115, 40);
            btnLimpiar.TabIndex = 8;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnAgregarUsuario
            // 
            btnAgregarUsuario.BackColor = Color.DarkGray;
            btnAgregarUsuario.FlatAppearance.BorderColor = Color.FromArgb(192, 192, 255);
            btnAgregarUsuario.FlatAppearance.CheckedBackColor = Color.Black;
            btnAgregarUsuario.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnAgregarUsuario.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            btnAgregarUsuario.FlatStyle = FlatStyle.Flat;
            btnAgregarUsuario.Location = new Point(838, 40);
            btnAgregarUsuario.Margin = new Padding(5, 5, 5, 5);
            btnAgregarUsuario.Name = "btnAgregarUsuario";
            btnAgregarUsuario.Size = new Size(255, 40);
            btnAgregarUsuario.TabIndex = 21;
            btnAgregarUsuario.Text = "Agregar usuario";
            btnAgregarUsuario.UseVisualStyleBackColor = false;
            btnAgregarUsuario.Click += btnAgregarUsuario_Click;
            // 
            // btnReactivarUsuario
            // 
            btnReactivarUsuario.BackColor = Color.DarkGray;
            btnReactivarUsuario.FlatAppearance.BorderColor = Color.FromArgb(192, 192, 255);
            btnReactivarUsuario.FlatAppearance.CheckedBackColor = Color.Black;
            btnReactivarUsuario.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnReactivarUsuario.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            btnReactivarUsuario.FlatStyle = FlatStyle.Flat;
            btnReactivarUsuario.Location = new Point(838, 93);
            btnReactivarUsuario.Margin = new Padding(5, 5, 5, 5);
            btnReactivarUsuario.Name = "btnReactivarUsuario";
            btnReactivarUsuario.Size = new Size(255, 40);
            btnReactivarUsuario.TabIndex = 22;
            btnReactivarUsuario.Text = "Reactivar usuario";
            btnReactivarUsuario.UseVisualStyleBackColor = false;
            btnReactivarUsuario.Click += btnReactivarUsuario_Click_1;
            // 
            // btnUsuariosActivos
            // 
            btnUsuariosActivos.BackColor = Color.DarkGray;
            btnUsuariosActivos.FlatAppearance.BorderColor = Color.FromArgb(192, 192, 255);
            btnUsuariosActivos.FlatAppearance.CheckedBackColor = Color.Black;
            btnUsuariosActivos.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnUsuariosActivos.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            btnUsuariosActivos.FlatStyle = FlatStyle.Flat;
            btnUsuariosActivos.Location = new Point(40, 317);
            btnUsuariosActivos.Margin = new Padding(5, 5, 5, 5);
            btnUsuariosActivos.Name = "btnUsuariosActivos";
            btnUsuariosActivos.Size = new Size(255, 40);
            btnUsuariosActivos.TabIndex = 23;
            btnUsuariosActivos.Text = "Listar usuarios activos";
            btnUsuariosActivos.UseVisualStyleBackColor = false;
            // 
            // lstUsuariosActivos
            // 
            lstUsuariosActivos.FormattingEnabled = true;
            lstUsuariosActivos.ItemHeight = 20;
            lstUsuariosActivos.Location = new Point(19, 27);
            lstUsuariosActivos.Name = "lstUsuariosActivos";
            lstUsuariosActivos.Size = new Size(295, 284);
            lstUsuariosActivos.TabIndex = 24;
            // 
            // grbUsuariosActivos
            // 
            grbUsuariosActivos.Controls.Add(lstUsuariosActivos);
            grbUsuariosActivos.Controls.Add(btnUsuariosActivos);
            grbUsuariosActivos.Location = new Point(798, 220);
            grbUsuariosActivos.Name = "grbUsuariosActivos";
            grbUsuariosActivos.Size = new Size(337, 371);
            grbUsuariosActivos.TabIndex = 25;
            grbUsuariosActivos.TabStop = false;
            grbUsuariosActivos.Text = "Usuarios Activos";
            // 
            // btnCambiarContraseña
            // 
            btnCambiarContraseña.BackColor = Color.DarkGray;
            btnCambiarContraseña.FlatAppearance.BorderColor = Color.FromArgb(192, 192, 255);
            btnCambiarContraseña.FlatAppearance.CheckedBackColor = Color.Black;
            btnCambiarContraseña.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnCambiarContraseña.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            btnCambiarContraseña.FlatStyle = FlatStyle.Flat;
            btnCambiarContraseña.Location = new Point(838, 149);
            btnCambiarContraseña.Margin = new Padding(5, 5, 5, 5);
            btnCambiarContraseña.Name = "btnCambiarContraseña";
            btnCambiarContraseña.Size = new Size(255, 40);
            btnCambiarContraseña.TabIndex = 26;
            btnCambiarContraseña.Text = "Cambiar contraseña";
            btnCambiarContraseña.UseVisualStyleBackColor = false;
            // 
            // FormUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1147, 651);
            Controls.Add(btnCambiarContraseña);
            Controls.Add(grbUsuariosActivos);
            Controls.Add(btnReactivarUsuario);
            Controls.Add(btnAgregarUsuario);
            Controls.Add(btnLimpiar);
            Controls.Add(btnListar);
            Controls.Add(grbDetalle);
            Controls.Add(lstUsuarios);
            Controls.Add(btnVerDetalle);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormUsuarios";
            Text = "Usuarios";
            Load += FormUsuarios_Load;
            grbDetalle.ResumeLayout(false);
            grbDetalle.PerformLayout();
            grbUsuariosActivos.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbDetalle;
        private TextBox txtDNI;
        private Label lblDNI;
        private TextBox txtUsuario;
        private Label lblUsuario;
        private TextBox txtApellido;
        private Label lblApellido;
        private TextBox txtNombre;
        private Label lblNombre;
        private ListBox lstUsuarios;
        private Button btnVerDetalle;
        private Button btnListar;
        private Button btnLimpiar;
        private TextBox txtHost;
        private Label lblHost;
        private Button btnEditar;
        private Button btnEliminar;
        private TextBox txtIDUsuario;
        private Label lblID;
        private Button btnLimpiarDetalle;
        private Button btnAgregarUsuario;
        private Button btnReactivarUsuario;
        private Button btnUsuariosActivos;
        private ListBox lstUsuariosActivos;
        private GroupBox grbUsuariosActivos;
        private Button btnCambiarContraseña;
    }
}