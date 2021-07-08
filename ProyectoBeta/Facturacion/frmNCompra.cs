using Entidades.Cache_usuario;
using Entidades.Facturacion;
using Logica.Facturacion;
using Logica.Inventario;
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

namespace ProyectoBeta.Facturacion
{
    public partial class frmNCompra : Form
    {
        
        int Orden;
        OrdenLN op = new OrdenLN();
        ProductoLN po = new ProductoLN();
        public frmNCompra(int pos)
        {
            InitializeComponent();
            Orden = pos;
            Inicializar();
            CargarDatos();
        }

        private void CargarDatos()
        {
            dataGridView1.DataSource = op.MostrarBusquedaProductos(Orden);
        }

        private void Inicializar()
        {
            textBox1.Text = Orden.ToString();
            textBox1.Enabled = false;
            textBox2.Text = op.MostrarOrdenFitro(Orden.ToString())[0].Fechaorden.Date.ToString();
            textBox2.Enabled = false;
            textBox3.Text = op.CantidadProductos(Orden).ToString();
            textBox3.Enabled = false;
            textBox5.Enabled = false;
            button2.Enabled = false;
        }

        private void TerminarOrden()
        {
            for (int i=0;i<ListaProducto.orden.Count;i++)
            {
                Orden_Detalles ob = new Orden_Detalles();
                Producto re = new Producto();
                ob.IdOrden = Orden;
                ob.IdProducto = ListaProducto.orden[i].IdProducto;
                ob.CantR = ListaProducto.orden[i].CantidadR;
                op.UpdateOrden_DetalleStock(ob);
                re = po.BuscarProducto(ob.IdProducto);
                int stock = re.StockActual + ob.CantR;               
                po.UpdateProductoStock(ob.IdProducto, stock);
            }
            Ordenes or = new Ordenes();
            or.IdOrden = Orden;
            or.Estado = "Finalizado";
            or.Total = Decimal.Parse(textBox5.Text);
            op.UpdateOrdenTotal(or);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox5.Text.CompareTo("0")!=0)
            {
                TerminarOrden();
                MessageBox.Show("Orden finalizada exitosamente");
                this.Close();
            }
            else
            {
                MessageBox.Show("Por favor registre los productos recibidos de cada producto");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int pos = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            frmCantStock frm = new frmCantStock(pos, Orden);
            frm.ShowDialog();
        }

        private void frmNCompra_Load(object sender, EventArgs e)
        {
            try
            {
                if (ListaProducto.orden.Count == 0)
                {
                    ListaProducto.orden = null;
                }
            }
            catch (Exception)
            {

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ListaProducto.orden = null;
            this.Close();
        }

        private void frmNCompra_FormClosed(object sender, FormClosedEventArgs e)
        {
            ListaProducto.orden = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            textBox5.Text = ListaProducto.CalcularToral().ToString();
        }

       
    }
}
