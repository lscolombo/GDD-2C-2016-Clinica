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

        public int crearRol(String nombre)
        {
            D1ABMRol abm = new D1ABMRol();
            return abm.crearRol(nombre);
        }

        public DataTable getFuncionalidades(String nombreRol)
        {
            D1ABMRol abm = new D1ABMRol();
            return abm.getFuncionalidades(nombreRol);
        }

        public void agregarFuncionalidadARol(String nombreRol, String nombreFuncionalidad)
        {
            D1ABMRol abm = new D1ABMRol();
            abm.agregarFuncionalidadARol(nombreRol, nombreFuncionalidad);
        }
    }
}