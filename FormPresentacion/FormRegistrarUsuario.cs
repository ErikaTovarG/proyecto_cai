using Modelo.Cliente;
using Modelo.Producto;
using Modelo.UsuarioModelo;
using Modelo.VentaModelo;
using Negocio.UsuarioLogNegocio;
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
    public partial class FormRegistrarUsuario : Form
    {
        public FormRegistrarUsuario()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiarDetalle_Click(object sender, EventArgs e)
        {
            txtApellido.Clear();
            txtNombre.Clear();
            txtTelefono.Clear();
            txtContraseña.Clear();
            txtDireccion.Clear();
            txtDNI.Clear();
            txtEmail.Clear();
            txtFechaNacimiento.Clear();
            txtUsuario.Clear();
            cmbHost.Items.Clear();
        }

        private void FormRegistrarUsuario_Load(object sender, EventArgs e)
        {
            cmbHost.Items.Add("1");
            cmbHost.Items.Add("2");
            cmbHost.Items.Add("3");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Atrapo variables
            string idUsuario = Guid.NewGuid().ToString();
            string host = cmbHost.SelectedItem.ToString();
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string dni = txtDNI.Text;
            string direccion = txtDireccion.Text;
            string telefono = txtTelefono.Text;
            string email = txtEmail.Text;
            string fechaNacimiento = txtFechaNacimiento.Text;
            string nombreUsuario = txtUsuario.Text;
            string contrasenia = txtContraseña.Text;
            DateTime fechaSalida = DateTime.Now;
            //Valido los errores en lista
            string listaErrores = "";
            listaErrores += Validaciones.ValidaVacio(host, "Host");
            listaErrores += Validaciones.ValidaVacio(nombre, "Nombre");
            listaErrores += Validaciones.ValidaVacio(apellido, "Apellido");
            listaErrores += Validaciones.ValidaVacio(dni, "DNI");
            listaErrores += Validaciones.ValidaVacio(direccion, "Dirección");
            listaErrores += Validaciones.ValidaVacio(telefono, "Telefono");
            listaErrores += Validaciones.ValidaVacio(email, "Email");
            listaErrores += Validaciones.ValidaFechaNacimiento(fechaNacimiento, ref fechaSalida);
            listaErrores += Validaciones.ValidaVacio(nombreUsuario, "Usuario");
            listaErrores += Validaciones.ValidaVacio(contrasenia, "Contraseña");
            listaErrores += Validaciones.ValidarContrasenia("Constraseña", contrasenia);

            //Si no hay errores, creo el usuario en swagger y llamo al método con la ruta POST
            if (!string.IsNullOrEmpty(listaErrores))
            {
                MessageBox.Show("Error", listaErrores);
            }
            else
            {
                UsuarioWebServicePost usuSwagger = new UsuarioWebServicePost();
                usuSwagger.IdUsuario = idUsuario;
                usuSwagger.Host = Convert.ToInt32(host);
                usuSwagger.Nombre = nombre;
                usuSwagger.Apellido = apellido;
                usuSwagger.Dni = Convert.ToInt32(dni);
                usuSwagger.Direccion = direccion;
                usuSwagger.Telefono = telefono;
                usuSwagger.Email = email;
                usuSwagger.FechaNac = fechaNacimiento;
                usuSwagger.NombreUsuario = nombreUsuario;
                usuSwagger.Contrasenia = contrasenia;


                ClsUsuario.CrearUsuario(usuSwagger);
                MessageBox.Show("Se creó el usuario exitosamente.");
                limpiarCampos();

            }

        }
        private void limpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtDNI.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            txtFechaNacimiento.Clear();
            cmbHost.Items.Clear();
            txtUsuario.Clear();
            txtContraseña.Clear();
        }
    }
}