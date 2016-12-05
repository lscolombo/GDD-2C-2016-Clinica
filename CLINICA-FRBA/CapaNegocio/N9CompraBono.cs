using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class N9CompraBono
    {
        public static DataTable ObtenerDatosPlan(int planId)
        {
            return new D9CompraBono().ObtenerDatosPlan(planId);
        }
    }
}
