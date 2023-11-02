using AccesoDatos;
using Modelo.Cliente_Modelo;
using Modelo.Cliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.Switch;

namespace Negocio.ClienteNegocio
{
    public class ClsCliente
    {

        static List<Cliente> listaClientes = new List<Cliente>();

        //¿Qué valores se deben modificar del proveedor?
        public static bool ModificarCliente(int dni, string nuevaDireccion,string nuevoTelefono,string nuevoEmail)
        {
            //prueba
            Activo activo = new Activo();
            Cliente cliente1 = new Cliente(Guid.NewGuid(), Guid.NewGuid(), "Facu", "Cairo", "Donato alvarez 510","4-581-5873", "facu@facu.com", Convert.ToDateTime("15/10/2023"), Convert.ToDateTime("15/10/2023"), Convert.ToDateTime("15/10/2023"), "1", 123456,activo);
            listaClientes.Add(cliente1);

            bool flag = false;
            Cliente clienteEncontrado = buscarClientePorDni(dni);
            if (clienteEncontrado != null)
            {
                clienteEncontrado.Direccion = nuevaDireccion;
                clienteEncontrado.Telefono = nuevoTelefono; 
                clienteEncontrado.Email= nuevoEmail;
                //asi se coloca estado??
                clienteEncontrado.Estado= new Activo();
                flag = true;
            }
            else
            {
                Console.WriteLine("\nError: no existe ningún Cliente con el DNI: {0} \n", dni);
            }
            return flag;
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
