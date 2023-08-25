<%@ Page Language="vb" MasterPageFile="~/Site.Master" AutoEventWireup="false" CodeBehind="FrmConfirmacionEstudiantes.aspx.vb" Inherits="Sistema_Matriculas_Web.FrmConfirmacionEstudiantes" %>

<asp:Content ID="PaginaConfirmacion" ContentPlaceHolderID="MainContent" runat="server">

        <style>
        .container {
            display: flex;
            align-items: center;
        }

        .left-side {
            flex: 1;
            padding: 20px;
            text-align: center;
        }

        .right-side {
            flex: 1;
            padding: 20px;
            display: flex;
            flex-direction: column;
            justify-content: space-between;
        }

        .gridview-container {
            width: 70%;
        }

        .button-container {
            margin-top: 20px;
            text-align: center;
        }
    </style>




           <div class="container">
        <div class="left-side">
            <h1>Pagina de confirmacion</h1>

            <asp:Label ID="LblCarne" runat="server" Text="Carne" style="padding: 10px;"></asp:Label>
            <br />
            <%--<asp:TextBox ID="TextBox1" runat="server" onkeypress="return event.charCode >= 48 && event.charCode <= 57"></asp:TextBox>--%>
            <asp:TextBox ID="TxtCarne"  runat="server"></asp:TextBox>

            <br />
            <asp:Button ID="ButtonBuscar" runat="server" Text="Buscar" style="margin-top: 20px; text-align: center;" />
            <br />
            <asp:Label ID="LblIdentificacion" runat="server" Text="Identificacion" style="padding: 10px;"></asp:Label>
            <br />
            <asp:TextBox ID="TxtIdentificacion" runat="server"></asp:TextBox>
            <br />

            <asp:Label ID="LblCarreraMAtriculada" runat="server" Text="Carrera Matriculada" style="padding: 10px;"></asp:Label>
            <br />
            <asp:TextBox ID="TxtCarreraMatriculada" runat="server"></asp:TextBox>
            <br />

            <asp:Label ID="LblCursos" runat="server" Text="Cursos" style="padding: 10px;"></asp:Label>
            <br />
            <asp:CheckBox ID="CBCurso1" runat="server" />
            <br />
            <asp:CheckBox ID="CBCurso2" runat="server" />
            <br />

            <asp:Label ID="LblBeca" runat="server" Text="Beca" style="padding: 10px;"></asp:Label>
            <br />
            <asp:TextBox ID="TxtBeca" runat="server"></asp:TextBox>
            <br />

            <asp:Label ID="Lbl" runat="server" Text="Costo Total" style="padding: 10px;"></asp:Label>
            <br />
            <asp:TextBox ID="TxtCostoTotal" runat="server"></asp:TextBox>
            <br />

        </div>
        <div class="right-side">
            <div class="gridview-container">
                <asp:GridView ID="GVMostarEstudiantes" runat="server"></asp:GridView>
            </div>
            <div class="button-container">
                <asp:Button ID="Button2" runat="server" Text="Button" />
                <asp:Button ID="Button1" runat="server" Text="Button" />
            </div>
        </div>
    </div>

</asp:Content>