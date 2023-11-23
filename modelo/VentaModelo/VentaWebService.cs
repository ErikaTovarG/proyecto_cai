using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.VentaModelo
{
    public class VentaWebService
    {

        private Guid _id;
        private int _cantidad, estado;
        private DateTime _fechaAlta;

        public Guid Id { get => _id; set => _id = value; }
        public int Cantidad { get => _cantidad; set => _cantidad = value; }
        public int Estado { get => estado; set => estado = value; }
        public DateTime FechaAlta { get => _fechaAlta; set => _fechaAlta = value; }

        public string ComboDisplay { get => $"Id: {Id} - Cantidad:{Cantidad} - Estado: { Estado}- FechaDeVenta{FechaAlta}"; }

    }
}
