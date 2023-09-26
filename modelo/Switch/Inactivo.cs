using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Switch
{
    public class Inactivo : Estado
    {
        public override void ControlarEstado( Switch sw)
        {
            sw.CambiarEstadoUsuario(new Activo());
        }

        public override string Describir()
        {
            return "Usuario Inactivo";
        }

    }
}
