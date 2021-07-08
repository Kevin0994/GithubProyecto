using Datos;
using Datos.Inventario.Datos;
using Datos.Seguridad;
using Entidades.Seguridad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Seguridad
{
    public class ModuloLN
    {
        public List<Modulos> MostrarModulo()
        {
            List<Modulos> Lista = new List<Modulos>();
            Modulos oc;
            try
            {
                List<Modulo> auxLista = ModuloCD.ListarModulo();
                foreach (Modulo aux in auxLista)
                {

                    oc = new Modulos(aux.IdModulo,aux.Nombre,aux.Descripcion);
                    Lista.Add(oc);
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al listar Modulo.", ex);
            }
            return Lista;
        }

        public bool CreateModulo(Modulos op)
        {
            try
            {
                ModuloCD.InsertarModulo(op);
                return true;
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al Crear Modulo.", ex);
            }
        }
        public bool UpdateModulo(Modulos op)
        {
            try
            {
                ModuloCD.ActualizarModulo(op);
                return true;
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al actualizar Modulo.", ex);
            }
        }

        public bool DeleteModulo(Modulos op)
        {
            try
            {
                ModuloCD.EliminarModulo(op);
                return true;
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al eliminar Modulo.", ex);
            }
        }
    }
}
