//Llamo al proyecto para poder traerme todos los namespace con sus repectivas clases.
using Modelo.UsuarioModelo;
using System.Net.NetworkInformation;

namespace Negocio.UsuarioLogNegocio
{
    public static class ClsUsuario
    {
        // validación contraseña
        public static bool ValidarContrasenia(string campo, string valor)
        {
            bool flag = false;

            // Any determina si algún elemento de una secuencia satisface una condición
            bool contieneNumero = valor.Any(char.IsDigit);
            bool contieneMayuscula = valor.Any(char.IsUpper);

            //valido que no esté vacía
            if (string.IsNullOrEmpty(valor))
            {
                Console.WriteLine("ERROR: El campo {0}, no puede estar vacío.", campo);
            }
            //valido que tenga entre 8 y 15 caracteres
            else if (valor.Length < 8 || valor.Length > 15)
            {
                Console.WriteLine("ERROR: La constraseña debe tener entre 8 y 15 caracteres.");
            }
            //valido que contenga al menos un número.
            else if (!contieneNumero)
            {
                Console.WriteLine("ERROR: La constraseña debe tener al menos un valor numérico.");
            }
            //valido que contenga al menos una mayúscula.
            else if (!contieneMayuscula)
            {
                Console.WriteLine("ERROR: La constraseña debe tener al menos un caracter en mayúscula.");
            }
            else
            {
                Console.WriteLine("La constraseña se guardó correctamente.");
                flag = true;
            }
            return flag;
        }
    }

        
}



