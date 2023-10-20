using Modelo.ProductoModelo;
using Modelo.Switch;
using Modelo.UsuarioModelo;
using Negocio.ProductoNegocio;
using Negocio.UsuarioLogNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion
{
    public static class FuncionesAuxiliares
    {
        public static int SeleccionarOpcion(int cant)
        {
            bool flag;
            int salida = 0;
            do
            {
                Console.Write("Indique la opción con la cual desea continuar: ");
                string respuesta = Console.ReadLine().Trim();
                flag = Validaciones.ValidaEntero(respuesta, cant, ref salida);
            } while (!flag);

            return salida;
        }

        public static bool Preguntar(UsuarioModelo usuario)
        {
            string res;
            bool flag;
            do
            {
                Console.Write("\n\t¿Desea intentar nuevamente? S/N: ");
                res = Console.ReadLine().ToUpper();
                flag = Validaciones.ValidaSyN(res);
            } while (!flag);

            if (res == "N") { Environment.Exit(0); }
            //Si la res es S, sumo el contador del usuario en 1 hasta que sea mayor igual a 3.
            if (res == "S")
            {
                usuario.Contador++;
                if (usuario.Contador >= 3)
                {
                    Console.WriteLine("\n ERROR: Ha excedido los intentos.\n El usuario {0} ha pasado a inactivo", usuario.Usuario);
                    Inactivo inactivo = new Inactivo();
                    usuario.Estado = inactivo;
                    Environment.Exit(0);
                }

            }
            return flag;
        }


        //USUARIOS
        public static int BuscarUsuarioYDevolverHost(Guid idUsuario)
        {
            List<UsuarioWebServices> usuarios = ClsUsuario.ListarUsuarios(Guid.Parse("D347CE99-DB8D-4542-AA97-FC9F3CCE6969"));
            UsuarioWebServices usuarioEncontrado = usuarios.Find((usuario) => usuario.id == idUsuario);

            if (usuarioEncontrado != null)
            {
                return usuarioEncontrado.host;
            }
            else
            {
                return -1;
            }
        }

        public static UsuarioWebServices BuscarUsuarioCompletoDatos(Guid idUsuario)
        {
            List<UsuarioWebServices> usuarios = ClsUsuario.ListarUsuarios(Guid.Parse("D347CE99-DB8D-4542-AA97-FC9F3CCE6969"));
            UsuarioWebServices usuarioEncontrado = usuarios.Find((usuario) => usuario.id == idUsuario);

            if (usuarioEncontrado != null)
            {
                return usuarioEncontrado;
            }
            else
            {
                return null;
            }
        }

        public static void ListarUsuarios()
        {
            List<UsuarioWebServices> usuariosWebServices = ClsUsuario.ListarUsuarios(Guid.Parse("D347CE99-DB8D-4542-AA97-FC9F3CCE6969"));
            Console.WriteLine($"\n\tHay en stock {usuariosWebServices.Count} usuarios \n");

            foreach (var usuario in usuariosWebServices)
            {
                ImprimirUsuarios(usuario);
            }

        }
        private static void ImprimirUsuarios(UsuarioWebServices usuario)
        {
            Console.WriteLine(new string('*', 60));
            Console.WriteLine($"ID: {usuario.id}");
            Console.WriteLine($"Apellido: {usuario.apellido}");
            Console.WriteLine($"Nombre: {usuario.nombre}");
            Console.WriteLine($"DNI: {usuario.dni}");
            Console.WriteLine($"Host: {usuario.host}");
            Console.WriteLine($"Usuario: {usuario.usuario}");
            Console.WriteLine(new string('*', 60));
        }

        public static void OpcionAContinuarAdministrador(int opcion, List<UsuarioModelo> usuarios)
        {
            switch (opcion)
            {
                case 1:
                    Limpia();
                    UsuarioModelo usuarioLogueado = new Administrador();
                    usuarioLogueado = null;
                    Vistas.MenuAdministrador();
                    int opcion2 = FuncionesAuxiliares.SeleccionarOpcion(5);
                    Program.SeleccionarOpcionesAdministrador(opcion2, usuarios);
                    break;
                case 2:
                    Limpia();
                    ListarUsuarios();
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
                default:
                    Environment.Exit(0);
                    break;
            }
        }

        //PRODUCTOS
        public static void ListarProductos()
        {
            List<ProductoWebServices> productoWebServices = ClsProducto.ListarProductos();

            Console.WriteLine($"\n\tHay en stock {productoWebServices.Count} productos \n");

            foreach (var producto in productoWebServices)
            {
                ImprimirProducto(producto);
            }

        }

        private static void ImprimirProducto(ProductoWebServices producto)
        {
            Console.WriteLine(new string('*', 60)); 
            Console.WriteLine($"ID: {producto.Id}");
            Console.WriteLine($"IdCategoria: {producto.IdCategoria}");
            Console.WriteLine($"Nombre: {producto.Nombre}");
            Console.WriteLine($"Nombre: {producto.FechaAlta}");
            Console.WriteLine($"Nombre: {producto.FechaBaja}");
            Console.WriteLine($"Precio: {producto.Precio:C}"); 
            Console.WriteLine($"Stock: {producto.Stock}");
            Console.WriteLine(new string('*', 60)); 
        }

        public static void Limpia()
        {
            Thread.Sleep(750);
            Console.Clear();
        }
    }
}
