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
            masVentasDetalle.DataSource = null;

            string errores = Validaciones.ValidaVacio(txtIdCliente.Text, "Cliente Buscado");

            if (errores == "")
            {
                string cliente = txtIdCliente.Text;

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
            else
            {
                MessageBox.Show("Cliente no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FormListarVentasPorCategorias_Load(object sender, EventArgs e)
        {

        }

        private void txtIdCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void masVentasDetalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }

}
