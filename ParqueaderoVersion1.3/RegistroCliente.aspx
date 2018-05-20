<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RegistroCliente.aspx.cs" Inherits="ParqueaderoVersion1._3.RegistroCliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 246px;
        }
        .auto-style3 {
            width: 236px;
        }
        .auto-style4 {
            width: 246px;
            height: 78px;
        }
        .auto-style5 {
            width: 236px;
            height: 78px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
    <h1>
       Registro Clientes

    </h1>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style4">Nombre(s) :<br />
                <asp:TextBox ID="txrNombre" runat="server" Height="16px" Width="315px" Enabled="False"></asp:TextBox>
            </td>
            <td class="auto-style5">Apellido(s):
                <br />
                <asp:TextBox ID="txtApellido" runat="server" Height="16px" Width="312px" Enabled="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Numero Identificacion :&nbsp;<br />
                <asp:TextBox ID="txtNumeroIdentificacion" runat="server" Height="16px" Width="313px" Enabled="False"></asp:TextBox>
            </td>
            <td class="auto-style3">Correo Electronico :<br />
                <asp:TextBox ID="txtCorreo" runat="server" Height="16px" Width="312px" Enabled="False"></asp:TextBox>
            </td>
           



        </tr>
    </table>
    <asp:Label ID="Label1" runat="server" style="color: #000000; font-size: medium; background-color: #FF3300" Text="Label" Visible="False"></asp:Label>
    <br />
    <br />

    
    <center>

    
    <asp:Button ID="Button1" runat="server" Text="Crear"  Height="35px" Width="99px" OnClick="Button1_Click1"  />
   
        <asp:Button ID="btnBuscar" runat="server" OnClick="btnBuscar_Click" Text="Buscar" Height="35px" Width="99px" />
        <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" Height="35px" Width="99px"  />
        <asp:Button ID="btnModificar" runat="server" Text="Modificar" Height="35px" Width="99px"  />
   </center>
    <br />
   
    <center>
     <asp:GridView ID="dgvCliente" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Height="161px" OnSelectedIndexChanged="dgvCliente_SelectedIndexChanged" Width="621px">
        <AlternatingRowStyle BackColor="White" />
         <Columns>
             <asp:ButtonField ButtonType="Button" HeaderText="Registrar Carro" />
         </Columns>
        <EditRowStyle BackColor="#7C6F57" />
        <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#E3EAEB" />
        <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F8FAFA" />
        <SortedAscendingHeaderStyle BackColor="#246B61" />
        <SortedDescendingCellStyle BackColor="#D4DFE1" />
        <SortedDescendingHeaderStyle BackColor="#15524A" />
    </asp:GridView>
        </center>
    <br />
   
    <center>
         <asp:Button ID="btnGuardar" runat="server" OnClick="btnGuardar_Click" Text="Guardar" />
    </center>
    <br />
    <br />

    </asp:Content>
