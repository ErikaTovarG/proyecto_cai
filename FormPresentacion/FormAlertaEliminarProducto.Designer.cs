namespace FormPresentacion
{
    partial class FormAlertaEliminarProducto
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
            lblAdvertencia = new Label();
            lblAtencion = new Label();
            btnCancelar = new Button();
            btnEliminar = new Button();
            SuspendLayout();
            // 
            // lblAdvertencia
            // 
            lblAdvertencia.AutoSize = true;
            lblAdvertencia.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblAdvertencia.ForeColor = Color.LightGray;
            lblAdvertencia.Location = new Point(79, 65);
            lblAdvertencia.Name = "lblAdvertencia";
            lblAdvertencia.Size = new Size(274, 20);
            lblAdvertencia.TabIndex = 25;
            lblAdvertencia.Text = "¿Está seguro de eliminar este producto?";
            // 
            // lblAtencion
            // 
            lblAtencion.AutoSize = true;
            lblAtencion.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblAtencion.ForeColor = Color.LightGray;
            lblAtencion.Location = new Point(55, 28);
            lblAtencion.Name = "lblAtencion";
            lblAtencion.Size = new Size(93, 23);
            lblAtencion.TabIndex = 24;
            lblAtencion.Text = "¡Atención!";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.DarkGray;
            btnCancelar.FlatAppearance.BorderColor = Color.FromArgb(192, 192, 255);
            btnCancelar.FlatAppearance.CheckedBackColor = Color.Black;
            btnCancelar.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Location = new Point(225, 124);
            btnCancelar.Margin = new Padding(5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(115, 40);
            btnCancelar.TabIndex = 23;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.DarkGray;
            btnEliminar.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            btnEliminar.FlatAppearance.CheckedBackColor = Color.Black;
            btnEliminar.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnEliminar.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 192);
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Location = new Point(79, 124);
            btnEliminar.Margin = new Padding(5);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(115, 40);
            btnEliminar.TabIndex = 22;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // FormAlertaEliminarProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(395, 193);
            Controls.Add(lblAdvertencia);
            Controls.Add(lblAtencion);
            Controls.Add(btnCancelar);
            Controls.Add(btnEliminar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAlertaEliminarProducto";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAlertaEliminarProducto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAdvertencia;
        private Label lblAtencion;
        private Button btnCancelar;
        private Button btnEliminar;
    }
}