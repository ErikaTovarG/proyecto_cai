using Modelo.UsuarioModelo;
using Negocio.UsuarioLogNegocio;

namespace FormPresentacion
{
    public partial class FormUsuarios : Form
    {
        public FormUsuarios()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            List<UsuarioWebServices> usuariosWebServices = ClsUsuario.ListarUsuarios(Guid.Parse("D347CE99-DB8D-4542-AA97-FC9F3CCE6969"));
            lstUsuarios.Items.Clear();

            foreach (var usuario in usuariosWebServices)
            {
                lstUsuarios.Items.Add(usuario.ToString());
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lstUsuarios.Items.Clear();
        }

        private void btnLimpiarDetalle_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtIDUsuario.Clear();
            txtUsuario.Clear();
            txtApellido.Clear();
            txtHost.Clear();
            txtDNI.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            AbrirFormulario<FormAlertaEliminarUsuario>();
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormRegistrarUsuario>();
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
