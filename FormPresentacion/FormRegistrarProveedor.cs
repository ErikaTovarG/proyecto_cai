using AccesoDatos;
using Modelo.ProveedorModelo;
using Negocio.ProveedorNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormPresentacion
{
    public partial class FormRegistrarProveedor : Form
    {
        public FormRegistrarProveedor()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiarDetalle_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtCUIT.Clear();
            txtEmail.Clear();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ProveedorWebServicePost proveedor = new ProveedorWebServicePost();

            // Realiza la validación de los campos.
            if (ValidarCampos())
            {
                string nombreProveedor = txtNombre.Text;
                string apellidoProveedor = txtApellido.Text;
                string emailProveedor = txtEmail.Text;
                string cuitProveedor = txtCUIT.Text;

                txtNombre.Clear();
                txtApellido.Clear();
                txtCUIT.Clear();
                txtEmail.Clear();


                //Guid idUsuario = Guid.Parse("D347CE99-DB8D-4542-AA97-FC9F3CCE6969");
                string Usuario = "D347CE99-DB8D-4542-AA97-FC9F3CCE6969";
                proveedor.IdUsuario = Usuario;
                proveedor.Nombre = nombreProveedor;
                proveedor.Apellido = apellidoProveedor;
                proveedor.Email = emailProveedor;
                proveedor.Cuit = cuitProveedor;
                proveedor.FechaAlta = DateTime.Now;


                try
                {
                    // Intenta ejecutar el método para crear el proveedor
                    ClsProveedor.CrearProveedor(proveedor);

                    // Si no hay excepciones, muestra un mensaje de éxito
                    MessageBox.Show(proveedor.ToString(), "Proveedor agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    // Si ocurre una excepción, muestra un mensaje de advertencia con detalles del error
                    MessageBox.Show($"Hubo un problema al agregar el proveedor: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private bool ValidarCampos()
        {
            // Validación de campos textuales y no vacíos.
            if (!EsTextoNoVacio(txtNombre.Text))
            {
                MostrarError("El campo Nombre debe contener solo texto y no puede estar vacío.");
                return false;
            }

            if (!EsTextoNoVacio(txtApellido.Text))
            {
                MostrarError("El campo Apellido debe contener solo texto y no puede estar vacío.");
                return false;
            }

            if (!EsEmailValido(txtEmail.Text))
            {
                MostrarError("El campo Email debe tener un formato de dirección de correo electrónico válido y no puede estar vacío.");
                return false;
            }

            if (!EsNumericoNoVacio(txtCUIT.Text))
            {
                MostrarError("El campo CUIT debe contener solo números y no puede estar vacío.");
                return false;
            }

            // Todos los campos son válidos.
            return true;
        }


        // hacer referencia a estas validaciones en crear usuario 

        private bool EsTextoNoVacio(string input)
        {
            // Verifica si la cadena contiene solo letras y no está vacía.
            return !string.IsNullOrEmpty(input) && input.All(char.IsLetter);
        }

        private bool EsNumericoNoVacio(string input)
        {
            // Verifica si la cadena contiene solo números y no está vacía.
            return !string.IsNullOrEmpty(input) && input.All(char.IsDigit);
        }

        private bool EsEmailValido(string input)
        {
            // Utiliza regex para verificar si la cadena tiene un formato de correo electrónico válido.
            string patronEmail = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(input, patronEmail);
        }

        private void MostrarError(string mensaje)
        {
            // Muestra un MessageBox con el mensaje de error.
            MessageBox.Show(mensaje, "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
