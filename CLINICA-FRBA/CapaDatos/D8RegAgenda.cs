using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient; 

namespace CapaDatos
{
    public class D8RegAgenda
    {
        /*Construtores*/
        public D8RegAgenda()
        { }

        /*METODO POR EL CUAL LA CLASE SE CONECTA A SQL PARA EJECUTAR UN STORE PROCEDURE*/
        public DataTable MostrarEspecialidades(int unaMatricula)
        {
            DataTable DtResultado = new DataTable(); /*VARIABLE DONDE GUARDO LO Q ME DEVUELVA SQL*/
            SqlConnection SqlCon = new SqlConnection(); /*VAR. ENCARGADA DE LA CONEXION*/

            /*UTILIZO UN TRY/CATCH PARA POSIBLES ERRORES*/
            try
            {
                SqlCon.ConnectionString = Conexion.Cn; /*LE PASO LA RUTA DE CONEXION QUE TENGO EN LA CLASE CONEXION*/
                SqlCommand SqlCmd = new SqlCommand(); /*OBJ ENCARGADO DE GUARDAR TODOS LOS DATOS PARA EJECUTAR UN DETERMINADO STORE POR EJEMPLO*/
                SqlCmd.Connection = SqlCon; /*LE PASO LA CONEXION AL OBJETO DEL COMANDO*/
                SqlCmd.CommandText = "p8MostrarEspecialidades"; /*LE INDICO EL NOMBRE DEL STORE/FUNCTION/VISTA/...*/
                SqlCmd.CommandType = CommandType.StoredProcedure; /*ESPECIFICO Q TIPO DE OBJETO VOY A USAR EN SQL*/

                /*ESPECIFICO CARACTERISTICAS DEL 1º PARAMETRO*/
                SqlParameter ParMatricula = new SqlParameter(); /*OBJETO DONDE GUARDO CADA CARACTERISTICA*/

                ParMatricula.ParameterName = "@matricula"; /*NOMBRE DEL PARAMETRO EN SQL*/
                ParMatricula.SqlDbType = SqlDbType.Int; /*EL TIPO DE DATO Q ES*/
                //ParMatricula.Size = 255; /*LA DIMENSION*/
                ParMatricula.Value = unaMatricula; /*EL VALOR QUE RECIBE*/
                SqlCmd.Parameters.Add(ParMatricula); /*LE PASO TODO LO REFERIDO AL 1º PARAMETRO*/

                
                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd); /*OBJETO ENCARGADO DE EJECUTAR EL COMANDO Q SE LE PASE*/
                SqlDat.Fill(DtResultado); /*GUARDO EN LA VARIABLE DE TIPO DATATABLE EL RESULTADO DE LA EJECUCION DEL COMANDO*/
            }

            catch (Exception ex)
            {
                DtResultado = null;
            }

            return DtResultado; /*EL METODO DEVUELVE EL RESULTADO EN "FORMATO" DATATABLE AL OBJETO Q LO INVOCO*/
        }

        /*METODO POR EL CUAL LA CLASE SE CONECTA A SQL PARA EJECUTAR UN STORE PROCEDURE*/
        public DataTable InsertarAgenda(int unaMatricula,DateTime fechaIni,DateTime fechaFin,Double cargaHoraria)
        {
            DataTable DtResultado = new DataTable(); /*VARIABLE DONDE GUARDO LO Q ME DEVUELVA SQL*/
            SqlConnection SqlCon = new SqlConnection(); /*VAR. ENCARGADA DE LA CONEXION*/

            /*UTILIZO UN TRY/CATCH PARA POSIBLES ERRORES*/
            try
            {
                SqlCon.ConnectionString = Conexion.Cn; /*LE PASO LA RUTA DE CONEXION QUE TENGO EN LA CLASE CONEXION*/
                SqlCommand SqlCmd = new SqlCommand(); /*OBJ ENCARGADO DE GUARDAR TODOS LOS DATOS PARA EJECUTAR UN DETERMINADO STORE POR EJEMPLO*/
                SqlCmd.Connection = SqlCon; /*LE PASO LA CONEXION AL OBJETO DEL COMANDO*/
                SqlCmd.CommandText = "p8InsertarAgenda"; /*LE INDICO EL NOMBRE DEL STORE/FUNCTION/VISTA/...*/
                SqlCmd.CommandType = CommandType.StoredProcedure; /*ESPECIFICO Q TIPO DE OBJETO VOY A USAR EN SQL*/

                /*ESPECIFICO CARACTERISTICAS DEL 1º PARAMETRO*/
                SqlParameter ParMatricula = new SqlParameter();

                ParMatricula.ParameterName = "@matricula"; 
                ParMatricula.SqlDbType = SqlDbType.Int; 
                //ParMatricula.Size = 255; /*LA DIMENSION*/
                ParMatricula.Value = unaMatricula; 
                SqlCmd.Parameters.Add(ParMatricula);

                /*ESPECIFICO CARACTERISTICAS DEL 2º PARAMETRO*/
                SqlParameter ParFechaIni = new SqlParameter();

                ParFechaIni.ParameterName = "@fechaIni";
                ParFechaIni.SqlDbType = SqlDbType.DateTime;
                //ParFechaIni.Size = 255; /*LA DIMENSION*/
                ParFechaIni.Value = fechaIni;
                SqlCmd.Parameters.Add(fechaIni);

                /*ESPECIFICO CARACTERISTICAS DEL 3º PARAMETRO*/
                SqlParameter ParFechaFin = new SqlParameter();

                ParFechaFin.ParameterName = "@fechaFin";
                ParFechaFin.SqlDbType = SqlDbType.DateTime;
                //ParFechaFin.Size = 255; /*LA DIMENSION*/
                ParFechaFin.Value = fechaFin;
                SqlCmd.Parameters.Add(ParFechaFin);

                /*ESPECIFICO CARACTERISTICAS DEL 4º PARAMETRO*/
                SqlParameter ParCargaHoraria = new SqlParameter();

                ParCargaHoraria.ParameterName = "@cargaHoraria";
                ParCargaHoraria.SqlDbType = SqlDbType.Decimal;
                //ParCargaHoraria.Size = 255; /*LA DIMENSION*/
                ParCargaHoraria.Value = cargaHoraria;
                SqlCmd.Parameters.Add(ParMatricula);


                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd); /*OBJETO ENCARGADO DE EJECUTAR EL COMANDO Q SE LE PASE*/
                SqlDat.Fill(DtResultado); /*GUARDO EN LA VARIABLE DE TIPO DATATABLE EL RESULTADO DE LA EJECUCION DEL COMANDO*/
            }

