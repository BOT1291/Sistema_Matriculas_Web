<%@ Page Language="vb" MasterPageFile="~/Site.Master" AutoEventWireup="false" CodeBehind="FrmRegistroFuncionario.aspx.vb" Inherits="Sistema_Matriculas_Web.FrmFuncionarios" %>

<asp:Content ID="PaginaFuncionarios" ContentPlaceHolderID="MainContent" runat="server">

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
        background: rgb(33,43,61);/*un color mas llamativo*/
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
        height: 745px;
        background: rgb(255,255,255);
        }

    .buttons-container {
    display: flex;
    justify-content: space-between;
    align-items: center;
    margin-top: 10px;
}


    #Contenedor.container DropDownList,
    #Contenedor.container label,
    #Contenedor.container input,
    #Contenedor.container button {
        margin: 10px 0;
    }
       
</style>
    <%-- Fin de la hoja de estilos --%>


    <div class="background"></div>
    <div class="title-panel">
        <asp:Label ID="LblTitulo" runat="server" Text="Registro de Funcionarios" CssClass="title-label"></asp:Label>
    </div>
    <div id="Centrado" class="center">
        <div id="Contenedor" class="container">

            <div class="form-group">
                <label for="LblIdentificacion">Identificación</label>
                <br />
                <asp:TextBox ID="TxtIdentificacion" runat="server" required="required" placeholder="Example: 123456789" minlength="9" MaxLength="12" type="number" ></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegexValidatorIdentificacion" runat="server"
                    ControlToValidate="TxtIdentificacion"
                    ValidationExpression="^\d+$"
                    Display="Dynamic">
                </asp:RegularExpressionValidator>
            </div>


            <div class="form-group">
                <label for="TxtNombre">Nombre</label>
                <br />
                <asp:TextBox ID="TxtNombre" runat="server" onkeypress="return soloLetras(event)" required="required" title="Ingresa un nombre válido"></asp:TextBox>

<%--                <asp:TextBox ID="TxtNombre" runat="server" required="required" pattern="[A-Za-zÁÉÍÓÚáéíóúñÑ\s]+" title="Ingresa un nombre válido"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegexValidatorNombre" runat="server"
                    ControlToValidate="TxtNombre"
                    ValidationExpression="^[A-Za-zÁÉÍÓÚáéíóúñÑ\s]+$"
                    ErrorMessage="Ingresa un nombre válido."
                    Display="Dynamic">
                </asp:RegularExpressionValidator>--%>
            </div>


            <div class="form-group">
                <label for="TxtPrimerApellido">Primer Apellido</label>
                <br />
                <asp:TextBox ID="TxtPrimerApellido" runat="server" required="required" placeholder="Example: Reyes" title="Ingresa tu Primer Apellido"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server"
                    ControlToValidate="TxtPrimerApellido"
                    ValidationExpression="^[A-Za-zÁÉÍÓÚáéíóúñÑ\s]+$"
                    Display="Dynamic">
                </asp:RegularExpressionValidator>
            </div>

            <div class="form-group">
                <label for="TxtSegundoApellido">Segundo Apellido</label>
                <br />
                <asp:TextBox ID="TxtSegundoApellido" runat="server" required="required" placeholder="Example: Rojas" title="Ingresa tu Segundo Apellido"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server"
                    ControlToValidate="TxtSegundoApellido"
                    ValidationExpression="^[A-Za-zÁÉÍÓÚáéíóúñÑ\s]+$"
                    Display="Dynamic">
                </asp:RegularExpressionValidator>
            </div>



            <div class="form-group">
                <label for="TxtCorreo">Correo Electrónico</label>
                <br />
                <asp:TextBox ID="TxtCorreo" runat="server" required="required" placeholder="Random@Example.com"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server"
                    ControlToValidate="TxtCorreo"
                    ValidationExpression="^(([^<>()\[\]\\.,;:\s@”]+(\.[^<>()\[\]\\.,;:\s@”]+)*)|(“.+”))@((\[[0–9]{1,3}\.[0–9]{1,3}\.[0–9]{1,3}\.[0–9]{1,3}])|(([a-zA-Z\-0–9]+\.)+[a-zA-Z]{2,}))$"
                    Display="Dynamic">
                </asp:RegularExpressionValidator>
            </div>

            <div class="form-gruop">

                <asp:Label ID="LblClave" runat="server" Text="Clave"></asp:Label>
                <br />
                <asp:TextBox ID="TxtClave" runat="server" requierd="requiered" placeholder="Example: Passw0rd!"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegexValidator" runat="server"
                    ControlToValidate="TxtClave"
                    ValidationExpression="^(?=.*\d)(?=.*[\u0021-\u002b\u003c-\u0040])(?=.*[A-Z])(?=.*[a-z])\S{8,16}$"
                    Display="Dynamic">
                </asp:RegularExpressionValidator>

            </div>
                


                <%--Sus respectivos campos para llenar y su nombre--%>
                <asp:Label ID="LblEstado" runat="server" Text="Estado"></asp:Label>
                <br />
                <br />
                <asp:DropDownList ID="DDLEstado" runat="server" Width="174px" Height="24px" AppendDataBoundItems="false">
                    <asp:ListItem Text="Activo" Value="Activo"></asp:ListItem>
                    <asp:ListItem Text="Inactivo" Value="Inactivo"></asp:ListItem>
                    <asp:ListItem Text="Bloqueado" Value="Bloqueado"></asp:ListItem>
                </asp:DropDownList>
                <br />
                <br />

                <%--Sus respectivos Boton--%>
                <div class="form-group">
                    <div class="buttons-container">
                        <asp:Button ID="BtnRegistrar" runat="server" Text="Registrar" CssClass="submit-button" />
                        <a href="FrmListaFuncionario.aspx" class="btn btn-danger">Volver</a>
                    </div>
                </div>
                 
            </div>
        </div>
    </div>


</asp:Content>

