using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class D3Usuario
    {
        private string _user_username;
        private string _user_password;

        private string _user_nombre;
        private string _user_apellido;
        private string _user_telefono;
        private char _user_sexo;
        private string _user_estado_civil;
        private string _user_dni;
        private string _user_tipo_dni;
        private DateTime _user_fecha_nac;
        private string _user_direccion;
        private string _user_mail;
        private int _user_intentos_fallidos;
        private bool _user_habilitado;



        //Propiedades

        public string User_username
        {
            get { return _user_username; }
            set { _user_username = value; }
        }

        public string User_password
        {
            get { return _user_password; }
            set { _user_password = value; }
        }

        public string User_nombre
        {
            get { return _user_nombre; }
            set { _user_nombre = value; }
        }

        public string User_apellido
        {
            get { return _user_apellido; }
            set { _user_apellido = value; }
        }

        public string User_telefono
        {
            get { return _user_telefono; }
            set { _user_telefono = value; }
        }

        public char User_sexo
        {
            get { return _user_sexo; }
            set { _user_sexo = value; }
        }

        public string User_estado_civil
        {
            get { return _user_estado_civil; }
            set { _user_estado_civil = value; }
        }

        public string User_dni
        {
            get { return _user_dni; }
            set { _user_dni = value; }
        }

        public string User_tipo_dni
        {
            get { return _user_tipo_dni; }
            set { _user_tipo_dni = value; }
        }

        public DateTime User_fecha_nac
        {
            get { return _user_fecha_nac; }
            set { _user_fecha_nac = value; }
        }

        public string User_direccion
        {
            get { return _user_direccion; }
            set { _user_direccion = value; }
        }

        public string User_mail
        {
            get { return _user_mail; }
            set { _user_mail = value; }
        }

        public int User_intentos_fallidos
        {
            get { return _user_intentos_fallidos; }
            set { _user_intentos_fallidos = value; }
        }

        public bool User_habilitado
        {
            get { return _user_habilitado; }
            set { _user_habilitado = value; }
        }

        //Constructores
        public D3Usuario()
        {

        }
        /*
        public D3Usuario(string user_username, string user_password)
        {
            this.User_username = user_username;
            this.User_password = user_password;
        }
        */
        public D3Usuario(string user_username, string user_nombre, string user_apellido,
                        string user_telefono, char user_sexo, string user_estado_civil,
                        string user_dni, string user_tipo_dni, DateTime user_fecha_nac,
                        string user_direccion, string user_mail, string user_password,
                        int user_intentos_fallidos, bool user_habilitado)
        {
            this.User_username = user_username;
            this.User_nombre = user_nombre;
            this.User_apellido = user_apellido;
            this.User_telefono = user_telefono;
            this.User_sexo = user_sexo;
            this.User_estado_civil = user_estado_civil;
            this.User_dni = user_dni;
            this.User_tipo_dni = user_tipo_dni;
            this.User_fecha_nac = user_fecha_nac;
            this.User_direccion = user_direccion;
            this.User_mail = user_mail;
            this.User_password = user_password;
            this.User_intentos_fallidos = user_intentos_fallidos;
            this.User_habilitado = user_habilitado;
        }

        public DataTable TraerDatosAfiliado(string user_username)
        {
            DataTable DtResultado = new DataTable("WINCHESTER.Afiliado");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "WINCHESTER.pDatosAfiliado";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParUserName = new SqlParameter();
                ParUserName.ParameterName = "@afil_usuario";
                ParUserName.SqlDbType = SqlDbType.VarChar;
                ParUserName.Size = 255;
                ParUserName.Value = user_username;
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

        public DataTable TraerNombreYApellidoAfiliado(int nroAfiliado)
        {
            DataTable DtResultado = new DataTable("WINCHESTER.Usuario");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "WINCHESTER.pApellNombAfiliado";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParNroAfil = new SqlParameter();
                ParNroAfil.ParameterName = "@afiliado";
                ParNroAfil.SqlDbType = SqlDbType.Int;
                ParNroAfil.Value = nroAfiliado;
                SqlCmd.Parameters.Add(ParNroAfil);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;

        }

        public DataTable ObtenerPlanAfiliado(int nroAfiliado)
        {
            DataTable DtResultado = new DataTable("WINCHESTER.Afiliado");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "WINCHESTER.pObtenerPlan";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParNroAfil = new SqlParameter();
                ParNroAfil.ParameterName = "@afil_id";
                ParNroAfil.SqlDbType = SqlDbType.Int;
                ParNroAfil.Value = nroAfiliado;
                SqlCmd.Parameters.Add(ParNroAfil);

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
