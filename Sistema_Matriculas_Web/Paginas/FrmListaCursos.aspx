<%@ Page Language="vb" MasterPageFile="~/Site.Master" AutoEventWireup="false" CodeBehind="FrmListaCursos.aspx.vb" Inherits="Sistema_Matriculas_Web.FrmListaCursos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div>
        <h1>Lista de Cursos</h1>
    </div>

    <div style="text-align: right">
        <a href="FrmRegistroCursos.aspx?accion=1" runat="server" class="btn btn-info">Registrar</a>
        <br />
    </div>

    <div>
        <table class="table">
            <thead>
                <tr>
                    <th scope="col">Codigo Curso</th>
                    <th scope="col">Codigo Carrea</th>
                    <th scope="col">Nombre</th>
                    <th scope="col">Creditos</th>
                    <th scope="col">Nota Minima</th>
                    <th scope="col">Minimo de Estudiantes</th>
                    <th scope="col">Maximo de Estudiantes</th>
                    <th scope="col">Grado de Carrera</th>
                    <th scope="col">Estado</th>
                    <th scope="col">Costo</th>
                </tr>
            </thead>
            <tbody id="lstCurso" runat="server">
            </tbody>
        </table>
    </div>




</asp:Content>


