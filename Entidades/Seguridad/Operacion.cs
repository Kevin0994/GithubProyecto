using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Seguridad
{
    public class Operacion
    {
        private int idOperacion;
        private string nombre;
        private int idModulo;

        public Operacion()
        {

        }

        public Operacion(int idOperacion, string nombre, int idModulo)
        {
            this.IdOperacion = idOperacion;
            this.Nombre = nombre;
            this.IdModulo = idModulo;
        }

        public int IdOperacion { get => idOperacion; set => idOperacion = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int IdModulo { get => idModulo; set => idModulo = value; }
    }
}
