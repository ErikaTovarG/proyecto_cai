using Modelo.ProductoModelo;
using Modelo.VentaModelo;
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
    public partial class FormReporteStockCritico : Form
    {
        public FormReporteStockCritico()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dtaGriewReporte.Rows.Clear();
            int stockInicial = 100;
            List<ProductoWebServices> lstProductos = ClsProducto.ListarProductos().Where(v => v.Stock < (stockInicial * 0.25)).ToList();
            foreach (var stock in lstProductos)
            {
                int n = dtaGriewReporte.Rows.Add();
                dtaGriewReporte.Rows[n].Cells[0].Value = stock.Id;
                dtaGriewReporte.Rows[n].Cells[1].Value = stock.Nombre;
                dtaGriewReporte.Rows[n].Cells[2].Value = stockInicial.ToString();
                dtaGriewReporte.Rows[n].Cells[3].Value = stock.Stock;
                dtaGriewReporte.Rows[n].Cells[4].Value = stockInicial - stock.Stock;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dtaGriewReporte.Rows.Clear();
        }

        private void CargarListaCategoria()
        {
            List<CategoriaProductos> categoriaProductos = ClsProducto.ListarCategorias();
            cmbCategoria.DataSource = null;
            cmbCategoria.DataSource = categoriaProductos;
            cmbCategoria.DisplayMember = "Nombre";
            cmbCategoria.ValueMember = "IdCategoria";
        }

        private void FormReporteStockCritico_Load(object sender, EventArgs e)
        {
            CargarListaCategoria();
        }

        private void btnBuscarPorCategoria_Click(object sender, EventArgs e)
        {
            dtaGriewReporte.Rows.Clear();
            int stockInicial = 100;
            List<ProductoWebServices> lstProductos = ClsProducto.ListarProductosPorCategoria(((cmbCategoria.SelectedIndex) + 1)).Where(v => v.Stock < (stockInicial * 0.25)).ToList();
            foreach (var stock in lstProductos)
            {
                int n = dtaGriewReporte.Rows.Add();
                dtaGriewReporte.Rows[n].Cells[0].Value = stock.Id;
                dtaGriewReporte.Rows[n].Cells[1].Value = stock.Nombre;
                dtaGriewReporte.Rows[n].Cells[2].Value = stockInicial.ToString();
                dtaGriewReporte.Rows[n].Cells[3].Value = stock.Stock;
                dtaGriewReporte.Rows[n].Cells[4].Value = stockInicial - stock.Stock;
            }
        }
    }
}
