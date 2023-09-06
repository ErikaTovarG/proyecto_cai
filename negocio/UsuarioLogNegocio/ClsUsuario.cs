using Modelo.UsuarioModelo;


namespace Negocio.UsuarioLogNegocio
{
    public static class ClsUsuario
    {
        //-> Validación contraseña
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


        public static void CrearAdministrador(UsuarioModelo usuario, ref Datos datos)
        {
            usuario.Host = 1;
            datos.agregarUsuario(usuario);
        }
        public static void CrearSupervisor(UsuarioModelo usuario, ref Datos datos)
        {
            usuario.Host = 2;
            datos.agregarUsuario(usuario);
        }

        public static void CrearVendedor(UsuarioModelo usuario, ref Datos datos)
        {
            usuario.Host = 3;
            datos.agregarUsuario(usuario);
        }


        //-> Método para cambiar de contraseña, validando que no sea igual a la anterior.
        public static bool CambiarContrasenia(UsuarioModelo usuario, string nuevaContrasenia) // Acá como primer argumento el usuario instanciado.
        {
            bool flag = false;
            bool validaciones = ValidarContrasenia("Contraseña", nuevaContrasenia);

            //Si se cumplen todas las validaciones de la contraseña, valido que la nueva contraseña no sea igual a la anterior.
            if (validaciones)
            {
                if (usuario.Contrasenia == nuevaContrasenia)
                {
                    Console.WriteLine("ERROR: La contraseña nueva no debe ser igual a la contraseña anterior. Por favor, inténtelo nuevamente.");
                }
                else
                {
                    Console.WriteLine("La contraseña se actualizó correctamente.");
                    flag = true;
                    //Actualizo la fecha actual.
                    usuario.FechaAlta = DateTime.Now;
                }
            }

            return flag;
        }


        public static bool ValidarNombre(string nombre, string apellido, string nombreUsuario)
        {
            nombre.ToLower();
            apellido.ToLower();
            nombreUsuario.ToLower();

            //Console.WriteLine(nombreUsuario.Length);

            if (nombreUsuario.Length >= 8 && nombreUsuario.Length <= 15)
            {
                if (!nombreUsuario.Contains(nombre) && !nombreUsuario.Contains(apellido))
                {
                    //Console.WriteLine("Nombre de usuario correcto");
                    return true;
                }
                else
                {
                    Console.WriteLine("El nombre o el apellido no pueden estar contenidos en el nombre de usuario");
                    return false;
                }

            }
            else
            {
                Console.WriteLine("El nombre de usuario debe tener entre 8 y 15 caracteres");
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

        //  Validación de la fecha

        public static bool ValidarFecha(string fecha, ref DateTime fechaSalida)
        {
            bool flag = false;
            if (!DateTime.TryParse(fecha, out fechaSalida))
            {
                Console.WriteLine("El valor ingresado no es una fecha válida");
            }
            else if (fechaSalida > DateTime.Now)
            {
                Console.WriteLine("La fecha no puede ser mayor a hoy.");
            }
            else
            {
                flag = true;
            }
            return flag;
        }


    }


}



