<%@ Page Language="vb" MasterPageFile="~/Site.Master" AutoEventWireup="false" CodeBehind="FrmClientes.aspx.vb" Inherits="Sistema_Matriculas_Web.FrmClientes" %>

<asp:Content ID="ContenidoCliente" ContentPlaceHolderID="MainContent" runat="server">
    
        <div>
            <h1>Lista de Clientes</h1>
        </div>

    <div>
        <asp:GridView ID="GvClientes" runat="server"></asp:GridView>
    </div>
</asp:Content>

