using Modelo.Cliente_Modelo;
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
    public partial class FormMaximaVentaCliente : Form
    {
        public FormMaximaVentaCliente()
        {
            InitializeComponent();
        }

        private void btnVentaMaxCliente_Click(object sender, EventArgs e)
        {
            string cliente = cmbClientes.SelectedValue.ToString();

            List<VentaWebService> ventasWebServices = ClsVenta.ListarVentasPorCliente(Guid.Parse(cliente));
            var ventasOrdenadas = ventasWebServices.OrderByDescending(v => v.Cantidad).FirstOrDefault();

            if (ventasOrdenadas != null)
            {

                int n = masVentasDetalle.Rows.Add();

                masVentasDetalle.Rows[n].Cells[0].Value = ventasOrdenadas.Id;
                masVentasDetalle.Rows[n].Cells[1].Value = ventasOrdenadas.Cantidad;
                masVentasDetalle.Rows[n].Cells[2].Value = ventasOrdenadas.Estado;
                masVentasDetalle.Rows[n].Cells[3].Value = ventasOrdenadas.FechaAlta;
            }
            else {
                MessageBox.Show("No se le realizo venta a ese Cliente");
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            masVentasDetalle.Rows.Clear();
        }

        private void FormMaximaVentaCliente_Load(object sender, EventArgs e)
        {
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

       
    }
}
