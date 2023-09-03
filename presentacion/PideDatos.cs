
namespace Presentacion
{
    public class PideDatos
    {
        public void PedirUsuario()
        {
            string nombre,apellido, direccion, telefono, email, contrasenia, usuario;
            DateTime fechaAlta, fechaNacimiento, fechaBaja;
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
                string campo = "Usuario";
                esValido = Validaciones.ValidaVacio(usuario, ref campo);
            } while (!esValido);

            do
            {
                esValido = false;
                Console.Write("Usuario: ");
                string usu = Console.ReadLine();
                fechaNacimiento = DateTime.Now;
                esValido = Validaciones.ValidaFecha(usu, ref fechaNacimiento);
            } while (!esValido);

           

        }
    }
}
