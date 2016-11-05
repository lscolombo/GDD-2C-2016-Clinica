using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DUsuario
    {

        private string _user_username;
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
        private string _user_password;
        private int _user_intentos_fallidos;
        private bool _user_habilitado;

        //Propiedades

        public string User_username
        {
            get { return _user_username; }
            set { _user_username = value; }
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

        public string User_password
        {
            get { return _user_password; }
            set { _user_password = value; }
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
        public DUsuario()
        {

        }

        public DUsuario(string user_username, string user_nombre, string user_apellido,
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

        //Métodos
        public string Insertar(DUsuario Usuario)
        {

            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Código
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "pinsertar_usuario";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParUserName = new SqlParameter();
                ParUserName.ParameterName = "@user_username";
                ParUserName.SqlDbType = SqlDbType.VarChar;
                ParUserName.Size = 255;
                ParUserName.Value = Usuario.User_username;
                SqlCmd.Parameters.Add(ParUserName);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@user_nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 25;
                ParNombre.Value = Usuario.User_nombre;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParApellido = new SqlParameter();
                ParApellido.ParameterName = "@user_apellido";
                ParApellido.SqlDbType = SqlDbType.VarChar;
                ParApellido.Size = 25;
                ParApellido.Value = Usuario.User_apellido;
                SqlCmd.Parameters.Add(ParApellido);

                // En SQL el telefono es numeric

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@user_telefono";
                ParTelefono.SqlDbType = SqlDbType.Float;
                ParTelefono.Value = Usuario.User_telefono;
                SqlCmd.Parameters.Add(ParTelefono);

                SqlParameter ParSexo = new SqlParameter();
                ParSexo.ParameterName = "@user_sexo";
                ParSexo.SqlDbType = SqlDbType.VarChar;
                ParSexo.Size = 1;
                ParSexo.Value = Usuario.User_sexo;
                SqlCmd.Parameters.Add(ParSexo);

                SqlParameter ParEstadoCivil = new SqlParameter();
                ParEstadoCivil.ParameterName = "@user_estado_civil";
                ParEstadoCivil.SqlDbType = SqlDbType.VarChar;
                ParEstadoCivil.Size = 11;
                ParEstadoCivil.Value = Usuario.User_estado_civil;
                SqlCmd.Parameters.Add(ParEstadoCivil);

                // En SQL el DNI es numeric

                SqlParameter ParDNI = new SqlParameter();
                ParDNI.ParameterName = "@user_dni";
                ParDNI.SqlDbType = SqlDbType.Float;
                ParDNI.Value = Usuario.User_dni;
                SqlCmd.Parameters.Add(ParDNI);

                SqlParameter ParTipoDNI = new SqlParameter();
                ParTipoDNI.ParameterName = "@user_tipo_dni";
                ParTipoDNI.SqlDbType = SqlDbType.VarChar;
                ParTipoDNI.Size = 3;
                ParTipoDNI.Value = Usuario.User_tipo_dni;
                SqlCmd.Parameters.Add(ParTipoDNI);

                SqlParameter ParFecha_Nacimiento = new SqlParameter();
                ParFecha_Nacimiento.ParameterName = "@user_fecha_nac";
                ParFecha_Nacimiento.SqlDbType = SqlDbType.DateTime;
                ParFecha_Nacimiento.Value = Usuario.User_fecha_nac;
                SqlCmd.Parameters.Add(ParFecha_Nacimiento);

                SqlParameter ParDireccion = new SqlParameter();
                ParDireccion.ParameterName = "@user_direccion";
                ParDireccion.SqlDbType = SqlDbType.VarChar;
                ParDireccion.Size = 255;
                ParDireccion.Value = Usuario.User_direccion;
                SqlCmd.Parameters.Add(ParDireccion);

                SqlParameter ParEmail = new SqlParameter();
                ParEmail.ParameterName = "@user_mail";
                ParEmail.SqlDbType = SqlDbType.VarChar;
                ParEmail.Size = 255;
                ParEmail.Value = Usuario.User_mail;
                SqlCmd.Parameters.Add(ParEmail);

                SqlParameter ParPassword = new SqlParameter();
                ParPassword.ParameterName = "@password";
                ParPassword.SqlDbType = SqlDbType.VarBinary;
                ParPassword.Size = 255;
                ParPassword.Value = Usuario.User_password;
                SqlCmd.Parameters.Add(ParPassword);

                SqlParameter ParIntentosFallidos = new SqlParameter();
                ParIntentosFallidos.ParameterName = "@user_intentos_fallidos";
                ParIntentosFallidos.SqlDbType = SqlDbType.Int;
                ParIntentosFallidos.Value = Usuario.User_intentos_fallidos;
                SqlCmd.Parameters.Add(ParIntentosFallidos);

                SqlParameter ParHabilitado = new SqlParameter();
                ParHabilitado.ParameterName = "@user_habilitado";
                ParHabilitado.SqlDbType = SqlDbType.Bit;
                ParHabilitado.Value = Usuario.User_habilitado;
                SqlCmd.Parameters.Add(ParHabilitado);

                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";


            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;
        }

        //Método Editar
        public string Editar(DUsuario Usuario)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Código
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "peditar_usuario";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParUserName = new SqlParameter();
                ParUserName.ParameterName = "@user_username";
                ParUserName.SqlDbType = SqlDbType.VarChar;
                ParUserName.Size = 255;
                ParUserName.Value = Usuario.User_username;
                SqlCmd.Parameters.Add(ParUserName);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@user_nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 25;
                ParNombre.Value = Usuario.User_nombre;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParApellido = new SqlParameter();
                ParApellido.ParameterName = "@user_apellido";
                ParApellido.SqlDbType = SqlDbType.VarChar;
                ParApellido.Size = 25;
                ParApellido.Value = Usuario.User_apellido;
                SqlCmd.Parameters.Add(ParApellido);

                // En SQL el telefono es numeric

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@user_telefono";
                ParTelefono.SqlDbType = SqlDbType.Float;
                ParTelefono.Value = Usuario.User_telefono;
                SqlCmd.Parameters.Add(ParTelefono);

                SqlParameter ParSexo = new SqlParameter();
                ParSexo.ParameterName = "@user_sexo";
                ParSexo.SqlDbType = SqlDbType.VarChar;
                ParSexo.Size = 1;
                ParSexo.Value = Usuario.User_sexo;
                SqlCmd.Parameters.Add(ParSexo);

                SqlParameter ParEstadoCivil = new SqlParameter();
                ParEstadoCivil.ParameterName = "@user_estado_civil";
                ParEstadoCivil.SqlDbType = SqlDbType.VarChar;
                ParEstadoCivil.Size = 11;
                ParEstadoCivil.Value = Usuario.User_estado_civil;
                SqlCmd.Parameters.Add(ParEstadoCivil);

                SqlParameter ParDireccion = new SqlParameter();
                ParDireccion.ParameterName = "@user_direccion";
                ParDireccion.SqlDbType = SqlDbType.VarChar;
                ParDireccion.Size = 255;
                ParDireccion.Value = Usuario.User_direccion;
                SqlCmd.Parameters.Add(ParDireccion);

                SqlParameter ParEmail = new SqlParameter();
                ParEmail.ParameterName = "@user_mail";
                ParEmail.SqlDbType = SqlDbType.VarChar;
                ParEmail.Size = 255;
                ParEmail.Value = Usuario.User_mail;
                SqlCmd.Parameters.Add(ParEmail);

                SqlParameter ParPassword = new SqlParameter();
                ParPassword.ParameterName = "@password";
                ParPassword.SqlDbType = SqlDbType.VarBinary;
                ParPassword.Size = 255;
                ParPassword.Value = Usuario.User_password;
                SqlCmd.Parameters.Add(ParPassword);

                SqlParameter ParHabilitado = new SqlParameter();
                ParHabilitado.ParameterName = "@user_habilitado";
                ParHabilitado.SqlDbType = SqlDbType.Bit;
                ParHabilitado.Value = Usuario.User_habilitado;
                SqlCmd.Parameters.Add(ParHabilitado);


                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";

            }

            catch (Exception ex)
            {
                rpta = ex.Message;
            }

            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;
        }

        //Método Eliminar
        public string Eliminar(DUsuario Usuario)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Código
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "peliminar_usuario";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParUserName = new SqlParameter();
                ParUserName.ParameterName = "@user_username";
                ParUserName.SqlDbType = SqlDbType.VarChar;
                ParUserName.Size = 255;
                ParUserName.Value = Usuario.User_username;
                SqlCmd.Parameters.Add(ParUserName);


                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Elimino el Registro";


            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;
        }

        //Método Mostrar (hace falta?)

        //Método Login

        public DataTable Login(DUsuario Usuario)
        {
            DataTable DtResultado = new DataTable("Usuario");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "plogin";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParUserName = new SqlParameter();
                ParUserName.ParameterName = "@user_username";
                ParUserName.SqlDbType = SqlDbType.VarChar;
                ParUserName.Size = 255;
                ParUserName.Value = Usuario.User_username;
                SqlCmd.Parameters.Add(ParUserName);

                SqlParameter ParPassword = new SqlParameter();
                ParPassword.ParameterName = "@password";
                ParPassword.SqlDbType = SqlDbType.VarBinary;
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
