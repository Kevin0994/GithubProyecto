using Datos;
using Datos.Inventario;
using Datos.Inventario.Datos;
using Entidades.Clases_Perzonalizadas;
using ProyectoBeta.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Inventario
{
    public class ProductoLN
    {
        public List<VistaProductos> MostrarProductosVistaFiltro(string busqueda)
        {
            List<VistaProductos> Lista = new List<VistaProductos>();
            VistaProductos op;
            try
            {
                List<cp_ListarProductosVista_FiltroResult> auxLista = ProductoCD.ListarProductoVistaFiltro(busqueda);
                foreach (cp_ListarProductosVista_FiltroResult aux in auxLista)
                {

                    op = new VistaProductos(aux.Nombre, aux.Categoria, aux.PrecioProveedor, aux.StockActual, aux.PrecioVenta, aux.FechaEntrada.GetValueOrDefault(), aux.Proveedor);
                    Lista.Add(op);
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al listar Producto.", ex);
            }
            return Lista;
        }
        public List<Producto> MostrarProductosFiltro(string busqueda)
        {
            List<Producto> Lista = new List<Producto>();
            Producto op;
            try
            {
                List<cp_ListarProductos_FiltroResult> auxLista = ProductoCD.ListarProductoFiltro(busqueda);
                foreach (cp_ListarProductos_FiltroResult aux in auxLista)
                {

                    op = new Producto(aux.IdProductos, aux.idCategoria, aux.Nombre, aux.PrecioProveedor.GetValueOrDefault(), aux.StockActual.GetValueOrDefault(), aux.StockMinimo, aux.PrecioVenta.GetValueOrDefault(), aux.Detalle);
                    Lista.Add(op);
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al listar Producto.", ex);
            }
            return Lista;
        }


        public Producto BuscarProducto(int busqueda)
        {
            Producto op=null;
            try
            {
                List<cp_BuscarProductoResult> auxLista = ProductoCD.BuscarProducto(busqueda);
                foreach (cp_BuscarProductoResult aux in auxLista)
                {

                    op = new Producto(aux.IdProductos, aux.idCategoria, aux.Nombre, aux.PrecioProveedor.GetValueOrDefault(), aux.StockActual.GetValueOrDefault(), aux.StockMinimo, aux.PrecioVenta.GetValueOrDefault(),aux.Detalle);
                    
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al listar Producto.", ex);
            }
            return op;
        }

        public bool CreateProducto(Producto op)
        {
            try
            {
                ProductoCD.InsertarProducto(op);
                return true;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al insertar Producto.", ex);
            }
        }
        public bool UpdateProducto(Producto op)
        {
            try
            {
                ProductoCD.ActualizarProducto(op);
                return true;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al actualizar Producto.", ex);
            }
        }

        public bool UpdateProductoStock(int IdP,int stock)
        {
            try
            {
                ProductoCD.ActualizarProductoStock(IdP,stock);
                return true;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al actualizar Producto.", ex);
            }
        }

        public bool DeleteProducto(Producto op)
        {
            try
            {
                ProductoCD.EliminarProducto(op);
                return true;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al eliminar Producto.", ex);
            }
        }
    }
}
