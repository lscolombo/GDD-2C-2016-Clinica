using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class D1ABMRol
    {
        //Variable usada para recibir la respuesta del Stored Procedured de crearRol, funciona como variable de salida
        private int respuesta;

        //Getter y setter de la variable
        public int getRespuesta() { return respuesta; }
        public void setRespuesta(int numero) { this.respuesta = numero; }

        //Constructor
        public D1ABMRol()
        {
        }

        //Crear Rol

        public int crearRol(String nombre)
        {
            DataTable DtResultado = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "p1AgregarRol";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter nombreRol = new SqlParameter();
                nombreRol.ParameterName = "@rolAgregar";
                nombreRol.SqlDbType = SqlDbType.VarChar;
                nombreRol.Size = 255;
                nombreRol.Value = nombre;
                SqlCmd.Parameters.Add(nombreRol);

                SqlParameter resultado = new SqlParameter();
                resultado.ParameterName = "@resultado";
                resultado.SqlDbType = SqlDbType.Int;
                resultado.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(resultado);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

                respuesta = Convert.ToInt32(resultado.Value);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return respuesta;
        }

        //Obtengo las funcionalidades que aún no tiene agregadas un rol

        public DataTable getFuncionalidades(String nombreRol)
        {
            DataTable DtResultado = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "p1MostrarFuncionalidadesNoAgregadasARol";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter rol = new SqlParameter();
                rol.ParameterName = "@nombreRol";
                rol.SqlDbType = SqlDbType.VarChar;
                rol.Size = 255;
                rol.Value = nombreRol;
                SqlCmd.Parameters.Add(rol);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }

        //Agrego una funcionalidad a un rol

        public void agregarFuncionalidadARol(String nombreRol, String nombreFuncionalidad)
        {
            DataTable DtResultado = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "WINCHESTER.AgregarFuncionalidadARol";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter rol = new SqlParameter();
                rol.ParameterName = "@nombrerol";
                rol.SqlDbType = SqlDbType.VarChar;
                rol.Size = 255;
                rol.Value = nombreRol;
                SqlCmd.Parameters.Add(rol);

                SqlParameter funcionalidad = new SqlParameter();
                funcionalidad.ParameterName = "@funcionalidad";
                funcionalidad.SqlDbType = SqlDbType.VarChar;
                funcionalidad.Size = 255;
                funcionalidad.Value = nombreFuncionalidad;
                SqlCmd.Parameters.Add(funcionalidad);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
        }

    }
}
