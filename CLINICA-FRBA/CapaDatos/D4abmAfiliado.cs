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
        public DataTable ExisteUserName(string unUserName)
        {
            DataTable DtResultado = new DataTable(); /*VARIABLE DONDE GUARDO LO Q ME DEVUELVA SQL*/
            SqlConnection SqlCon = new SqlConnection(); /*VAR. ENCARGADA DE LA CONEXION*/

            /*UTILIZO UN TRY/CATCH PARA POSIBLES ERRORES*/
            try
            {
                SqlCon.ConnectionString = Conexion.Cn; /*LE PASO LA RUTA DE CONEXION QUE TENGO EN LA CLASE CONEXION*/
                SqlCommand SqlCmd = new SqlCommand(); /*OBJ ENCARGADO DE GUARDAR TODOS LOS DATOS PARA EJECUTAR UN DETERMINADO STORE POR EJEMPLO*/
                SqlCmd.Connection = SqlCon; /*LE PASO LA CONEXION AL OBJETO DEL COMANDO*/
                SqlCmd.CommandText = "p4ExisteUserName"; /*LE INDICO EL NOMBRE DEL STORE/FUNCTION/VISTA/...*/
                SqlCmd.CommandType = CommandType.StoredProcedure; /*ESPECIFICO Q TIPO DE OBJETO VOY A USAR EN SQL*/

                /*ESPECIFICO CARACTERISTICAS DEL 1º PARAMETRO*/
                SqlParameter ParUnUserName = new SqlParameter(); /*OBJETO DONDE GUARDO CADA CARACTERISTICA*/

                ParUnUserName.ParameterName = "@unUserName"; /*NOMBRE DEL PARAMETRO EN SQL*/
                ParUnUserName.SqlDbType = SqlDbType.VarChar; /*EL TIPO DE DATO Q ES*/
                ParUnUserName.Size = 255; /*LA DIMENSION*/
                ParUnUserName.Value = unUserName; /*EL VALOR QUE RECIBE*/
                SqlCmd.Parameters.Add(ParUnUserName); /*LE PASO TODO LO REFERIDO AL 2º PARAMETRO*/

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
        public DataTable ExisteUsuario(string unTipoDNI, string unMail, int unDNI)
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
                SqlParameter ParTipoDNI = new SqlParameter(); /*OBJETO DONDE GUARDO CADA CARACTERISTICA*/

                ParTipoDNI.ParameterName = "@tipoDNI"; /*NOMBRE DEL PARAMETRO EN SQL*/
                ParTipoDNI.SqlDbType = SqlDbType.VarChar; /*EL TIPO DE DATO Q ES*/
                ParTipoDNI.Size = 3; /*LA DIMENSION*/
                ParTipoDNI.Value = unTipoDNI; /*EL VALOR QUE RECIBE*/
                SqlCmd.Parameters.Add(ParTipoDNI); /*LE PASO TODO LO REFERIDO AL 1º PARAMETRO*/

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

        public DataTable InsertarUsuario(string unUserName,string unNombre,string unApellido,
							     int unTelefono, string unSexo,string unEstadoCivil,int unDni,
								 string unTipoDNI,DateTime unaFechaNacimiento,string unaDireccion,string unMail,
								 string unPassword)
        {
            DataTable DtResultado = new DataTable(); /*VARIABLE DONDE GUARDO LO Q ME DEVUELVA SQL*/
            SqlConnection SqlCon = new SqlConnection(); /*VAR. ENCARGADA DE LA CONEXION*/

            /*UTILIZO UN TRY/CATCH PARA POSIBLES ERRORES*/
            try
            {
                SqlCon.ConnectionString = Conexion.Cn; /*LE PASO LA RUTA DE CONEXION QUE TENGO EN LA CLASE CONEXION*/
                SqlCommand SqlCmd = new SqlCommand(); /*OBJ ENCARGADO DE GUARDAR TODOS LOS DATOS PARA EJECUTAR UN DETERMINADO STORE POR EJEMPLO*/
                SqlCmd.Connection = SqlCon; /*LE PASO LA CONEXION AL OBJETO DEL COMANDO*/
                SqlCmd.CommandText = "p4InsertUsuario"; /*LE INDICO EL NOMBRE DEL STORE/FUNCTION/VISTA/...*/
                SqlCmd.CommandType = CommandType.StoredProcedure; /*ESPECIFICO Q TIPO DE OBJETO VOY A USAR EN SQL*/

                /*ESPECIFICO CARACTERISTICAS DEL 1º PARAMETRO*/
                SqlParameter ParUserName = new SqlParameter(); /*OBJETO DONDE GUARDO CADA CARACTERISTICA*/

                ParUserName.ParameterName = "@userName"; /*NOMBRE DEL PARAMETRO EN SQL*/
                ParUserName.SqlDbType = SqlDbType.VarChar; /*EL TIPO DE DATO Q ES*/
                ParUserName.Size = 255; /*LA DIMENSION*/
                ParUserName.Value = unUserName; /*EL VALOR QUE RECIBE*/
                SqlCmd.Parameters.Add(ParUserName); /*LE PASO TODO LO REFERIDO AL 1º PARAMETRO*/

                /*ESPECIFICO CARACTERISTICAS DEL 2º PARAMETRO*/
                SqlParameter ParNombre = new SqlParameter(); /*OBJETO DONDE GUARDO CADA CARACTERISTICA*/

                ParNombre.ParameterName = "@nombre"; /*NOMBRE DEL PARAMETRO EN SQL*/
                ParNombre.SqlDbType = SqlDbType.VarChar; /*EL TIPO DE DATO Q ES*/
                ParNombre.Size = 255; /*LA DIMENSION*/
                ParNombre.Value = unNombre; /*EL VALOR QUE RECIBE*/
                SqlCmd.Parameters.Add(ParNombre); /*LE PASO TODO LO REFERIDO AL 1º PARAMETRO*/

                /*ESPECIFICO CARACTERISTICAS DEL 3º PARAMETRO*/
                SqlParameter ParApellido = new SqlParameter(); /*OBJETO DONDE GUARDO CADA CARACTERISTICA*/

                ParApellido.ParameterName = "@apellido"; /*NOMBRE DEL PARAMETRO EN SQL*/
                ParApellido.SqlDbType = SqlDbType.VarChar; /*EL TIPO DE DATO Q ES*/
                ParApellido.Size = 255; /*LA DIMENSION*/
                ParApellido.Value = unApellido; /*EL VALOR QUE RECIBE*/
                SqlCmd.Parameters.Add(ParApellido); /*LE PASO TODO LO REFERIDO AL 1º PARAMETRO*/

                /*ESPECIFICO CARACTERISTICAS DEL 4º PARAMETRO*/
                SqlParameter ParTelefono = new SqlParameter(); /*OBJETO DONDE GUARDO CADA CARACTERISTICA*/

                ParTelefono.ParameterName = "@telefono"; /*NOMBRE DEL PARAMETRO EN SQL*/
                ParTelefono.SqlDbType = SqlDbType.Int; /*EL TIPO DE DATO Q ES*/
                //ParTelefono.Size = 255; /*LA DIMENSION*/
                ParTelefono.Value = unTelefono; /*EL VALOR QUE RECIBE*/
                SqlCmd.Parameters.Add(ParTelefono); /*LE PASO TODO LO REFERIDO AL 1º PARAMETRO*/

                /*ESPECIFICO CARACTERISTICAS DEL 5º PARAMETRO*/
                SqlParameter ParSexo = new SqlParameter(); /*OBJETO DONDE GUARDO CADA CARACTERISTICA*/

                ParSexo.ParameterName = "@sexo"; /*NOMBRE DEL PARAMETRO EN SQL*/
                ParSexo.SqlDbType = SqlDbType.VarChar; /*EL TIPO DE DATO Q ES*/
                ParSexo.Size = 6; /*LA DIMENSION*/
                ParSexo.Value = unSexo; /*EL VALOR QUE RECIBE*/
                SqlCmd.Parameters.Add(ParSexo); /*LE PASO TODO LO REFERIDO AL 1º PARAMETRO*/

                /*ESPECIFICO CARACTERISTICAS DEL 6º PARAMETRO*/
                SqlParameter ParEstadoCivil = new SqlParameter(); /*OBJETO DONDE GUARDO CADA CARACTERISTICA*/

                ParEstadoCivil.ParameterName = "@estadoCivil"; /*NOMBRE DEL PARAMETRO EN SQL*/
                ParEstadoCivil.SqlDbType = SqlDbType.VarChar; /*EL TIPO DE DATO Q ES*/
                ParEstadoCivil.Size = 11; /*LA DIMENSION*/
                ParEstadoCivil.Value = unEstadoCivil; /*EL VALOR QUE RECIBE*/
                SqlCmd.Parameters.Add(ParEstadoCivil); /*LE PASO TODO LO REFERIDO AL 1º PARAMETRO*/

                /*ESPECIFICO CARACTERISTICAS DEL 7º PARAMETRO*/
                SqlParameter ParDni = new SqlParameter(); /*OBJETO DONDE GUARDO CADA CARACTERISTICA*/

                ParDni.ParameterName = "@dni"; /*NOMBRE DEL PARAMETRO EN SQL*/
                ParDni.SqlDbType = SqlDbType.Int; /*EL TIPO DE DATO Q ES*/
                //ParDni.Size = 11; /*LA DIMENSION*/
                ParDni.Value = unDni; /*EL VALOR QUE RECIBE*/
                SqlCmd.Parameters.Add(ParDni); /*LE PASO TODO LO REFERIDO AL 1º PARAMETRO*/

                /*ESPECIFICO CARACTERISTICAS DEL 8º PARAMETRO*/
                SqlParameter ParTipoDni = new SqlParameter(); /*OBJETO DONDE GUARDO CADA CARACTERISTICA*/

                ParTipoDni.ParameterName = "@tipoDNI"; /*NOMBRE DEL PARAMETRO EN SQL*/
                ParTipoDni.SqlDbType = SqlDbType.VarChar; /*EL TIPO DE DATO Q ES*/
                ParTipoDni.Size = 3; /*LA DIMENSION*/
                ParTipoDni.Value = unTipoDNI; /*EL VALOR QUE RECIBE*/
                SqlCmd.Parameters.Add(ParTipoDni); /*LE PASO TODO LO REFERIDO AL 1º PARAMETRO*/

                /*ESPECIFICO CARACTERISTICAS DEL 9º PARAMETRO*/
                SqlParameter ParFechaNacimiento = new SqlParameter(); /*OBJETO DONDE GUARDO CADA CARACTERISTICA*/

                ParFechaNacimiento.ParameterName = "@fechaNacimiento"; /*NOMBRE DEL PARAMETRO EN SQL*/
                ParFechaNacimiento.SqlDbType = SqlDbType.DateTime; /*EL TIPO DE DATO Q ES*/
                //ParFechaNacimiento.Size = 3; /*LA DIMENSION*/
                ParFechaNacimiento.Value = unaFechaNacimiento; /*EL VALOR QUE RECIBE*/
                SqlCmd.Parameters.Add(ParFechaNacimiento); /*LE PASO TODO LO REFERIDO AL 1º PARAMETRO*/

                /*ESPECIFICO CARACTERISTICAS DEL 10º PARAMETRO*/
                SqlParameter ParDireccion = new SqlParameter(); /*OBJETO DONDE GUARDO CADA CARACTERISTICA*/

                ParDireccion.ParameterName = "@direccion"; /*NOMBRE DEL PARAMETRO EN SQL*/
                ParDireccion.SqlDbType = SqlDbType.VarChar; /*EL TIPO DE DATO Q ES*/
                ParDireccion.Size = 255; /*LA DIMENSION*/
                ParDireccion.Value = unaDireccion; /*EL VALOR QUE RECIBE*/
                SqlCmd.Parameters.Add(ParDireccion); /*LE PASO TODO LO REFERIDO AL 1º PARAMETRO*/

                /*ESPECIFICO CARACTERISTICAS DEL 11º PARAMETRO*/
                SqlParameter ParMail = new SqlParameter(); /*OBJETO DONDE GUARDO CADA CARACTERISTICA*/

                ParMail.ParameterName = "@mail"; /*NOMBRE DEL PARAMETRO EN SQL*/
                ParMail.SqlDbType = SqlDbType.VarChar; /*EL TIPO DE DATO Q ES*/
                ParMail.Size = 255; /*LA DIMENSION*/
                ParMail.Value = unMail; /*EL VALOR QUE RECIBE*/
                SqlCmd.Parameters.Add(ParMail); /*LE PASO TODO LO REFERIDO AL 1º PARAMETRO*/

                /*ESPECIFICO CARACTERISTICAS DEL 12º PARAMETRO*/
                SqlParameter ParPassWord = new SqlParameter(); /*OBJETO DONDE GUARDO CADA CARACTERISTICA*/

                ParPassWord.ParameterName = "@password"; /*NOMBRE DEL PARAMETRO EN SQL*/
                ParPassWord.SqlDbType = SqlDbType.VarChar; /*EL TIPO DE DATO Q ES*/
                ParPassWord.Size = 255; /*LA DIMENSION*/
                ParPassWord.Value = unPassword; /*EL VALOR QUE RECIBE*/
                SqlCmd.Parameters.Add(ParPassWord); /*LE PASO TODO LO REFERIDO AL 1º PARAMETRO*/


                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd); /*OBJETO ENCARGADO DE EJECUTAR EL COMANDO Q SE LE PASE*/
                SqlDat.Fill(DtResultado); /*GUARDO EN LA VARIABLE DE TIPO DATATABLE EL RESULTADO DE LA EJECUCION DEL COMANDO*/
            }

            catch (Exception ex)
            {
                DtResultado = null;
            }

            return DtResultado; /*EL METODO DEVUELVE EL RESULTADO EN "FORMATO" DATATABLE AL OBJETO Q LO INVOCO*/
        }

        public DataTable InsertarAfiliado(int unId, string unUsuario,int unPlan,int unPrincipal ,int unaCantHijos)
        {
            DataTable DtResultado = new DataTable(); /*VARIABLE DONDE GUARDO LO Q ME DEVUELVA SQL*/
            SqlConnection SqlCon = new SqlConnection(); /*VAR. ENCARGADA DE LA CONEXION*/

            /*UTILIZO UN TRY/CATCH PARA POSIBLES ERRORES*/
            try
            {
                SqlCon.ConnectionString = Conexion.Cn; /*LE PASO LA RUTA DE CONEXION QUE TENGO EN LA CLASE CONEXION*/
                SqlCommand SqlCmd = new SqlCommand(); /*OBJ ENCARGADO DE GUARDAR TODOS LOS DATOS PARA EJECUTAR UN DETERMINADO STORE POR EJEMPLO*/
                SqlCmd.Connection = SqlCon; /*LE PASO LA CONEXION AL OBJETO DEL COMANDO*/
                SqlCmd.CommandText = "p4InsertarAfiliado"; /*LE INDICO EL NOMBRE DEL STORE/FUNCTION/VISTA/...*/
                SqlCmd.CommandType = CommandType.StoredProcedure; /*ESPECIFICO Q TIPO DE OBJETO VOY A USAR EN SQL*/

                /*ESPECIFICO CARACTERISTICAS DEL 1º PARAMETRO*/
                SqlParameter ParID = new SqlParameter(); /*OBJETO DONDE GUARDO CADA CARACTERISTICA*/

                ParID.ParameterName = "@Id"; /*NOMBRE DEL PARAMETRO EN SQL*/
                ParID.SqlDbType = SqlDbType.Int; /*EL TIPO DE DATO Q ES*/
                //ParID.Size = 255; /*LA DIMENSION*/
                ParID.Value = unId; /*EL VALOR QUE RECIBE*/
                SqlCmd.Parameters.Add(ParID); /*LE PASO TODO LO REFERIDO AL 1º PARAMETRO*/

                /*ESPECIFICO CARACTERISTICAS DEL 2º PARAMETRO*/
                SqlParameter ParUsuario = new SqlParameter(); /*OBJETO DONDE GUARDO CADA CARACTERISTICA*/

                ParUsuario.ParameterName = "@usuario"; /*NOMBRE DEL PARAMETRO EN SQL*/
                ParUsuario.SqlDbType = SqlDbType.VarChar; /*EL TIPO DE DATO Q ES*/
                ParUsuario.Size = 255; /*LA DIMENSION*/
                ParUsuario.Value = unUsuario; /*EL VALOR QUE RECIBE*/
                SqlCmd.Parameters.Add(ParUsuario); /*LE PASO TODO LO REFERIDO AL 1º PARAMETRO*/

                /*ESPECIFICO CARACTERISTICAS DEL 3º PARAMETRO*/
                SqlParameter ParPlan = new SqlParameter(); /*OBJETO DONDE GUARDO CADA CARACTERISTICA*/

                ParPlan.ParameterName = "@plan"; /*NOMBRE DEL PARAMETRO EN SQL*/
                ParPlan.SqlDbType = SqlDbType.Int; /*EL TIPO DE DATO Q ES*/
                //ParPlan.Size = 255; /*LA DIMENSION*/
                ParPlan.Value = unPlan; /*EL VALOR QUE RECIBE*/
                SqlCmd.Parameters.Add(ParPlan); /*LE PASO TODO LO REFERIDO AL 1º PARAMETRO*/

                /*ESPECIFICO CARACTERISTICAS DEL 4º PARAMETRO*/
                SqlParameter ParPrincipal = new SqlParameter(); /*OBJETO DONDE GUARDO CADA CARACTERISTICA*/

                ParPrincipal.ParameterName = "@principal"; /*NOMBRE DEL PARAMETRO EN SQL*/
                ParPrincipal.SqlDbType = SqlDbType.Int; /*EL TIPO DE DATO Q ES*/
                //ParPrincipal.Size = 255; /*LA DIMENSION*/
                ParPrincipal.Value = unPrincipal; /*EL VALOR QUE RECIBE*/
                SqlCmd.Parameters.Add(ParPrincipal); /*LE PASO TODO LO REFERIDO AL 1º PARAMETRO*/

                /*ESPECIFICO CARACTERISTICAS DEL 5º PARAMETRO*/
                SqlParameter ParCantHijos = new SqlParameter(); /*OBJETO DONDE GUARDO CADA CARACTERISTICA*/

                ParCantHijos.ParameterName = "@cantHijos"; /*NOMBRE DEL PARAMETRO EN SQL*/
                ParCantHijos.SqlDbType = SqlDbType.Int; /*EL TIPO DE DATO Q ES*/
                //ParCantHijos.Size = 6; /*LA DIMENSION*/
                ParCantHijos.Value = unaCantHijos; /*EL VALOR QUE RECIBE*/
                SqlCmd.Parameters.Add(ParCantHijos); /*LE PASO TODO LO REFERIDO AL 1º PARAMETRO*/

                

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
