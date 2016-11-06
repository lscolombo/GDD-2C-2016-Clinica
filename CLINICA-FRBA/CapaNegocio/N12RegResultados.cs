using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class N12RegResultados
    {
        public static DataTable BuscarConsultasParaReg(int unaMatricula)
        {
            /*D11RegLlegada Obj = new D11RegLlegada();
            return Obj.BuscarPorApell(unApellido);*/

            D12RegResultados Obj = new D12RegResultados();
            return Obj.BuscarConsultasParaReg(unaMatricula);

        }
    }
}
