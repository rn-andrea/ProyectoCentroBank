<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="indicadores.aspx.cs" Inherits="ProyectoBank.Formularios.indicadores" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:TextBox ID="txtindi" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnindica" runat="server" Text="Button" OnClick="btnindica_Click" />

        </div>
    </form>
</body>
</html>
