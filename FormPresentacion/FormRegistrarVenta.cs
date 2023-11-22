using Modelo.Cliente;
using Modelo.Cliente_Modelo;
using Modelo.ProductoModelo;
using Modelo.Switch;
using Modelo.VentaModelo;
using Negocio.ClienteNegocio;
using Negocio.ProductoNegocio;
using Negocio.Venta;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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
            string idCliente = Guid.NewGuid().ToString();
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
            txbCant.Clear();
            cmbClientes.Items.Clear();
            txbMonUni.Clear();
            txbMonTot.Clear();
            txtMonPromocion.Clear();
        }

        private void FormRegistrarVenta_Load(object sender, EventArgs e)
        {
            CargarListaClientes();
            CargarListaCategoria();
            cmbCategoria.SelectedIndexChanged += CmbCategoria_SelectedIndexChanged;
            CargarStock();
            cmbProducto.SelectedIndexChanged += cmbProducto_SelectedIndexChanged;
            cmbCantidad.SelectedIndexChanged += cmbCantidad_SelectedIndexChanged;
        }
        private void CargarListaClientes()
        {
            List<ClienteWebServices> lstClientes = ClsCliente.ListarClientes();
            cmbClientes.DataSource = null;

            cmbClientes.DataSource = lstClientes;
            cmbClientes.DisplayMember = "ComboDisplay";
            cmbClientes.ValueMember = "Id";
        }



        private void CargarListaCategoria()
        {
            List<CategoriaProductos> categoriaProductos = ClsProducto.ListarCategorias();
            cmbCategoria.DataSource = null;
            cmbCategoria.DataSource = categoriaProductos;
            cmbCategoria.DisplayMember = "Nombre";
            cmbCategoria.ValueMember = "IdCategoria";
        }
        private void CargarListaProductos()
        {
            List<ProductoWebServices> lstProductos = ClsProducto.ListarProductosPorCategoria(Convert.ToInt32(cmbCategoria.SelectedValue));
            cmbProducto.DataSource = null;
            cmbProducto.DataSource = lstProductos;
            cmbProducto.DisplayMember = "ComboDisplay";
            cmbProducto.ValueMember = "Id";
        }
        private void CmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarListaProductos(); // Llama al método cuando cambia la categoría seleccionada
        }

        private void CargarStock()
        {
            int[] stock = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            cmbCantidad.DataSource = null;
            cmbCantidad.DataSource = stock;
        }

        private void cmbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProducto.SelectedIndex != -1)
            {
                ProductoWebServices productoSeleccionado = (ProductoWebServices)cmbProducto.SelectedItem;
                int precioUnitario = ClsProducto.PrecioUnitarioProducto(productoSeleccionado.Id);
                txbMonUni.Text = precioUnitario.ToString();
            }
        }

        private void cmbCantidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalcularTotal();
        }

        private void CalcularTotal()
        {
            if (!string.IsNullOrEmpty(txbMonUni.Text) && cmbCantidad.SelectedIndex != -1)
            {
                if (int.TryParse(txbMonUni.Text, out int precioUnitario))
                {
                    // Obtiene la cantidad seleccionada
                    int cantidad = (int)cmbCantidad.SelectedItem;
                    int total = precioUnitario * cantidad;
                    txbMonTot.Text = total.ToString();
                }
                else
                {
                    MessageBox.Show("El precio unitario no es un número válido.");
                }
            }
        }

        private void VerificarNombrePromocion()
        {
            if (txtNombrePromocion.Text.Length > 0)
            {

            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }
    }
}
