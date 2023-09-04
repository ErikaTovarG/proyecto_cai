

namespace Modelo.UsuarioModelo
{
    public class Datos
    {
        
        private List<UsuarioModelo> listaUsuarios = new List<UsuarioModelo>();

        public List<UsuarioModelo> getUsuarios() { return this.listaUsuarios; }

        public void agregarUsuario(UsuarioModelo user)
        {
            this.listaUsuarios.Add(user);
        }
    }
}
