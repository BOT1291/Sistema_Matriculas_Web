Public Class Contact
    Inherits PaginaBase

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        Me.VerificarCredencial()
    End Sub
End Class