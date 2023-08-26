Public Class FrmListaCarrera
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Dim iCarreras As New Negocios.NegCarrera
            Dim dtCarreras As DataTable = iCarreras.ConsultarNeg
            Dim strListaCarreras As New System.Text.StringBuilder

            For Each drcarrera As DataRow In dtCarreras.Rows
                With strListaCarreras
                    .Append("<tr>")

                    Dim strcodigo As String = CStr(drcarrera("CodigoCarrera"))
                    .Append("<th scope = ""row"" >")
                    .Append(strcodigo)
                    .Append("</th>")
                    .Append("<td>")
                    .Append(CStr(drcarrera("Nombre")))
                    .Append("</td>")
                    .Append("<td>")
                    .Append(CStr(drcarrera("Estado")))
                    .Append("</td>")
                    .Append("<td><a href=""FrmRegistroCarrera.aspx?accion=2&codigo=")
                    .Append(strcodigo)
                    .Append(""" Class=""btn btn-primary"">Modificar</a></td>")
                    .Append("<td><a href=""FrmRegistroCarrera.aspx?accion=3&codigo=")
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