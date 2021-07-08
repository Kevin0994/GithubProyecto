using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clases_Perzonalizadas
{
    public class VistaProductos
    {
        private string nombre;
        private string aaNombre;
        private decimal precioProveedor;
        private int stockActual;
        private decimal precioVenta;
        private DateTime fechaEntrada;
        private string proveedor;

        public VistaProductos()
        {

        }

        public VistaProductos(string nombre, string aaNombre, decimal precioProveedor, int stockActual, decimal precioVenta, DateTime fechaEntrada, string proveedor)
        {
            this.Nombre = nombre;
            this.AaNombre = aaNombre;
            this.PrecioProveedor = precioProveedor;
            this.StockActual = stockActual;
            this.PrecioVenta = precioVenta;
            this.FechaEntrada = fechaEntrada;
            this.Proveedor = proveedor;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string AaNombre { get => aaNombre; set => aaNombre = value; }
        public decimal PrecioProveedor { get => precioProveedor; set => precioProveedor = value; }
        public int StockActual { get => stockActual; set => stockActual = value; }
        public decimal PrecioVenta { get => precioVenta; set => precioVenta = value; }
        public DateTime FechaEntrada { get => fechaEntrada; set => fechaEntrada = value; }
        public string Proveedor { get => proveedor; set => proveedor = value; }
    }
}
