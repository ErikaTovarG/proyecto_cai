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
            grbCambiosEstado = new GroupBox();
            lblUsuarioCambioEstado = new Label();
            txtUsuarioCambioEstado = new TextBox();
            btnInhabiliarUsuario = new Button();
            grbDetalle.SuspendLayout();
            grbUsuariosActivos.SuspendLayout();
            grbCambiosEstado.SuspendLayout();
            SuspendLayout();
            // 
            // grbDetalle
            // 
            grbDetalle.Controls.Add(btnLimpiarDetalle);
            grbDetalle.Controls.Add(txtIDUsuario);
            grbDetalle.Controls.Add(lblID);
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
            grbDetalle.Location = new Point(327, 19);
            grbDetalle.Margin = new Padding(3, 2, 3, 2);
            grbDetalle.Name = "grbDetalle";
            grbDetalle.Padding = new Padding(3, 2, 3, 2);
            grbDetalle.Size = new Size(356, 332);
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
            btnLimpiarDetalle.Location = new Point(189, 287);
            btnLimpiarDetalle.Margin = new Padding(4, 4, 4, 4);
            btnLimpiarDetalle.Name = "btnLimpiarDetalle";
            btnLimpiarDetalle.Size = new Size(101, 30);
            btnLimpiarDetalle.TabIndex = 20;
            btnLimpiarDetalle.Text = "Limpiar";
            btnLimpiarDetalle.UseVisualStyleBackColor = false;
            btnLimpiarDetalle.Click += btnLimpiarDetalle_Click;
            // 
            // txtIDUsuario
            // 
            txtIDUsuario.Enabled = false;
            txtIDUsuario.Location = new Point(22, 51);
            txtIDUsuario.Margin = new Padding(3, 2, 3, 2);
            txtIDUsuario.Name = "txtIDUsuario";
            txtIDUsuario.Size = new Size(303, 23);
            txtIDUsuario.TabIndex = 19;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblID.Location = new Point(22, 34);
            lblID.Name = "lblID";
            lblID.Size = new Size(20, 15);
            lblID.TabIndex = 18;
            lblID.Text = "ID";
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.DarkGray;
            btnEliminar.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            btnEliminar.FlatAppearance.CheckedBackColor = Color.Black;
            btnEliminar.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnEliminar.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 192);
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Location = new Point(79, 287);
            btnEliminar.Margin = new Padding(4, 4, 4, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(101, 30);
            btnEliminar.TabIndex = 16;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtHost
            // 
            txtHost.Enabled = false;
            txtHost.Location = new Point(22, 252);
            txtHost.Margin = new Padding(3, 2, 3, 2);
            txtHost.Name = "txtHost";
            txtHost.Size = new Size(83, 23);
            txtHost.TabIndex = 9;
            // 
            // lblHost
            // 
            lblHost.AutoSize = true;
            lblHost.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblHost.Location = new Point(23, 235);
            lblHost.Name = "lblHost";
            lblHost.Size = new Size(33, 15);
            lblHost.TabIndex = 8;
            lblHost.Text = "Host";
            // 
            // txtDNI
            // 
            txtDNI.Enabled = false;
            txtDNI.Location = new Point(22, 211);
            txtDNI.Margin = new Padding(3, 2, 3, 2);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(303, 23);
            txtDNI.TabIndex = 7;
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblDNI.Location = new Point(22, 194);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(29, 15);
            lblDNI.TabIndex = 6;
            lblDNI.Text = "DNI";
            // 
            // txtUsuario
            // 
            txtUsuario.Enabled = false;
            txtUsuario.Location = new Point(22, 170);
            txtUsuario.Margin = new Padding(3, 2, 3, 2);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(303, 23);
            txtUsuario.TabIndex = 5;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsuario.Location = new Point(22, 153);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(49, 15);
            lblUsuario.TabIndex = 4;
            lblUsuario.Text = "Usuario";
            // 
            // txtApellido
            // 
            txtApellido.Enabled = false;
            txtApellido.Location = new Point(22, 130);
            txtApellido.Margin = new Padding(3, 2, 3, 2);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(303, 23);
            txtApellido.TabIndex = 3;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblApellido.Location = new Point(23, 114);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(52, 15);
            lblApellido.TabIndex = 2;
            lblApellido.Text = "Apellido";
            // 
            // txtNombre
            // 
            txtNombre.Enabled = false;
            txtNombre.Location = new Point(22, 91);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(303, 23);
            txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.Location = new Point(22, 74);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(53, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // lstUsuarios
            // 
            lstUsuarios.FormattingEnabled = true;
            lstUsuarios.ItemHeight = 15;
            lstUsuarios.Location = new Point(38, 19);
            lstUsuarios.Margin = new Padding(3, 2, 3, 2);
            lstUsuarios.Name = "lstUsuarios";
            lstUsuarios.Size = new Size(265, 379);
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
            btnVerDetalle.Location = new Point(182, 403);
            btnVerDetalle.Margin = new Padding(4, 4, 4, 4);
            btnVerDetalle.Name = "btnVerDetalle";
            btnVerDetalle.Size = new Size(101, 30);
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
            btnListar.Location = new Point(56, 403);
            btnListar.Margin = new Padding(4, 4, 4, 4);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(101, 30);
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
            btnLimpiar.Location = new Point(116, 440);
            btnLimpiar.Margin = new Padding(4, 4, 4, 4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(101, 30);
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
            btnAgregarUsuario.Location = new Point(714, 30);
            btnAgregarUsuario.Margin = new Padding(4, 4, 4, 4);
            btnAgregarUsuario.Name = "btnAgregarUsuario";
            btnAgregarUsuario.Size = new Size(223, 30);
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
            btnReactivarUsuario.Location = new Point(23, 73);
            btnReactivarUsuario.Margin = new Padding(4, 4, 4, 4);
            btnReactivarUsuario.Name = "btnReactivarUsuario";
            btnReactivarUsuario.Size = new Size(133, 30);
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
            btnUsuariosActivos.Location = new Point(25, 310);
            btnUsuariosActivos.Margin = new Padding(4, 4, 4, 4);
            btnUsuariosActivos.Name = "btnUsuariosActivos";
            btnUsuariosActivos.Size = new Size(223, 30);
            btnUsuariosActivos.TabIndex = 23;
            btnUsuariosActivos.Text = "Listar usuarios activos";
            btnUsuariosActivos.UseVisualStyleBackColor = false;
            btnUsuariosActivos.Click += btnUsuariosActivos_Click;
            // 
            // lstUsuariosActivos
            // 
            lstUsuariosActivos.FormattingEnabled = true;
            lstUsuariosActivos.ItemHeight = 15;
            lstUsuariosActivos.Location = new Point(14, 22);
            lstUsuariosActivos.Margin = new Padding(3, 2, 3, 2);
            lstUsuariosActivos.Name = "lstUsuariosActivos";
            lstUsuariosActivos.Size = new Size(245, 274);
            lstUsuariosActivos.TabIndex = 24;
            // 
            // grbUsuariosActivos
            // 
            grbUsuariosActivos.Controls.Add(lstUsuariosActivos);
            grbUsuariosActivos.Controls.Add(btnUsuariosActivos);
            grbUsuariosActivos.Location = new Point(689, 119);
            grbUsuariosActivos.Margin = new Padding(3, 2, 3, 2);
            grbUsuariosActivos.Name = "grbUsuariosActivos";
            grbUsuariosActivos.Padding = new Padding(3, 2, 3, 2);
            grbUsuariosActivos.Size = new Size(276, 351);
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
            btnCambiarContraseña.Location = new Point(714, 70);
            btnCambiarContraseña.Margin = new Padding(4, 4, 4, 4);
            btnCambiarContraseña.Name = "btnCambiarContraseña";
            btnCambiarContraseña.Size = new Size(223, 30);
            btnCambiarContraseña.TabIndex = 26;
            btnCambiarContraseña.Text = "Cambiar contraseña";
            btnCambiarContraseña.UseVisualStyleBackColor = false;
            btnCambiarContraseña.Visible = false;
            // 
            // grbCambiosEstado
            // 
            grbCambiosEstado.Controls.Add(lblUsuarioCambioEstado);
            grbCambiosEstado.Controls.Add(txtUsuarioCambioEstado);
            grbCambiosEstado.Controls.Add(btnInhabiliarUsuario);
            grbCambiosEstado.Controls.Add(btnReactivarUsuario);
            grbCambiosEstado.Location = new Point(327, 357);
            grbCambiosEstado.Margin = new Padding(3, 2, 3, 2);
            grbCambiosEstado.Name = "grbCambiosEstado";
            grbCambiosEstado.Padding = new Padding(3, 2, 3, 2);
            grbCambiosEstado.Size = new Size(356, 113);
            grbCambiosEstado.TabIndex = 27;
            grbCambiosEstado.TabStop = false;
            grbCambiosEstado.Text = "Cambios de estado";
            // 
            // lblUsuarioCambioEstado
            // 
            lblUsuarioCambioEstado.AutoSize = true;
            lblUsuarioCambioEstado.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsuarioCambioEstado.Location = new Point(22, 26);
            lblUsuarioCambioEstado.Name = "lblUsuarioCambioEstado";
            lblUsuarioCambioEstado.Size = new Size(110, 15);
            lblUsuarioCambioEstado.TabIndex = 21;
            lblUsuarioCambioEstado.Text = "Ingrese el Usuario:";
            // 
            // txtUsuarioCambioEstado
            // 
            txtUsuarioCambioEstado.Location = new Point(22, 43);
            txtUsuarioCambioEstado.Margin = new Padding(3, 2, 3, 2);
            txtUsuarioCambioEstado.Name = "txtUsuarioCambioEstado";
            txtUsuarioCambioEstado.Size = new Size(303, 23);
            txtUsuarioCambioEstado.TabIndex = 21;
            // 
            // btnInhabiliarUsuario
            // 
            btnInhabiliarUsuario.BackColor = Color.DarkGray;
            btnInhabiliarUsuario.FlatAppearance.BorderColor = Color.FromArgb(192, 192, 255);
            btnInhabiliarUsuario.FlatAppearance.CheckedBackColor = Color.Black;
            btnInhabiliarUsuario.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnInhabiliarUsuario.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            btnInhabiliarUsuario.FlatStyle = FlatStyle.Flat;
            btnInhabiliarUsuario.Location = new Point(190, 73);
            btnInhabiliarUsuario.Margin = new Padding(4, 4, 4, 4);
            btnInhabiliarUsuario.Name = "btnInhabiliarUsuario";
            btnInhabiliarUsuario.Size = new Size(135, 30);
            btnInhabiliarUsuario.TabIndex = 23;
            btnInhabiliarUsuario.Text = "Inhabilitar usuario";
            btnInhabiliarUsuario.UseVisualStyleBackColor = false;
            btnInhabiliarUsuario.Click += btnInhabiliarUsuario_Click;
            // 
            // FormUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1004, 488);
            Controls.Add(grbCambiosEstado);
            Controls.Add(btnCambiarContraseña);
            Controls.Add(grbUsuariosActivos);
            Controls.Add(btnAgregarUsuario);
            Controls.Add(btnLimpiar);
            Controls.Add(btnListar);
            Controls.Add(grbDetalle);
            Controls.Add(lstUsuarios);
            Controls.Add(btnVerDetalle);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormUsuarios";
            Text = "Usuarios";
            Load += FormUsuarios_Load;
            grbDetalle.ResumeLayout(false);
            grbDetalle.PerformLayout();
            grbUsuariosActivos.ResumeLayout(false);
            grbCambiosEstado.ResumeLayout(false);
            grbCambiosEstado.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbDetalle;
        private Label lblDNI;
        private Label lblUsuario;
        private Label lblApellido;
        private Label lblNombre;
        private Button btnVerDetalle;
        private Button btnListar;
        private Button btnLimpiar;
        private Label lblHost;
        private Button btnEliminar;
        private Label lblID;
        private Button btnLimpiarDetalle;
        private Button btnAgregarUsuario;
        private Button btnReactivarUsuario;
        private Button btnUsuariosActivos;
        private ListBox lstUsuariosActivos;
        private GroupBox grbUsuariosActivos;
        private Button btnCambiarContraseña;
        public TextBox txtIDUsuario;
        public ListBox lstUsuarios;
        public TextBox txtDNI;
        public TextBox txtApellido;
        public TextBox txtNombre;
        public TextBox txtHost;
        public TextBox txtUsuario;
        private GroupBox grbCambiosEstado;
        private Button btnInhabiliarUsuario;
        private Label lblUsuarioCambioEstado;
        public TextBox txtUsuarioCambioEstado;
    }
}