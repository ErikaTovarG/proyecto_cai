namespace FormPresentacion
{
    partial class FormPrincipalVendedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipalVendedor));
            panelFormularios = new Panel();
            pictureBox1 = new PictureBox();
            panelMenu = new Panel();
            button1 = new Button();
            btnInicio = new Button();
            btnReporteVendedor = new Button();
            btnRegistrarVenta = new Button();
            lblVendedor = new Label();
            pictureBox2 = new PictureBox();
            btnVentas = new Button();
            panelTitulo = new Panel();
            btnMinimizar = new PictureBox();
            btnCerrar = new PictureBox();
            btnDevolucionVenta = new Button();
            panelFormularios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            SuspendLayout();
            // 
            // panelFormularios
            // 
            panelFormularios.BorderStyle = BorderStyle.FixedSingle;
            panelFormularios.Controls.Add(pictureBox1);
            panelFormularios.Dock = DockStyle.Fill;
            panelFormularios.Location = new Point(250, 39);
            panelFormularios.Name = "panelFormularios";
            panelFormularios.Size = new Size(1136, 698);
            panelFormularios.TabIndex = 6;
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
            // panelMenu
            // 
            panelMenu.BackColor = Color.Teal;
            panelMenu.BorderStyle = BorderStyle.FixedSingle;
            panelMenu.Controls.Add(btnDevolucionVenta);
            panelMenu.Controls.Add(button1);
            panelMenu.Controls.Add(btnInicio);
            panelMenu.Controls.Add(btnReporteVendedor);
            panelMenu.Controls.Add(btnRegistrarVenta);
            panelMenu.Controls.Add(lblVendedor);
            panelMenu.Controls.Add(pictureBox2);
            panelMenu.Controls.Add(btnVentas);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 39);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(250, 698);
            panelMenu.TabIndex = 5;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 50, 70);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Gainsboro;
            button1.Location = new Point(1, 358);
            button1.Name = "button1";
            button1.Size = new Size(247, 47);
            button1.TabIndex = 13;
            button1.Text = "Reporte por cliente";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // btnInicio
            // 
            btnInicio.Dock = DockStyle.Bottom;
            btnInicio.FlatAppearance.BorderSize = 0;
            btnInicio.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 50, 70);
            btnInicio.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.ForeColor = Color.Gainsboro;
            btnInicio.Location = new Point(0, 649);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(248, 47);
            btnInicio.TabIndex = 12;
            btnInicio.Text = "Inicio";
            btnInicio.UseVisualStyleBackColor = true;
            btnInicio.Click += btnInicio_Click;
            // 
            // btnReporteVendedor
            // 
            btnReporteVendedor.FlatAppearance.BorderSize = 0;
            btnReporteVendedor.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 50, 70);
            btnReporteVendedor.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            btnReporteVendedor.FlatStyle = FlatStyle.Flat;
            btnReporteVendedor.ForeColor = Color.Gainsboro;
            btnReporteVendedor.Location = new Point(1, 410);
            btnReporteVendedor.Name = "btnReporteVendedor";
            btnReporteVendedor.Size = new Size(247, 47);
            btnReporteVendedor.TabIndex = 11;
            btnReporteVendedor.Text = "Reporte por vendedor";
            btnReporteVendedor.UseVisualStyleBackColor = true;
            btnReporteVendedor.Click += btnReporteVendedor_Click;
            // 
            // btnRegistrarVenta
            // 
            btnRegistrarVenta.FlatAppearance.BorderSize = 0;
            btnRegistrarVenta.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 50, 70);
            btnRegistrarVenta.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            btnRegistrarVenta.FlatStyle = FlatStyle.Flat;
            btnRegistrarVenta.ForeColor = Color.Gainsboro;
            btnRegistrarVenta.Location = new Point(0, 204);
            btnRegistrarVenta.Name = "btnRegistrarVenta";
            btnRegistrarVenta.Size = new Size(247, 47);
            btnRegistrarVenta.TabIndex = 10;
            btnRegistrarVenta.Text = "Registrar venta";
            btnRegistrarVenta.UseVisualStyleBackColor = true;
            btnRegistrarVenta.Click += btnRegistrarVenta_Click;
            // 
            // lblVendedor
            // 
            lblVendedor.AutoSize = true;
            lblVendedor.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblVendedor.Location = new Point(82, 131);
            lblVendedor.Name = "lblVendedor";
            lblVendedor.Size = new Size(94, 25);
            lblVendedor.TabIndex = 8;
            lblVendedor.Text = "Vendedor";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(62, 21);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(128, 107);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // btnVentas
            // 
            btnVentas.FlatAppearance.BorderSize = 0;
            btnVentas.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 50, 70);
            btnVentas.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            btnVentas.FlatStyle = FlatStyle.Flat;
            btnVentas.ForeColor = Color.Gainsboro;
            btnVentas.Location = new Point(1, 306);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(247, 47);
            btnVentas.TabIndex = 6;
            btnVentas.Text = "Reporte por venta";
            btnVentas.UseVisualStyleBackColor = true;
            btnVentas.Click += btnVentas_Click;
            // 
            // panelTitulo
            // 
            panelTitulo.BackColor = Color.PowderBlue;
            panelTitulo.BorderStyle = BorderStyle.FixedSingle;
            panelTitulo.Controls.Add(btnMinimizar);
            panelTitulo.Controls.Add(btnCerrar);
            panelTitulo.Dock = DockStyle.Top;
            panelTitulo.Location = new Point(0, 0);
            panelTitulo.Name = "panelTitulo";
            panelTitulo.Size = new Size(1386, 39);
            panelTitulo.TabIndex = 4;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Image = (Image)resources.GetObject("btnMinimizar.Image");
            btnMinimizar.Location = new Point(1291, 7);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(30, 31);
            btnMinimizar.SizeMode = PictureBoxSizeMode.StretchImage;
            btnMinimizar.TabIndex = 1;
            btnMinimizar.TabStop = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(1328, 7);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(30, 31);
            btnCerrar.SizeMode = PictureBoxSizeMode.StretchImage;
            btnCerrar.TabIndex = 0;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnDevolucionVenta
            // 
            btnDevolucionVenta.FlatAppearance.BorderSize = 0;
            btnDevolucionVenta.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 50, 70);
            btnDevolucionVenta.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            btnDevolucionVenta.FlatStyle = FlatStyle.Flat;
            btnDevolucionVenta.ForeColor = Color.Gainsboro;
            btnDevolucionVenta.Location = new Point(3, 257);
            btnDevolucionVenta.Name = "btnDevolucionVenta";
            btnDevolucionVenta.Size = new Size(247, 47);
            btnDevolucionVenta.TabIndex = 14;
            btnDevolucionVenta.Text = "Devolucion venta";
            btnDevolucionVenta.UseVisualStyleBackColor = true;
            btnDevolucionVenta.Click += btnDevolucionVenta_Click;
            // 
            // FormPrincipalVendedor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1386, 737);
            Controls.Add(panelFormularios);
            Controls.Add(panelMenu);
            Controls.Add(panelTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormPrincipalVendedor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormPrincipalVendedor";
            panelFormularios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelFormularios;
        private PictureBox pictureBox1;
        private Panel panelMenu;
        private Label lblVendedor;
        private PictureBox pictureBox2;
        private Button btnVentas;
        private Panel panelTitulo;
        private PictureBox btnMinimizar;
        private PictureBox btnCerrar;
        private Button btnRegistrarVenta;
        private Button btnReporteVendedor;
        private Button btnInicio;
        private Button button1;
        private Button btnDevolucionVenta;
    }
}