using Logica.Inventario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBeta
{
    public partial class frmProductos : Form
    {
        ProductoLN op = new ProductoLN();
        public frmProductos()
        {
            InitializeComponent();
           
            
        }

        private void CargarDatos()
        {
            dataGridView1.DataSource = op.MostrarProductosVistaFiltro("");
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
           
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            int pos = dataGridView1.CurrentCell.RowIndex;
            frmCRUDProductos frm2 = new frmCRUDProductos(pos);
            frm2.ShowDialog();
            CargarDatos();
        }


        private void btnCategorias_Click(object sender, EventArgs e)
        {
            frmCRUDCategoria frm1 = new frmCRUDCategoria();
            frm1.ShowDialog();
            CargarDatos();
        }


    }
}
