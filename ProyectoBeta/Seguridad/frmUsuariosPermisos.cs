using Logica.Seguridad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBeta.Seguridad
{
    public partial class frmUsuariosPermisos : Form
    {
        UsuarioLN op = new UsuarioLN();
        public frmUsuariosPermisos()
        {
            InitializeComponent();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = op.MostrarUsuariosVistaFitro("");
        }
    }
}
