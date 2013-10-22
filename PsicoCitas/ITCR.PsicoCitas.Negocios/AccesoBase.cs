using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace ITCR.PsicoCitas.Negocios
{
   public class AccesoBase
    {
        SqlConnection cnn;
        SqlDataReader rdr;
        public AccesoBase()
        {
           // cnn = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=PsicoCitas_TEC;Data Source=localhost");
            cnn = new SqlConnection("workstation id=PsicoCitasTEC.mssql.somee.com;packet size=4096;user id=psicocitas_SQLLogin_1;pwd=bcbfq3ebio;data source=PsicoCitasTEC.mssql.somee.com;persist security info=False;initial catalog=PsicoCitasTEC");
        }




        public bool insertarDuda(String nombreEst, int edadEst, int carreraEst, int carnetEst, String correoEst, String dudaEst, int estadoEst)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandText = "Insertar_Consulta";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Nombre", SqlDbType.VarChar);
                cmd.Parameters["@Nombre"].Value = nombreEst;
                cmd.Parameters.Add("@Edad", SqlDbType.Int);
                cmd.Parameters["@Edad"].Value = edadEst;
                cmd.Parameters.Add("@carne", SqlDbType.Int);
                cmd.Parameters["@carne"].Value = carnetEst;
                cmd.Parameters.Add("@Carrera", SqlDbType.Int);
                cmd.Parameters["@Carrera"].Value = carreraEst;
                cmd.Parameters.Add("@email", SqlDbType.NVarChar);
                cmd.Parameters["@email"].Value = correoEst;
                cmd.Parameters.Add("@duda", SqlDbType.NVarChar);
                cmd.Parameters["@duda"].Value = dudaEst;
                cmd.Parameters.Add("@estado", SqlDbType.Bit);
                cmd.Parameters["@estado"].Value = estadoEst;


                cnn.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }




        public List<string> nCargarCarreras()
        {
            try
            {

                cnn.Open();
                string StoredProcedure = "obtenerCarreras";  //nombre del SP en la Base de datos
                SqlCommand cmd = new SqlCommand(StoredProcedure, cnn); //Invocacion del Metodo
                cmd.CommandType = CommandType.StoredProcedure;// Seteamos el tipo del comando a store procedure
                SqlDataReader datos = null;
                datos = cmd.ExecuteReader();
                List<string> listaID = new List<string>();
                while (datos.Read())
                {
                    listaID.Add(datos.GetValue(0).ToString());
                }
                
                return listaID;
            }
            catch
            {
                cnn.Close();
                List<string> vacia = new List<string>();
                return vacia;
            }
        }//metodo




        public bool AsignarCita(int id_asesor,int id_solicitud)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandText = "Asignar_Psicologo";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@id_Solicitud", SqlDbType.Int);
                cmd.Parameters["@id_Solicitud"].Value = id_solicitud;
                cmd.Parameters.Add("@id_Asesor", SqlDbType.Int);
                cmd.Parameters["@id_Asesor"].Value = id_asesor;
              


                cnn.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }





        public bool AsignarHorarioCita(int id_solicitud,String fecha,String hora_inicio,String hora_final)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandText = "Asignar_Cita";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@id_Solicitud", SqlDbType.Int);
                cmd.Parameters["@id_Solicitud"].Value = id_solicitud;
                cmd.Parameters.Add("@fecha", SqlDbType.Date);
                cmd.Parameters["@fecha"].Value = fecha;
                cmd.Parameters.Add("@hora_inicio", SqlDbType.VarChar);
                cmd.Parameters["@hora_inicio"].Value = hora_inicio;
                cmd.Parameters.Add("@hora_fin", SqlDbType.VarChar);
                cmd.Parameters["@hora_fin"].Value = hora_final;


                cnn.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }







        public SqlDataReader obtener_info_Estudiante(string nombre)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandText = "RetornaDatosSolicitud";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@NombreEstudiante", SqlDbType.VarChar);
                cmd.Parameters["@NombreEstudiante"].Value = nombre;
                cnn.Open();
                rdr = cmd.ExecuteReader();
                return rdr;
            }
            catch (Exception e)
            {
                return rdr;
            }
        }



        public int insertar_HorarioDisp(SolicitudCita citaNueva, int idHorario)
        {

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandText = "InsertaHorarioDisp";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@dia", SqlDbType.VarChar);
                cmd.Parameters["@dia"].Value = citaNueva.DiaSolicitud;
                cmd.Parameters.Add("@hora_inicio", SqlDbType.VarChar);
                cmd.Parameters["@hora_inicio"].Value = citaNueva.HoraInicio;
                cmd.Parameters.Add("@hora_fin", SqlDbType.VarChar);
                cmd.Parameters["@hora_fin"].Value = citaNueva.HoraFin;
                cmd.Parameters.Add("@idHorario", SqlDbType.Int);
                cmd.Parameters["@idHorario"].Direction = ParameterDirection.Output;
                cmd.Parameters["@idHorario"].Value = idHorario;

                cnn.Open();
                cmd.ExecuteNonQuery();

                int res = int.Parse(cmd.Parameters["@idHorario"].Value.ToString());
                cnn.Close();
                return res;

            }
            catch (Exception ex)
            {

                return 0;
            }
        }




        public SolicitudCita Obtener_Cita(int id)
        {
            SqlConnection conn = cnn;
            SqlCommand cmd = new SqlCommand("Obtener_Cita", conn);
            cmd.Parameters.AddWithValue("@Id", id);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds, "cita");

         DataTable dt = ds.Tables[0];

        DataRow row = dt.Rows[0];

        DateTime _fechaSolicitud = Convert.ToDateTime(row["Fecha de Solicitud"]);
       String _motivoCita= Convert.ToString(row["Motivo"]);
       int _urgencia = Convert.ToInt32(row["Urgencia"]);
       String _nombrePsicologo = Convert.ToString(row["Psicologo"]);
       String _fechaPrevia = Convert.ToString(row["Fecha Previa"]);
      
       String _observacion = Convert.ToString(row["Observacion"]);
       String _nombreEstudiante = Convert.ToString(row["Estudiante"]);
       String _carnetEstudiante = Convert.ToString(row["Carnet"]);
       String _carreraEstudiante = Convert.ToString(row["Carrera"]);

       String _correo = Convert.ToString(row["Correo"]);
     
            
      SolicitudCita solicitud  = new SolicitudCita(_fechaSolicitud,_motivoCita,_urgencia,_nombrePsicologo,_fechaPrevia,0,_observacion,null,null,null,_nombreEstudiante,_carnetEstudiante,_carreraEstudiante,_correo);

      solicitud.IdSolicitud = id;

     return solicitud;



        }



        public DataSet Obtener_Asesores()
        {

            SqlCommand cmd = new SqlCommand("Obtener_Asesores", cnn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            return ds;
        }   



        public bool insertar_Solicitud(SolicitudCita citaNueva, int idHorarioDisp)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandText = "Insertar_Nueva_Solicitud";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@fecha_Sol", SqlDbType.Date);
                cmd.Parameters["@fecha_Sol"].Value = citaNueva.FechaSolicitud;
                cmd.Parameters.Add("@motivo", SqlDbType.VarChar);
                cmd.Parameters["@motivo"].Value = citaNueva.MotivoCita;
                cmd.Parameters.Add("@urgencia", SqlDbType.Int);
                cmd.Parameters["@urgencia"].Value = citaNueva.Urgencia;
                cmd.Parameters.Add("@psicologoPrev", SqlDbType.VarChar);
                cmd.Parameters["@psicologoPrev"].Value = citaNueva.NombrePsicologo;
                cmd.Parameters.Add("@fechaPrev", SqlDbType.VarChar);
                cmd.Parameters["@fechaPrev"].Value = citaNueva.FechaPrevia;
                cmd.Parameters.Add("@confirmacion", SqlDbType.Bit);
                cmd.Parameters["@confirmacion"].Value = citaNueva.Confirmacion;
                cmd.Parameters.Add("@observacion", SqlDbType.VarChar);
                cmd.Parameters["@observacion"].Value = citaNueva.Observacion;
                cmd.Parameters.Add("@idHorarioDisp", SqlDbType.Int);
                cmd.Parameters["@idHorarioDisp"].Value = idHorarioDisp;
                cmd.Parameters.Add("@nomEstudiante", SqlDbType.VarChar);
                cmd.Parameters["@nomEstudiante"].Value = citaNueva.NombreEstudiante;
                cmd.Parameters.Add("@carnetEst", SqlDbType.VarChar);
                cmd.Parameters["@carnetEst"].Value = citaNueva.CarnetEstudiante;


                cnn.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }
    }
}
