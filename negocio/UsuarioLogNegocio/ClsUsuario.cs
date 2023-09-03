//Llamo al proyecto para poder traerme todos los namespace con sus repectivas clases.
using Modelo.UsuarioModelo;
namespace Negocio.UsuarioLogNegocio
{
    public class AltaUsuario
    {
        public void CrearUsuarios()
        {
            Supervisor nuevo1 = new Supervisor();
            nuevo1.Nombre = "Juan";

            UsuarioModelo usuario1 = new UsuarioModelo();
            usuario1.Nombre = "Juancito";
        }

    }


}
