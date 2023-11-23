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
            grbDetalle.Size = new Size(407, 443);
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
            btnLimpiarDetalle.Location = new Point(275, 389);
            btnLimpiarDetalle.Margin = new Padding(5);
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
            lblID.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblID.Location = new Point(25, 45);
            lblID.Name = "lblID";
            lblID.Size = new Size(25, 20);
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
            btnEditar.Location = new Point(25, 389);
            btnEditar.Margin = new Padding(5);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(115, 40);
            btnEditar.TabIndex = 17;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.DarkGray;
            btnEliminar.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            btnEliminar.FlatAppearance.CheckedBackColor = Color.Black;
            btnEliminar.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnEliminar.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 192);
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Location = new Point(150, 389);
            btnEliminar.Margin = new Padding(5);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(115, 40);
            btnEliminar.TabIndex = 16;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtHost
            // 
            txtHost.Location = new Point(25, 336);
            txtHost.Name = "txtHost";
            txtHost.Size = new Size(94, 27);
            txtHost.TabIndex = 9;
            // 
            // lblHost
            // 
            lblHost.AutoSize = true;
            lblHost.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblHost.Location = new Point(26, 313);
            lblHost.Name = "lblHost";
            lblHost.Size = new Size(42, 20);
            lblHost.TabIndex = 8;
            lblHost.Text = "Host";
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(25, 281);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(346, 27);
            txtDNI.TabIndex = 7;
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblDNI.Location = new Point(25, 258);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(37, 20);
            lblDNI.TabIndex = 6;
            lblDNI.Text = "DNI";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(25, 227);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(346, 27);
            txtUsuario.TabIndex = 5;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsuario.Location = new Point(25, 204);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(63, 20);
            lblUsuario.TabIndex = 4;
            lblUsuario.Text = "Usuario";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(25, 174);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(346, 27);
            txtApellido.TabIndex = 3;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblApellido.Location = new Point(26, 151);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(67, 20);
            lblApellido.TabIndex = 2;
            lblApellido.Text = "Apellido";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(25, 121);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(346, 27);
            txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.Location = new Point(25, 98);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
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
            btnVerDetalle.Margin = new Padding(5);
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
            btnListar.Margin = new Padding(5);
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
            btnLimpiar.Margin = new Padding(5);
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
            btnAgregarUsuario.Location = new Point(816, 40);
            btnAgregarUsuario.Margin = new Padding(5);
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
            btnReactivarUsuario.Location = new Point(26, 97);
            btnReactivarUsuario.Margin = new Padding(5);
            btnReactivarUsuario.Name = "btnReactivarUsuario";
            btnReactivarUsuario.Size = new Size(152, 40);
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
            btnUsuariosActivos.Location = new Point(29, 414);
            btnUsuariosActivos.Margin = new Padding(5);
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
            lstUsuariosActivos.Location = new Point(16, 30);
            lstUsuariosActivos.Name = "lstUsuariosActivos";
            lstUsuariosActivos.Size = new Size(279, 364);
            lstUsuariosActivos.TabIndex = 24;
            // 
            // grbUsuariosActivos
            // 
            grbUsuariosActivos.Controls.Add(lstUsuariosActivos);
            grbUsuariosActivos.Controls.Add(btnUsuariosActivos);
            grbUsuariosActivos.Location = new Point(787, 159);
            grbUsuariosActivos.Name = "grbUsuariosActivos";
            grbUsuariosActivos.Size = new Size(315, 468);
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
            btnCambiarContraseña.Location = new Point(816, 93);
            btnCambiarContraseña.Margin = new Padding(5);
            btnCambiarContraseña.Name = "btnCambiarContraseña";
            btnCambiarContraseña.Size = new Size(255, 40);
            btnCambiarContraseña.TabIndex = 26;
            btnCambiarContraseña.Text = "Cambiar contraseña";
            btnCambiarContraseña.UseVisualStyleBackColor = false;
            // 
            // grbCambiosEstado
            // 
            grbCambiosEstado.Controls.Add(lblUsuarioCambioEstado);
            grbCambiosEstado.Controls.Add(txtUsuarioCambioEstado);
            grbCambiosEstado.Controls.Add(btnInhabiliarUsuario);
            grbCambiosEstado.Controls.Add(btnReactivarUsuario);
            grbCambiosEstado.Location = new Point(374, 476);
            grbCambiosEstado.Name = "grbCambiosEstado";
            grbCambiosEstado.Size = new Size(407, 151);
            grbCambiosEstado.TabIndex = 27;
            grbCambiosEstado.TabStop = false;
            grbCambiosEstado.Text = "Cambios de estado";
            // 
            // lblUsuarioCambioEstado
            // 
            lblUsuarioCambioEstado.AutoSize = true;
            lblUsuarioCambioEstado.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsuarioCambioEstado.Location = new Point(25, 34);
            lblUsuarioCambioEstado.Name = "lblUsuarioCambioEstado";
            lblUsuarioCambioEstado.Size = new Size(139, 20);
            lblUsuarioCambioEstado.TabIndex = 21;
            lblUsuarioCambioEstado.Text = "Ingrese el Usuario:";
            // 
            // txtUsuarioCambioEstado
            // 
            txtUsuarioCambioEstado.Location = new Point(25, 57);
            txtUsuarioCambioEstado.Name = "txtUsuarioCambioEstado";
            txtUsuarioCambioEstado.Size = new Size(346, 27);
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
            btnInhabiliarUsuario.Location = new Point(217, 97);
            btnInhabiliarUsuario.Margin = new Padding(5);
            btnInhabiliarUsuario.Name = "btnInhabiliarUsuario";
            btnInhabiliarUsuario.Size = new Size(154, 40);
            btnInhabiliarUsuario.TabIndex = 23;
            btnInhabiliarUsuario.Text = "Inhabilitar usuario";
            btnInhabiliarUsuario.UseVisualStyleBackColor = false;
            btnInhabiliarUsuario.Click += btnInhabiliarUsuario_Click;
            // 
            // FormUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1147, 651);
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
        private Button btnEditar;
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