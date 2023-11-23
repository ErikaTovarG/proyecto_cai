namespace FormPresentacion
{
    partial class FormListarVentasPorCategorias
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
            lstVentaProdCat = new ListBox();
            btnVentaProdCat = new Button();
            SuspendLayout();
            // 
            // lstVentaProdCat
            // 
            lstVentaProdCat.FormattingEnabled = true;
            lstVentaProdCat.ItemHeight = 15;
            lstVentaProdCat.Location = new Point(131, 36);
            lstVentaProdCat.Margin = new Padding(3, 2, 3, 2);
            lstVentaProdCat.Name = "lstVentaProdCat";
            lstVentaProdCat.Size = new Size(518, 274);
            lstVentaProdCat.TabIndex = 6;
            // 
            // btnVentaProdCat
            // 
            btnVentaProdCat.BackColor = Color.DarkGray;
            btnVentaProdCat.FlatAppearance.BorderSize = 0;
            btnVentaProdCat.FlatAppearance.CheckedBackColor = Color.Black;
            btnVentaProdCat.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnVentaProdCat.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnVentaProdCat.FlatStyle = FlatStyle.Flat;
            btnVentaProdCat.Location = new Point(341, 343);
            btnVentaProdCat.Margin = new Padding(4);
            btnVentaProdCat.Name = "btnVentaProdCat";
            btnVentaProdCat.Size = new Size(101, 30);
            btnVentaProdCat.TabIndex = 7;
            btnVentaProdCat.Text = "Listar";
            btnVentaProdCat.UseVisualStyleBackColor = false;
            btnVentaProdCat.Click += btnVentaProdCat_Click;
            // 
            // FormListarVentasPorCategorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVentaProdCat);
            Controls.Add(lstVentaProdCat);
            Name = "FormListarVentasPorCategorias";
            Text = "FormListarVentasPorCategorias";
            ResumeLayout(false);
        }

        #endregion

        public ListBox lstVentaProdCat;
        private Button btnVentaProdCat;
    }
}