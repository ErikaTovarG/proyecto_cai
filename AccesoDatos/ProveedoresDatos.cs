using AccesoDatos.Utilidades;
using Modelo.Proveedor;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    internal class ProveedoresDatos
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
    }
}
