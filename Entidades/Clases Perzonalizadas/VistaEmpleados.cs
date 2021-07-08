using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clases_Perzonalizadas
{
    public class VistaEmpleados
    {
        private string rol;
        private string cedEmpleado;
        private string nombres;
        private string apellidos;
        private string direccion;
        private string telefono;
        private string correoElectronico;
        private string tipo;

        public VistaEmpleados()
        {

        }

        public VistaEmpleados(string rol, string cedEmpleado, string nombres, string apellidos, string direccion, string telefono, string correoElectronico, string tipo)
        {
            this.Rol = rol;
            this.CedEmpleado = cedEmpleado;
            this.Nombres = nombres;
            this.Apellidos = apellidos;
            this.Direccion = direccion;
            this.Telefono = telefono;
            this.CorreoElectronico = correoElectronico;
            this.Tipo = tipo;
        }

        public string Rol { get => rol; set => rol = value; }
        public string CedEmpleado { get => cedEmpleado; set => cedEmpleado = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string CorreoElectronico { get => correoElectronico; set => correoElectronico = value; }
        public string Tipo { get => tipo; set => tipo = value; }
    }
}
