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
    public class ClienteLN
    {
        public List<VistaClientes> MostrarClientesFitro(string busqueda)
        {
            List<VistaClientes> Lista = new List<VistaClientes>();
            VistaClientes op;
            try
            {
                List<cp_ListarClientesVista_FiltroResult> auxLista = ClienteCD.ListarClienteFiltro(busqueda);
                foreach (cp_ListarClientesVista_FiltroResult aux in auxLista)
                {

                    op = new VistaClientes(aux.Rol, aux.CedCliente, aux.Nombres, aux.Apellidos, aux.Direccion, aux.Telefono,aux.Ciudad , aux.CorreoElectronico);
                    Lista.Add(op);
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al listar Clientes.", ex);
            }
            return Lista;
        }

        public bool CreateCliente(Cliente op)
        {
            try
            {
                ClienteCD.InsertarCliente(op);
                return true;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al insertar Proveedor.", ex);
            }
        }
        public bool UpdateCliente(Cliente op)
        {
            try
            {
                ClienteCD.ActualizarCliente(op);
                return true;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al actualizar Proveedor.", ex);
            }
        }

        public bool DeleteCliente(Cliente op)
        {
            try
            {
                ClienteCD.InsertarCliente(op);
                return true;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al eliminar Proveedor.", ex);
            }
        }
    }
}
