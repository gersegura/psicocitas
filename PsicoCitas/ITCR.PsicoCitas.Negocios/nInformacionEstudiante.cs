using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using ITCR.PsicoCitas.Datos;

namespace ITCR.PsicoCitas.Negocios
{
    public class nInformacionEstudiante 
    {
        /***
         * <summary> accedo a negocios de la informacion personal,
         * insertar todos los paramestros en una lista</summary>
         * <param name="datosPersonales">
         * 
         * <param name="nombre">
         * <param name="carne">
         * <param name="carrera">
         * <param name="celular">
         * <param name="telefono">
         * <param name="email">
         * <param name="fecha">
         * 
         */
        public bool nInsertarInformacion(List<string> datosPersonales) {
            try
            {
                List<object> datos = new List<object>();
                datos.Add(datosPersonales[0]);//nombre
                datos.Add(Int32.Parse(datosPersonales[1]));//carne
                datos.Add(datosPersonales[2]);//carrera
                datos.Add(Int32.Parse(datosPersonales[3]));//celular
                datos.Add(Int32.Parse(datosPersonales[4]));//telefono
                datos.Add(datosPersonales[5]);//email
                datos.Add(DateTime.Parse(datosPersonales[6]));//fecha nacimiento
                dInformacionEstudiante IE = new dInformacionEstudiante();
                bool pres = IE.InsertarInformacion(datos);
                return pres;
            }
            catch {
                return false;
            }
        }

        public bool nInsertarInformacionAdicional(List<string> datosPersonales) {
            try{

                List<object> datos = new List<object>();
                datos.Add(Int32.Parse(datosPersonales[0]));//carne
                if (datosPersonales[1].Equals("Si"))
                    datos.Add(0);//cambiocarreta?
                else
                    datos.Add(1);//cambiocarreta?


                if (datosPersonales[2].Equals("Si"))
                    datos.Add(0);//consultaprevia?
                else
                    datos.Add(1);//consultaprevia?
                


                datos.Add(datosPersonales[3]);//carrera
                datos.Add(Int16.Parse(datosPersonales[4]));//semestre
                datos.Add(Int32.Parse(datosPersonales[5]));//ano
                datos.Add(datosPersonales[6]);//motivo
                dInformacionEstudiante IE = new dInformacionEstudiante();
                bool pres = IE.InsertarInformacionAdicional(datos);
                return pres;
            }
            catch
            {
                return false;
            }
        }

        public bool nModificarInformacion(List<string> datosPersonales) {
            try{

                List<object> datos = new List<object>();            
                datos.Add(Int32.Parse(datosPersonales[0]));//carne
                datos.Add(datosPersonales[1]);//carrera
                datos.Add(Int32.Parse(datosPersonales[2]));//celular
                datos.Add(Int32.Parse(datosPersonales[3]));//telefona
                datos.Add(datosPersonales[4]);//email
                dInformacionEstudiante IE = new dInformacionEstudiante();
                bool pres = IE.ModificarInformacion(datos);
                return pres;
            }
            catch
            {
                return false;
            }
        }


    }
}

