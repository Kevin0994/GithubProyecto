using Datos.Inventario.Datos;
using Entidades.Facturacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Facturacion
{
    public class OrdenCD
    {
        public static List<cp_ListarPedidosVista_FiltroResult> ListarOrdenFiltro(string busqueda)
        {
            DataProyectDataContext DB = null;
            try
            {
                using (DB = new DataProyectDataContext())
                {
                    return DB.cp_ListarPedidosVista_Filtro(busqueda).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al listar Orden.", ex);
            }
            finally
            {
                DB = null;
            }
        }

        public static List<cp_BuscarProducto_OrdenResult> BuscarProductosOrden(int busqueda)
        {
            DataProyectDataContext DB = null;
            try
            {
                using (DB = new DataProyectDataContext())
                {
                    return DB.cp_BuscarProducto_Orden(busqueda).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al Listar Productos.", ex);
            }
            finally
            {
                DB = null;
            }
        }

        public static List<cp_BuscarCantidadSProducto_OrdenResult> CantidadProductosOrden(int idP,int idO)
        {
            DataProyectDataContext DB = null;
            try
            {
                using (DB = new DataProyectDataContext())
                {
                    return DB.cp_BuscarCantidadSProducto_Orden(idP,idO).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al Listar Productos.", ex);
            }
            finally
            {
                DB = null;
            }
        }

        public static List<cp_CountProducto_OrdenResult> ContarProductosOrden(int busqueda)
        {
            DataProyectDataContext DB = null;
            try
            {
                using (DB = new DataProyectDataContext())
                {
                    return DB.cp_CountProducto_Orden(busqueda).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al Listar Productos.", ex);
            }
            finally
            {
                DB = null;
            }
        }

        public static void InsertarOrden(Ordenes oc)
        {
            DataProyectDataContext DB = null;
            try
            {
                using (DB = new DataProyectDataContext())
                {
                    DB.cp_InsertarOrden(oc.IdOrden, oc.IdUsuario, oc.FechaOrden, oc.FechaEntrada,oc.Estado,oc.Total);
                    DB.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al insertar Orden.", ex);
            }
            finally
            {
                DB = null;
            }

        }

        public static void InsertarOrden_Detalle(Orden_Detalles oc)
        {
            DataProyectDataContext DB = null;
            try
            {
                using (DB = new DataProyectDataContext())
                {
                    DB.cp_InsertarOrden_Detalle(oc.IdOrden, oc.IdProducto, oc.PrecioCompra, oc.CantS,oc.CantR);
                    DB.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al insertar Orden Detalle.", ex);
            }
            finally
            {
                DB = null;
            }

        }

        public static void ActualizarOrden(Ordenes oc)
        {
            DataProyectDataContext DB = null;
            try
            {
                using (DB = new DataProyectDataContext())
                {
                    DB.cp_ActualizarOrden(oc.IdOrden,oc.FechaOrden, oc.FechaEntrada,oc.Estado,oc.Total);
                    DB.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al actualizar Orden.", ex);
            }
            finally
            {
                DB = null;
            }
        }

        public static void ActualizarOrdenTotal(Ordenes oc)
        {
            DataProyectDataContext DB = null;
            try
            {
                using (DB = new DataProyectDataContext())
                {
                    DB.cp_ActualizarOrdenTotal(oc.IdOrden, oc.Estado, oc.Total);
                    DB.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al actualizar Orden.", ex);
            }
            finally
            {
                DB = null;
            }
        }


        public static void ActualizarOrden_Detalle(Orden_Detalles oc)
        {
            DataProyectDataContext DB = null;
            try
            {
                using (DB = new DataProyectDataContext())
                {
                    DB.cp_ActualizarOrden_Detalle(oc.IdOrden, oc.IdProducto, oc.PrecioCompra, oc.CantS, oc.CantR);
                    DB.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al actualizar Orden.", ex);
            }
            finally
            {
                DB = null;
            }
        }

        public static void ActualizarOrden_DetalleStock(Orden_Detalles oc)
        {
            DataProyectDataContext DB = null;
            try
            {
                using (DB = new DataProyectDataContext())
                {
                    DB.cp_ActualizarOrden_DetalleStock(oc.IdOrden,oc.IdProducto ,oc.CantR);
                    DB.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al actualizar Orden.", ex);
            }
            finally
            {
                DB = null;
            }
        }

        public static void EliminarOrden(Ordenes oc)
        {
            DataProyectDataContext DB = null;
            try
            {
                using (DB = new DataProyectDataContext())
                {
                    DB.cp_EliminarOrden(oc.IdOrden);
                    DB.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al eliminar Orden.", ex);
            }
            finally
            {
                DB = null;
            }
        }

        public static void EliminarOrden_Detalle(Orden_Detalles oc)
        {
            DataProyectDataContext DB = null;
            try
            {
                using (DB = new DataProyectDataContext())
                {
                    DB.cp_EliminarOrden_Detalle(oc.IdOrden);
                    DB.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al eliminar Orden.", ex);
            }
            finally
            {
                DB = null;
            }
        }
    }
}
