using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace ITCR.PsicoCitas.Datos
{
    public class dVerDudasConsultas : Conexion
    {

        public dVerDudasConsultas() { }

        public List<string> nCargarDudas() {
            try
            {
                AbrirConexion(); //abre la conexion a la base de datos
                string StoredProcedure = "verIdDudas";  //nombre del SP en la Base de datos
                SqlCommand cmd = new SqlCommand(StoredProcedure, conexion); //Invocacion del Metodo
                cmd.CommandType = CommandType.StoredProcedure;// Seteamos el tipo del comando a store procedure
                datos = cmd.ExecuteReader();
                List<string> listaID = new List<string>();
                while (datos.Read())
                {
                    listaID.Add(datos.GetValue(0).ToString());
                }
                CerrarConexion();
                return listaID;
            }
            catch {
                CerrarConexion();
                List<string> vacia = new List<string>();
                return vacia;
            }
        }//metodo



        public List<string> cCargarDuda(int idDuda) {
            try
            {
                List<string> listaID = new List<string>();
                AbrirConexion(); //abre la conexion a la base de datos
                string StoredProcedure = "obtener_Consulta";  //nombre del SP en la Base de datos
                SqlCommand cmd = new SqlCommand(StoredProcedure, conexion); //Invocacion del Metodo
                cmd.CommandType = CommandType.StoredProcedure;// Seteamos el tipo del comando a store procedure
                cmd.Parameters.Add(new SqlParameter("@idconsulta", SqlDbType.Int));
                cmd.Parameters["@idconsulta"].Value = idDuda;
                datos = cmd.ExecuteReader();
                while (datos.Read())
                {
                    listaID.Add(datos.GetValue(1).ToString());
                    listaID.Add(datos.GetValue(2).ToString());
                    listaID.Add(datos.GetValue(4).ToString());
                    listaID.Add(datos.GetValue(5).ToString());
                    listaID.Add(datos.GetValue(6).ToString());
                }
                CerrarConexion();
                return listaID;
            }
            catch {
                CerrarConexion();
                List<string> vacia = new List<string>();
                return vacia;
            }
        }//metodo


        public bool nResponderDudaTexto(int idDuda, string respuesta) {
            try
            {
                AbrirConexion(); //abre la conexion a la base de datos
                string StoredProcedure = "insertar_Respuesta";  //nombre del SP en la Base de datos
                SqlCommand cmd = new SqlCommand(StoredProcedure, conexion); //Invocacion del Metodo
                cmd.CommandType = CommandType.StoredProcedure;// Seteamos el tipo del comando a store procedure
                cmd.Parameters.Add(new SqlParameter("@Respuesta", SqlDbType.NVarChar, 500));
                cmd.Parameters["@Respuesta"].Value = respuesta;
                cmd.Parameters.Add(new SqlParameter("@idconsulta", SqlDbType.Int));
                cmd.Parameters["@idconsulta"].Value = idDuda;
                cmd.ExecuteReader(); //ejecuta el SP
                CerrarConexion();
                return true;
            }
            catch 
            {
                CerrarConexion();
                return false;
            }
        }//metodo

        public bool nResponderDudaEstado(int idDuda)
        {
            try
            {
                AbrirConexion(); //abre la conexion a la base de datos
                string StoredProcedure = "cambiar_estado_duda";  //nombre del SP en la Base de datos
                SqlCommand cmd = new SqlCommand(StoredProcedure, conexion); //Invocacion del Metodo
                cmd.CommandType = CommandType.StoredProcedure;// Seteamos el tipo del comando a store procedure
                cmd.Parameters.Add(new SqlParameter("@id_consulta", SqlDbType.Int));
                cmd.Parameters["@id_consulta"].Value = idDuda;
                cmd.ExecuteReader(); //ejecuta el SP
                CerrarConexion();
                return true;
            }
            catch
            {
                CerrarConexion();
                return false;
            }
        }//metodo


    }//clase
}//alcance
