
using Modelo.UsuarioModelo;
using System.Drawing;

namespace FormPresentacion
{
    public static class Validaciones
    {
        public static string ValidaEmail(string email, string campo)
        {
            string error = "";
            email = email.Trim();
            if (string.IsNullOrEmpty(email))
            {
                error = ($"El dato ingresado en {campo}no puede estar vacío.\n");
                return error;
            }

            // Divide el email en partes antes y después del símbolo '@'
            string[] partes = email.Split('@');

            // Verifica que haya exactamente una '@' en el email
            if (partes.Length != 2)
            {
                error = ($"El dato ingresado en {campo} debe ser un email válido.\n");
                return error;
            }
            if (string.IsNullOrEmpty(partes[0]) || string.IsNullOrEmpty(partes[1]))
            {
                error = ($"El dato ingresado en {campo} debe ser un email válido.\n");
                return error;
            }

            // Verifica que la parte después del '@' contenga al menos un punto '.'
            if (!partes[1].Contains("."))
            {
                error = ($"El dato ingresado en {campo} debe ser un email válido.\n");
                return error;
            }
            return error;
        }


        public static string ValidaNumerico(string num, ref int salida, string campo)
        {
            string error = "";
            if (!Int32.TryParse(num, out salida) || salida < 0)
                error = ($"El dato ingresado en {campo} debe ser númerico y entero.\n");
            return error;
        }


        public static string ValDecimal(string num, ref double salida, string campo)
        {
            string error = "";
            if (!Double.TryParse(num, out salida) || salida < 0)
                error = ($"El dato ingresado en {campo} debe ser numérico y decimal.\n");
            return error;
        }
        public static string ValidaVacio(string dato, string campo)
        {
            string error = "";
            if (string.IsNullOrEmpty(dato.Trim())) 
                error = ($"El campo {campo} no puede estar vacio.\n");
            return error;
        }

        public static string ValidarContrasenia(string campo, string valor)
        {
            string error = "";
            // Any determina si algún elemento de una secuencia satisface una condición
            bool contieneNumero = valor.Any(char.IsDigit);
            bool contieneMayuscula = valor.Any(char.IsUpper);

            //valido que no esté vacía
            if (string.IsNullOrEmpty(valor))
            {
                error = ($"El campo {campo} no puede estar vacio.\n"); 
            }
            //valido que tenga entre 8 y 15 caracteres
            else if (valor.Length < 8 || valor.Length > 15)
            {
                error = ($"El campo {campo} debe tener entre 8 y 15 caracteres.\n");    
            }
            //valido que contenga al menos un número.
            else if (!contieneNumero)
            {
                error = ($"El campo {campo}debe tener al menos un valor numérico.\n");
            }
            //valido que contenga al menos una mayúscula.
            else if (!contieneMayuscula)
            {
                error = ($"El campo {campo} debe tener al menos un caracter en mayúscula.\n");
            }
            return error;
        }

        public static string ValidaFechaNacimiento(string fecha, ref DateTime salida)
        {
            string error = "";
            DateTime fechaActual = DateTime.Now, fechaMinima = Convert.ToDateTime("1900-1-1");
            if (string.IsNullOrEmpty(fecha)) error = ("El campo Fecha puede estar vacio.\n");
            else if (!DateTime.TryParse(fecha, out salida)) error = ("El dato ingresado no es un formato válido de fecha.Use el formato YYYY-MM - DD.\n"); 
            else if (salida < fechaMinima) error = ("\nERROR: La fecha ingresado no puede ser menor a 01/01/1900.");
            else if (salida > fechaActual) error = ("\nERROR: la fecha de nacimiento no puede ser mayor a hoy.");
            return error;
        }



    }
}
