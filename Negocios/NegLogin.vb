Public Class NegLogin

    Public Function validarLogiin(ByVal eUsuario As Entidades.EntiUsuarios)

        Try
            'Dim eUsuario As New Entidades.EntiUsuarios
            Dim iDatos As New Datos.DatosUsuario
            eUsuario.validarCredencial = False

            Dim dt As DataTable = iDatos.consultarusuario(eUsuario)

            If dt.Rows.Count <> 0 Then

                eUsuario.validarCredencial = True

            End If
            Return eUsuario
        Catch ex As Exception
            Throw ex
        End Try

    End Function

End Class
