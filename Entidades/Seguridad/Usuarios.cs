using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Seguridad
{
    public class Usuarios
    {
        private int idUsuario;
        private string nombres;
        private string email;
        private string contraseña;
        private DateTime fecha;
        private int idRol;

        public Usuarios()
        {

        }

        public Usuarios(int idUsuario, string nombres, string email, string contraseña, DateTime fecha, int idRol)
        {
            this.IdUsuario = idUsuario;
            this.Nombres = nombres;
            this.Email = email;
            this.Contraseña = contraseña;
            this.Fecha = fecha;
            this.IdRol = idRol;
        }

        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Email { get => email; set => email = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public int IdRol { get => idRol; set => idRol = value; }
    }
}
