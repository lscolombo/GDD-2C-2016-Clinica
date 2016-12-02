using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class N10Turno
    {
        public static DataTable MostrarEspecialidades()
        {
            return new D10Turno().MostrarEspecialidades();
        }

        public static DataTable MostrarProfesionales(string especialidad)
        {
            return new D10Turno().MostrarProfesionales(especialidad);
        }

        public static DataTable TraerEspecialidad(string especialidad)
        {
            return new D10Turno().TraerEspecialidad(especialidad);
        }

        public static DataTable TraerMatricula(string usuario)
        {
            return new D10Turno().TraerMatricula(usuario);
        }
    }
}
