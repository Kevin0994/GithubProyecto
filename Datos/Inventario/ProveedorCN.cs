using Datos.Inventario.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Inventario
{
    public class ProveedorCN
    {
        public static List<cp_ListarProveedores_FiltroResult> ListarProveedoresFiltro(string busqueda)
        {
            DataProyectDataContext DB = null;
            try
            {
                using (DB = new DataProyectDataContext())
                {
                    return DB.cp_ListarProveedores_Filtro(busqueda).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al listar Proveedores.", ex);
            }
            finally
            {
                DB = null;
            }
        }
    }
}
