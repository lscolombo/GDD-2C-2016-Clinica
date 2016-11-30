using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
   
 public class D13CancAtencion
    {
       private int _afilID;
       private int _codTurno;
       private string _detalle;

       public int afilID
       {
           get { return _afilID; }
           set { _afilID = value; }
       }

       public int codTurno
       {
           get { return _codTurno; }
           set { _codTurno = value; }
       }

       public string detalle
       {
           get { return _detalle; }
           set { _detalle = value; }
       }



        /*Construtores*/
     public D13CancAtencion()
         {
           
       }

       //constructor con parámetros
        public D13CancAtencion(int AfilID, int CodTurno, string Detalle)
        {
            this.afilID = AfilID;
            this.codTurno = CodTurno;
            this.detalle = Detalle;
        }
       
        //Método mostrar todos los turnos disponibles pedidos por un afiliado
         public DataTable TurnosPedidos(D13CancAtencion CancAtencion)
        {
         
            DataTable DtResultado = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "WINCHESTER.TurnosPedidos";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                /*ESPECIFICO CARACTERISTICAS DEL 1º PARAMETRO*/
                SqlParameter ParAfilID = new SqlParameter(); 

                ParAfilID.ParameterName = "@afilID";
                ParAfilID.SqlDbType = SqlDbType.Int;
                ParAfilID.Value = afilID; 
                SqlCmd.Parameters.Add(ParAfilID);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;

        }




        //Método cancelar turno por parte de afiliado
        public string CancelarTurnoAf(D13CancAtencion CancAtencion)
        {
            string rpta = ""; 
            SqlConnection SqlCon = new SqlConnection(); 

            /*UTILIZO UN TRY/CATCH PARA POSIBLES ERRORES*/
            try
            {
                SqlCon.ConnectionString = Conexion.Cn; /*LE PASO LA RUTA DE CONEXION QUE TENGO EN LA CLASE CONEXION*/
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand(); /*OBJ ENCARGADO DE GUARDAR TODOS LOS DATOS PARA EJECUTAR UN DETERMINADO STORE POR EJEMPLO*/
                SqlCmd.Connection = SqlCon; /*LE PASO LA CONEXION AL OBJETO DEL COMANDO*/
                SqlCmd.CommandText = "WINCHESTER.cancelarTurnoAf"; /*LE INDICO EL NOMBRE DEL STORE/FUNCTION/VISTA/...*/
                SqlCmd.CommandType = CommandType.StoredProcedure; /*ESPECIFICO Q TIPO DE OBJETO VOY A USAR EN SQL*/

                /*ESPECIFICO CARACTERISTICAS DEL 1º PARAMETRO*/
                SqlParameter ParCodTurno = new SqlParameter(); 

                ParCodTurno.ParameterName = "@codTurno";
                ParCodTurno.SqlDbType = SqlDbType.Int;
                ParCodTurno.Value = codTurno; 
                SqlCmd.Parameters.Add(ParCodTurno); 

                /*ESPECIFICO CARACTERISTICAS DEL 2º PARAMETRO*/
                SqlParameter ParDetalle = new SqlParameter();

                ParDetalle.ParameterName = "@detalle";
                ParDetalle.SqlDbType = SqlDbType.VarChar;
                ParDetalle.Size = 255;
                ParDetalle.Value = detalle;
                SqlCmd.Parameters.Add(ParDetalle); 

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se canceló el turno";


            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
           
            return rpta; 
        }
                

        //Método cancelar día por parte de médico
        //Método cancelar rango de fechas por parte de médico



}
}
