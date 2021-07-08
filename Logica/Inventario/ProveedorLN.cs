using Datos;
using Datos.Inventario;
using Datos.Inventario.Datos;
using Entidades.Inventario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Inventario
{
    public class ProveedorLN
    {
        public List<Proveedores> MostrarProveedoresFitro(string busqueda)
        {
            List<Proveedores> Lista = new List<Proveedores>();
            Proveedores op;
            try
            {
                List<cp_ListarProveedores_FiltroResult> auxLista = ProveedorCN.ListarProveedoresFiltro(busqueda);
                foreach (cp_ListarProveedores_FiltroResult aux in auxLista)
                {

                    op = new Proveedores(aux.idProveedor, aux.CedProveedor, aux.Nombre, aux.Representante, aux.Direccion, aux.Ciudad, aux.Telefono);
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
