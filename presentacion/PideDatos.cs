using Modelo.UsuarioModelo;
using Negocio.UsuarioLogNegocio;

namespace Presentacion
{

    public static class PideDatos
    {
        public static UsuarioModelo PedirUsuario()
        {
            Guid id;
            string nombre, apellido, direccion, telefono, email, usuario, contrasenia;
            DateTime fechaNacimiento, fechaAlta;
            int salidaHost, salidaDni;
            bool esValido;
            do
            {
                esValido = false;
                Console.Write("Nombre: ");
                nombre = Console.ReadLine();
                string campo = "Nombre";
                esValido = Validaciones.ValidaVacio(nombre, ref campo);
            } while (!esValido);
            do
            {
                esValido = false;
                Console.Write("Apellido: ");
                apellido = Console.ReadLine();
                string campo = "Apellido";
                esValido = Validaciones.ValidaVacio(apellido, ref campo);
            } while (!esValido);

            do
            {
                esValido = false;
                Console.Write("Dirección: ");
                direccion = Console.ReadLine();
                string campo = "Dirección";
                esValido = Validaciones.ValidaVacio(direccion, ref campo);
            } while (!esValido);

            do
            {
                esValido = false;
                Console.Write("Telefono: ");
                telefono = Console.ReadLine();
                string campo = "Telefono";
                esValido = Validaciones.ValidaVacio(telefono, ref campo);
            } while (!esValido);

            do
            {
                esValido = false;
                Console.Write("Email: ");
                email = Console.ReadLine();
                string campo = "Email";
                esValido = Validaciones.ValidaVacio(email, ref campo);
            } while (!esValido);

            do
            {
                esValido = false;
                Console.Write("Contraseña: ");
                contrasenia = Console.ReadLine();
                string campo = "Contraseña";
                esValido = Validaciones.ValidaVacio(contrasenia, ref campo);
            } while (!esValido);

            do
            {
                esValido = false;
                Console.Write("Usuario: ");
                usuario = Console.ReadLine();
                esValido = ClsUsuario.ValidarNombre(nombre, apellido, ref usuario);
            } while (!esValido);

            do
            {
                esValido = false;
                Console.Write("Fecha de Nacimiento: (en formato dd/mm/aaaa): ");
                string datoFecha = Console.ReadLine();
                DateTime salida = DateTime.Now;
                fechaNacimiento = salida;
                esValido = Validaciones.ValidaFecha(datoFecha, ref salida);
            } while (!esValido);

            do
            {
                esValido = false;
                Console.Write("Host: ");
                string datoIngresado = Console.ReadLine();
                salidaHost = 0;
                esValido = Validaciones.ValidaEntero(datoIngresado, 3, ref salidaHost);
            } while (!esValido);

            do
            {
                esValido = false;
                Console.Write("Host: ");
                string datoIngresado = Console.ReadLine();
                salidaDni = 0;
                esValido = Validaciones.ValidaNumerico(datoIngresado, ref salidaDni);
            } while (!esValido);


            fechaAlta = DateTime.Now;
            id = Guid.NewGuid();

            UsuarioModelo usuarioaAgregar = null;

            switch (usuarioaAgregar.Host)
            {
                case 1:
                    usuarioaAgregar = new Administrador(id, nombre, apellido, direccion, telefono, email, contrasenia, usuario, fechaAlta, fechaNacimiento, null, salidaHost, salidaDni);
                    break;
                case 2:
                    usuarioaAgregar = new Supervisor(id, nombre, apellido, direccion, telefono, email, contrasenia, usuario, fechaAlta, fechaNacimiento, null, salidaHost, salidaDni);
                    break;
                case 3:
                    usuarioaAgregar = new Vendedor(id, nombre, apellido, direccion, telefono, email, contrasenia, usuario, fechaAlta, fechaNacimiento, null, salidaHost, salidaDni);
                    break;
                default:
                    usuarioaAgregar = null;
                    break;
            }
            return usuarioaAgregar;
        }
    }
}



