﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using ITCR.PsicoCitas.Negocios;
using System.Web.UI.WebControls;
using System.Net.Mail;

namespace ITCR.PsicoCitas.Interfaz
{
    public partial class vtnAsignarCita : System.Web.UI.Page
    {


        private SolicitudCita solicitud;



        public SolicitudCita Solicitud
        {
            get { return (SolicitudCita)Session["Solicitud"]; }
            set { Session["Solicitud"] = value; }

            // get { return solicitud; }
            //set { solicitud = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

            if (PreviousPage != null)
            {



            







                this.Solicitud = PreviousPage.Solicitud_Cita;

                textoNomEstudiante.Text = Solicitud.NombreEstudiante;
                carnet.Text = Solicitud.CarnetEstudiante;
                carrera.Text=Solicitud.CarreraEstudiante;
                fecha_solicitud.Text = Solicitud.FechaSolicitud.ToString();
                Motivo.Text = Solicitud.MotivoCita;
                Urgencia.Text = Solicitud.Urgencia.ToString();
                Nombre_previo.Text = Solicitud.NombrePsicologo;
               
                if (Solicitud.FechaPrevia.Equals("01/01/1900 0:00:00"))
                { Fecha_previo.Text = ""; }
                else{ Fecha_previo.Text = Solicitud.FechaPrevia;}
                Observacion.Text = Solicitud.Observacion;

             


            }


            else if (IsPostBack)
            {

            }





            else
            {

                Response.Redirect("~/CitasPorPsicologo.aspx");
            }








        }

        protected void btnAsignarCita_Click(object sender, EventArgs e)
        {
           
            AccesoBase ab = new AccesoBase();
           string fecha = txtFecha.Text;
            string horainicio = txtHoraInicio.Text;
            string horafinal =txtHoraFinal.Text;
            
            bool sirvio = ab.AsignarHorarioCita(Solicitud.IdSolicitud,fecha,horainicio,horafinal);

            if (sirvio)
            {

                AsignarCita correo = new AsignarCita();

                correo.enviarCorreo(fecha, horainicio, horafinal, Solicitud.Correo);

                
                Response.Redirect("~/CitasPorPsicologo.aspx"); 
            
            
            
            
            }

            else { Response.Write("Ha ocurrido un error"); }
        }

        }
    }
