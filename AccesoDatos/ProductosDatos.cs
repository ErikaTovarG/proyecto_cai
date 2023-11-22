using AccesoDatos.Utilidades;
using Modelo.ProductoModelo;
using Modelo.UsuarioModelo;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class ProductosDatos
    {
        public static List<ProductoWebServices> ListarProductos()
        {
            HttpResponseMessage response = WebHelper.Get("Producto/TraerProductos");

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("verifique los datos ingresados");
            }
            else
            {
                var contentstream = response.Content.ReadAsStringAsync().Result;
                List<ProductoWebServices> Listado = JsonConvert.DeserializeObject<List<ProductoWebServices>>(contentstream);
                return Listado;

            }
        }

        public static List<ProductoWebServices> ListarProductosPorCategoria(int idCategoria)
        {
            HttpResponseMessage response = WebHelper.Get("Producto/TraerProductosPorCategoria?catnum=" + idCategoria);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("verifique los datos ingresados");
            }
            else
            {
                var contentstream = response.Content.ReadAsStringAsync().Result;
                List<ProductoWebServices> listadousuarios = JsonConvert.DeserializeObject<List<ProductoWebServices>>(contentstream);
                return listadousuarios;

            }
        }

        public static void CrearProducto(ProductoWebServicesPost producto)
        {
            var jsonRequest = JsonConvert.SerializeObject(producto);

            HttpResponseMessage response = WebHelper.Post("Producto/AgregarProducto", jsonRequest);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception(response.StatusCode.ToString());
            }
        }

        public static void BorrarProducto(string idProducto, string idUsuarioMaster)
        {
            Dictionary<String, String> map = new Dictionary<String, String>();
            map.Add("id", idProducto);
            map.Add("idUsuario", idUsuarioMaster);

            var jsonRequest = JsonConvert.SerializeObject(map);

            HttpResponseMessage response = WebHelper.DeleteConBody("Producto/BajaProducto", jsonRequest);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Verifique los datos ingresados.");
            }

        }

    }
}
