using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clases_Perzonalizadas
{
    public class VistaOrden
    {
        private int idOrden;
        private string rol;
        private DateTime fechaorden;
        private string estado;
        private decimal total;

        public VistaOrden()
        {

        }

        public VistaOrden(int idOrden, string rol, DateTime fechaorden, string estado, decimal total)
        {
            this.IdOrden = idOrden;
            this.Rol = rol;
            this.Fechaorden = fechaorden;
            this.Estado = estado;
            this.Total = total;
        }

        public int IdOrden { get => idOrden; set => idOrden = value; }
        public string Rol { get => rol; set => rol = value; }
        public DateTime Fechaorden { get => fechaorden; set => fechaorden = value; }
        public string Estado { get => estado; set => estado = value; }
        public decimal Total { get => total; set => total = value; }
    }
}
