using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient; 

namespace CapaDatos
{
    public class D4abmAfiliado
    {
         /*Construtores*/
        public D4abmAfiliado()
        { 
        }

        
        /*METODO POR EL CUAL LA CLASE SE CONECTA A SQL PARA EJECUTAR UN STORE PROCEDURE*/
        public DataTable BuscarUltimoAfiliado()
        {
            DataTable DtResultado = new DataTable(); /*VARIABLE DONDE GUARDO LO Q ME DEVUELVA SQL*/
            SqlConnection SqlCon = new SqlConnection(); /*VAR. ENCARGADA DE LA CONEXION*/

            /*UTILIZO UN TRY/CATCH PARA POSIBLES ERRORES*/
            try
            {
                SqlCon.ConnectionString = Conexion.Cn; /*LE PASO LA RUTA DE CONEXION QUE TENGO EN LA CLASE CONEXION*/
                SqlCommand SqlCmd = new SqlCommand(); /*OBJ ENCARGADO DE GUARDAR TODOS LOS DATOS PARA EJECUTAR UN DETERMINADO STORE POR EJEMPLO*/
                SqlCmd.Connection = SqlCon; /*LE PASO LA CONEXION AL OBJETO DEL COMANDO*/
                SqlCmd.CommandText = "p4BuscarUltimoAfiliado"; /*LE INDICO EL NOMBRE DEL STORE/FUNCTION/VISTA/...*/
                SqlCmd.CommandType = CommandType.StoredProcedure; /*ESPECIFICO Q TIPO DE OBJETO VOY A USAR EN SQL*/
                
                
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
        public DataTable ExisteUsuario(string unUsuario, string unMail, int unDNI)
        {
            DataTable DtResultado = new DataTable(); /*VARIABLE DONDE GUARDO LO Q ME DEVUELVA SQL*/
            SqlConnection SqlCon = new SqlConnection(); /*VAR. ENCARGADA DE LA CONEXION*/

            /*UTILIZO UN TRY/CATCH PARA POSIBLES ERRORES*/
            try
            {
                SqlCon.ConnectionString = Conexion.Cn; /*LE PASO LA RUTA DE CONEXION QUE TENGO EN LA CLASE CONEXION*/
                SqlCommand SqlCmd = new SqlCommand(); /*OBJ ENCARGADO DE GUARDAR TODOS LOS DATOS PARA EJECUTAR UN DETERMINADO STORE POR EJEMPLO*/
                SqlCmd.Connection = SqlCon; /*LE PASO LA CONEXION AL OBJETO DEL COMANDO*/
                SqlCmd.CommandText = "p4ExisteUsuario"; /*LE INDICO EL NOMBRE DEL STORE/FUNCTION/VISTA/...*/
                SqlCmd.CommandType = CommandType.StoredProcedure; /*ESPECIFICO Q TIPO DE OBJETO VOY A USAR EN SQL*/

                /*ESPECIFICO CARACTERISTICAS DEL 1º PARAMETRO*/
                SqlParameter ParUsuario = new SqlParameter(); /*OBJETO DONDE GUARDO CADA CARACTERISTICA*/

                ParUsuario.ParameterName = "@usuario"; /*NOMBRE DEL PARAMETRO EN SQL*/
                ParUsuario.SqlDbType = SqlDbType.VarChar; /*EL TIPO DE DATO Q ES*/
                ParUsuario.Size = 255; /*LA DIMENSION*/
                ParUsuario.Value = unUsuario; /*EL VALOR QUE RECIBE*/
                SqlCmd.Parameters.Add(ParUsuario); /*LE PASO TODO LO REFERIDO AL 1º PARAMETRO*/

                /*ESPECIFICO CARACTERISTICAS DEL 2º PARAMETRO */
                SqlParameter ParMail = new SqlParameter(); /*OBJETO DONDE GUARDO CADA CARACTERISTICA*/

                ParMail.ParameterName = "@mail"; /*NOMBRE DEL PARAMETRO EN SQL*/
                ParMail.SqlDbType = SqlDbType.VarChar; /*EL TIPO DE DATO Q ES*/
                ParMail.Size = 255; /*LA DIMENSION*/
                ParMail.Value = unMail; /*EL VALOR QUE RECIBE*/
                SqlCmd.Parameters.Add(ParMail); /*LE PASO TODO LO REFERIDO AL 2º PARAMETRO*/

                /*ESPECIFICO CARACTERISTICAS DEL 3º PARAMETRO */
                SqlParameter ParDNI = new SqlParameter(); /*OBJETO DONDE GUARDO CADA CARACTERISTICA*/

                ParDNI.ParameterName = "@dni"; /*NOMBRE DEL PARAMETRO EN SQL*/
                ParDNI.SqlDbType = SqlDbType.Int; /*EL TIPO DE DATO Q ES*/
                //ParMail.Size = 255; /*LA DIMENSION*/
                ParDNI.Value = unDNI; /*EL VALOR QUE RECIBE*/
                SqlCmd.Parameters.Add(ParDNI); /*LE PASO TODO LO REFERIDO AL 2º PARAMETRO*/

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
        public DataTable ExisteAfiliado(string unUsuario)
        {
            DataTable DtResultado = new DataTable(); /*VARIABLE DONDE GUARDO LO Q ME DEVUELVA SQL*/
            SqlConnection SqlCon = new SqlConnection(); /*VAR. ENCARGADA DE LA CONEXION*/

            /*UTILIZO UN TRY/CATCH PARA POSIBLES ERRORES*/
            try
            {
                SqlCon.ConnectionString = Conexion.Cn; /*LE PASO LA RUTA DE CONEXION QUE TENGO EN LA CLASE CONEXION*/
                SqlCommand SqlCmd = new SqlCommand(); /*OBJ ENCARGADO DE GUARDAR TODOS LOS DATOS PARA EJECUTAR UN DETERMINADO STORE POR EJEMPLO*/
                SqlCmd.Connection = SqlCon; /*LE PASO LA CONEXION AL OBJETO DEL COMANDO*/
                SqlCmd.CommandText = "p4ExisteAfiliado"; /*LE INDICO EL NOMBRE DEL STORE/FUNCTION/VISTA/...*/
                SqlCmd.CommandType = CommandType.StoredProcedure; /*ESPECIFICO Q TIPO DE OBJETO VOY A USAR EN SQL*/

                /*ESPECIFICO CARACTERISTICAS DEL 1º PARAMETRO*/
                SqlParameter ParUsuario = new SqlParameter(); /*OBJETO DONDE GUARDO CADA CARACTERISTICA*/

                ParUsuario.ParameterName = "@usuario"; /*NOMBRE DEL PARAMETRO EN SQL*/
                ParUsuario.SqlDbType = SqlDbType.VarChar; /*EL TIPO DE DATO Q ES*/
                ParUsuario.Size = 255; /*LA DIMENSION*/
                ParUsuario.Value = unUsuario; /*EL VALOR QUE RECIBE*/
                SqlCmd.Parameters.Add(ParUsuario); /*LE PASO TODO LO REFERIDO AL 1º PARAMETRO*/

                
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
