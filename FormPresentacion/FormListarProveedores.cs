using Modelo.ProveedorModelo;
using Negocio.ProveedorNegocio;


namespace FormPresentacion
{
    public partial class FormListarProveedores : Form
    {
        public FormListarProveedores()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lstProveedores.Items.Clear();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            List<ProveedorWebServices> proveedorWebServices = ClsProveedor.ListarProveedores();

            foreach (var proveedor in proveedorWebServices)
            {
                lstProveedores.Items.Add(proveedor.ToString());
            }
        }
    }
}
