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
    public partial class CalCompraLote : System.Web.UI.Page
    {
 

        protected void Page_Load(object sender, EventArgs e)
        {
            NCalculadora cal = new NCalculadora();
            txttaza1.Text = Convert.ToString(cal.GetTasaP9());
            lblmensaje1.Text = "";

            txtmonto1.Enabled = false;
            textmonto2.Enabled = false;
            textmonto2.Visible = false;
            txtplazo1.Enabled = false;
            btnCalcular1.Enabled = false;
            btncalc2.Visible = false;
            txtplazo2.Visible = false;

            //TextBox1.Text = Convert.ToString(cal.GetDollarp());
        }

        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            //DCalculadora DCAL = new DCalculadora();
            NCalculadora cal = new NCalculadora();
            CalculadoraModel calModel = new CalculadoraModel();




          
               
                    calModel.Monto = Convert.ToInt32(txtmonto1.Text);
                    calModel.plazo = Convert.ToInt32(txtplazo1.Text);
                    calModel.taza = float.Parse(txttaza1.Text);
                    cal.Calculo(calModel.Monto, calModel.taza, calModel.plazo);
                    decimal result = Convert.ToDecimal(cal.resultado);
                    double res = cal.resultado;
                    txtcalculo1.Text = Convert.ToString(decimal.Round(result, 2));


            







        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            txtmonto1.Enabled = true;
            textmonto2.Enabled = false;
            textmonto2.Visible = false;
            txtplazo1.Enabled = true;
            btnCalcular1.Enabled = true;
            btncalc2.Visible = false;
            txtcalculo1.Text = "";

            labelmontos.Text = "Monto mínimo 5 000 000 colones- Monto máximo 100 000 000 colones";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            textmonto2.Enabled = true;
            txtmonto1.Enabled = false;
            txtmonto1.Visible = false;
            textmonto2.Visible = true;
            txtplazo1.Enabled = true;
            btncalc2.Enabled = true;
            btnCalcular1.Visible = false;
            btncalc2.Visible = true;
            txtplazo1.Visible = false;
            txtplazo2.Visible = true;
            txtcalculo1.Text = "";
            labelmontos.Text = "Monto mínimo 7000 dolares- Monto máximo 152 000 dolares";

        }

        protected void btncalc2_Click(object sender, EventArgs e)
        {
            NCalculadora cal = new NCalculadora();

            CalculadoraModel calModel = new CalculadoraModel();



           
                
                    calModel.Monto = Convert.ToInt32(textmonto2.Text);
                    calModel.plazo = Convert.ToInt32(txtplazo2.Text);
                    calModel.taza = float.Parse(txttaza1.Text);
                    cal.Calculo(calModel.Monto, calModel.taza, calModel.plazo);
                    decimal result = Convert.ToDecimal(cal.resultado);
                    decimal rest = result * cal.GetDollarp();
                    txtcalculo1.Text = Convert.ToString(decimal.Round(rest, 2));
            btncalc2.Visible = true;
            textmonto2.Visible = true;
            txtplazo2.Visible = true;


        }
    }
}