using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class D12RegResultados
    {
        public D12RegResultados()
        {

        }

        public DataTable BuscarConsultasParaReg(int unaMatricula)
        {
            DataTable DtResultado = new DataTable();
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "p12ConsultasParaRegistrar";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParMatricula = new SqlParameter();

                ParMatricula.ParameterName = "@matricula";
                ParMatricula.SqlDbType = SqlDbType.Int;
                /*ParMatricula.Size = 50;*/
                ParMatricula.Value = unaMatricula;

                SqlCmd.Parameters.Add(ParMatricula);

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
