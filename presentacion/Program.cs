using Modelo.UsuarioModelo;
using Negocio.UsuarioLogNegocio;
using System;
using System.Threading.Channels;

namespace Presentacion
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Program programa = new Program();

            List<UsuarioModelo> usuarios = new List<UsuarioModelo>();
            UsuarioModelo admin1 = new Administrador(Guid.NewGuid(), "Erika", "Tovar", "Av. 123", "111111", "etovar@GMAIL.COM", "CAI20232", "etovar", Convert.ToDateTime("01/09/2023"), Convert.ToDateTime("18/10/1991"), null, 1, 44665522);   
            UsuarioModelo sup1 = new Supervisor(Guid.NewGuid(), "Andrea", "Rivera", "Av. cabildo", "22222", "acrs@GMAIL.COM", "CAI20232", "andrivera", Convert.ToDateTime("01/09/2023"), Convert.ToDateTime("18/10/1991"), null, 2, 8542658);
            UsuarioModelo vend1 = new Vendedor(Guid.NewGuid(), "Facundo", "Cairo", "Av. belgrano", "33333", "facundo@GMAIL.COM", "CAI20232", "heygoogle", Convert.ToDateTime("01/09/2023"), Convert.ToDateTime("18/10/1991"), null, 3, 4845752);
            
            usuarios.Add(admin1);
            usuarios.Add(sup1);
            usuarios.Add(vend1);

            programa.Inicia(usuarios);
     
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
                                Vistas.MenuAdministrador();                        
                                int opcion2 = SeleccionarOpcion(5);
                                Limpia();
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
            Console.Write("\n\t Usuario: ");
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
            //Pruebas si es false
            
            if (!inicioSesionExitoso)
            {
                int contador = 0;
                contador++;
                Console.WriteLine("\t\nInicio de sesión fallido. Credenciales incorrectas.");  
                if (contador <= 3)
                {
                    Console.WriteLine("Ha excedido la cantidad de intentos permitidos para validar las credenciales.");
                    //usu2.Estado = inactivo. 
                }
                else
                {
                    if (Preguntar())
                    {
                        Limpia();
                        return MenuLogin(usuarios);
                    }
                    else
                    {
                        return null;
                    }
                }

               
            }
            else
            {
                ClsUsuario.validarDias(usu2);
                Console.WriteLine("\t\n Inicio de sesión exitoso. ¡Bienvenido!\n");
                Limpia();
                return usu2;
            }





            /* if (inicioSesionExitoso)
            {
                ClsUsuario.validarDias(usu2);
                Console.WriteLine("\t\n Inicio de sesión exitoso. ¡Bienvenido!\n");
                Limpia();
                return usu2;
            }
            else
            {
                Console.WriteLine("\t\nInicio de sesión fallido. Credenciales incorrectas.");
                if (Preguntar())
                {
                    Limpia();
                    return MenuLogin(usuarios);
                }
                else
                {
                    return null; 
                }
            }
            */


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
                    Console.WriteLine("\nProximamente...");
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
                    Console.WriteLine("\nProximamente...");
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
                    Vistas.MenuAdministrador();
                    int opcion2 = SeleccionarOpcion(5);
                    SeleccionarOpcionesAdministrador(opcion2, usuarios);
                    break;
                case 2:
                    Limpia();
                    Console.WriteLine("\nLos usuarios son: \n\n");
                    foreach (var fila in usuarios)
                    {
                        Console.WriteLine((" ").PadRight(60, '*'));
                        Console.WriteLine($"{fila.ToString()}");
                    }
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

    }
}