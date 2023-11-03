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
            lblUser = new Label();
            pictureBox2 = new PictureBox();
            btnListarProductos = new Button();
            btnListarProveedores = new Button();
            btnListarUsuarios = new Button();
            panelFormularios = new Panel();
            pictureBox1 = new PictureBox();
            panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            panelTitulo.Margin = new Padding(3, 2, 3, 2);
            panelTitulo.Name = "panelTitulo";
            panelTitulo.Size = new Size(1213, 30);
            panelTitulo.TabIndex = 0;
            panelTitulo.Paint += panelTitulo_Paint;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Image = (Image)resources.GetObject("btnMinimizar.Image");
            btnMinimizar.Location = new Point(1146, 3);
            btnMinimizar.Margin = new Padding(3, 2, 3, 2);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(26, 23);
            btnMinimizar.SizeMode = PictureBoxSizeMode.StretchImage;
            btnMinimizar.TabIndex = 1;
            btnMinimizar.TabStop = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(1175, 3);
            btnCerrar.Margin = new Padding(3, 2, 3, 2);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(26, 23);
            btnCerrar.SizeMode = PictureBoxSizeMode.StretchImage;
            btnCerrar.TabIndex = 0;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.Teal;
            panelMenu.Controls.Add(lblUser);
            panelMenu.Controls.Add(pictureBox2);
            panelMenu.Controls.Add(btnListarProductos);
            panelMenu.Controls.Add(btnListarProveedores);
            panelMenu.Controls.Add(btnListarUsuarios);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 30);
            panelMenu.Margin = new Padding(3, 2, 3, 2);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(219, 523);
            panelMenu.TabIndex = 1;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblUser.Location = new Point(53, 98);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(111, 20);
            lblUser.TabIndex = 10;
            lblUser.Text = "Administrador";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(48, 16);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(122, 80);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // btnListarProductos
            // 
            btnListarProductos.FlatAppearance.BorderSize = 0;
            btnListarProductos.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 50, 70);
            btnListarProductos.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            btnListarProductos.FlatStyle = FlatStyle.Flat;
            btnListarProductos.ForeColor = Color.Gainsboro;
            btnListarProductos.Location = new Point(3, 245);
            btnListarProductos.Margin = new Padding(3, 2, 3, 2);
            btnListarProductos.Name = "btnListarProductos";
            btnListarProductos.Size = new Size(216, 35);
            btnListarProductos.TabIndex = 6;
            btnListarProductos.Text = "Productos";
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
            btnListarProveedores.Location = new Point(3, 206);
            btnListarProveedores.Margin = new Padding(3, 2, 3, 2);
            btnListarProveedores.Name = "btnListarProveedores";
            btnListarProveedores.Size = new Size(216, 35);
            btnListarProveedores.TabIndex = 5;
            btnListarProveedores.Text = "Proveedores";
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
            btnListarUsuarios.Location = new Point(3, 166);
            btnListarUsuarios.Margin = new Padding(3, 2, 3, 2);
            btnListarUsuarios.Name = "btnListarUsuarios";
            btnListarUsuarios.Size = new Size(216, 35);
            btnListarUsuarios.TabIndex = 4;
            btnListarUsuarios.Text = "Usuarios";
            btnListarUsuarios.UseVisualStyleBackColor = true;
            btnListarUsuarios.Click += btnListarUsuarios_Click;
            // 
            // panelFormularios
            // 
            panelFormularios.Controls.Add(pictureBox1);
            panelFormularios.Dock = DockStyle.Fill;
            panelFormularios.Location = new Point(219, 30);
            panelFormularios.Margin = new Padding(3, 2, 3, 2);
            panelFormularios.Name = "panelFormularios";
            panelFormularios.Size = new Size(994, 523);
            panelFormularios.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(291, 91);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(386, 266);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1213, 553);
            Controls.Add(panelFormularios);
            Controls.Add(panelMenu);
            Controls.Add(panelTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormPrincipal";
            Load += FormPrincipal_Load;
            panelTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private Button btnListarProductos;
        private Label lblUser;
        private PictureBox pictureBox2;
    }
}