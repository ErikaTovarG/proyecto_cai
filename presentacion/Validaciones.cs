using Modelo.UsuarioModelo;
using System.Diagnostics.Metrics;

namespace Presentacion
{
    public static class Validaciones
    {
        public static bool ValidaEntero(string num, int cant, ref int salida)
        {
            bool flag = false;
            if (!int.TryParse(num, out salida) || salida < 0) Console.WriteLine("\nERROR: El dato ingresado debe ser númerico y positivo.\n");
            else if (salida < 1 || salida > cant) Console.WriteLine("\nERROR: La opción ingresada debe encontrarse en la tabla de opciones.\n");
            else flag = true;
            return flag;
        }

        public static bool ValidaFecha(string fecha, ref DateTime salida)
        {
            bool flag = false;
            if (!DateTime.TryParse(fecha, out salida)) Console.WriteLine("\nERROR: El dato ingresado como fecha no es un dato valido.\n");
            else if (salida > DateTime.Now) Console.WriteLine("\nERROR: La fecha ingresada no puede ser mayor a hoy.\n");
            else flag = true;
            return flag;
        }

        public static bool ValidaVacio(string dato, ref string campo)
        {
            bool flag = false;
            if (string.IsNullOrEmpty(dato.Trim())) Console.WriteLine($"\nERROR: El campo {campo} no puede estar vacio.\n");
            else flag = true;
            return flag;
        }
        public static bool ValidaNumerico(string num, ref int salida)
        {
            bool flag = false;
            if (!int.TryParse(num, out salida) || salida < 0) Console.WriteLine("\nERROR: El dato ingresado debe ser númerico y positivo.\n");
            else flag = true;
            return flag;
        }
        public static bool ValidaFechaNacimiento(string fecha, ref DateTime salida)
        {
            bool flag = false;
            DateTime fechaActual = DateTime.Now, fechaMinima = Convert.ToDateTime("1900-1-1");
            
            if (!DateTime.TryParse(fecha, out salida)) Console.WriteLine("\nERROR: El dato ingresado no es un formato valido de fecha. Use el formato YYYY-MM-DD.");

            if (salida < fechaMinima) Console.WriteLine("\nERROR: La fecha ingresado no puede ser menor a 1900/01/01.");
            else if (salida > fechaActual) Console.WriteLine("\nERROR: la fecha de nacimiento no puede ser mayor a hoy.");
            else flag |= true;

            return flag;
        }
       
        public static bool ValidaEmail(string email)
        {
            email = email.Trim();
            if (string.IsNullOrEmpty(email))
            {
                Console.WriteLine("\nERROR: El campo email no puede estar vacío.\n");
                return false;
            }

            // Divide el email en partes antes y después del símbolo '@'
            string[] partes = email.Split('@');

            // Verifica que haya exactamente una '@' en el email
            if (partes.Length != 2)
            {
                Console.WriteLine("\nERROR: El dato ingresado debe ser un email válido.\n");
                return false;
            }
            if (string.IsNullOrEmpty(partes[0]) || string.IsNullOrEmpty(partes[1]))
            {
                Console.WriteLine("\nERROR: El dato ingresado debe ser un email válido.\n");
                return false;
            }

            // Verifica que la parte después del '@' contenga al menos un punto '.'
            if (!partes[1].Contains("."))
            {
                Console.WriteLine("\nERROR: El dato ingresado debe ser un email válido.\n");
                return false;
            }

            return true;
        }

      

    }
}