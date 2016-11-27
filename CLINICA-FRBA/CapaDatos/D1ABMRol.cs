using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    class D1ABMRol
    {
        public DataTable crearRol(String nombre){
            DataTable DtResultado = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "p1BuscarRol";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter nombreRol = new SqlParameter();
                nombreRol.ParameterName = "@nombre";
                nombreRol.SqlDbType = SqlDbType.VarChar;
                nombreRol.Size = 255;
                nombreRol.Value = nombre;
                SqlCmd.Parameters.Add(nombreRol);

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
