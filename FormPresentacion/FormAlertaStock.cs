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
    public partial class FormAlertaStock : Form
    {
        public FormAlertaStock()
        {
            InitializeComponent();
        }

        public void AgregarProductoALista(string producto)
        {
            lstStockFaltante.Items.Add(producto);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
