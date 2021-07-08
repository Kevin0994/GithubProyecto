using Entidades.Cache_usuario;
using Entidades.CacheProducto;
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
    public partial class frmCantStock : Form
    {
        int Pos;
        int Orden;
        string operacion = "";
        OrdenLN op = new OrdenLN();
        ProductoLN ob = new ProductoLN();
        public frmCantStock(int pos,int orden)
        {
            InitializeComponent();
            Pos = pos;
            Orden = orden;
            CargarDatos();
        }

        private void CargarDatos()
        {
            textBox1.Text = Pos.ToString();
            Producto po= ob.BuscarProducto(Pos);
            textBox2.Text = po.PrecioProveedor.ToString();
            textBox3.Text = po.PrecioVenta.ToString();
            

            if (ListaProducto.orden==null)
            {
                textBox4.Text = op.SolicitudProductos(Pos, Orden).ToString();
            }
            else
            {
                if (ListaProducto.BuscarSolicitud(Pos) != 0 && ListaProducto.BuscarSolicitud(Pos) !=-1)
                {                
                    textBox4.Text = ListaProducto.BuscarSolicitud(Pos).ToString();
                    operacion = "actualizar";
                }
                else
                {
                    textBox4.Text = "0";
                    operacion = "";
                }
               
            }
                               
        }

        private void InsertarCantidad()
        {
            if (ListaProducto.orden==null)
            {
                ListaProducto.orden = new List<OrdenCantidad>();
                GuardarLista();
            }
            else
            {
                GuardarLista();
            }        
        }

        private void GuardarLista()
        {
            OrdenCantidad ob = new OrdenCantidad();
            ob.IdProducto = Pos;
            ob.Precio = decimal.Parse(textBox2.Text);
            ob.PrevioV = decimal.Parse(textBox3.Text);
            ob.CantidadR = Convert.ToInt16(textBox4.Text);         
            if (operacion.CompareTo("actualizar")!=0)
            {
                ListaProducto.orden.Add(ob);
                this.Close();
            }
            else
            {
               
                ListaProducto.EditarOrden(ob, ListaProducto.BuscarDatoOrden(Pos));
                this.Close();
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            InsertarCantidad();
        }
    }
}
