<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="FrmRegistroCarrera.aspx.vb" Inherits="Sistema_Matriculas_Web.FrmRegistroCarrera" %>

<asp:Content ID="PaginaRegistroCarrera" ContentPlaceHolderID="MainContent" runat="server">

    
    <div class="background"></div>
    <div class="title-panel">
        <h1><asp:Label ID="LblTitulo"  runat="server"></asp:Label></h1>
    </div>
    <div id="Centrado" class="center">
        <div id="Contenedor" class="container">
<%--Sus respectivos campos para llenar y su nombre--%>
         <asp:Label ID="LblIdentificacion" runat="server" Text="Identificacion"></asp:Label>
                   <br />
        <asp:TextBox ID="TxtIdentificacion" runat="server"></asp:TextBox>
                   <br />

<%--Sus respectivos campos para llenar y su nombre--%>
        <asp:Label ID="LblNombre" runat="server" Text="Nombre"></asp:Label>
                 <br />
        <asp:TextBox ID="TxtNombre" runat="server"></asp:TextBox>
                  <br />

<%--Sus respectivos campos para llenar y su nombre--%>
        <asp:Label ID="LblEstado" runat="server" Text="Estado"></asp:Label>
            <br />
            <br />
        <asp:DropDownList ID="DDLEstado" runat="server" Width="174px" Height="24px">
    <asp:ListItem Text="Habilitado" Value="Habilitado"></asp:ListItem>
    <asp:ListItem Text="Inabilitado" Value="Inabilitado"></asp:ListItem>
    </asp:DropDownList>
           <br />
           <br />

<%--Sus respectivos Boton--%>
        <asp:Button ID="BtnRegistrar" runat="server" Text="Registrar" CssClass="submit-button" />
            <br />
        <a href="FrmListaCarrera.aspx" class="btn btn-danger">Cancelar</a> 

        </div>
    </div>

</asp:Content>