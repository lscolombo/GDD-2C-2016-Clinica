using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class D10Turno
    {
        public DataTable MostrarEspecialidades()
        {
            DataTable DtResultado = new DataTable("WINCHESTER.Especialidad");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "WINCHESTER.pMostrarEspecialidades";
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

        public DataTable MostrarProfesionales(string especialidad)
        {
            DataTable DtResultado = new DataTable("WINCHESTER.Usuario");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "WINCHESTER.pMostrarProfesionales";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParEspecialidad = new SqlParameter();
                ParEspecialidad.ParameterName = "@esp_por_prof_especialidad";
                ParEspecialidad.SqlDbType = SqlDbType.Int;
                ParEspecialidad.Value = Convert.ToInt32(especialidad);
                SqlCmd.Parameters.Add(ParEspecialidad);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;

        }

        public DataTable TraerEspecialidad(string especialidad)
        {
            DataTable DtResultado = new DataTable("WINCHESTER.Especialidad");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "WINCHESTER.pTraerEspecialidad";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParEspecialidad = new SqlParameter();
                ParEspecialidad.ParameterName = "@esp_codigo";
                ParEspecialidad.SqlDbType = SqlDbType.Int;
                ParEspecialidad.Value = Convert.ToInt32(especialidad);
                SqlCmd.Parameters.Add(ParEspecialidad);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }

        public DataTable TraerMatricula(string usuario)
        {
            DataTable DtResultado = new DataTable("WINCHESTER.Profesional");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "WINCHESTER.pTraerMatricula";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParUserName = new SqlParameter();
                ParUserName.ParameterName = "@prof_usuario";
                ParUserName.SqlDbType = SqlDbType.VarChar;
                ParUserName.Size = 255;
                ParUserName.Value = usuario;
                SqlCmd.Parameters.Add(ParUserName);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }

        public DataTable MostrarTurnos(string fecha, string matricula, string especialidad)
        {
            DataTable DtResultado = new DataTable("WINCHESTER.Turno");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "WINCHESTER.pMostrarTurnos";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParFecha = new SqlParameter();
                ParFecha.ParameterName = "@turn_fecha";
                ParFecha.SqlDbType = SqlDbType.VarChar;
                ParFecha.Size = 10;
                ParFecha.Value = fecha;
                SqlCmd.Parameters.Add(ParFecha);

                SqlParameter ParProfesional = new SqlParameter();
                ParProfesional.ParameterName = "@turn_profesional";
                ParProfesional.SqlDbType = SqlDbType.Int;
                ParProfesional.Value = Convert.ToInt32(matricula);
                SqlCmd.Parameters.Add(ParProfesional);

                SqlParameter ParEspecialidad = new SqlParameter();
                ParEspecialidad.ParameterName = "@turn_especialidad";
                ParEspecialidad.SqlDbType = SqlDbType.Int;
                ParEspecialidad.Value = Convert.ToInt32(especialidad);
                SqlCmd.Parameters.Add(ParEspecialidad);

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
