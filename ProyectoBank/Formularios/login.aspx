<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="ProyectoBank.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
  <meta charset="UFT-8"/>
  <meta name="viewport" content="with=divice-with, inicial-scale=1.0"/>
  <meta http-equiv="X-UA-Compatible" content="id-edge"/>
  <title>Centro Bank</title>
    <link href="css/style.css" rel="stylesheet" />
    
  <!--Import Google Icon Font-->
  <link href="https://fonts.googleapis.com/icon?family=Material+Icons" rel="stylesheet"/>




  <!-- Compiled and minified CSS -->
   <link rel="stylesheet" href="../CSS/materialize.min.css" />
 
  <!--letra-->
  <link href="https://fonts.googleapis.com/css2?family=Nunito&display=swap" rel="stylesheet"/>
</head>
<body>
     <form id="form1" runat="server">
     <!-- inicio menu -->
  <div class="contenedor">
    <div class="navbar-fixed">
      <nav class="white" style="padding: 0px 18px; ">
      <div class="navbar-wrapper">
        <ul id="dropdown1" class="dropdown-content">
          <li><a style="  font-family: 'Nunito', sans-serif;font-weight: 600; font-size: large;color: #303F9F;color: #303F9F; font-size: large;" href="/frmCreditosPersonales.aspx">Créditos Personales</a></li>
          <li class="divider"></li>
          <li><a style=" font-family: 'Nunito', sans-serif;font-weight: 600; font-size: large; color: #303F9F;font-size: large;"  href="/frmCreditosVehiculos.aspx">Créditos de Vehículos</a></li>
          <li class="divider"></li>
          <li><a  style="  font-family: 'Nunito', sans-serif;font-weight: 600; font-size: large; color: #303F9F; font-size: large;" href="/frmCreditosVivienda.aspx">Créditos de Vivienda</a></li>
        </ul>
        
  
            <a href="#" class="brand-logo"> <img src="../img/logoCentroBank.png" height="54"
                style="vertical-align: middle;"/></a>
            <a href="#" class="sidenav-trigger" data-target="mobile-demo">
              <i class="material-icons indigo darken-2">menu</i>
            </a>
            <ul id="nav-menu" class=" right hide-on-med-and-down">
              <li><a  style="  font-family: 'Nunito', sans-serif;font-weight: 700; font-size: large;color: #303F9F; font-size: large;"  href="/Index.aspx">Inicio</a></li>
              <li><a style=" font-family: 'Nunito', sans-serif;font-weight: 700; font-size: large; color: #303F9F; font-size: large;"  class="dropdown-trigger" href="#!" data-target="dropdown1">Créditos<i
                    class="material-icons right">arrow_drop_down</i></a></li>
              <li><a  style=" font-family: 'Nunito', sans-serif;font-weight: 700; font-size: large; color: #303F9F;font-size: large;"  href="/frmCalculadoradeCreditos.aspx">Calculadora de créditos</a></li>
              <li><a style="  font-family: 'Nunito', sans-serif;font-weight: 700; font-size: large; color: #303F9F;font-size: large;"  href="/frmContactenos.aspx">Contáctenos</a></li>
              <li><a style=" font-family: 'Nunito', sans-serif;font-weight: 700; font-size: large; color: #303F9F; font-size: large;"  href="/frmLogin.aspx"><i class="material-icons large">person</i></a></li>

            </ul>
          </div>
         </nav>
      </div>
      </div>

      <ul class="sidenav" id="mobile-demo">
        <li><a style=" font-family: 'Nunito', sans-serif;font-weight: 700; font-size: large; color: #303F9F; font-size: large;" href="/Index.aspx">Inicio</a></li>
        <li><a style=" font-family: 'Nunito', sans-serif;font-weight: 600; font-size: large; color: #303F9F; font-size: large;" href="/frmCreditosPersonales.aspx">Créditos</a></li>
        <li><a style=" font-family: 'Nunito', sans-serif;font-weight: 600; font-size: large; color: #303F9F; font-size: large;" class="nunito" href="/frmCalculadoradeCreditos.aspx">Calculadora de créditos</a></li>
        <li><a style=" font-family: 'Nunito', sans-serif;font-weight: 600; font-size: large; color: #303F9F; font-size: large;" class="nunito" href="/frmContactenos.aspx">Contáctenos</a></li>
      </ul>
  
  <!-- fin menu -->
    <!--raya color azul debajo del navbar-->
