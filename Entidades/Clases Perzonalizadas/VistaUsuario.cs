using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clases_Perzonalizadas
{
    public class VistaUsuario
    {
        private string email;
        private string password;
        private string rol;
        private string operacion;
        private string modulo;

        public VistaUsuario()
        {

        }

        public VistaUsuario(string email, string password, string rol, string operacion, string modulo)
        {
            this.Email = email;
            this.Password = password;
            this.Rol = rol;
            this.Operacion = operacion;
            this.Modulo = modulo;
        }

        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public string Rol { get => rol; set => rol = value; }
        public string Operacion { get => operacion; set => operacion = value; }
        public string Modulo { get => modulo; set => modulo = value; }
    }
}
