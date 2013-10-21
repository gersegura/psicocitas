using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ITCR.PsicoCitas.Negocios;


namespace ITCR.PsicoCitas.Interfaz
{
    public partial class vtnSolicitudesDeCitas : System.Web.UI.Page
    {


        private SolicitudCita cita;



        public SolicitudCita Solicitud_Cita
        {
            get { return cita; }
            set { cita = value; }
        }




        protected void Page_Load(object sender, EventArgs e)
        {
            MostrarCitas();


        }

        protected void Ver_Detalle(object sender, EventArgs e)
        {
            
            
            GridViewRow row = GridView1.SelectedRow;
            int id = (int)GridView1.DataKeys[row.RowIndex].Value;
            AccesoBase datos = new AccesoBase();
            this.Solicitud_Cita = datos.Obtener_Cita(id);

            Server.Transfer("~/AsignarPsicologo.aspx", true);

            
            
        }



        public void MostrarCitas()
        {

            CU_ModificarHorario mostrar = new CU_ModificarHorario();
            this.GridView1.DataSource = mostrar.MostrarCita();
            this.GridView1.DataBind();

        }



    }
}