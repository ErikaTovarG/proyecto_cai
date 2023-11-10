using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Cliente_Modelo
{
    public class ClienteWebServicesPost
    {

        private Guid _id;
        private string _nombre, _idUsuario;
        private string _apellido;
        private string _direccion;
        private string _telefono;
        private string _email;
        private DateTime _fechaAlta;
        private DateTime _fechaNacimiento;
        private DateTime _fechaBaja;
        private string _host;
        private int _dni;

        public Guid Id { get => _id; set => _id = value; }
        public string IdUsuario { get => _idUsuario; set => _idUsuario = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public string Telefono { get => _telefono; set => _telefono = value; }
        public string Email { get => _email; set => _email = value; }
        public DateTime FechaAlta { get => _fechaAlta; set => _fechaAlta = value; }
        public DateTime FechaNacimiento { get => _fechaNacimiento; set => _fechaNacimiento = value; }
        public DateTime? FechaBaja { get; set; }
        public string Host { get => _host; set => _host = value; }
        public int Dni { get => _dni; set => _dni = value; }


    }
}
