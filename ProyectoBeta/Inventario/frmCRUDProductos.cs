
using ProyectoBeta.Entidades;
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
    public partial class frmCRUDProductos : Form
    {
        int posEmp;
        public frmCRUDProductos(int pos)
        {
            InitializeComponent();
            CargarComboBox();
            posEmp = pos;
            if (posEmp < 0)
            {
                groupBox1.Text = "Agregar Producto";
            }
            else
            {
                EditarProducto();
                groupBox1.Text = "Editar Producto";
            }
        }

        private void CargarComboBox()
        {
            
            
        }

        private void EditarProducto()
        {
            /*
            Productos ob = Tlista_Productos.getProducto(posEmp);
            textBox1.Text = ob.Id;
            textBox2.Text = ob.Nombre;
            textBox3.Text = ob.Precio.ToString();
            textBox4.Text = ob.Cantidad.ToString();
    */
        }



        private void button1_Click(object sender, EventArgs e)
        {
            Producto ob = new Producto();

            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && 
                textBox4.Text != "" && comboBox1.SelectedIndex >= 0)
            {
                
                try
                {
                   
                }
                catch (Exception)
                {
                    MessageBox.Show("Por favor rellene los campos correctamente");
                }
               
            }
            else
            {
                MessageBox.Show("Por favor rellene todos los campos");
            }
           
            
        }
    }
}
