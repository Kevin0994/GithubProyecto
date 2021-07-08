using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clases_Perzonalizadas
{
    public class VistaVehiculo
    {
        private string rol;
        private DateTime fecha;
        private string cedCliente;
        private string nomCliente;
        private string marca;
        private string modelo;
        private short Año;
        private string color;
        private string especificaion;

        public VistaVehiculo()
        {

        }

        public VistaVehiculo(string rol, DateTime fecha, string cedCliente, string nomCliente, string marca, string modelo, short año, string color, string especificaion)
        {
            this.Rol = rol;
            this.Fecha = fecha;
            this.CedCliente = cedCliente;
            this.NomCliente = nomCliente;
            this.Marca = marca;
            this.Modelo = modelo;
            Año1 = año;
            this.Color = color;
            this.Especificaion = especificaion;
        }

        public string Rol { get => rol; set => rol = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string CedCliente { get => cedCliente; set => cedCliente = value; }
        public string NomCliente { get => nomCliente; set => nomCliente = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public short Año1 { get => Año; set => Año = value; }
        public string Color { get => color; set => color = value; }
        public string Especificaion { get => especificaion; set => especificaion = value; }
    }
}
