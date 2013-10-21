using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ITCR.PsicoCitas.Negocios;

namespace ITCR.PsicoCitas.Interfaz
{
    public partial class VerDudasConsultas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CargarDudas(object sender, EventArgs e)
        {
            limpiar();
            select_dudas_pendientes.Items.Clear();
            nVerDudasConsultas IE = new nVerDudasConsultas();
            List<string> idSolicitudes = new List<string>();
            idSolicitudes= IE.nVerPendiantes();
            if (idSolicitudes.Count == 0)
            {
                System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE='JavaScript'>alert('No hay dudas Pendientes')</SCRIPT>");
            }
            else {
                for(int i = 0; i < idSolicitudes.Count ; i++)
                    select_dudas_pendientes.Items.Add(idSolicitudes[i]);
            }

        }//metodo

        protected void verDatos_Click(object sender, EventArgs e)
        {
            limpiar();
            nVerDudasConsultas ie = new nVerDudasConsultas();

            try
            {
                string sIDduda = select_dudas_pendientes.Value;
                int iIDduda = Int32.Parse(sIDduda);
                List<string> respuesta = new List<string>();
                respuesta = ie.nCargarDuda(iIDduda);
                if (respuesta.Count == 0)
                {
                    System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE='JavaScript'>alert('No se cargo correctamente, intente de nuevo')</SCRIPT>");
                }
                else
                {
                    nombreEstudiante.Text = respuesta[0];
                    edadEstudiante.Text = respuesta[1];
                    carneEstadiente.Text = respuesta[2];
                    correoEstudiante.Text = respuesta[3];
                    dudaEstudiante.Value = respuesta[4];
                }
            }
            catch {
                System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE='JavaScript'>alert('Debe selecionar un Consulta Primera')</SCRIPT>");
            }
        }//metodo


        



        protected void enviarRespuestabtn_Click(object sender, EventArgs e)
        {
            try
            {
                string sIDduda = select_dudas_pendientes.Value;
                int iIDduda = Int32.Parse(sIDduda);
                string respuesta = txtObservaciones.Value;
                if (respuesta.Equals(""))
                    System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE='JavaScript'>alert('Debe escribir una respuesta')</SCRIPT>");
                else {
                    nVerDudasConsultas ie = new nVerDudasConsultas();
                    bool ok; 
                    ok = ie.nResponderDudaEstado(iIDduda);
                    ie.nResponderDudaTexto(iIDduda, respuesta, correoEstudiante.Text);

                    if (ok)
                    {
                        System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE='JavaScript'>alert('Respuesta Exitosa')</SCRIPT>");
                    }
                    else {
                        System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE='JavaScript'>alert('Respuesta Fallida')</SCRIPT>");
                    }
                }
            }
            catch
            {
                System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE='JavaScript'>alert('Debe selecionar un Consulta Primera')</SCRIPT>");
            }
        }//metodo


        private void limpiar()
        {
            nombreEstudiante.Text = "";
            edadEstudiante.Text = "";
            carneEstadiente.Text = "";
            correoEstudiante.Text = "";
            dudaEstudiante.Value = "";
            txtObservaciones.Value = "";
        }
    }//clase
}//alcance