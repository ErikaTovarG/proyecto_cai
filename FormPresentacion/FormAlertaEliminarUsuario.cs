using Modelo.UsuarioModelo;
using Negocio.UsuarioLogNegocio;
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
    public partial class FormAlertaEliminarUsuario : Form
    {
        //atrapo el dato del fomrulario aterior
        FormUsuarios formUsu = new FormUsuarios();
        public FormAlertaEliminarUsuario()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            string idUsuario = formUsu.txtIDUsuario.Text;
            string id = "da4e0f22-7c9e-4801-af9d-3e938f4888d3"; // usuario Admin
                UsuarioWebServiceDelete usuSwagger = new UsuarioWebServiceDelete();
                usuSwagger.Id = id;
                usuSwagger.IdUsuario = idUsuario;

                ClsUsuario.EliminarUsuario(usuSwagger);
                MessageBox.Show("Se eliminó el usuario exitosamente.");       
                this.Close();
        }

      

        public void AbrirFormulario<T>() where T : Form, new()
        {
            T form = new T();
            form.TopLevel = true;
            form.ShowDialog();
            form.Dock = DockStyle.Fill;
            form.BringToFront();
        }
    }
}
