using Modelo.UsuarioModelo;
using Modelo.Proveedor;
using Modelo.Producto;
using Negocio.UsuarioLogNegocio;
using Modelo.Switch;
using System;
using System.Threading.Channels;
using System.Runtime.InteropServices;
using Negocio.ProductoNegocio;
using Negocio.ProveedorNegocio;
using Modelo.ProductoModelo;

namespace Presentacion
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Program programa = new Program();
            Activo activo = new Activo();
            Inactivo inactivo = new Inactivo();

            List<UsuarioModelo> usuariosCreados = new List<UsuarioModelo>();
            UsuarioModelo admin1 = new Administrador(Guid.NewGuid(), "Erika", "Tovar", "Av. 123", "111111", "etovar@GMAIL.COM", "CAI20232", "etovar", Convert.ToDateTime("01/09/2023"), Convert.ToDateTime("18/10/1991"), null, 1, 44665522, 0, activo);
            UsuarioModelo sup1 = new Supervisor(Guid.NewGuid(), "Andrea", "Rivera", "Av. cabildo", "22222", "acrs@GMAIL.COM", "CAI20232", "andrivera", Convert.ToDateTime("01/09/2023"), Convert.ToDateTime("18/10/1991"), null, 2, 8542658, 0, activo);
            UsuarioModelo vend1 = new Vendedor(Guid.NewGuid(), "Facundo", "Cairo", "Av. belgrano", "33333", "facundo@GMAIL.COM", "CAI20232", "heygoogle", Convert.ToDateTime("01/09/2023"), Convert.ToDateTime("18/10/1991"), null, 3, 4845752, 0, activo);

            admin1.Estado = inactivo;

            usuariosCreados.Add(admin1);
            usuariosCreados.Add(sup1);
            usuariosCreados.Add(vend1);
            programa.Inicia(usuariosCreados);

        }
        public void Inicia(List<UsuarioModelo> usuariosCreados)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();

            Vistas.MenuInicial();
            int opcion = FuncionesAuxiliares.SeleccionarOpcion(3);
            SeleccionarModulo(opcion, usuariosCreados);
        }


        private void SeleccionarModulo(int opcion, List<UsuarioModelo> usuarios)
        {
            int hostLogin;
            switch (opcion)
            {
                case 1:
                    Console.Clear();
                    hostLogin = LoginAction();
                    switch (hostLogin)
                    {
                        case 3:
                            Console.Clear();
                            Vistas.MenuAdministrador();
                            int opcion2 = FuncionesAuxiliares.SeleccionarOpcion(8);
                            FuncionesAuxiliares.Limpia();
                            SeleccionarOpcionesAdministrador(opcion2, usuarios);
                            break;
                        case 2:
                            Console.Clear();
                            Vistas.MenuSupervisor();
                            opcion2 = FuncionesAuxiliares.SeleccionarOpcion(7);
                            FuncionesAuxiliares.Limpia();
                            SeleccionarOpcionesSupervisor(opcion2, usuarios);
                            break;
                        case 1:
                            Console.Clear();
                            Vistas.MenuVendedor();
                            opcion2 = FuncionesAuxiliares.SeleccionarOpcion(3);
                            SeleccionarOpcionesVendedor(opcion2, usuarios);
                            FuncionesAuxiliares.Limpia();
                            break;
                        default:
                            Console.WriteLine("No se encontró.");
                            break;
                    }          
                    break;
                case 2:
                    Console.WriteLine("\nProximamente...");
                    break;
                default:
                    Environment.Exit(0);
                    break;
            }
        }
        
        

        private int LoginAction()
        {
            Login login = new Login();
            int host = -1; 
            int intentosMaximos = 3;
            bool loginExitoso = false;
            string idUsuario = null; 
            string test = "test";
            do
            {
                try
                {
                    login = PideDatos.PidoDatosEnLogin(login);
                    idUsuario = ClsUsuario.Login(login);
                    test = idUsuario.Substring(1, idUsuario.Length - 2);
                    host = FuncionesAuxiliares.BuscarUsuarioYDevolverHost(Guid.Parse(test));
                    loginExitoso = true;
                }
                catch (Exception ex)
                {
                    if (idUsuario == null)
                    {
                        UsuarioSesion.AgregarUsuarioLista(login.NombreUsuario);
                    }
                    //login.SumarIntentos();

                    if (login.Intentos >= intentosMaximos)
                    {
                        Console.WriteLine("Has excedido el número máximo de intentos. El programa se cerrará.");
                        Console.WriteLine(ex.Message);
                        break;
                    }        
                }
            } while (!loginExitoso);
            return host;
        }


        //public UsuarioModelo MenuLogin(List<UsuarioModelo> usuariosCreados)
        //{
        //    Login login = new Login();
        //    Activo activo = new Activo();
        //    bool inicioSesionExitoso = false;
        //    bool flag;
        //    UsuarioModelo usu2 = null;
        //    string idUsuario = null;
        //    try
        //    {
        //        login = PidoDatosEnLogin(login);
        //        idUsuario = ClsUsuario.Login(login);
        //        inicioSesionExitoso = true;

        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }


        //    if (inicioSesionExitoso)
        //    {
        //        ClsUsuario.validarDias(usu2);
        //        Console.WriteLine("\t\n Inicio de sesión exitoso. ¡Bienvenido!\n");
        //        Limpia();
        //        return usu2;
        //    }
        //    else
        //    {
        //        Console.WriteLine("\t\nInicio de sesión fallido. Credenciales incorrectas.");

        //        if (Preguntar(usu2))
        //        {
        //            Limpia();
        //            return MenuLogin(usuariosCreados);

        //        }
        //        else
        //        {
        //            return null;
        //        }
        //    }
        //}

        public static void SeleccionarOpcionesAdministrador(int opcion, List<UsuarioModelo> usuarios)
        {
            switch (opcion)
            {
                case 1:
                    FuncionesAuxiliares.Limpia();
                    Console.WriteLine("\n\tVas a crear un usuario Supervisor.\n");
                    UsuarioModelo usuarioSup = PideDatos.PedirUsuario(2);
                    usuarios.Add(usuarioSup);
                    Console.WriteLine("\n\tUsuario creado con exito.");
                    FuncionesAuxiliares.Limpia();
                    Vistas.OpcionesContinuarUsuario();
                    int op1 = FuncionesAuxiliares.SeleccionarOpcion(2);
                    FuncionesAuxiliares.OpcionAContinuarAdministrador(op1, usuarios);
                    break;

                case 2:
                    int dniSupervisorNum = 0;
                    string campo = "DNI";
                    bool esValidoNum = false, esValidoVacio = false;

                    do
                    {
                        Console.Write("Ingrese DNI de supervisor a eliminar: ");
                        string dniSupervisor = Console.ReadLine();
                        esValidoNum = Validaciones.ValidaNumerico(dniSupervisor, ref dniSupervisorNum);
                        esValidoVacio = Validaciones.ValidaVacio(dniSupervisor, ref campo);

                        if (esValidoNum && esValidoVacio)
                        { break; }
                        else
                        {
                            Console.WriteLine("Por favor, ingrese un DNI válido y no vacío.");
                        }
                    } while (true);


                    bool flag = ClsUsuario.EliminarSupervisorPorDni(usuarios, dniSupervisorNum);

                    if (flag)
                    {
                        Console.WriteLine("Se eliminó supervisor con DNI " + dniSupervisorNum);
                    }
                    else
                    {
                        Console.WriteLine("No se encontró supervisor con DNI " + dniSupervisorNum);
                    }

                    Console.ReadKey();
                    break;
                case 3:
                    FuncionesAuxiliares.Limpia();
                    Console.WriteLine("\n\tVas a crear un usuario Vendedor.\n");
                    UsuarioModelo usuarioVen = PideDatos.PedirUsuario(3);
                    usuarios.Add(usuarioVen);
                    Console.WriteLine("\n\tUsuario creado con exito.");
                    FuncionesAuxiliares.Limpia();
                    Vistas.OpcionesContinuarUsuario(); 
                    int op3 = FuncionesAuxiliares.SeleccionarOpcion(2);
                    FuncionesAuxiliares.OpcionAContinuarAdministrador(op3, usuarios);
                    break;
                case 4:

                    int dnivendedorNum = 0;
                    campo = "DNI";
                    esValidoNum = false;
                    esValidoVacio = false;
                    flag = false;

                    do
                    {
                        Console.Write("Ingrese DNI de vendedor a eliminar: ");
                        string dniSupervisor = Console.ReadLine();
                        esValidoNum = Validaciones.ValidaNumerico(dniSupervisor, ref dnivendedorNum);
                        esValidoVacio = Validaciones.ValidaVacio(dniSupervisor, ref campo);

                        if (esValidoNum && esValidoVacio)
                        { break; }
                        else
                        {
                            Console.WriteLine("Por favor, ingrese un DNI válido y no vacío.");
                        }
                    } while (true);

                    flag = ClsUsuario.EliminarVendedorPorDni(usuarios, dnivendedorNum);

                    if (flag)
                    {
                        Console.WriteLine("Se eliminó vendedor con DNI " + dnivendedorNum);
                    }
                    else
                    {
                        Console.WriteLine("No se encontró vendedor con DNI " + dnivendedorNum);
                    }

                    Console.ReadKey();
                    break;
                case 5:
                    Console.WriteLine(" Proximamente ");

                    break;
                //case 6:
                //    Console.WriteLine("\nElegiste la opción para cambiar contraseña.\n");
                //    bool flag1;
                //    do
                //    {
                //        Console.Write("\n Ingrese su contraseña actual: ");
                //        string contraseniaActual = Console.ReadLine();
                //        Console.Write("\n Ingrese una nueva contraseña: ");
                //        string nuevaContrasenia = Console.ReadLine();
                //        flag1 = ClsUsuario.CambiarContrasenia(usuarioLogueado, contraseniaActual, nuevaContrasenia);
                //    } while (!flag1);
                //    break;
                case 7:
                    FuncionesAuxiliares.ListarProductos();
                    Vistas.OpcionesContinuarProducto();
                    int op7 = FuncionesAuxiliares.SeleccionarOpcion(2);
                    FuncionesAuxiliares.OpcionAContinuarAdministrador(op7, usuarios);
                    break;
                case 8:
                    FuncionesAuxiliares.ListarUsuarios();
                    Vistas.OpcionesContinuarUsuario();
                    int op8 = FuncionesAuxiliares.SeleccionarOpcion(2);
                    FuncionesAuxiliares.OpcionAContinuarAdministrador(op8, usuarios);
                    break;
                case 9: 
                    Console.WriteLine("\nVas a modificar un proveedor.\n");
                    esValidoNum = false;
                    esValidoVacio = false;
                    campo = "CUIT";
                    int cuitSalida = 0;
                    bool flag2 = false;
                    do
                    {

                        Console.Write("\nIngrese el CUIT del proveedor que desea modificar: ");
                        string cuit = Console.ReadLine();
                        Console.Write("\nIngrese el nuevo nombre para el proveedor: ");
                        string nuevoNombre = Console.ReadLine();
                        esValidoNum = Validaciones.ValidaNumerico(cuit, ref cuitSalida);
                        esValidoVacio = Validaciones.ValidaVacio(nuevoNombre, ref campo);

                        
                        if(esValidoNum & esValidoVacio)
                        {
                            flag2 = ClsProveedor.ModificarProveedor(Convert.ToInt32(cuit), nuevoNombre);
                        }

                        if (flag2)
                        {
                            Console.WriteLine("\nSe modificó correctamente el proveedor con CUIT: {0}\n", cuit);
                        }

                    } while (!flag2 || !esValidoNum || !esValidoVacio); 
                   

                    break;
                //case 6:
                //    Console.WriteLine("\nElegiste la opción para cambiar contraseña.\n");
                //    bool flag1;
                //    do
                //    {
                //        Console.Write("\n Ingrese su contraseña actual: ");
                //        string contraseniaActual = Console.ReadLine();
                //        Console.Write("\n Ingrese una nueva contraseña: ");
                //        string nuevaContrasenia = Console.ReadLine();
                //        flag1 = ClsUsuario.CambiarContrasenia(usuarioLogueado, contraseniaActual, nuevaContrasenia);
                //    } while (!flag1);
                //    break;

                default:
                    Environment.Exit(0);
                    break;
            }

        }

        private void SeleccionarOpcionesSupervisor(int opcion, List<UsuarioModelo> usuarios)
        {
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Proximamente.");
                    break;
                case 2:
                    Console.WriteLine("Proximamente.");
                    break;
                case 3:
                    Console.WriteLine("Proximamente.");
                    break;
                case 4:
                    Console.WriteLine("Proximamente.");
                    break;
                case 5:
                    Console.WriteLine("Proximamente.");
                    break;
                case 6:
                    Console.WriteLine("Proximamente.");
                    break;
                //case 7:
                //    Console.WriteLine("\nElegiste la opción para cambiar contraseña.\n");
                //    bool flag = false;
                //    do
                //    {
                //        Console.Write("\n Ingrese su contraseña actual: ");
                //        string contraseniaActual = Console.ReadLine();
                //        Console.Write("\n Ingrese una nueva contraseña: ");
                //        string nuevaContrasenia = Console.ReadLine();
                //        flag = ClsUsuario.CambiarContrasenia(usuarioLogueado, contraseniaActual, nuevaContrasenia);
                //    } while (!flag);
                //    break;
            }
        }

        private void SeleccionarOpcionesVendedor(int opcion, List<UsuarioModelo> usuarios)
        {
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Proximamente.");
                    break;
                case 2:
                    Console.WriteLine("Proximamente.");
                    break;
                //case 3:
                //    Console.WriteLine("\nElegiste la opción para cambiar contraseña.\n");
                //    bool flag;
                //    do
                //    {
                //        Console.Write("\n Ingrese su contraseña actual: ");
                //        string contraseniaActual = Console.ReadLine();
                //        Console.Write("\n Ingrese una nueva contraseña: ");
                //        string nuevaContrasenia = Console.ReadLine();
                //        flag = ClsUsuario.CambiarContrasenia(usuarioLogueado, contraseniaActual, nuevaContrasenia);
                //    } while (!flag);
                //    break;
            }
        }

    }
}