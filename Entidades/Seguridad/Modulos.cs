using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Seguridad
{
    public class Modulos
    {
        private int idModulo;
        private string nombre;
        private string descripcion;

        public Modulos()
        {

        }

        public Modulos(int idModulo, string nombre, string descripcion)
        {
            this.idModulo = idModulo;
            this.nombre = nombre;
            this.descripcion = descripcion;
        }

        public int IdModulo { get => idModulo; set => idModulo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}
