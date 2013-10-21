using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace ITCR.PsicoCitas.Datos
{
    public class dInformacionEstudiante : Conexion
    {

        public bool InsertarInformacion(List<object> datosPersonal) {
            try
            {
                AbrirConexion(); //abre la conexion a la base de datos
                string StoredProcedure = "Insertar_Informacion_Personal";  //nombre del SP en la Base de datos
                SqlCommand cmd = new SqlCommand(StoredProcedure, conexion); //Invocacion del Metodo
                cmd.CommandType = CommandType.StoredProcedure;// Seteamos el tipo del comando a store procedure
                //Agregamos parametros

                cmd.Parameters.Add(new SqlParameter("@Nombre", SqlDbType.NVarChar, 40));
                cmd.Parameters["@Nombre"].Value = datosPersonal[0];

                cmd.Parameters.Add(new SqlParameter("@carne", SqlDbType.Int));
                cmd.Parameters["@carne"].Value = datosPersonal[1];

                cmd.Parameters.Add(new SqlParameter("@Carrera", SqlDbType.NVarChar,40));
                cmd.Parameters["@Carrera"].Value = datosPersonal[2];

                cmd.Parameters.Add(new SqlParameter("@Celular", SqlDbType.Int));
                cmd.Parameters["@Celular"].Value = datosPersonal[3];

                cmd.Parameters.Add(new SqlParameter("@Telefono", SqlDbType.Int));
                cmd.Parameters["@Telefono"].Value = datosPersonal[4];

                cmd.Parameters.Add(new SqlParameter("@email", SqlDbType.NVarChar,100));
                cmd.Parameters["@email"].Value = datosPersonal[5];

                cmd.Parameters.Add(new SqlParameter("@Nacimiento", SqlDbType.Date));
                cmd.Parameters["@Nacimiento"].Value = datosPersonal[6];

                cmd.ExecuteReader(); //ejecuta el SP


                CerrarConexion();
                return true;
            }
            catch {
                CerrarConexion();
                return false;
            }
        }//metodo

        public bool InsertarInformacionAdicional(List<object> datosPersonal)
        {
            try
            {
                AbrirConexion(); //abre la conexion a la base de datos
                string StoredProcedure = "Insertar_Informacion_Personal_Adicional";  //nombre del SP en la Base de datos
                SqlCommand cmd = new SqlCommand(StoredProcedure, conexion); //Invocacion del Metodo
                cmd.CommandType = CommandType.StoredProcedure;// Seteamos el tipo del comando a store procedure
                //Agregamos parametros

                cmd.Parameters.Add(new SqlParameter("@carnet", SqlDbType.Int));
                cmd.Parameters["@carnet"].Value = datosPersonal[0];

                cmd.Parameters.Add(new SqlParameter("@cambioCarrera", SqlDbType.Bit));
                cmd.Parameters["@cambioCarrera"].Value = datosPersonal[1];

                cmd.Parameters.Add(new SqlParameter("@consultaPrevia", SqlDbType.Bit));
                cmd.Parameters["@consultaPrevia"].Value = datosPersonal[2];

                cmd.Parameters.Add(new SqlParameter("@NombreCarrera", SqlDbType.NVarChar, 40));
                cmd.Parameters["@NombreCarrera"].Value = datosPersonal[3];

                cmd.Parameters.Add(new SqlParameter("@Semestre", SqlDbType.Bit));
                cmd.Parameters["@Semestre"].Value = datosPersonal[4];

                cmd.Parameters.Add(new SqlParameter("@Ano", SqlDbType.Int));
                cmd.Parameters["@Ano"].Value = datosPersonal[5];

                cmd.Parameters.Add(new SqlParameter("@Motivo", SqlDbType.NVarChar, 250));
                cmd.Parameters["@Motivo"].Value = datosPersonal[6];

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

        public bool ModificarInformacion(List<object> datosPersonal)
        {
            try
            {
                AbrirConexion(); //abre la conexion a la base de datos
                string StoredProcedure = "Modifar_Informacon_Personal";  //nombre del SP en la Base de datos
                SqlCommand cmd = new SqlCommand(StoredProcedure, conexion); //Invocacion del Metodo
                cmd.CommandType = CommandType.StoredProcedure;// Seteamos el tipo del comando a store procedure
                //Agregamos parametros

                cmd.Parameters.Add(new SqlParameter("@carne", SqlDbType.Int));
                cmd.Parameters["@carne"].Value = datosPersonal[0];

                cmd.Parameters.Add(new SqlParameter("@Carrera", SqlDbType.NVarChar,40));
                cmd.Parameters["@Carrera"].Value = datosPersonal[1];

                cmd.Parameters.Add(new SqlParameter("@Celular", SqlDbType.Int));
                cmd.Parameters["@Celular"].Value = datosPersonal[2];

                cmd.Parameters.Add(new SqlParameter("@Telefono", SqlDbType.Int));
                cmd.Parameters["@Telefono"].Value = datosPersonal[3];

                cmd.Parameters.Add(new SqlParameter("@email", SqlDbType.NVarChar,100));
                cmd.Parameters["@email"].Value = datosPersonal[4];

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

    }
}
