using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class D9CompraBono
    {
        public DataTable ObtenerDatosPlan(int planId)
        {
            DataTable DtResultado = new DataTable("WINCHESTER.Plan_Medico");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "WINCHESTER.pObtenerDatosPlan";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParPlanId = new SqlParameter();
                ParPlanId.ParameterName = "@plan_id";
                ParPlanId.SqlDbType = SqlDbType.Int;
                ParPlanId.Value = planId;
                SqlCmd.Parameters.Add(ParPlanId);

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
