using AccesoDatos.Utilidades;
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
                Console.WriteLine("Proveedor agregado exitosamente.");
            }
        }

    }
}
