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

        public string InsertarCompraBono(int nroAfiliado, int precioBono,
                                             int cantidadBonos, int precioTotal)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "WINCHESTER.pInsertarCompraBono";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParAfiliadoId = new SqlParameter();
                ParAfiliadoId.ParameterName = "@comp_afiliado";
                ParAfiliadoId.SqlDbType = SqlDbType.Int;
                ParAfiliadoId.Value = nroAfiliado;
                SqlCmd.Parameters.Add(ParAfiliadoId);

                SqlParameter ParPrecioBono = new SqlParameter();
                ParPrecioBono.ParameterName = "@comp_precio_bono";
                ParPrecioBono.SqlDbType = SqlDbType.Int;
                ParPrecioBono.Value = precioBono;
                SqlCmd.Parameters.Add(ParPrecioBono);

                SqlParameter ParCantidad = new SqlParameter();
                ParCantidad.ParameterName = "@comp_cantidad";
                ParCantidad.SqlDbType = SqlDbType.Int;
                ParCantidad.Value = cantidadBonos;
                SqlCmd.Parameters.Add(ParCantidad);

                SqlParameter ParTotal = new SqlParameter();
                ParTotal.ParameterName = "@comp_total";
                ParTotal.SqlDbType = SqlDbType.Int;
                ParTotal.Value = precioTotal;
                SqlCmd.Parameters.Add(ParTotal);

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se ingreso el registro, intente nuevamente";

            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open)
                    SqlCon.Close();
            }

            return rpta;
        }
    }
}
