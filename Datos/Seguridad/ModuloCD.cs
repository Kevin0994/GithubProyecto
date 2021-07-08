using Datos.Inventario.Datos;
using Entidades.Seguridad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Seguridad
{
    public class ModuloCD
    {
        public static List<Modulo> ListarModulo()
        {
            DataProyectDataContext DB = null;
            try
            {
                using (DB = new DataProyectDataContext())
                {
                    return DB.Modulo.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al listar Modulo.", ex);
            }
            finally
            {
                DB = null;
            }
        }
        public static void InsertarModulo(Modulos oc)
        {
            DataProyectDataContext DB = null;
            try
            {
                using (DB = new DataProyectDataContext())
                {
                    DB.cp_InsertarModulo(oc.IdModulo, oc.Nombre, oc.Descripcion);
                    DB.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al insertar Modulo.", ex);
            }
            finally
            {
                DB = null;
            }

        }
        public static void ActualizarModulo(Modulos oc)
        {
            DataProyectDataContext DB = null;
            try
            {
                using (DB = new DataProyectDataContext())
                {
                    DB.cp_ActualizarModulo (oc.IdModulo, oc.Nombre, oc.Descripcion);
                    DB.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al actualizar Modulo.", ex);
            }
            finally
            {
                DB = null;
            }
        }

        public static void EliminarModulo(Modulos oc)
        {
            DataProyectDataContext DB = null;
            try
            {
                using (DB = new DataProyectDataContext())
                {
                    DB.cp_EliminarUsuario(oc.IdModulo);
                    DB.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al eliminar Modulo.", ex);
            }
            finally
            {
                DB = null;
            }
        }
    }
}
