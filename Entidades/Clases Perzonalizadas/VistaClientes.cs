using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clases_Perzonalizadas
{
    public class VistaClientes
    {
        private string rol;
        private string cedCliente;
        private string nombres;
        private string apellidos;
        private string direccion;
        private string telefono;
        private string ciudad;
        private string correoElectronico;

        public VistaClientes()
        {

        }

        public VistaClientes(string rol, string cedCliente, string nombres, string apellidos, string direccion, string telefono, string ciudad, string correoElectronico)
        {
            this.Rol = rol;
            this.CedCliente = cedCliente;
            this.Nombres = nombres;
            this.Apellidos = apellidos;
            this.Direccion = direccion;
            this.Telefono = telefono;
            this.Ciudad = ciudad;
            this.CorreoElectronico = correoElectronico;
        }

        public string Rol { get => rol; set => rol = value; }
        public string CedCliente { get => cedCliente; set => cedCliente = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Ciudad { get => ciudad; set => ciudad = value; }
        public string CorreoElectronico { get => correoElectronico; set => correoElectronico = value; }
    }
}
