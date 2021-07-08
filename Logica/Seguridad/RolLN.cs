using Datos;
using Datos.Inventario.Datos;
using Datos.Seguridad;
using Entidades.Clases_Perzonalizadas;
using Entidades.Seguridad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Seguridad
{
    public class RolLN
    {
        public List<Rol> MostrarRol()
        {
            List<Rol> Lista = new List<Rol>();
            Rol oc;
            try
            {
                List<Roles> auxLista = RolCD.ListarRol();
                foreach (Roles aux in auxLista)
                {

                    oc = new Rol(aux.IdRole,aux.Nombre,aux.Descripcion);
                    Lista.Add(oc);
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al listar Rol.", ex);
            }
            return Lista;
        }

        public bool CreateUsuario(Rol op)
        {
            try
            {
                RolCD.InsertarRol(op);
                return true;
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al Crear Rol.", ex);
            }
        }
        public bool UpdateRol(Rol op)
        {
            try
            {
                RolCD.ActualizarRol(op);
                return true;
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al actualizar Rol.", ex);
            }
        }

        public bool DeleteRol(Rol op)
        {
            try
            {
                RolCD.EliminarRol(op);
                return true;
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al eliminar Rol.", ex);
            }
        }

        public bool CreateRol_Op(Rol_Operacion op)
        {
            try
            {
                RolCD.InsertarRol_Op(op);
                return true;
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al Crear Rol Operacion.", ex);
            }
        }

        public bool DeleteRol_Op(Rol_Operacion op)
        {
            try
            {
                RolCD.EliminarRol_Op(op);
                return true;
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al eliminar Rol Operacion.", ex);
            }
        }

    }
}
