﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CalCompraLote.aspx.cs" Inherits="CentroBank.Formularios.CalCompraLote" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
          <h2>Calculadora Compra de Vivienda</h2>
            <label>Moneda</label>
          <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Colones" causesvalidation="false"/>
          <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Dolares" causesvalidation="false"/>
            <br />
            <label>Monto prestamo</label>
            <asp:TextBox ID="txtmonto1" runat="server" type="number" min="5000000" max="100000000" pattern="[0-9]+" required="true" ></asp:TextBox>
        <asp:TextBox ID="textmonto2" runat="server" type="number" min="7000" max="1520000" pattern="[0-9]+" required="true" ></asp:TextBox>
        <asp:Label ID="labelmontos" runat="server"></asp:Label>

            <br />
             <label>Plazo</label>
            <asp:TextBox ID="txtplazo1" runat="server" type="number" min="12" max="360" pattern="[0-9]+" required="true" ></asp:TextBox>
         <asp:TextBox ID="txtplazo2" runat="server" type="number" min="12" max="360" pattern="[0-9]+" required="true"></asp:TextBox>
        <p>Plazo mínimo 12 meses- Plazo máximo 360 meses</p>
            <br />
             <label>Taza</label>
            <asp:TextBox ID="txttaza1" ReadOnly="true" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnCalcular1" Text="Calcular" runat="server" Type="submit" OnClick="btnCalcular_Click" />
         <asp:Button ID="btncalc2" Text="Calcular" runat="server" Type="submit" OnClick="btncalc2_Click" />
        <asp:Label runat="server" ID="lblmensaje1"></asp:Label>
            <br />
            <asp:TextBox ID="txtcalculo1" ReadOnly="true" runat="server" Text="Cuota en colones" ></asp:TextBox>


         

    </form>
</body>
</html>
