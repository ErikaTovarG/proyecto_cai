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
            if (txtUsuario.Text != "USUARIO")
            {
                if (txtContraseña.Text != "CONTRASEÑA")
                {
                    Login login = new Login();
                    login.NombreUsuario = txtUsuario.Text;
                    login.Contraseña = txtContraseña.Text;
                    int host = -1, intentosMaximos = 3;
                    string idUsuario = null, test = "test";
                    try
                    {
                        //login = PideDatos.PidoDatosEnLogin(login);
                        idUsuario = ClsUsuario.Login(login);
                        test = idUsuario.Substring(1, idUsuario.Length - 2);
                        host = FuncionesAuxiliares.BuscarUsuarioYDevolverHost(Guid.Parse(test));
                        switch (host)
                        {
                            case 3:
                                FormPrincipal formAdmin = new FormPrincipal();
                                formAdmin.Show();
                                this.Hide();
                                //FuncionesAuxiliares.MostrarAlertaDeStockBajo(listaProductos);
                                //int opcion2 = FuncionesAuxiliares.SeleccionarOpcion(13);

                                //SeleccionarOpcionesAdministrador(opcion2, usuarios);

                                break;
                            case 2:
                                FormPrincipalSupervisor formSuper = new FormPrincipalSupervisor();
                                formSuper.Show();
                                this.Hide();
                                //funcionesauxiliares.mostraralertadestockbajo(listaproductos2);
                                //opcion2 = funcionesauxiliares.seleccionaropcion(7);
                                //seleccionaropcionessupervisor(opcion2, usuarios);
                                break;
                            case 1:

                                FormPrincipalVendedor formVendedor = new FormPrincipalVendedor();
                                formVendedor.Show();
                                this.Hide();
                                ; break;
                                //case 1:
                                //    Console.Clear();
                                //    Vistas.MenuVendedor();
                                //    opcion2 = FuncionesAuxiliares.SeleccionarOpcion(3);
                                //    SeleccionarOpcionesVendedor(opcion2, usuarios);
                                //    FuncionesAuxiliares.Limpia();
                                //    break;
                                //default:
                                //    Console.WriteLine("No se encontró.");
                                //    break;
                        }
                    }
                    catch (Exception ex)
                    {
                        if (idUsuario == null)
                        {
                            UsuarioSesion.AgregarUsuarioLista(login.NombreUsuario);
                        }

                        if (login.Intentos >= intentosMaximos)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                else MensajeError("Por favor ingrese una contraseña");
            }
            else MensajeError("Por favor ingrese un usuario");

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }

}