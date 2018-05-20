<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RegistroCarro.aspx.cs" Inherits="ParqueaderoVersion1._3.RegistroCarro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 87%;
        }
        .auto-style2 {
            width: 202px;
        }
        .auto-style3 {
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
    <h1>Registro vehiculo por usuario</h1>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">



    <table class="auto-style1">
        <tr>
            <td class="auto-style2">Numero Identificacion
                <asp:TextBox ID="TxtNumeroIdentificacion" runat="server" Width="190px"></asp:TextBox>
            </td>
            <td class="auto-style3">Nombre(s):<br />
                <asp:TextBox ID="txtNombre" runat="server" Width="190px"></asp:TextBox>
            </td>
            <td>Tipo vehiculo:
                <br />
                <asp:DropDownList ID="ddtipoVehiculo" runat="server" Height="18px" Width="190px">
                </asp:DropDownList>
                <br />
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Marca
                <br />
                <asp:DropDownList ID="ddMarca" runat="server" Height="18px" Width="190px">
                </asp:DropDownList>
            </td>
            <td class="auto-style3">Modelo<br />
                <asp:DropDownList ID="ddModelo" runat="server" Height="18px" Width="190px">
                </asp:DropDownList>
            </td>
            <td>Color
                <br />
                <asp:DropDownList ID="ddColor" runat="server" Height="18px" Width="190px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Placa<br />
                <asp:TextBox ID="txtPlaca" runat="server" Height="27px" Width="171px"></asp:TextBox>
                <asp:Button ID="btnBuscar" runat="server" OnClick="btnBuscar_Click" Text="Buscar" />
            </td>
            <td class="auto-style3" colspan="2">Observacione(s):<br />
&nbsp;<asp:TextBox ID="txtObservaciones" runat="server" Height="35px" Width="425px"></asp:TextBox>
              &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp  <asp:Button ID="btnGuardar" runat="server" Height="28px" OnClick="Button1_Click" Text="Guardar" Width="84px" />
            </td>
        </tr>
    </table>



</asp:Content>
