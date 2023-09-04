using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.UsuarioModelo
{
    public class Administrador : UsuarioModelo
    {
        public static void CrearAdministrador(UsuarioModelo usuario, ref Datos datos)
        {
            usuario.Host = 1;
            datos.agregarUsuario(usuario);
        }
        public static void CrearSupervisor(UsuarioModelo usuario, ref Datos datos)
        {
            usuario.Host = 2;
            datos.agregarUsuario(usuario);
        }

        public static void CrearVendedor(UsuarioModelo usuario, ref Datos datos)
        {
            usuario.Host = 3;
            datos.agregarUsuario(usuario);
        }
    }
}
