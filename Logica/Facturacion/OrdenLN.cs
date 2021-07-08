using Datos;
using Datos.Facturacion;
using Datos.Inventario.Datos;
using Entidades.Clases_Perzonalizadas;
using Entidades.Facturacion;
using ProyectoBeta.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Facturacion
{
    public class OrdenLN
    {
        public List<VistaOrden> MostrarOrdenFitro(string busqueda)
        {
            List<VistaOrden> Lista = new List<VistaOrden>();
            VistaOrden op;
            try
            {
                List<cp_ListarPedidosVista_FiltroResult> auxLista = OrdenCD.ListarOrdenFiltro(busqueda);
                foreach (cp_ListarPedidosVista_FiltroResult aux in auxLista)
                {

                    op = new VistaOrden(aux.IdOrden, aux.Rol, aux.FechaOrden, aux.Estado,aux.Total.GetValueOrDefault());
                    Lista.Add(op);
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al listar Orden.", ex);
            }
            return Lista;
        }

        public List<Producto> MostrarBusquedaProductos (int busqueda)
        {
            List<Producto> Lista = new List<Producto>();
            Producto op;
            try
            {
                List<cp_BuscarProducto_OrdenResult> auxLista = OrdenCD.BuscarProductosOrden(busqueda);
                foreach (cp_BuscarProducto_OrdenResult aux in auxLista)
                {

                    op = new Producto(aux.IdProductos, aux.idCategoria, aux.Nombre, aux.PrecioProveedor.GetValueOrDefault(), aux.StockActual.GetValueOrDefault(), aux.StockMinimo, aux.PrecioVenta.GetValueOrDefault(), aux.Detalle);
                    Lista.Add(op);
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al listar Productos.", ex);
            }
            return Lista;
        }

        public int CantidadProductos(int busqueda)
        {
            List<int> Lista = new List<int>();
            try
            {
                List<cp_CountProducto_OrdenResult> auxLista = OrdenCD.ContarProductosOrden(busqueda);
                foreach (cp_CountProducto_OrdenResult aux in auxLista)
                {                    
                    Lista.Add(aux.Column1.GetValueOrDefault());
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al listar Productos.", ex);
            }
            return Lista[0];
        }

        public int SolicitudProductos(int IdP,int IdO)
        {
            List<int> Lista = new List<int>();
            try
            {
                List<cp_BuscarCantidadSProducto_OrdenResult> auxLista = OrdenCD.CantidadProductosOrden(IdP,IdO);
                foreach (cp_BuscarCantidadSProducto_OrdenResult aux in auxLista)
                {
                    Lista.Add(aux.CantidadRecibida.GetValueOrDefault());
                }

            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al listar Productos.", ex);
            }
            return Lista[0];
        }

        public bool CreateOrden(Ordenes op)
        {
            try
            {
                OrdenCD.InsertarOrden(op);
                return true;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al insertar Orden.", ex);
            }
        }

        public bool CreateOrden_Detalle(Orden_Detalles op)
        {
            try
            {
                OrdenCD.InsertarOrden_Detalle(op);
                return true;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al insertar Orden detalle.", ex);
            }
        }

        public bool UpdateOrden(Ordenes op)
        {
            try
            {
                OrdenCD.ActualizarOrden(op);
                return true;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al actualizar Orden.", ex);
            }
        }

        public bool UpdateOrdenTotal(Ordenes op)
        {
            try
            {
                OrdenCD.ActualizarOrdenTotal(op);
                return true;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al actualizar Orden.", ex);
            }
        }

        public bool UpdateOrden_Detalle(Orden_Detalles op)
        {
            try
            {
                OrdenCD.ActualizarOrden_Detalle(op);
                return true;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al actualizar Orden detalle.", ex);
            }
        }

        public bool UpdateOrden_DetalleStock(Orden_Detalles op)
        {
            try
            {
                OrdenCD.ActualizarOrden_DetalleStock(op);
                return true;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al actualizar Orden detalle.", ex);
            }
        }

        public bool DeleteOrden(Ordenes op)
        {
            try
            {
                OrdenCD.EliminarOrden(op);
                return true;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al eliminar Orden.", ex);
            }
        }

        public bool DeleteOrden_Detalle(Orden_Detalles op)
        {
            try
            {
                OrdenCD.EliminarOrden_Detalle(op);
                return true;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al eliminar Orden detalle.", ex);
            }
        }
    }
}
