using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace ITCR.PsicoCitas.Datos
{
    public class dIniciarSesion : Conexion
    {
        public bool dLogin(string user, string pass)
        {
            try
            {
                AbrirConexion(); //abre la conexion a la base de datos
                string StoredProcedure = "IniciarSesion";  //nombre del SP en la Base de datos
                SqlCommand cmd = new SqlCommand(StoredProcedure, conexion); //Invocacion del Metodo
                cmd.CommandType = CommandType.StoredProcedure;// Seteamos el tipo del comando a store procedure
                cmd.Parameters.Add(new SqlParameter("@user", SqlDbType.NVarChar, 30));
                cmd.Parameters["@user"].Value = user;
                cmd.Parameters.Add(new SqlParameter("@pass", SqlDbType.NVarChar, 30));
                cmd.Parameters["@pass"].Value = pass;
                datos = cmd.ExecuteReader();

                while (datos.Read())
                {
                    CerrarConexion();
                    return true;
                }
                CerrarConexion();
                return false;
            }
            catch
            {
                CerrarConexion();
                return false;
            }
        }//metodo




    }
}
