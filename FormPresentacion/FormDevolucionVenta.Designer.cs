namespace FormPresentacion
{
    partial class FormDevolucionVenta
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
            lblCliente = new Label();
            btnBuscarVenta = new Button();
            gbDevVenta = new GroupBox();
            lstVentasPorCliente = new ListBox();
            btnEliminarVenta = new Button();
            tbTotalPagado = new TextBox();
            cmbClientes = new ComboBox();
            btnDevolucion = new Button();
            gbDevVenta.SuspendLayout();
            SuspendLayout();
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCliente.Location = new Point(42, 48);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(286, 20);
            lblCliente.TabIndex = 51;
            lblCliente.Text = "Seleccione el cliente para su devolucion:";
            // 
            // btnBuscarVenta
            // 
            btnBuscarVenta.BackColor = Color.Silver;
            btnBuscarVenta.FlatAppearance.BorderColor = Color.Silver;
            btnBuscarVenta.FlatAppearance.CheckedBackColor = Color.Black;
            btnBuscarVenta.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnBuscarVenta.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            btnBuscarVenta.FlatStyle = FlatStyle.Flat;
            btnBuscarVenta.Location = new Point(802, 42);
            btnBuscarVenta.Margin = new Padding(5);
            btnBuscarVenta.Name = "btnBuscarVenta";
            btnBuscarVenta.Size = new Size(132, 33);
            btnBuscarVenta.TabIndex = 50;
            btnBuscarVenta.Text = "Buscar";
            btnBuscarVenta.UseVisualStyleBackColor = false;
            btnBuscarVenta.Click += btnBuscarVenta_Click;
            // 
            // gbDevVenta
            // 
            gbDevVenta.Controls.Add(btnDevolucion);
            gbDevVenta.Controls.Add(lstVentasPorCliente);
            gbDevVenta.Controls.Add(btnEliminarVenta);
            gbDevVenta.Controls.Add(tbTotalPagado);
            gbDevVenta.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            gbDevVenta.Location = new Point(42, 105);
            gbDevVenta.Margin = new Padding(3, 4, 3, 4);
            gbDevVenta.Name = "gbDevVenta";
            gbDevVenta.Padding = new Padding(3, 4, 3, 4);
            gbDevVenta.Size = new Size(1038, 445);
            gbDevVenta.TabIndex = 52;
            gbDevVenta.TabStop = false;
            gbDevVenta.Text = "Devolución venta por ID Cliente : ";
            // 
            // lstVentasPorCliente
            // 
            lstVentasPorCliente.FormattingEnabled = true;
            lstVentasPorCliente.ItemHeight = 20;
            lstVentasPorCliente.Location = new Point(31, 51);
            lstVentasPorCliente.Name = "lstVentasPorCliente";
            lstVentasPorCliente.Size = new Size(969, 304);
            lstVentasPorCliente.TabIndex = 36;
            // 
            // btnEliminarVenta
            // 
            btnEliminarVenta.BackColor = Color.DarkGray;
            btnEliminarVenta.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            btnEliminarVenta.FlatAppearance.CheckedBackColor = Color.Black;
            btnEliminarVenta.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnEliminarVenta.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 192);
            btnEliminarVenta.FlatStyle = FlatStyle.Flat;
            btnEliminarVenta.Location = new Point(555, 613);
            btnEliminarVenta.Margin = new Padding(5);
            btnEliminarVenta.Name = "btnEliminarVenta";
            btnEliminarVenta.Size = new Size(102, 35);
            btnEliminarVenta.TabIndex = 35;
            btnEliminarVenta.Text = "Eliminar";
            btnEliminarVenta.UseVisualStyleBackColor = false;
            // 
            // tbTotalPagado
            // 
            tbTotalPagado.Enabled = false;
            tbTotalPagado.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tbTotalPagado.Location = new Point(515, 555);
            tbTotalPagado.Name = "tbTotalPagado";
            tbTotalPagado.Size = new Size(141, 30);
            tbTotalPagado.TabIndex = 26;
            // 
            // cmbClientes
            // 
            cmbClientes.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbClientes.FormattingEnabled = true;
            cmbClientes.Location = new Point(344, 45);
            cmbClientes.Margin = new Padding(3, 4, 3, 4);
            cmbClientes.Name = "cmbClientes";
            cmbClientes.Size = new Size(305, 28);
            cmbClientes.TabIndex = 65;
            // 
            // btnDevolucion
            // 
            btnDevolucion.BackColor = Color.Silver;
            btnDevolucion.FlatAppearance.BorderColor = Color.Silver;
            btnDevolucion.FlatAppearance.CheckedBackColor = Color.Black;
            btnDevolucion.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnDevolucion.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            btnDevolucion.FlatStyle = FlatStyle.Flat;
            btnDevolucion.Location = new Point(790, 382);
            btnDevolucion.Margin = new Padding(5);
            btnDevolucion.Name = "btnDevolucion";
            btnDevolucion.Size = new Size(210, 33);
            btnDevolucion.TabIndex = 66;
            btnDevolucion.Text = "Devolucion de Venta";
            btnDevolucion.UseVisualStyleBackColor = false;
            btnDevolucion.Click += btnDevolucion_Click;
            // 
            // FormDevolucionVenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1126, 637);
            Controls.Add(cmbClientes);
            Controls.Add(gbDevVenta);
            Controls.Add(lblCliente);
            Controls.Add(btnBuscarVenta);
            Name = "FormDevolucionVenta";
            Text = "Devolucion Venta";
            gbDevVenta.ResumeLayout(false);
            gbDevVenta.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCliente;
        private Button btnBuscarVenta;
        private GroupBox gbDevVenta;
        private Button btnEliminarVenta;
        private TextBox tbTotalPagado;
        private ComboBox cmbClientes;
        private ListBox lstVentasPorCliente;
        private Button btnDevolucion;
    }
}