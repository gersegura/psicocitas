using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace ITCR.PsicoCitas.Interfaz.GuardarEnDb
{
    public class HttpImageHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            int id = Convert.ToInt32(context.Request.Params["id"]);

            Archivo archivo = ArchivosDAL.GetById(id);

            context.Response.Clear();
            context.Response.AddHeader("content-disposition", string.Format("attachment;filename={0}", archivo.Nombre));

            switch (Path.GetExtension(archivo.Nombre).ToLower())
            {
                case ".pdf":
                    context.Response.ContentType = "application/pdf";
                    break;
                case ".doc":
                    context.Response.ContentType = "application/msword";
                    break;
                case ".xls":
                    context.Response.ContentType = "application/vnd.ms-excel";
                    break;
            }

            context.Response.BinaryWrite(archivo.ContenidoArchivo);
            context.Response.End();
        }

        public bool IsReusable
        {
            get { return false; }
        }

    }
}