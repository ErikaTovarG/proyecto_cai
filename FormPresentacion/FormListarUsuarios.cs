using Modelo.UsuarioModelo;
using Negocio.UsuarioLogNegocio;
using Presentacion;
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
    public partial class FormListarUsuarios : Form
    {
        public FormListarUsuarios()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            List<UsuarioWebServices> usuariosWebServices = ClsUsuario.ListarUsuarios(Guid.Parse("D347CE99-DB8D-4542-AA97-FC9F3CCE6969"));
            lstUsuarios.Items.Clear();

            foreach (var usuario in usuariosWebServices)
            {
                lstUsuarios.Items.Add(usuario.ToString());
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lstUsuarios.Items.Clear();
        }
    }
}
