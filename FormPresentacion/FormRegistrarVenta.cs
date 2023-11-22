using Modelo.Cliente_Modelo;
using Modelo.ProductoModelo;
using Modelo.VentaModelo;
using Negocio.ClienteNegocio;
using Negocio.ProductoNegocio;
using Negocio.Venta;


namespace FormPresentacion
{
    public partial class FormRegistrarVenta : Form
    {
        private int n = 0;
        public FormRegistrarVenta()
        {
            InitializeComponent();
        }


        private void limpiarCampos()
        {
            txbMonUni.Clear();
            txbMonTot.Clear();
            txtNombrePromocion.Clear();
            txtMonPromocion.Clear();
            cmbCategoria.SelectedIndex = 0;
            cmbProducto.SelectedIndex = 0;
            cmbCantidad.SelectedIndex = 0;

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
            if (lstProductos.Count > 0)
            {
                cmbProducto.DataSource = null;
                cmbProducto.DataSource = lstProductos;
                cmbProducto.DisplayMember = "ComboDisplay";
                cmbProducto.ValueMember = "Id";
            }
            else
            {
                cmbProducto.DataSource = null;
            }
        }
        private void CmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarListaProductos();

            if (cmbProducto.Items.Count == 0)
            {
                MessageBox.Show("No hay productos disponibles para la categoría seleccionada.");
            }
        }

        private void CargarStock()
        {
            int[] stock = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            cmbCantidad.DataSource = null;
            cmbCantidad.DataSource = stock;
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Adicionar un nuevo renglon 
            int n = dtaGriewDetalle.Rows.Add();
            //Se coloca la informacion 
            dtaGriewDetalle.Rows[n].Cells[0].Value = cmbProducto.SelectedValue.ToString();
            dtaGriewDetalle.Rows[n].Cells[1].Value = cmbProducto.SelectedItem.ToString();
            dtaGriewDetalle.Rows[n].Cells[2].Value = cmbCantidad.SelectedItem;
            dtaGriewDetalle.Rows[n].Cells[3].Value = txbMonUni.Text;
            dtaGriewDetalle.Rows[n].Cells[4].Value = txbMonTot.Text;

            limpiarCampos();
        }

        private void FormRegistrarVenta_Load(object sender, EventArgs e)
        {
            CargarListaClientes();
            CargarListaCategoria();
            cmbCategoria.SelectedIndexChanged += CmbCategoria_SelectedIndexChanged;
            CargarStock();
            cmbProducto.SelectedIndexChanged += cmbProducto_SelectedIndexChanged_1;
            cmbCantidad.SelectedIndexChanged += cmbCantidad_SelectedIndexChanged_1;
        }


        private void ac()
        {
            int pos = cmbProducto.SelectedIndex;
            if (cmbProducto.SelectedIndex != -1)
            {

            }
        }
        private void cmbProducto_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbProducto.SelectedIndex != -1)
            {
                try
                {
                    if (cmbProducto.SelectedItem is ProductoWebServices productoSeleccionado)
                    {
                        Guid productId = productoSeleccionado.Id;
                        int precioUnitario = ClsProducto.PrecioUnitarioProducto(productId);
                        txbMonUni.Text = precioUnitario.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Error al obtener el producto seleccionado.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al obtener el precio unitario: {ex.Message}");
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void cmbCantidad_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            CalcularTotal();
        }

        private void dtaGriewDetalle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex; //en donde se hizo el click 
            if (n != -1)
            {
                lblInfo.Text = dtaGriewDetalle.Rows[n].Cells[1].Value.ToString();
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (n != -1)
            {
                dtaGriewDetalle.Rows.RemoveAt(n);
            }
        }


        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            string idProducto = dtaGriewDetalle.Rows[n].Cells[0].Value.ToString();
            string idCliente = cmbClientes.SelectedValue.ToString();
            string cantidad = dtaGriewDetalle.Rows[n].Cells[2].Value.ToString();
            string Usuario = "5482745b-d0c0-4401-9603-17d07d9014e7";
            string errores = "";

            bool flag = ClsProducto.SinStock(Guid.Parse(idProducto));
            if (!flag) MessageBox.Show("El producto no cuenta con stock.");
            else
            {
                bool flag2 = ClsProducto.StockBajo(Guid.Parse(idProducto));
                if (flag) MessageBox.Show("El producto cuenta con un 25% de stock.\n\nAvise a su supervisor");
                bool hayStock = ClsProducto.ConsultaStock(Guid.Parse(idProducto), cantidad);
                if(hayStock)
                {
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
                        cmbClientes.SelectedIndex = 0;
                        dtaGriewDetalle.Rows.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("No hay stock sufiente para realizar esta venta.\n\nContactese con su supervisor.");
                }
            }
        }
    }
}
