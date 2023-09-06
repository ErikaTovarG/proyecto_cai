using Modelo.UsuarioModelo;
using Negocio.UsuarioLogNegocio;

namespace Presentacion
{
    
    public static class PideDatos
    {
        public static void PedirUsuario()
        {
            Guid id;
            string nombre, apellido, direccion, telefono, email, usuario, contrasenia;
            DateTime fechaNacimiento, fechaAlta;
            bool esValido;
            do
            {
                esValido = false;
                Console.Write("Nombre: ");
                nombre = Console.ReadLine();
                string campo = "Nombre";
                esValido = Validaciones.ValidaVacio( nombre, ref campo);
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
                esValido = UsuarioModelo.ValidarNombre(nombre, apellido,usuario);
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


            fechaAlta = DateTime.Now;
            id = Guid.NewGuid();

        }
    }
}

/* Codigo del profe
 * 
 * //if elegio Vendedor
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

*/



