
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoBeta.Entidades;

namespace ProyectoBeta
{
    public partial class frmCRUDClientes : Form
    {
        int posEmp;
        public frmCRUDClientes(int pos)
        {
            InitializeComponent();
            posEmp = pos;
            if (posEmp < 0)
            {
               
                groupBox1.Text = "Agregar Producto";
            }
            else
            {
                EditClientes(posEmp);             
                groupBox1.Text = "Editar Producto";
            }
        }
        private void EditClientes(int pos)
        {
            
/*
            textBox1.Text = ob.Cedula;
            textBox2.Text = ob.Nombres;
            textBox3.Text = ob.Apellidos;
            textBox4.Text = ob.TipoConsumo;
            */
        }

        private void AgregarClientes()
        {

            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != ""
                && textBox4.Text != "")
            {
                try
                {
                    
                    

                }
                catch (Exception)
                {
                    MessageBox.Show("Datos ingresados no validos");
                }

            }
            else
            {
                MessageBox.Show("Por favor rellene todos los Campos");
            }
        }
       
        
        private void frmCRUDClientes_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgregarClientes();
            this.Close();
        }
    }
}