            catch (Exception ex)
            {
                DtResultado = null;
            }

            return DtResultado; /*EL METODO DEVUELVE EL RESULTADO EN "FORMATO" DATATABLE AL OBJETO Q LO INVOCO*/
        }

        public DataTable BuscarIdAgenda(int unaMatricula)
        {
            DataTable DtResultado = new DataTable(); /*VARIABLE DONDE GUARDO LO Q ME DEVUELVA SQL*/
            SqlConnection SqlCon = new SqlConnection(); /*VAR. ENCARGADA DE LA CONEXION*/

            /*UTILIZO UN TRY/CATCH PARA POSIBLES ERRORES*/
            try
            {
                SqlCon.ConnectionString = Conexion.Cn; /*LE PASO LA RUTA DE CONEXION QUE TENGO EN LA CLASE CONEXION*/
                SqlCommand SqlCmd = new SqlCommand(); /*OBJ ENCARGADO DE GUARDAR TODOS LOS DATOS PARA EJECUTAR UN DETERMINADO STORE POR EJEMPLO*/
                SqlCmd.Connection = SqlCon; /*LE PASO LA CONEXION AL OBJETO DEL COMANDO*/
                SqlCmd.CommandText = "p8BuscarIdAgenda"; /*LE INDICO EL NOMBRE DEL STORE/FUNCTION/VISTA/...*/
                SqlCmd.CommandType = CommandType.StoredProcedure; /*ESPECIFICO Q TIPO DE OBJETO VOY A USAR EN SQL*/

                /*ESPECIFICO CARACTERISTICAS DEL 1º PARAMETRO*/
                SqlParameter ParMatricula = new SqlParameter(); /*OBJETO DONDE GUARDO CADA CARACTERISTICA*/

                ParMatricula.ParameterName = "@matricula"; /*NOMBRE DEL PARAMETRO EN SQL*/
                ParMatricula.SqlDbType = SqlDbType.Int; /*EL TIPO DE DATO Q ES*/
                //ParMatricula.Size = 255; /*LA DIMENSION*/
                ParMatricula.Value = unaMatricula; /*EL VALOR QUE RECIBE*/
                SqlCmd.Parameters.Add(ParMatricula); /*LE PASO TODO LO REFERIDO AL 1º PARAMETRO*/

                
                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd); /*OBJETO ENCARGADO DE EJECUTAR EL COMANDO Q SE LE PASE*/
                SqlDat.Fill(DtResultado); /*GUARDO EN LA VARIABLE DE TIPO DATATABLE EL RESULTADO DE LA EJECUCION DEL COMANDO*/
            }

            catch (Exception ex)
            {
                DtResultado = null;
            }

            return DtResultado; /*EL METODO DEVUELVE EL RESULTADO EN "FORMATO" DATATABLE AL OBJETO Q LO INVOCO*/
        }

        public DataTable InsertarDisponibilidad(int unaAgenda,int unaMatricula,int unaEspecialidad,string unDia,string horaIni,string horaFin)
        {
            DataTable DtResultado = new DataTable(); /*VARIABLE DONDE GUARDO LO Q ME DEVUELVA SQL*/
            SqlConnection SqlCon = new SqlConnection(); /*VAR. ENCARGADA DE LA CONEXION*/

            /*UTILIZO UN TRY/CATCH PARA POSIBLES ERRORES*/
            try
            {
                SqlCon.ConnectionString = Conexion.Cn; /*LE PASO LA RUTA DE CONEXION QUE TENGO EN LA CLASE CONEXION*/
                SqlCommand SqlCmd = new SqlCommand(); /*OBJ ENCARGADO DE GUARDAR TODOS LOS DATOS PARA EJECUTAR UN DETERMINADO STORE POR EJEMPLO*/
                SqlCmd.Connection = SqlCon; /*LE PASO LA CONEXION AL OBJETO DEL COMANDO*/
                SqlCmd.CommandText = "p8InsertarDisponibilidad"; /*LE INDICO EL NOMBRE DEL STORE/FUNCTION/VISTA/...*/
                SqlCmd.CommandType = CommandType.StoredProcedure; /*ESPECIFICO Q TIPO DE OBJETO VOY A USAR EN SQL*/

                /*ESPECIFICO CARACTERISTICAS DEL 1º PARAMETRO*/
                SqlParameter ParAgenda = new SqlParameter();

                ParAgenda.ParameterName = "@agenda";
                ParAgenda.SqlDbType = SqlDbType.Int;
                //ParAgenda.Size = 255; /*LA DIMENSION*/
                ParAgenda.Value = unaAgenda;
                SqlCmd.Parameters.Add(ParAgenda);

                /*ESPECIFICO CARACTERISTICAS DEL 2º PARAMETRO*/
                SqlParameter ParMatricula = new SqlParameter();

                ParMatricula.ParameterName = "@matricula";
                ParMatricula.SqlDbType = SqlDbType.Int;
                //ParMatricula.Size = 255; /*LA DIMENSION*/
                ParMatricula.Value = unaMatricula;
                SqlCmd.Parameters.Add(ParMatricula);

                /*ESPECIFICO CARACTERISTICAS DEL 3º PARAMETRO*/
                SqlParameter ParEspecialidad = new SqlParameter();

                ParEspecialidad.ParameterName = "@especialidad";
                ParEspecialidad.SqlDbType = SqlDbType.Int;
                //ParEspecialidad.Size = 255; /*LA DIMENSION*/
                ParEspecialidad.Value = unaEspecialidad;
                SqlCmd.Parameters.Add(ParEspecialidad);

                /*ESPECIFICO CARACTERISTICAS DEL 4º PARAMETRO*/
                SqlParameter Pardia = new SqlParameter();

                Pardia.ParameterName = "@dia";
                Pardia.SqlDbType = SqlDbType.NVarChar;
                Pardia.Size = 20; /*LA DIMENSION*/
                Pardia.Value = unDia;
                SqlCmd.Parameters.Add(Pardia);

                /*ESPECIFICO CARACTERISTICAS DEL 5º PARAMETRO*/
                SqlParameter ParHoraIni = new SqlParameter();

                ParHoraIni.ParameterName = "@horaIni";
                ParHoraIni.SqlDbType = SqlDbType.NVarChar;
                ParHoraIni.Size = 5; /*LA DIMENSION*/
                ParHoraIni.Value = horaIni;
                SqlCmd.Parameters.Add(ParHoraIni);

                /*ESPECIFICO CARACTERISTICAS DEL 6º PARAMETRO*/
                SqlParameter ParHoraFin = new SqlParameter();

                ParHoraFin.ParameterName = "@horaFin";
                ParHoraFin.SqlDbType = SqlDbType.NVarChar;
                ParHoraFin.Size = 5; /*LA DIMENSION*/
                ParHoraFin.Value = horaFin;
                SqlCmd.Parameters.Add(ParHoraFin);

                
                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd); /*OBJETO ENCARGADO DE EJECUTAR EL COMANDO Q SE LE PASE*/
                SqlDat.Fill(DtResultado); /*GUARDO EN LA VARIABLE DE TIPO DATATABLE EL RESULTADO DE LA EJECUCION DEL COMANDO*/
            }

            catch (Exception ex)
            {
                DtResultado = null;
            }

            return DtResultado; /*EL METODO DEVUELVE EL RESULTADO EN "FORMATO" DATATABLE AL OBJETO Q LO INVOCO*/
        }

        public DataTable BuscarMatricula(string unUserName)
        {
            DataTable DtResultado = new DataTable(); /*VARIABLE DONDE GUARDO LO Q ME DEVUELVA SQL*/
            SqlConnection SqlCon = new SqlConnection(); /*VAR. ENCARGADA DE LA CONEXION*/

            /*UTILIZO UN TRY/CATCH PARA POSIBLES ERRORES*/
            try
            {
                SqlCon.ConnectionString = Conexion.Cn; /*LE PASO LA RUTA DE CONEXION QUE TENGO EN LA CLASE CONEXION*/
                SqlCommand SqlCmd = new SqlCommand(); /*OBJ ENCARGADO DE GUARDAR TODOS LOS DATOS PARA EJECUTAR UN DETERMINADO STORE POR EJEMPLO*/
                SqlCmd.Connection = SqlCon; /*LE PASO LA CONEXION AL OBJETO DEL COMANDO*/
                SqlCmd.CommandText = "p8BuscarMatricula"; /*LE INDICO EL NOMBRE DEL STORE/FUNCTION/VISTA/...*/
                SqlCmd.CommandType = CommandType.StoredProcedure; /*ESPECIFICO Q TIPO DE OBJETO VOY A USAR EN SQL*/

                /*ESPECIFICO CARACTERISTICAS DEL 1º PARAMETRO*/
                SqlParameter ParUserName = new SqlParameter(); /*OBJETO DONDE GUARDO CADA CARACTERISTICA*/

                ParUserName.ParameterName = "@username"; /*NOMBRE DEL PARAMETRO EN SQL*/
                ParUserName.SqlDbType = SqlDbType.VarChar; /*EL TIPO DE DATO Q ES*/
                ParUserName.Size = 255; /*LA DIMENSION*/
                ParUserName.Value = unUserName; /*EL VALOR QUE RECIBE*/
                SqlCmd.Parameters.Add(ParUserName); /*LE PASO TODO LO REFERIDO AL 1º PARAMETRO*/


                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd); /*OBJETO ENCARGADO DE EJECUTAR EL COMANDO Q SE LE PASE*/
                SqlDat.Fill(DtResultado); /*GUARDO EN LA VARIABLE DE TIPO DATATABLE EL RESULTADO DE LA EJECUCION DEL COMANDO*/
            }

            catch (Exception ex)
            {
                DtResultado = null;
            }

            return DtResultado; /*EL METODO DEVUELVE EL RESULTADO EN "FORMATO" DATATABLE AL OBJETO Q LO INVOCO*/
        }

        public DataTable RegistrarTurnos(int unaMatricula)
        {
            DataTable DtResultado = new DataTable(); /*VARIABLE DONDE GUARDO LO Q ME DEVUELVA SQL*/
            SqlConnection SqlCon = new SqlConnection(); /*VAR. ENCARGADA DE LA CONEXION*/

            /*UTILIZO UN TRY/CATCH PARA POSIBLES ERRORES*/
            try
            {
                SqlCon.ConnectionString = Conexion.Cn; /*LE PASO LA RUTA DE CONEXION QUE TENGO EN LA CLASE CONEXION*/
                SqlCommand SqlCmd = new SqlCommand(); /*OBJ ENCARGADO DE GUARDAR TODOS LOS DATOS PARA EJECUTAR UN DETERMINADO STORE POR EJEMPLO*/
                SqlCmd.Connection = SqlCon; /*LE PASO LA CONEXION AL OBJETO DEL COMANDO*/
                SqlCmd.CommandText = "p8RegistrarTurnos"; /*LE INDICO EL NOMBRE DEL STORE/FUNCTION/VISTA/...*/
                SqlCmd.CommandType = CommandType.StoredProcedure; /*ESPECIFICO Q TIPO DE OBJETO VOY A USAR EN SQL*/

                /*ESPECIFICO CARACTERISTICAS DEL 1º PARAMETRO*/
                SqlParameter ParMatricula = new SqlParameter(); /*OBJETO DONDE GUARDO CADA CARACTERISTICA*/

                ParMatricula.ParameterName = "@matricula"; /*NOMBRE DEL PARAMETRO EN SQL*/
                ParMatricula.SqlDbType = SqlDbType.Int; /*EL TIPO DE DATO Q ES*/
                //ParMatricula.Size = 255; /*LA DIMENSION*/
                ParMatricula.Value = unaMatricula; /*EL VALOR QUE RECIBE*/
                SqlCmd.Parameters.Add(ParMatricula); /*LE PASO TODO LO REFERIDO AL 1º PARAMETRO*/


                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd); /*OBJETO ENCARGADO DE EJECUTAR EL COMANDO Q SE LE PASE*/
                SqlDat.Fill(DtResultado); /*GUARDO EN LA VARIABLE DE TIPO DATATABLE EL RESULTADO DE LA EJECUCION DEL COMANDO*/
            }

            catch (Exception ex)
            {
                DtResultado = null;
            }

            return DtResultado; /*EL METODO DEVUELVE EL RESULTADO EN "FORMATO" DATATABLE AL OBJETO Q LO INVOCO*/
        }
    }


}
