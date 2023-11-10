using Modelo.VentaModelo;
using Negocio.ClienteNegocio;
using Negocio.Venta;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormPresentacion
{
    public partial class FormRegistrarVenta : Form
    {
        public FormRegistrarVenta()
        {
            InitializeComponent();
        }

        private void lblTotalVendido_Click(object sender, EventArgs e)
        {

        }

        private void txbtotalPagar_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            string idProducto = txbIdProd.Text;
            string idCliente = tbxIDcliente.Text;
            string cantidad = txbCant.Text;
            string Usuario = "5482745b-d0c0-4401-9603-17d07d9014e7";
            string errores = "";

            errores += Validaciones.ValidaVacio(idProducto, "idProducto");
            errores += Validaciones.ValidaVacio(idCliente, "idCliente");
            errores += Validaciones.ValidaVacio(cantidad, "Cantidad");

            if (!string.IsNullOrEmpty(errores))
            {
                MessageBox.Show("Error", errores);
            }
            else
            {
                VentaWebServicePost venta = new VentaWebServicePost(); 
                venta.IdCliente = idCliente;
                venta.IdProducto = idProducto; 
                venta.IdUsuario = Usuario;
                venta.Cantidad = Convert.ToInt32(cantidad);

                ClsVenta.CrearVenta(venta);
                MessageBox.Show("Se ha creado la venta correctamente.");
                limpiarCampos();


            }

        }
        private void limpiarCampos()
        {
            txbIdProd.Clear();
            tbxIDcliente.Clear();
            txbCant.Clear();
        }
    }
}
