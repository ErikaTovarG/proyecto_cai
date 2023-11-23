using AccesoDatos.Utilidades;
using Modelo.Cliente_Modelo;
using Modelo.ClienteModelo;
using Modelo.ProductoModelo;
using Modelo.ProveedorModelo;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class ClientesDatos
    {
        public static List<ClienteWebServices> ListarClientes()
        {
            HttpResponseMessage response = WebHelper.Get("Cliente/GetClientes");

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("verifique los datos ingresados");
            }
            else
            {
                var contentstream = response.Content.ReadAsStringAsync().Result;
                List<ClienteWebServices> listadousuarios = JsonConvert.DeserializeObject<List<ClienteWebServices>>(contentstream);
                return listadousuarios;

            }
        }


        public static void CrearCliente(ClienteWebServicesPost cliente)
        {
            var jsonRequest = JsonConvert.SerializeObject(cliente);

            HttpResponseMessage response = WebHelper.Post("Cliente/AgregarCliente", jsonRequest);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception(response.StatusCode.ToString());
            }
            //else
            //{
            //    Console.WriteLine("Cliente agregado exitosamente." + response.StatusCode.ToString());
            //}
        }

        public static void BorrarCliente(string idUsuario, string idUsuarioMaster)
        {
            Dictionary<String, String> map = new Dictionary<String, String>();
            map.Add("id", idUsuario);
            map.Add("idUsuario", idUsuarioMaster);

            var jsonRequest = JsonConvert.SerializeObject(map);

            HttpResponseMessage response = WebHelper.DeleteConBody("Cliente/BajaCliente", jsonRequest);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Verifique los datos ingresados.");
            }

        }


        public static void EditarCliente(ClienteWebServicePatch cliente)
        {
            var jsonRequest = JsonConvert.SerializeObject(cliente);

            HttpResponseMessage response = WebHelper.Patch("Cliente/PatchCliente", jsonRequest);

            if (!response.IsSuccessStatusCode)
            {
                Console.WriteLine(response.StatusCode.ToString());
            }
            
        }


    }
}
