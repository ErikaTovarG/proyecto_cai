using Modelo.Cliente;
using Modelo.Cliente_Modelo;
using Modelo.ClienteModelo;
using Modelo.Producto;
using Modelo.ProveedorModelo;
using Modelo.VentaModelo;
using Negocio.ClienteNegocio;
using Negocio.ProveedorNegocio;
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
    public partial class FormModificarCliente : Form
    {
        public FormModificarCliente()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            List<ClienteWebServices> clienteWebServices = ClsCliente.ListarClientes();
            lstClientes.DataSource = clienteWebServices;
            lstClientes.DisplayMember = "ComboDisplay";
            lstClientes.ValueMember = "Id";
        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lstClientes.DataSource = null;
            lstClientes.Items.Clear();
        }

        private void btnVerDetalle_Click(object sender, EventArgs e)
        {
            if (lstClientes.SelectedItem != null)
            {
                ClienteWebServices cliente = (ClienteWebServices)lstClientes.SelectedItem;

                txtIDCliente.Text = cliente.Id.ToString();
                txtNombre.Text = cliente.Nombre.ToString();
                txtApellido.Text = cliente.Apellido.ToString();
                txtEmail.Text = cliente.Email.ToString();
                txtDni.Text = cliente.Dni.ToString();
                txtDireccion.Text = cliente.Direccion.ToString();
                txtTelefono.Text = cliente.Telefono.ToString();
                txtFechaNacimiento.Text = cliente.FechaNacimiento.ToString();
                txtHost.Text = cliente.Host.ToString();


            }
        }

        private void btnLimpiarCmb_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void Limpiar()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtEmail.Clear();
            txtDni.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtFechaNacimiento.Clear();
            txtIDCliente.Clear();
            txtHost.Clear();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            string direccion = txtDireccion.Text;
            string telefono = txtTelefono.Text;
            string email = txtEmail.Text;


            string errores = "";

            errores += Validaciones.ValidaVacio(direccion, "Direccion");
            errores += Validaciones.ValidaVacio(telefono, "Telefono");
            errores += Validaciones.ValidaVacio(email, "Email");

            if (!string.IsNullOrEmpty(errores))
            {
                MessageBox.Show("Error", errores);
            }
            else
            {
                ClienteWebServicePatch clienteModificar = new ClienteWebServicePatch();
                clienteModificar.Id = Guid.Parse(txtIDCliente.Text);
                clienteModificar.Direccion = txtDireccion.Text;
                clienteModificar.Email = txtEmail.Text;
                clienteModificar.Telefono = txtTelefono.Text;
                ClsCliente.ModificarCliente(clienteModificar);
                MessageBox.Show("Se ha creado la venta correctamente.");
                lstClientes.DataSource = null;
                lstClientes.Items.Clear();
                Limpiar();
            }

        }
    }
}
