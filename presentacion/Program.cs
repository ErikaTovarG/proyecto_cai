using Modelo.UsuarioModelo;
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
            UsuarioModelo hola = new Administrador(Guid.NewGuid(), "Erika", "Tovar", "Av. 123", "111111", "etovar@GMAIL.COM", "CAI", "etovar", DateTime.Now, Convert.ToDateTime("18/10/1991"), null, 1, 44665522);
            usuarios.Add(hola);
            programa.Inicia(usuarios);
            //programa.Inicia(ref datos);
        }
        public void Inicia(List<UsuarioModelo> usuarios)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();

            Vistas.MenuInicial();
            int opcion = SeleccionarOpcion(3);
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
                    if(usuLogueado != null)
                    {
                        switch (usuLogueado.Host)
                        {
                            case 1:
                                Vistas.MenuAdministrador();
                                int opcion2 = SeleccionarOpcion(5);
                                SeleccionarOpcionesAdministrador(opcion2);
                                break;
                            case 2:
                                Console.WriteLine("aca ira la vista de Supervisor");
                                break;
                            case 3:
                                Console.WriteLine("aca ira la vista de Vendedor");
                                break;
                            default: Console.WriteLine("No se encontro");
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


        public UsuarioModelo MenuLogin(List<UsuarioModelo> usuarios)
        {
            string usuarioIngresado, contrasenaIngresada,res;
            Console.WriteLine("\n");
            //Solicita nombre usuario
            Console.Write("\t Usuario: ");
            usuarioIngresado = Console.ReadLine().Trim();
            //Solicita contraseña del usuario
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
                Console.WriteLine("\t\nInicio de sesión exitoso. ¡Bienvenido!\n");
                return usu2;
            }
            else
            {
                Console.WriteLine("\t\nInicio de sesión fallido. Credenciales incorrectas.");
                Preguntar(usuarios);
                return null;
            }

        }
        public void Preguntar(List<UsuarioModelo> usuarios)
        {
            string res;
            bool flag = false;
            do
            {
                Console.Write("\n\t¿Desea intentar nuevamente? S/N: ");
                res = Console.ReadLine().ToUpper();
                if (res == "S" || res == "N") {flag = true; }            
            } while (!flag);

            if (res == "N") { Environment.Exit(0); }
            else MenuLogin(usuarios); 
        }

         private void SeleccionarOpcionesAdministrador(int opcion)
         {
             switch (opcion)
             {
                 case 1:

                    UsuarioModelo usuario = new PideDatos.PedirUsuario();
       
                    //listadoUsuarios.add(usuario);
                     Datos datos = new Datos();
                     foreach (var fila in datos.getUsuarios())
                     {
                         Console.WriteLine($"{fila.ToString()}");
                     }

                     Console.WriteLine("\n");
                     Console.WriteLine("\n\tUsuario creado con exito.");
                     break;
                 case 2:
                     Console.WriteLine("\nProximamente...");
                     break;
                 case 3:
                     Console.WriteLine("\nProximamente...");
                     break;
                 case 4:
                     Console.WriteLine("\nProximamente...");
                     break;
                 case 5:
                     Console.WriteLine("\nProximamente...");
                     break;
                 case 6:
                     Console.WriteLine("\nProximamente...");
                     break;
                 case 7:
                     Console.WriteLine("\nProximamente...");
                     break;
                 default:
                     Environment.Exit(0);
                     break;

             }
         }
        

    }
}