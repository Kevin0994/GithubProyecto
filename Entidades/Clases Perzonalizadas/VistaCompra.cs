using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clases_Perzonalizadas
{
    public class VistaCompra
    {
        private string producto;
        private string categoria;
        private string proveedor;
        private decimal precioProveedor;
        private short cantidadSolicitado;
        private short cantidadRecibida;
        private string estado;
        private DateTime fechaOrden;
        private DateTime fechaEntrada;
        private decimal precioCompra;

        public VistaCompra()
        {

        }

        public VistaCompra(string producto, string categoria, string proveedor, decimal precioProveedor, short cantidadSolicitado, short cantidadRecibida, string estado, DateTime fechaOrden, DateTime fechaEntrada, decimal precioCompra)
        {
            this.Producto = producto;
            this.Categoria = categoria;
            this.Proveedor = proveedor;
            this.PrecioProveedor = precioProveedor;
            this.CantidadSolicitado = cantidadSolicitado;
            this.CantidadRecibida = cantidadRecibida;
            this.Estado = estado;
            this.FechaOrden = fechaOrden;
            this.FechaEntrada = fechaEntrada;
            this.PrecioCompra = precioCompra;
        }

        public string Producto { get => producto; set => producto = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        public string Proveedor { get => proveedor; set => proveedor = value; }
        public decimal PrecioProveedor { get => precioProveedor; set => precioProveedor = value; }
        public short CantidadSolicitado { get => cantidadSolicitado; set => cantidadSolicitado = value; }
        public short CantidadRecibida { get => cantidadRecibida; set => cantidadRecibida = value; }
        public string Estado { get => estado; set => estado = value; }
        public DateTime FechaOrden { get => fechaOrden; set => fechaOrden = value; }
        public DateTime FechaEntrada { get => fechaEntrada; set => fechaEntrada = value; }
        public decimal PrecioCompra { get => precioCompra; set => precioCompra = value; }
    }
}
