

using Modelo.Producto;
using Modelo.ProductoModelo;
using Negocio.ProductoNegocio;

namespace FormPresentacion
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            MostrarAlertaDeStockBajo();
        }


        #region Funcionalidades del Formulario
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnListarProductos_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormProductos>();
        }

        private void btnListarProveedores_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormProveedores>();
        }

        private void btnListarUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormUsuarios>();
        }

        private void panelTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        #endregion

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
        private static void MostrarAlertaDeStockBajo()
        {
            List<ProductoWebServices> listaProductos = ClsProducto.ListarProductos();
            List<ProductoWebServices> listaProductos2;
            listaProductos2 = null;
            FormAlertaStock formOtro = new FormAlertaStock();

            foreach (var producto in listaProductos)
            {
                double stock = producto.Stock;
                double stockLimite = 0.25 * stock;
                if (stock < stockLimite)
                {
                    listaProductos2.Add(producto);
                }    
            }

            if(listaProductos2 != null)
            {
                foreach (var producto in listaProductos)
                {
                    formOtro.AgregarProductoALista(producto.ToString());
                }
                    formOtro.ShowDialog();
            }
        }

    }
}
