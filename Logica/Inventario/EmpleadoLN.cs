using Datos;
using Datos.Inventario;
using Datos.Inventario.Datos;
using Entidades.Clases_Perzonalizadas;
using Entidades.Inventario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Inventario
{
    public class EmpleadoLN
    {
        public List<VistaEmpleados> MostrarEmpleadosFitro(string busqueda)
        {
            List<VistaEmpleados> Lista = new List<VistaEmpleados>();
            VistaEmpleados op;
            try
            {
                List<cp_ListarVistaEmpleados_FiltroResult> auxLista = EmpleadoCD.ListarEmpleadoFiltro(busqueda);
                foreach (cp_ListarVistaEmpleados_FiltroResult aux in auxLista)
                {

                    op = new VistaEmpleados(aux.Rol, aux.CedEmpleado, aux.Nombres, aux.Apellidos, aux.Direccion, aux.Telefono, aux.CorreoElectronico, aux.Tipo);
                    Lista.Add(op);
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al listar Empleados.", ex);
            }
            return Lista;
        }
        public bool CreateEmpleado(Empleado op)
        {
            try
            {
                EmpleadoCD.InsertarEmpleado(op);
                return true;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al insertar Proveedor.", ex);
            }
        }
        public bool UpdateEmpleado(Empleado op)
        {
            try
            {
                EmpleadoCD.ActualizarEmpleado(op);
                return true;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al actualizar Proveedor.", ex);
            }
        }

        public bool DeleteEmpleado(Empleado op)
        {
            try
            {
                EmpleadoCD.EliminarEmpleado(op);
                return true;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al eliminar Proveedor.", ex);
            }
        }
    }
}
