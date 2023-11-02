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
    }
}
