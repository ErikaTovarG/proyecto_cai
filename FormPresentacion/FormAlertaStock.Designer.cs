namespace FormPresentacion
{
    partial class FormAlertaStock
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
            btnAceptar = new Button();
            lblAdvertencia = new Label();
            lblAtencion = new Label();
            lstStockFaltante = new ListBox();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.DarkGray;
            btnAceptar.FlatAppearance.BorderColor = Color.FromArgb(192, 192, 255);
            btnAceptar.FlatAppearance.CheckedBackColor = Color.Black;
            btnAceptar.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnAceptar.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Location = new Point(170, 322);
            btnAceptar.Margin = new Padding(5);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(115, 40);
            btnAceptar.TabIndex = 20;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // lblAdvertencia
            // 
            lblAdvertencia.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblAdvertencia.ForeColor = Color.LightGray;
            lblAdvertencia.Location = new Point(45, 71);
            lblAdvertencia.Name = "lblAdvertencia";
            lblAdvertencia.Size = new Size(384, 61);
            lblAdvertencia.TabIndex = 23;
            lblAdvertencia.Text = "El stock de los siguientes productos se encuentra por debajo del 25%";
            // 
            // lblAtencion
            // 
            lblAtencion.AutoSize = true;
            lblAtencion.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblAtencion.ForeColor = Color.LightGray;
            lblAtencion.Location = new Point(45, 34);
            lblAtencion.Name = "lblAtencion";
            lblAtencion.Size = new Size(93, 23);
            lblAtencion.TabIndex = 22;
            lblAtencion.Text = "¡Atención!";
            // 
            // lstStockFaltante
            // 
            lstStockFaltante.AccessibleName = "lstStockFaltante";
            lstStockFaltante.AccessibleRole = AccessibleRole.ListItem;
            lstStockFaltante.FormattingEnabled = true;
            lstStockFaltante.ItemHeight = 20;
            lstStockFaltante.Location = new Point(45, 126);
            lstStockFaltante.Name = "lstStockFaltante";
            lstStockFaltante.Size = new Size(384, 164);
            lstStockFaltante.TabIndex = 24;
            // 
            // FormAlertaStock
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(481, 429);
            Controls.Add(lstStockFaltante);
            Controls.Add(lblAdvertencia);
            Controls.Add(lblAtencion);
            Controls.Add(btnAceptar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAlertaStock";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAlertaStock";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAceptar;
        private Label lblAdvertencia;
        private Label lblAtencion;
        private ListBox lstStockFaltante;
    }
}