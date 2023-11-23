using Modelo.ProductoModelo;
using Modelo.Proveedor;
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
            lstProveedores.DataSource = null;
            lstProveedores.Items.Clear();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            List<ProveedorWebServices> proveedorWebServices = ClsProveedor.ListarProveedores();
            lstProveedores.DataSource = proveedorWebServices;
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
            if (!string.IsNullOrEmpty(txtCuit.Text))
            {
                FormAlertaEliminarProveedor formAlerta = new FormAlertaEliminarProveedor();
                string cuit = txtCuit.Text;
                formAlerta.Cuit = cuit;
                formAlerta.ShowDialog();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Debe seleccionar de la lista el proveedor que desea eliminar.");
            }
        }

        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormRegistrarProveedor>();
        }

        private void btnVerDetalle_Click(object sender, EventArgs e)
        {
            if (lstProveedores.SelectedItem != null)
            {
                ProveedorWebServices proveedor = (ProveedorWebServices)lstProveedores.SelectedItem;

                txtCuit.Text = proveedor.Cuit.ToString();
                txtApellido.Text = proveedor.Apellido.ToString();
                txtNombre.Text = proveedor.Nombre.ToString();
                txtIDProveedor.Text = proveedor.Id.ToString();
                txtEmail.Text = proveedor.Email.ToString();
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

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtCuit.Clear();
            txtIDProveedor.Clear();
            txtEmail.Clear();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
         

            if (lstProveedores.SelectedItem != null && !string.IsNullOrEmpty(txtIDProveedor.Text))
            {
                AbrirFormulario<FormEditarProveedor>();
                LimpiarCampos();
                lstProveedores.DataSource = null;

            }
            else
            {
                MessageBox.Show("Seleccione el detalle de un proveedor a editar.");
            }
        }
    }
}
