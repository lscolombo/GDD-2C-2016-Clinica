using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class N14Estadisticas
    {
        public N14Estadisticas()
        {
        }

        public DataTable ListadoEstadistico(int anio, int semestre, int mes, int tipoListado, int especialidad, int tipoCancelacion)
        {
            D14Estadisticas Obj = new D14Estadisticas();
            Obj.anio = anio;
            Obj.semestre = semestre;
            Obj.mes = mes;
            Obj.tipoListado = tipoListado;
            Obj.especialidad = especialidad;
            Obj.tipoCancelacion = tipoCancelacion;
            return Obj.ListadoEstadistico(Obj);
        }

        public DataTable MostrarEspecialidades()
        {
            D14Estadisticas Obj = new D14Estadisticas();
            return Obj.MostrarEspecialidades();
        }


    }
}
