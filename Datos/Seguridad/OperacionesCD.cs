using Datos;
using Datos.Inventario.Datos;
using Entidades.Seguridad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class OperacionesCD
    {
        public static List<OPERACIONES> ListarOperacion()
        {
            DataProyectDataContext DB = null;
            try
            {
                using (DB = new DataProyectDataContext())
                {
                    return DB.OPERACIONES.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al listar Operacion.", ex);
            }
            finally
            {
                DB = null;
            }
        }
        public static void InsertarOperacion(Operacion oc)
        {
            DataProyectDataContext DB = null;
            try
            {
                using (DB = new DataProyectDataContext())
                {
                    DB.cp_InsertarOperacion(oc.IdOperacion, oc.Nombre, oc.IdModulo);
                    DB.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al insertar Operacion.", ex);
            }
            finally
            {
                DB = null;
            }

        }
        public static void ActualizarOperacion(Operacion oc)
        {
            DataProyectDataContext DB = null;
            try
            {
                using (DB = new DataProyectDataContext())
                {
                    DB.cp_ActualizarOperacion(oc.IdOperacion, oc.Nombre, oc.IdModulo);
                    DB.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al actualizar Operacion.", ex);
            }
            finally
            {
                DB = null;
            }
        }

        public static void EliminarOperacion(Operacion oc)
        {
            DataProyectDataContext DB = null;
            try
            {
                using (DB = new DataProyectDataContext())
                {
                    DB.cp_EliminarOperacion(oc.IdOperacion);
                    DB.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al eliminar Operacion.", ex);
            }
            finally
            {
                DB = null;
            }
        }
    }

