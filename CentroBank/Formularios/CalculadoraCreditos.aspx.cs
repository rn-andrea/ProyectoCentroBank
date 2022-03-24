using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaNegocios;
using CapaNegocios.Logica;
using CentroBank.Model;

namespace CentroBank.Formularios
{
    public partial class CalCompraLote : System.Web.UI.Page
    {
 

        protected void Page_Load(object sender, EventArgs e)
        {
            NCalculadora cal = new NCalculadora();
           // txttaza1.Text = Convert.ToString(cal.GetTasaP9());
            
            if (!IsPostBack)
            {
                lblmensaje1.Text = "";

                dpCreditos.DataSource = cal.GetCreditos();
                dpCreditos.DataTextField = "TipoCredito";
                dpCreditos.DataValueField = "TipoCredito";
                dpCreditos.DataBind();

              
                string tipo = dpCreditos.SelectedValue;
                txttaza1.Text = Convert.ToString(cal.GetTasaP1(tipo));
                labelmontos.Text = "Mínimo: ₡250 000/ $400 Máximo: ₡15 000 000/ $23000 ";
                labelplazo.Text = "Plazo de 6 a 240 meses";
                txtcalculo1.Text = "";
                lblmensaje1.Text = "";
            }

        }

        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            //DCalculadora DCAL = new DCalculadora();
            NCalculadora cal = new NCalculadora();
            CalculadoraModel calModel = new CalculadoraModel();

            lblmensaje1.Text = "";
            string crediSelect= dpCreditos.SelectedValue;
            string monedaSelect = dpDatos.SelectedItem.Value;

            if (monedaSelect == "1")
            {
                int valor = cal.LimiteDinero(crediSelect,float.Parse( txtmonto1.Text));
                int val = cal.LimitePlazo(crediSelect, int.Parse(txtplazo1.Text));
                if (valor == 1)
                {
                    if(val == 1)
                    {
                        calModel.Monto = Convert.ToInt32(txtmonto1.Text);
                        calModel.plazo = Convert.ToInt32(txtplazo1.Text);
                        calModel.taza = float.Parse(txttaza1.Text);
                        cal.Calculo(calModel.Monto, calModel.taza, calModel.plazo);
                        decimal result = Convert.ToDecimal(cal.resultado);
                        double res = cal.resultado;
                        txtcalculo1.Text = "₡"+ Convert.ToString(decimal.Round(result, 2));
                    }
                    else
                    {
                        lblmensaje1.Text = "El valor del plazo es incorrecto";
                    }
                    
                }
                else
                {
                    lblmensaje1.Text = "El monto solicitado no cumple con los limites minímos o máximos del tipo de crédito";
                }
            }else if(monedaSelect=="2")
            {
                
                int valor2 = cal.LimiteDineroD(crediSelect, float.Parse(txtmonto1.Text));
                int val = cal.LimitePlazo(crediSelect, int.Parse(txtplazo1.Text));
                if (valor2 == 1)
                {
                    if (val == 1)
                    {
                        calModel.Monto = Convert.ToInt32(txtmonto1.Text);
                        calModel.plazo = Convert.ToInt32(txtplazo1.Text);
                        calModel.taza = float.Parse(txttaza1.Text);
                        calModel.taza = float.Parse(txttaza1.Text);
                        cal.Calculo(calModel.Monto, calModel.taza, calModel.plazo);
                        decimal result = Convert.ToDecimal(cal.resultado) * cal.GetDollarp();

                        txtcalculo1.Text = "₡"+Convert.ToString(decimal.Round(result, 2));
                    }
                    else
                    {
                        lblmensaje1.Text = "El valor del plazo es incorrecto";
                    }
                   
                }
                else
                {
                    lblmensaje1.Text = "El monto solicitado no cumple con los limites minímos o máximos del tipo de crédito";
                }
                //dolares
            }
           

           



        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           

           // labelmontos.Text = "Monto mínimo 5 000 000 colones- Monto máximo 100 000 000 colones";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            
           // labelmontos.Text = "Monto mínimo 7000 dolares- Monto máximo 152 000 dolares";

        }

        protected void btncalc2_Click(object sender, EventArgs e)
        {
        


        }

        protected void txtmonto1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        protected void dpDatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        protected void dpCreditos_TextChanged(object sender, EventArgs e)
        {
           
           
        }

        protected void Dp(object sender, EventArgs e)
        {
           
            NCalculadora cal = new NCalculadora();
            string tipo = dpCreditos.SelectedValue;
            txttaza1.Text = Convert.ToString(cal.GetTasaP1(tipo));
            txtcalculo1.Text = "";
            lblmensaje1.Text = "";
            if (tipo == "Préstamo Personal")
            {
                labelmontos.Text = "Mínimo: ₡250 000/ $400 Máximo: ₡15 000 000/ $23000 ";
                labelplazo.Text = "Plazo de 6 a 240 meses";

            }
            else if (tipo == "Unificación de deudas")
            {
                labelmontos.Text = "Mínimo: ₡100 000/ $200 Máximo: ₡15 000 000/ $23000 ";
                labelplazo.Text = "Plazo de 6 a 60 meses";
            }
            else if (tipo == "MiniCredito")
            {
                labelmontos.Text = "Mínimo: ₡100 000/ $200 Máximo: ₡650 000/ $1 000 ";
                labelplazo.Text = "Plazo de 6 a 60 meses";

            }
            else if (tipo == "Préstamo Multiproposito")
            {
                labelmontos.Text = "Mínimo: ₡1 000 000/ $1500 Máximo: ₡40 000 000/ $62 000 ";
                labelplazo.Text = "Plazo de 6 a 240 meses";
            }
            else if (tipo == "Compra Vehículos")
            {
                labelmontos.Text = "Mínimo: ₡1 000 000/ $1500 Máximo: ₡40 000 000/ $62 000 ";
                labelplazo.Text = "Plazo de 6 a 96 meses";
            }
            else if (tipo == "Vehículo Sostenible")
            {
                labelmontos.Text = "Mínimo: ₡1 000 000/ $1500 Máximo: ₡40 000 000/ $62 000 ";
                labelplazo.Text = "Plazo de 6 a 96 meses";
            }
            else if (tipo == "Leasing Financiero")
            {
                labelmontos.Text = "Mínimo: ₡1 000 000/ $1500 Máximo: ₡40 000 000/ $62 000 ";
                labelplazo.Text = "Plazo de 6 a 96 meses";

            }
            else if (tipo == "Compra Vivienda")
            {
                labelmontos.Text = "Mínimo: ₡5 000 000/ $7500 Máximo: ₡100 000 000/ $152 000 ";
                labelplazo.Text = "Plazo de 120 a 360 meses";
            }
            else if (tipo == "Compra Lote")
            {
                labelmontos.Text = "Mínimo: ₡5 000 000/ $7500 Máximo: ₡100 000 000/ $152 000 ";
                labelplazo.Text = "Plazo de 120 a 360 meses";
            }
            else if (tipo == "Traslado de Hipoteca")
            {
                labelmontos.Text = "Mínimo: ₡5 000 000/ $7500 Máximo: ₡100 000 000/ $152 000 ";
                labelplazo.Text = "Plazo de 120 a 360 meses";
            }
        }

        protected void txtcha(object sender, EventArgs e)
        {
            txtcalculo1.Text = "";
            lblmensaje1.Text = "";
            txtmonto1.Text = "";
            txtplazo1.Text = "";
        }
    }
}