using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Switch
{
    public class Switch
    {
        Estado _estado;

        public Switch()
        {
            _estado = new Activo();
        }
        public void CambiarEstadoUsuario(Estado estado)
        {
            _estado = estado;
        }

        public void ModificarEstado()
        {
            _estado.ControlarEstado(this);
            Console.WriteLine(_estado.Describir());
        }
    }
}
