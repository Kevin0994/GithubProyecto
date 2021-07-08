using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clases_Perzonalizadas
{
    public class Rol_Operacion
    {
        private int idRol;
        private int idOperacion;
        private string detalle;
        
        public Rol_Operacion()
        {

        }

        public Rol_Operacion(int idRol, int idOperacion, string detalle)
        {
            this.IdRol = idRol;
            this.IdOperacion = idOperacion;
            this.Detalle = detalle;
        }

        public int IdRol { get => idRol; set => idRol = value; }
        public int IdOperacion { get => idOperacion; set => idOperacion = value; }
        public string Detalle { get => detalle; set => detalle = value; }
    }
}
