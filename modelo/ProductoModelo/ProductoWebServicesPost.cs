using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.ProductoModelo
{
    public class ProductoWebServicesPost
    {
            private Guid _id;
            private string _nombre;
            private int _idCategoria, _precio, _stock;
            private DateTime _fechaAlta, _fechaBaja;
            private Guid _idUsuario, _idProveedor;

        

            public Guid Id { get => _id; set => _id = value; }
            public int IdCategoria { get => _idCategoria; set => _idCategoria = value; }
            public string Nombre { get => _nombre; set => _nombre = value; }
            public int Precio { get => _precio; set => _precio = value; }
            public int Stock { get => _stock; set => _stock = value; }
            public DateTime FechaAlta { get => _fechaAlta; set => _fechaAlta = value; }
            public Guid IdUsuario { get => _idUsuario; set => _idUsuario = value; }
            public Guid IdProveedor { get => _idProveedor; set => _idProveedor = value; }
            public DateTime? FechaBaja { get; set; }

        public ProductoWebServicesPost(Guid id, int idCategoria, string nombre, int precio, int stock, DateTime fechaAlta, Guid idUsuario, Guid idProveedor, DateTime? fechaBaja)
        {
            Id = id;
            IdCategoria = idCategoria;
            Nombre = nombre;
            Precio = precio;
            Stock = stock;
            FechaAlta = fechaAlta;
            IdUsuario = idUsuario;
            IdProveedor = idProveedor;
            FechaBaja = fechaBaja;
        }
        public ProductoWebServicesPost()
        {

        }
    }
}
