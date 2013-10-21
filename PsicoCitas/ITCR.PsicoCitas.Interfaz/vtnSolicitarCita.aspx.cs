using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ITCR.PsicoCitas.Negocios;

namespace ITCR.PsicoCitas.Interfaz
{
    public partial class vtnSolicitarCita : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

        }

        protected void btnSolicitarCita_Click(object sender, EventArgs e)
        {
            //aqui es donde se obtienen los datos y se mandan a insertar a la base
            String NombreEstudiante = txtNombreEstudiante.Text;
            String CarnetEstudiante = txtCarnetEstudiante.Text;
            String DiaSolicitud = ddlDias.Value;
            String HoraInicio = (ddlHorainicio.Value + ":" + ddlMinsInicio.Value);
            String HoraFin = (ddlHoraFin.Value + ":" + ddlMinsFin.Value);
            String Motivo;
            if (_rblMotivos.Value != "Otro")
            {
                Motivo = _rblMotivos.Value;
            }
            else { Motivo = txtOtroMotivo.Text; }
            int urgencia = Convert.ToInt32(rbtnlcategorias.SelectedIndex);

            String NomPsicologo = txtNomPersonaAtendio.Text;
            String FechaPrevia = txtfechaAtencionPrevia.Text;
            
            int Confirmacion = 0;
            if(rbtnAtencion.Value == "Si")
                Confirmacion = 1;

            String Observaciones = txtObservaciones.Value;
            DateTime fechaSolicitud = DateTime.Now;

            //se instancia la clase de solicitud de cita
            SolicitudCita solicitud = new SolicitudCita(fechaSolicitud, Motivo, urgencia, NomPsicologo, FechaPrevia, Confirmacion,
                Observaciones, DiaSolicitud, HoraInicio, HoraFin, NombreEstudiante, CarnetEstudiante);

            solicitud.crearSolicitud(solicitud);

            Response.Write("<SCRIPT>alert('Su Solicitud ha sido creada con éxito');</SCRIPT>");
            txtNombreEstudiante.Text = "";
            txtCarnetEstudiante.Text = "";
            txtNomPersonaAtendio.Text = "";
            txtfechaAtencionPrevia.Text = "";
            txtObservaciones.Value = "";
        }

        protected void btnMostrarSolicitudes_Click(object sender, EventArgs e)
        {
            Response.Redirect("vtnSolicitudesDeCitas.aspx");
        }
    }
}