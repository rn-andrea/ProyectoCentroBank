<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="ProyectoBank.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {}
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblUser" runat="server" Text="USUARIO"></asp:Label>
            <asp:TextBox ID="txtUser" runat="server"></asp:TextBox>
            <br />
             <asp:Label ID="lblcontra" runat="server" Text="Contraseña"></asp:Label>
            <asp:TextBox ID="txtcontra" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnloguearse" runat="server" Text="Ingresar" CssClass="auto-style1" OnClick="btnloguearse_Click" />

            <br />
            <asp:Label ID="lblerror" runat="server" Text=""></asp:Label>
            <br />
            <asp:Button ID="btnemail" runat="server" OnClick="btnemail_Click" Text="EMAIL" />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
