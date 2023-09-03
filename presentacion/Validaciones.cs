
namespace Presentacion
{
    public static class Validaciones
    {
        public static bool ValidaEntero(string num, ref int salida)
        {
            bool flag = false;
            if (!int.TryParse(num, out salida) || salida < 0) Console.WriteLine("El dato ingresado debe ser númerico y positivo.");
            else if (salida != 1 && salida != 2 && salida !=3) Console.WriteLine("La opción ingresada debe encontrarse en la tabla de opciones.");
            else flag = true;
            return flag;
        }

        public static bool ValidaFecha(string fecha, ref DateTime salida)
        {
            bool flag = false;
            if(!DateTime.TryParse(fecha, out salida)) Console.WriteLine("El dato ingresado como fecha no es un dato valido.");
            else if (salida > DateTime.Now) Console.WriteLine("La fecha ingresada no puede ser mayor a hoy.");
            else flag = true;
            return flag;
        }

        public static bool ValidaVacio(string dato, ref string campo)
        {
            bool flag = false;
            if (string.IsNullOrEmpty(dato)) Console.WriteLine($"El campo {campo} no puede estar vacio.");
            else flag = true;
            return flag;
        }

    }
}
