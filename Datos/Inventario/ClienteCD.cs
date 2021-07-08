using Datos.Inventario.Datos;
using ProyectoBeta.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Inventario
{
    public class ClienteCD
    {
        public static List<cp_ListarClientesVista_FiltroResult> ListarClienteFiltro(string busqueda)
        {
            DataProyectDataContext DB = null;
            try
            {
                using (DB = new DataProyectDataContext())
                {
                    return DB.cp_ListarClientesVista_Filtro(busqueda).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al listar Clientes.", ex);
            }
            finally
            {
                DB = null;
            }
        }

        public static void InsertarCliente(Cliente oc)
        {
            DataProyectDataContext DB = null;
            try
            {
                using (DB = new DataProyectDataContext())
                {
                    DB.cp_InsertarClientes(oc.IdUsuario, oc.CedClientes, oc.Nombre, oc.Apellidos, oc.Direccion, oc.Ciudad,oc.Telefono,oc.Correo);
                    DB.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al insertar Cliente.", ex);
            }
            finally
            {
                DB = null;
            }

        }
        public static void ActualizarCliente(Cliente oc)
        {
            DataProyectDataContext DB = null;
            try
            {
                using (DB = new DataProyectDataContext())
                {
                    DB.cp_ActualizarClientes(oc.CedClientes, oc.Nombre, oc.Apellidos, oc.Direccion, oc.Ciudad, oc.Telefono, oc.Correo);
                    DB.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al actualizar Cliente.", ex);
            }
            finally
            {
                DB = null;
            }
        }

        public static void EliminarCliente(Cliente oc)
        {
            DataProyectDataContext DB = null;
            try
            {
                using (DB = new DataProyectDataContext())
                {
                    DB.cp_EliminarClientes(oc.CedClientes);
                    DB.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al eliminar Cliente.", ex);
            }
            finally
            {
                DB = null;
            }
        }
    }
}
