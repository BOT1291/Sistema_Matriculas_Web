Public Class FrmError
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub BtnError_Click(sender As Object, e As EventArgs) Handles BtnError.Click
        Response.Redirect("~/Paginas/FrmError.aspx")
    End Sub
End Class