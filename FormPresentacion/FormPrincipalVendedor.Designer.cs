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
            btnModificarCliente = new Button();
            button2 = new Button();
            btnVentasEstado = new Button();
            btnMasVentas = new Button();
            btnInicio = new Button();
            btnRegistrarVenta = new Button();
            lblVendedor = new Label();
            pictureBox2 = new PictureBox();
            panelTitulo = new Panel();
            btnMinimizar = new PictureBox();
            btnCerrar = new PictureBox();
            btnRegistarCliente = new Button();
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
            panelMenu.Controls.Add(btnRegistarCliente);
            panelMenu.Controls.Add(btnModificarCliente);
            panelMenu.Controls.Add(button2);
            panelMenu.Controls.Add(btnVentasEstado);
            panelMenu.Controls.Add(btnMasVentas);
            panelMenu.Controls.Add(btnInicio);
            panelMenu.Controls.Add(btnRegistrarVenta);
            panelMenu.Controls.Add(lblVendedor);
            panelMenu.Controls.Add(pictureBox2);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 39);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(250, 698);
            panelMenu.TabIndex = 5;
            // 
            // btnModificarCliente
            // 
            btnModificarCliente.FlatAppearance.BorderSize = 0;
            btnModificarCliente.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 50, 70);
            btnModificarCliente.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            btnModificarCliente.FlatStyle = FlatStyle.Flat;
            btnModificarCliente.ForeColor = Color.Gainsboro;
            btnModificarCliente.Location = new Point(0, 315);
            btnModificarCliente.Name = "btnModificarCliente";
            btnModificarCliente.Size = new Size(247, 47);
            btnModificarCliente.TabIndex = 12;
            btnModificarCliente.Text = "Modificar Datos Cliente";
            btnModificarCliente.UseVisualStyleBackColor = true;
            btnModificarCliente.Click += btnModificarCliente_Click;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 50, 70);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.Gainsboro;
            button2.Location = new Point(-1, 474);
            button2.Name = "button2";
            button2.Size = new Size(247, 47);
            button2.TabIndex = 17;
            button2.Text = "Reporte Maxima Venta Cliente";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnVentasEstado
            // 
            btnVentasEstado.FlatAppearance.BorderSize = 0;
            btnVentasEstado.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 50, 70);
            btnVentasEstado.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            btnVentasEstado.FlatStyle = FlatStyle.Flat;
            btnVentasEstado.ForeColor = Color.Gainsboro;
            btnVentasEstado.Location = new Point(2, 421);
            btnVentasEstado.Name = "btnVentasEstado";
            btnVentasEstado.Size = new Size(247, 47);
            btnVentasEstado.TabIndex = 16;
            btnVentasEstado.Text = "Reporte Ventas Estados";
            btnVentasEstado.UseVisualStyleBackColor = true;
            btnVentasEstado.Click += btnVentasEstado_Click;
            // 
            // btnMasVentas
            // 
            btnMasVentas.FlatAppearance.BorderSize = 0;
            btnMasVentas.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 50, 70);
            btnMasVentas.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            btnMasVentas.FlatStyle = FlatStyle.Flat;
            btnMasVentas.ForeColor = Color.Gainsboro;
            btnMasVentas.Location = new Point(-1, 368);
            btnMasVentas.Name = "btnMasVentas";
            btnMasVentas.Size = new Size(247, 47);
            btnMasVentas.TabIndex = 15;
            btnMasVentas.Text = "Reporte Mayores Ventas";
            btnMasVentas.UseVisualStyleBackColor = true;
            btnMasVentas.Click += btnMasVentas_Click;
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
            // btnRegistrarVenta
            // 
            btnRegistrarVenta.FlatAppearance.BorderSize = 0;
            btnRegistrarVenta.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 50, 70);
            btnRegistrarVenta.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            btnRegistrarVenta.FlatStyle = FlatStyle.Flat;
            btnRegistrarVenta.ForeColor = Color.Gainsboro;
            btnRegistrarVenta.Location = new Point(-1, 262);
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
            // btnRegistarCliente
            // 
            btnRegistarCliente.FlatAppearance.BorderSize = 0;
            btnRegistarCliente.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 50, 70);
            btnRegistarCliente.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            btnRegistarCliente.FlatStyle = FlatStyle.Flat;
            btnRegistarCliente.ForeColor = Color.Gainsboro;
            btnRegistarCliente.Location = new Point(3, 209);
            btnRegistarCliente.Name = "btnRegistarCliente";
            btnRegistarCliente.Size = new Size(247, 47);
            btnRegistarCliente.TabIndex = 18;
            btnRegistarCliente.Text = "Registrar cliente";
            btnRegistarCliente.UseVisualStyleBackColor = true;
            btnRegistarCliente.Click += btnRegistarCliente_Click;
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
        private Panel panelTitulo;
        private PictureBox btnMinimizar;
        private PictureBox btnCerrar;
        private Button btnRegistrarVenta;
        private Button btnInicio;
        private Button btnModificarCliente;
        private Button btnMasVentas;
        private Button btnVentasEstado;
        private Button button2;
        private Button btnRegistarCliente;
    }
}