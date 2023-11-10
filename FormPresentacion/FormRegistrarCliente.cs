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
            string usuario = "5482745b-d0c0-4401-9603-17d07d9014e7";
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            int dni = Convert.ToInt32(txtDNI.Text);
            string direccion = txtDireccion.Text;
            string telefono = txtTelefono.Text;
            string email = txtEmail.Text;
            DateTime fechaNacimiento = Convert.ToDateTime(txtFechaNacimiento.Text);
            //DateTime.TryParseExact(txtFechaNacimiento.Text, "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out fechaNacimiento);
            string host = txtHost.Text;
            //'cmbHost.SelectedItem.ToString();
            string errores = "";

            //MessageBox.Show(fechaNacimiento.ToString());

            errores += Validaciones.ValidaVacio(nombre, "Nombre");
            errores += Validaciones.ValidaVacio(apellido, "Apellido");
            errores += Validaciones.ValidaVacio(direccion, "Direccion");
            errores += Validaciones.ValidaVacio(telefono, "Telefono");
            errores += Validaciones.ValidaVacio(email, "Email");


            if (!string.IsNullOrEmpty(errores))
                MessageBox.Show(errores);
            else
            {
                ClienteWebServicesPost ClienteAgregar = new ClienteWebServicesPost();
                ClienteAgregar.IdUsuario = usuario;
                ClienteAgregar.Nombre = nombre;
                ClienteAgregar.Apellido = apellido;
                ClienteAgregar.Dni = dni;
                ClienteAgregar.Direccion = direccion;
                ClienteAgregar.Telefono = telefono;
                ClienteAgregar.Email = email;
                ClienteAgregar.FechaNacimiento = fechaNacimiento;
                ClienteAgregar.Host = host;


                ClsCliente.CrearCliente(ClienteAgregar);
                MessageBox.Show("Se creo el cliente exitosamente");
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
            txtHost.Clear();
            //cmbHost.SelectedIndex = 0;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
