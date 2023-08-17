Public Class SiteMaster
    Inherits MasterPage

    Protected Sub LkCerrarSesion_Click(sender As Object, e As EventArgs) Handles LkCerrarSesion.Click
        'codigo para errores 
        Try
            FormsAuthentication.SignOut()
            Session.Clear()
            FormsAuthentication.RedirectToLoginPage()
        Catch ex As Exception

        End Try
    End Sub
End Class