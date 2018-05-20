<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Taquilla.aspx.cs" Inherits="ParqueaderoVersion1._3.Taquilla" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 264px;
            height: 200px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
    <h1>Taquilla</h1>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <p>
       <center>
           <img alt="" class="auto-style1" src="Images/cierre_caja.jpg" /><br />
           <br />
           <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/RegistroCliente.aspx">* Registro Cliente</asp:LinkButton>
           <br />
           <br />
           <asp:LinkButton ID="LinkButton2" runat="server" PostBackUrl="~/RegistroCarro.aspx" OnClick="LinkButton2_Click">* Registro Carro</asp:LinkButton>
           <br />
       </center>
    
   



</asp:Content>
