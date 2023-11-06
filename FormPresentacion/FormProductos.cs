using Modelo.ProductoModelo;
using Modelo.UsuarioModelo;
using Negocio.ProductoNegocio;
using Negocio.UsuarioLogNegocio;
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
    public partial class FormProductos : Form
    {
        public FormProductos()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            List<ProductoWebServices> productoWebServices = ClsProducto.ListarProductos();
            lstProductos.DataSource = productoWebServices;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lstProductos.DataSource = null;
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

        private void btnLimpiarCategoria_Click(object sender, EventArgs e)
        {
            lstProductosCategoria.Items.Clear();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormRegistrarProducto>();
        }

        private void btnVerDetalle_Click(object sender, EventArgs e)
        {
           if (lstProductos.SelectedItem != null)
           {
            ProductoWebServices producto = (ProductoWebServices)lstProductos.SelectedItem;

            txtNombre.Text = producto.Nombre.ToString();
            txtPrecio.Text = producto.Precio.ToString();
            txtStock.Text = producto.Stock.ToString();
            txtCategoria.Text = producto.IdCategoria.ToString();
            txtIDProveedor.Text = producto.Id.ToString();
           }
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
