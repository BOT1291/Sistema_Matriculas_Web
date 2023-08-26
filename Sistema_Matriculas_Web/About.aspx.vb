Public Class About
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        Try
            Dim eUsuarios As Entidades.EntiUsuarios = CType(Session("usuario"), Entidades.EntiUsuarios)
            If eUsuarios Is Nothing Then
                FormsAuthentication.RedirectToLoginPage()
            End If
        Catch ex As Exception

            Response.Redirect("~/Paginas/FrmError")
        End Try
    End Sub
End Class