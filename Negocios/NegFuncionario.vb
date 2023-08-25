Public Class NegFuncionario

    Public Function ConsultarNeg()
        Dim iCarrera As New Datos.DatosFuncionarios
        Return iCarrera.ObtenerF
    End Function

    Public Function Funcionarios(ByVal CodigoCarrera As Integer) As Entidades.EntiFuncionario

        Dim iCarrera As New Datos.DatosFuncionarios
        Dim dtCarrera As DataTable = iCarrera.PruebaF(CodigoCarrera)

        Dim iInfoCarrera As Entidades.EntiFuncionario = Nothing

        If dtCarrera IsNot Nothing AndAlso dtCarrera.Rows.Count > 0 Then
            iInfoCarrera = New Entidades.EntiFuncionario With {
            .Codigo = CInt(dtCarrera.Rows(0)("CodigoFuncionario")),
            .Nombre = CStr(dtCarrera.Rows(0)("Nombre")),
            .Primer_Apellido = CStr(dtCarrera.Rows(0)("PrimerApellido")),
            .Segundo_Apellido = CStr(dtCarrera.Rows(0)("SegundoApellido")),
            .Correo = CStr(dtCarrera.Rows(0)("Correo")),
            .Clave = CStr(dtCarrera.Rows(0)("Clave")),
            .Estado = CStr(dtCarrera.Rows(0)("Estado"))
            }
        End If

        Return iInfoCarrera
    End Function

    Public Sub GrabarN(ByVal iCarrera As Entidades.EntiFuncionario, ByVal accion As Entidades.EntiEnumeradores.Accion)
        Dim iInfoCarrera As New Datos.DatosFuncionarios
        iInfoCarrera.Grabar(iCarrera, accion)
    End Sub


End Class
