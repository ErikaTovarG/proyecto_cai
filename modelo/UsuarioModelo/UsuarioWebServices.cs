using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.UsuarioModelo
{
        public class UsuarioWebServices
        {
                private Guid _id;
                private string _nombre, _apellido, _nombreUsuario;

                private int _host, _dni;
                public Guid id { get => _id; set => _id = value; }
                public string nombre { get => _nombre; set => _nombre = value; }
                public string apellido { get => _apellido; set => _apellido = value; }
                public int dni { get => _dni; set => _dni = value; }
                public string nombreUsuario { get => _nombreUsuario; set => _nombreUsuario = value; }
                public int host { get => _host; set => _host = value; }

                public UsuarioWebServices()
                {

                }
                private string hostAdevolver { get => hostSeleccionado(host); }
                public string ComboDisplay { get => $"{nombre} {apellido} -{hostAdevolver}"; }
                private string hostSeleccionado(int host)
                {
                        string devolver;
                        if (host == 1) devolver = "Vendedor";
                        else if (host == 2) devolver = "Supervisor";
                        else devolver = "Administrador";

                        return devolver;
                }
        }
}
