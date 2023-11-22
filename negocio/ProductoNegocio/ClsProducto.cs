using Modelo.UsuarioModelo;
using Modelo.Producto;
using Modelo.Switch;
using AccesoDatos;
using Modelo.ProductoModelo;
using System.Data;
using Modelo.Proveedor;
using Modelo.ProveedorModelo;
using System.Collections.Generic;

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

        public static int PrecioUnitarioProducto(Guid id)
        {
            try
            {
                ProductoWebServices productoEncontrado = ListarProductos().Find(p => p.Id == id);
                if (productoEncontrado != null)
                {
                    return productoEncontrado.Precio;
                }
                else
                {
                    throw new Exception("Producto no encontrado");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener el precio unitario: {ex.Message}");
                return 0; 
            }
        }
        public static bool SinStock(Guid id)
        {
            try
            {
                ProductoWebServices productoEncontrado = ListarProductos().Find(p => p.Id == id);
                if (productoEncontrado.Stock == 0)
                {
                    return true;
                }
                return false; 
                //throw new Exception("Producto sin stock");
            }
            catch (Exception ex)
            {
                return false;
            }
            
        }
        public static bool StockBajo(Guid id)
        {
            try
            {
                ProductoWebServices producto = ListarProductos().Find(p => p.Id == id);
                double stock = producto.Stock;
                double stockLimite = 0.25 * stock;
                if (stock < stockLimite)
                {
                    return true;
                }
                return false;
                throw new Exception("Producto sin stock");
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool ConsultaStock(Guid id, string cant)
        {
            ProductoWebServices producto = ListarProductos().Find(p => p.Id == id);
            if(producto.Stock > Convert.ToInt32(cant)) return true;
            return false;
        }
    }
}





