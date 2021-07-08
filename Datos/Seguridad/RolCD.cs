using Datos.Inventario.Datos;
using Entidades.Clases_Perzonalizadas;
using Entidades.Seguridad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Seguridad
{
    public class RolCD
    {

        public static List<Roles> ListarRol()
        {
            DataProyectDataContext DB = null;
            try
            {
                using (DB = new DataProyectDataContext())
                {
                    return DB.Roles.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al listar Rol.", ex);
            }
            finally
            {
                DB = null;
            }
        }
        public static void InsertarRol(Rol oc)
        {
            DataProyectDataContext DB = null;
            try
            {
                using (DB = new DataProyectDataContext())
                {
                    DB.cp_InsertarRol(oc.IdRol, oc.Nombre, oc.Detalle);
                    DB.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al insertar Rol.", ex);
            }
            finally
            {
                DB = null;
            }

        }

        public static void ActualizarRol(Rol oc)
        {
            DataProyectDataContext DB = null;
            try
            {
                using (DB = new DataProyectDataContext())
                {
                    DB.cp_ActualizarRol(oc.IdRol, oc.Nombre, oc.Detalle);
                    DB.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al actualizar Rol.", ex);
            }
            finally
            {
                DB = null;
            }
        }

        public static void EliminarRol(Rol oc)
        {
            DataProyectDataContext DB = null;
            try
            {
                using (DB = new DataProyectDataContext())
                {
                    DB.cp_EliminarRol(oc.IdRol);
                    DB.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al eliminar Rol.", ex);
            }
            finally
            {
                DB = null;
            }
        }

        public static void InsertarRol_Op(Rol_Operacion oc)
        {
            DataProyectDataContext DB = null;
            try
            {
                using (DB = new DataProyectDataContext())
                {
                    DB.cp_ActualizarRoles_Operacion(oc.IdRol, oc.IdOperacion,oc.Detalle);
                    DB.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al insertar Rol Operacion.", ex);
            }
            finally
            {
                DB = null;
            }

        }

        public static void EliminarRol_Op(Rol_Operacion oc)
        {
            DataProyectDataContext DB = null;
            try
            {
                using (DB = new DataProyectDataContext())
                {
                    DB.cp_EliminarRoles_Operaciones(oc.IdRol);
                    DB.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al eliminar Rol Operacion.", ex);
            }
            finally
            {
                DB = null;
            }
        }
    }
}
