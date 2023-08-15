Public Class FrmLogin
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub TxtRegistrar_Click(sender As Object, e As EventArgs) Handles TxtRegistrar.Click
        Dim blnusuariovalido As Boolean = txtPassword.Text
        If blnusuariovalido Then
            Session("Credenciales") = blnusuariovalido
            FormsAuthentication.RedirectFromLoginPage(txtPassword.Text, False)
        Else

        End If
    End Sub
End Class