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
    }
}
