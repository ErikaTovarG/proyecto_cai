using Modelo.ProductoModelo;
using Negocio.ProductoNegocio;
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
    public partial class FormAlertaEditarProducto : Form
    {

        public FormAlertaEditarProducto()
        {
            InitializeComponent();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try //intenta ejecutar la función de Editar prodcuto
            {
            // atrapo las variables de los formularios
            FormProductos formProd = new FormProductos();
            FormEditarProducto formEdi = new FormEditarProducto();
            string id = "da4e0f22-7c9e-4801-af9d-3e938f4888d3";
            string idUsuario = formProd.txtIDproducto.Text;
            string nuevoPrecio = formEdi.txtNuevoPrecio.Text;
            string nuevoStock = formEdi.txtNuevoStock.Text;

            // instancio el objeto del producto a modificar
            ProductoWebServicePatch prodSwagger = new ProductoWebServicePatch();
            prodSwagger.Id = id;
            prodSwagger.IdUsuario = idUsuario;
            prodSwagger.Precio = nuevoPrecio;
            prodSwagger.Stock = nuevoStock;
    
            ClsProducto.EditarProducto(prodSwagger);
            MessageBox.Show("Se modificó el producto exitosamente.");
            this.Close();
            
          }
          catch (Exception ex) // Si ocurre una excepción, muestra un mensaje de advertencia con detalles del error
           {
           MessageBox.Show($"Hubo un problema al editar el producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
           }
           
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
