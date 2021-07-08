using Logica.Facturacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBeta.Inventario
{
    public partial class frmCompra : Form
    {
        CompraLN op = new CompraLN();
        public frmCompra()
        {
            InitializeComponent();
        }

        private void frmCompra_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = op.MostrarCompraFitro("Finalizado");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }
    }
}
