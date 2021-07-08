using Datos.Inventario.Datos;
using Entidades.Inventario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Inventario
{
    public class EmpleadoCD
    {
        public static List<cp_ListarVistaEmpleados_FiltroResult> ListarEmpleadoFiltro(string busqueda)
        {
            DataProyectDataContext DB = null;
            try
            {
                using (DB = new DataProyectDataContext())
                {
                    return DB.cp_ListarVistaEmpleados_Filtro(busqueda).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al listar Empleado.", ex);
            }
            finally
            {
                DB = null;
            }
        }

        public static void InsertarEmpleado(Empleado oc)
        {
            DataProyectDataContext DB = null;
            try
            {
                using (DB = new DataProyectDataContext())
                {
                    DB.cp_InsertarEmpleados(oc.IdUsuario,oc.CedEmpleado, oc.Nombres, oc.Apellidos, oc.Direccion, oc.Telefono, oc.Correo, oc.Tipo);
                    DB.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al insertar Empleado.", ex);
            }
            finally
            {
                DB = null;
            }

        }
        public static void ActualizarEmpleado(Empleado oc)
        {
            DataProyectDataContext DB = null;
            try
            {
                using (DB = new DataProyectDataContext())
                {
                    DB.cp_ActualizarEmpleado(oc.CedEmpleado, oc.Nombres, oc.Apellidos, oc.Direccion, oc.Telefono, oc.Correo, oc.Tipo);
                    DB.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al actualizar Empleado.", ex);
            }
            finally
            {
                DB = null;
            }
        }

        public static void EliminarEmpleado(Empleado oc)
        {
            DataProyectDataContext DB = null;
            try
            {
                using (DB = new DataProyectDataContext())
                {
                    DB.cp_EliminarEmpleado(oc.CedEmpleado);
                    DB.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al eliminar Empleado.", ex);
            }
            finally
            {
                DB = null;
            }
        }
    }
}
