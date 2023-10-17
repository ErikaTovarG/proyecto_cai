﻿using Modelo.UsuarioModelo;

namespace Negocio.UsuarioLogNegocio
{
    public static class UsuarioSesion
    {
        public static List<Login> usuariosIntentosLoguedos = new List<Login>();

        public static void AgregarUsuarioLista(string nombreUsuario)
        {

            // Verificar si el usuario ya existe
            Login usuarioExistente = usuariosIntentosLoguedos.Find(u => u.NombreUsuario == nombreUsuario);
            if (usuarioExistente == null)
            {
                // Agregar el nuevo usuario a la lista
                usuariosIntentosLoguedos.Add(new Login(nombreUsuario));
            }
        }
        public static bool InactivarUsuario(string nombreUsuario)
        {
            // Buscar el usuario por nombre de usuario
            Login usuario = usuariosIntentosLoguedos.Find(u => u.NombreUsuario == nombreUsuario);
            if (usuario != null)
            {
                // Si el usuario ha excedido los 3 intentos, inactivarlo
                if (usuario.Intentos >= 3)
                {
                    usuariosIntentosLoguedos.Remove(usuario);
                    Console.WriteLine("El usuario ha sido inactivado debido a exceso de intentos fallidos.");
                    return true;
                }
            }
            return false;
        }

    }
}
