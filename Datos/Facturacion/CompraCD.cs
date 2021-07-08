using Datos.Inventario.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Facturacion
{
    public class CompraCD
    {
        public static List<cp_ListarVistaCompra_FiltroResult> ListarCompraFiltro(string busqueda)
        {
            DataProyectDataContext DB = null;
            try
            {
                using (DB = new DataProyectDataContext())
                {
                    return DB.cp_ListarVistaCompra_Filtro(busqueda).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al listar Compra.", ex);
            }
            finally
            {
                DB = null;
            }
        }
    }
}
