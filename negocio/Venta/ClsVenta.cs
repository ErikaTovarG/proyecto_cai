using AccesoDatos;
using Modelo.ProductoModelo;
using Modelo.VentaModelo;


namespace Negocio.Venta
{
    public static class ClsVenta
    {
        public static void CrearVenta(VentaWebServicePost venta)
        {
            VentaDatos.CrearVenta(venta);
        }
        public static List<VentaWebService> ListarVentasPorCliente(Guid idCliente)
        {
            return VentaDatos.ListarVentasPorCliente(idCliente);
        }
        public static void DevolucionVenta(string idVenta)
        {
            string usuarioAdministrador = "f2547a8f-d1ee-4508-a53e-846c466beafd";
            //string usuarioAdministrador = "D347CE99-DB8D-4542-AA97-FC9F3CCE6969";
            VentaDatos.DevolucionVenta(idVenta, usuarioAdministrador);
        }
    }
}
