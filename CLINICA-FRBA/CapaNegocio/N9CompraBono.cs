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

        public static string InsertarCompraBono(int nroAfiliado, int precioBono,
                                                    int cantidadBonos, int precioTotal)
        {
            return new D9CompraBono().InsertarCompraBono(nroAfiliado, precioBono,
                                                            cantidadBonos, precioTotal);
        }

        public static string InsertarBonoConsulta(int nroAfiliado, int planId)
        {
            return new D9CompraBono().InsertarBonoConsulta(nroAfiliado, planId);
        }

    }
}
