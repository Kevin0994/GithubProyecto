using Datos.Inventario.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Inventario
{
    public class VehiculoCD
    {
        public static List<cp_ListarVehiculosVista_FiltroResult> ListarVehiculoFiltro(string busqueda)
        {
            DataProyectDataContext DB = null;
            try
            {
                using (DB = new DataProyectDataContext())
                {
                    return DB.cp_ListarVehiculosVista_Filtro(busqueda).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al listar Vehiculos.", ex);
            }
            finally
            {
                DB = null;
            }
        }
    }
}
