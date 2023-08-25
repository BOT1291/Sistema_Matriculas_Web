Public Class DatosUsuario

    Public Function consultarusuario(ByVal ususario As Entidades.EntiUsuarios)

        Try
            Dim consultar As New Text.StringBuilder

            consultar.Append($" SELECT correo FROM Funcionario WHERE correo = '{ususario.correoenti}' AND clave = '{ususario.claveenti}' AND estado = 'activo' ")

            Dim iDatos As New DatosSQL.DatosSQL
            Return iDatos.QueryDBwithDT(consultar.ToString)

        Catch ex As Exception
            Throw ex
        End Try

    End Function

End Class
