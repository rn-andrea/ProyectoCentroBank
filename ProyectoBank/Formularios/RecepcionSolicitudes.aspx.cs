using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaNegocios.Logica;



namespace ProyectoBank
{
    public partial class RecepcionSolicitudes : System.Web.UI.Page
    {
        NSolicitud soli = new NSolicitud();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Mostrar();
                //////CARGAR CREDITOS
                dpCreditos.DataSource = soli.GetTipoCredito();
                dpCreditos.DataTextField = "TipoCreditos1";
                dpCreditos.DataValueField = "IdTipoCreditos";
                DataBind();

            }
        }

        private void Mostrar()
        {
            gdwDatos1.DataSource = soli.MostrarRecepcion();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
             Mostrar();
        }

        protected void gdwDatos1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}