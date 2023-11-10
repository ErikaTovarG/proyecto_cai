using Modelo.Cliente_Modelo;
using Modelo.ProductoModelo;
using Negocio.ClienteNegocio;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FormPresentacion
{
    public partial class FormRegistrarCliente : Form
    {
        public FormRegistrarCliente()
        {
            InitializeComponent();
            txtFechaNacimiento.Text = string.Format("yyyy-MM-dd");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string usuario = "D347CE99-DB8D-4542-AA97-FC9F3CCE6969";
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            int dni = Convert.ToInt32(txtDNI.Text);
            string direccion = txtDireccion.Text;
            string telefono = txtTelefono.Text;
            string email = txtEmail.Text;
            DateTime fechaNacimiento;
            DateTime.TryParseExact(txtFechaNacimiento.Text, "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out fechaNacimiento);
            string host = "1";
            //'cmbHost.SelectedItem.ToString();
            string errores = "";

            MessageBox.Show(fechaNacimiento.ToString());
           
            errores += Validaciones.ValidaVacio(nombre, "Nombre");
            errores += Validaciones.ValidaVacio(apellido, "Apellido");


            if (!string.IsNullOrEmpty(errores))
                MessageBox.Show(errores);
            else
            {
                ClienteWebServicesPost ClienteAgregar = new ClienteWebServicesPost();
                ClienteAgregar.IdUsuario = new Guid(usuario);
                ClienteAgregar.Nombre = nombre;
                ClienteAgregar.Apellido = apellido;
                ClienteAgregar.Direccion = direccion;
                ClienteAgregar.Telefono = telefono;
                ClienteAgregar.Email = email;
                ClienteAgregar.FechaNacimiento = fechaNacimiento;
                ClienteAgregar.Host = host;


                ClsCliente.CrearCliente(ClienteAgregar);

                LimpiarCampos();
            }
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtDNI.Clear(); 
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();   
            txtFechaNacimiento.Clear(); 
            //cmbHost.SelectedIndex = 0;
        }

    }
}
