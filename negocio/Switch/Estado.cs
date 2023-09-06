using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Switch
{
    public abstract class Estado
    {
        public abstract void ControlarEstado(Switch sw);
        public abstract string Describir();

    }
}
