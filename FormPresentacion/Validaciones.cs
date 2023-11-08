
namespace FormPresentacion
{
    public static class Validaciones
    {
        public static string ValDecimal(string num, ref double salida, string campo)
        {
            string error = "";
            if (!Double.TryParse(num, out salida) || salida < 0)
                error = ($"El dato ingresado en {campo} debe ser númerico y entero.");
            return error;
        }

        public static string ValidaVacio(string dato, string campo)
        {
            string error = "";
            if (string.IsNullOrEmpty(dato.Trim())) error = ($"\nERROR: El campo {campo} no puede estar vacio.\n");
            return error;
        }



    }
}
