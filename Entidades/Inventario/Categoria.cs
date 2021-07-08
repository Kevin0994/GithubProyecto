using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBeta.Entidades
{
    public class Categoria
    {
        private string id;
        private string nombre;


        public Categoria()
        {

        }
        public Categoria(string id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }

        public string Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }
}
