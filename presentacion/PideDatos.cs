using Modelo.UsuarioModelo;
using Negocio.UsuarioLogNegocio;

namespace Presentacion
{
    
    public static class PideDatos
    {
        public static void PedirUsuario()
        {
            Guid id;
            string nombre, apellido, direccion, telefono, email, usuario, contrasenia, host;
            DateTime fechaNacimiento, fechaAlta;
            int hostSalida = 0;
            bool esValido;

            do
            {
                esValido = false;
                Console.Write("Host: ");
                host = Console.ReadLine();       
                esValido = Validaciones.ValidaHost(host, ref hostSalida);
            } while (!esValido);

            do
            {
                esValido = false;
                Console.Write("Nombre: ");
                nombre = Console.ReadLine();
                string campo = "";
                esValido = Validaciones.ValidaVacio(nombre, ref campo);
            } while (!esValido);

            do
            {
                esValido = false;
                Console.Write("Apellido: ");
                apellido = Console.ReadLine();
                string campo = "";
                esValido = Validaciones.ValidaVacio(apellido, ref campo);
            } while (!esValido);

            do
            {
                esValido = false;
                Console.Write("Dirección: ");
                direccion = Console.ReadLine();
                string campo = "";
                esValido = Validaciones.ValidaVacio(direccion, ref campo);
            } while (!esValido);

            do
            {
                esValido = false;
                Console.Write("Telefono: ");
                telefono = Console.ReadLine();
                string campo = "";
                esValido = Validaciones.ValidaVacio(telefono, ref campo);
            } while (!esValido);

            do
            {
                esValido = false;
                Console.Write("Email: ");
                email = Console.ReadLine();
                string campo = "";
                esValido = Validaciones.ValidaVacio(email, ref campo);
            } while (!esValido);

            do
            {
                esValido = false;
                Console.Write("Contraseña: ");
                contrasenia = Console.ReadLine();
                string campo = "Contraseña";
                esValido = ClsUsuario.ValidarContrasenia(campo, contrasenia);
            } while (!esValido);

            do
            {
                esValido = false;
                Console.Write("Usuario: ");
                usuario = Console.ReadLine();
                esValido = ClsUsuario.ValidarNombre(nombre, apellido, usuario);
            } while (!esValido);

            do
            {
                esValido = false;
                Console.Write("Fecha de Nacimiento: (en formato dd/mm/aaaa ");
                string datoFecha = Console.ReadLine();
                DateTime salida = DateTime.Now;
                fechaNacimiento = salida;
                esValido = Validaciones.ValidaFecha(datoFecha, ref salida);
            } while (!esValido);

            //Datos seteados
            fechaAlta = DateTime.Now;
            id = Guid.NewGuid();
            DateTime fechaBaja = DateTime.MinValue; 
            int dni = 0;

            // Clase abstracta
            UsuarioModelo usuarioAgregar = null;

            //Instanciocada host segun el caso y lo agrego en la clase abstracta.
            switch (usuarioAgregar.Host)
            {
                case 1:
                    usuarioAgregar = new Administrador(id, nombre, apellido, direccion, telefono, email, contrasenia, usuario, fechaAlta, fechaNacimiento, fechaBaja, hostSalida, dni);
                    Datos d = new Datos();
                    d.agregarUsuario(usuarioAgregar);
                    break;
                case 2:
                    usuarioAgregar = new Supervisor(id, nombre, apellido, direccion, telefono, email, contrasenia, usuario, fechaAlta, fechaNacimiento, fechaBaja, hostSalida, dni);
                    Datos d2 = new Datos();
                    d2.agregarUsuario(usuarioAgregar);
                    break;

                case 3:
                    usuarioAgregar = new Vendedor(id, nombre, apellido, direccion, telefono, email, contrasenia, usuario, fechaAlta, fechaNacimiento, fechaBaja, hostSalida, dni);
                    Datos d3 = new Datos();
                    d3.agregarUsuario(usuarioAgregar);
                    break;
                default:
                    Console.WriteLine("No se logró elegir el host");
                    break;
            }
        }
    }
}



