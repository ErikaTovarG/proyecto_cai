using Modelo.Producto;
using Negocio.ProductoNegocio;

namespace FormPresentacion
{
    public partial class FormAlertaEliminarProducto : Form
    {
        public string IdProducto { get; set; }
        public FormAlertaEliminarProducto()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Guid idProductoGuid = Guid.Parse(IdProducto);
                string productoEncontrado = ClsProducto.BuscarProveedorPorId_DevolverString(idProductoGuid);
                ClsProducto.EliminarProductoPorId(productoEncontrado);

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
