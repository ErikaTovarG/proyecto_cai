using Modelo.Cliente;
using Modelo.VentaModelo;
using Presentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatos;
using Modelo.UsuarioModelo;
using Negocio.UsuarioLogNegocio;
using Negocio.Venta;
using Modelo.ProductoModelo;
using Negocio.ProductoNegocio;
using Modelo.Cliente_Modelo;
using Negocio.ClienteNegocio;

namespace FormPresentacion
{
    public partial class FormListarVentasPorCategorias : Form
    {
        public FormListarVentasPorCategorias()
        {
            InitializeComponent();
        }

        private void btnVentaProdCat_Click(object sender, EventArgs e)
        {

            masVentasDetalle.Rows.Clear();

            string cliente = cmbClientes.SelectedValue.ToString();

            List<VentaWebService> ventasWebServices = ClsVenta.ListarVentasPorCliente(Guid.Parse(cliente));
            var ventasOrdenadas = ventasWebServices.OrderByDescending(v => v.Cantidad).ToList();

            foreach (var venta in ventasOrdenadas)
            {
                int n = masVentasDetalle.Rows.Add();

                masVentasDetalle.Rows[n].Cells[0].Value = venta.Id;
                masVentasDetalle.Rows[n].Cells[1].Value = venta.Cantidad;
                masVentasDetalle.Rows[n].Cells[2].Value = venta.Estado;
                masVentasDetalle.Rows[n].Cells[3].Value = venta.FechaAlta;
            }

        }

        private void CargarListaClientes()
        {
            List<ClienteWebServices> lstClientes = ClsCliente.ListarClientes();
            cmbClientes.DataSource = null;
            cmbClientes.DataSource = lstClientes;
            cmbClientes.DisplayMember = "ComboDisplay";
            cmbClientes.ValueMember = "Id";
        }

        private void FormListarVentasPorCategorias_Load(object sender, EventArgs e)
        {
            CargarListaClientes();
        }


    }

}
