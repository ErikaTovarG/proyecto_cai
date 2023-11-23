using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.VentaModelo
{
    public class VentaWebService
    {
        private string idCliente, idUsuario, idProducto;
        private int cantidad, estado;

        public string IdCliente { get => idCliente; set => idCliente = value; }
        public string IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string IdProducto { get => idProducto; set => idProducto = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public int Estado { get => estado; set => estado = value; }
    }
}
