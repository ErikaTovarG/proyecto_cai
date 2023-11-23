using AccesoDatos.Utilidades;
using Modelo.Cliente_Modelo;
using Modelo.UsuarioModelo;
using Modelo.VentaModelo;
using Newtonsoft.Json;


namespace AccesoDatos
{
    public static class VentaDatos
    {
        public static void CrearVenta(VentaWebServicePost venta)
        {
            var jsonRequest = JsonConvert.SerializeObject(venta);

            //Console.WriteLine(jsonRequest);

            HttpResponseMessage response = WebHelper.Post("Venta/AgregarVenta", jsonRequest);

            if (!response.IsSuccessStatusCode)
            {
                //throw new Exception(response.StatusCode.ToString());
                Console.WriteLine(response.StatusCode.ToString());
            }
            else
            {
                Console.WriteLine("Venta agregada exitosamente.");
            }
        }

        public static List<VentaWebService> ListarVentasPorCliente(Guid idcliente)
        {
            HttpResponseMessage response = WebHelper.Get("Venta/GetVentaByCliente?id=" + idcliente);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("verifique los datos ingresados");
            }
            else
            {
                var contentstream = response.Content.ReadAsStringAsync().Result;
                List<VentaWebService> ventas = JsonConvert.DeserializeObject<List<VentaWebService>>(contentstream);
                return ventas;

            }
        }
        public static void DevolucionVenta(string idVenta, string idUsuarioMaster)
        {
            Dictionary<String, String> map = new Dictionary<String, String>();
            map.Add("id", idVenta);
            map.Add("idUsuario", idUsuarioMaster);

            var jsonRequest = JsonConvert.SerializeObject(map);

            HttpResponseMessage response = WebHelper.Patch("Venta/DevolverVenta", jsonRequest);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Verifique los datos ingresados");
            }
        }

    }
}
