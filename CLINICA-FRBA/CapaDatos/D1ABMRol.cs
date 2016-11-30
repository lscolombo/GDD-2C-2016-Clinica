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

        //Metodo para crear un rol

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

        //Metodo para obtener las funcionalidades que aún no tiene agregadas un rol

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

        //Metodo para obtener las funcionalidades asignadas que tiene un rol

        public DataTable getFuncionalidadesAsignadas(String nombreRol)
        {
            DataTable DtResultado = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "p1MostrarFuncionalidadesAgregadasARol";
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

        //Metodo para agregar una funcionalidad a un rol

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

        //Eliminar funcionalidad de un rol

        public void eliminarFuncionalidadARol(int idRol, String nombreFuncionalidad)
        {
            DataTable DtResultado = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "p1EliminarFuncionalidadARol";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter funcionalidad = new SqlParameter();
                funcionalidad.ParameterName = "@nombreFuncionalidad";
                funcionalidad.SqlDbType = SqlDbType.VarChar;
                funcionalidad.Size = 255;
                funcionalidad.Value = nombreFuncionalidad;
                SqlCmd.Parameters.Add(funcionalidad);

                SqlParameter id = new SqlParameter();
                id.ParameterName = "@idRol";
                id.SqlDbType = SqlDbType.Int;
                id.Value = idRol;
                SqlCmd.Parameters.Add(id);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
        }

        //Metodo para mostrar los roles existentes en el sistema

        public DataTable mostrarRoles()
        {
            DataTable DtResultado = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "p1MostrarRoles";
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

        //Metodo para cambiar el nombre de un rol

        public void cambiarNombreRol(int id, String nombre)
        {
            DataTable DtResultado = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "p1ActualizarNombreRol";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter idRol = new SqlParameter();
                idRol.ParameterName = "@id";
                idRol.SqlDbType = SqlDbType.Int;
                idRol.Value = id;
                SqlCmd.Parameters.Add(idRol);

                SqlParameter nombreRol = new SqlParameter();
                nombreRol.ParameterName = "@nombreRol";
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
        }

        //Metodo para habilitar un rol

        public void habilitarRol(int id)
        {
            DataTable DtResultado = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "p1HabilitarRol";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter idRol = new SqlParameter();
                idRol.ParameterName = "@idRol";
                idRol.SqlDbType = SqlDbType.Int;
                idRol.Value = id;
                SqlCmd.Parameters.Add(idRol);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
        }

        //Metodo para deshabilitar un rol

        public void deshabilitarRol(int id)
        {
            DataTable DtResultado = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "p1DeshabilitarRol";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter idRol = new SqlParameter();
                idRol.ParameterName = "@idRol";
                idRol.SqlDbType = SqlDbType.Int;
                idRol.Value = id;
                SqlCmd.Parameters.Add(idRol);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
        }

        //Metodo para mostrar los roles habilitados

        public DataTable mostrarRolesHabilitados()
        {
            DataTable DtResultado = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "p1MostrarRolesHabilitados";
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
