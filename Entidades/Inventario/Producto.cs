using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBeta.Entidades
{
    public class Producto
    {
        private int idProductos;
        private int idCategoria;
        private string nombre;
        private decimal precioProveedor;
        private int stockActual;
        private int stockMinimo;
        private decimal precioVenta;
        private string detalle;

        public Producto()
        {

        }

        public Producto(int idProductos, int idCategoria, string nombre, decimal precioProveedor, int stockActual, int stockMinimo, decimal precioVenta, string detalle)
        {
            this.idProductos = idProductos;
            this.idCategoria = idCategoria;
            this.nombre = nombre;
            this.precioProveedor = precioProveedor;
            this.stockActual = stockActual;
            this.stockMinimo = stockMinimo;
            this.precioVenta = precioVenta;
            this.detalle = detalle;
        }

        public int IdProductos { get => idProductos; set => idProductos = value; }
        public int IdCategoria { get => idCategoria; set => idCategoria = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public decimal PrecioProveedor { get => precioProveedor; set => precioProveedor = value; }
        public int StockActual { get => stockActual; set => stockActual = value; }
        public int StockMinimo { get => stockMinimo; set => stockMinimo = value; }
        public decimal PrecioVenta { get => precioVenta; set => precioVenta = value; }
        public string Detalle { get => detalle; set => detalle = value; }
    }
}
