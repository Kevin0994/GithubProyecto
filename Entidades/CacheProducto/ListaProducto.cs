using Entidades.CacheProducto;
using Entidades.Inventario;
using ProyectoBeta.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entidades.Cache_usuario
{
    public  class ListaProducto
    {
        public static List<Producto_Orden> aux = new List<Producto_Orden>();
        public static List<OrdenCantidad> orden = new List<OrdenCantidad>();

        public static void Editar(Producto_Orden oe, int pos)
        {
            aux[pos] = oe;
        }

        public static void EditarOrden(OrdenCantidad oe, int pos)
        {
            orden[pos] = oe;
        }

        public static Decimal CalcularToral()
        {
            Decimal pos = 0;
            for (int i = 0; i < orden.Count; i++)
            {
                pos += orden[i].CantidadR * orden[i].Precio;
            }
            return pos;
        }

        public static void Eliminar(int pos)
        {
            aux.Remove(aux.ElementAtOrDefault(pos));
        }

        public static bool BuscarDatoBool(int clave)
        {
            bool pos = false;
            for (int i = 0; i < aux.Count; i++)
            {
                if (aux[i].IdProductos.CompareTo(clave)==0)
                {
                    return pos=true;
                    
                }
            }
            return pos;
        }

        public static int BuscarDato(int clave)
        {
            int pos = -1;
            for (int i = 0; i < aux.Count; i++)
            {
                if (aux[i].IdProductos.Equals(clave))
                {
                    pos = i;
                    break;
                }
            }
            return pos;
        }

        public static int BuscarDatoOrden(int clave)
        {
            int pos = -1;
            for (int i = 0; i < orden.Count; i++)
            {
                if (orden[i].IdProducto.Equals(clave))
                {
                    pos = i;
                    return pos;
                }
            }
            return pos;
        }

        public static short BuscarSolicitud(int clave)
        {
            short pos = -1;
            
            for (int i = 0; i < orden.Count; i++)
            {
               
                if (orden[i].IdProducto.CompareTo(clave)==0)
                {
                   
                    pos = orden[i].CantidadR;
                    break;
                }
            }
            return pos;
        }

        public static Producto_Orden GetProducto(int pos)
        {
            return aux.ElementAtOrDefault(pos);
        }
    }
}
