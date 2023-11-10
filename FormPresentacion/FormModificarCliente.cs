using Modelo.Cliente;
using Modelo.Cliente_Modelo;
using Modelo.ProveedorModelo;
using Negocio.ClienteNegocio;
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

                txtNombre.Text = cliente.Nombre.ToString();
                txtApellido.Text = cliente.Apellido.ToString();
                txtEmail.Text = cliente.Email.ToString();
                txtDni.Text = cliente.Dni.ToString();
                txtDireccion.Text = cliente.Direccion.ToString();
                txtTelefono.Text = cliente.Telefono.ToString();
                txtFechaNacimiento.Text = cliente.FechaNacimiento.ToString();


            }
        }

        private void btnLimpiarCmb_Click(object sender, EventArgs e)
        {

            txtNombre.Clear();
            txtApellido.Clear();
            txtEmail.Clear();
            txtDni.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtFechaNacimiento.Clear();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }
    }
}
