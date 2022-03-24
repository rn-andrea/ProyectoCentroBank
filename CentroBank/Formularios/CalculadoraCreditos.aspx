<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CalculadoraCreditos.aspx.cs" Inherits="CentroBank.Formularios.CalCompraLote" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
          <h2>Seleccione el tipo de credito    </h2>
        <asp:DropDownList ID="dpCreditos" runat="server" OnSelectedIndexChanged="Dp" OnTextChanged="dpCreditos_TextChanged" AutoPostBack="true">
              </asp:DropDownList>
      
            <label>Moneda</label>
          <asp:DropDownList ID="dpDatos" runat="server" OnSelectedIndexChanged="dpDatos_SelectedIndexChanged" OnTextChanged="txtcha" AutoPostBack="true">
              <asp:ListItem Value="1">Colones</asp:ListItem>
              <asp:ListItem Value="2">Dolares</asp:ListItem>
          </asp:DropDownList>
            <br />
            <label>Monto prestamo</label>
            <asp:TextBox ID="txtmonto1" runat="server" type="number" pattern="[0-9]+" required="true" OnTextChanged="txtmonto1_TextChanged" ></asp:TextBox>
        <asp:Label ID="labelmontos" runat="server"></asp:Label>

            <br />
             <label>Plazo</label>
            <asp:TextBox ID="txtplazo1" runat="server" type="number" pattern="[0-9]+" required="true" ></asp:TextBox>
       <asp:Label ID="labelplazo" runat="server"></asp:Label>
       
            <br />
             <label>Tasa (%)</label>
            <asp:TextBox ID="txttaza1" ReadOnly="true" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnCalcular1" Text="Calcular" runat="server" Type="submit" OnClick="btnCalcular_Click" />
        <asp:Label runat="server" ID="lblmensaje1"></asp:Label>
            <br />

            <asp:TextBox ID="txtcalculo1" ReadOnly="true" runat="server" Text="Cuota en colones" ></asp:TextBox>


         

    </form>
</body>
</html>
