﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class D10Turno
    {
        public DataTable MostrarEspecialidades()
        {
            DataTable DtResultado = new DataTable("WINCHESTER.Especialidad");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "WINCHESTER.pMostrarEspecialidades";
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

        public DataTable MostrarProfesionales(string especialidad)
        {
            DataTable DtResultado = new DataTable("WINCHESTER.Usuario");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "WINCHESTER.pTraerProfesionales";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParEspecialidad = new SqlParameter();
                ParEspecialidad.ParameterName = "@esp_codigo";
                ParEspecialidad.SqlDbType = SqlDbType.Int;
                ParEspecialidad.Value = Convert.ToInt32(especialidad);
                SqlCmd.Parameters.Add(ParEspecialidad);

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
