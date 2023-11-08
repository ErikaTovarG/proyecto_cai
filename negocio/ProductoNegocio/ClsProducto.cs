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

        public static List<ProductoWebServices> ListarProductosPorCategoria(int categoria)
        {
            return ProductosDatos.ListarProductosPorCategoria(categoria);
        }

        public static void CrearProducto(ProductoWebServicesPost producto)
        {
            ProductosDatos.CrearProducto(producto);
        }

        public static string BuscarProveedorPorId_DevolverString(Guid id)
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





