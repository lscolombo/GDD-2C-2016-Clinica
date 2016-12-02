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

        public DataTable TurnosPedidos(int afilID, DateTime fechaApp)
        {
            D13CancAtencion Obj = new D13CancAtencion();
            Obj.afilID = afilID;
            Obj.fechaApp = fechaApp;
            return Obj.TurnosPedidos(Obj);
        }

        public string CancelarTurnoAf(int codTurno, string detalle, DateTime fechaApp)
        {
            D13CancAtencion Obj = new D13CancAtencion();
            Obj.codTurno = codTurno;
            Obj.detalle = detalle;
            Obj.fechaApp = fechaApp;
            return Obj.CancelarTurnoAf(Obj);
        }

        public DataTable TurnosPendientesEntreFechas(int profesionalID, DateTime fechaInicio, DateTime fechaFin)
        {
            D13CancAtencion Obj = new D13CancAtencion();
            Obj.profesionalID = profesionalID;
            Obj.fechaInicio = fechaInicio;
            Obj.fechaFin = fechaFin;
            return Obj.TurnosPendientesEntreFechas(Obj);
        }

        public string CancelarTurnosProf(DateTime fechaInicio, DateTime fechaFin, string detalle, int profesionalID, DateTime fechaApp)
        {
            D13CancAtencion Obj = new D13CancAtencion();
            Obj.fechaInicio = fechaInicio;
            Obj.fechaFin = fechaFin;
            Obj.detalle = detalle;
            Obj.profesionalID = profesionalID;
            Obj.fechaApp = fechaApp;
            return Obj.CancelarTurnosProf(Obj);
        }



    }
}
