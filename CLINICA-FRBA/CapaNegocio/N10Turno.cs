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
    }
}
