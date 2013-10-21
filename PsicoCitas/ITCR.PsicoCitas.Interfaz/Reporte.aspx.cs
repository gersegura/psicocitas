using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ITCR.PsicoCitas.Negocios;

namespace ITCR.PsicoCitas.Interfaz
{
    public partial class Reporte : System.Web.UI.Page
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
                ddlreporte.Items.Add("Reporte 1");
                ddlreporte.Items.Add("Reporte 2");
            




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






        public void mostrardetalle(object sender, EventArgs e)
        {


            if (ddlreporte.SelectedItem.Text.Equals("Reporte 1"))
            { lbldescripcion.Text = "Citas atendidas por cada asesor en un determinado tiempo"; }

            if (ddlreporte.SelectedItem.Text.Equals("Reporte 2"))
            { lbldescripcion.Text = "Solicitudes recibidas por carrera en un determinado tiempo"; }




          /*  CU_ModificarHorario mostrar = new CU_ModificarHorario();
            int id_asesor = Convert.ToInt32(ddlPsicologos.SelectedItem.Value);
            this.GridView1.DataSource = mostrar.MostrarCitaAsesor(id_asesor);
            this.GridView1.DataBind();*/

        }

        protected void btngenerar_Click(object sender, EventArgs e)
        {
             CU_ModificarHorario mostrar = new CU_ModificarHorario();
             String fechainicio = Calendar1.SelectedDate.ToString();
             String fechafin = Calendar2.SelectedDate.ToString();
             String reporte = ddlreporte.SelectedItem.Text;
             this.GridView1.DataSource = mostrar.reporte(reporte,fechainicio, fechafin);

           
            this.GridView1.DataBind();

            


        }


    }
}