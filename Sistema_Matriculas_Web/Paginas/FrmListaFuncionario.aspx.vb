Public Class FrmListaFuncionario
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'seguridad
        Try
            Dim eUsuarios As Entidades.EntiUsuarios = CType(Session("usuario"), Entidades.EntiUsuarios)
            If eUsuarios Is Nothing Then
                FormsAuthentication.RedirectToLoginPage()
            End If
        Catch ex As Exception
            Throw ex
        End Try

        Try
            Dim iCarreras As New Negocios.NegFuncionario
            Dim dtCarreras As DataTable = iCarreras.ConsultarNeg
            Dim strListaCarreras As New System.Text.StringBuilder

            For Each drcarrera As DataRow In dtCarreras.Rows
                With strListaCarreras
                    .Append("<tr>")

                    Dim strcodigo As String = CInt(drcarrera("CodigoFuncionario"))
                    .Append("<th scope = ""row"" >")
                    .Append(strcodigo)
                    .Append("</th>")
                    .Append("<td>")
                    .Append(CStr(drcarrera("Nombre")))
                    .Append("</td>")
                    .Append("<td>")
                    .Append(CStr(drcarrera("PrimerApellido")))
                    .Append("</td>")
                    .Append("<td>")
                    .Append(CStr(drcarrera("SegundoApellido")))
                    .Append("</td>")
                    .Append("<td>")
                    .Append(CStr(drcarrera("Correo")))
                    .Append("</td>")
                    .Append("<td>")
                    .Append(CStr(drcarrera("Clave")))
                    .Append("</td>")
                    .Append("<td>")
                    .Append(CStr(drcarrera("Estado")))
                    .Append("</td>")
                    .Append("<td><a href=""FrmRegistroFuncionario.aspx?accion=2&codigo=")
                    .Append(strcodigo)
                    .Append(""" Class=""btn btn-primary"">Modificar</a></td>")
                    .Append("<td><a href=""FrmRegistroFuncionario.aspx?accion=3&codigo=")
                    .Append(strcodigo)
                    .Append("""Class=""btn btn-danger"">Eliminar</a></td>")
                    .Append("</tr>")
                End With
            Next

            Me.lstFuncionarios.InnerHtml = strListaCarreras.ToString


        Catch ex As Exception
            Session("error") = ex
        End Try

    End Sub

End Class