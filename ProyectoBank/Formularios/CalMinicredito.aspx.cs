using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaNegocios;
using CapaNegocios.Logica;
using CapaDatos.Data;

namespace CentroBank.Formularios
{
    public partial class Calculadora3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            NCalculadora cal = new NCalculadora();
            txttaza1.Text = Convert.ToString(cal.GetTasaP3());
            lblmensaje1.Text = "";
        }

        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            //DCalculadora DCAL = new DCalculadora();
            NCalculadora cal = new NCalculadora();
            CalculadoraModel calModel = new CalculadoraModel();


            if (chbColones1.Checked = true && txtmonto1.Text != "" && txtplazo1.Text != "")
            {
                if (Convert.ToInt32(txtmonto1.Text) >= 100000 && Convert.ToInt32(txtmonto1.Text) <= 650000)
                {
                    if (Convert.ToInt32(txtplazo1.Text) >= 6 && Convert.ToInt32(txtplazo1.Text) <= 60)
                        calModel.Monto = Convert.ToInt32(txtmonto1.Text);
                    calModel.plazo = Convert.ToInt32(txtplazo1.Text);
                    calModel.taza = float.Parse(txttaza1.Text);
                    cal.Calculo(calModel.Monto, calModel.taza, calModel.plazo);
                    decimal result = Convert.ToDecimal(cal.resultado);
                    double res = cal.resultado;
                    txtcalculo1.Text = Convert.ToString(decimal.Round(result, 2));
                }
                else
                {
                    lblmensaje1.Text = "El monto del préstamo es incorrecto";
                }

            }
            else
            {
                lblmensaje1.Text = "Debe seleccionar el tipo de moneda y completar los espacios de monto a solicitar y plazo";
            }
        }
    }
}