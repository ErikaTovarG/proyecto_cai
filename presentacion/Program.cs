using Modelo.UsuarioModelo;
using Negocio.UsuarioLogNegocio;
using System.Threading.Channels;

namespace Presentacion
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Program programa = new Program();
            //Datos datos = new Datos();
            List<UsuarioModelo> usuarios = new List<UsuarioModelo>();
            UsuarioModelo hola = new Administrador(Guid.NewGuid(), "Erika", "Tovar", "Av. 123", "111111", "etovar@GMAIL.COM", "CAI", "etovar", Convert.ToDateTime("01/09/2023"), Convert.ToDateTime("18/10/1991"), null, 1, 44665522);
            usuarios.Add(hola);
            programa.Inicia(usuarios);
            //programa.Inicia(ref datos);
        }
        public void Inicia(List<UsuarioModelo> usuarios)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();

            Vistas.MenuInicial();
            int opcion = SeleccionarOpcion(2);
            SeleccionarModulo(opcion, usuarios);
        }
        private int SeleccionarOpcion(int cant)
        {
            bool flag;
            int salida = 0;
            do
            {
                Console.Write("Indique la opción con la cual desea continuar: ");
                string res = Console.ReadLine();
                flag = Validaciones.ValidaEntero(res, cant, ref salida);
            } while (!flag);

            return salida;
        }
        private void SeleccionarModulo(int opcion, List<UsuarioModelo> usuarios)
        {
            switch (opcion)
            {
                case 1:
                    Console.Clear();
                    UsuarioModelo usuLogueado = MenuLogin(usuarios);

                    if (usuLogueado != null)
                    {
                        switch (usuLogueado.Host)
                        {
                            case 1:
                                Console.Clear();
                                Vistas.MenuAdministrador();
                                int opcion2 = SeleccionarOpcion(5);
                                SeleccionarOpcionesAdministrador(opcion2, usuarios);
                                break;
                            case 2:
                                Console.WriteLine("aca ira la vista de Supervisor");
                                break;
                            case 3:
                                Console.WriteLine("aca ira la vista de Vendedor");
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


        public bool Preguntar()
        {
            string res;
            bool flag = false;
            do
            {
                Console.Write("\n\t¿Desea intentar nuevamente? S/N: ");
                res = Console.ReadLine().ToUpper();
                if (res == "S" || res == "N") { flag = true; }
            } while (!flag);

            if (res == "N") { Environment.Exit(0); }
            return res == "S";
        }

        public UsuarioModelo MenuLogin(List<UsuarioModelo> usuarios)
        {
            string usuarioIngresado, contrasenaIngresada;
            Console.WriteLine("\n");
            Console.Write("\t Usuario: ");
            usuarioIngresado = Console.ReadLine().Trim();
            Console.Write("\t Contraseña: ");
            contrasenaIngresada = Console.ReadLine().Trim();

            bool inicioSesionExitoso = false;
            UsuarioModelo usu2 = null;

            foreach (var usu in usuarios)
            {
                if (usu.Usuario == usuarioIngresado && usu.Contrasenia == contrasenaIngresada)
                {
                    inicioSesionExitoso = true;
                    usu2 = usu;
                    break;
                }
            }

            if (inicioSesionExitoso)
            {
                ClsUsuario.validarDias(usu2);
                Console.WriteLine("\t\nInicio de sesión exitoso. ¡Bienvenido!\n");
                return usu2;
            }
            else
            {
                Console.WriteLine("\t\nInicio de sesión fallido. Credenciales incorrectas.");
                if (Preguntar())
                {
                    return MenuLogin(usuarios);
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
                    
                    UsuarioModelo usuarioSup = PideDatos.PedirUsuario(2);
                    usuarios.Add(usuarioSup);
                   
                    foreach (var fila in usuarios)
                    {
                        Console.WriteLine((" ").PadRight(48, '*'));
                        Console.WriteLine($"{fila.ToString()}");
                    }
                    Console.WriteLine("\n");
                    Console.WriteLine((" ").PadRight(48, '*'));
                    Console.WriteLine("\n\tUsuario creado con exito.");
                    break;
                case 2:
                    Console.WriteLine("\nProximamente...");
                    break;
                case 3:
                    UsuarioModelo usuarioVen = PideDatos.PedirUsuario(3);
                    usuarios.Add(usuarioVen);

                    foreach (var fila in usuarios)
                    {
                        Console.WriteLine((" ").PadRight(48, '*'));
                        Console.WriteLine($"{fila.ToString()}");
                    }
                    Console.WriteLine("\n");
                    Console.WriteLine((" ").PadRight(48, '*'));
                    Console.WriteLine("\n\tUsuario creado con exito.");
                    break;
                case 4:
                    Console.WriteLine("\nProximamente...");
                    break;
                default:
                    Environment.Exit(0);
                    break;
            }
          
        }
       

    }
}