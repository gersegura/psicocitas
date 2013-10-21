using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ITCR.PsicoCitas.Negocios;

namespace ITCR.PsicoCitas.Interfaz
{
    public partial class VtnEnviarConsultas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            AccesoBase ab = new AccesoBase();
            List<string> carreras = ab.nCargarCarreras();
            for (int i = 0; i < carreras.Count; i++) 
            {
                SelectCarreras.Items.Add(carreras[i]);
            }

        }

        protected void enviarRespuestabtn_Click(object sender, EventArgs e)
        {
            AccesoBase ab = new AccesoBase();
            String nombreEst = nombreEstudiante.Text;
            int edadEst = Convert.ToInt32(edadEstudiante.Text);
            int carreraEst = SelectCarreras.SelectedIndex;
            int carnetEst = Convert.ToInt32(carneEstadiente.Text);
            String correoEst = correoEstudiante.Text;
            String dudaEst = dudaEstudiante.Value;
            int estadoEst = 0;
            ab.insertarDuda(nombreEst, edadEst, (carreraEst + 1), carnetEst, correoEst, dudaEst, estadoEst);
            System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE='JavaScript'>alert('Consulta Realizada con éxito.')</SCRIPT>");

            nombreEstudiante.Text = "";
            edadEstudiante.Text = "";
            carneEstadiente.Text = "";
            correoEstudiante.Text = "";
            dudaEstudiante.Value = "";


        }
    }
}