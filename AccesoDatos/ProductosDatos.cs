﻿using AccesoDatos.Utilidades;
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
                List<ProductoWebServices> listadousuarios = JsonConvert.DeserializeObject<List<ProductoWebServices>>(contentstream);
                return listadousuarios;

            }
        }
    }
}
