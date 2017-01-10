using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class N8RegAgenda
    {
        /*ESTA CLASE ES LA ENCARCARGADA DE CONECTAR CAPADATOS CON CAPANEGOCIOS*/
        /*ATRAVEZ DE UN METODO DE UNA CLASE */
        public static DataTable MostrarLasEspecialidades(int unaMatricula)
        {
            D8RegAgenda Obj = new D8RegAgenda();
            return Obj.MostrarEspecialidades(unaMatricula);
        }

        public static DataTable InsertarEnAgenda(int unaMatricula, DateTime fechaIni, DateTime fechaFin, Double cargaHoraria)
        {
            D8RegAgenda Obj = new D8RegAgenda();
            return Obj.InsertarAgenda(unaMatricula, fechaIni, fechaFin, cargaHoraria);
        }

        public static DataTable BuscarIdEnAgenda(int unaMatricula, string fechaIni, string fechaFin)
        {
            D8RegAgenda Obj = new D8RegAgenda();
            return Obj.BuscarIdAgenda(unaMatricula,fechaIni,fechaFin);
        }

        public static DataTable InsertarEnDisponibilidad(int unaAgenda, int unaMatricula, int unaEspecialidad, string unDia, string horaIni, string horaFin)
        {
            D8RegAgenda Obj = new D8RegAgenda();
            return Obj.InsertarDisponibilidad(unaAgenda, unaMatricula, unaEspecialidad, unDia, horaIni, horaFin);
        }

        public static DataTable BuscarLaMatricula(string unUserName)
        {
            D8RegAgenda Obj = new D8RegAgenda();
            return Obj.BuscarMatricula(unUserName);
        }

        public static DataTable RegistrarLosTurnos(int unIdAgenda)
        {
            D8RegAgenda Obj = new D8RegAgenda();
            return Obj.RegistrarTurnos(unIdAgenda);
        }

        public static DataTable VerificarElRangoFechas(int unaMatricula, string fechaIni, string fechaFin)
        {
            D8RegAgenda Obj = new D8RegAgenda();
            return Obj.VerificarRangoFechas(unaMatricula, fechaIni, fechaFin);
        }

        public static string GetFechaDeSistema()
        {
            D8RegAgenda Obj = new D8RegAgenda();
            return Obj.GetFechaSistema();
        }
    }
}
