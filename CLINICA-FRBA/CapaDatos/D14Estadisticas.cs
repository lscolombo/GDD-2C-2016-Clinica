using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class D14Estadisticas
    {
        private int _anio;
        private int _semestre;
        private int _mes;
        private int _tipoListado;
        private int _especialidad;
        private int _tipoCancelacion;

        public int anio
        {
            get { return _anio; }
            set { _anio = value; }
        }

        public int semestre
        {
            get { return _semestre; }
            set { _semestre = value; }
        }

        public int mes
        {
            get { return _mes; }
            set { _mes = value; }
        }

        public int tipoListado
        {
            get { return _tipoListado; }
            set { _tipoListado = value; }
        }

        public int especialidad
        {
            get { return _especialidad; }
            set { _especialidad = value; }
        }

        public int tipoCancelacion
        {
            get { return _tipoCancelacion; }
            set { _tipoCancelacion = value; }
        }
        

     /*public Especialidades(string nombreEspecialidad, int codigoEspecialidad)
     {
           NombreEspecialidad = nombreEspecialidad;
           CodigoEspecialidad = codigoEspecialidad
     }
     public string NombreEspecialidad {get;set;}
     public int CodigoEspecialidad {get;set;}
}*/


        public D14Estadisticas()
        {

        }

        public D14Estadisticas(int anio, int semestre, int mes, int tipoListado, int especialidad, int tipoCancelacion)
        {
            this.anio = anio;
            this.semestre = semestre;
            this.mes = mes;
            this.tipoListado = tipoListado;
            this.especialidad = especialidad;
            this.tipoCancelacion = tipoCancelacion;
        }
        
        private object ValueOrDBNullIfZero(int val)
        {
            if (val == 1000)
                {
                return DBNull.Value;
                }
            else
            {
            return val;
            }
        }

        //Método mostrar todos los turnos disponibles pedidos por un afiliado
        public DataTable ListadoEstadistico(D14Estadisticas Estadisticas)
        {

            DataTable DtResultado = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCon.Open();
                SqlCmd.Connection = SqlCon;
                
                SqlCmd.CommandText = "WINCHESTER.p_ObtenerEstadisticas";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParAnio = new SqlParameter();

                ParAnio.ParameterName = "@Anio";
                ParAnio.SqlDbType = SqlDbType.Int;
                ParAnio.Value = anio;
                SqlCmd.Parameters.Add(ParAnio);

                SqlParameter ParSemestre = new SqlParameter();

                ParSemestre.ParameterName = "@Semestre";
                ParSemestre.SqlDbType = SqlDbType.Int;
                ParSemestre.Value = semestre;
                SqlCmd.Parameters.Add(ParSemestre);


                SqlParameter ParMes = new SqlParameter();

                ParMes.ParameterName = "@Mes";
                ParMes.SqlDbType = SqlDbType.Int;
                ParMes.Value = ValueOrDBNullIfZero(mes);
                SqlCmd.Parameters.Add(ParMes);

                SqlParameter ParTipoListado = new SqlParameter();

                ParTipoListado.ParameterName = "@TipoListado";
                ParTipoListado.SqlDbType = SqlDbType.Int;
                ParTipoListado.Value = tipoListado;
                SqlCmd.Parameters.Add(ParTipoListado);

                SqlParameter ParEspecialidad = new SqlParameter();

                ParEspecialidad.ParameterName = "@Especialidad";
                ParEspecialidad.SqlDbType = SqlDbType.Int;
                ParEspecialidad.Value = ValueOrDBNullIfZero(especialidad);
                SqlCmd.Parameters.Add(ParEspecialidad);
                                
                SqlParameter ParTipoCancelacion = new SqlParameter();

                ParTipoCancelacion.ParameterName = "@TipoCancelacion";
                ParTipoCancelacion.SqlDbType = SqlDbType.Int;
                ParTipoCancelacion.Value = ValueOrDBNullIfZero(tipoCancelacion);
                SqlCmd.Parameters.Add(ParTipoCancelacion);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;

        }

        public DataTable MostrarEspecialidades()
        {
            DataTable DtResultado = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "WINCHESTER.mostrarEspecialidades";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
                
        }
        
         catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
     }






    }

}
