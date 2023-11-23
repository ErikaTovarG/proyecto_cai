namespace FormPresentacion
{
    partial class FormBajaProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBajaProveedor));
            txtIDProveedor = new TextBox();
            lblIDProveedor = new Label();
            btnEliminar = new Button();
            SuspendLayout();
            // 
            // txtIDProveedor
            // 
            txtIDProveedor.Location = new Point(142, 84);
            txtIDProveedor.Margin = new Padding(3, 2, 3, 2);
            txtIDProveedor.Name = "txtIDProveedor";
            txtIDProveedor.Size = new Size(344, 23);
            txtIDProveedor.TabIndex = 7;
            // 
            // lblIDProveedor
            // 
            lblIDProveedor.AutoSize = true;
            lblIDProveedor.Location = new Point(142, 67);
            lblIDProveedor.Name = "lblIDProveedor";
            lblIDProveedor.Size = new Size(116, 15);
            lblIDProveedor.TabIndex = 6;
            lblIDProveedor.Text = "Ingrese ID proveedor";
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.DarkGray;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatAppearance.CheckedBackColor = Color.Black;
            btnEliminar.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnEliminar.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Location = new Point(142, 132);
            btnEliminar.Margin = new Padding(4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(101, 30);
            btnEliminar.TabIndex = 11;
            btnEliminar.Text = "Aceptar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // FormBajaProveedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1004, 488);
            Controls.Add(btnEliminar);
            Controls.Add(txtIDProveedor);
            Controls.Add(lblIDProveedor);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormBajaProveedor";
            Text = "Baja Proveedor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtIDProveedor;
        private Label lblIDProveedor;
        private Button btnEliminar;
    }
}