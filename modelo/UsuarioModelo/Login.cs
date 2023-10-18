using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.UsuarioModelo
{
    public class Login
    {
        private string _nombreUsuario;
        private string _contraseña;
        private int _intentos;

        public string NombreUsuario { get => _nombreUsuario; set => _nombreUsuario = value; }
        public string Contraseña { get => _contraseña; set => _contraseña = value; }

        public int Intentos { get => _intentos; }
        public Login() { }
        public Login(string nombreUsuario)
        {
            _nombreUsuario = nombreUsuario;
            _intentos = 0;
        }
        public void SumarIntentos()
        {
            this._intentos++;
        }
    }
}
