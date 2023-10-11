using Modelo.UsuarioModelo;
using Negocio.UsuarioLogNegocio;
using Modelo.Switch;
using System;
using System.Threading.Channels;
using System.Runtime.InteropServices;
using Modelo.UsuarioWS;

namespace Presentacion
{
    public class Program
    {
        public static void Main(string[] args)

        {
            Program programa = new Program();

            Activo activo = new Activo();
            Inactivo inactivo = new Inactivo();

            int indiceContraseña = 0;
            String Contraseña = "Password_" + indiceContraseña;

            List<UsuarioModelo> usuariosCreados = new List<UsuarioModelo>();
            UsuarioModelo admin1 = new Administrador(Guid.NewGuid(), "Erika", "Tovar", "Av. 123", "111111", "etovar@GMAIL.COM", "CAI20232", "etovar", Convert.ToDateTime("01/09/2023"), Convert.ToDateTime("18/10/1991"), null, 1, 44665522, 0, activo);
            UsuarioModelo sup1 = new Supervisor(Guid.NewGuid(), "Andrea", "Rivera", "Av. cabildo", "22222", "acrs@GMAIL.COM", "CAI20232", "andrivera", Convert.ToDateTime("01/09/2023"), Convert.ToDateTime("18/10/1991"), null, 2, 8542658, 0, activo);
            UsuarioModelo vend1 = new Vendedor(Guid.NewGuid(), "Facundo", "Cairo", "Av. belgrano", "33333", "facundo@GMAIL.COM", "CAI20232", "heygoogle", Convert.ToDateTime("01/09/2023"), Convert.ToDateTime("18/10/1991"), null, 3, 4845752, 0, activo);

            UsuarioWS usr = new UsuarioWS();
            // (Guid.NewGuid(), "Rodolfo ","Zavala", "Calle false","123", null, null, null, DateTime.Now.AddYears(-30), DateTime.Now.AddYears(-30), null, 1, 4443333, 0, activo) ;

            usr.Host = 1;
            usr.Nombre = "Rodolfo ";
            usr.Apellido = "Zavala";
            usr.Dni = 32531831;
            usr.Direccion = "Calle false 123";
            usr.Telefono = "44443333";
            usr.Email = "test@test.com";
            usr.FechaNacimiento = DateTime.Now.AddYears(-30);
            usr.NombreUsuario = "AyudanteCAI";
            usr.Contraseña = Contraseña;
            ClsUsuario.CrearUsuario(usr);

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
            int opcion = SeleccionarOpcion(2);
            SeleccionarModulo(opcion, usuariosCreados);
        }
        private int SeleccionarOpcion(int cant)
        {
            bool flag;
            int salida = 0;
            do
            {
                Console.Write("Indique la opción con la cual desea continuar: ");
                string respuesta = Console.ReadLine().Trim ();
                flag = Validaciones.ValidaEntero(respuesta, cant, ref salida);
            } while (!flag);

            return salida;
        }
        private void SeleccionarModulo(int opcion, List<UsuarioModelo> usuarios)
        {
            switch (opcion)
            {
                case 1:
                    Console.Clear();
                    UsuarioModelo usuarioLogueado = MenuLogin(usuarios);
                    int cantidadOpciones = 10;

                    if (usuarioLogueado != null)
                    {
                        switch (usuarioLogueado.Host)
                        {
                            
                            case 1:
                                Vistas.MenuAdministrador();                        
                                int opcion2 = SeleccionarOpcion(cantidadOpciones);
                                Limpia();
                                SeleccionarOpcionesAdministrador(opcion2, usuarios, usuarioLogueado);
                                break;
                            case 2:
                                Vistas.MenuSupervisor();
                                opcion2 = SeleccionarOpcion(cantidadOpciones);
                               // Vistas.VistaSupervisor();                          
                                Limpia();
                                SeleccionarOpcionesSupervisor(opcion2, usuarios, usuarioLogueado);
                                Limpia();
                                break;
                            case 3:
                                Vistas.MenuVendedor();
                                opcion2 = SeleccionarOpcion(cantidadOpciones);
                                SeleccionarOpcionesVendedor(opcion2, usuarios, usuarioLogueado);
                                Limpia();
                                break;
                            default:
                                Console.WriteLine("No se encontró.");
                                break;
                        }

                    }
                    break;

                case 2:
                    Salir();
                    break;
                default:
                    Environment.Exit(0);
                    break;
            }
        }
        public bool volverAIntentar(UsuarioModelo usuario)
        {
            string reIntentar;
            bool flag;
            do
            {
                Console.Write("\n\t¿Desea intentar nuevamente? S/N: ");
                reIntentar = Console.ReadLine().ToUpper();
                flag = Validaciones.ValidaSyN(reIntentar);
            } while (!flag);

            if (reIntentar == "N") {
                Salir(); }
            //Si la res es S, sumo el contador del usuario en 1 hasta que sea mayor igual a 3.
            if (reIntentar == "S")
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

        public UsuarioModelo MenuLogin(List<UsuarioModelo> usuariosCreados)
        {
            string usuarioIngresado, contrasenaIngresada;
            string campo = "Usuario";
            string campo2 = "Contraseña";
            Activo activo = new Activo();
            bool inicioSesionExitoso = false;
            bool flag;
            UsuarioModelo usu2 = null;
            Console.WriteLine("\n");
            Console.WriteLine((" ").PadRight(48, '=') + "   " + DateTime.Now + $"{0:D}" + "   " + (" ").PadRight(48, '='));
            Console.WriteLine("\n¡Bienvenidos a ElectroHogar S.A!\n");

            //valido que haya ingresado un usuario.
            do
            {
                Console.Write("\n\t Ingrese su Usuario: ");
                usuarioIngresado = Console.ReadLine().Trim();
                Console.Write("\t Ingrese su Contraseña: ");
                contrasenaIngresada = Console.ReadLine().Trim();
                //Valido que ni el usario ni la contraseña estén vacíos.
                flag = Validaciones.ValidaVacio(usuarioIngresado, ref campo); Validaciones.ValidaVacio(contrasenaIngresada, ref campo2);

            } while (!flag);

            foreach (var usu in usuariosCreados)
            {
                if (usu.Usuario == usuarioIngresado && usu.Contrasenia == contrasenaIngresada) 
                { 
                        // if (usu.Estado == activo && usu.logueadas > 1)
                            {
                                 
                                 inicioSesionExitoso = true;
                                 usu2 = usu;
                                 usu2.Estado = activo;      
                                 break;

                             }
                }
                if(usu.Usuario == usuarioIngresado)
                {
                    usu2 = usu;
                }
            }

            if (inicioSesionExitoso)
            {
                ClsUsuario.validarDias(usu2);
                Console.WriteLine("\t\n Inicio de sesión exitoso. ¡Bienvenido!\n");
                Limpia();
                return usu2;
            }
            else
            {
                Console.WriteLine("\t\nInicio de sesión fallido. Credenciales incorrectas.");
              
                if (volverAIntentar(usu2))
                {
                    Limpia();
                    return MenuLogin(usuariosCreados);
                   
                }
                else
                {
                    return null;
                }
            }
        }

          private void SeleccionarOpcionesAdministrador(int opcion, List<UsuarioModelo> usuarios, UsuarioModelo usuarioLogueado)
        {
            switch (opcion)
            {
                case 0:
                    Salir();
                    break;
                case 1:
                    Limpia();
                    Console.WriteLine("\n\tVas a crear un usuario Supervisor.\n");
                    //Prueba
                    //usr.IdUsuario = "D347CE99-DB8D-4542-AA97-FC9F3CCE6969";

                    // Fin de prueba
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
                        {break;}
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
                    Console.WriteLine(" Proximamente " );
                    break;
                case 6:
                    Console.WriteLine("\nElegiste la opción para cambiar contraseña.\n");
                    bool flag1;
                    do
                    {
                        Console.Write("\n Ingrese su contraseña actual: ");
                        string contraseniaActual = Console.ReadLine();
                        Console.Write("\n Ingrese una nueva contraseña: ");
                        string nuevaContrasenia = Console.ReadLine();
                        flag1 = ClsUsuario.CambiarContrasenia(usuarioLogueado, contraseniaActual, nuevaContrasenia);
                    } while (!flag1);
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
                    SeleccionarOpcionesAdministrador(opcion2,usuarios,usuarioLogueado);
                    break;
                case 2:
                    Limpia();
                    Console.WriteLine("\nLos usuarios son: \n\n");
                    ListarUsuarios(usuarios);
                    Console.WriteLine("\n");
                    Console.WriteLine((" ").PadRight(60, '*'));
                    break;
                case 3:
                    Salir();
                    break;
                default : Environment.Exit(0);
                    break;
            }
        }

        private void SeleccionarOpcionesSupervisor(int opcion, List<UsuarioModelo> usuarios, UsuarioModelo usuarioLogueado)
        {
            switch (opcion)
            {
                case 0:
                    Salir();
                    break;
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
                case 7:
                    Console.WriteLine("\nElegiste la opción para cambiar contraseña.\n");
                    bool flag = false;
                    do
                    {
                        Console.Write("\n Ingrese su contraseña actual: ");
                        string contraseniaActual = Console.ReadLine();
                        Console.Write("\n Ingrese una nueva contraseña: ");
                        string nuevaContrasenia = Console.ReadLine();
                        flag = ClsUsuario.CambiarContrasenia(usuarioLogueado,contraseniaActual,nuevaContrasenia);
                    } while (!flag);
                    break;
            }
        }

        private void SeleccionarOpcionesVendedor(int opcion, List<UsuarioModelo> usuarios, UsuarioModelo usuarioLogueado)
        {
            switch (opcion)
            {
                case 0:
                    Salir();
                    break;
                case 1:
                    Console.WriteLine("Proximamente.");
                    break;
                case 2:
                    Console.WriteLine("Proximamente.");
                    break;
                case 3:
                    Console.WriteLine("\nElegiste la opción para cambiar contraseña.\n");
                    bool flag;
                    do
                    {
                        Console.Write("\n Ingrese su contraseña actual: ");
                        string contraseniaActual = Console.ReadLine();
                        Console.Write("\n Ingrese una nueva contraseña: ");
                        string nuevaContrasenia = Console.ReadLine();
                        flag = ClsUsuario.CambiarContrasenia(usuarioLogueado, contraseniaActual, nuevaContrasenia);
                    } while (!flag);
                    break;
            }
        }

        private void Limpia()
        {
            Thread.Sleep(750);
            Console.Clear();
        }

        private void Salir()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Seleccionó salir. Hasta luego.");
            Environment.Exit(0);
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