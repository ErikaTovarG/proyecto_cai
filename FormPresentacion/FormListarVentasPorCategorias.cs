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
            //var cantidadesMaximas = ventas
            //.GroupBy(v => v.IdProducto)
            //.Select(grupo => new
            //    {
            //     IdProducto = grupo.Key,
            //     CantidadMaxima = grupo.Max(v => v.Cantidad)
            //    })
            //    .ToList();

            //lstVentaProdCat.Items.Clear();

           
            //foreach (var item in cantidadesMaximas)
            //{
            //    lstVentaProdCat.Items.Add($"IdProducto: {item.IdProducto}, Cantidad Máxima: {item.CantidadMaxima}");
            //}
        }
    }
    
}
