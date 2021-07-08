using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Inventario
{
    public class Empleado
    {
        private int idEmpleado;
        private int idUsuario;
        private int usuario;
        private string cedEmpleado;
        private string nombres;
        private string apellidos;
        private string direccion;
        private string telefono;
        private string correo;
        private string tipo;

        public Empleado()
        {

        }

        public Empleado(int idEmpleado, int idUsuario, int usuario, string cedEmpleado, string nombres, string apellidos, string direccion, string telefono, string correo, string tipo)
        {
            this.IdEmpleado = idEmpleado;
            this.IdUsuario = idUsuario;
            this.Usuario = usuario;
            this.CedEmpleado = cedEmpleado;
            this.Nombres = nombres;
            this.Apellidos = apellidos;
            this.Direccion = direccion;
            this.Telefono = telefono;
            this.Correo = correo;
            this.Tipo = tipo;
        }

        public int IdEmpleado { get => idEmpleado; set => idEmpleado = value; }
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public int Usuario { get => usuario; set => usuario = value; }
        public string CedEmpleado { get => cedEmpleado; set => cedEmpleado = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Tipo { get => tipo; set => tipo = value; }
    }
}
