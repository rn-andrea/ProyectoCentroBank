<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CalCompraVehiSostenible.aspx.cs" Inherits="CentroBank.Formularios.CalCompraVehiSostenible" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
       <h2>Calculadora Compra de Vehículo Sostenible</h2>
            <label>Moneda</label>
            <asp:CheckBox ID="chbColones1" runat="server" text="colones"/>
            &nbsp;
             <asp:CheckBox ID="chbdolares1" Enabled="false" runat="server" text="dolares"/>
            <br />
            <label>Monto prestamo</label>
            <asp:TextBox ID="txtmonto1" runat="server" type="number" min="1000000" max="40000000" pattern="[0-9]+" required="true" ></asp:TextBox>
        <p>Monto mínimo 1 000 000- Monto máximo 40 000 000</p>
            <br />
             <label>Plazo</label>
            <asp:TextBox ID="txtplazo1" runat="server" type="number" min="6" max="96" pattern="[0-9]+"  required="true"></asp:TextBox>
        <p>Plazo mínimo 6 meses- Plazo máximo 96 meses</p>
            <br />
             <label>Taza</label>
            <asp:TextBox ID="txttaza1" ReadOnly="true" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnCalcular1" Text="Calcular" runat="server" Type="submit" OnClick="btnCalcular_Click" />
        <asp:Label runat="server" ID="lblmensaje1"></asp:Label>
            <br />
            <asp:TextBox ID="txtcalculo1" ReadOnly="true" runat="server" ></asp:TextBox>
    </form>
</body>
</html>
