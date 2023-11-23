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
    public partial class FormEditarProveedor : Form
    {
        public FormEditarProveedor()
        {
            InitializeComponent();
        }

        

        private void FormEditarProveedor_Load(object sender, EventArgs e)
        {
            AbrirFormulario<FormAlertaEditarProveedor>();
        }

        private void btnEditarProveedor_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void limpiarCampos()
        {
            
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
