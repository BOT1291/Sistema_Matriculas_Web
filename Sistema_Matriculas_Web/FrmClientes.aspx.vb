Public Class FrmClientes
    Inherits PaginaBase

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.VerificarCredencial()
    End Sub

End Class