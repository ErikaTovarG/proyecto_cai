﻿using Modelo.UsuarioModelo;
using Negocio.UsuarioLogNegocio;

namespace Presentacion
{
    public class Program 
    {
        public static void Main(string[] args)
        {   Program programa = new Program();
            programa.Inicia();
        }
        public void Inicia()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
            Opciones();
            int opcion = SeleccionarOpcion(); 
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Verificar Login");
                break;
                case 2:
                    ClsUsuario.CrearUsuarios();
                    Console.WriteLine("Usuario creado con exito.");

                    //probando el metodo de validacion de nombre de usuario
                    UsuarioModelo test = new UsuarioModelo();
                    test.validarNombre("juan", "perez", "diegoperez");


                break;
                default:
                    Environment.Exit(0);
                    break;
            }
            Console.WriteLine($"\nIngresó la opción:  {opcion}    ");
        }

        private void ImprimeLineaMarcada() => Console.WriteLine(("").PadRight(120, '='));

        private void Opciones()
        {
            ImprimeLineaMarcada();
            Console.WriteLine((" ").PadRight(48, '=') + "   " + DateTime.Now + $"{0:D}" + "   " + (" ").PadRight(48, '='));
            ImprimeLineaMarcada();
            Console.WriteLine("¡Bienvenidos a ElectroHogar S.A.!");
            ImprimeLineaMarcada();
            Console.WriteLine("| Opcion      | Marcar |");
            Console.WriteLine("|-------------|--------|");
            Console.WriteLine("| Ingresar    |    1   | ");
            Console.WriteLine("| Registrarse |    2   | ");
            Console.WriteLine("| Salir       |    3   | \n");
        }
           
        private int SeleccionarOpcion()
        {
            bool flag;
            int salida = 0;
            do
            {
                Console.Write("Indique la opción con la cual desea continuar: ");
                string res = Console.ReadLine();
                flag = Validaciones.validaEntero(res, ref salida);
            } while (!flag);

            return salida;
        }


    }
}