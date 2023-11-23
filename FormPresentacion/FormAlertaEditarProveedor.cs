using Modelo.ProductoModelo;
using Modelo.ProveedorModelo;
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
    public partial class FormAlertaEditarProveedor : Form
    {
        public FormAlertaEditarProveedor()
        {
            InitializeComponent();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try //intenta ejecutar la función de Editar prodcuto
            {
                // atrapo las variables de los formularios
                FormProveedores formProv = new FormProveedores();
                FormEditarProveedor formEdiProv = new FormEditarProveedor();
                string id = "da4e0f22-7c9e-4801-af9d-3e938f4888d3";
                string idUsuario = formProv.txtIDProveedor.Text;
                string nuevoNombre = formEdiProv.txtNuevoNombre.Text;
                string nuevoApellido = formEdiProv.txtNuevoApellido.Text;
                string nuevoEmail = formEdiProv.txtNuevoEmail.Text;
                string nuevoCuit = formEdiProv.txtNuevoCuit.Text;

                // instancio el objeto del producto a modificar
                ProveedorWebservicePatch provSwagger = new ProveedorWebservicePatch();
                provSwagger.Id = id;
                provSwagger.IdUsuario = idUsuario;
                provSwagger.Nombre = nuevoNombre;
                provSwagger.Apellido = nuevoApellido;
                provSwagger.Email = nuevoEmail;
                provSwagger.Cuit = nuevoCuit;


                ClsProveedor.EditarProveedor(provSwagger);
                MessageBox.Show("Se modificó el proveedor exitosamente.");
                this.Close();

            }
            catch (Exception ex) // Si ocurre una excepción, muestra un mensaje de advertencia con detalles del error
            {
                MessageBox.Show($"Hubo un problema al editar el proveedor: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
