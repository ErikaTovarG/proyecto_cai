//Llamo al proyecto para poder traerme todos los namespace con sus repectivas clases.
using Modelo.Usuario;

namespace Negocio.UsuarioLogNegocio
{
    public class AltaUsuario
    {
        public void CrearUsuarios()
        {
            Supervisor nuevo1 = new Supervisor();
            nuevo1.nombre = "Juan";

            Usuario usuario1 = new Usuario();
            usuario1.nombre = "Juancito";
        }

    }


}
