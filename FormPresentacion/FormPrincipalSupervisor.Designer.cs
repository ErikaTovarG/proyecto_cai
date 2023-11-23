namespace FormPresentacion
{
    partial class FormPrincipalSupervisor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipalSupervisor));
            panelTitulo = new Panel();
            btnMinimizar = new PictureBox();
            btnCerrar = new PictureBox();
            panelMenu = new Panel();
            lblUser = new Label();
            pictureBox2 = new PictureBox();
            btnProductos = new Button();
            btnReportes = new Button();
            btnDevoluciones = new Button();
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
            panelTitulo.Name = "panelTitulo";
            panelTitulo.Size = new Size(1386, 40);
            panelTitulo.TabIndex = 1;
            panelTitulo.Paint += panelTitulo_Paint;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Image = (Image)resources.GetObject("btnMinimizar.Image");
            btnMinimizar.Location = new Point(1308, 6);
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
            btnCerrar.Location = new Point(1344, 6);
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
            panelMenu.Controls.Add(lblUser);
            panelMenu.Controls.Add(pictureBox2);
            panelMenu.Controls.Add(btnProductos);
            panelMenu.Controls.Add(btnReportes);
            panelMenu.Controls.Add(btnDevoluciones);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 40);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(250, 697);
            panelMenu.TabIndex = 2;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblUser.Location = new Point(82, 131);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(103, 25);
            lblUser.TabIndex = 8;
            lblUser.Text = "Supervisor";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(55, 21);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(139, 107);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // btnProductos
            // 
            btnProductos.FlatAppearance.BorderSize = 0;
            btnProductos.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 50, 70);
            btnProductos.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            btnProductos.FlatStyle = FlatStyle.Flat;
            btnProductos.ForeColor = Color.Gainsboro;
            btnProductos.Location = new Point(3, 221);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(247, 47);
            btnProductos.TabIndex = 6;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += btnProductos_Click;
            // 
            // btnReportes
            // 
            btnReportes.FlatAppearance.BorderSize = 0;
            btnReportes.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 50, 70);
            btnReportes.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            btnReportes.FlatStyle = FlatStyle.Flat;
            btnReportes.ForeColor = Color.Gainsboro;
            btnReportes.Location = new Point(3, 327);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(247, 47);
            btnReportes.TabIndex = 5;
            btnReportes.Text = "Reportes";
            btnReportes.UseVisualStyleBackColor = true;
            btnReportes.Click += btnReportes_Click;
            // 
            // btnDevoluciones
            // 
            btnDevoluciones.FlatAppearance.BorderSize = 0;
            btnDevoluciones.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 50, 70);
            btnDevoluciones.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            btnDevoluciones.FlatStyle = FlatStyle.Flat;
            btnDevoluciones.ForeColor = Color.Gainsboro;
            btnDevoluciones.Location = new Point(3, 275);
            btnDevoluciones.Name = "btnDevoluciones";
            btnDevoluciones.Size = new Size(247, 47);
            btnDevoluciones.TabIndex = 4;
            btnDevoluciones.Text = "Devoluciones";
            btnDevoluciones.UseVisualStyleBackColor = true;
            btnDevoluciones.Click += btnDevoluciones_Click;
            // 
            // panelFormularios
            // 
            panelFormularios.Controls.Add(pictureBox1);
            panelFormularios.Dock = DockStyle.Fill;
            panelFormularios.Location = new Point(250, 40);
            panelFormularios.Name = "panelFormularios";
            panelFormularios.Size = new Size(1136, 697);
            panelFormularios.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(333, 121);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(441, 355);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // FormPrincipalSupervisor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1386, 737);
            Controls.Add(panelFormularios);
            Controls.Add(panelMenu);
            Controls.Add(panelTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormPrincipalSupervisor";
            Text = "FormPrincipalSupervisor";
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
        private PictureBox btnMinimizar;
        private PictureBox btnCerrar;
        private Panel panelMenu;
        private Button btnProductos;
        private Button btnReportes;
        private Button btnDevoluciones;
        private Panel panelFormularios;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label lblUser;
    }
}