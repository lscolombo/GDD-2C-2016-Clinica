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
        /*ESTA CLASE ES LA ENCARCARGADA DE CONECTAR CAPADATOS CON CAPANEGOCIOS*/
        /*ATRAVEZ DE UN METODO DE UNA CLASE */
        public static DataTable BuscarConsultasParaReg(int unaMatricula)
        {
            D12RegResultados Obj = new D12RegResultados();
            return Obj.BuscarConsultasParaReg(unaMatricula);
        }

        public static DataTable UpdateAConsulta(int unID, string enfermedades, string sintomas)
        {
            D12RegResultados Obj = new D12RegResultados();
            return Obj.UpdateConsulta(unID, enfermedades, sintomas);
        }
    }
}
