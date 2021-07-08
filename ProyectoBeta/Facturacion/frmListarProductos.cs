using Entidades.Cache_usuario;
using Entidades.Inventario;
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
    public partial class frmListarProductos : Form
    {

        
        int Dato=0;
        int pos=0;
        string Mensaje="";
        ProductoLN op = new ProductoLN();
        public frmListarProductos(int dato,string mensaje)
        {
            InitializeComponent();
            Dato = dato;
            Mensaje = mensaje;
            if (Mensaje.CompareTo("Actualizar Cantidad") == 0)
            {
                ActualizarDatos();
            }
            else
                Datos();
        }

        public void ActualizarDatos()

        {
            Producto_Orden ob = ListaProducto.GetProducto(Dato);
            List<Producto_Orden> Lista = new List<Producto_Orden>();
            Lista.Add(ob);
            numericUpDown1.Value = ob.Cantidad;
            dataGridView1.DataSource = Lista.ToList();
            Lista = null;
        }

        public void IngresarLista()
        {

        }

        public void Datos()
        {
            dataGridView1.DataSource = op.MostrarProductosFiltro("");
        }

        private void frmListarProductos_Load(object sender, EventArgs e)
        {
            
        }

        private void AbrirForm()
        {
      
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (numericUpDown1.Value!=0)
            {

                if (Mensaje.CompareTo("Actualizar Cantidad") == 0)
                {
                    Producto_Orden ob = ListaProducto.GetProducto(Dato);
                    ob.Cantidad = numericUpDown1.Value;
                    ListaProducto.Editar(ob, Dato);
                    AbrirForm();
                }
                else
                {

                    pos = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    Producto pr = op.BuscarProducto(pos);
                    if (ListaProducto.aux == null)
                    {
                        ListaProducto.aux = new List<Producto_Orden>();
                        Producto_Orden ob = new Producto_Orden(pr.IdProductos, pr.IdCategoria, pr.Nombre, pr.PrecioProveedor, pr.StockActual, pr.StockMinimo, pr.PrecioVenta, pr.Detalle, numericUpDown1.Value);
                        ListaProducto.aux.Add(ob);
                        AbrirForm();
                    }
                    else
                    {
                        if (ListaProducto.BuscarDatoBool(pr.IdProductos) != true)
                        {
                            Producto_Orden ob = new Producto_Orden(pr.IdProductos, pr.IdCategoria, pr.Nombre, pr.PrecioProveedor, pr.StockActual, pr.StockMinimo, pr.PrecioVenta, pr.Detalle, numericUpDown1.Value);
                            ListaProducto.aux.Add(ob);
                            AbrirForm();
                        }
                        else
                        {
                            MessageBox.Show("Ya escogio anteriormente este producto");
                        }
                    }
                
                }
            }
            else
            {
                MessageBox.Show("Por favor eliga la cantidad de productos a comprar");
            }
            
        }

        private void frmListarProductos_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
