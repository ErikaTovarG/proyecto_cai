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
    public partial class FormPrincipalVendedor : Form
    {
        public FormPrincipalVendedor()
        {
            InitializeComponent();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormVenta>();
        }

        private void btnReportesVentas_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormReporteVendedor>();
        }

        private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormRegistrarVenta>();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReporteVendedor_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormReporteVendedor>();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario<FormVentaCliente>();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            FormPrincipalVendedor formVendedor = new FormPrincipalVendedor();
            formVendedor.Show();
            this.Hide();
        }

        private void btnDevolucionVenta_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormDevolucionVenta>();
        }



        //Metodo para abrir el formulario dentro del panel.
        //<> esto indica que el metodo es generico () sin parametros y con restricciones 
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
                                   // formulario.FormBorderStyle = FormBorderStyle.None; //Quito el borde a los formularios
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
