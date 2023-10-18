using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.UsuarioModelo
{
    public class UsuarioWebServices
    {
        private Guid _id;
        private string _nombre, _apellido, _direccion, _telefono, _email, _contrasenia, _usuario;
        private object _estado;
        private DateTime _fechaAlta, _fechaNacimiento;
        private int _host, _dni, _contador;
        public string nombreUsuario { get => _usuario; set => _usuario = value; }
        public Guid id { get => _id; set => _id = value; }
        public string nombre { get => _nombre; set => _nombre = value; }
        public string apellido { get => _apellido; set => _apellido = value; }
        public int dni { get => _dni; set => _dni = value; }
        public int host { get => _host; set => _host = value; }

        public UsuarioWebServices()
        {

        }
    }
}
