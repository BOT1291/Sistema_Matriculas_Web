<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="FrmListaFuncionario.aspx.vb" Inherits="Sistema_Matriculas_Web.FrmListaFuncionario" %>


<asp:Content ID="ListaFuncinarios" ContentPlaceHolderID="MainContent" runat="server">

    
        <div>
        <h1>Lista de Funcionarios</h1>
    </div>

    <div style="text-align: right">
        <a href="FrmRegistroFuncionario.aspx?accion=1" runat="server" class="btn btn-info">Registrar</a>
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
                    <th scope="col">Primer Apellido</th>
                    <th scope="col">Segundo Apellido</th>
                    <th scope="col">Correo</th>
                    <th scope="col">Clave</th>
                    <th scope="col">Estado</th>
                </tr>
            </thead>
            <tbody id="lstFuncionarios" runat="server">

            </tbody>
        </table>
    </div>



</asp:Content>

