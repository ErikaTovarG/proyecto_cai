namespace FormPresentacion
{
    partial class FormAlertaEliminarUsuario
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
            btnCancelar = new Button();
            btnEliminar = new Button();
            lblAtencion = new Label();
            lblAdvertencia = new Label();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.DarkGray;
            btnCancelar.FlatAppearance.BorderColor = Color.FromArgb(192, 192, 255);
            btnCancelar.FlatAppearance.CheckedBackColor = Color.Black;
            btnCancelar.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Location = new Point(210, 121);
            btnCancelar.Margin = new Padding(5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(115, 40);
            btnCancelar.TabIndex = 19;
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
            btnEliminar.Location = new Point(64, 121);
            btnEliminar.Margin = new Padding(5);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(115, 40);
            btnEliminar.TabIndex = 18;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // lblAtencion
            // 
            lblAtencion.AutoSize = true;
            lblAtencion.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblAtencion.ForeColor = Color.LightGray;
            lblAtencion.Location = new Point(40, 25);
            lblAtencion.Name = "lblAtencion";
            lblAtencion.Size = new Size(93, 23);
            lblAtencion.TabIndex = 20;
            lblAtencion.Text = "¡Atención!";
            // 
            // lblAdvertencia
            // 
            lblAdvertencia.AutoSize = true;
            lblAdvertencia.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblAdvertencia.ForeColor = Color.LightGray;
            lblAdvertencia.Location = new Point(64, 62);
            lblAdvertencia.Name = "lblAdvertencia";
            lblAdvertencia.Size = new Size(261, 20);
            lblAdvertencia.TabIndex = 21;
            lblAdvertencia.Text = "¿Está seguro de eliminar este usuario?";
            // 
            // FormAlertaEliminarUsuario
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
            Name = "FormAlertaEliminarUsuario";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAlertaEliminarUsuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnEliminar;
        private Label lblAtencion;
        private Label lblAdvertencia;
    }
}