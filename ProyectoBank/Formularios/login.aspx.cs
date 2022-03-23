using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaNegocios.Clases;
using CapaNegocios.Logica;

namespace ProyectoBank
{
    public partial class login : System.Web.UI.Page
    {
        loginLo objLogico = new loginLo();
        mailLo objmail = new mailLo();
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnloguearse_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    //if (dropRol.SelectedValue.Equals("Usuario"))
            //    //{
            //        if (objLogico.IsNumeric(txtUser.Text))
            //        {
            //            if (objLogico.ContraSafe(txtcontra.Text))
            //            {
            //                objLogico.Contra = txtcontra.Text;
            //                objLogico.Id = Convert.ToInt32(txtUser.Text);
            //                //objVaU.ID = txtUser.Text;
            //                //objVaU.Contraseña= txtpassword.Text;
            //                //Session["RolU"] = _objValidarU.RetornarIdUsuario(_obj_usuario.IdU, _obj_usuario.Contra);
            //                String Resultado = objLogico.ValidarUsuario(objLogico.Id, objLogico.Contra);

            //                if (Resultado.Equals("0"))
            //                {
            //                    lblerror.Text = "Usuario y/o contraseña incorrectos";

            //                }
            //                else if (Resultado.Equals("1"))
            //                {

            //                    //objLogico.GrabarCliente();

            //                    lblerror.Text = "Credenciales correctas";
            //                    Response.Redirect("Solicitud.aspx");
            //                }
            //            }
            //            else
            //            {
            //                lblerror.Text = "La contraseña debe de tener una mayuscula, minuscula, caracter y número";
            //            }

            //        }
            //        else
            //        {
            //            lblerror.Text = "Usuario y/o contraseña incorrectos";
            //        }

            //    //}
            //}
            //catch (Exception ex)
            //{

            //    throw ex;
            //}
        }

        protected void btnemail_Click(object sender, EventArgs e)
        {
            ////creamos nuestra lista de archivos a enviar
            //List<string> lstArchivos = new List<string>();
            //lstArchivos.Add("c:/english.txt");
            ////lstArchivos.Add("c:/english.pdf");

            ////creamos nuestro objeto de la clase que hicimos
            //objmail.Mail("raigna1212@gmail.com", "danimendeza00@gmail.com",
            //                    "hola", "un mensaje bien chevere", lstArchivos);

            ////y enviamos
            //if (objmail.enviaMail())
            //{
            //    lblerror.Text = "se envio el mail";

            //}
            //else
            //{
            //    lblerror.Text = "no se envio el mail: " + objmail.error;

            //}


            //if (objmail.envioE())
            //{
            //    lblerror.Text = "SIRVIO TSS";
            //}
            //else 
            //{
            //    lblerror.Text = "EROR TSS";
            //}
            


        }

        protected void btnloguearse_Click1(object sender, EventArgs e)
        {
            try
            {
                //if (dropRol.SelectedValue.Equals("Usuario"))
                //{
                if (objLogico.IsNumeric(txtUser.Text))
                {
                    if (objLogico.ContraSafe(txtcontra.Text))
                    {
                        objLogico.Contra = txtcontra.Text;
                        objLogico.Id = Convert.ToInt32(txtUser.Text);
                        //objVaU.ID = txtUser.Text;
                        //objVaU.Contraseña= txtpassword.Text;
                        //Session["RolU"] = _objValidarU.RetornarIdUsuario(_obj_usuario.IdU, _obj_usuario.Contra);
                        String Resultado = objLogico.ValidarUsuario(objLogico.Id, objLogico.Contra);

                        if (Resultado.Equals("0"))
                        {
                            lblerror.Text = "Usuario y/o contraseña incorrectos";

                        }
                        else if (Resultado.Equals("1"))
                        {

                            //objLogico.GrabarCliente();

                            lblerror.Text = "Credenciales correctas";
                            Response.Redirect("Solicitud.aspx");
                        }
                    }
                    else
                    {
                        lblerror.Text = "La contraseña debe de tener una mayuscula, minuscula, caracter y número";
                    }

                }
                else
                {
                    lblerror.Text = "Usuario y/o contraseña incorrectos";
                }

                //}
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        protected void btnemail_Click1(object sender, EventArgs e)
        {
            //creamos nuestra lista de archivos a enviar
            List<string> lstArchivos = new List<string>();
            lstArchivos.Add("c:/english.txt");
            //lstArchivos.Add("c:/english.pdf");

            //creamos nuestro objeto de la clase que hicimos
            objmail.Mail("raigna1212@gmail.com", "danimendeza00@gmail.com",
                                "hola", "un mensaje bien chevere", lstArchivos);

            //y enviamos
            if (objmail.enviaMail())
            {
                lblerror.Text = "se envio el mail";

            }
            else
            {
                lblerror.Text = "no se envio el mail: " + objmail.error;

            }


            if (objmail.envioE())
            {
                lblerror.Text = "SIRVIO TSS";
            }
            else
            {
                lblerror.Text = "EROR TSS";
            }
        }
    }
}