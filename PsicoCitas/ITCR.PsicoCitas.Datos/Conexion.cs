using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.NetworkInformation;
using System.Data.SqlClient;

namespace ITCR.PsicoCitas.Datos
{
    public class Conexion
    {
        private static string nombreEmpresa = "PsicoCitas_TEC";
        private static string nombre_maquina_correcto = IPGlobalProperties.GetIPGlobalProperties().HostName;
        private static string nombre_maquina= @"Danilo_PC\DASM";

        /*protected string _Ruta = "Data Source=" + nombre_maquina+ 
                                 ";Initial Catalog=" + nombreEmpresa + 
                                 ";Integrated Security=SSPI;Persist Security Info=False;";"*/
        protected string _Ruta = "workstation id=PsicoCitasTEC.mssql.somee.com;packet size=4096;user id=psicocitas_SQLLogin_1;pwd=bcbfq3ebio;data source=PsicoCitasTEC.mssql.somee.com;persist security info=False;initial catalog=PsicoCitasTEC";
        protected SqlConnection conexion = null;
        protected SqlDataReader datos = null;


        

        protected bool AbrirConexion()
        {
            try
            {
                conexion = new SqlConnection(_Ruta);
                conexion.Open();
                return true;
            }
            catch
            {
                return false;
            }

        }
        protected bool CerrarConexion()
        {
            try
            {
                conexion.Close();
                return true;
            }
            catch
            {
                return false;
            }

        }



    }
}
