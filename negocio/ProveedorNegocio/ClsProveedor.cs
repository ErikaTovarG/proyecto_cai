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

        public static ProveedorWebServices BuscarProveedorPorId( Guid idProveedor)
        {
            return ListarProveedores().Find(proveedor => proveedor.Id == idProveedor);
        }


        public static string BuscarProveedorPorCuitYDevolverString(string cuit)
        {
           ProveedorWebServices proveedorEncontrado= ListarProveedores().Find(p => p.Cuit == cuit);
           return Convert.ToString(proveedorEncontrado.Id);
        }

        public static void CrearProveedor(ProveedorWebServicePost usuario)
        {
            ProveedoresDatos.CrearProveedor(usuario);
        }


        public static void EliminarProveedorPorCuit(string idProveedor)
        {
            string usuarioAdministrador = "D347CE99-DB8D-4542-AA97-FC9F3CCE6969";
            ProveedoresDatos.BorrarProveedor(idProveedor, usuarioAdministrador);
        }

    }
}





