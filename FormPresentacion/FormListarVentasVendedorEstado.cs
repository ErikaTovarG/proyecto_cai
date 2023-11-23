using Modelo.Cliente_Modelo;
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
    public partial class FormListarVentasVendedorEstado : Form
    {
        public FormListarVentasVendedorEstado()
        {
            InitializeComponent();
        }

        private void btnVentaEstado_Click(object sender, EventArgs e)
        {

            ventasEstado.Rows.Clear();

            string cliente = cmbClientes.SelectedValue.ToString();

            List<VentaWebService> ventasWebServices = ClsVenta.ListarVentasPorCliente(Guid.Parse(cliente));
            List<VentaWebService> ventasOrdenadas;

            if (cmbEstado.SelectedValue.ToString() == "Activo")
            {
                ventasOrdenadas = ventasWebServices.Where(v => v.Estado == 1).ToList();
            }
            else
            {
                ventasOrdenadas = ventasWebServices.Where(v => v.Estado == 0).ToList();
            }


            foreach (var venta in ventasOrdenadas)
            {
                int n = ventasEstado.Rows.Add();
                ventasEstado.Rows[n].Cells[0].Value = venta.Id;
                ventasEstado.Rows[n].Cells[1].Value = venta.Cantidad;
                ventasEstado.Rows[n].Cells[2].Value = venta.Estado;
                ventasEstado.Rows[n].Cells[3].Value = venta.FechaAlta;
            }

        }


        private void NombreEstado()
        {
            string[] nombreEstado = new string[] { "Activo", "Inactivo" };
            cmbEstado.DataSource = null;
            cmbEstado.DataSource = nombreEstado;
        }

        private void CargarListaClientes()
        {
            List<ClienteWebServices> lstClientes = ClsCliente.ListarClientes();
            cmbClientes.DataSource = null;
            cmbClientes.DataSource = lstClientes;
            cmbClientes.DisplayMember = "ComboDisplay";
            cmbClientes.ValueMember = "Id";
        }
        private void FormListarVentasVendedorEstado_Load(object sender, EventArgs e)
        {
            NombreEstado();
            CargarListaClientes();
        }
    }
}
