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
            btnReporteVendedor = new Button();
            btnRegistrarVenta = new Button();
            lblVendedor = new Label();
            pictureBox2 = new PictureBox();
            btnVentas = new Button();
            panelTitulo = new Panel();
            btnMinimizar = new PictureBox();
            btnCerrar = new PictureBox();
            btnInicio = new Button();
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
            panelFormularios.Location = new Point(219, 30);
            panelFormularios.Margin = new Padding(3, 2, 3, 2);
            panelFormularios.Name = "panelFormularios";
            panelFormularios.Size = new Size(994, 523);
            panelFormularios.TabIndex = 6;
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
            // panelMenu
            // 
            panelMenu.BackColor = Color.Teal;
            panelMenu.BorderStyle = BorderStyle.FixedSingle;
            panelMenu.Controls.Add(btnInicio);
            panelMenu.Controls.Add(btnReporteVendedor);
            panelMenu.Controls.Add(btnRegistrarVenta);
            panelMenu.Controls.Add(lblVendedor);
            panelMenu.Controls.Add(pictureBox2);
            panelMenu.Controls.Add(btnVentas);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 30);
            panelMenu.Margin = new Padding(3, 2, 3, 2);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(219, 523);
            panelMenu.TabIndex = 5;
            // 
            // btnReporteVendedor
            // 
            btnReporteVendedor.FlatAppearance.BorderSize = 0;
            btnReporteVendedor.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 50, 70);
            btnReporteVendedor.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            btnReporteVendedor.FlatStyle = FlatStyle.Flat;
            btnReporteVendedor.ForeColor = Color.Gainsboro;
            btnReporteVendedor.Location = new Point(3, 241);
            btnReporteVendedor.Margin = new Padding(3, 2, 3, 2);
            btnReporteVendedor.Name = "btnReporteVendedor";
            btnReporteVendedor.Size = new Size(216, 35);
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
            btnRegistrarVenta.Location = new Point(3, 202);
            btnRegistrarVenta.Margin = new Padding(3, 2, 3, 2);
            btnRegistrarVenta.Name = "btnRegistrarVenta";
            btnRegistrarVenta.Size = new Size(216, 35);
            btnRegistrarVenta.TabIndex = 10;
            btnRegistrarVenta.Text = "Registrar Venta";
            btnRegistrarVenta.UseVisualStyleBackColor = true;
            btnRegistrarVenta.Click += btnRegistrarVenta_Click;
            // 
            // lblVendedor
            // 
            lblVendedor.AutoSize = true;
            lblVendedor.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblVendedor.Location = new Point(72, 98);
            lblVendedor.Name = "lblVendedor";
            lblVendedor.Size = new Size(76, 20);
            lblVendedor.TabIndex = 8;
            lblVendedor.Text = "Vendedor";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(54, 16);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(112, 80);
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
            btnVentas.Location = new Point(3, 166);
            btnVentas.Margin = new Padding(3, 2, 3, 2);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(216, 35);
            btnVentas.TabIndex = 6;
            btnVentas.Text = "Ventas";
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
            panelTitulo.Margin = new Padding(3, 2, 3, 2);
            panelTitulo.Name = "panelTitulo";
            panelTitulo.Size = new Size(1213, 30);
            panelTitulo.TabIndex = 4;
            panelTitulo.Paint += panelTitulo_Paint;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Image = (Image)resources.GetObject("btnMinimizar.Image");
            btnMinimizar.Location = new Point(1130, 5);
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
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(1162, 5);
            btnCerrar.Margin = new Padding(3, 2, 3, 2);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(26, 23);
            btnCerrar.SizeMode = PictureBoxSizeMode.StretchImage;
            btnCerrar.TabIndex = 0;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnInicio
            // 
            btnInicio.Dock = DockStyle.Bottom;
            btnInicio.FlatAppearance.BorderSize = 0;
            btnInicio.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 50, 70);
            btnInicio.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.ForeColor = Color.Gainsboro;
            btnInicio.Location = new Point(0, 486);
            btnInicio.Margin = new Padding(3, 2, 3, 2);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(217, 35);
            btnInicio.TabIndex = 12;
            btnInicio.Text = "Inicio";
            btnInicio.UseVisualStyleBackColor = true;
            btnInicio.Click += btnInicio_Click;
            // 
            // FormPrincipalVendedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1213, 553);
            Controls.Add(panelFormularios);
            Controls.Add(panelMenu);
            Controls.Add(panelTitulo);
            FormBorderStyle = FormBorderStyle.None;
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
    }
}