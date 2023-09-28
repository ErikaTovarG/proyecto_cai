using Modelo.UsuarioModelo;
using Negocio.UsuarioLogNegocio;
using Modelo.Switch;
using System;
using System.Threading.Channels;
using System.Runtime.InteropServices;

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
                                SeleccionarOpcionesAdministrador(opcion2, usuarios);
                                break;
                            case 2:

                                Vistas.MenuSupervisor();
                                opcion2 = SeleccionarOpcion(cantidadOpciones);

                                Vistas.VistaSupervisor();
                                

                                Limpia();
                               //SeleccionarOpcionesAdministrador(opcion2, usuarios);
                                Limpia();
                                break;
                            case 3:

                                Vistas.MenuVendedor();
                                opcion2 = SeleccionarOpcion(cantidadOpciones);

                                Vistas.VistaVendedor();
                                //opcion2 = SeleccionarOpcion(4);

                                Limpia();
                                break;
                            default:
                                Console.WriteLine("No se encontro");
                                break;
                        }

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
        public bool Preguntar(List<UsuarioModelo> usuarios)
        {
            string res;
            bool flag = false;
            
            do
            {
                Console.Write("\n\t¿Desea intentar nuevamente? S/N: ");
                res = Console.ReadLine().ToUpper();
                if (res == "N") { flag = true; }

                //Si responde SI, recorro los usuario y sumo el contador de intentos en uno
                if (res == "S") { 
                    foreach (var usu in usuarios)
                    {
                        usu.Contador++;
                        if(usu.Contador >= 3)
                        {
                            Console.WriteLine("\n ERROR: Ha excedido los intentos.\n");
                            Environment.Exit(0);
                            //usu.Estado = "inactivo";
                          
                            
                            
                        }
                        break;
                    }
                    flag = true;

                }        

            } while (!flag);

            if (res == "N") { Environment.Exit(0); }
            return res == "S";
        }
        //ANDREA
        public UsuarioModelo MenuLogin(List<UsuarioModelo> usuariosCreados)
        {
            string usuarioIngresado, contrasenaIngresada;
            Activo activo = new Activo();
            Inactivo inactivo = new Inactivo();
            bool inicioSesionExitoso = false;
            UsuarioModelo usu2 = null;


            //Vistas.Login();
            Console.WriteLine("\n");
            Console.WriteLine((" ").PadRight(48, '=') + "   " + DateTime.Now + $"{0:D}" + "   " + (" ").PadRight(48, '='));
            Console.WriteLine("\n¡Bienvenidos a ElectroHogar S.A!\n");
            Console.Write("\n\t Ingrese su Usuario: ");
            usuarioIngresado = Console.ReadLine().Trim();
            Console.Write("\t Ingrese su Contraseña: ");
            contrasenaIngresada = Console.ReadLine().Trim();


            foreach (var usu in usuariosCreados)
            {
                if (usu.Usuario == usuarioIngresado && usu.Contrasenia == contrasenaIngresada) 
                { 
                         if (usu.Estado == activo)
                            {
                                 inicioSesionExitoso = true;
                                 usu2 = usu;
                                 break;
                             }
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
              
                if (Preguntar(usuariosCreados))
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
                    
                /*case 6:
                    Console.WriteLine("\n");
                    Console.WriteLine((" ").PadRight(48, '=') + "   " + DateTime.Now + $"{0:D}" + "   " + (" ").PadRight(48, '='));
                    Console.WriteLine("| Ingrese su contraseña actual: ");
                    string contrasenaIngresada = Console.ReadLine().Trim();
                    if (ClsUsuario.ValidarContrasenia)
                    {
                        ClsUsuario.CambiarContrasenia(usuarioSup, nuevaContrasenia);
                    }*/
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
                default : Environment.Exit(0);
                    break;
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