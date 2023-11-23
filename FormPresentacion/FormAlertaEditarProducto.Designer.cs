namespace FormPresentacion
{
    partial class FormAlertaEditarProducto
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
            btnEditar = new Button();
            SuspendLayout();
            // 
            // lblAdvertencia
            // 
            lblAdvertencia.AutoSize = true;
            lblAdvertencia.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblAdvertencia.ForeColor = Color.LightGray;
            lblAdvertencia.Location = new Point(57, 43);
            lblAdvertencia.Name = "lblAdvertencia";
            lblAdvertencia.Size = new Size(202, 15);
            lblAdvertencia.TabIndex = 29;
            lblAdvertencia.Text = "¿Está seguro de editar este producto?";
            // 
            // lblAtencion
            // 
            lblAtencion.AutoSize = true;
            lblAtencion.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblAtencion.ForeColor = Color.LightGray;
            lblAtencion.Location = new Point(36, 15);
            lblAtencion.Name = "lblAtencion";
            lblAtencion.Size = new Size(78, 19);
            lblAtencion.TabIndex = 28;
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
            btnCancelar.Location = new Point(185, 87);
            btnCancelar.Margin = new Padding(4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(101, 30);
            btnCancelar.TabIndex = 27;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.DarkGray;
            btnEditar.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            btnEditar.FlatAppearance.CheckedBackColor = Color.Black;
            btnEditar.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnEditar.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 192);
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Location = new Point(57, 87);
            btnEditar.Margin = new Padding(4);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(101, 30);
            btnEditar.TabIndex = 26;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // FormAlertaEditarProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(346, 145);
            Controls.Add(lblAdvertencia);
            Controls.Add(lblAtencion);
            Controls.Add(btnCancelar);
            Controls.Add(btnEditar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAlertaEditarProducto";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAlertaEditarProducto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAdvertencia;
        private Label lblAtencion;
        private Button btnCancelar;
        private Button btnEditar;
    }
}