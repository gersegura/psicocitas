using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

namespace ITCR.PsicoCitas.Interfaz.GuardarEnDb
{
    public static class ArchivosDAL
    {

        public static void Guardar(string nombrearchivo, int length, byte[] archivo)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Data Source=Danilo_PC/DASM;Initial Catalog=PsicoCitas_TEC;Integrated Security=SSPI;Persist Security Info=False;"].ToString()))
            {
                conn.Open();

                string query = @"INSERT INTO Archivos (nombre, length, archivo)
                                 VALUES (@name, @length, @archivo)";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@name", nombrearchivo);
                cmd.Parameters.AddWithValue("@length", length);

                SqlParameter archParam = cmd.Parameters.Add("@archivo", System.Data.SqlDbType.VarBinary);
                archParam.Value = archivo;

                cmd.ExecuteNonQuery();

            }

        }

        public static List<Archivo> GetAll()
        {
            List<Archivo> lista = new List<Archivo>();

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Data Source=Danilo_PC/DASM;Initial Catalog=PsicoCitas_TEC;Integrated Security=SSPI;Persist Security Info=False;"].ToString()))
            {
                conn.Open();

                string query = @"SELECT Id, Nombre, Length  
                                    FROM Archivos";

                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Archivo img = new Archivo(
                                            Convert.ToInt32(reader["Id"]),
                                            Convert.ToString(reader["nombre"]),
                                            Convert.ToInt32(reader["length"]));
                    lista.Add(img);
                }

            }

            return lista;

        }

        public static Archivo GetById(int Id)
        {
            Archivo arch = null;

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Data Source=Danilo_PC/DASM;Initial Catalog=PsicoCitas_TEC;Integrated Security=SSPI;Persist Security Info=False;"].ToString()))
            {
                conn.Open();

                string query = @"SELECT Id, Nombre, Length, archivo
                                FROM Archivos
                                WHERE Id = @id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", Id);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    arch = new Archivo(
                                    Convert.ToInt32(reader["Id"]),
                                    Convert.ToString(reader["nombre"]),
                                    Convert.ToInt32(reader["length"]));

                    arch.ContenidoArchivo = (byte[])reader["archivo"];

                }

            }

            return arch;

        }

        public static void DeleteById(int Id)
        {

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Data Source=Danilo_PC/DASM;Initial Catalog=PsicoCitas_TEC;Integrated Security=SSPI;Persist Security Info=False;"].ToString()))
            {
                conn.Open();

                string query = @"DELETE FROM Archivos WHERE Id = @id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", Id);

                cmd.ExecuteNonQuery();

            }
        }


    }


    public class Archivo
    {
        public Archivo(int id, string nombre, int length)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Length = length;
        }
        public int Id { get; set; }
        public int Length { get; set; }
        public string Nombre { get; set; }

        public byte[] ContenidoArchivo { get; set; }
    }
}