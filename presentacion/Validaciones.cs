
namespace Presentacion
{
    public static class Validaciones
    {
        public static bool validaEntero(string num, ref int salida)
        {
            bool flag = false;
            if (!int.TryParse(num, out salida) || salida < 0) Console.WriteLine("El dato ingresado debe ser númerico y positivo.");
            else if (salida != 1 && salida != 2) Console.WriteLine("La opción ingresada debe encontrarse en la tabla de opciones.");
            else flag = true;
            return flag;
        }
    }
}
