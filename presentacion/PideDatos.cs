using Modelo.UsuarioModelo;
using Negocio.UsuarioLogNegocio;
using Modelo.Switch;
using System.Runtime.CompilerServices;
using Negocio.ProveedorNegocio;
using Modelo.ProductoModelo;
using Modelo.ProveedorModelo;

namespace Presentacion
{

    public static class PideDatos
    {
        public static UsuarioModelo PedirUsuario(int hostSeleccionado)
        {
            Guid id;
            string nombre, apellido, direccion, telefono, email, usuario, contrasenia;
            Inactivo inactivo = new Inactivo();
            DateTime fechaNacimiento, fechaAlta;
            int salidaHost, salidaDni, contador = 0;
            bool esValido;
            do
            {
                esValido = false;
                Console.Write("Nombre: ");
                nombre = Console.ReadLine();
                string campo = "Nombre";
                esValido = Validaciones.ValidaVacio(nombre, ref campo);
            } while (!esValido);
            do
            {
                esValido = false;
                Console.Write("Apellido: ");
                apellido = Console.ReadLine();
                string campo = "Apellido";
                esValido = Validaciones.ValidaVacio(apellido, ref campo);
            } while (!esValido);

            do
            {
                esValido = false;
                Console.Write("Dirección: ");
                direccion = Console.ReadLine();
                string campo = "Dirección";
                esValido = Validaciones.ValidaVacio(direccion, ref campo);
            } while (!esValido);

            do
            {
                esValido = false;
                Console.Write("Telefono: ");
                telefono = Console.ReadLine();
                string campo = "Telefono";
                esValido = Validaciones.ValidaVacio(telefono, ref campo);
            } while (!esValido);

            do
            {
                esValido = false;
                Console.Write("Email: ");
                email = Console.ReadLine();
                esValido = Validaciones.ValidaEmail(email);
            } while (!esValido);

            do
            {
                esValido = false;
                Console.Write("Contraseña: ");
                contrasenia = Console.ReadLine();
                string campo = "Contraseña";
                esValido = ClsUsuario.ValidarContrasenia(campo,  contrasenia) ;
            } while (!esValido);

            do
            {
                esValido = false;
                Console.Write("Usuario: ");
                usuario = Console.ReadLine();
                esValido = ClsUsuario.ValidarNombre(nombre, apellido, ref usuario);
            } while (!esValido);

            do
            {
                esValido = false;
                Console.Write("Fecha de Nacimiento: (en formato dd/mm/aaaa): ");
                string datoFecha = Console.ReadLine();
                DateTime salida = DateTime.Now;
                fechaNacimiento = salida;
                esValido = Validaciones.ValidaFechaNacimiento(datoFecha, ref salida);
            } while (!esValido);

            do
            {
                esValido = false;
                Console.Write("DNI:" );
                string datoIngresado = Console.ReadLine();
                salidaDni = 0;
                esValido = Validaciones.ValidaNumerico(datoIngresado, ref salidaDni);
            } while (!esValido);


            fechaAlta = DateTime.Now;
            id = Guid.NewGuid();
            
            UsuarioModelo usuarioaAgregar = null;

            switch (hostSeleccionado)
            {
                
                case 1:
                    usuarioaAgregar = new Administrador(id, nombre, apellido, direccion, telefono, email, contrasenia, usuario, fechaAlta, fechaNacimiento, null, hostSeleccionado, salidaDni, contador, inactivo);
                    break;
                case 2:
                    usuarioaAgregar = new Supervisor(id, nombre, apellido, direccion, telefono, email, contrasenia, usuario, fechaAlta, fechaNacimiento, null, hostSeleccionado, salidaDni, contador, inactivo);
                    break;
                case 3:
                    usuarioaAgregar = new Vendedor(id, nombre, apellido, direccion, telefono, email, contrasenia, usuario, fechaAlta, fechaNacimiento, null, hostSeleccionado, salidaDni, contador, inactivo);
                    break;
                default:
                    usuarioaAgregar = null;
                    break;
            }
            return usuarioaAgregar;
        }

