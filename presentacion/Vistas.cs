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
            Console.WriteLine("| Opcion         | Marcar |");
            Console.WriteLine("| Login          |    1   |");
            //Console.WriteLine("| Registrarse    |    2   |");
            Console.WriteLine("| Salir          |    2   |\n");
        }

       public static void MenuAdministrador()
        {
            Console.WriteLine("\n");
            Console.WriteLine((" ").PadRight(48, '=') + "   " + DateTime.Now + $"{0:D}" + "   " + (" ").PadRight(48, '='));
            Console.WriteLine("\n¡Bienvenidos a ElectroHogar S.A.!\n");
            Console.WriteLine("| Opciones de Administrador       | Marcar |");
            Console.WriteLine("|---------------------------------|--------|");
            Console.WriteLine("| Registrar Supervisor            |    1   |");
            Console.WriteLine("| Baja Supervisor                 |    2   |");
            Console.WriteLine("| Registrar Vendedor              |    3   |");
            Console.WriteLine("| Baja Vendedor                   |    4   |");
            Console.WriteLine("| Reporte de ventas por vendedor  |    5   |");
            Console.WriteLine("| Modificar contraseña            |    6   |");
            Console.WriteLine("| Salir                           |    0   |\n");
        }

       /* public static void MenuSupervisor()
        {
            Console.WriteLine("\n");
            Console.WriteLine((" ").PadRight(48, '=') + "   " + DateTime.Now + $"{0:D}" + "   " + (" ").PadRight(48, '='));
            Console.WriteLine("\n¡Bienvenido a ElectroHogar S.A.!\n");
            Console.WriteLine("| Opciones de Supervisor          | Marcar |");
            Console.WriteLine("|---------------------------------|--------|");
            Console.WriteLine("| Alta de productos               |    1   |");
            Console.WriteLine("| Modificar producto              |    2   |");
            Console.WriteLine("| Baja de producto                |    3   |");
            Console.WriteLine("| Devolución                      |    4   |");
            Console.WriteLine("| Reporte de stock crítico        |    5   |");
            Console.WriteLine("| Reporte de ventas por vendedor  |    6   |");
            Console.WriteLine("| Modificar contraseña            |    7   |");
            Console.WriteLine("| Salir                           |    0   |\n");
        }

        public static void MenuVendedor()
        {
            Console.WriteLine("\n");
            Console.WriteLine((" ").PadRight(48, '=') + "   " + DateTime.Now + $"{0:D}" + "   " + (" ").PadRight(48, '='));
            Console.WriteLine("\n¡Bienvenido a ElectroHogar S.A.!\n");
            Console.WriteLine("| Opcion                          | Marcar |");
            Console.WriteLine("|---------------------------------|--------|");
            Console.WriteLine("| Venta                           |    1   |");
            Console.WriteLine("| Reporte de ventas por vendedor  |    2   |");
            Console.WriteLine("| Modificar contraseña            |    3   |");
            Console.WriteLine("| Salir                           |    0   |\n");
        } */

        public static void OpcionesContinuar()
        {
            Console.WriteLine("\n");
            Console.WriteLine((" ").PadRight(48, '=') + "   " + DateTime.Now + $"{0:D}" + "   " + (" ").PadRight(48, '='));
            Console.WriteLine("| Opcion                     |          Marcar          |");
            Console.WriteLine("|----------------------------|--------------------------|");
            Console.WriteLine("| Volver al menu anterior    |            1             |");
            Console.WriteLine("| Ver usuarios registrados   |            2             |");
            Console.WriteLine("| Salir                      |     3 o cualquier tecla. |\n");
        }

        public static void VistaSupervisor()
        {
            Console.WriteLine("\n");
            Console.WriteLine((" ").PadRight(48, '=') + "   " + DateTime.Now + $"{0:D}" + "   " + (" ").PadRight(48, '='));
            Console.WriteLine("| Opcion                     | Marcar |");
            Console.WriteLine("|----------------------------|--------|");
            Console.WriteLine("| Listar Productos           |    1   |");
            Console.WriteLine("| Alta de Productos          |    2   |");
            Console.WriteLine("| Modificacion de Productos  |    3   |");
            Console.WriteLine("| Baja de Productos          |    4   |");
            Console.WriteLine("| Devolucion                 |    5   |");
            Console.WriteLine("| Reportes                   |    6   |");
            Console.WriteLine("| Salir                      |    7   |\n");
        }

        public static void VistaVendedor()
        {
            Console.WriteLine("\n");
            Console.WriteLine((" ").PadRight(48, '=') + "   " + DateTime.Now + $"{0:D}" + "   " + (" ").PadRight(48, '='));
            Console.WriteLine("| Opcion                     | Marcar |");
            Console.WriteLine("|----------------------------|--------|");
            Console.WriteLine("| Listar Productos           |    1   |");
            Console.WriteLine("| Registrar Venta Producto   |    2   |");
            Console.WriteLine("| Reporte de Ventas          |    3   |");
            Console.WriteLine("| Salir                      |    5   |\n");
        }

        public static void VistaReportes()
        {
            Console.WriteLine("\n");
            Console.WriteLine((" ").PadRight(48, '=') + "   " + DateTime.Now + $"{0:D}" + "   " + (" ").PadRight(48, '='));
            Console.WriteLine("| Opcion                                          | Marcar |");
            Console.WriteLine("|-------------------------------------------------|--------|");
            Console.WriteLine("| Reporte de stock crítico                        |    1   |");
            Console.WriteLine("| Reporte de Ventas                               |    2   |");
            Console.WriteLine("| Reporte de productos más vendido por categoría  |    3   |");
            Console.WriteLine("| Salir                                           |    4   |\n");

        public static void ModificarContrasena()
        {
            Console.WriteLine("\n");
            Console.WriteLine((" ").PadRight(48, '=') + "   " + DateTime.Now + $"{0:D}" + "   " + (" ").PadRight(48, '='));
            Console.WriteLine("| Ingrese su contraseña actual: ");
            //validar contraseña
            Console.WriteLine("| Ingrese su nueva contraseña: ");
            //
            Console.WriteLine("| Repita su nueva contraseña: ");

        }
    }
}
