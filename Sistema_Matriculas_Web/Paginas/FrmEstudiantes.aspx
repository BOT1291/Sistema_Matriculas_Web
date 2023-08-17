<%@ Page Language="vb" MasterPageFile="~/Site.Master" AutoEventWireup="false" CodeBehind="FrmEstudiantes.aspx.vb" Inherits="Sistema_Matriculas_Web.FrmEstudiantes" %>

<asp:Content ID="PaginaResgistroEstudiante" ContentPlaceHolderID="MainContent" runat="server">

    
<%-- Hoja de estilo para la pagina --%>
<style>
/*Estilo para cambiar el color del texto del footer*/    
    .footer-text {
        font-size: 16px;
        color: rgb(255, 255, 255);
        }

/*Estilo para cambiar el fondo de la pagina*/    
    .background {
        position: fixed;
        top: 0;
        left: 0;
        width: 100%;
        height: 100%;
        /*background: linear-gradient(45deg, #34495e, #2c3e50);*/ /* Colores más formales */
        /*background: rgb(230,230,250);*/
        background: rgb(128,0,128);/*un color mas llamativo*/
        z-index: -1;
        }

/*Estilo para cambiar el color del panel*/    
    .title-panel {
        background: #333;
        color: white;
        padding: 10px 20px;
        border-radius: 5px;
        font-size: 24px;
        margin-bottom: 20px;
        text-align :center;
        }

/*Estilo para cambiar el centrado*/    
    #Centrado.center {
        display: block;
        justify-content: center;
        align-items: center;
        min-height: 100vh;
        text-align: center;
        }

/*Estilo para cambiar el centrado del contenido*/    
    #Contenedor.container {
        padding: 40px;
        border: 2px solid #ccc;
        border-radius: 10px;
        width: 400px;
        height: 876px;
        background: rgb(255,255,255);
        }

    #Contenedor.container select,
    #Contenedor.container label,
    #Contenedor.container input,
    #Contenedor.container button {
        margin: 10px 0;
        }
       
</style>
    <%-- Fin de la hoja de estilos --%>


    <div class="background"></div>
    <div class="title-panel">
        <asp:Label ID="LblTitulo" runat="server" Text="Registro de Estudiantes" CssClass="title-label"></asp:Label>
    </div>
    <div id="Centrado" class="center">
        <div id="Contenedor" class="container">
<%--Sus respectivos campos para llenar y su nombre--%>
         <asp:Label ID="LblCarne" runat="server" Text="Carne"></asp:Label>
                   <br />
        <asp:TextBox ID="TxtCarne" runat="server"></asp:TextBox>
                   <br />

<%--Sus respectivos campos para llenar y su nombre--%>
        <asp:Label ID="LblIdentificacion" runat="server" Text="Identificacion"></asp:Label>
                 <br />
        <asp:TextBox ID="TxtIdentificacion" runat="server"></asp:TextBox>
                  <br />

<%--Sus respectivos campos para llenar y su nombre--%>
        <asp:Label ID="LblNombre" runat="server" Text="Nombre"></asp:Label>
             <br/>
         <asp:TextBox ID="TxtNombre" runat="server"></asp:TextBox>
             <br/>

<%--Sus respectivos campos para llenar y su nombre--%>
        <asp:Label ID="LblApellidos" runat="server" Text="Apellidos"></asp:Label>
             <br/>
        <asp:TextBox ID="TxtApellidos" runat="server"></asp:TextBox>
             <br/>

<%--Sus respectivos campos para llenar y su nombre--%>
        <asp:Label ID="LblCarreraMatriculada" runat="server" Text="Carrera Matriculada"></asp:Label>
            
            <br />
    <asp:DropDownList ID="DropDownList1" runat="server" Width="174px" Height="28px">
    <asp:ListItem Text="Seleccione....." Value="carrera0"></asp:ListItem>
    <asp:ListItem Text="carrera1" Value="carrera1"></asp:ListItem>
    <asp:ListItem Text="carrera2" Value="carrera2"></asp:ListItem>
    <asp:ListItem Text="carrera3" Value="carrera3"></asp:ListItem>
    </asp:DropDownList>
           <br />
         

<%--Sus respectivos campos para llenar y su nombre--%>
        <asp:Label ID="LblTelefono" runat="server" Text="Telefono"></asp:Label>
        <br />
        <asp:TextBox ID="TxtTelefono" runat="server" oninput="limitToEightDigits(this)"></asp:TextBox>
        <br />

        <script>
        function limitToEightDigits(inputElement) {
            inputElement.value = inputElement.value.replace(/[^\d]/g, ''); // Eliminar caracteres no numéricos
            inputElement.value = inputElement.value.substr(0, 8); // Limitar a 8 caracteres
        }
        </script>

<%--Sus respectivos campos para llenar y su nombre--%>
        <asp:Label ID="Label1" runat="server" Text="Correo ELectronico"></asp:Label>
             <br/>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
             <br/>

<%--Sus respectivos campos para llenar y su nombre--%>
        <asp:Label ID="LblFecha" runat="server" Text="Fecha de Nacimiento"></asp:Label>
        <br />
        <asp:TextBox ID="TxtFecha" runat="server" type="date"></asp:TextBox>
        <script>
            var today = new Date();
            var year = today.getFullYear();
            var month = (today.getMonth() + 1).toString().padStart(2, '0');
            var day = today.getDate().toString().padStart(2, '0');
            var maxDate = year + "-" + month + "-" + day;
            document.getElementById("<%= TxtFecha.ClientID %>").setAttribute("max", maxDate);
        </script>
        <br />

<%--Sus respectivos campos para llenar y su nombre--%>
        <asp:Label ID="Label3" runat="server" Text="Direccion Exacta"></asp:Label>
             <br/>
        <asp:TextBox ID="TextBox3" runat="server" Height="91px" Width="349px" Style="direction: ltr" TextMode="MultiLine"></asp:TextBox>
             <br/>


<%--Sus respectivos campos para llenar y su nombre--%>
        <asp:Label ID="LblBeca" runat="server" Text="Beca"></asp:Label>
           
            <br />
        <asp:DropDownList ID="DDLBeca" runat="server" Width="174px" Height="27px" >
            <asp:ListItem Text="Seleccione....." Value="carrera0"></asp:ListItem>
            <asp:ListItem Text="25" value="25"></asp:ListItem>
            <asp:ListItem Text="50" value="50"></asp:ListItem>
            <asp:ListItem Text="75" value="75"></asp:ListItem>
            <asp:ListItem Text="100" value="100"></asp:ListItem>
    </asp:DropDownList>
           <br />
           <br />

<%--Sus respectivos Boton--%>
        <asp:Button ID="BtnRegistrar" runat="server" Text="Registrar Estudiante" CssClass="submit-button" />
        </div>
    </div>


</asp:Content>
