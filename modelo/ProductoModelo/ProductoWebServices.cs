using Modelo.UsuarioModelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.ProductoModelo
{
    public class ProductoWebServices
    {
        private Guid _id;
        private string _nombre;
        private int _idCategoria,_precio, _stock;
        private DateTime _fechaAlta, _fechaBaja;
        public Guid Id { get => _id; set => _id = value; }
        public int IdCategoria { get => _idCategoria; set => _idCategoria = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public int Precio { get => _precio; set => _precio = value; }
        public int Stock { get => _stock; set => _stock = value; }
        public DateTime FechaAlta { get => _fechaAlta; set => _fechaAlta = value; }
        public DateTime? FechaBaja { get; set; }


        //public override string ToString()
        //{
        //    return string.Format($"* {Nombre} - {Stock}.");
        //}

        public string ComboDisplay { get => $"{Nombre}"; }
    }
}
