using AccesoDatos;
using Modelo.ProductoModelo;
using Modelo.Proveedor;
using Modelo.ProveedorModelo;
using Modelo.UsuarioModelo;


namespace Negocio.ProveedorNegocio
{
    public static class ClsProveedor

    {
        static List<Proveedor> listaProveedores = new List<Proveedor>();
        public static void cargarProveedores()
        {
            Proveedor proveedor1 = new Proveedor(Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid(), "Proveedor 1", "Apellido 1", "acrs@gmail.com", Convert.ToDateTime("15/10/2023"), Convert.ToDateTime(null), 123456);
            listaProveedores.Add(proveedor1);
        }
    
        //¿Qué valores se deben modificar del proveedor?
        public static bool ModificarProveedor (int cuit, string nuevoNombre)
        {
            //prueba
            Proveedor proveedor1 = new Proveedor(Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid(), "Proveedor 1", "Apellido 1", "acrs@gmail.com", Convert.ToDateTime("15/10/2023"), Convert.ToDateTime(null), 123456);
            listaProveedores.Add(proveedor1);
            
            bool flag = false;
            Proveedor proveedorEncontrado = BuscarProveedorporCUIT(cuit);
            if (proveedorEncontrado != null)
            {
                proveedorEncontrado.Nombre = nuevoNombre;
                flag = true;
            }
            else
            {
                Console.WriteLine("\nError: no existe ningún proveedor con el CUIT: {0} \n", cuit);   
            }
          return flag;
        }

        public static Proveedor BuscarProveedorporCUIT(int cuit)
        {
            return listaProveedores.Find(proveedor => proveedor.CUIT == cuit);
        }

        public static List<ProveedorWebServices> ListarProveedores()
        {
            return ProveedoresDatos.ListarProveedores();
        }
        public static ProveedorWebServices BuscarProveedorPorCuit(string cuit)
        {
            return ListarProveedores().Find(p => p.Cuit == cuit);
        }
    }
}





