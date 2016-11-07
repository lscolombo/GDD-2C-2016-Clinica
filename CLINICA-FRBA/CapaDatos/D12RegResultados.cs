using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;


namespace CapaDatos
{
    public class D12RegResultados
    {
        public D12RegResultados()
        {

        }

        /*METODO POR EL CUAL LA CLASE SE CONECTA A SQL PARA EJECUTAR UN STORE PROCEDURE*/
        /*Y DEVUELVE EL RESULTADO DEL COMANDO EJECUTADO AL OBJETO Q LO INVOCO*/
        public DataTable BuscarConsultasParaReg(int unaMatricula)
        {
            DataTable DtResultado = new DataTable(); /*VARIABLE DONDE GUARDO LO Q ME DEVUELVA SQL*/
            SqlConnection SqlCon = new SqlConnection(); /*VAR. ENCARGADA DE LA CONEXION*/

            /*UTILIZO UN TRY/CATCH PARA POSIBLES ERRORES*/
            try
            {
                SqlCon.ConnectionString = Conexion.Cn; /*LE PASO LA RUTA DE CONEXION QUE TENGO EN LA CLASE CONEXION*/
                SqlCommand SqlCmd = new SqlCommand(); /*OBJ ENCARGADO DE GUARDAR TODOS LOS DATOS PARA EJECUTAR UN DETERMINADO STORE POR EJEMPLO*/
                SqlCmd.Connection = SqlCon; /*LE PASO LA CONEXION AL OBJETO DEL COMANDO*/
                SqlCmd.CommandText = "p12ConsultasParaRegistrar"; /*LE INDICO EL NOMBRE DEL STORE/FUNCTION/VISTA/...*/
                SqlCmd.CommandType = CommandType.StoredProcedure; /*ESPECIFICO Q TIPO DE OBJETO VOY A USAR EN SQL*/

                /*ESPECIFICO CARACTERISTICAS DEL 1º PARAMETRO*/
                SqlParameter ParMatricula = new SqlParameter();  /*OBJETO DONDE GUARDO CADA CARACTERISTICA*/

                ParMatricula.ParameterName = "@matricula"; /*NOMBRE DEL PARAMETRO EN SQL*/
                ParMatricula.SqlDbType = SqlDbType.Int; /*EL TIPO DE DATO Q ES*/

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

        /*IDEM CON "UpdateConsulta" RESPECTO DE "BuscarConsultasParaReg"*/
        /*RESPECTO A LA ESTRUCTURA DEL METODO*/
        public DataTable UpdateConsulta(int unID,string enfermedades,string sintomas)
        {
            DataTable DtResultado = new DataTable();
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "p12UpdateConsulta";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                /*1º PARAMETRO*/
                SqlParameter ParId = new SqlParameter();

                ParId.ParameterName = "@id";
                ParId.SqlDbType = SqlDbType.Int;
                /*ParMatricula.Size = 50;*/
                ParId.Value = unID;
                SqlCmd.Parameters.Add(ParId);

                /*2º PARAMETRO*/
                SqlParameter ParEnfermedades = new SqlParameter();

                ParEnfermedades.ParameterName = "@enfermedades";
                ParEnfermedades.SqlDbType = SqlDbType.VarChar;
                ParEnfermedades.Size = 255;
                ParEnfermedades.Value = enfermedades;
                SqlCmd.Parameters.Add(ParEnfermedades);

                /*3º PARAMETRO*/
                SqlParameter ParSintomas = new SqlParameter();

                ParSintomas.ParameterName = "@sintomas";
                ParSintomas.SqlDbType = SqlDbType.VarChar;
                ParSintomas.Size = 255;
                ParSintomas.Value = sintomas;
                SqlCmd.Parameters.Add(ParSintomas);

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
