using Modelo.Producto;
using Negocio.ProductoNegocio;
using Negocio.ProveedorNegocio;
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
    public partial class FormAlertaEliminarProveedor : Form
    {
        public string Cuit { get; set; }
        public FormAlertaEliminarProveedor()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Guid cuitProveedor = ClsProveedor.BuscarProveedorPorCuitYDevolverId(Cuit);
                string idProveedor = cuitProveedor.ToString();
                ClsProveedor.EliminarProveedor(idProveedor);
                MessageBox.Show("El proveedor se ha eliminado correctamente.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
