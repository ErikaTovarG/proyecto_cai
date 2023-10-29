namespace FormPresentacion
{
    partial class FormListarProveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListarProveedores));
            grbDetalle = new GroupBox();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            lstProveedores = new ListBox();
            btnLimpiar = new Button();
            btnListar = new Button();
            btnVerDetalle = new Button();
            grbDetalle.SuspendLayout();
            SuspendLayout();
            // 
            // grbDetalle
            // 
            grbDetalle.Controls.Add(textBox4);
            grbDetalle.Controls.Add(label4);
            grbDetalle.Controls.Add(textBox3);
            grbDetalle.Controls.Add(label3);
            grbDetalle.Controls.Add(textBox2);
            grbDetalle.Controls.Add(label2);
            grbDetalle.Controls.Add(textBox1);
            grbDetalle.Controls.Add(label1);
            grbDetalle.Location = new Point(543, 23);
            grbDetalle.Name = "grbDetalle";
            grbDetalle.Size = new Size(575, 570);
            grbDetalle.TabIndex = 6;
            grbDetalle.TabStop = false;
            grbDetalle.Text = "Detalle del proveedor";
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
            // textBox1
            // 
            textBox1.Location = new Point(25, 84);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(346, 27);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 51);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // lstProveedores
            // 
            lstProveedores.FormattingEnabled = true;
            lstProveedores.ItemHeight = 20;
            lstProveedores.Location = new Point(36, 23);
            lstProveedores.Name = "lstProveedores";
            lstProveedores.Size = new Size(302, 504);
            lstProveedores.TabIndex = 5;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.DarkGray;
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatAppearance.CheckedBackColor = Color.Black;
            btnLimpiar.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnLimpiar.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Location = new Point(126, 585);
            btnLimpiar.Margin = new Padding(5);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(115, 40);
            btnLimpiar.TabIndex = 11;
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
            btnListar.Location = new Point(58, 535);
            btnListar.Margin = new Padding(5);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(115, 40);
            btnListar.TabIndex = 10;
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
            btnVerDetalle.Location = new Point(202, 535);
            btnVerDetalle.Margin = new Padding(5);
            btnVerDetalle.Name = "btnVerDetalle";
            btnVerDetalle.Size = new Size(115, 40);
            btnVerDetalle.TabIndex = 9;
            btnVerDetalle.Text = "Ver detalle";
            btnVerDetalle.UseVisualStyleBackColor = false;
            // 
            // FormListarProveedores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1147, 650);
            Controls.Add(btnLimpiar);
            Controls.Add(btnListar);
            Controls.Add(btnVerDetalle);
            Controls.Add(grbDetalle);
            Controls.Add(lstProveedores);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormListarProveedores";
            Text = "Listado de Proveedores";
            grbDetalle.ResumeLayout(false);
            grbDetalle.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbDetalle;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private ListBox lstProveedores;
        private Button btnLimpiar;
        private Button btnListar;
        private Button btnVerDetalle;
    }
}