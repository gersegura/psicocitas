using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace ITCR.PsicoCitas.Interfaz
{
    public partial class AdministrarDocumentos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DirectoryInfo dirInfo = new DirectoryInfo(Server.MapPath("files"));
                FileInfo[] fileInfo = dirInfo.GetFiles("*.*", SearchOption.AllDirectories);

                GridView1.DataSource = fileInfo;
                GridView1.DataBind();
            }

        }//////////////////////7

        protected void btnSubirArchivo_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                string fullPath = Path.Combine(Server.MapPath("files"), FileUpload1.FileName);
                FileUpload1.SaveAs(fullPath);

                Response.Redirect("AdministrarDocumentos.aspx"); //se recarga la propia pagina
            }
        }//////////////////////7
        
        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            //se obtiene el nombre de campo definido en el DataKeyNames del gridview
            string fileName = Convert.ToString(GridView1.DataKeys[e.RowIndex].Value);
            //se define el path fisico del archivo
            string fullPath = Path.Combine(Server.MapPath("files"), fileName);

            File.Delete(fullPath);

            Response.Redirect("AdministrarDocumentos.aspx");

        }//////////////////////7

    }
}