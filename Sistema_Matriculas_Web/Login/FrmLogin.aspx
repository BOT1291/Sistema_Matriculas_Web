<%@ Page Language="vb" MasterPageFile="~/MpLogin.Master" AutoEventWireup="false" CodeBehind="FrmLogin.aspx.vb" Inherits="Sistema_Matriculas_Web.FrmLogin" %>

<asp:Content ID="ContenidoLogin" ContentPlaceHolderID="MainContent" runat="server">

    <div class="login-container">
        <h1>Iniciar Session</h1>
        <asp:TextBox ID="txtPassword" runat="server" placeholder="Clave"></asp:TextBox>
        <asp:RegularExpressionValidator ID="revPassword" runat="server"
            ControlToValidate="txtPassword"
            ErrorMessage="La contraseña no cumple con los requisitos de seguridad."
            ValidationExpression="^(?=.*\d)(?=.*[\u0021-\u002b\u003c-\u0040])(?=.*[A-Z])(?=.*[a-z])\S{8,16}$"
            Display="Dynamic">
        </asp:RegularExpressionValidator>


        <asp:TextBox ID="txtUsuario" runat="server" placeholder="Email"></asp:TextBox>

        <asp:Button ID="BtnRegistrar" runat="server" Text="Button" />
    </div>


<style>
    body {
        font-family: Arial, sans-serif;
        background: linear-gradient(to bottom, #f0f0f0, #e0e0e0);
    }

    .login-container {
        background-color: #ffffff;
        border-radius: 8px;
        box-shadow: 0px 0px 10px rgba(0, 0, 0, 0.2);
        padding: 20px;
        width: 300px;
        margin: 100px auto;
        text-align: center;
    }

    h1 {
        font-size: 24px;
        margin-bottom: 20px;
    }

    input {
        width: 100%;
        padding: 10px;
        margin-bottom: 10px;
        border: 1px solid #ccc;
        border-radius: 10px;
        outline: none;
    }

    button {
        width: 100%;
        padding: 10px;
        background-color: #3498db;
        border: none;
        border-radius: 4px;
        color: white;
        font-weight: bold;
        cursor: pointer;
    }
</style>

</asp:Content>

