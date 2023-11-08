using Modelo.UsuarioModelo;
using Modelo.Producto;
using Modelo.Switch;
using AccesoDatos;
using Modelo.ProductoModelo;
using System.Data;
using Modelo.Proveedor;
using Modelo.ProveedorModelo;

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

        public static List<CategoriaProductos> ListarCategorias()
        {
            List<CategoriaProductos> categorias = new List<CategoriaProductos>();

            categorias.Add(new CategoriaProductos(1, "Audio"));
            categorias.Add(new CategoriaProductos(2, "Celulares"));
            categorias.Add(new CategoriaProductos(3, "Electro Hogar"));
            categorias.Add(new CategoriaProductos(4, "Informatica"));
            categorias.Add(new CategoriaProductos(5, "Smart TV"));

            return categorias;
        }

        public static List<ProductoWebServices> ListarProductos()
        {
            return ProductosDatos.ListarProductos();
        }

        public static void CrearProducto(ProductoWebServicesPost producto)
        {
            ProductosDatos.CrearProducto(producto);
        }


        //public static ProductoWebServices BuscarProductoPorId( Guid idProducto)
        //{
        //    return ListarProductos().Find(producto => producto.Id == idProducto);
        //}

        //public static bool EliminarProductoPorId( Guid idProducto)
        //{
        //    var producto = BuscarProductoPorId( idProducto);
        //    if (producto != null)
        //    {
        //        ListarProductos().Remove(producto);
        //        return true;
        //    }
        //    return false;
        //}

        public static string BuscarProveedorPorCuitYDevolverString(Guid id)
        {
            ProductoWebServices productoEncontrado = ListarProductos().Find(p => p.Id == id);
            return Convert.ToString( productoEncontrado.Id);
        }



        public static void EliminarProductoPorId(string idProducto)
        {
            string usuarioAdministrador = "D347CE99-DB8D-4542-AA97-FC9F3CCE6969";
            ProductosDatos.BorrarProducto(idProducto, usuarioAdministrador);
        }



    }
}





