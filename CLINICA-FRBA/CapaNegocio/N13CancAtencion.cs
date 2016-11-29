using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class N13CancAtencion
    {

        public N13CancAtencion()
        {

        }

        public DataTable TurnosPedidos(int afilID)
        {
            D13CancAtencion Obj = new D13CancAtencion();
            Obj.afilID = afilID;
            return Obj.TurnosPedidos(Obj);
        }

        public string CancelarTurnoAf(int codTurno, string detalle)
        {
            D13CancAtencion Obj = new D13CancAtencion();
            Obj.codTurno = codTurno;
            Obj.detalle = detalle;
            return Obj.CancelarTurnoAf(Obj);
        }


    }
}
