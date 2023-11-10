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
    public partial class FormRegistrarVenta : Form
    {
        public FormRegistrarVenta()
        {
            InitializeComponent();
        }

        private void lblTotalVendido_Click(object sender, EventArgs e)
        {

        }

        private void txbtotalPagar_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormRegistrarCliente>();
        }
        private void AbrirFormulario<T>() where T : Form, new()
        {
            T form = new T();
            form.TopLevel = true;
            form.ShowDialog();
            form.Dock = DockStyle.Fill;
            form.BringToFront();
        }
    }
}
