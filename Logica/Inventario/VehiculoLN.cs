using Datos;
using Datos.Inventario;
using Datos.Inventario.Datos;
using Entidades.Clases_Perzonalizadas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Inventario
{
    public class VehiculoLN
    {
        public List<VistaVehiculo> MostrarVehiculosFitro(string busqueda)
        {
            List<VistaVehiculo> Lista = new List<VistaVehiculo>();
            VistaVehiculo op;
            try
            {
                List<cp_ListarVehiculosVista_FiltroResult> auxLista = VehiculoCD.ListarVehiculoFiltro(busqueda);
                foreach (cp_ListarVehiculosVista_FiltroResult aux in auxLista)
                {

                    op = new VistaVehiculo(aux.Rol, aux.Fecha.GetValueOrDefault(), aux.CedCliente, aux.Nombres, aux.Marca,aux.Modelo,aux.Año.GetValueOrDefault(),aux.Color,aux.Especificacion);
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
