using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Inventario
{
    public class Producto_Orden
    {
        private int idProductos;
        private int idCategoria;
        private string nombre;
        private decimal precioProveedor;
        private int stockActual;
        private int stockMinimo;
        private decimal precioVenta;
        private string detalle;
        private decimal cantidad;

        public Producto_Orden()
        {

        }

        public Producto_Orden(int idProductos, int idCategoria, string nombre, decimal precioProveedor, int stockActual, int stockMinimo, decimal precioVenta, string detalle, decimal cantidad)
        {
            this.IdProductos = idProductos;
            this.IdCategoria = idCategoria;
            this.Nombre = nombre;
            this.PrecioProveedor = precioProveedor;
            this.StockActual = stockActual;
            this.StockMinimo = stockMinimo;
            this.PrecioVenta = precioVenta;
            this.Detalle = detalle;
            this.Cantidad = cantidad;
        }

        public int IdProductos { get => idProductos; set => idProductos = value; }
        public int IdCategoria { get => idCategoria; set => idCategoria = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public decimal PrecioProveedor { get => precioProveedor; set => precioProveedor = value; }
        public int StockActual { get => stockActual; set => stockActual = value; }
        public int StockMinimo { get => stockMinimo; set => stockMinimo = value; }
        public decimal PrecioVenta { get => precioVenta; set => precioVenta = value; }
        public string Detalle { get => detalle; set => detalle = value; }
        public decimal Cantidad { get => cantidad; set => cantidad = value; }
    }
}
