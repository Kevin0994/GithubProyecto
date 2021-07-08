using Datos.Inventario.Datos;
using ProyectoBeta.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Inventario
{
    public class ProductoCD
    {
        public static List<cp_ListarProductosVista_FiltroResult> ListarProductoVistaFiltro(string busqueda)
        {
            DataProyectDataContext DB = null;
            try
            {
                using (DB = new DataProyectDataContext())
                {
                    return DB.cp_ListarProductosVista_Filtro(busqueda).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al listar Productos.", ex);
            }
            finally
            {
                DB = null;
            }
        }


        public static List<cp_ListarProductos_FiltroResult> ListarProductoFiltro(string busqueda)
        {
            DataProyectDataContext DB = null;
            try
            {
                using (DB = new DataProyectDataContext())
                {
                    return DB.cp_ListarProductos_Filtro(busqueda).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al listar Productos.", ex);
            }
            finally
            {
                DB = null;
            }
        }

        public static List<cp_BuscarProductoResult> BuscarProducto(int busqueda)
        {
            DataProyectDataContext DB = null;
            try
            {
                using (DB = new DataProyectDataContext())
                {
                    return DB.cp_BuscarProducto(busqueda).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al listar Productos.", ex);
            }
            finally
            {
                DB = null;
            }
        }

        public static void InsertarProducto(Producto oc)
        {
            DataProyectDataContext DB = null;
            try
            {
                using (DB = new DataProyectDataContext())
                {
                    DB.cp_InsertarProducto(oc.IdProductos, oc.IdCategoria, oc.Nombre, oc.PrecioProveedor, oc.StockActual, oc.StockMinimo, oc.PrecioVenta,oc.Detalle);

                    DB.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al insertar Producto.", ex);
            }
            finally
            {
                DB = null;
            }

        }
        public static void ActualizarProducto(Producto oc)
        {
            DataProyectDataContext DB = null;
            try
            {
                using (DB = new DataProyectDataContext())
                {
                    DB.cp_ActualizarProducto(oc.IdProductos, oc.IdCategoria, oc.Nombre, oc.PrecioProveedor, oc.StockActual, oc.StockMinimo, oc.PrecioVenta, oc.Detalle);
                    DB.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al actualizar Producto.", ex);
            }
            finally
            {
                DB = null;
            }
        }

        public static void ActualizarProductoStock(int IdP, int stock)
        {
            DataProyectDataContext DB = null;
            try
            {
                using (DB = new DataProyectDataContext())
                {
                    DB.cp_ActualizarProductoStock(IdP, stock);
                    DB.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al actualizar Producto.", ex);
            }
            finally
            {
                DB = null;
            }
        }

        public static void EliminarProducto(Producto oc)
        {
            DataProyectDataContext DB = null;
            try
            {
                using (DB = new DataProyectDataContext())
                {
                    DB.cp_EliminarProducto(oc.IdProductos);
                    DB.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al eliminar Producto.", ex);
            }
            finally
            {
                DB = null;
            }
        }
    }
}
