using Modelo.Switch;

namespace Modelo.Cliente
{
    public class Cliente
    {
        #region Variables Privadas
        private Guid _id,_idUsuario;
        private string _nombre;
        private string _apellido;
        private string _direccion;
        private string _telefono;
        private string _email;
        private DateTime _fechaAlta;
        private DateTime _fechaNacimiento;
        private DateTime _fechaBaja;
        private string _host;
        private int _dni;
        private object _estado;

        #endregion


        #region Variables Publicas
        public Guid Id { get => _id; set => _id = value; }
        public Guid IdUsuario { get => _idUsuario; set => _idUsuario = value; }
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
        public Estado Estado { get; set; }


        #endregion


        #region Contructores 
        public Cliente()
        {

        }
        public Cliente(Guid id, Guid idUsuario, string nombre,string apellido, string direccion, string telefono, string email, DateTime fechaAlta,DateTime fechaNacimiento, DateTime fechaBaja, string host, int dni,Switch.Estado estado)
        {
            Id = id;
            IdUsuario = idUsuario;
            Nombre = nombre;
            Apellido = apellido;
            Direccion = direccion;
            Telefono = telefono;
            Email = email;
            FechaAlta = fechaAlta;
            FechaNacimiento = fechaNacimiento;
            FechaBaja = fechaBaja;
            Host = host;
            Dni = dni;
            Estado = estado;
     

        }
        #endregion






        public string ToString()
        {
            return $"Nombre: {Nombre}\nApellido: {Apellido} \nFecha Alta: " +
                   $"{FechaAlta} \nFecha Baja: {FechaBaja} \nDni: {Dni} \nDireccion: {Direccion}";
        }

    }
}

