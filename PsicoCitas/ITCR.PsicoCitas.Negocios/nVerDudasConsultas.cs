using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
using System.Net;
using ITCR.PsicoCitas.Datos;

namespace ITCR.PsicoCitas.Negocios
{
    public class nVerDudasConsultas
    {
        public List<string> nVerPendiantes() {
            List<string> respuesta = new List<string>();
            dVerDudasConsultas ie = new dVerDudasConsultas();
            respuesta = ie.nCargarDudas();
            return respuesta;
        }//metodo

        public List<string> nCargarDuda(int idduda) { 
            List<string> respuesta = new List<string>();
            dVerDudasConsultas ie = new dVerDudasConsultas();
            respuesta = ie.cCargarDuda(idduda);
            return respuesta;
        }//metodo

        public bool nResponderDudaEstado(int id)
        {
            dVerDudasConsultas ie = new dVerDudasConsultas();
            bool respuesta;
            respuesta = ie.nResponderDudaEstado(id);
            return respuesta;
        }//metodo

        public bool nResponderDudaTexto(int id, string respuesta, string correoEstudiante)
        {
            dVerDudasConsultas ie = new dVerDudasConsultas();
            bool sol;
            sol = ie.nResponderDudaTexto(id, respuesta);
            sol = enviarCorreo(respuesta, correoEstudiante);
            return sol;
        }//metodo

        private bool enviarCorreo(string respuesta, string correoEstudiante){

            try
            {
                //Configuración del Mensaje
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                
                //Especificamos el correo desde el que se enviará el Email y el nombre de la persona que lo envía
                mail.From = new MailAddress("psicocitas@gmail.com", "Departamente Orientacion y Psicologia", Encoding.UTF8);
                
                //Aquí ponemos el asunto del correo
                mail.Subject = "DOP - Respuesta Consulta";

                //Aquí ponemos el mensaje que incluirá el correo
                mail.Body = respuesta;

                //Especificamos a quien enviaremos el Email, no es necesario que sea Gmail, puede ser cualquier otro proveedor
                mail.To.Add(correoEstudiante);
                
                //Si queremos enviar archivos adjuntos tenemos que especificar la ruta en donde se encuentran
                //mail.Attachments.Add(new Attachment(@"C:\Documentos\carta.docx"));


                //Configuracion del SMTP
                SmtpServer.Port = 587; //Puerto que utiliza Gmail para sus servicios
                //Especificamos las credenciales con las que enviaremos el mail
                SmtpServer.Credentials = new System.Net.NetworkCredential("psicocitas@gmail.com", "PsicoCitas-TEC1");
                SmtpServer.EnableSsl = true;
                SmtpServer.Send(mail);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

    }//clase
}//clase
