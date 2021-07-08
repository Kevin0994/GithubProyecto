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

namespace ProyectoBeta.Inventario
{
    public partial class frmEmpleados : Form
    {
        EmpleadoLN op = new EmpleadoLN();
        public frmEmpleados()
        {
            InitializeComponent();
        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = op.MostrarEmpleadosFitro("");
        }

        private void CargarDatos(string text)
        {
            dataGridView1.DataSource = op.MostrarEmpleadosFitro(text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CargarDatos(textBox1.Text);
        }
    }
}
