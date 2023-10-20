using AccesoDatos;
using Modelo.UsuarioModelo;


namespace Negocio.UsuarioLogNegocio
{

    public static class ClsUsuario

    {
        static List<UsuarioModelo> listaUsuarios = new List<UsuarioModelo>();

        public static bool ValidarContrasenia(string campo, string valor)
        {
            bool flag = false;

            // Any determina si algún elemento de una secuencia satisface una condición
            bool contieneNumero = valor.Any(char.IsDigit);
            bool contieneMayuscula = valor.Any(char.IsUpper);

            //valido que no esté vacía
            if (string.IsNullOrEmpty(valor))
            {
                Console.WriteLine("\nERROR: El campo {0}, no puede estar vacío.\n", campo);
            }
            //valido que tenga entre 8 y 15 caracteres
            else if (valor.Length < 8 || valor.Length > 15)
            {
                Console.WriteLine("\nERROR: La constraseña debe tener entre 8 y 15 caracteres.\n");
            }
            //valido que contenga al menos un número.
            else if (!contieneNumero)
            {
                Console.WriteLine("\nERROR: La constraseña debe tener al menos un valor numérico.\n");
            }
            //valido que contenga al menos una mayúscula.
            else if (!contieneMayuscula)
            {
                Console.WriteLine("\nERROR: La constraseña debe tener al menos un caracter en mayúscula.\n");
            }
            else
            {
                flag = true;
            }
            return flag;
        }
        public static void validarDias(UsuarioModelo usuario)
        {
            bool flag;
            bool fechaExpiracion = ValidarExpiracion(usuario);
            string nuevaContrasenia;
            string contraseniActual = usuario.Contrasenia;

            if (fechaExpiracion)
            {
                Console.WriteLine("\n\tSu contraseña ha expirado.");

                do
                {
                    Console.Write("\nPor favor, ingrese una nueva contraseña: ");
                    nuevaContrasenia = Console.ReadLine();
                    flag = CambiarContrasenia(usuario, contraseniActual, nuevaContrasenia);
                } while (!flag);

            }

        }
        public static bool CambiarContrasenia(UsuarioModelo usuario, string contraseniaActual, string nuevaContrasenia)
        {
            bool flag = false;
            bool validaciones = ValidarContrasenia("Contraseña", nuevaContrasenia);
            //Si se cumplen todas las validaciones de la contraseña, valido que la nueva contraseña no sea igual a la anterior.
            if (validaciones)
            {
                if (contraseniaActual != usuario.Contrasenia) Console.WriteLine("\nERROR: La contraseña ingresada no coincide con la contraseña actual.\n");
                else if (usuario.Contrasenia == nuevaContrasenia) Console.WriteLine("\nERROR: La contraseña nueva no debe ser igual a la contraseña anterior.\n");      
                else
                {
                    //Actualizo la fecha actual.
                    usuario.FechaAlta = DateTime.Now;
                    usuario.Contrasenia = nuevaContrasenia;
                    Console.WriteLine("\n \tLa contraseña se actualizó correctamente.");
                    flag = true;
                }
            }
            return flag;
        }
        public static bool ValidarNombre(string nombre, string apellido, ref string nombreUsuario)
        {
            nombre.ToLower();
            apellido.ToLower();
            nombreUsuario.ToLower();

            if (nombreUsuario.Length >= 8 && nombreUsuario.Length <= 15)
            {
                if (!nombreUsuario.Contains(nombre) && !nombreUsuario.Contains(apellido))
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("\nERROR: El nombre o el apellido no pueden estar contenidos en el nombre de usuario");
                    return false;
                }

            }
            else
            {
                Console.WriteLine("\nERROR: El nombre de usuario debe tener entre 8 y 15 caracteres");
                return false;
            }
        }
        public static bool ValidarExpiracion(UsuarioModelo usuario)
        {
            DateTime fechaActual = DateTime.Now;
            DateTime fechaRenovacion = usuario.FechaAlta;
            TimeSpan diferencia = fechaActual - fechaRenovacion; // Timespan se usa para obtener valores derivados de una fecha.

            if (diferencia.TotalDays >= 30)
            {
                return true; // La fecha de renovación es igual o mayor a 30 días --> para pedir cambio
            }
            else
            {
                return false; // La fecha de renovación es menor a 30 días --> sigue con la misma
            }
        }
        public static UsuarioModelo BuscarPorDni(List<UsuarioModelo> usuarios, int dniUsuario)
        {
            return usuarios.Find(usuario => usuario.Dni == dniUsuario);
        }

        public static bool EliminarSupervisorPorDni(List<UsuarioModelo> usuarios, int dniUsuario)
        {
            var usuario = BuscarPorDni(usuarios, dniUsuario);
            if (usuario != null && usuario.Host==2)
            {
                usuarios.Remove(usuario);
                return true;
            }
            return false;
        }

        public static bool EliminarVendedorPorDni(List<UsuarioModelo> usuarios, int dniUsuario)
        {
            var usuario = BuscarPorDni(usuarios, dniUsuario);
            if (usuario != null && usuario.Host == 3)
            {
                usuarios.Remove(usuario);
                return true;
            }
            return false;
        }

        public static String Login(Login login)
        {
            String idUsuario = UsuarioDatos.Login(login);
            return idUsuario;
        }

        public static List<UsuarioWebServices> ListarUsuarios(Guid idUsuario)
        {
            return UsuarioDatos.Listarusuarios(idUsuario);
        }
   

    }
}





