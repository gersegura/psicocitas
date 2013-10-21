﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace ITCR.PsicoCitas.Interfaz
{
    public partial class Download : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string filename = Request.QueryString["filename"].ToString();

            Response.Clear();

            Response.AddHeader("content-disposition", string.Format("attachment;filename={0}", filename));
            Response.ContentType = "application/octet-stream";

            Response.WriteFile(Server.MapPath(Path.Combine("~/files", filename)));

            Response.End();
        }
    }
}