using AccesoDatos.Utilidades;
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

        public static void BorrarProveedor(string idUsuario, string idUsuarioMaster)
        {
            Dictionary<String, String> map = new Dictionary<String, String>();
            map.Add("id", idUsuario);
            map.Add("idUsuario", idUsuarioMaster);

            var jsonRequest = JsonConvert.SerializeObject(map);

            HttpResponseMessage response = WebHelper.DeleteConBody("Usuario/BajaUsuario", jsonRequest);
            
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Verifique los datos ingresados");
            }

        }


    }
}
