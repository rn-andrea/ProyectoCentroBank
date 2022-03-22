using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaNegocios.Logica;
using CapaDatos.Data;

namespace CentroBank.Formularios
{
    public partial class Calculadora2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            NCalculadora cal = new NCalculadora();
            txttaza2.Text = Convert.ToString(cal.GetTasaP2());
            lblmensaje2.Text = "";
        }

        protected void btnCalcular2_Click(object sender, EventArgs e)
        {

            //DCalculadora DCAL = new DCalculadora();
            NCalculadora cal = new NCalculadora();
            CalculadoraModel calModel = new CalculadoraModel();


            if (CheckBox11.Checked = true && txtmonto2.Text != "" && txtplazo2.Text != "")
            {
                if (Convert.ToInt32(txtmonto2.Text) >= 100000 && Convert.ToInt32(txtmonto2.Text) <= 15000000)
                {
                    if (Convert.ToInt32(txtplazo2.Text) >= 6 && Convert.ToInt32(txtplazo2.Text) <= 240)
                        calModel.Monto = Convert.ToInt32(txtmonto2.Text);
                    calModel.plazo = Convert.ToInt32(txtplazo2.Text);
                    calModel.taza = float.Parse(txttaza2.Text);
                    cal.Calculo(calModel.Monto, calModel.taza, calModel.plazo);
                    decimal result = Convert.ToDecimal(cal.resultado);
                    double res = cal.resultado;
                    txtcalculo2.Text = Convert.ToString(decimal.Round(result, 2));
                }
                else
                {
                    lblmensaje2.Text = "El monto del préstamo es incorrecto";
                }

            }
            else
            {
                lblmensaje2.Text = "Debe seleccionar el tipo de moneda y completar los espacios de monto a solicitar y plazo";
            }
        }
    }
}