<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Examen3._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">

        <asp:Button ID="Button1" runat="server" Text="Consultar Proveedor" OnClick="ConsultarProveedor" />
        <p></p>

        <asp:Button ID="Button4" runat="server" Text="Consultar Nombre de Empresa" OnClick="ConsultarProveedor" />
        <p></p>

        <asp:Button ID="Button2" runat="server" Text="Consultar Producto" OnClick="ConsultarProducto" />
        <p></p>

   <asp:Button ID="Button3" runat="server" Text="Insertar Proveedor" />
        <p></p>

        <p>Empresa:</p>
        <asp:TextBox ID="TextEmpresa" runat="server"> </asp:TextBox>

        <p>Nombre:</p>
        <asp:TextBox ID="TxtNombre" runat="server"> </asp:TextBox>
       
         <p>Telefono:</p>
        <asp:TextBox ID="TxtTel" runat="server"> </asp:TextBox>
       
         <p>Email:</p>
        <asp:TextBox ID="TxtEmail" runat="server"> </asp:TextBox>
       
         <p>Dias de Espera:</p>
        <asp:TextBox ID="TxtDias" runat="server"> </asp:TextBox>

    </div>

    <asp:GridView ID="grvReporte" runat="server" AllowPaging="true" AllowSorting="true" Style="font: 16px arial; color: grey; border-color: gainsboro; margin-top: 2%; margin-bottom: 2%">
        <SelectedRowStyle BackColor="#7BC143"
            ForeColor="Black"
            Font-Bold="true" BorderStyle="Dotted" BorderWidth="1px" />
    </asp:GridView>
</asp:Content>
