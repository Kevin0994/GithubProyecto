using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.CacheProducto
{
    public class OrdenCantidad
    {
        private int idProducto;
        private decimal precio;
        private decimal previoV;
        private short cantidadR;

        public OrdenCantidad()
        {

        }

        public OrdenCantidad(int idProducto, decimal precio, decimal previoV, short cantidadR)
        {
            this.IdProducto = idProducto;
            this.Precio = precio;
            this.PrevioV = previoV;
            this.CantidadR = cantidadR;
        }

        public int IdProducto { get => idProducto; set => idProducto = value; }
        public decimal Precio { get => precio; set => precio = value; }
        public decimal PrevioV { get => previoV; set => previoV = value; }
        public short CantidadR { get => cantidadR; set => cantidadR = value; }
    }
}
