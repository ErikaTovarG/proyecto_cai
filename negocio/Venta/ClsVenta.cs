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

    }
}
