using Modelo.Cliente_Modelo;
using Modelo.ProductoModelo;
using Modelo.VentaModelo;
using Negocio.ClienteNegocio;
using Negocio.ProductoNegocio;
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
    public partial class FormDevolucionVenta : Form
    {
        public FormDevolucionVenta()
        {
            InitializeComponent();
            CargarListaClientes();
        }

        private void CargarListaClientes()
        {
            List<ClienteWebServices> lstClientes = ClsCliente.ListarClientes();
            cmbClientes.DataSource = null;
            cmbClientes.DataSource = lstClientes;
            cmbClientes.DisplayMember = "ComboDisplay";
            cmbClientes.ValueMember = "Id";
        }

        private void btnBuscarVenta_Click(object sender, EventArgs e)
        {
            CargarVentas();
        }

        private void CargarVentas()
        {
            try
            {
                List<VentaWebService> listado = ClsVenta.ListarVentasPorCliente(Guid.Parse(cmbClientes.SelectedValue.ToString()));
                lstVentasPorCliente.DataSource = null;
                lstVentasPorCliente.DataSource = listado;
                lstVentasPorCliente.DisplayMember = "ComboDisplay";
                lstVentasPorCliente.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al traer la lista" + ex.Message);
            }
        }

        private void btnDevolucion_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstVentasPorCliente.SelectedItem != null)
                {
                    Guid idVenta = ((VentaWebService)lstVentasPorCliente.SelectedItem).Id;
                    ClsVenta.DevolucionVenta(idVenta.ToString());
                    lstVentasPorCliente.Items.Remove(lstVentasPorCliente.SelectedItem);
                    MessageBox.Show("Devolución realizada correctamente.");
                }
                else MessageBox.Show("Por favor, seleccione una venta para realizar la devolución.");
            }
            catch (Exception ex) { MessageBox.Show("Error al realizar la devolución: " + ex.Message); }
        }
    }
}
