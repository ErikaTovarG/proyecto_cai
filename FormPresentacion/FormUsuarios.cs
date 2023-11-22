using Modelo.UsuarioModelo;
using Negocio.UsuarioLogNegocio;
using Newtonsoft.Json;

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
            lstUsuarios.DataSource = usuariosWebServices;
        }   

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lstUsuarios.DataSource = null;
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

        private void btnVerDetalle_Click(object sender, EventArgs e)
        {
            if (lstUsuarios.SelectedItem != null)
            {
                UsuarioWebServices usuario = (UsuarioWebServices)lstUsuarios.SelectedItem;

                txtIDUsuario.Text = usuario.id.ToString();
                txtDNI.Text = usuario.dni.ToString();
                txtHost.Text = usuario.host.ToString();
                txtNombre.Text = usuario.nombre.ToString();
                txtApellido.Text = usuario.apellido.ToString();
                //txtUsuario.Text = usuario.usuario.ToString();
            }
        }

        private void FormUsuarios_Load(object sender, EventArgs e)
        {

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
