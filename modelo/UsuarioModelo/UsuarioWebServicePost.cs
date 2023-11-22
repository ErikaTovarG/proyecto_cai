<<<<<<< HEAD
﻿using System;
=======
﻿using Modelo.Switch;
using System;
>>>>>>> ceb1b8944e947760c9b272d31a476d1806b36da7
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.UsuarioModelo
{
    public class UsuarioWebServicePost
    {
<<<<<<< HEAD
       
            private Guid _idUsuario;
            private string _nombre, _apellido, _usuario,_direccion,_telefono,_email,_nombreUsuario,_contraseña;
            private int _host, _dni;
            private DateTime _fechaNacimiento;



            public UsuarioWebServicePost()
            {

            }

            public Guid IdUsuario { get => _idUsuario; set => _idUsuario = value; }
            public string Nombre { get => _nombre; set => _nombre = value; }
            public string Apellido { get => _apellido; set => _apellido = value; }
            public string Usuario { get => _usuario; set => _usuario = value; }
            public string Direccion { get => _direccion; set => _direccion = value; }
            public string Telefono { get => _telefono; set => _telefono = value; }
            public string Email { get => _email; set => _email = value; }
            public string NombreUsuario { get => _nombreUsuario; set => _nombreUsuario = value; }
            public string Contraseña { get => _contraseña; set => _contraseña = value; }
            public int Host { get => _host; set => _host = value; }
            public int Dni { get => _dni; set => _dni = value; }
            public DateTime FechaNacimiento { get => _fechaNacimiento; set => _fechaNacimiento = value; }

            public override string ToString()
            {
                return string.Format($"* {Dni} - {Nombre} - {Apellido}.");
            }
        }
    
=======
        private string idUsuario, nombre, apellido, direccion, telefono, email, nombreUsuario, contrasenia;
        private int host, dni;
        private string fechaNac;

        public string IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
       public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Email { get => email; set => email = value; }
        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string Contrasenia { get => contrasenia; set => contrasenia = value; }
        public int Host { get => host; set => host = value; }
        public int Dni { get => dni; set => dni = value; }
        public string FechaNac { get => fechaNac; set => fechaNac = value; }
    }
>>>>>>> ceb1b8944e947760c9b272d31a476d1806b36da7
}
