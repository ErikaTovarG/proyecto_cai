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
using System.Globalization;
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
            //txtFechaNacimiento.Text = string.Format("yyyy-MM-dd");
            txtFechaNacimiento.TextChanged += txtFechaNacimiento_TextChanged;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                string usuario = "5482745b-d0c0-4401-9603-17d07d9014e7";
                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                string dni = txtDNI.Text;
                string direccion = txtDireccion.Text;
                string telefono = txtTelefono.Text;
                string email = txtEmail.Text;
                DateTime fechaNacimiento = Convert.ToDateTime(txtFechaNacimiento.Text);
                string host = txtHost.Text;
                int salida = 0;
                string errores = "";
                errores += Validaciones.ValidaVacio(nombre, "Nombre");
                errores += Validaciones.ValidaVacio(apellido, "Apellido");
                errores += Validaciones.ValidaVacio(direccion, "Direccion");
                errores += Validaciones.ValidaVacio(telefono, "Telefono");
                errores += Validaciones.ValidaVacio(email, "Email");
                errores += Validaciones.ValidaNumerico(dni, ref salida, "DNI");

                if (!string.IsNullOrEmpty(errores))
                    MessageBox.Show(errores);
                else
                {
                    ClienteWebServicesPost ClienteAgregar = new ClienteWebServicesPost();
                    ClienteAgregar.IdUsuario = usuario;
                    ClienteAgregar.Nombre = nombre;
                    ClienteAgregar.Apellido = apellido;
                    ClienteAgregar.Dni = Convert.ToInt32(salida);
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
            catch (Exception ex) { }
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
   
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFechaNacimiento_TextChanged(object sender, EventArgs e)
        {
          
            if (DateTime.TryParseExact(txtFechaNacimiento.Text, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime fecha))
            {
                txtFechaNacimiento.Text = fecha.ToString("yyyy-MM-dd");
            }
        }

    }
}
