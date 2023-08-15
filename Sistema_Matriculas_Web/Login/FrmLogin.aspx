<%@ Page Language="vb" MasterPageFile="~/MpLogin.Master" AutoEventWireup="false" CodeBehind="FrmLogin.aspx.vb" Inherits="Sistema_Matriculas_Web.FrmLogin" %>

<asp:Content ID="ContenidoLogin" ContentPlaceHolderID="MainContent" runat="server">
        <div>
            <h1>Iniciar sesion</h1>
            <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
            <br />
            <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="TxtRegistrar" runat="server" Text="Registrar" />
        </div>
</asp:Content>

