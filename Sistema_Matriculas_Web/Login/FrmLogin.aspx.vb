Public Class FrmLogin
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub BtnRegistrar_Click(sender As Object, e As EventArgs) Handles BtnRegistrar.Click

        Try
            ' Crear una instancia del objeto para almacenar información del usuario y instancia de la clase de negocio para la autenticación
            Dim eUsuario As New Entidades.EntiUsuarios
            Dim iSeguridad As New Negocios.NegLogin

            ' Asignar los valores del usuario y la contraseña desde los campos de entrada
            eUsuario.correoenti = txtUsuario.Text
            eUsuario.claveenti = txtPassword.Text

            ' Realizar la validación de las credenciales mediante la clase de negocio
            eUsuario = iSeguridad.validarLogiin(eUsuario)

            ' Verificar si las credenciales son válidas
            If eUsuario.validarCredencial Then

                ' Guardar la información del usuario en la sesión y redireccionar a la pagina de inicio
                Session("usuario") = eUsuario
                FormsAuthentication.RedirectFromLoginPage(eUsuario.correoenti, False)
            Else
                ' Mostrar mensaje de credenciales inválidas 
                ScriptManager.RegisterStartupScript(Me, GetType(Page), "SweetAlert", "Swal.fire('Credenciales inválidas', 'Las credenciales que ingresadas son inválidas.', 'error');", True)
            End If
        Catch ex As Exception
            ' Mostrar mensaje de error 
            ScriptManager.RegisterStartupScript(Me, GetType(Page), "SweetAlert", "Swal.fire('Error', 'Hubo un fallo al iniciar sesión.', 'error');", True)
        End Try

    End Sub
End Class