<div id="contenedor1"></div>
<!--fin raya color azul debajo del navbar-->
<div id="espacio"></div>

<div id="contenedor3">
    <div class="row">
        <div class="col s1 l2"><p></p></div>
        <div class="col s10 l8 indigo lighten-5">
            <div class="row">
                <div class="col s1 l2 "><p></p></div>
                <div class="col s10 l8 ">

                    <h4>Iniciar sesión</h4>
                    <div class="row">
                        <div class="col s1 l2 "><p></p></div>
            
                        <div class="col s8 l8 ">
                           
                            <div class="row">
                                <div class="col s3 l3 "><p></p></div>
                                <div class="col s5 l5 ">
                                    <img class="responsive-img" src="../img/2919600.png" style="height: 150px;margin-left: 25px; margin-top: 10px; margin-bottom: 10px;"/>
                                </div>
                               
                            </div>
                           
                            <h8>Identificación</h8>
                                <div class="input-field">
                                    <%--<asp:TextBox ID="txtUser"  style="border-radius: 8px; border-color: grey darken-1;  border-width: 2px; " class="validate white "runat="server" ></asp:TextBox>--%>
                                    <asp:TextBox ID="txtUser" style="border-radius: 8px; border-color: grey darken-1; border-width: 2px;"  class="validate white" runat="server"></asp:TextBox>
                                    </div>
                              
                            <h8>Contraseña</h8>
                            <div class="input-field">
                                <asp:TextBox ID="txtcontra" style="border-radius: 8px; border-color: grey darken-1; border-width: 2px;"  class="validate white" runat="server"></asp:TextBox>
                               </div> 
                            <div id="espacio"></div>
                            <div class="row">
                                <div class="col s4 l4 "><p></p></div>
                                <%--<div class="col s6 l6 ">--%>

                                    <asp:Button ID="btnloguearse" runat="server" class="waves-effect waves-gray btn amber accent-2 indigo-text" Text="Loguearse" OnClick="btnloguearse_Click1" />
                                <br />
                                <asp:Label ID="lblerror" runat="server" Text=""></asp:Label>
                                <br />
                                <asp:Button ID="btnemail" runat="server" Text="email" OnClick="btnemail_Click1" />

                                    
                                <%--</div>--%>
                               
                                <br />
                               
                            </div>
                            
                        </div>
                        <div class="col s1 l2 ">
                          
                        </div>


                    </div>
                    
                </div>
                <div class="col s1 l1">
                  
                </div>
            </div>
        </div>
        <div class="col s1 l2">
           
        </div>
      </div>
</div>


<div id="espacio"></div>


<!--inicio footer--> 

<footer class="page-footer indigo darken-2 ">
    <div class="container indigo darken-2 ">
      <div class="row indigo darken-2 ">
        <div class="col l6 s12 indigo darken-2 ">
            <p></p>
            <p></p>
            <p></p>
            <p></p>
            <p></p>
            <p></p>
            <img class=" responsive-img" src="../img/logoCentroBank.png" height="60" />
        </div>
        <div class="col l4 offset-l2 s12 indigo darken-2 ">
          <h5 class="white-text">Links</h5>
          <ul>
            <li><a style="font-family: 'Nunito', sans-serif;font-weight: 600; font-size: large;" href="#!">Inicio</a></li>
            <li><a style="font-family: 'Nunito', sans-serif;font-weight: 600; font-size: large;" href="#!">Créditos</a></li>
            <li><a style="font-family: 'Nunito', sans-serif;font-weight: 600; font-size: large;" href="#!">Calculadora de Créditos</a></li>
            <li><a style="font-family: 'Nunito', sans-serif;font-weight: 600; font-size: large;" href="#!">Iniciar Sesión</a></li>
          </ul>
        </div>
      </div>
    </div>
    <div class="footer-copyright indigo">
      <div class="container text-lighten-4">
        © 2022 Centro Bank de Costa Rica. Todos los derechos reservados.
      </div>
    </div>
  </footer>
<!--fin footer--> 


    <!-- Compiled and minified JavaScript -->
    <script src="https://cdnjs.cloudflare.com/ajax/libs/materialize/1.0.0/js/materialize.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.6.0/jquery.min.js"> </script>
    <script>
        M.AutoInit();
    </script>
      <script type="text/javascript" src="js/materialize.min.js"></script>
   </form>
</body>
</html>
