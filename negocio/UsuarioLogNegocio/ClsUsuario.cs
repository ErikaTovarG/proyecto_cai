//Llamo al proyecto para poder traerme todos los namespace con sus repectivas clases.
using Modelo.UsuarioModelo;
using System.Net.NetworkInformation;

namespace Negocio.UsuarioLogNegocio
{
    public static class ClsUsuario
    {
        public static void CrearUsuarios()
        {
            RegistrarUsuario();
        }

        static List<UsuarioModelo> listaUsuarios = new List<UsuarioModelo>();
        private static void RegistrarUsuario()
        {
            Guid id = Guid.NewGuid(); //Se genera un id nuevo para el usuario.
            string nombre = "Juana";
            string apellido = "Juana";
            string direccion = "Juana";
            string telefono = "Juana";
            string email = "Juana";
            string contrasenia = "Juana";
            string usuario = "Juana";
            DateTime fechaAlta = DateTime.Now;
            DateTime fechaNacimiento = DateTime.Parse("2023/02/01");
            DateTime fechaBaja = DateTime.Now;

            UsuarioModelo nu = new UsuarioModelo(id, nombre, apellido, direccion, telefono, email, contrasenia, usuario, fechaAlta, fechaNacimiento, fechaBaja, 1, 95852369);
            UsuarioModelo nu1 = new UsuarioModelo(id, nombre, apellido, direccion, telefono, email, contrasenia, usuario, fechaAlta, fechaNacimiento, fechaBaja, 1, 95852369);
            UsuarioModelo nu2 = new UsuarioModelo(id, nombre, apellido, direccion, telefono, email, contrasenia, usuario, fechaAlta, fechaNacimiento, fechaBaja, 1, 95852369);
            UsuarioModelo nu3 = new UsuarioModelo(id, nombre, apellido, direccion, telefono, email, contrasenia, usuario, fechaAlta, fechaNacimiento, fechaBaja, 1, 95852369);

            listaUsuarios.Add(nu);
            listaUsuarios.Add(nu2);
            listaUsuarios.Add(nu1);
            listaUsuarios.Add(nu3);

            Console.WriteLine("la lista tiene "+ listaUsuarios.Count);

        }
    }

        
        
        
}



