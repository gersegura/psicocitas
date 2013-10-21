using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ITCR.PsicoCitas.Negocios;


namespace ITCR.PsicoCitas.Interfaz.CU
{
    public partial class InformacionPersonal1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

     

        protected void EnviarDatos_Click(object sender, EventArgs e)
        {
            

            string nombre = textoNombre.Text;
            string carne = textoCarne.Text;
            string carrera = textoCarrera.Text;
            string celular = textoCelular.Text;
            string telefono = textoTelefono.Text;
            string email = textoCorreo.Text;
            string fecha = textoFecha.Text;
            
            
            List<string> datos = new List<string>();
            datos.Add(nombre);
            datos.Add(carne);
            datos.Add(carrera);
            datos.Add(celular);
            datos.Add(telefono);
            datos.Add(email);
            datos.Add(fecha);
            nInformacionEstudiante IE = new nInformacionEstudiante();
            bool ok = IE.nInsertarInformacion(datos);

            if (ok)
                System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE='JavaScript'>alert('Informacion Envia con Exito')</SCRIPT>");
            else
            {
                System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE='JavaScript'>alert('Error al Enviar Informacion')</SCRIPT>");
            }
        }//metodo

        protected void ActualizarDatos_Click(object sender, EventArgs e)
        {
            string carne = textoCarne.Text;
            string carrera = textoCarrera.Text;
            string celular = textoCelular.Text;
            string telefono = textoTelefono.Text;
            string email = textoCorreo.Text;
            List<string> datos = new List<string>();    
            datos.Add(carne);
            datos.Add(carrera);
            datos.Add(celular);
            datos.Add(telefono);
            datos.Add(email);
            
            nInformacionEstudiante IE = new nInformacionEstudiante();
            bool ok = IE.nModificarInformacion(datos);

            if (ok)
                System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE='JavaScript'>alert('Informacion Envia con Exito')</SCRIPT>");
            else
            {
                System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE='JavaScript'>alert('Error al Enviar Informacion')</SCRIPT>");
            }
        }//metodo

        protected void InformacionAdicional_Click(object sender, EventArgs e)
        {
            
            string carne = textoCarne.Text;
            string Cambiocarrera = DropDownList1.Value;
            string consulta = DropDownList2.Value;
            string carreraAnterior = textoCarreraAnterior.Text;
            string semestre = DropDownList3.SelectedIndex.ToString();
            string ano = textoAno.Text;
            string motivo = textoMotivo.Value;
            List<string> datos = new List<string>();
            datos.Add(carne);
            datos.Add(Cambiocarrera);
            datos.Add(consulta);
            datos.Add(carreraAnterior);
            datos.Add(semestre);
            datos.Add(ano);
            datos.Add(motivo);

            nInformacionEstudiante IE = new nInformacionEstudiante();
            bool ok = IE.nInsertarInformacionAdicional(datos);

            if (ok)
                System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE='JavaScript'>alert('Informacion Envia con Exito')</SCRIPT>");
            else
            {
                System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE='JavaScript'>alert('Error al Enviar Informacion')</SCRIPT>");
            }
        }//metodo
    }

}