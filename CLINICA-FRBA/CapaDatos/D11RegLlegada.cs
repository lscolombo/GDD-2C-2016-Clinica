using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;


namespace CapaDatos
{
    public class D11RegLlegada
    {
        private string _ApellidoPro;
        private string _Especialidad;

        public string ApellidoPro
        {
            get { return _ApellidoPro; }
            set { _ApellidoPro= value; }
        }
        public string Especialidad
        {
            get { return _Especialidad; }
            set { _Especialidad = value; }
        }
        /*Construtores*/
        public D11RegLlegada()
        { 
        }

        public D11RegLlegada(string apellidoPro, string especialidad)
        {
            this._ApellidoPro = apellidoPro;
            this._Especialidad = especialidad;
        }

        /**/
        public DataTable BuscarPorApell(string unApellido)
        { 
            DataTable DtResultado = new DataTable();
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "p11Buscar1";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTxtBuscar = new SqlParameter();

                ParTxtBuscar.ParameterName = "@aProfesional";
                ParTxtBuscar.SqlDbType = SqlDbType.VarChar;
                ParTxtBuscar.Size = 50;
                ParTxtBuscar.Value = unApellido;

                SqlCmd.Parameters.Add(ParTxtBuscar);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null; 
            }

            return DtResultado;
        }

        public DataTable BuscarPorEspecialidad(string unaEspecialidad)
        {
            DataTable DtResultado = new DataTable();
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "p11Buscar2";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTxtBuscar = new SqlParameter();

                ParTxtBuscar.ParameterName = "@especialidad";
                ParTxtBuscar.SqlDbType = SqlDbType.VarChar;
                ParTxtBuscar.Size = 50;
                ParTxtBuscar.Value = unaEspecialidad;

                SqlCmd.Parameters.Add(ParTxtBuscar);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }

            return DtResultado;
        }

        public DataTable BuscarPorApellEspec(string unApellido,string unaEspecialidad)
        {
            DataTable DtResultado = new DataTable();
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "p11Buscar3";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                
                /*1º Parametro*/
                SqlParameter ParApell = new SqlParameter();

                ParApell.ParameterName = "@aProfesional";
                ParApell.SqlDbType = SqlDbType.VarChar;
                ParApell.Size = 50;
                ParApell.Value = unApellido;
                SqlCmd.Parameters.Add(ParApell);

                /*2º Parametro*/
                SqlParameter ParEspec = new SqlParameter();

                ParEspec.ParameterName = "@especialidad";
                ParEspec.SqlDbType = SqlDbType.VarChar;
                ParEspec.Size = 50;
                ParEspec.Value = unaEspecialidad;

                SqlCmd.Parameters.Add(ParEspec);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }

            return DtResultado;
        }

        public DataTable BuscarTurnosDisponibles(int unaMatricula, DateTime unaFecha)
        {
            DataTable DtResultado = new DataTable();
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "p11TurnosDisponibles";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                /*1º Parametro*/
                SqlParameter ParMatricula = new SqlParameter();

                ParMatricula.ParameterName = "@matricula";
                ParMatricula.SqlDbType = SqlDbType.Int;
                ParMatricula.Size = 50;
                ParMatricula.Value = unaMatricula;
                SqlCmd.Parameters.Add(ParMatricula);

                /*2º Parametro*/
                SqlParameter ParFecha = new SqlParameter();

                ParFecha.ParameterName = "@fecha";
                ParFecha.SqlDbType = SqlDbType.DateTime;
                ParFecha.Size = 50;
                ParFecha.Value = unaFecha;

                SqlCmd.Parameters.Add(ParFecha);

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
