<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CalUnificaciondeudas.aspx.cs" Inherits="CentroBank.Formularios.Calculadora2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
         <br />
        <br />
         <h2>Calculadora Unificación de Deudas</h2>
            <label>moneda</label>
            <asp:CheckBox ID="CheckBox11" runat="server" text="colones"/>
            &nbsp;
             <asp:CheckBox ID="CheckBox22" Enabled="false" runat="server" text="dolares"/>
            <br />
            <label>Monto préstamo</label>
            <asp:TextBox ID="txtmonto2" runat="server" type="number" min="100000" max="15000000" pattern="[0-9]+" required="true" ></asp:TextBox>
        <p>Monto mínimo 100 000- Monto máximo 15 000 000</p>
            <br />
             <label>Plazo</label>
            <asp:TextBox ID="txtplazo2" runat="server" type="number" min="6" max="240" pattern="[0-9]+"  required="true"></asp:TextBox>
        <p>Plazo mínimo 6 meses- Plazo máximo 240 meses</p>
            <br />
             <label>Taza</label>
            <asp:TextBox ID="txttaza2" ReadOnly="true" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnCalcular2" runat="server" Type="submit" Text="Calcular" OnClick="btnCalcular2_Click" />
        <asp:Label runat="server" ID="lblmensaje2"></asp:Label>
            <br />
            <asp:TextBox ID="txtcalculo2" ReadOnly="true" runat="server" ></asp:TextBox>
    </form>
</body>
</html>
