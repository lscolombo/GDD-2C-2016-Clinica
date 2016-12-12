﻿using System;
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
        private string _afilID;
        private int _codTurno;
        private string _detalle;
        private DateTime _fechaInicio;
        private DateTime _fechaFin;
        private DateTime _fechaApp;
        private string _profesionalID;

        public string afilID
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

        public DateTime fechaInicio
        {
            get { return _fechaInicio; }
            set { _fechaInicio = value; }
        }

        public DateTime fechaFin
        {
            get { return _fechaFin; }
            set { _fechaFin = value; }
        }

        public DateTime fechaApp
        {
            get { return _fechaApp; }
            set { _fechaApp = value; }
        }

        public string profesionalID
        {
            get { return _profesionalID; }
            set { _profesionalID = value; }
        }


        /*Construtores*/
        public D13CancAtencion()
        {

        }

        //constructor con parámetros
        public D13CancAtencion(string AfilID, int CodTurno, string Detalle)
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
                SqlCmd.CommandText = "WINCHESTER.turnosPedidos";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                /*ESPECIFICO CARACTERISTICAS DEL 1º PARAMETRO*/
                SqlParameter ParAfilID = new SqlParameter();

                ParAfilID.ParameterName = "@afilID";
                ParAfilID.SqlDbType = SqlDbType.VarChar;
                ParAfilID.Size = 255;
                ParAfilID.Value = afilID;
                SqlCmd.Parameters.Add(ParAfilID);

                SqlParameter ParFechaApp = new SqlParameter();

                ParFechaApp.ParameterName = "@fechaApp";
                ParFechaApp.SqlDbType = SqlDbType.VarChar;
                ParFechaApp.Size = 10;
                ParFechaApp.Value = Conexion.FechaSistema;
                SqlCmd.Parameters.Add(ParFechaApp);

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

                SqlParameter ParFechaApp = new SqlParameter();

                ParFechaApp.ParameterName = "@fechaApp";
                ParFechaApp.SqlDbType = SqlDbType.VarChar;
                ParFechaApp.Size = 10;
                ParFechaApp.Value = Conexion.FechaSistema;
                SqlCmd.Parameters.Add(ParFechaApp);

                rpta = SqlCmd.ExecuteNonQuery() == 2 ? "OK" : "NO Se canceló el turno";


            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }

            return rpta;
        }


        //Método mostrar todos los turnos pendientes de un médico dado un intervalo de fechas
        public DataTable TurnosPendientesEntreFechas(D13CancAtencion CancAtencion)
        {

            DataTable DtResultado = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "WINCHESTER.TurnosPendientesEntreFechas";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                /*ESPECIFICO CARACTERISTICAS DEL 1º PARAMETRO*/
                SqlParameter ParProf = new SqlParameter();

                ParProf.ParameterName = "@profesionalID";
                ParProf.SqlDbType = SqlDbType.VarChar;
                ParProf.Size = 255;
                ParProf.Value = profesionalID;
                SqlCmd.Parameters.Add(ParProf);


                SqlParameter ParFechaInicio = new SqlParameter();

                ParFechaInicio.ParameterName = "@fechaInicio";
                ParFechaInicio.SqlDbType = SqlDbType.DateTime;
                ParFechaInicio.Value = fechaInicio;
                SqlCmd.Parameters.Add(ParFechaInicio);


                SqlParameter ParFechaFin = new SqlParameter();

                ParFechaFin.ParameterName = "@fechaFin";
                ParFechaFin.SqlDbType = SqlDbType.DateTime;
                ParFechaFin.Value = fechaFin;
                SqlCmd.Parameters.Add(ParFechaFin);



               
                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;

        }

        //Método cancelar rango de fechas/día por parte de médico
        public string CancelarTurnosProf(D13CancAtencion CancAtencion)
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
                SqlCmd.CommandText = "WINCHESTER.cancelarTurnosProf"; /*LE INDICO EL NOMBRE DEL STORE/FUNCTION/VISTA/...*/
                SqlCmd.CommandType = CommandType.StoredProcedure; /*ESPECIFICO Q TIPO DE OBJETO VOY A USAR EN SQL*/

                /*ESPECIFICO CARACTERISTICAS DEL 1º PARAMETRO*/
                SqlParameter ParFechaInicio = new SqlParameter();

                ParFechaInicio.ParameterName = "@fechaInicio";
                ParFechaInicio.SqlDbType = SqlDbType.DateTime;
                ParFechaInicio.Value = fechaInicio;
                SqlCmd.Parameters.Add(ParFechaInicio);

                /*ESPECIFICO CARACTERISTICAS DEL 2º PARAMETRO*/
                SqlParameter ParFechaFin = new SqlParameter();

                ParFechaFin.ParameterName = "@fechaFin";
                ParFechaFin.SqlDbType = SqlDbType.DateTime;
                ParFechaFin.Value = fechaFin;
                SqlCmd.Parameters.Add(ParFechaFin);

                /*ESPECIFICO CARACTERISTICAS DEL 3º PARAMETRO*/
                SqlParameter ParDetalle = new SqlParameter();

                ParDetalle.ParameterName = "@detalle";
                ParDetalle.SqlDbType = SqlDbType.VarChar;
                ParDetalle.Size = 255;
                ParDetalle.Value = detalle;
                SqlCmd.Parameters.Add(ParDetalle);

                /*ESPECIFICO CARACTERISTICAS DEL 4º PARAMETRO*/
                SqlParameter ParProfesionalID = new SqlParameter();

                ParProfesionalID.ParameterName = "@profesionalID";
                ParProfesionalID.SqlDbType = SqlDbType.VarChar;
                ParProfesionalID.Size = 255;
                ParProfesionalID.Value = profesionalID;
                SqlCmd.Parameters.Add(ParProfesionalID);

                SqlParameter ParFechaApp = new SqlParameter();

                ParFechaApp.ParameterName = "@fechaApp";
                ParFechaApp.SqlDbType = SqlDbType.VarChar;
                ParFechaApp.Size = 10;
                ParFechaApp.Value = Conexion.FechaSistema;
                SqlCmd.Parameters.Add(ParFechaApp);


                rpta = "Se cancelaron" + " " + SqlCmd.ExecuteNonQuery() +" " + "turnos"; // == 1 ? "OK" : "No se cancelaron los turnos para las fechas seleccionadas";


            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }

            return rpta;
        }



    }
}

