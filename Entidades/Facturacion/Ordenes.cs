using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Facturacion
{
    public class Ordenes
    {
        private int idOrden;
        private int idUsuario;
        private DateTime fechaOrden;
        private DateTime fechaEntrada;
        private string estado;
        private decimal total;

        public Ordenes()
        {

        }

        public Ordenes(int idOrden, int idUsuario, DateTime fechaOrden, DateTime fechaEntrada, string estado, decimal total)
        {
            this.IdOrden = idOrden;
            this.IdUsuario = idUsuario;
            this.FechaOrden = fechaOrden;
            this.FechaEntrada = fechaEntrada;
            this.Estado = estado;
            this.Total = total;
        }

        public int IdOrden { get => idOrden; set => idOrden = value; }
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public DateTime FechaOrden { get => fechaOrden; set => fechaOrden = value; }
        public DateTime FechaEntrada { get => fechaEntrada; set => fechaEntrada = value; }
        public string Estado { get => estado; set => estado = value; }
        public decimal Total { get => total; set => total = value; }
    }
}
