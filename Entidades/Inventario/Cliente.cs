using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBeta.Entidades
{
    public class Cliente
    {
        private int idUsuario;
        private int idClientes;
        private string cedClientes;
        private string nombre;
        private string apellidos;
        private string direccion;
        private string ciudad;
        private string telefono;
        private string correo;

        public Cliente()
        {

        }

        public Cliente(int idUsuario, int idClientes, string cedClientes, string nombre, string apellidos, string direccion, string ciudad, string telefono, string correo)
        {
            this.IdUsuario = idUsuario;
            this.IdClientes = idClientes;
            this.CedClientes = cedClientes;
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.Direccion = direccion;
            this.Ciudad = ciudad;
            this.Telefono = telefono;
            this.Correo = correo;
        }

        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public int IdClientes { get => idClientes; set => idClientes = value; }
        public string CedClientes { get => cedClientes; set => cedClientes = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Ciudad { get => ciudad; set => ciudad = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Correo { get => correo; set => correo = value; }
    }
}
