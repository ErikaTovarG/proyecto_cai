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

    }
}