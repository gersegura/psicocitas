using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ITCR.PsicoCitas.Datos;

namespace ITCR.PsicoCitas.Negocios
{
    public class nIniciarSesion
    {
        public bool nLogin(string user, string pass)
        {
            dIniciarSesion id = new dIniciarSesion();
            bool respuesta = id.dLogin(user, pass);
            if (respuesta)
                return true;
            else
                return false;
        }//metodo

    }
}
