using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;

namespace ITCR.PsicoCitas.Negocios
{
   public  class AsignarCita
    {


        public bool enviarCorreo(string fecha,string horainicio, string horafinal , string correoEstudiante)
        {


            String Respuesta = "Fecha:  " + fecha + "\n" + "Hora de Inicio:  " + horainicio + "\n" + "Hora final:  " + horafinal;

            try
            {
                //Configuración del Mensaje
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                //Especificamos el correo desde el que se enviará el Email y el nombre de la persona que lo envía
                mail.From = new MailAddress("psicocitas@gmail.com", "Departamente Orientacion y Psicologia", Encoding.UTF8);

                //Aquí ponemos el asunto del correo
                mail.Subject = "DOP - Horario cita asignada";

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








    }



    










}
