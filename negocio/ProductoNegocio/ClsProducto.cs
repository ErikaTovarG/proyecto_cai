using Modelo.UsuarioModelo;
using Modelo.Producto;
using Modelo.Switch;
using AccesoDatos;
using Modelo.ProductoModelo;

namespace Negocio.ProductoNegocio
{

    public static class ClsProducto

    {
        //static List<Producto> listaProductos = new List<Producto>();

        ////Controla el estado del producto según la fecha de baja. 
        //public static void ControlarEstadoProducto()
        //{
        //    Producto prod = new Producto();
        //    Activo activo = new Activo();
        //    Inactivo inactivo = new Inactivo();
            
        //    if (prod.FechaBaja == null)
        //    {
        //        prod.Estado = activo;
        //    }else
        //    {
        //        prod.Estado = inactivo;
        //    }
        //}

        public static List<ProductoWebServices> ListarProductos()
        {
            return ProductosDatos.ListarProductos();
        }



    }
}





