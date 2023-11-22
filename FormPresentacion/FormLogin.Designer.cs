namespace FormPresentacion
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            panel1 = new Panel();
            ptureLogo = new PictureBox();
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            btnLogin = new Button();
            btnCerrar = new Button();
            label1 = new Label();
            pctCerrar = new PictureBox();
            pctMinimizar = new PictureBox();
            lblErrorMensaje = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptureLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctMinimizar).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(ptureLogo);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(286, 440);
            panel1.TabIndex = 0;
            // 
            // ptureLogo
            // 
            ptureLogo.Image = (Image)resources.GetObject("ptureLogo.Image");
            ptureLogo.Location = new Point(35, 125);
            ptureLogo.Name = "ptureLogo";
            ptureLogo.Size = new Size(214, 131);
            ptureLogo.SizeMode = PictureBoxSizeMode.Zoom;
            ptureLogo.TabIndex = 0;
            ptureLogo.TabStop = false;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.FromArgb(15, 15, 15);
            txtUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtUsuario.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuario.ForeColor = Color.DimGray;
            txtUsuario.Location = new Point(342, 125);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(493, 32);
            txtUsuario.TabIndex = 1;
            txtUsuario.Text = "USUARIO";
            txtUsuario.Enter += txtUsuario_Enter;
            txtUsuario.Leave += txtUsuario_Leave;
            // 
            // txtContraseña
            // 
            txtContraseña.BackColor = Color.FromArgb(15, 15, 15);
            txtContraseña.BorderStyle = BorderStyle.FixedSingle;
            txtContraseña.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtContraseña.ForeColor = Color.DimGray;
            txtContraseña.Location = new Point(342, 196);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(493, 32);
            txtContraseña.TabIndex = 2;
            txtContraseña.Text = "CONTRASEÑA";
            txtContraseña.Enter += txtContraseña_Enter;
            txtContraseña.Leave += txtContraseña_Leave;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(40, 40, 40);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Bookman Old Style", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.LightGray;
            btnLogin.Location = new Point(409, 296);
            btnLogin.Margin = new Padding(0);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(166, 51);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.FromArgb(40, 40, 40);
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnCerrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("Bookman Old Style", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnCerrar.ForeColor = Color.LightGray;
            btnCerrar.Location = new Point(607, 296);
            btnCerrar.Margin = new Padding(0);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(166, 51);
            btnCerrar.TabIndex = 4;
            btnCerrar.Text = "Cancelar";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(566, 0);
            label1.Name = "label1";
            label1.Size = new Size(126, 40);
            label1.TabIndex = 5;
            label1.Text = "LOGIN";
            // 
            // pctCerrar
            // 
            pctCerrar.BackColor = Color.FromArgb(40, 40, 40);
            pctCerrar.BackgroundImageLayout = ImageLayout.None;
            pctCerrar.Image = (Image)resources.GetObject("pctCerrar.Image");
            pctCerrar.Location = new Point(863, 0);
            pctCerrar.Margin = new Padding(0);
            pctCerrar.Name = "pctCerrar";
            pctCerrar.Size = new Size(25, 25);
            pctCerrar.SizeMode = PictureBoxSizeMode.StretchImage;
            pctCerrar.TabIndex = 6;
            pctCerrar.TabStop = false;
            pctCerrar.Click += pctCerrar_Click;
            // 
            // pctMinimizar
            // 
            pctMinimizar.BackColor = Color.FromArgb(40, 40, 40);
            pctMinimizar.BackgroundImageLayout = ImageLayout.None;
            pctMinimizar.Image = (Image)resources.GetObject("pctMinimizar.Image");
            pctMinimizar.Location = new Point(832, 0);
            pctMinimizar.Margin = new Padding(0);
            pctMinimizar.Name = "pctMinimizar";
            pctMinimizar.Size = new Size(25, 25);
            pctMinimizar.SizeMode = PictureBoxSizeMode.StretchImage;
            pctMinimizar.TabIndex = 7;
            pctMinimizar.TabStop = false;
            pctMinimizar.Click += pctMinimizar_Click;
            // 
            // lblErrorMensaje
            // 
            lblErrorMensaje.AutoSize = true;
            lblErrorMensaje.Font = new Font("MS Reference Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblErrorMensaje.ForeColor = Color.DarkGray;
            lblErrorMensaje.Location = new Point(347, 244);
            lblErrorMensaje.Name = "lblErrorMensaje";
            lblErrorMensaje.Size = new Size(121, 20);
            lblErrorMensaje.TabIndex = 8;
            lblErrorMensaje.Text = "Mensaje Error";
            lblErrorMensaje.Visible = false;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(891, 440);
            Controls.Add(lblErrorMensaje);
            Controls.Add(pctMinimizar);
            Controls.Add(pctCerrar);
            Controls.Add(label1);
            Controls.Add(btnCerrar);
            Controls.Add(btnLogin);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormLogin";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormLogin";
            Load += FormLogin_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ptureLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctMinimizar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private Button btnLogin;
        private Button btnCerrar;
        private Label label1;
        private PictureBox ptureLogo;
        private PictureBox pctCerrar;
        private PictureBox pctMinimizar;
        private Label lblErrorMensaje;
    }
}