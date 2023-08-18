<%@ Page Language="vb" MasterPageFile="~/Site.Master" AutoEventWireup="false" CodeBehind="FrmInicio.aspx.vb" Inherits="Sistema_Matriculas_Web.FrmInicio" %>

<asp:Content ID="PaginaInicio" ContentPlaceHolderID="MainContent" runat="server">

    <style>
    .footer-text {
        font-size: 16px;
        color: rgb(0,0,0);
    }
    body {
        margin: 0;
        padding: 0;
        font-family: Arial, sans-serif;
        overflow: hidden;
    }

    .background {
        position: fixed;
        top: 0;
        left: 0;
        width: 100%;
        height: 100%;
        /*background: linear-gradient(45deg, #34495e, #2c3e50);*/ /* Colores más formales */
        background: linear-gradient(45deg, #f06, #09f);    /*un color mas llamativo*/
        animation: gradientAnimation 5s infinite alternate;
        z-index: -1;
    }

    @keyframes gradientAnimation {
        0% {
            background-position: 0% 50%;
        }
        100% {
            background-position: 100% 50%;
        }
    }

    .content {
        display: flex;
        flex-direction: column;
        justify-content: center;
        align-items: center;
        text-align: center;
        color: black;
        height: 80vh; /* Asegura que el contenido ocupe el 100% de la altura de la ventana */
    }

    p {
        font-size: 1.2rem;
    }
    /*En este caso, he utilizado los colores #34495e y #2c3e50 en el gradiente, que son tonos más apagados y formales. Puedes ajustar estos valores a otros colores que se adapten a tu preferencia.*/

    #siu.content {
        position: absolute;
        top: 50%;
        left: 50%;
        transform: translate(-50%, -50%);
        text-align: center;
        color: black;
    }

    h1 {
        font-size: 2.5rem;
        margin-bottom: 10px;
        white-space: nowrap;
        overflow: hidden;
        border-right: 0.15em solid black; /* Cursor invisible al principio */
        animation: typewriter 5s steps(40) forwards;
    }

    @keyframes typewriter {
        from {
            width: 0;
            border-color: black;
        }
        to {
            width: 100%;
            border-color: transparent; /* Hacer el cursor visible al final */
        }
    }

    </style>
    
    <div class="background"></div>
    <div class="content"></div>
    <div id="siu" class="content">
    <h1 id="typewriter-text">Sistema de Matricula</h1>
</div>



</asp:Content>
