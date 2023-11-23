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
        private bool _activo;

        public string NombreUsuario { get => _nombreUsuario; set => _nombreUsuario = value; }
        public string Contraseña { get => _contraseña; set => _contraseña = value; }

        public int Intentos { get => _intentos; }
        public bool Activo { get => _activo; }
        public Login() { }
        public Login(string nombreUsuario)
        {
            _nombreUsuario = nombreUsuario;
            _intentos = 1;
        }
        public void SumarIntentos()
        {
            this._intentos++;
        }
        public void ActivarUsuario()
        {
            this._activo = true;
        }
        public void InactivarUsuario()
        {
            this._activo= false;
        }
        public void ResetearIntentos()
        {
            this._intentos = 0;
        }
    }
}
