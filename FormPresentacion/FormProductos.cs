using Modelo.Producto;
using Modelo.ProductoModelo;
using Modelo.ProveedorModelo;
using Modelo.UsuarioModelo;
using Negocio.ProductoNegocio;
using Negocio.ProveedorNegocio;
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
            txtIDproducto.Clear();
            txtCategoria.Clear();
            txtNombre.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtIDproducto.Text))
            {
                FormAlertaEliminarProducto formAlerta = new FormAlertaEliminarProducto();
                string idProducto = txtIDproducto.Text;
                formAlerta.IdProducto = idProducto;
                formAlerta.ShowDialog();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Debe seleccionar de la lista el producto que desea eliminar.");
            }
        }

        private void btnLimpiarCategoria_Click(object sender, EventArgs e)
        {
            cmbCategoria.SelectedIndex = 0;
            lstProductosCategoria.DataSource = null;
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
                txtIDproducto.Text = producto.Id.ToString();
            }
        }

        private void FormProductos_Load(object sender, EventArgs e)
        {
            CargarListaCategoria();
        }

        private void AbrirFormulario<T>() where T : Form, new()
        {
            T form = new T();
            form.TopLevel = true;
            form.ShowDialog();
            form.Dock = DockStyle.Fill;
            form.BringToFront();
        }
        private void CargarListaCategoria()
        {
            List<CategoriaProductos> categoriaProductos = ClsProducto.ListarCategorias();
            cmbCategoria.DataSource = null;
            cmbCategoria.DataSource = categoriaProductos;
            cmbCategoria.DisplayMember = "Nombre";
            cmbCategoria.ValueMember = "IdCategoria";
        }

        private void btnListarCategoria_Click(object sender, EventArgs e)
        {

            CargarListaPorCategoria();
        }

        private void CargarListaPorCategoria()
        {
            try
            {
                List<ProductoWebServices> productos = new List<ProductoWebServices>();
                productos = ClsProducto.ListarProductosPorCategoria(Convert.ToInt32(cmbCategoria.SelectedValue));
                lstProductosCategoria.DataSource = null;
                lstProductosCategoria.DataSource = productos;
                lstProductosCategoria.DisplayMember = "ListarPorCategoria";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al traer la lista" + ex.Message);
            }
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
            txtCategoria.Clear();
            txtIDproducto.Clear();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //se abre si la lista de productos no está vacía y si seleccinó un detalle
            
            if (lstProductos.SelectedItem != null && !string.IsNullOrEmpty(txtIDproducto.Text))
            {
                AbrirFormulario<FormEditarProducto>();
                LimpiarCampos();
                lstProductos.DataSource = null;

            }else
            {
                MessageBox.Show("Seleccione el detalle de un producto a editar.");
            }    
        }


    }
}
