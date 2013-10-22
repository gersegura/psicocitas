using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ITCR.PsicoCitas.Negocios;

namespace ITCR.PsicoCitas.Interfaz
{
    public partial class IniciarSesion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void iLogin_Click(object sender, EventArgs e)
        {
            string sUser = user.Text;
            string sPass = pass.Text;
            if (sUser.Equals("") || sPass.Equals(""))
            {
                System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE='JavaScript'>alert('Debe llenar todos los campos.')</SCRIPT>");
            }
            else
            {
                nIniciarSesion iniciar = new nIniciarSesion();
                bool respuesta = iniciar.nLogin(sUser, sPass);
                if (respuesta)
                    System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE='JavaScript'>alert('Correcto')</SCRIPT>");
                else
                    System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE='JavaScript'>alert('Clave Incorrecta')</SCRIPT>");
            }
        }
    }
}