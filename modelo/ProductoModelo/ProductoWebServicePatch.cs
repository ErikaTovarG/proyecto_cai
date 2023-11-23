using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.ProductoModelo
{
    public class ProductoWebServicePatch
    {
        
        private string _id, idUsuario;
        private string _precio;
        private string _stock;
        
    
        public string Id { get => _id; set => _id = value; }
        public string IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string Precio { get => _precio; set => _precio = value; }
        public string Stock { get => _stock; set => _stock = value; }

    }
}
