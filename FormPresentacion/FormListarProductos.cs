using Modelo.ProductoModelo;
using Negocio.ProductoNegocio;
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
    public partial class FormListarProductos : Form
    {
        public FormListarProductos()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            List<ProductoWebServices> productoWebServices = ClsProducto.ListarProductos();

            foreach (var producto in productoWebServices)
            {
                lstProductos.Items.Add(producto.ToString());
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lstProductos.Items.Clear();
        }
    }
}
