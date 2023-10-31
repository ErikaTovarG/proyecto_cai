using Modelo.ProductoModelo;
using Negocio.ProductoNegocio;
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
    public partial class FormListarProductos : Form
    {
        public FormListarProductos()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            List<ProductoWebServices> productoWebServices = ClsProducto.ListarProductos();

            foreach (var producto in productoWebServices)
            {
                lstProductos.Items.Add(producto.ToString());
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lstProductos.Items.Clear();
        }

        private void btnLimpiarDetalle_Click(object sender, EventArgs e)
        {
            txtIDProveedor.Clear();
            txtCategoria.Clear();
            txtNombre.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormAlertaEliminarProducto>();
        }
        private void AbrirFormulario<T>() where T : Form, new()
        {
            T form = new T();
            form.TopLevel = true;
            form.ShowDialog();
            form.Dock = DockStyle.Fill;
            form.BringToFront();
        }
    }
}
