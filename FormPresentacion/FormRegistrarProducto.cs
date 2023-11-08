using Modelo.ProductoModelo;
using Modelo.ProveedorModelo;
using Negocio.ProductoNegocio;
using Negocio.ProveedorNegocio;

namespace FormPresentacion
{
    public partial class FormRegistrarProducto : Form
    {
        public FormRegistrarProducto()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiarDetalle_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void FormRegistrarProducto_Load(object sender, EventArgs e)
        {
            CargarListaCategoria();
            CargarListaProveedores();
            CargarStock();
        }

        private void CargarListaCategoria()
        {
            List<CategoriaProductos> categoriaProductos = ClsProducto.ListarCategorias();
            cmbCategoria.DataSource = null;
            cmbCategoria.DataSource = categoriaProductos;
            cmbCategoria.DisplayMember = "Nombre";
            cmbCategoria.ValueMember = "IdCategoria";
        }
        private void CargarListaProveedores()
        {
            List<ProveedorWebServices> proveedores = ClsProveedor.ListarProveedores();
            cmbProveedor.DataSource = null;
            cmbProveedor.DataSource = proveedores;
            cmbProveedor.DisplayMember = "Nombre";
            cmbProveedor.ValueMember = "Cuit";
        }
        private void CargarStock()
        {
            int[] stock = new int[] { 1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20};
            cmbStock.DataSource = null;
            cmbStock.DataSource = stock;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            int stock = Convert.ToInt32(cmbStock.SelectedValue);
            int idCategoria = Convert.ToInt32(cmbCategoria.SelectedValue);
            string ciutProveedor = cmbProveedor.SelectedValue.ToString();
            string proveedorEncontrado = ClsProveedor.BuscarProveedorPorCuitYDevolverString(ciutProveedor);
            string Usuario = "D347CE99-DB8D-4542-AA97-FC9F3CCE6969";
            string nombre = txtNombre.Text;
            string precio = txtPrecio.Text;
            string errores = "";
            double salida = 0;

            errores += Validaciones.ValDecimal(precio, ref salida, "Precio");
            errores += Validaciones.ValidaVacio(nombre, "Nombre");

            if (!string.IsNullOrEmpty(errores))
                MessageBox.Show(errores);   
            else
            {
                ProductoWebServicesPost ProductoAgregar = new ProductoWebServicesPost();
                ProductoAgregar.IdCategoria = idCategoria;
                ProductoAgregar.IdUsuario = Usuario;
                ProductoAgregar.IdProveedor = proveedorEncontrado;
                ProductoAgregar.Nombre = nombre;
                ProductoAgregar.Precio = salida;
                ProductoAgregar.Stock = stock;

                ClsProducto.CrearProducto(ProductoAgregar);

                MessageBox.Show("Se agrego el producto con exito!");
                LimpiarCampos();

            }
        }
        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtPrecio.Clear();
            cmbProveedor.SelectedIndex = 0;
            cmbCategoria.SelectedIndex = 0;
            cmbStock.SelectedIndex = 0;
        }

    }
}
