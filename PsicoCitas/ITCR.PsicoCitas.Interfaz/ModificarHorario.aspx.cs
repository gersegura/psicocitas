using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ITCR.PsicoCitas.Interfaz
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {


                //LLenar drowlist Dias1
                #region LLenar drownlist Dias1
                DropDownList1.Items.Add("Todos");
                DropDownList1.Items.Add("Lunes");
                DropDownList1.Items.Add("Martes");
                DropDownList1.Items.Add("Miercoles");
                DropDownList1.Items.Add("Jueves");
                DropDownList1.Items.Add("Viernes");

                #endregion
                Mostrardia("");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            CU_ModificarHorario agregar = new CU_ModificarHorario();
            string dia = Dias2.Value;
            string horainicio = horainicio2.Value + ":" + MinutosInicio.Value;
            string horafinal = HoraFinal.Value + ":" + MinutosFinal.Value;
            agregar.InsertaBloque(dia, horainicio, horafinal);
            Mostrardia("");//refrescar la pagina
            
        }

        public void Cambiardia(object sender, EventArgs e)
        {
            string diacambiado = DropDownList1.Text;
            if (diacambiado.Equals("Todos"))
            {
                diacambiado = "";//Esto se hace para script de base de datos muestre todo
            }
            Mostrardia(diacambiado);
        }

        public void Mostrardia(string dia)
        {

                CU_ModificarHorario mostrar = new CU_ModificarHorario();
                this.GridView1.DataSource = mostrar.MostrarBloque(dia);
                this.GridView1.DataBind();

        }

        protected void Eliminar_Bloque(object sender, EventArgs e)
        {
            GridViewRow row = GridView1.SelectedRow;
            int id = (int)GridView1.DataKeys[row.RowIndex].Value;
            CU_ModificarHorario eliminar = new CU_ModificarHorario();
            eliminar.EliminarBloque(id);
            Mostrardia("");//refrescar la pagina   
        }
    }
}