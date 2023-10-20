

namespace Modelo.ProveedorModelo
{
    public class ProveedorWebServices
    {
        private Guid _id;
        private string _nombre, _apellido, _email, _cuit;
        private DateTime _fechaAlta, _fechaBaja;

        public Guid Id { get => _id; set => _id = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public string Email { get => _email; set => _email = value; }
        public string Cuit { get => _cuit; set => _cuit = value; }
        public DateTime FechaAlta { get => _fechaAlta; set => _fechaAlta = value; }
        public DateTime? FechaBaja { get; set; }
    }
}
