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
    public partial class FormEditarProducto : Form
    {
        public FormEditarProducto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // abrir el formulario de alerta de editar
            string errores = "";
            int salidaInt = 0;
            double salidaDouble = 0;
            errores += Validaciones.ValidaVacio(txtNuevoPrecio.Text, "Nuevo precio");
            errores += Validaciones.ValidaVacio(txtNuevoStock.Text, "Nuevo stock");
            errores += Validaciones.ValDecimal(txtNuevoPrecio.Text, ref salidaDouble, "Nuevo precio");
            errores += Validaciones.ValidaNumerico(txtNuevoStock.Text, ref salidaInt, "Nuevo stock");

            if (!string.IsNullOrEmpty(errores))
            {
                MessageBox.Show("Error", errores);
            }
            else
            {
                this.Close();
                AbrirFormulario<FormAlertaEditarProducto>();
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiarDetalle_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtNuevoPrecio.Clear();
            txtNuevoStock.Clear();
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
