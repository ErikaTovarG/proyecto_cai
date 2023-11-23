namespace FormPresentacion
{
    partial class FormEditarProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditarProveedor));
            pictureBox1 = new PictureBox();
            grbEditarProveedor = new GroupBox();
            txtNuevoCuit = new TextBox();
            label1 = new Label();
            txtNuevoEmail = new TextBox();
            label2 = new Label();
            btnEditarProveedor = new Button();
            btnLimpiarCampos = new Button();
            btnCancelar = new Button();
            txtNuevoApellido = new TextBox();
            lblApellido = new Label();
            txtNuevoNombre = new TextBox();
            lblNombre = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            grbEditarProveedor.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(22, 37);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(115, 115);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // grbEditarProveedor
            // 
            grbEditarProveedor.Controls.Add(txtNuevoCuit);
            grbEditarProveedor.Controls.Add(label1);
            grbEditarProveedor.Controls.Add(txtNuevoEmail);
            grbEditarProveedor.Controls.Add(label2);
            grbEditarProveedor.Controls.Add(btnEditarProveedor);
            grbEditarProveedor.Controls.Add(btnLimpiarCampos);
            grbEditarProveedor.Controls.Add(btnCancelar);
            grbEditarProveedor.Controls.Add(txtNuevoApellido);
            grbEditarProveedor.Controls.Add(lblApellido);
            grbEditarProveedor.Controls.Add(txtNuevoNombre);
            grbEditarProveedor.Controls.Add(lblNombre);
            grbEditarProveedor.Location = new Point(153, 30);
            grbEditarProveedor.Margin = new Padding(3, 2, 3, 2);
            grbEditarProveedor.Name = "grbEditarProveedor";
            grbEditarProveedor.Padding = new Padding(3, 2, 3, 2);
            grbEditarProveedor.Size = new Size(382, 201);
            grbEditarProveedor.TabIndex = 16;
            grbEditarProveedor.TabStop = false;
            grbEditarProveedor.Text = "Editar proveedor";
            // 
            // txtNuevoCuit
            // 
            txtNuevoCuit.Location = new Point(210, 99);
            txtNuevoCuit.Margin = new Padding(3, 2, 3, 2);
            txtNuevoCuit.Name = "txtNuevoCuit";
            txtNuevoCuit.Size = new Size(148, 23);
            txtNuevoCuit.TabIndex = 39;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(210, 81);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 38;
            label1.Text = "Nuevo Nro. Cuit:";
            // 
            // txtNuevoEmail
            // 
            txtNuevoEmail.Location = new Point(210, 49);
            txtNuevoEmail.Margin = new Padding(3, 2, 3, 2);
            txtNuevoEmail.Name = "txtNuevoEmail";
            txtNuevoEmail.Size = new Size(148, 23);
            txtNuevoEmail.TabIndex = 37;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(210, 29);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 36;
            label2.Text = "Nuevo email:";
            // 
            // btnEditarProveedor
            // 
            btnEditarProveedor.BackColor = Color.DarkGray;
            btnEditarProveedor.FlatAppearance.BorderSize = 0;
            btnEditarProveedor.FlatAppearance.CheckedBackColor = Color.Black;
            btnEditarProveedor.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnEditarProveedor.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnEditarProveedor.FlatStyle = FlatStyle.Flat;
            btnEditarProveedor.Location = new Point(26, 145);
            btnEditarProveedor.Margin = new Padding(4);
            btnEditarProveedor.Name = "btnEditarProveedor";
            btnEditarProveedor.Size = new Size(101, 30);
            btnEditarProveedor.TabIndex = 35;
            btnEditarProveedor.Text = "Editar";
            btnEditarProveedor.UseVisualStyleBackColor = false;
            btnEditarProveedor.Click += btnEditarProveedor_Click;
            // 
            // btnLimpiarCampos
            // 
            btnLimpiarCampos.BackColor = Color.DarkGray;
            btnLimpiarCampos.FlatAppearance.BorderSize = 0;
            btnLimpiarCampos.FlatAppearance.CheckedBackColor = Color.Black;
            btnLimpiarCampos.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnLimpiarCampos.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnLimpiarCampos.FlatStyle = FlatStyle.Flat;
            btnLimpiarCampos.Location = new Point(141, 145);
            btnLimpiarCampos.Margin = new Padding(4);
            btnLimpiarCampos.Name = "btnLimpiarCampos";
            btnLimpiarCampos.Size = new Size(101, 30);
            btnLimpiarCampos.TabIndex = 34;
            btnLimpiarCampos.Text = "Limpiar";
            btnLimpiarCampos.UseVisualStyleBackColor = false;
            btnLimpiarCampos.Click += btnLimpiarCampos_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.DarkGray;
            btnCancelar.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            btnCancelar.FlatAppearance.CheckedBackColor = Color.Black;
            btnCancelar.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 192);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Location = new Point(256, 145);
            btnCancelar.Margin = new Padding(4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(101, 30);
            btnCancelar.TabIndex = 31;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtNuevoApellido
            // 
            txtNuevoApellido.Location = new Point(25, 99);
            txtNuevoApellido.Margin = new Padding(3, 2, 3, 2);
            txtNuevoApellido.Name = "txtNuevoApellido";
            txtNuevoApellido.Size = new Size(148, 23);
            txtNuevoApellido.TabIndex = 13;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(25, 81);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(90, 15);
            lblApellido.TabIndex = 12;
            lblApellido.Text = "Nuevo apellido:";
            // 
            // txtNuevoNombre
            // 
            txtNuevoNombre.Location = new Point(25, 49);
            txtNuevoNombre.Margin = new Padding(3, 2, 3, 2);
            txtNuevoNombre.Name = "txtNuevoNombre";
            txtNuevoNombre.Size = new Size(148, 23);
            txtNuevoNombre.TabIndex = 11;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(25, 29);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(90, 15);
            lblNombre.TabIndex = 10;
            lblNombre.Text = "Nuevo nombre:";
            // 
            // FormEditarProveedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(569, 259);
            Controls.Add(pictureBox1);
            Controls.Add(grbEditarProveedor);
            Name = "FormEditarProveedor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormEditarProveedor";
            Load += FormEditarProveedor_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            grbEditarProveedor.ResumeLayout(false);
            grbEditarProveedor.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private GroupBox grbEditarProveedor;
        private Button btnEditarProveedor;
        private Button btnLimpiarCampos;
        private Button btnCancelar;
        public TextBox txtNuevoApellido;
        private Label lblApellido;
        public TextBox txtNuevoNombre;
        private Label lblNombre;
        public TextBox txtNuevoCuit;
        private Label label1;
        public TextBox txtNuevoEmail;
        private Label label2;
    }
}