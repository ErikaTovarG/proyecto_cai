
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Proveedor
{
    public class Proveedor
    {
        #region Variables Privadas
        private Guid _id, _idProducto, _idUsuario;
        private string _nombre, _apellido, _email;
        private DateTime _fechaAlta;
        private int _cuit;
        #endregion


        #region Variables Publicas
        public Guid Id { get => _id; set => _id = value; }
        public Guid IdProducto { get => _idProducto; set => _idProducto = value; }  
        public Guid IdUsuario { get => _idUsuario; set => _idUsuario = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public string Email { get => _email; set => _email = value; }
        public DateTime FechaAlta { get => _fechaAlta; set => _fechaAlta = value; }
        public DateTime? FechaBaja { get; set; }
        public int CUIT { get => _cuit; set => _cuit = value; }

        #endregion


        #region Contructores 
        public Proveedor()
        {

        }
        public Proveedor(Guid id, Guid idProducto, Guid idUsuario,  string nombre, string apellido, string email, DateTime fechaAlta, DateTime fechaBaja, int cuit)
        {
            Id = id;
            IdProducto= idProducto;
            IdUsuario = idUsuario;
            Nombre = nombre;
            Apellido = apellido;
            Email = email;
            FechaAlta = fechaAlta;
            FechaBaja = fechaBaja;
            CUIT = cuit;
        }
        #endregion

        public string ToString()
        {
            return $"Nombre: {Nombre} \nApellido: {Apellido}\nEmail: {Email}  \nFecha Alta: " +
                   $"{FechaAlta} \nFecha Baja: {FechaBaja} \nCUIT: {CUIT}";
        }

    }
}
