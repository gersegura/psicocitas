using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlTypes;
using System.Data;
using System.Data.SqlClient;
using Microsoft.SqlServer.Server;
using System.Data.Common;
using System.Data.Odbc;



namespace ITCR.PsicoCitas.Interfaz
{
    public class CU_ModificarHorario
    {

        
        private String cadena;
        



        public CU_ModificarHorario()
		{
            /*host = @"Danilo_PC\DASM";
            bd = "PsicoCitas_TEC";
            cadena = "Data Source=" + host + ";Initial Catalog=" + bd + ";Integrated Security=True";*/
            cadena = "workstation id=PsicoCitasTEC.mssql.somee.com;packet size=4096;user id=psicocitas_SQLLogin_1;pwd=bcbfq3ebio;data source=PsicoCitasTEC.mssql.somee.com;persist security info=False;initial catalog=PsicoCitasTEC";
           //cadena = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=PsicoCitas_TEC;Data Source=localhost";
		}





        public int InsertaBloque(string dia, string horainicio,string horafinal)
        {


            try
            {
            using (SqlConnection connection = new SqlConnection(cadena))
                {

                    using (SqlCommand command = new SqlCommand())
                    {
                        connection.Open();
                        command.Connection = connection;
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.CommandText = "Insertar_Bloque";
                        command.CommandTimeout = 10;
                       // command.Parameters.Add(new SqlParameter("@resultado", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.ReturnValue, false, 0, 32, "ret", System.Data.DataRowVersion.Default, null));
                        command.Parameters.AddWithValue("@Dia", dia);
                        command.Parameters.AddWithValue("@HoraInicio", horainicio);
                        command.Parameters.AddWithValue("@HoraFinal", horafinal);
                        int rows = command.ExecuteNonQuery();
                        //int j = (int)command.Parameters["@resultado"].Value;
                        connection.Close();
                        return 0;
                    }
                }
            }
            catch (SqlException)
            {
                return -1;
            }
        }
        public DataSet MostrarBloque(string dia)
        {
                SqlConnection conn = new SqlConnection(cadena);
                SqlCommand cmd = new SqlCommand("Mostrar_Bloque", conn);
                cmd.Parameters.AddWithValue("@dia", dia);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataSet ds = new DataSet();
                da.Fill(ds, "bloque");
                return ds;
        }



        public int EliminarBloque(int Id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(cadena))
                {

                    using (SqlCommand command = new SqlCommand())
                    {
                        connection.Open();
                        command.Connection = connection;
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.CommandText = "borrar_Bloque";
                        command.CommandTimeout = 10;
                        // command.Parameters.Add(new SqlParameter("@resultado", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.ReturnValue, false, 0, 32, "ret", System.Data.DataRowVersion.Default, null));
                        command.Parameters.AddWithValue("@ID", Id);
                        
                        int rows = command.ExecuteNonQuery();
                        //int j = (int)command.Parameters["@resultado"].Value;
                        connection.Close();
                        return 0;
                    }
                }
            }
            catch (SqlException)
            {
                return -1;
            }
        }



        public DataSet MostrarCita()
        {
            SqlConnection conn = new SqlConnection(cadena);
            SqlCommand cmd = new SqlCommand("Mostrar_Cita_Pendiente", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds, "citas");
            return ds;

        }





        public DataSet MostrarCitaAsesor(int id_asesor)
        {
            SqlConnection conn = new SqlConnection(cadena);
            SqlCommand cmd = new SqlCommand("Citas_por_Asesor", conn);
            cmd.Parameters.AddWithValue("@idAsesor", id_asesor);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds, "citas");
            return ds;

        }








    }
}