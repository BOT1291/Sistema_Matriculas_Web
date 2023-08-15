Public Class SiteMaster
    Inherits MasterPage

    Protected Sub LinkButton1_Click(sender As Object, e As EventArgs) Handles LinkButton1.Click
        'codigo para errores 
        Try
            FormsAuthentication.SignOut()
            Session.Clear()
            FormsAuthentication.RedirectToLoginPage()
        Catch ex As Exception

        End Try
    End Sub
End Class