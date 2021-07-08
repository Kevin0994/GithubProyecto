using Datos;
using Datos.Facturacion;
using Datos.Inventario.Datos;
using Entidades.Clases_Perzonalizadas;
using Entidades.Facturacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Facturacion
{
    public class CompraLN
    {
        public List<Ordenes> MostrarCompraFitro(string busqueda)
        {
            List<Ordenes> Lista = new List<Ordenes>();
            Ordenes op;
            try
            {
                List<cp_ListarVistaCompra_FiltroResult> auxLista = CompraCD.ListarCompraFiltro(busqueda);
                foreach (cp_ListarVistaCompra_FiltroResult aux in auxLista)
                {

                    op = new Ordenes(aux.IdOrden, aux.IdUsuario, aux.FechaOrden, aux.FechaEntrada.GetValueOrDefault(), aux.Estado, aux.Total.GetValueOrDefault());
                    Lista.Add(op);
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al listar Vehiculo.", ex);
            }
            return Lista;
        }
    }
}
