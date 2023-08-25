Public Class FrmListaCursos
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Dim iCarreras As New Negocios.NegCursos
            Dim dtCarreras As DataTable = iCarreras.ConsultarCurso
            Dim strListaCarreras As New System.Text.StringBuilder

            For Each drcarrera As DataRow In dtCarreras.Rows
                With strListaCarreras
                    .Append("<tr>")

                    Dim strcodigo As String = CInt(drcarrera("Identificacion"))
                    .Append("<th scope = ""row"" >")
                    .Append(strcodigo)
                    .Append("</th>")
                    .Append("<td>")
                    .Append(CStr(drcarrera("Carrera")))
                    .Append("</td>")
                    .Append("<td>")
                    .Append(CStr(drcarrera("Nombre")))
                    .Append("</td>")
                    .Append("<td>")
                    .Append(CStr(drcarrera("Creditos")))
                    .Append("</td>")
                    .Append("<td>")
                    .Append(CStr(drcarrera("Nota_min")))
                    .Append("</td>")
                    .Append("<td>")
                    .Append(CStr(drcarrera("Estudiantes_min")))
                    .Append("</td>")
                    .Append("<td>")
                    .Append(CStr(drcarrera("Estudiantes_max")))
                    .Append("</td>")
                    .Append("<td>")
                    .Append(CStr(drcarrera("Grado")))
                    .Append("</td>")
                    .Append("<td>")
                    .Append(CStr(drcarrera("Estado")))
                    .Append("</td>")
                    .Append("<td>")
                    .Append(CStr(drcarrera("Costo")))
                    .Append("</td>")
                    .Append("<td><a href=""FrmRegistroCursos.aspx?accion=2&codigo=")
                    .Append(strcodigo)
                    .Append(""" Class=""btn btn-primary"">Modificar</a></td>")
                    .Append("<td><a href=""FrmRegistroCursos.aspx?accion=3&codigo=")
                    .Append(strcodigo)
                    .Append("""Class=""btn btn-danger"">Eliminar</a></td>")
                    .Append("</tr>")
                End With
            Next

            Me.lstCurso.InnerHtml = strListaCarreras.ToString

        Catch ex As Exception
            Session("error") = ex
        End Try
    End Sub

End Class