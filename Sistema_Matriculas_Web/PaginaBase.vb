Public Class PaginaBase
    Inherits System.Web.UI.Page

    Protected Function VerificarCredencial()
        'Dim blnUsuarioLogueado As Boolean
        'Boolean.TryParse(Session("Credenciales"), blnUsuarioLogueado)

        'If Not blnUsuarioLogueado Then
        '    FormsAuthentication.RedirectToLoginPage()
        '    Return False
        'Else
        '    Return True
        'End If

        Return True
    End Function

End Class
