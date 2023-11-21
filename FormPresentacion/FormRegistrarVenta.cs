using Modelo.Cliente;
using Modelo.Switch;
using Modelo.VentaModelo;
using Negocio.ClienteNegocio;
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
            txtNomPromocion.Clear();
            txtMonPromocion.Clear();
            txtTotalDatos.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
        }
        private void FormRegistrarVenta_Load(object sender, EventArgs e)
        {
            //    Cliente Cliente1 = new Cliente(Guid.NewGuid(), Guid.NewGuid(), "Andrea", "Rivera", "Palermo", "1166995544", "andre@gmail.com", Convert.ToDateTime("15/11/2023"), Convert.ToDateTime("24/10/1997"), Convert.ToDateTime(null), "Grupo A", 1111111, new Activo());
            //    Cliente Cliente2 = new Cliente(Guid.NewGuid(), Guid.NewGuid(), "Erika", "Tovar", "Belgrano", "2222222222", "eri@gmail.com", Convert.ToDateTime("18/11/2023"), Convert.ToDateTime("24/10/1997"), Convert.ToDateTime(null), "Grupo A", 2222222, new Activo());
            //    Cliente Cliente3 = new Cliente(Guid.NewGuid(), Guid.NewGuid(), "Nazareno", "Martedi", "Saladillo", "3333333333", "naza@gmail.com", Convert.ToDateTime("20/11/2023"), Convert.ToDateTime("24/10/1997"), Convert.ToDateTime(null), "Grupo A", 3333333, new Activo());
            //    Cliente Cliente4 = new Cliente(Guid.NewGuid(), Guid.NewGuid(), "Facundo", "Cairo", "Colegiales", "4444444444", "facu@gmail.com", Convert.ToDateTime("11/11/2023"), Convert.ToDateTime("24/10/1997"), Convert.ToDateTime(null), "Grupo A", 4444444, new Activo());
            cmbClientes.Items.Add("Andrea");
            cmbClientes.Items.Add("Erika");
            cmbClientes.Items.Add("Nazareno");
            cmbClientes.Items.Add("Facundo");
        }
    }
}
