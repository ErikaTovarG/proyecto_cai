using AccesoDatos.Utilidades;
using Modelo.ProductoModelo;
using Modelo.Proveedor;
using Modelo.ProveedorModelo;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AccesoDatos
{
    public class ProveedoresDatos
    {
        public static List<ProveedorWebServices> ListarProveedores()
        {
            HttpResponseMessage response = WebHelper.Get("Proveedor/TraerProveedores");

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Verifique los datos ingresados");
            }
            else
            {
                var contentStream = response.Content.ReadAsStringAsync().Result;
                List<ProveedorWebServices> listadoProveedores = JsonConvert.DeserializeObject<List<ProveedorWebServices>>(contentStream);
                return listadoProveedores;
            }
        }

        public static void CrearProveedor(ProveedorWebServicePost proveedor)
        {
            var jsonRequest = JsonConvert.SerializeObject(proveedor);

            //Console.WriteLine(jsonRequest);

            HttpResponseMessage response = WebHelper.Post("Proveedor/AgregarProveedor", jsonRequest);

            if (!response.IsSuccessStatusCode)
            {
                //throw new Exception(response.StatusCode.ToString());
                Console.WriteLine(response.StatusCode.ToString());
            }
            else
            {
                Console.WriteLine("Proveedor agregado exitosamente.");
            }
        }

        public static void BorrarProveedor(string idProveedor, string idUsuarioMaster)
        {
            Dictionary<String, String> map = new Dictionary<String, String>();
            map.Add("id", idProveedor);
            map.Add("idUsuario", idUsuarioMaster);

            var jsonRequest = JsonConvert.SerializeObject(map);

            HttpResponseMessage response = WebHelper.DeleteConBody("Proveedor/BajaProveedor", jsonRequest);
            
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Verifique los datos ingresados");
            }

        }

        //modificar producto con swagger
        public static void EditarProveedor(ProveedorWebservicePatch proveedor)
        {
            var jsonRequest = JsonConvert.SerializeObject(proveedor);

            HttpResponseMessage response = WebHelper.Patch("Proveedor/ModificarProveedor", jsonRequest);

            if (!response.IsSuccessStatusCode)
            {
                Console.WriteLine(response.StatusCode.ToString());
            }
            else
            {
                Console.WriteLine("Proveedor modificado.");
            }
        }


    }
}
