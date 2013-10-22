using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ITCR.PsicoCitas.Negocios;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace ITCR.PsicoCitas.Interfaz
{
    public partial class AsignarPsicologo : System.Web.UI.Page
    {

        private SolicitudCita solicitud;

        
        
        public SolicitudCita Solicitud
        {
           get { return (SolicitudCita) Session["Solicitud"]; }
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
           // carrera.Text=solicitud.Carrera; Falta meter atributo en la clase solicitud
            fecha_solicitud.Text = Solicitud.DiaSolicitud;
            Motivo.Text = Solicitud.MotivoCita;
            Urgencia.Text = Solicitud.Urgencia.ToString();
            Nombre_previo.Text = Solicitud.NombrePsicologo;
            Fecha_previo.Text = Solicitud.FechaPrevia;
            Observacion.Text = Solicitud.Observacion;

            if (!IsPostBack)
            {
                AccesoBase nuevoacceso = new AccesoBase();

                ddlPsicologos.DataSource = nuevoacceso.Obtener_Asesores();
                ddlPsicologos.DataTextField = "Nombre";                            
                ddlPsicologos.DataValueField = "ID";
                ddlPsicologos.DataBind();

            }
            
            }
            else if (IsPostBack)
            {
               
            }
            else
            {

                Response.Redirect("~/vtnSolicitudesDeCitas.aspx");
            }
        
        
        }

        protected void btnAsignarCita_Click(object sender, EventArgs e)
        {
            int id_asesor= Convert.ToInt32(ddlPsicologos.SelectedItem.Value);
            AccesoBase ab = new AccesoBase();
            bool sirvio = ab.AsignarCita(id_asesor,Solicitud.IdSolicitud);

            if (sirvio)
            { Response.Redirect("~/vtnSolicitudesDeCitas.aspx"); }

            else { Response.Write("Ha ocurrido un error"); }
        }

       
    





     
    }
}