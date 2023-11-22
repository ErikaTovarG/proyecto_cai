using Microsoft.VisualBasic.Logging;
using Modelo.ProductoModelo;
using Modelo.UsuarioModelo;
using Negocio.ProductoNegocio;
using Negocio.UsuarioLogNegocio;
using Presentacion;

namespace FormPresentacion
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        #region Funciones del Login 
        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.LightGray;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.DimGray;
            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "CONTRASEÑA")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.LightGray;
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "CONTRASEÑA";
                txtContraseña.ForeColor = Color.DimGray;
                txtContraseña.UseSystemPasswordChar = false;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pctCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pctMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        private void MensajeError(string mensaje)
        {
            lblErrorMensaje.Text = mensaje;
            lblErrorMensaje.Visible = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Login login = new Login();
                login.NombreUsuario = txtUsuario.Text;
                login.Contraseña = txtContraseña.Text;
                int host = -1, intentosMaximos = 3;
                string idUsuario = null, test = "test";
                idUsuario = ClsUsuario.Login(login);
                if (idUsuario != null)
                {
                    test = idUsuario.Substring(1, idUsuario.Length - 2);
                    host = FuncionesAuxiliares.BuscarUsuarioYDevolverHost(Guid.Parse(test));
                    switch (host)
                    {
                        case 3:
                            FormPrincipal formAdmin = new FormPrincipal();
                            formAdmin.Show();
                            this.Hide();
                            break;
                        case 2:
                            FormPrincipalSupervisor formSuper = new FormPrincipalSupervisor();
                            formSuper.Show();
                            this.Hide();
                            break;
                        case 1:

                            FormPrincipalVendedor formVendedor = new FormPrincipalVendedor();
                            formVendedor.Show();
                            this.Hide();
                            ; break;
                    }
                }
                else
                {
                    int intentos = UsuarioSesion.ObtenerIntentosUsuario(login.NombreUsuario);
                    int intRestante= intentosMaximos - intentos;
                    if(intentos == 0 || (intentos != 0 && intentos < intentosMaximos))
                    {
                        // Incrementar el contador de intentos y mostrar un mensaje
                        UsuarioSesion.AgregarUsuarioLista(login.NombreUsuario);
                        MessageBox.Show($"Usuario o Contraseña ingresado incorrecto.");
                        txtUsuario.Clear();
                        txtContraseña.Clear();
                    }
                    
                    if(intRestante ==0)
                    {
                        // Desactivar el usuario después de superar el límite de intentos
                        UsuarioSesion.InactivarUsuario(login.NombreUsuario);
                        MessageBox.Show("Ha superado la cantidad de intentos.\n\n\tPóngase en contacto con el administrador.");
                        Application.Exit();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }

}