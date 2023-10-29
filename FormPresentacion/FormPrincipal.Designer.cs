namespace FormPresentacion
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            panelTitulo = new Panel();
            btnMinimizar = new PictureBox();
            btnCerrar = new PictureBox();
            panelMenu = new Panel();
            btnListarProductos = new Button();
            btnListarProveedores = new Button();
            btnListarUsuarios = new Button();
            btnBajaProveedor = new Button();
            btnBajaUsuario = new Button();
            btnAddSupplier = new Button();
            btnAddUser = new Button();
            panelFormularios = new Panel();
            pictureBox1 = new PictureBox();
            panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            panelMenu.SuspendLayout();
            panelFormularios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelTitulo
            // 
            panelTitulo.BackColor = Color.PowderBlue;
            panelTitulo.Controls.Add(btnMinimizar);
            panelTitulo.Controls.Add(btnCerrar);
            panelTitulo.Dock = DockStyle.Top;
            panelTitulo.Location = new Point(0, 0);
            panelTitulo.Name = "panelTitulo";
            panelTitulo.Size = new Size(1415, 40);
            panelTitulo.TabIndex = 0;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Image = (Image)resources.GetObject("btnMinimizar.Image");
            btnMinimizar.Location = new Point(1346, 6);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(30, 31);
            btnMinimizar.SizeMode = PictureBoxSizeMode.StretchImage;
            btnMinimizar.TabIndex = 1;
            btnMinimizar.TabStop = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(1382, 6);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(30, 31);
            btnCerrar.SizeMode = PictureBoxSizeMode.StretchImage;
            btnCerrar.TabIndex = 0;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.Teal;
            panelMenu.Controls.Add(btnListarProductos);
            panelMenu.Controls.Add(btnListarProveedores);
            panelMenu.Controls.Add(btnListarUsuarios);
            panelMenu.Controls.Add(btnBajaProveedor);
            panelMenu.Controls.Add(btnBajaUsuario);
            panelMenu.Controls.Add(btnAddSupplier);
            panelMenu.Controls.Add(btnAddUser);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 40);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(250, 697);
            panelMenu.TabIndex = 1;
            // 
            // btnListarProductos
            // 
            btnListarProductos.FlatAppearance.BorderSize = 0;
            btnListarProductos.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 50, 70);
            btnListarProductos.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            btnListarProductos.FlatStyle = FlatStyle.Flat;
            btnListarProductos.ForeColor = Color.Gainsboro;
            btnListarProductos.Location = new Point(3, 451);
            btnListarProductos.Name = "btnListarProductos";
            btnListarProductos.Size = new Size(247, 47);
            btnListarProductos.TabIndex = 6;
            btnListarProductos.Text = "Listar Productos";
            btnListarProductos.UseVisualStyleBackColor = true;
            btnListarProductos.Click += btnListarProductos_Click;
            // 
            // btnListarProveedores
            // 
            btnListarProveedores.FlatAppearance.BorderSize = 0;
            btnListarProveedores.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 50, 70);
            btnListarProveedores.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            btnListarProveedores.FlatStyle = FlatStyle.Flat;
            btnListarProveedores.ForeColor = Color.Gainsboro;
            btnListarProveedores.Location = new Point(3, 398);
            btnListarProveedores.Name = "btnListarProveedores";
            btnListarProveedores.Size = new Size(247, 47);
            btnListarProveedores.TabIndex = 5;
            btnListarProveedores.Text = "Listar Proveedores";
            btnListarProveedores.UseVisualStyleBackColor = true;
            btnListarProveedores.Click += btnListarProveedores_Click;
            // 
            // btnListarUsuarios
            // 
            btnListarUsuarios.FlatAppearance.BorderSize = 0;
            btnListarUsuarios.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 50, 70);
            btnListarUsuarios.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            btnListarUsuarios.FlatStyle = FlatStyle.Flat;
            btnListarUsuarios.ForeColor = Color.Gainsboro;
            btnListarUsuarios.Location = new Point(3, 345);
            btnListarUsuarios.Name = "btnListarUsuarios";
            btnListarUsuarios.Size = new Size(247, 47);
            btnListarUsuarios.TabIndex = 4;
            btnListarUsuarios.Text = "Listar Usuarios";
            btnListarUsuarios.UseVisualStyleBackColor = true;
            btnListarUsuarios.Click += btnListarUsuarios_Click;
            // 
            // btnBajaProveedor
            // 
            btnBajaProveedor.FlatAppearance.BorderSize = 0;
            btnBajaProveedor.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 50, 70);
            btnBajaProveedor.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            btnBajaProveedor.FlatStyle = FlatStyle.Flat;
            btnBajaProveedor.ForeColor = Color.Gainsboro;
            btnBajaProveedor.Location = new Point(3, 292);
            btnBajaProveedor.Name = "btnBajaProveedor";
            btnBajaProveedor.Size = new Size(247, 47);
            btnBajaProveedor.TabIndex = 3;
            btnBajaProveedor.Text = "Baja Proveedor";
            btnBajaProveedor.UseVisualStyleBackColor = true;
            btnBajaProveedor.Click += btnBajaProveedor_Click;
            // 
            // btnBajaUsuario
            // 
            btnBajaUsuario.FlatAppearance.BorderSize = 0;
            btnBajaUsuario.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 50, 70);
            btnBajaUsuario.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            btnBajaUsuario.FlatStyle = FlatStyle.Flat;
            btnBajaUsuario.ForeColor = Color.Gainsboro;
            btnBajaUsuario.Location = new Point(3, 239);
            btnBajaUsuario.Name = "btnBajaUsuario";
            btnBajaUsuario.Size = new Size(247, 47);
            btnBajaUsuario.TabIndex = 2;
            btnBajaUsuario.Text = "Baja Usuario";
            btnBajaUsuario.UseVisualStyleBackColor = true;
            btnBajaUsuario.Click += btnBajaUsuario_Click;
            // 
            // btnAddSupplier
            // 
            btnAddSupplier.FlatAppearance.BorderSize = 0;
            btnAddSupplier.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 50, 70);
            btnAddSupplier.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            btnAddSupplier.FlatStyle = FlatStyle.Flat;
            btnAddSupplier.ForeColor = Color.Gainsboro;
            btnAddSupplier.Location = new Point(3, 186);
            btnAddSupplier.Name = "btnAddSupplier";
            btnAddSupplier.Size = new Size(247, 47);
            btnAddSupplier.TabIndex = 1;
            btnAddSupplier.Text = "Agregar Proveedor";
            btnAddSupplier.UseVisualStyleBackColor = true;
            btnAddSupplier.Click += btnAddSupplier_Click;
            // 
            // btnAddUser
            // 
            btnAddUser.FlatAppearance.BorderSize = 0;
            btnAddUser.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 50, 70);
            btnAddUser.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            btnAddUser.FlatStyle = FlatStyle.Flat;
            btnAddUser.ForeColor = Color.Gainsboro;
            btnAddUser.Location = new Point(3, 133);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(247, 47);
            btnAddUser.TabIndex = 0;
            btnAddUser.Text = "Agregar Usuario";
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // panelFormularios
            // 
            panelFormularios.Controls.Add(pictureBox1);
            panelFormularios.Dock = DockStyle.Fill;
            panelFormularios.Location = new Point(250, 40);
            panelFormularios.Name = "panelFormularios";
            panelFormularios.Size = new Size(1165, 697);
            panelFormularios.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(333, 121);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(441, 354);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1415, 737);
            Controls.Add(panelFormularios);
            Controls.Add(panelMenu);
            Controls.Add(panelTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormPrincipal";
            Load += FormPrincipal_Load;
            panelTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            panelMenu.ResumeLayout(false);
            panelFormularios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTitulo;
        private Panel panelMenu;
        private PictureBox btnMinimizar;
        private PictureBox btnCerrar;
        private Panel panelFormularios;
        private PictureBox pictureBox1;
        private Button btnListarProveedores;
        private Button btnListarUsuarios;
        private Button btnBajaProveedor;
        private Button btnBajaUsuario;
        private Button btnAddSupplier;
        private Button btnAddUser;
        private Button btnListarProductos;
    }
}