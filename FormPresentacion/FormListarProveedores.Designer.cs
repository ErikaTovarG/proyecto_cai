﻿namespace FormPresentacion
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
            txtIDProveedor = new TextBox();
            lblID = new Label();
            btnEditar = new Button();
            btnEliminar = new Button();
            txtCuit = new TextBox();
            lblCuit = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtApellido = new TextBox();
            lblApellido = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            lstProveedores = new ListBox();
            btnLimpiar = new Button();
            btnListar = new Button();
            btnVerDetalle = new Button();
            btnLimpiarCmb = new Button();
            grbDetalle.SuspendLayout();
            SuspendLayout();
            // 
            // grbDetalle
            // 
            grbDetalle.Controls.Add(btnLimpiarCmb);
            grbDetalle.Controls.Add(txtIDProveedor);
            grbDetalle.Controls.Add(lblID);
            grbDetalle.Controls.Add(btnEditar);
            grbDetalle.Controls.Add(btnEliminar);
            grbDetalle.Controls.Add(txtCuit);
            grbDetalle.Controls.Add(lblCuit);
            grbDetalle.Controls.Add(txtEmail);
            grbDetalle.Controls.Add(lblEmail);
            grbDetalle.Controls.Add(txtApellido);
            grbDetalle.Controls.Add(lblApellido);
            grbDetalle.Controls.Add(txtNombre);
            grbDetalle.Controls.Add(lblNombre);
            grbDetalle.Location = new Point(543, 23);
            grbDetalle.Name = "grbDetalle";
            grbDetalle.Size = new Size(575, 570);
            grbDetalle.TabIndex = 6;
            grbDetalle.TabStop = false;
            grbDetalle.Text = "Detalle del proveedor";
            // 
            // txtIDProveedor
            // 
            txtIDProveedor.Enabled = false;
            txtIDProveedor.Location = new Point(42, 84);
            txtIDProveedor.Name = "txtIDProveedor";
            txtIDProveedor.Size = new Size(346, 27);
            txtIDProveedor.TabIndex = 19;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(42, 51);
            lblID.Name = "lblID";
            lblID.Size = new Size(24, 20);
            lblID.TabIndex = 18;
            lblID.Text = "ID";
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.DarkGray;
            btnEditar.FlatAppearance.BorderColor = Color.FromArgb(192, 192, 255);
            btnEditar.FlatAppearance.CheckedBackColor = Color.Black;
            btnEditar.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnEditar.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Location = new Point(42, 512);
            btnEditar.Margin = new Padding(5);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(115, 40);
            btnEditar.TabIndex = 17;
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
            btnEliminar.Location = new Point(176, 512);
            btnEliminar.Margin = new Padding(5);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(115, 40);
            btnEliminar.TabIndex = 16;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // txtCuit
            // 
            txtCuit.Location = new Point(42, 374);
            txtCuit.Name = "txtCuit";
            txtCuit.Size = new Size(346, 27);
            txtCuit.TabIndex = 7;
            // 
            // lblCuit
            // 
            lblCuit.AutoSize = true;
            lblCuit.Location = new Point(42, 341);
            lblCuit.Name = "lblCuit";
            lblCuit.Size = new Size(40, 20);
            lblCuit.TabIndex = 6;
            lblCuit.Text = "CUIT";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(42, 296);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(346, 27);
            txtEmail.TabIndex = 5;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(42, 263);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(42, 222);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(346, 27);
            txtApellido.TabIndex = 3;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(42, 189);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(66, 20);
            lblApellido.TabIndex = 2;
            lblApellido.Text = "Apellido";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(42, 150);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(346, 27);
            txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(42, 117);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
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
            // btnLimpiarCmb
            // 
            btnLimpiarCmb.BackColor = Color.DarkGray;
            btnLimpiarCmb.FlatAppearance.BorderSize = 0;
            btnLimpiarCmb.FlatAppearance.CheckedBackColor = Color.Black;
            btnLimpiarCmb.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnLimpiarCmb.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnLimpiarCmb.FlatStyle = FlatStyle.Flat;
            btnLimpiarCmb.Location = new Point(301, 512);
            btnLimpiarCmb.Margin = new Padding(5);
            btnLimpiarCmb.Name = "btnLimpiarCmb";
            btnLimpiarCmb.Size = new Size(115, 40);
            btnLimpiarCmb.TabIndex = 20;
            btnLimpiarCmb.Text = "Limpiar";
            btnLimpiarCmb.UseVisualStyleBackColor = false;
            btnLimpiarCmb.Click += btnLimpiarCmb_Click;
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
        private TextBox txtCuit;
        private Label lblCuit;
        private TextBox txtEmail;
        private Label lblEmail;
        private TextBox txtApellido;
        private Label lblApellido;
        private TextBox txtNombre;
        private Label lblNombre;
        private ListBox lstProveedores;
        private Button btnLimpiar;
        private Button btnListar;
        private Button btnVerDetalle;
        private Button btnEditar;
        private Button btnEliminar;
        private TextBox txtIDProveedor;
        private Label lblID;
        private Button btnLimpiarCmb;
    }
}