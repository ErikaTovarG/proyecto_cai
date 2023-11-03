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
    public partial class FormPrincipalSupervisor : Form
    {
        public FormPrincipalSupervisor()
        {
            InitializeComponent();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormProductos>();
        }

        private void panelTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario; //declaro un form 
            formulario = panelFormularios.Controls.OfType<MiForm>().FirstOrDefault(); //En controles de tipo envio mi formulario 
            //Busca en una coleccion el formulario 
            //Si el formulario no existe 
            if (formulario == null)
            {
                formulario = new MiForm(); //Instacio el nuevo formulario 
                formulario.TopLevel = false; // no es de nivel superior 
                panelFormularios.Controls.Add(formulario); //Agrego el formulario al panel de formularios 
                panelFormularios.Tag = formulario; //Especifico la propiedad tag 
                formulario.Show(); //muestro el formulario 
                //formulario.FormBorderStyle = FormBorderStyle.None; //Quito el borde a los formularios
                formulario.Dock = DockStyle.Fill; //acoplo al panel 
                formulario.BringToFront(); //para traer al frente el formulario cuando hacemos click 
            }
            else
            {
                //Si el formulario existe simplemente lo traigo al frente 
                formulario.BringToFront();
            }
        }
    }
}
