<%@ Page Title="About" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.vb" Inherits="Sistema_Matriculas_Web.About" %>

<asp:Content ID="PaginaAcerdaDe" ContentPlaceHolderID="MainContent" runat="server">
    <style>
    body {
    background:rgb(230, 230, 250);

    }
    .project-container {
        display: flex;
        align-items: center;
        justify-content: space-between;
        margin: 30px auto;
        padding: 20px;
        background-color: #f7f7f7;
        border-radius: 10px;
        box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
        width: 70%;
    }

    .project-image {
        flex: 0 0 auto;
        margin-right: 70px;
    }

    .logo {
        display: block;
        margin-bottom: 15px;
    }

    .project-details {
        flex: 3 3 auto;
    }

    .project-title {
        font-size: 24px;
        margin-bottom: 5px;
        font-family: "Arial", sans-serif;
        font-size: 28px;
        font-weight: bold;
    }

    .project-description,
    .project-elaborated,
    .project-student,
    .project-details {
        font-size: 20px;
        margin: 5px 0;
        font-style:italic;
    }
    </style>

<%-- Pagina de Acerca de y ademas con su nombres --%>
 <div class="project-container">
    <div class="project-image">
        <asp:Image ID="ImgLogo" runat="server" Height="277px" Width="298px" CssClass="logo" ImageUrl="~/Imagenes/logo_cuc_color.png" />
    </div>
    <div class="project-details">
        <h1 class="project-title">Nombre del Proyecto</h1>
        <p class="project-description">Sistema de Matricula</p>
        <br />
        <h1 class="project-title">Elaborado Por</h1>
        <p class="project-student">Brandon Cardenas Estrada</p>
        <p class="project-student">Benjamin Ortiz Torpoco</p>
        <br />
        <p class="project-details">Grupo 03, Programación II</p>
        <p class="project-details">II Cuatrimestres del 2023</p>
    </div>
</div>
    <%-- Fin de la pagina Acerca De --%>

</asp:Content>
