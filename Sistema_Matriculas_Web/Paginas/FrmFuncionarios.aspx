<%@ Page Language="vb" MasterPageFile="~/Site.Master" AutoEventWireup="false" CodeBehind="FrmFuncionarios.aspx.vb" Inherits="Sistema_Matriculas_Web.FrmFuncionarios" %>

<asp:Content ID="PaginaFuncionarios" ContentPlaceHolderID="MainContent" runat="server">


    <style>
    .title-panel {
            background: #333;
            color: white;
            padding: 10px 20px;
            border-radius: 5px;
            font-size: 24px;
            margin-bottom: 20px;
            text-align :center;
        }

    #Hola.center {
        display: block;
        justify-content: center;
        align-items: center;
        min-height: 100vh;
        text-align: center;
    }

    #Prueba.container {
        padding: 40px;
        border: 2px solid #ccc;
        border-radius: 10px;
        width: 400px;
            height: 665px;
        }

    #Prueba.container DropDownList,
    #Prueba.container label,
    #Prueba.container input,
    #Prueba.container button {
        margin: 10px 0;
    }
        
    </style>

    <div class="title-panel">
        <asp:Label ID="LblTitulo" runat="server" Text="Registro de Funcionarios" CssClass="title-label"></asp:Label>
    </div>
    <div id="Hola" class="center">
        <div id="Prueba" class="container">
<%--Sus respectivos campos para llenar y si nombre--%>
         <asp:Label ID="LblIdentificacion" runat="server" Text="Identificacion"></asp:Label>
                   <br />
        <asp:TextBox ID="TxtIdentificacion" runat="server"></asp:TextBox>
                   <br />

<%--Sus respectivos campos para llenar y si nombre--%>
        <asp:Label ID="LblNombre" runat="server" Text="Nombre"></asp:Label>
                 <br />
        <asp:TextBox ID="TxtNombre" runat="server"></asp:TextBox>
                  <br />

<%--Sus respectivos campos para llenar y si nombre--%>
        <asp:Label ID="LblPrimerApellido" runat="server" Text="Primer Apellido"></asp:Label>
             <br />
         <asp:TextBox ID="TxtPrimerApellido" runat="server"></asp:TextBox>
               <br />

<%--Sus respectivos campos para llenar y si nombre--%>
        <asp:Label ID="LblSegundoApellido" runat="server" Text="Seundo Apellido"></asp:Label>
                   <br />
        <asp:TextBox ID="TxtSegundoApellido" runat="server"></asp:TextBox>
                <br />

<%--Sus respectivos campos para llenar y si nombre--%>
        <asp:Label ID="LblCorreo" runat="server" Text="Correo Electronico"></asp:Label>
            <br />
        <asp:TextBox ID="TxtCorreo" runat="server"></asp:TextBox>
            <br />

<%--Sus respectivos campos para llenar y si nombre--%>
        <asp:Label ID="LblClave" runat="server" Text="Clave"></asp:Label>
            <br />
        <asp:TextBox ID="TxtClave" runat="server"></asp:TextBox>
            <br />

<%--Sus respectivos campos para llenar y si nombre--%>
        <asp:Label ID="LblEstado" runat="server" Text="Estado"></asp:Label>
            <br />
            <br />
        <asp:DropDownList ID="DDLEstado" runat="server" Width="174px" Height="24px">
    <asp:ListItem Text="Activo" Value="1"></asp:ListItem>
    <asp:ListItem Text="Inactivo" Value="2"></asp:ListItem>
    <asp:ListItem Text="Bloqueado" Value="3"></asp:ListItem>
    </asp:DropDownList>
           <br />
           <br />

<%--Sus respectivos Boton--%>
        <asp:Button ID="BtnRegistrar" runat="server" Text="Registrar" CssClass="submit-button" />
        </div>
    </div>


</asp:Content>

