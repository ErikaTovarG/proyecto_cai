namespace FormPresentacion
{
    partial class FormListarUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListarUsuarios));
            grbDetalle = new GroupBox();
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
            btnEditar = new Button();
            btnEliminar = new Button();
            txtIDUsuario = new TextBox();
            lblID = new Label();
            grbDetalle.SuspendLayout();
            SuspendLayout();
            // 
            // grbDetalle
            // 
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
            grbDetalle.Location = new Point(518, 25);
            grbDetalle.Name = "grbDetalle";
            grbDetalle.Size = new Size(575, 570);
            grbDetalle.TabIndex = 6;
            grbDetalle.TabStop = false;
            grbDetalle.Text = "Detalle del usuario";
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
            txtDNI.Location = new Point(25, 382);
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
            lblUsuario.Location = new Point(25, 270);
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
            btnVerDetalle.Margin = new Padding(5);
            btnVerDetalle.Name = "btnVerDetalle";
            btnVerDetalle.Size = new Size(115, 40);
            btnVerDetalle.TabIndex = 4;
            btnVerDetalle.Text = "Ver detalle";
            btnVerDetalle.UseVisualStyleBackColor = false;
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
            btnLimpiar.Location = new Point(132, 587);
            btnLimpiar.Margin = new Padding(5);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(115, 40);
            btnLimpiar.TabIndex = 8;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.DarkGray;
            btnEditar.FlatAppearance.BorderColor = Color.FromArgb(192, 192, 255);
            btnEditar.FlatAppearance.CheckedBackColor = Color.Black;
            btnEditar.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnEditar.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Location = new Point(42, 512);
            btnEditar.Margin = new Padding(5);
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
            btnEliminar.Location = new Point(186, 512);
            btnEliminar.Margin = new Padding(5);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(115, 40);
            btnEliminar.TabIndex = 16;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
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
            // FormListarUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1147, 650);
            Controls.Add(btnLimpiar);
            Controls.Add(btnListar);
            Controls.Add(grbDetalle);
            Controls.Add(lstUsuarios);
            Controls.Add(btnVerDetalle);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormListarUsuarios";
            Text = "Listado de Usuarios";
            grbDetalle.ResumeLayout(false);
            grbDetalle.PerformLayout();
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
    }
}