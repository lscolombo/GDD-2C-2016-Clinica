using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data; 
using System.Data.SqlClient; 


namespace CapaDatos
{
    public class D11RegLlegada
    {
        
        /*Construtores*/
        public D11RegLlegada()
        { 
        }

        
        /*METODO POR EL CUAL LA CLASE SE CONECTA A SQL PARA EJECUTAR UN STORE PROCEDURE*/
        public DataTable BuscarPorApellEspec(string unApellido,string unaEspecialidad)
        {
            DataTable DtResultado = new DataTable(); /*VARIABLE DONDE GUARDO LO Q ME DEVUELVA SQL*/
            SqlConnection SqlCon = new SqlConnection(); /*VAR. ENCARGADA DE LA CONEXION*/

            /*UTILIZO UN TRY/CATCH PARA POSIBLES ERRORES*/
            try
            {
                SqlCon.ConnectionString = Conexion.Cn; /*LE PASO LA RUTA DE CONEXION QUE TENGO EN LA CLASE CONEXION*/
                SqlCommand SqlCmd = new SqlCommand(); /*OBJ ENCARGADO DE GUARDAR TODOS LOS DATOS PARA EJECUTAR UN DETERMINADO STORE POR EJEMPLO*/
                SqlCmd.Connection = SqlCon; /*LE PASO LA CONEXION AL OBJETO DEL COMANDO*/
                SqlCmd.CommandText = "p11BuscarProfesional"; /*LE INDICO EL NOMBRE DEL STORE/FUNCTION/VISTA/...*/
                SqlCmd.CommandType = CommandType.StoredProcedure; /*ESPECIFICO Q TIPO DE OBJETO VOY A USAR EN SQL*/
                
                /*ESPECIFICO CARACTERISTICAS DEL 1º PARAMETRO*/
                SqlParameter ParApell = new SqlParameter(); /*OBJETO DONDE GUARDO CADA CARACTERISTICA*/

                ParApell.ParameterName = "@aProfesional"; /*NOMBRE DEL PARAMETRO EN SQL*/
                ParApell.SqlDbType = SqlDbType.VarChar; /*EL TIPO DE DATO Q ES*/
                ParApell.Size = 255; /*LA DIMENSION*/
                ParApell.Value = unApellido; /*EL VALOR QUE RECIBE*/
                SqlCmd.Parameters.Add(ParApell); /*LE PASO TODO LO REFERIDO AL 1º PARAMETRO*/

                /*ESPECIFICO CARACTERISTICAS DEL 2º PARAMETRO */
                SqlParameter ParEspec = new SqlParameter(); /*OBJETO DONDE GUARDO CADA CARACTERISTICA*/

                ParEspec.ParameterName = "@especialidad"; /*NOMBRE DEL PARAMETRO EN SQL*/
                ParEspec.SqlDbType = SqlDbType.VarChar; /*EL TIPO DE DATO Q ES*/
                ParEspec.Size = 255; /*LA DIMENSION*/
                ParEspec.Value = unaEspecialidad; /*EL VALOR QUE RECIBE*/
                SqlCmd.Parameters.Add(ParEspec); /*LE PASO TODO LO REFERIDO AL 2º PARAMETRO*/

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd); /*OBJETO ENCARGADO DE EJECUTAR EL COMANDO Q SE LE PASE*/
                SqlDat.Fill(DtResultado); /*GUARDO EN LA VARIABLE DE TIPO DATATABLE EL RESULTADO DE LA EJECUCION DEL COMANDO*/
            }

            catch (Exception ex)
            {
                DtResultado = null;
            }

            return DtResultado; /*EL METODO DEVUELVE EL RESULTADO EN "FORMATO" DATATABLE AL OBJETO Q LO INVOCO*/
        }

        /*IDEM CON "BuscarTurnosDisponibles" RESPECTO DE "BuscarPorApellEspec"*/
        /*RESPECTO A LA ESTRUCTURA DEL METODO*/
        public DataTable BuscarTurnosDisponibles(int unaMatricula)
        {
            DataTable DtResultado = new DataTable();
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "p11TurnosDisponibles";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                /*1º Parametro*/
                SqlParameter ParMatricula = new SqlParameter();

                ParMatricula.ParameterName = "@matricula";
                ParMatricula.SqlDbType = SqlDbType.Int;
                ParMatricula.Size = 50;
                ParMatricula.Value = unaMatricula;
                SqlCmd.Parameters.Add(ParMatricula);

                /*2º Parametro*/
                SqlParameter ParFechaSistema = new SqlParameter();

                ParFechaSistema.ParameterName = "@fechaSistema";
                ParFechaSistema.SqlDbType = SqlDbType.VarChar;
                ParFechaSistema.Size = 10;
                ParFechaSistema.Value = Conexion.FechaSistema;
                SqlCmd.Parameters.Add(ParFechaSistema);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }

            return DtResultado;
        }

        /*IDEM CON "BuscarBonosDisponibles" RESPECTO DE "BuscarPorApellEspec"*/
        /*RESPECTO A LA ESTRUCTURA DEL METODO*/
        public DataTable BuscarBonosDisponibles(int unAfiliado)
        {
            DataTable DtResultado = new DataTable();
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "p11BonosDisponibles";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                /*1º Parametro*/
                SqlParameter ParAfiliado = new SqlParameter();

                ParAfiliado.ParameterName = "@afiliado";
                ParAfiliado.SqlDbType = SqlDbType.Int;
                ParAfiliado.Size = 50;
                ParAfiliado.Value = unAfiliado;
                SqlCmd.Parameters.Add(ParAfiliado);


                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }

            return DtResultado;
        }

        /*IDEM CON "insertarConsulta" RESPECTO DE "BuscarPorApellEspec"*/
        /*RESPECTO A LA ESTRUCTURA DEL METODO*/
        public DataTable insertarConsulta(int unTurno, int unBono)
        {
            DataTable DtResultado = new DataTable();
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "p11InsertarConsulta";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                /*1º Parametro*/
                SqlParameter ParTurno = new SqlParameter();

                ParTurno.ParameterName = "@turno";
                ParTurno.SqlDbType = SqlDbType.Int;
                /*ParTurno.Size = 50;*/
                ParTurno.Value = unTurno;
                SqlCmd.Parameters.Add(ParTurno);

                /*2º Parametro*/
                SqlParameter ParBono = new SqlParameter();

                ParBono.ParameterName = "@bono";
                ParBono.SqlDbType = SqlDbType.Int;
                /*ParBono.Size = 50;*/
                ParBono.Value = unBono;
                SqlCmd.Parameters.Add(ParBono);

                /*3º Parametro*/
                SqlParameter ParFechaSistema = new SqlParameter();

                ParFechaSistema.ParameterName = "@fechaSistema";
                ParFechaSistema.SqlDbType = SqlDbType.VarChar;
                ParFechaSistema.Size = 10;
                ParFechaSistema.Value = Conexion.FechaSistema;
                SqlCmd.Parameters.Add(ParFechaSistema);

                
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
