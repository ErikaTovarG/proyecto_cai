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

namespace Presentacion
{
    public class Program
    {
        private static int indiceContraseña = 0;


        public static void Main(string[] args)
        {
            Program programa = new Program();
            Activo activo = new Activo();
            Inactivo inactivo = new Inactivo();



            List<UsuarioModelo> usuariosCreados = new List<UsuarioModelo>();
            UsuarioModelo admin1 = new Administrador(Guid.NewGuid(), "Erika", "Tovar", "Av. 123", "111111", "etovar@GMAIL.COM", "CAI20232", "etovar", Convert.ToDateTime("01/09/2023"), Convert.ToDateTime("18/10/1991"), null, 1, 44665522,0, activo);   
            UsuarioModelo sup1 = new Supervisor(Guid.NewGuid(), "Andrea", "Rivera", "Av. cabildo", "22222", "acrs@GMAIL.COM", "CAI20232", "andrivera", Convert.ToDateTime("01/09/2023"), Convert.ToDateTime("18/10/1991"), null, 2, 8542658,0, activo);
            UsuarioModelo vend1 = new Vendedor(Guid.NewGuid(), "Facundo", "Cairo", "Av. belgrano", "33333", "facundo@GMAIL.COM", "CAI20232", "heygoogle", Convert.ToDateTime("01/09/2023"), Convert.ToDateTime("18/10/1991"), null, 3, 4845752,0, activo);
                        
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
            int opcion = SeleccionarOpcion(3);
            SeleccionarModulo(opcion, usuariosCreados);
        }
        private int SeleccionarOpcion(int cant)
        {
            bool flag;
            int salida = 0;
            do
            {
                Console.Write("Indique la opción con la cual desea continuar: ");
                string respuesta = Console.ReadLine().Trim();
                flag = Validaciones.ValidaEntero(respuesta, cant, ref salida);
            } while (!flag);

            return salida;
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
                            int opcion2 = SeleccionarOpcion(6);
                            Limpia();
                            SeleccionarOpcionesAdministrador(opcion2, usuarios);
                            break;
                        case 2:
                            Console.Clear();
                            Vistas.MenuSupervisor();
                            opcion2 = SeleccionarOpcion(7);
                            Limpia();
                            SeleccionarOpcionesSupervisor(opcion2, usuarios);
                            break;
                        case 1:
                            Console.Clear();
                            Vistas.MenuVendedor();
                            opcion2 = SeleccionarOpcion(3);
                            SeleccionarOpcionesVendedor(opcion2, usuarios);
                            Limpia();
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
        public bool Preguntar(UsuarioModelo usuario)
        {
            string res;
            bool flag;
            do
            {
                Console.Write("\n\t¿Desea intentar nuevamente? S/N: ");
                res = Console.ReadLine().ToUpper();
                flag = Validaciones.ValidaSyN(res);
            } while (!flag);

            if (res == "N") { Environment.Exit(0); }
            //Si la res es S, sumo el contador del usuario en 1 hasta que sea mayor igual a 3.
            if (res == "S")
            {
                usuario.Contador++;
                if (usuario.Contador >= 3)
                {
                    Console.WriteLine("\n ERROR: Ha excedido los intentos.\n El usuario {0} ha pasado a inactivo", usuario.Usuario);
                    Inactivo inactivo = new Inactivo();
                    usuario.Estado = inactivo;
                    Environment.Exit(0);
                }

            }
            return flag;
        }
        private Login PidoDatosEnLogin(Login login)
        {
            string usuarioIngresado, contrasenaIngresada, campo = "Usuario", campo2 = "Contraseña";
            bool flag;
            Console.WriteLine("\n");
            Console.WriteLine((" ").PadRight(48, '=') + "   " + DateTime.Now + $"{0:D}" + "   " + (" ").PadRight(48, '='));
            Console.WriteLine("\n¡Bienvenidos a ElectroHogar S.A!\n");

            do
            {
                Console.Write("\n\t Ingrese su Usuario: ");
                usuarioIngresado = Console.ReadLine().Trim();
                Console.Write("\t Ingrese su Contraseña: ");
                contrasenaIngresada = Console.ReadLine().Trim();
                flag = Validaciones.ValidaVacio(usuarioIngresado, ref campo) && Validaciones.ValidaVacio(contrasenaIngresada, ref campo2);
            } while (!flag);

            login.NombreUsuario = usuarioIngresado;
            login.Contraseña = contrasenaIngresada;
            return login;
        }
        private static int ListarUsuarios(Guid idUsuario)
        {
            List<UsuarioWebServices> usuarios = ClsUsuario.ListarUsuarios(Guid.Parse("D347CE99-DB8D-4542-AA97-FC9F3CCE6969"));           
            UsuarioWebServices usuarioEncontrado = usuarios.Find((usuario) => usuario.id == idUsuario);

            if (usuarioEncontrado != null)
            {
                return usuarioEncontrado.host; 
            }
            else
            {
                return -1; 
            }
        }

        private static UsuarioWebServices BuscarUsuarioCompletoDatos(Guid idUsuario)
        {
            List<UsuarioWebServices> usuarios = ClsUsuario.ListarUsuarios(Guid.Parse("D347CE99-DB8D-4542-AA97-FC9F3CCE6969"));
            UsuarioWebServices usuarioEncontrado = usuarios.Find((usuario) => usuario.id == idUsuario);

            if (usuarioEncontrado != null)
            {
                return usuarioEncontrado;
            }
            else
            {
                return null;
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
                    login = PidoDatosEnLogin(login);
                    idUsuario = ClsUsuario.Login(login);
                    test = idUsuario.Substring(1, idUsuario.Length - 2);
                    host = ListarUsuarios(Guid.Parse(test));
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

        private void SeleccionarOpcionesAdministrador(int opcion, List<UsuarioModelo> usuarios)
        {
            switch (opcion)
            {
                case 1:
                    Limpia();
                    Console.WriteLine("\n\tVas a crear un usuario Supervisor.\n");
                    UsuarioModelo usuarioSup = PideDatos.PedirUsuario(2);
                    usuarios.Add(usuarioSup);
                    Console.WriteLine("\n\tUsuario creado con exito.");
                    Limpia();
                    Vistas.OpcionesContinuar();
                    int op1 = SeleccionarOpcion(2);
                    OpcionAContinuar(op1, usuarios);
                    break;

                case 2:
                    int dniSupervisorNum = 0;
                    string campo = "DNI";
                    bool esValidoNum = false;
                    bool esValidoVacio = false;

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
                    Limpia();
                    Console.WriteLine("\n\tVas a crear un usuario Vendedor.\n");
                    UsuarioModelo usuarioVen = PideDatos.PedirUsuario(3);
                    usuarios.Add(usuarioVen);
                    Console.WriteLine("\n\tUsuario creado con exito.");
                    Limpia();
                    Vistas.OpcionesContinuar();
                    int op3 = SeleccionarOpcion(2);
                    OpcionAContinuar(op3, usuarios);
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

                default:
                    Environment.Exit(0);
                    break;
            }

        }
        public void OpcionAContinuar(int opcion, List<UsuarioModelo> usuarios)
        {
            switch (opcion)
            {
                case 1:
                    Limpia();
                    UsuarioModelo usuarioLogueado = new Administrador();
                    usuarioLogueado = null;
                    Vistas.MenuAdministrador();
                    int opcion2 = SeleccionarOpcion(5);
                    SeleccionarOpcionesAdministrador(opcion2, usuarios);
                    break;
                case 2:
                    Limpia();
                    Console.WriteLine("\nLos usuarios son: \n\n");
                    ListarUsuarios(usuarios);
                    Console.WriteLine("\n");
                    Console.WriteLine((" ").PadRight(60, '*'));
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
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

        private void Limpia()
        {
            Thread.Sleep(750);
            Console.Clear();
        }

        private void ListarUsuarios(List<UsuarioModelo> listaDeUsuarios)
        {

            foreach (var fila in listaDeUsuarios)
            {
                Console.WriteLine((" ").PadRight(60, '*'));
                Console.WriteLine($"{fila.ToString()}");
            }

        }

    }
}