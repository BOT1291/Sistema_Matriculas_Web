<%@ Page Language="vb" MasterPageFile="~/Site.Master" AutoEventWireup="false" CodeBehind="FrmRegistroCursos.aspx.vb" Inherits="Sistema_Matriculas_Web.FrmRegistroCursos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div>
        <h1>
            <asp:Label ID="LblTitulo" runat="server"></asp:Label></h1>
    </div>

    <div>

        <div class="form-group">
            <label for="a">Codigo de la Carrera</label>
            <asp:TextBox ID="TxtCarrera" runat="server" onkeypress="return soloLetras(event)" required="required" placeholder="Example: TID"></asp:TextBox>

        </div>
        <div class="form-group">
            <label for="d">Numero Codigo</label>
            <asp:TextBox ID="TxtId" runat="server" required="required" placeholder="Example: 102"></asp:TextBox>

        </div>
        <div class="form-group">
            <label for="f">Materia</label>
            <asp:TextBox ID="TxtNombre" runat="server" onkeypress="return soloLetras(event)" required="required" placeholder="Example: Estructura de Datos"></asp:TextBox>

        </div>
        <div class="form-group">
            <label for="g">Creditos</label>
            <asp:TextBox ID="TxtCreditos" runat="server" required="required" placeholder="Example: ####"></asp:TextBox>

        </div>
        <div class="form-group">
            <label for="d">Nota Minima</label>
            <asp:TextBox ID="TxtNotaMinima" runat="server" required="required" placeholder="Example: #####"></asp:TextBox>

        </div>
        <div class="form-group">
            <label for="a">Estudiantes Min</label>
            <asp:TextBox ID="TxtEstudianteMin" runat="server" required="required" placeholder="Example: #####"></asp:TextBox>

        </div>
        <div class="form-group">
            <label for="q">Estudiantes Max</label>
            <asp:TextBox ID="TxtEstudiantesMax" runat="server" required="required" placeholder="Example: ####"></asp:TextBox>

        </div>
        <div class="form-group">
            <label for="">Grado</label>
            
            <asp:DropDownList ID="DDLGrado" runat="server" Width="174px" Height="24px" AppendDataBoundItems="false">
                    <asp:ListItem Text="Diplomado" Value="1"></asp:ListItem>
                    <asp:ListItem Text="Bachiller" Value="2"></asp:ListItem>
                    <asp:ListItem Text="Licenciado" Value="3"></asp:ListItem>
                    <asp:ListItem Text="Master" Value="4"></asp:ListItem>
                    <asp:ListItem Text="Doctorado" Value="5"></asp:ListItem>
                </asp:DropDownList>

        </div>
        <div class="form-group">
            <label for="e">Estado</label>
            <asp:DropDownList ID="DDLEstado" runat="server" Width="174px" Height="24px" AppendDataBoundItems="false">
                <asp:ListItem Text="Habilitado" Value="Habilitado"></asp:ListItem>
                <asp:ListItem Text="Inabilitado" Value="Inabilitado"></asp:ListItem>
            </asp:DropDownList>
        </div>
<%--        <div class="form-group">
            <label for="h">Costo</label>
            <asp:TextBox ID="TxtCosto" runat="server" placeholder=""></asp:TextBox>
        </div>--%>
        <div>
            <asp:Button ID="BtnPrueba" CssClass="btn btn-primary" runat="server" Text="Aceptar" />
            <a href="FrmListaCursos.aspx" class="btn btn-danger">Cancelar</a>
        </div>
        <div class="alert alert-danger" role="alert" id="lblMensaje" runat="server" visible="false"></div>
    </div>

</asp:Content>

