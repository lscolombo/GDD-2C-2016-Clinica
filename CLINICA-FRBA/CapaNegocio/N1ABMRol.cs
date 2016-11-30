using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class N1ABMRol
    {
        public N1ABMRol() { }

        //Metodo para crear un rol

        public int crearRol(String nombre)
        {
            D1ABMRol abm = new D1ABMRol();
            return abm.crearRol(nombre);
        }

        //Metodo para obtener las funcionalidades que aun no están agregadas al rol

        public DataTable getFuncionalidades(String nombreRol)
        {
            D1ABMRol abm = new D1ABMRol();
            return abm.getFuncionalidades(nombreRol);
        }

        //Metodo para agregar una funcionalidad a un rol

        public void agregarFuncionalidadARol(String nombreRol, String nombreFuncionalidad)
        {
            D1ABMRol abm = new D1ABMRol();
            abm.agregarFuncionalidadARol(nombreRol, nombreFuncionalidad);
        }

        //Metodo para eliminar una funcionalidad a un rol

        public void eliminarFuncionalidadARol(int idRol, String nombreFuncionalidad)
        {
            D1ABMRol abm = new D1ABMRol();
            abm.eliminarFuncionalidadARol(idRol, nombreFuncionalidad);
        }

        //Metodo para mostrar los roles del sistema

        public static DataTable mostrarRoles()
        {
            D1ABMRol abm = new D1ABMRol();
            return abm.mostrarRoles();
        }

        //Metodo para cambiar el nombre a un rol

        public static void cambiarNombreRol(int id, String nombre)
        {
            D1ABMRol abm = new D1ABMRol();
            abm.cambiarNombreRol(id, nombre);
        }

        //Metodo para mostrar las funcionalidades asignadas de un rol

        public DataTable getFuncionalidadesAsignadas(String nombreRol)
        {
            D1ABMRol abm = new D1ABMRol();
            return abm.getFuncionalidadesAsignadas(nombreRol);
        }

        //Metodo para habilitar un rol

        public void habilitarRol(int id)
        {
            D1ABMRol abm = new D1ABMRol();
            abm.habilitarRol(id);
        }

        //Metodo para deshabilitar un rol

        public void deshabilitarRol(int id)
        {
            D1ABMRol abm = new D1ABMRol();
            abm.deshabilitarRol(id);
        }

        //Metodo para mostrar los roles inhabilitados

        public static DataTable mostrarRolesHabilitados()
        {
            D1ABMRol abm = new D1ABMRol();
            return abm.mostrarRolesHabilitados();
        }

    }
}