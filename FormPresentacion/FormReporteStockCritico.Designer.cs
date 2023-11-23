namespace FormPresentacion
{
    partial class FormReporteStockCritico
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
            dtaGriewReporte = new DataGridView();
            idProducto = new DataGridViewTextBoxColumn();
            desProducto = new DataGridViewTextBoxColumn();
            cant = new DataGridViewTextBoxColumn();
            cantActual = new DataGridViewTextBoxColumn();
            cantPedir = new DataGridViewTextBoxColumn();
            mTotal = new DataGridViewTextBoxColumn();
            lblTexto = new Label();
            btnBuscar = new Button();
            btnLimpiar = new Button();
            cmbCategoria = new ComboBox();
            lblCategoria = new Label();
            btnBuscarPorCategoria = new Button();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dtaGriewReporte).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dtaGriewReporte
            // 
            dtaGriewReporte.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtaGriewReporte.Columns.AddRange(new DataGridViewColumn[] { idProducto, desProducto, cant, cantActual, cantPedir });
            dtaGriewReporte.EnableHeadersVisualStyles = false;
            dtaGriewReporte.Location = new Point(107, 60);
            dtaGriewReporte.Margin = new Padding(3, 4, 3, 4);
            dtaGriewReporte.Name = "dtaGriewReporte";
            dtaGriewReporte.RowHeadersWidth = 51;
            dtaGriewReporte.RowTemplate.Height = 25;
            dtaGriewReporte.Size = new Size(919, 366);
            dtaGriewReporte.TabIndex = 24;
            // 
            // idProducto
            // 
            idProducto.HeaderText = "ID Producto";
            idProducto.MinimumWidth = 6;
            idProducto.Name = "idProducto";
            idProducto.Width = 250;
            // 
            // desProducto
            // 
            desProducto.HeaderText = "Descripción";
            desProducto.MinimumWidth = 6;
            desProducto.Name = "desProducto";
            desProducto.Width = 220;
            // 
            // cant
            // 
            cant.HeaderText = "Cantidad Deseada";
            cant.MinimumWidth = 6;
            cant.Name = "cant";
            cant.Width = 125;
            // 
            // cantActual
            // 
            cantActual.HeaderText = "Cantidad Actual";
            cantActual.MinimumWidth = 6;
            cantActual.Name = "cantActual";
            cantActual.Width = 125;
            // 
            // cantPedir
            // 
            cantPedir.HeaderText = "Cantidad a Pedir";
            cantPedir.MinimumWidth = 6;
            cantPedir.Name = "cantPedir";
            cantPedir.Width = 125;
            // 
            // mTotal
            // 
            mTotal.MinimumWidth = 6;
            mTotal.Name = "mTotal";
            mTotal.Width = 125;
            // 
            // lblTexto
            // 
            lblTexto.AutoSize = true;
            lblTexto.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTexto.Location = new Point(107, 36);
            lblTexto.Name = "lblTexto";
            lblTexto.Size = new Size(273, 20);
            lblTexto.TabIndex = 31;
            lblTexto.Text = "Listado de productos con stock critico";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.DarkGray;
            btnBuscar.FlatAppearance.BorderColor = Color.FromArgb(192, 192, 255);
            btnBuscar.FlatAppearance.CheckedBackColor = Color.Black;
            btnBuscar.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnBuscar.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Location = new Point(847, 547);
            btnBuscar.Margin = new Padding(5);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(145, 41);
            btnBuscar.TabIndex = 76;
            btnBuscar.Text = "Buscar productos";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.DarkGray;
            btnLimpiar.FlatAppearance.BorderColor = Color.FromArgb(192, 192, 255);
            btnLimpiar.FlatAppearance.CheckedBackColor = Color.Black;
            btnLimpiar.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnLimpiar.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Location = new Point(563, 547);
            btnLimpiar.Margin = new Padding(5);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(145, 41);
            btnLimpiar.TabIndex = 77;
            btnLimpiar.Text = "Limpiar ";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // cmbCategoria
            // 
            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(40, 59);
            cmbCategoria.Margin = new Padding(3, 4, 3, 4);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(211, 28);
            cmbCategoria.TabIndex = 79;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCategoria.Location = new Point(40, 35);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(80, 20);
            lblCategoria.TabIndex = 78;
            lblCategoria.Text = "Categoria:";
            // 
            // btnBuscarPorCategoria
            // 
            btnBuscarPorCategoria.BackColor = Color.DarkGray;
            btnBuscarPorCategoria.FlatAppearance.BorderColor = Color.FromArgb(192, 192, 255);
            btnBuscarPorCategoria.FlatAppearance.CheckedBackColor = Color.Black;
            btnBuscarPorCategoria.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnBuscarPorCategoria.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            btnBuscarPorCategoria.FlatStyle = FlatStyle.Flat;
            btnBuscarPorCategoria.Location = new Point(40, 96);
            btnBuscarPorCategoria.Margin = new Padding(5);
            btnBuscarPorCategoria.Name = "btnBuscarPorCategoria";
            btnBuscarPorCategoria.Size = new Size(211, 41);
            btnBuscarPorCategoria.TabIndex = 80;
            btnBuscarPorCategoria.Text = "Buscar por categoria";
            btnBuscarPorCategoria.UseVisualStyleBackColor = false;
            btnBuscarPorCategoria.Click += btnBuscarPorCategoria_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblCategoria);
            groupBox1.Controls.Add(btnBuscarPorCategoria);
            groupBox1.Controls.Add(cmbCategoria);
            groupBox1.Location = new Point(107, 451);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(313, 155);
            groupBox1.TabIndex = 81;
            groupBox1.TabStop = false;
            groupBox1.Text = "Buscar por categoria";
            // 
            // FormReporteStockCritico
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1126, 637);
            Controls.Add(groupBox1);
            Controls.Add(btnLimpiar);
            Controls.Add(btnBuscar);
            Controls.Add(lblTexto);
            Controls.Add(dtaGriewReporte);
            Name = "FormReporteStockCritico";
            Text = "Reporte Stock Critico";
            Load += FormReporteStockCritico_Load;
            ((System.ComponentModel.ISupportInitialize)dtaGriewReporte).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtaGriewReporte;
        private DataGridViewTextBoxColumn idProducto;
        private DataGridViewTextBoxColumn desProducto;
        private DataGridViewTextBoxColumn cant;
        private DataGridViewTextBoxColumn cantActual;
        private DataGridViewTextBoxColumn cantPedir;
        private DataGridViewTextBoxColumn mUnitario;
        private DataGridViewTextBoxColumn mTotal;
        private Label lblTexto;
        private Button btnBuscar;
        private Button btnLimpiar;
        private ComboBox cmbCategoria;
        private Label lblCategoria;
        private Button btnBuscarPorCategoria;
        private GroupBox groupBox1;
    }
}