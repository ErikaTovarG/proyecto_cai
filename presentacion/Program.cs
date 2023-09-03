namespace Presentacion
{
    public static class Program 
    {
        public static void Main(string[] args)
        {   
            Program.Inicia();
        }
        private static void Inicia()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
            Opciones();
            int opcion = SeleccionarOpcion();
            Console.WriteLine($"\nIngresó la opción:  {opcion}    ");
        }

        private static void ImprimeLineaMarcada() => Console.WriteLine(("").PadRight(120, '='));

        private static void Opciones()
        {
            ImprimeLineaMarcada();
            Console.WriteLine((" ").PadRight(48, '=') + "   " + DateTime.Now + $"{0:D}" + "   " + (" ").PadRight(48, '='));
            ImprimeLineaMarcada();
            Console.WriteLine("¡Bienvenidos a ElectroHogar S.A.!");
            ImprimeLineaMarcada();
            Console.WriteLine("| Opcion      | Marcar |");
            Console.WriteLine("|-------------|--------|");
            Console.WriteLine("| Ingresar    |    1   | ");
            Console.WriteLine("| Registrarse |    2   | \n");
        }

        
             

        private static int SeleccionarOpcion()
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