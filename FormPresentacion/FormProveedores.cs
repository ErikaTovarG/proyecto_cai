using Modelo.ProveedorModelo;
using Negocio.ProveedorNegocio;


namespace FormPresentacion
{
    public partial class FormProveedores : Form
    {
        public FormProveedores()
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

        private void btnLimpiarCmb_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtCuit.Clear();
            txtIDProveedor.Clear();
            txtEmail.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormAlertaEliminarProveedor>();
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
