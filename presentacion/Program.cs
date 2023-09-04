using Modelo.UsuarioModelo;

namespace Presentacion
{
    public class Program 
    {
        public static void Main(string[] args)
        {   Program programa = new Program();
            Datos datos = new Datos();  
            programa.Inicia(ref datos);
        }
        public void Inicia(ref Datos datos)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();

            Vistas.MenuInicial();
            int opcion = SeleccionarOpcion(4);
            SeleccionarModulo(opcion, ref datos);

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
        private void SeleccionarModulo(int opcion, ref Datos datos)
        {
            switch (opcion)
            {
                case 1:
                    Console.Clear();
                    Vistas.MenuAdministrador();
                    int opcion2 = SeleccionarOpcion(7);
                    SeleccionarOpcionesAdministrador(opcion2, ref datos);

                    break;

                case 2:
                    Console.WriteLine("\nProximamente...");
                    break;
                case 3:
                    Console.WriteLine("\nProximamente...");
                    break;
                default:
                    Environment.Exit(0);
                    break;
            }
        }
        private void SeleccionarOpcionesAdministrador(int opcion, ref Datos datos)
        {
            switch (opcion)
            {
                case 1:

                    PideDatos.PedirUsuario(ref datos);
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