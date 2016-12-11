using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class N3Usuario
    {
        public static DataTable TraerDatosAfiliado(string usuario)
        {
            return new D3Usuario().TraerDatosAfiliado(usuario);
        }

        public static DataTable TraerNombreYApellidoAfiliado(int nroAfiliado)
        {
            return new D3Usuario().TraerNombreYApellidoAfiliado(nroAfiliado);
        }

        public static DataTable ObtenerPlanAfiliado(int nroAfiliado)
        {
            return new D3Usuario().ObtenerPlanAfiliado(nroAfiliado);
        }

        public static DataTable ProfesionalQueTambienEsAfiliado(int nroAfiliado)
        {
            return new D3Usuario().ProfesionalQueTambienEsAfiliado(nroAfiliado);
        }
    }
}