        public static ProductoWebServicesPost IngresoDatosProducto()
        {
            ProductoWebServicesPost producto = new ProductoWebServicesPost();
            int idCategoriaSalida, cantidadSalida, salidaprecioProducto;
            string nombreProducto, precioProducto, idCategoria, nombreProductoSalida, cantidad, cuitIngresado, cuitSalida;
            bool esValido;
            do
            {
                esValido = false;
                Console.Write("\nCategoria del producto: ");
                idCategoria = Console.ReadLine();
                idCategoriaSalida = 0;
                esValido = Validaciones.ValidaNumerico(idCategoria, ref idCategoriaSalida);
            } while (!esValido);
            do
            {
                esValido = false;
                Console.Write("\nNombre del producto: ");
                nombreProducto = Console.ReadLine();
                nombreProductoSalida = "Nombre";
                esValido = Validaciones.ValidaVacio(nombreProducto, ref nombreProductoSalida);
            } while (!esValido);
            do
            {
                esValido = false;
                Console.Write("\nPrecio del producto: ");
                precioProducto = Console.ReadLine();
                salidaprecioProducto = 0;
                esValido = Validaciones.ValidaNumerico(precioProducto, ref salidaprecioProducto);
            } while (!esValido);
            do
            {
                esValido = false;
                Console.Write("\nCantidad del producto: ");
                cantidad = Console.ReadLine();
                cantidadSalida = 0;
                esValido = Validaciones.ValidaNumerico(cantidad, ref cantidadSalida);
            } while (!esValido);

            do
            {
                esValido = false;
                Console.Write("\nIngrese el cuit del proveedor: ");
                cuitIngresado = Console.ReadLine();
                cuitSalida = "Cuit";
                esValido = Validaciones.ValidaVacio(cuitIngresado, ref cuitSalida);
            } while(!esValido);

            ProveedorWebServices ProveedorEncontrado = ClsProveedor.BuscarProveedorPorCuit(cuitIngresado);
            Console.WriteLine(ProveedorEncontrado.Id);
            
            producto.IdCategoria = idCategoriaSalida;
            producto.IdProveedor = ProveedorEncontrado.Id;
            Guid idUsuario = Guid.Parse("D347CE99-DB8D-4542-AA97-FC9F3CCE6969");
            producto.IdUsuario = idUsuario;
            producto.Nombre = nombreProducto;
            producto.Precio = salidaprecioProducto;
            producto.Stock = cantidadSalida;

            //Guid idProveedor = Guid.Parse("984c5534-0b26-46f1-8b89-04496bff9957");
            //"1850fefa-e074-47f6-8a0e-7e212cb98ea3"

            return producto;
        }

        public static ProveedorWebServices IngresoDatosProveedor()
        {
            ProveedorWebServices proveedor = new ProveedorWebServices();
           
            string nombreProveedor, apellidoProveedor, emailProveedor, cuitProveedor, nombreProveedorSalida, apellidoProveedorSalida, emailProveedorSalida;
            int cuitProveedorSalida;
            DateTime fechaAlta, fechaBaja;
            bool esValido;

            do
            {
                esValido = false;
                Console.Write("\nNombre del proveedor: ");
                nombreProveedor = Console.ReadLine();
                nombreProveedorSalida = "Nombre";
                esValido = Validaciones.ValidaVacio(nombreProveedor, ref nombreProveedorSalida);
            } while (!esValido);

            do
            {
                esValido = false;
                Console.Write("\nApellido del proveedor: ");
                apellidoProveedor = Console.ReadLine();
                apellidoProveedorSalida = "Apellido";
                esValido = Validaciones.ValidaVacio(apellidoProveedor, ref apellidoProveedorSalida);
            } while (!esValido);

            do
            {
                esValido = false;
                Console.Write("\nemail del proveedor: ");
                emailProveedor = Console.ReadLine();
                emailProveedorSalida = "Email";
                esValido = Validaciones.ValidaVacio(emailProveedor, ref emailProveedorSalida);
            } while (!esValido);

            do
            {
                esValido = false;
                Console.Write("\nCUIT del proveedor: ");
                cuitProveedor = Console.ReadLine();
                cuitProveedorSalida = 0;
                esValido = Validaciones.ValidaNumerico(cuitProveedor, ref cuitProveedorSalida);
            } while (!esValido);

            

            Guid idUsuario = Guid.Parse("D347CE99-DB8D-4542-AA97-FC9F3CCE6969");
            proveedor.IdUsuario = idUsuario;
            proveedor.Nombre = nombreProveedor;
            proveedor.Apellido = apellidoProveedor;
            proveedor.Email = emailProveedor;
            proveedor.Cuit = cuitProveedorSalida.ToString();
            proveedor.FechaAlta = DateTime.Now;

            Console.WriteLine(proveedor.ToString());
            Console.WriteLine();

            return proveedor;
        }


        public static Login PidoDatosEnLogin(Login login)
        {
            string usuarioIngresado, contrasenaIngresada, campo = "Usuario", campo2 = "Contraseña";
            bool flag;
            Console.WriteLine("\n");
            Console.WriteLine((" ").PadRight(48, '=') + "   " + DateTime.Now + $"{0:D}" + "   " + (" ").PadRight(48, '='));
            Console.WriteLine("\n¡Bienvenidos a ElectroHogar S.A!\n");

            do
            {
                Console.Write("\n\t Ingrese su Usuario: ");
                usuarioIngresado = Console.ReadLine().Trim();
                Console.Write("\t Ingrese su Contraseña: ");
                contrasenaIngresada = Console.ReadLine().Trim();
                flag = Validaciones.ValidaVacio(usuarioIngresado, ref campo) && Validaciones.ValidaVacio(contrasenaIngresada, ref campo2);
            } while (!flag);

            login.NombreUsuario = usuarioIngresado;
            login.Contraseña = contrasenaIngresada;
            return login;
        }
    }
}



