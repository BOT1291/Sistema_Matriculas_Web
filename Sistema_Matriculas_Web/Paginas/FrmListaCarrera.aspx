<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="FrmListaCarrera.aspx.vb" Inherits="Sistema_Matriculas_Web.FrmListaCarrera" %>

<asp:Content ID="PaginaCarrea" ContentPlaceHolderID="MainContent" runat="server">

     <div>
        <h1>Lista de Carreras</h1>
    </div>

    <div style="text-align: right">
        <a href="FrmRegistroCarrera.aspx?accion=1" runat="server" class="btn btn-info">Registrar</a>
        <br />
    </div>
        <br />


    <br />
    <br />
    <div>
        <table class="table">
            <thead>
                <tr>
                    <th scope="col">Codigo</th>
                    <th scope="col">Nombre</th>
                    <th scope="col">Estado</th>
                </tr>
            </thead>
            <tbody id="lstFuncionarios" runat="server">

            </tbody>
        </table>
    </div>

</asp:Content>
