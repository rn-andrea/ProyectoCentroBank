<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Solicitud.aspx.cs" Inherits="ProyectoBank.Solicitud" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 25px;
        }
        .auto-style3 {
            height: 30px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style3">Tipo de Identificacion<asp:DropDownList ID="dpTipoID" runat="server">
                    <asp:ListItem>Cédula Nacional</asp:ListItem>
                    <asp:ListItem>DIMEX</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>Identificacion<asp:TextBox ID="txtid" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Nombre<asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Apellidos<asp:TextBox ID="txtapellidos" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Fecha de Nacimiento<asp:Calendar ID="cldNacimiento" SelectionMode="DayWeekMonth" runat="server"></asp:Calendar>
                </td>
            </tr>
        </table>
        <table class="auto-style1">
            <tr>
                <td>Telefono<asp:TextBox ID="txttelefono" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Provincia<asp:DropDownList ID="dpProvincia" runat="server">
                    <asp:ListItem Value="San José">San José</asp:ListItem>
                    <asp:ListItem Value="Alajuela">Alajuela</asp:ListItem>
                    <asp:ListItem Value="Cartago">Cartago</asp:ListItem>
                    <asp:ListItem Value="Guanacaste">Guanacaste</asp:ListItem>
                    <asp:ListItem Value="Heredia">Heredia</asp:ListItem>
                    <asp:ListItem Value="Limon">Limon</asp:ListItem>
                    <asp:ListItem Value="Puntarenas">Puntarenas</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>Correo<asp:TextBox ID="txtcorreos" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Direccion<asp:TextBox ID="txtdirecc" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Tipo de credito<asp:DropDownList ID="dpTipoCredito" runat="server">
                    <asp:ListItem Value="1">Préstamo Personal</asp:ListItem>
                    <asp:ListItem Value="2">Unificacion de deudas</asp:ListItem>
                    <asp:ListItem Value="3">MiniCredito</asp:ListItem>
                    <asp:ListItem Value="4">Prestamo MultiProposito</asp:ListItem>
                    <asp:ListItem Value="5">Compra Vehículo</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>Monto&nbsp; a solicitar<asp:TextBox ID="txtmonto" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Fecha de Solicitud<asp:Label ID="lblDateNow" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
        <table class="auto-style1">
            <tr>
                <td>
                    <asp:RadioButton ID="rbterminos" runat="server" Text="He leido y acepto los terminos y condiciones de Centro Bank" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:RadioButton ID="rbAutori" runat="server" Text="Autorizo a Centro Bank a realizar un estudio de salario" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Su solicitud sera revisada y se le notificara en un plazo de 15 dias habiles</td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnEnvioSolicitud" runat="server"  Text="Enviar solicitud" OnClick="btnEnvioSolicitud_Click" />
                    <br />
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                    <br />
                    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                    <br />
                    <asp:Label ID="lblerror" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
