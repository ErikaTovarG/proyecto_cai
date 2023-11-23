using AccesoDatos;
using Modelo.Cliente_Modelo;
using Modelo.Cliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.Switch;
using Modelo.ClienteModelo;

namespace Negocio.ClienteNegocio
{
    public class ClsCliente
    {

        static List<Cliente> listaClientes = new List<Cliente>();

       
        public static void ModificarCliente(ClienteWebServicePatch cliente)
        {
            ClientesDatos.EditarCliente(cliente);
        }

        public static Cliente buscarClientePorDni(int dni)
        {
            return listaClientes.Find(cliente=> cliente.Dni == dni);
        }

        public static List<ClienteWebServices> ListarClientes()
        {
            return ClientesDatos.ListarClientes();
        }
        public static ClienteWebServices buscarClientePorDniWeb(int dni)
        {
            return ListarClientes().Find(cliente => cliente.Dni == dni);
        }

        public static ClienteWebServices buscarClientePorIdWeb(Guid idProveedor)
        {
            return ListarClientes().Find(proveedor => proveedor.Id == idProveedor);
        }


        public static string BuscarClientePorDniYDevolverString(int dni)
        {
            ClienteWebServices clienteEncontrado = ListarClientes().Find(cliente => cliente.Dni == dni);
            return Convert.ToString(clienteEncontrado.Id);
        }


        public static void CrearCliente(ClienteWebServicesPost usuario)
        {
            ClientesDatos.CrearCliente(usuario);
        }

        public static void EliminarClientePorDni(string idCliente)
        {
            string usuarioAdministrador = "D347CE99-DB8D-4542-AA97-FC9F3CCE6969";
            ClientesDatos.BorrarCliente(idCliente, usuarioAdministrador);
        }

    }
}
