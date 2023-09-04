using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion
{
    public class Vistas
    {
        public static void MenuInicial()
        {
            Console.WriteLine("\n");
            Console.WriteLine((" ").PadRight(48, '=') + "   " + DateTime.Now + $"{0:D}" + "   " + (" ").PadRight(48, '='));
            Console.WriteLine("\n¡Bienvenidos a ElectroHogar S.A!\n");
            Console.WriteLine("\nMenu principal: \n\n");
            Console.WriteLine("[1]. Modulo Administrador.\n");
            Console.WriteLine("[2]. Modulo Supervisor.\n");
            Console.WriteLine("[3]. Modulo Vendedor.\n");
            Console.WriteLine("[4]. Salir.\n\n");
        }

        public static void MenuAdministrador() 
        {
            Console.WriteLine("\n");
            Console.WriteLine((" ").PadRight(48, '=') + "   " + DateTime.Now + $"{0:D}" + "   " + (" ").PadRight(48, '='));
            Console.WriteLine("\n¡Bienvenidos a ElectroHogar S.A.!\n");
            Console.WriteLine("| Opcion                     | Marcar |");
            Console.WriteLine("|----------------------------|--------|");
            Console.WriteLine("| Registrar Administrador    |    1   |");
            Console.WriteLine("| Baja Administrador         |    2   |");
            Console.WriteLine("| Registrar Supervisor       |    3   |");
            Console.WriteLine("| Baja Supervisor            |    4   |");
            Console.WriteLine("| Registrar Vendedor         |    5   |");
            Console.WriteLine("| Baja Vendedor              |    6   |");
            Console.WriteLine("| Salir                      |    7   |\n");
        }
    }
}
