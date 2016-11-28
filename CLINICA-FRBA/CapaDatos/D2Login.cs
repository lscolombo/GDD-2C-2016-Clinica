using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class D2Login
    {
        public DataTable Login(D3Usuario Usuario)
        {
            DataTable DtResultado = new DataTable("WINCHESTER.Usuario");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "splogin";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParUserName = new SqlParameter();
                ParUserName.ParameterName = "@user_username";
                ParUserName.SqlDbType = SqlDbType.VarChar;
                ParUserName.Size = 255;
                ParUserName.Value = Usuario.User_username;
                SqlCmd.Parameters.Add(ParUserName);

                SqlParameter ParPassword = new SqlParameter();
                ParPassword.ParameterName = "@user_password";
                ParPassword.SqlDbType = SqlDbType.VarChar;
                ParPassword.Size = 255;
                ParPassword.Value = Usuario.User_password;
                SqlCmd.Parameters.Add(ParPassword);

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
