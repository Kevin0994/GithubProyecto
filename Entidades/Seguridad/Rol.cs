using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Seguridad
{
    public class Rol
    {
        private int idRol;
        private string nombre;
        private string detalle;

        public Rol()
        {

        }

        public Rol(int idRol, string nombre, string detalle)
        {
            this.IdRol = idRol;
            this.Nombre = nombre;
            this.Detalle = detalle;
        }

        public int IdRol { get => idRol; set => idRol = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Detalle { get => detalle; set => detalle = value; }
    }
}
