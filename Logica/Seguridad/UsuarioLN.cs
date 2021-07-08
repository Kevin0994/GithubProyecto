using Datos;
using Datos.Inventario.Datos;
using Datos.Seguridad;
using Entidades.Clases_Perzonalizadas;
using Entidades.Seguridad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Seguridad
{
    public class UsuarioLN
    {
        public List<VistaUsuario> MostrarUsuariosVistaFitro(string busqueda)
        {
            List<VistaUsuario> Lista = new List<VistaUsuario>();
            VistaUsuario op;
            try
            {
                List<cp_ListarUsuariosVista_FiltroResult> auxLista = UsuarioCD.ListarUsuarioVistaFiltro(busqueda);
                foreach (cp_ListarUsuariosVista_FiltroResult aux in auxLista)
                {

                    op = new VistaUsuario(aux.Email, aux.Password, aux.Rol, aux.Operacion, aux.Modulo);
                    Lista.Add(op);
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al listar Usuario.", ex);
            }
            return Lista;
        }

        public List<Usuarios> MostrarUsuariosFitro(string busqueda)
        {
            List<Usuarios> Lista = new List<Usuarios>();
            Usuarios op;
            try
            {
                List<cp_ListarUsuarios_FiltroResult> auxLista = UsuarioCD.ListarUsuarioFiltro(busqueda);
                foreach (cp_ListarUsuarios_FiltroResult aux in auxLista)
                {

                    op = new Usuarios(aux.IdUsuario,aux.Nombres,aux.Email ,aux.Password, aux.fecha.GetValueOrDefault(), aux.idRol.GetValueOrDefault());
                    Lista.Add(op);
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al listar Usuario.", ex);
            }
            return Lista;
        }

        public List<Usuarios> MostrarUsuario()
        {
            List<Usuarios> Lista = new List<Usuarios>();
            Usuarios oc;
            try
            {
                List<Usuario> auxLista = UsuarioCD.ListarUsuario();
                foreach (Usuario aux in auxLista)
                {

                    oc = new Usuarios(aux.IdUsuario, aux.Nombres, aux.Email, aux.Password, aux.fecha.GetValueOrDefault(), aux.idRol.GetValueOrDefault());
                    Lista.Add(oc);
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al listar Usuarios.", ex);
            }
            return Lista;
        }

        public bool CreateUsuario(Usuarios op)
        {
            try
            {
                UsuarioCD.InsertarUsuario(op);
                return true;
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al Crear Usuarios.", ex);
            }
        }
        public bool UpdateUsuario(Usuarios op)
        {
            try
            {
                UsuarioCD.ActualizarUsuarios(op);
                return true;
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al actualizar Usuarios.", ex);
            }
        }

        public bool DeleteUsuario (Usuarios op)
        {
            try
            {
                UsuarioCD.EliminarUsuario(op);
                return true;
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al eliminar Usuarios.", ex);
            }
        }

    }
}
