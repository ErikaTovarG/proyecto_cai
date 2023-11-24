using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormPresentacion
{
    public partial class FormEditarProveedor : Form
    {
        public FormEditarProveedor()
        {
            InitializeComponent();
        }

        private void FormEditarProveedor_Load(object sender, EventArgs e)
        {
            
        }

        private void btnEditarProveedor_Click(object sender, EventArgs e)
        {
           
            string errores = "";
            int salidaInt = 0;
            errores += Validaciones.ValidaVacio(txtNuevoNombre.Text, "Nuevo nombre");
            errores += Validaciones.ValidaVacio(txtNuevoApellido.Text, "Nuevo apellido");
            errores += Validaciones.ValidaEmail(txtNuevoEmail.Text, "Email");
            errores += Validaciones.ValidaNumerico(txtNuevoCuit.Text, ref salidaInt, "Nuevo Nro. Cuit");

            if (!string.IsNullOrEmpty(errores))
            {
                MessageBox.Show(errores, "Error");
            }
            else
            {
                this.Close();
                AbrirFormulario<FormAlertaEditarProveedor>();
            }
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void limpiarCampos()
        {
            txtNuevoNombre.Clear();
            txtNuevoApellido.Clear();
            txtNuevoEmail.Clear();
            txtNuevoCuit.Clear();
        }

        public void AbrirFormulario<T>() where T : Form, new()
        {
            T form = new T();
            form.TopLevel = true;
            form.ShowDialog();
            form.Dock = DockStyle.Fill;
            form.BringToFront();
        }
    }
}
