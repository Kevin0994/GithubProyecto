using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Facturacion
{
    public class Orden_Detalles
    {
        private int idOrden;
        private int idProducto;
        private decimal precioCompra;
        private short cantS;
        private short cantR;
   

        public Orden_Detalles()
        {


        }

        public Orden_Detalles(int idOrden, int idProducto, decimal precioCompra, short cantS, short cantR)
        {
            this.IdOrden = idOrden;
            this.IdProducto = idProducto;
            this.PrecioCompra = precioCompra;
            this.CantS = cantS;
            this.CantR = cantR;
         
        }

        public int IdOrden { get => idOrden; set => idOrden = value; }
        public int IdProducto { get => idProducto; set => idProducto = value; }
        public decimal PrecioCompra { get => precioCompra; set => precioCompra = value; }
        public short CantS { get => cantS; set => cantS = value; }
        public short CantR { get => cantR; set => cantR = value; }
    
    }
}
