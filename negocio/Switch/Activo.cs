using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Switch
{
    public class Activo : Estado
    {

        public override void ControlarEstado(Switch sw)
        {
            sw.CambiarEstadoUsuario(new Inactivo());
        }

        public override string Describir()
        {
            return "Usuario Activo";
        }

    }
}
