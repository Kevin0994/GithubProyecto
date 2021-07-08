using Datos.Inventario.Datos;
using Entidades.Seguridad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Seguridad
{
    public class UsuarioCD
    {
        public static List<cp_ListarUsuariosVista_FiltroResult> ListarUsuarioVistaFiltro(string busqueda)
        {
            DataProyectDataContext DB = null;
            try
            {
                using (DB = new DataProyectDataContext())
                {
                    return DB.cp_ListarUsuariosVista_Filtro(busqueda).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al listar Usuarios.", ex);
            }
            finally
            {
                DB = null;
            }
        }

        public static List<cp_ListarUsuarios_FiltroResult> ListarUsuarioFiltro(string busqueda)
        {
            DataProyectDataContext DB = null;
            try
            {
                using (DB = new DataProyectDataContext())
                {
                    return DB.cp_ListarUsuarios_Filtro(busqueda).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al listar Usuarios.", ex);
            }
            finally
            {
                DB = null;
            }
        }



        public static List<Usuario> ListarUsuario()
        {
            DataProyectDataContext DB = null;
            try
            {
                using (DB = new DataProyectDataContext())
                {
                    return DB.Usuario.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al listar Usuarios.", ex);
            }
            finally
            {
                DB = null;
            }
        }
        public static void InsertarUsuario(Usuarios oc)
        {
            DataProyectDataContext DB = null;
            try
            {
                using (DB = new DataProyectDataContext())
                {
                    DB.cp_InsertarUsuarios(oc.Nombres, oc.Email, oc.Contraseña, oc.Fecha, oc.IdRol);
                    DB.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al insertar Usuarios.", ex);
            }
            finally
            {
                DB = null;
            }

        }
        public static void ActualizarUsuarios(Usuarios oc)
        {
            DataProyectDataContext DB = null;
            try
            {
                using (DB = new DataProyectDataContext())
                {
                    DB.cp_ActualizarUsuario(oc.Nombres, oc.Email, oc.Contraseña, oc.Fecha, oc.IdRol);
                    DB.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al actualizar Usuarios.", ex);
            }
            finally
            {
                DB = null;
            }
        }

        public static void EliminarUsuario(Usuarios oc)
        {
            DataProyectDataContext DB = null;
            try
            {
                using (DB = new DataProyectDataContext())
                {
                    DB.cp_EliminarUsuario (oc.IdUsuario);
                    DB.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al eliminar Usuarios.", ex);
            }
            finally
            {
                DB = null;
            }
        }
    }
}
