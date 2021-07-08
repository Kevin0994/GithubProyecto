using Datos.Seguridad;
using Entidades.Cache_usuario;
using Entidades.Facturacion;
using Entidades.Inventario;
using Logica.Facturacion;
using Logica.Seguridad;
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
    public partial class frmNOrden : Form
    {
        OrdenLN op = new OrdenLN();
        UsuarioLN us = new UsuarioLN();

        public frmNOrden()
        {

            InitializeComponent();
        }

        public bool InsertarOrden()
        {
            bool result = false;
            try
            {
                Ordenes ob = new Ordenes();
                ob.IdOrden = int.Parse(textBox1.Text);
                ob.IdUsuario = us.MostrarUsuariosFitro(LoginCache.ListaUsuario[0].Email.ToString())[0].IdUsuario;
                ob.FechaOrden = dateTimePicker1.Value.Date;
                ob.Estado = "Pendiente";
                op.CreateOrden(ob);
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al ingresar datos");
                return result;
            }


        }

        public bool InsertarOrdenDetalle()
        {
            bool result = false;
            try
            {
                for (int i = 0; i < ListaProducto.aux.Count; i++)
                {
                    Orden_Detalles ob = new Orden_Detalles();
                    ob.IdOrden = int.Parse(textBox1.Text);
                    ob.IdProducto = ListaProducto.aux[i].IdProductos;
                    ob.CantS = Convert.ToInt16(ListaProducto.aux[i].Cantidad);
                    ob.PrecioCompra = ListaProducto.aux[i].PrecioProveedor;
                    op.CreateOrden_Detalle(ob);
                }

                return true;
            }
            catch (Exception) {

                MessageBox.Show("Error al ingresar datos");
                return result;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && ListaProducto.aux.Count != 0)
            {
                if (InsertarOrden() && InsertarOrdenDetalle())
                {
                    MessageBox.Show("Orden ingresada correctamente");
                    Limpiar();
                }
            }
            else
                MessageBox.Show("Por favor rellene todos los campos");

        }


        public void CargarDatos()
        {
            Tabla.DataSource = null;
            Tabla.DataSource = ListaProducto.aux;

        }

        private void frmNOrden_Load(object sender, EventArgs e)
        {
            try
            {
                if (ListaProducto.aux.Count != 0)
                {
                    CargarDatos();

                }
            }
            catch (Exception)
            {

            }

        }

        private void btnProducto_Click(object sender, EventArgs e)
        {

            frmListarProductos frm = new frmListarProductos(-1, "Insertar");
            frm.ShowDialog();
            if (ListaProducto.aux.Count != 0)
            {
                CargarDatos();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int pos = Tabla.CurrentRow.Index;
            frmListarProductos frm = new frmListarProductos(pos, "Actualizar Cantidad");
            frm.ShowDialog();
            CargarDatos();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int pos = Tabla.CurrentRow.Index;
            ListaProducto.Eliminar(pos);
            CargarDatos();
        }

        public void Limpiar()
        {
         
            Tabla.DataSource = null;
            textBox1.Text = "";
            ListaProducto.aux = null;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            var mss = MessageBox.Show("Si cancela la orden se borrara los productos seleccionados\n ¿Desea continuar?", "Atencion", MessageBoxButtons.YesNo);
            if (mss == DialogResult.Yes)
            {
                Limpiar();
               
            }
        }
    }
}
