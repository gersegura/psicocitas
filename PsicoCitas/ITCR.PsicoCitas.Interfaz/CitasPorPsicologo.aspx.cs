using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ITCR.PsicoCitas.Negocios;

namespace ITCR.PsicoCitas.Interfaz
{
    public partial class CitasPorPsicologo : System.Web.UI.Page
    {



        private SolicitudCita cita;



        public SolicitudCita Solicitud_Cita
        {
            get { return cita; }
            set { cita = value; }
        }
        
        
        
        
        
        
        
        protected void Page_Load(object sender, EventArgs e)
        {

            
            
            if (!IsPostBack)
            {
                AccesoBase nuevoacceso = new AccesoBase();

                ddlPsicologos.DataSource = nuevoacceso.Obtener_Asesores();
                ddlPsicologos.DataTextField = "Nombre";
                ddlPsicologos.DataValueField = "ID";
                ddlPsicologos.DataBind();





            }
        }



        protected void Ver_Detalle(object sender, EventArgs e)
        {


            GridViewRow row = GridView1.SelectedRow;
            int id = (int)GridView1.DataKeys[row.RowIndex].Value;
            AccesoBase datos = new AccesoBase();
            this.Solicitud_Cita = datos.Obtener_Cita(id);

            Server.Transfer("~/vtnAsignarCita.aspx", true);

            // Response.Redirect("");

        }


        



        public void MostrarCitas(object sender, EventArgs e)
        {

            CU_ModificarHorario mostrar = new CU_ModificarHorario();
            int id_asesor = Convert.ToInt32(ddlPsicologos.SelectedItem.Value);
            this.GridView1.DataSource = mostrar.MostrarCitaAsesor(id_asesor);
            this.GridView1.DataBind();

        }


    }
}