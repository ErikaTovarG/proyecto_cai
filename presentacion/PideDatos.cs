using Modelo.UsuarioModelo;
using Negocio.UsuarioLogNegocio;

namespace Presentacion
{
    /*
    public static class PideDatos
    {
        public static UsuarioModelo PedirUsuario(ref Datos datos)
        {
            
            

            bool esValido;
            do
            {
                esValido = false;
                Console.Write("Nombre: ");
                usuarioModelo.Nombre = Console.ReadLine();
                string campo = "Nombre";
                esValido = Validaciones.ValidaVacio(usuarioModelo.Nombre, ref campo);
            } while (!esValido);
            do
            {
                esValido = false;
                Console.Write("Apellido: ");
                usuarioModelo.Apellido = Console.ReadLine();
                string campo = "Apellido";
                esValido = Validaciones.ValidaVacio(usuarioModelo.Apellido, ref campo);
            } while (!esValido);

            do
            {
                esValido = false;
                Console.Write("Dirección: ");
                usuarioModelo.Direccion = Console.ReadLine();
                string campo = "Dirección";
                esValido = Validaciones.ValidaVacio(usuarioModelo.Direccion, ref campo);
            } while (!esValido);

            do
            {
                esValido = false;
                Console.Write("Telefono: ");
                usuarioModelo.Telefono = Console.ReadLine();
                string campo = "Telefono";
                esValido = Validaciones.ValidaVacio(usuarioModelo.Telefono, ref campo);
            } while (!esValido);

            do
            {
                esValido = false;
                Console.Write("Email: ");
                usuarioModelo.Email = Console.ReadLine();
                string campo = "Email";
                esValido = Validaciones.ValidaVacio(usuarioModelo.Email, ref campo);
            } while (!esValido);

            do
            {
                esValido = false;
                Console.Write("Contraseña: ");
                usuarioModelo.Contrasenia = Console.ReadLine();
                string campo = "Contraseña";
                esValido = Validaciones.ValidaVacio(usuarioModelo.Contrasenia, ref campo);
            } while (!esValido);

            do
            {
                esValido = false;
                Console.Write("Usuario: ");
                usuarioModelo.Usuario = Console.ReadLine();       
                esValido = UsuarioModelo.ValidarNombre(usuarioModelo.Nombre, usuarioModelo.Apellido, usuarioModelo.Usuario);
            } while (!esValido);

            do
            {
                esValido = false;
                Console.Write("Fecha de Nacimiento: ");
                string datoFecha = Console.ReadLine();
                DateTime salida = DateTime.Now;
                usuarioModelo.FechaNacimiento = salida;
                esValido = Validaciones.ValidaFecha(datoFecha, ref salida);
            } while (!esValido);


            usuarioModelo.FechaAlta = DateTime.Now;
            usuarioModelo.Id = Guid.NewGuid();


            //if elegio Vendedor
            UsuarioModelo usuario = null;

            if ()
            {
                usuario = new Vendedor();
            }
            else
            {
                usuario = new Supervisor();
            }

            return usuario;

            //ClsUsuario.CrearSupervisor(usuarioModelo, ref datos);

           


        }
    }*/
}
