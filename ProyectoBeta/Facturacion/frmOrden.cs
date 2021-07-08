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

namespace ProyectoBeta.Facturacion
{
    public partial class frmOrden : Form
    {
        OrdenLN op = new OrdenLN();
        string Listar;
        public frmOrden(string operacion)
        {
            InitializeComponent();
            Listar = operacion;
        }

        private void CargarDatos()
        {
            dataGridView1.DataSource = op.MostrarOrdenFitro(Listar);
        }

        private void frmOrden_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void frmOrden_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            int pos = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            frmNCompra frm = new frmNCompra(pos);
            frm.ShowDialog();
            CargarDatos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
