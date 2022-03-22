using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaNegocios.Logica;
using System.ComponentModel.DataAnnotations;
namespace ProyectoBank
{
    public partial class Solicitud : System.Web.UI.Page
    {
        solicitudLo objSoli = new solicitudLo();
        DateTime dt = new DateTime();
        //NSolicitud soli = new NSolicitud();
        protected void Page_Load(object sender, EventArgs e)
        {
            lblDateNow.Text = DateTime.Now.ToString(" dd/MM/yyyy");
            //dia de hoy
            Label1.Text = cldNacimiento.TodaysDate.ToShortDateString();
            ////CARGAR IDENTIFICACION
            //dpTipoID.DataSource = soli.GetTIposCedula();
            ////dpTipoID.DataTextField = "IdTipoIdentificacion";
            ////dpTipoID.DataValueField = "TipoIdentificaciones";
            /////
            //dpTipoID.DataTextField = "TipoIdentificaciones";
            //dpTipoID.DataValueField = "IdTipoIdentificacion";
            //dpTipoID.DataBind();
            ////////CARGAR CREDITOS
            //dpTipoCredito.DataSource = soli.GetTipoCredito();
            //dpTipoCredito.DataTextField = "TipoCredito";
            //dpTipoCredito.DataValueField = "IdTipoCreditos";
            //DataBind();

            ////CARGAR PROVINCIAS
            //dpProvincia.DataSource = soli.GetProvincia();
            //dpProvincia.DataTextField = "Provincia";
            //dpProvincia.DataValueField = "IdProvincia";
            //dpProvincia.DataBind();

        }

        protected void btnEnvioSolicitud_Click(object sender, EventArgs e)
        {

            if (((RadioButton)rbterminos).Checked & ((RadioButton)rbAutori).Checked)
            {

                if (txtid.Text.Trim().Equals("") || txtNombre.Text.Trim().Equals("") || txtapellidos.Text.Trim().Equals("") || txttelefono.Text.Trim().Equals("") || txtcorreos.Text.Trim().Equals("") || txtdirecc.Text.Trim().Equals("") || txtmonto.Text.Trim().Equals(""))
                {
                    lblerror.Text = "Completa los campos necesarios";

                } else if (objSoli.IsNumeric(txtid.Text))
                {
                    objSoli.Idu = Convert.ToInt32(txtid.Text);
                    objSoli.tipoid = dpTipoID.SelectedValue;
                    objSoli.nombre=txtNombre.Text;
                    objSoli.appelido = txtapellidos.Text;
                    objSoli.Nacimiento= cldNacimiento.SelectedDate.ToString("yyyy-dd-MM");
                    objSoli.Telefono = Convert.ToInt32(txttelefono.Text);
                    objSoli.provincia = dpProvincia.SelectedValue;
                    objSoli.correo = txtcorreos.Text;
                    objSoli.direccion = txtdirecc.Text;
                    objSoli.tipocred =Convert.ToInt32( dpTipoCredito.SelectedValue);
                    objSoli.monto = Convert.ToInt64(txtmonto.Text);
                    objSoli.FechaSoli = cldNacimiento.TodaysDate.ToString("dd-MM-yyyy");

                    if (objSoli.IsNumeric(txttelefono.Text))
                      {
                    if (objSoli.IsNumeric(txtmonto.Text)) 
                    {
                        if (new EmailAddressAttribute().IsValid(txtcorreos.Text))
                        {
                                string result= objSoli.RegistroSolicitudC(1,objSoli.Idu, objSoli.tipoid, objSoli.nombre, objSoli.appelido, objSoli.Nacimiento, objSoli.Telefono, objSoli.provincia, objSoli.correo, objSoli.direccion, objSoli.tipocred, objSoli.monto, objSoli.FechaSoli);

                                if (result.Equals("1"))
                                {
                                    lblerror.Text = "Solicitud recibida con exito";
                                }
                                else if(result.Equals("0"))
                                {
                                    lblerror.Text = "Verifica tu Identificación";
                                }
                                else if (result.Equals("00"))
                                {
                                    lblerror.Text = "Tu identificacion no es acorde al tipo de identificacion";
                                }
                                else if (result.Equals("11"))
                                {
                                    lblerror.Text = "Tu identificacion no es acorde al tipo de identificacion";
                                }
                                else if (result.Equals("02"))
                                {
                                    lblerror.Text = "Tu nombre no concuerda con el registrado";
                                }
                                else if (result.Equals("03"))
                                {
                                    lblerror.Text = "Tu apellido no concuerda con el registrado";
                                }
                                else if (result.Equals("04"))
                                {
                                    lblerror.Text = "Tu fecha de nacimiento no concuerda con el registrado";
                                }
                                else if (result.Equals("05"))
                                {
                                    lblerror.Text = "Tu telefono no concuerda con el registrado";
                                }
                                else if (result.Equals("06"))
                                {
                                    lblerror.Text = "Tu correo no concuerda con el registrado";
                                }
                                else if (result.Equals("07"))
                                {
                                    lblerror.Text = "Ha ocurrido un error intentalo mas tárde";
                                }



                            }
                        else 
                        {
                            lblerror.Text = "Dirección de correo no valida";
                        }
                    }
                    else 
                    {
                        lblerror.Text = "El monto debe conformar números";
                    }
                }
                else 
                {
                    lblerror.Text = "El telefono debe conformar números";
                }


            }
            else 
            {
                lblerror.Text = "La identificacion debe conformar números";
            }

            }
            else 
            {
                lblerror.Text = "Para continuar debes de aceptar los terminos y condiciones";
            }



            //dia seleccionado
            Label2.Text = cldNacimiento.SelectedDate.ToShortDateString();


        }




    }
}