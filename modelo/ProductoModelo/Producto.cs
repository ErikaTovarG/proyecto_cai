using Modelo.Switch;

namespace Modelo.Producto
{

    public class Producto
    {
        #region Variables Privadas
        private Guid _id, _idCategoria, _idProducto, _idUsuario;
        private string _nombre;
        private DateTime _fechaAlta;
        private Double _precio;
        private int _stock;
        private object _estado;
        #endregion


        #region Variables Publicas
        public Guid Id { get => _id; set => _id = value; }
        public Guid IdCategoria { get => _idCategoria; set => _idCategoria = value; }
        public Guid IdProducto { get => _idProducto; set => _idProducto = value; }  
        public Guid IdUsuario { get => _idUsuario; set => _idUsuario = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public DateTime FechaAlta { get => _fechaAlta; set => _fechaAlta = value; }
        public DateTime? FechaBaja { get; set; }
        public Double Precio { get => _precio; set => _precio = value; }
        public int Stock { get => _stock; set => _stock = value; }
        public Estado Estado { get; set; } //si la fecha de baja es null, por defecto el estado está activo.

        #endregion


        #region Contructores 
        public Producto()
        {

        }
        public Producto(Guid id, Guid idCategoria, Guid idProducto, Guid idUsuario,  string nombre,DateTime fechaAlta, DateTime fechaBaja, Double precio, int stock, Estado estado)
        {
            Id = id;
            IdCategoria = idCategoria;
            IdProducto= idProducto;
            IdUsuario = idUsuario;
            Nombre = nombre;
            FechaAlta = fechaAlta;
            FechaBaja = fechaBaja;
            Precio = precio;
            Stock = stock;
            Estado = estado;

        }
        #endregion






        public string ToString()
        {
            return $"Nombre: {Nombre} \nFecha Alta: " +
                   $"{FechaAlta} \nFecha Baja: {FechaBaja} \nPrecio: {Precio} \nStock: {Stock}";
        }

    }
}
