using Datos;
using Datos.Inventario.Datos;
using Datos.Seguridad;
using Entidades.Seguridad;
using System;
using System.Collections.Generic;

namespace Logica.Seguridad
{
    public class OperacionesLN
    {

        public List<Operacion> MostrarOperacion()
        {
            List<Operacion> Lista = new List<Operacion>();
            Operacion oc;
            try
            {
                List<OPERACIONES> auxLista = OperacionesCD.ListarOperacion();
                foreach (OPERACIONES aux in auxLista)
                {

                    oc = new Operacion(aux.idOperacione, aux.nombre, aux.idModulo);
                    Lista.Add(oc);
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al listar Operacion.", ex);
            }
            return Lista;
        }

        public bool CreateOperacion(Operacion op)
        {
            try
            {
                OperacionesCD.InsertarOperacion(op);
                return true;
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al Crear Operacion.", ex);
            }
        }
        public bool UpdateOperacion(Operacion op)
        {
            try
            {
                OperacionesCD.ActualizarOperacion(op);
                return true;
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al actualizar Operacion.", ex);
            }
        }

        public bool DeleteOperacion(Operacion op)
        {
            try
            {
                OperacionesCD.EliminarOperacion(op);
                return true;
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al eliminar Operacion.", ex);
            }
        }

    }
}
