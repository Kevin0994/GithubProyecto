using Entidades.Clases_Perzonalizadas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Cache_usuario
{
    public static class LoginCache
    {
        public static List<VistaUsuario> ListaUsuario = new List<VistaUsuario>();


        public static void insert(VistaUsuario op)
        {
            ListaUsuario.Add(op);

        }

        public static void Update(VistaUsuario op, int pos)
        {
            ListaUsuario[pos] = op;
        }

        public static void Delete_this(VistaUsuario op)
        {
            ListaUsuario = null;

        }

        public static bool BuscarRol(String rol)
        {
            bool pos = false;

            for (int i = 0; i < ListaUsuario.Count; i++)
            {

                if (ListaUsuario[i].Rol.CompareTo(rol)==0)
                {
                    pos = true;
                    i = ListaUsuario.Count;
                }
            }
            return pos;
        }

        public static bool BuscarOperacion(String op)
        {
            bool pos = false;

            for (int i = 0; i < ListaUsuario.Count; i++)
            {

                if (ListaUsuario[i].Operacion.CompareTo(op) == 0)
                {
                    pos = true;
                    i = ListaUsuario.Count;
                }
            }
            return pos;
        }

        public static bool BuscarModulo(String mo)
        {
            bool pos = false;

            for (int i = 0; i < ListaUsuario.Count; i++)
            {

                if (ListaUsuario[i].Modulo.CompareTo(mo) == 0)
                {
                    pos = true;
                    i = ListaUsuario.Count;
                }
            }
            return pos;
        }

    }
}
