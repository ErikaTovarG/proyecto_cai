namespace FormPresentacion
{
    partial class FormListarProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListarProductos));
            lstProductos = new ListBox();
            grbDetalle = new GroupBox();
            btnEditar = new Button();
            btnEliminar = new Button();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            txtIDProveedor = new TextBox();
            lblID = new Label();
            btnLimpiar = new Button();
            btnListar = new Button();
            btnVerDetalle = new Button();
            textBox5 = new TextBox();
            label5 = new Label();
            grbDetalle.SuspendLayout();
            SuspendLayout();
            // 
            // lstProductos
            // 
            lstProductos.FormattingEnabled = true;
            lstProductos.ItemHeight = 20;
            lstProductos.Location = new Point(43, 27);
            lstProductos.Name = "lstProductos";
            lstProductos.Size = new Size(302, 504);
            lstProductos.TabIndex = 2;
            // 
            // grbDetalle
            // 
            grbDetalle.Controls.Add(textBox5);
            grbDetalle.Controls.Add(label5);
            grbDetalle.Controls.Add(btnEditar);
            grbDetalle.Controls.Add(btnEliminar);
            grbDetalle.Controls.Add(textBox4);
            grbDetalle.Controls.Add(label4);
            grbDetalle.Controls.Add(textBox3);
            grbDetalle.Controls.Add(label3);
            grbDetalle.Controls.Add(textBox2);
            grbDetalle.Controls.Add(label2);
            grbDetalle.Controls.Add(txtIDProveedor);
            grbDetalle.Controls.Add(lblID);
            grbDetalle.Location = new Point(564, 27);
            grbDetalle.Name = "grbDetalle";
            grbDetalle.Size = new Size(575, 570);
            grbDetalle.TabIndex = 3;
            grbDetalle.TabStop = false;
            grbDetalle.Text = "Detalle del producto";
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.DarkGray;
            btnEditar.FlatAppearance.BorderColor = Color.FromArgb(192, 192, 255);
            btnEditar.FlatAppearance.CheckedBackColor = Color.Black;
            btnEditar.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnEditar.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Location = new Point(96, 512);
            btnEditar.Margin = new Padding(5);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(115, 40);
            btnEditar.TabIndex = 15;
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
            btnEliminar.Location = new Point(240, 512);
            btnEliminar.Margin = new Padding(5);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(115, 40);
            btnEliminar.TabIndex = 14;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(25, 334);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(346, 27);
            textBox4.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 301);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 6;
            label4.Text = "label4";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(25, 255);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(346, 27);
            textBox3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 222);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 4;
            label3.Text = "label3";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(25, 165);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(346, 27);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 132);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 2;
            label2.Text = "label2";
            // 
            // txtIDProveedor
            // 
            txtIDProveedor.Enabled = false;
            txtIDProveedor.Location = new Point(25, 84);
            txtIDProveedor.Name = "txtIDProveedor";
            txtIDProveedor.Size = new Size(346, 27);
            txtIDProveedor.TabIndex = 1;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(25, 51);
            lblID.Name = "lblID";
            lblID.Size = new Size(24, 20);
            lblID.TabIndex = 0;
            lblID.Text = "ID";
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.DarkGray;
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatAppearance.CheckedBackColor = Color.Black;
            btnLimpiar.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnLimpiar.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Location = new Point(131, 589);
            btnLimpiar.Margin = new Padding(5);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(115, 40);
            btnLimpiar.TabIndex = 14;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnListar
            // 
            btnListar.BackColor = Color.DarkGray;
            btnListar.FlatAppearance.BorderSize = 0;
            btnListar.FlatAppearance.CheckedBackColor = Color.Black;
            btnListar.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnListar.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnListar.FlatStyle = FlatStyle.Flat;
            btnListar.Location = new Point(63, 539);
            btnListar.Margin = new Padding(5);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(115, 40);
            btnListar.TabIndex = 13;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = false;
            btnListar.Click += btnListar_Click;
            // 
            // btnVerDetalle
            // 
            btnVerDetalle.BackColor = Color.DarkGray;
            btnVerDetalle.FlatAppearance.BorderSize = 0;
            btnVerDetalle.FlatAppearance.CheckedBackColor = Color.Black;
            btnVerDetalle.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnVerDetalle.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnVerDetalle.FlatStyle = FlatStyle.Flat;
            btnVerDetalle.Location = new Point(207, 539);
            btnVerDetalle.Margin = new Padding(5);
            btnVerDetalle.Name = "btnVerDetalle";
            btnVerDetalle.Size = new Size(115, 40);
            btnVerDetalle.TabIndex = 12;
            btnVerDetalle.Text = "Ver detalle";
            btnVerDetalle.UseVisualStyleBackColor = false;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(25, 412);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(346, 27);
            textBox5.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 379);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 16;
            label5.Text = "label5";
            // 
            // FormListarProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1147, 650);
            Controls.Add(btnLimpiar);
            Controls.Add(btnListar);
            Controls.Add(btnVerDetalle);
            Controls.Add(grbDetalle);
            Controls.Add(lstProductos);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormListarProductos";
            Text = "Listado de Productos";
            grbDetalle.ResumeLayout(false);
            grbDetalle.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox grpLista;
        private ListBox lstProductos;
        private GroupBox grbDetalle;
        private TextBox txtIDProveedor;
        private Label lblID;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private Button btnLimpiar;
        private Button btnListar;
        private Button btnVerDetalle;
        private Button btnEditar;
        private Button btnEliminar;
        private TextBox textBox5;
        private Label label5;
    }
}