using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ITCR.PsicoCitas.Negocios;


namespace ITCR.PsicoCitas.Pruebas
{
    class Program
    {
        static void Main(string[] args)
        {



            
            string carne = "555";
            string carrera = "farma";
            string celular = "77775555";
            string telefono = "22772277";
            string email = "farmayes@gmail.com";
            /*
            string semstre = "0";
            string ano = "2010";
            string motivo = "dificultad";
            
            string celular = "87655654";
            string telefono = "22111450";
            string email = "pato@gmail.com";
            string fecha = "30-8-2094";*/


            List<string> datoss = new List<string>();


            
            datoss.Add(carne);
            datoss.Add(carrera);
            datoss.Add(celular);
            datoss.Add(telefono);
            datoss.Add(email);
            





            nInformacionEstudiante IE = new nInformacionEstudiante();
            bool e = IE.nModificarInformacion(datoss);

            Console.WriteLine(e);
            Console.ReadLine();


        }

    }
}
