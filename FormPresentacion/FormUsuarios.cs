using Modelo.ProveedorModelo;
using Modelo.UsuarioModelo;
using Negocio.UsuarioLogNegocio;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net;

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
            List<UsuarioWebServices> usuariosWebServices = ClsUsuario.ListarUsuarios();
            lstUsuarios.DataSource = usuariosWebServices;
            lstUsuarios.DisplayMember = "ComboDisplay";
            lstUsuarios.ValueMember = "Id";

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
            if (lstUsuarios.SelectedItem != null && (!string.IsNullOrEmpty(txtIDUsuario.Text) && !string.IsNullOrEmpty(txtDNI.Text) && !string.IsNullOrEmpty(txtHost.Text) && !string.IsNullOrEmpty(txtNombre.Text) && !string.IsNullOrEmpty(txtApellido.Text)))
            {
                AbrirFormulario<FormAlertaEliminarUsuario>();
                LimpiarCampos();
                lstUsuarios.DataSource = null;
                lstUsuarios.Items.Remove(lstUsuarios.SelectedItem);

            }
            else
            {
                MessageBox.Show("Seleccione el detalle de un usuario a eliminar.");
            }

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
                txtUsuario.Text = usuario.nombreUsuario.ToString();
            }
        }
        private void btnReactivarUsuario_Click_1(object sender, EventArgs e)
        {
            try
            {

                string idUsuario = txtIDUsuario.Text;
                string error = Validaciones.ValidaVacio(idUsuario, "ID");

                if (!string.IsNullOrEmpty(error)) MessageBox.Show("Se requiere el ID del usuario a reactivar.");
                else
                {
                    ClsUsuario.ReactivarUsuario(idUsuario);
                    MessageBox.Show("Se reactivo el usuario correctamente");
                    LimpiarCampos();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        public void LimpiarCampos()
        {
            txtIDUsuario.Clear();
            txtDNI.Clear();
            txtHost.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
        }
        private void FormUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //no está el endóint para editar parcialmente un usuario. 

        }

        private void btnUsuariosActivos_Click(object sender, EventArgs e)
        {
            
           List<UsuarioWebServices> usuariosWebServices = ClsUsuario.ListarUsuarios();

            lstUsuariosActivos.DataSource = usuariosWebServices;
            lstUsuariosActivos.DisplayMember = "ComboDisplay";
            lstUsuariosActivos.ValueMember = "Id";

            
        }

        public void AbrirFormulario<T>() where T : Form, new()
        {
            T form = new T();
            form.TopLevel = true;
            form.ShowDialog();
            form.Dock = DockStyle.Fill;
            form.BringToFront();
        }

    }
}
