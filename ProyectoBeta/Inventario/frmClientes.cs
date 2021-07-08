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
    public partial class frmClientes : Form
    
    {
        ClienteLN op = new ClienteLN();
        int posEmp;
        public frmClientes()
        {
            InitializeComponent();
         
            
        }

        private void CargarDatos(string text)
        {
            dataGridView1.DataSource = op.MostrarClientesFitro(text);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void frmClientes_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = op.MostrarClientesFitro("");
        }
    
        

        private void button3_Click(object sender, EventArgs e)
        {           
          
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
        
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {


        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            CargarDatos(textBox6.Text);
        }
    }
}
