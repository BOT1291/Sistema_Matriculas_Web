Public Class NegCarrera

    Public Function ConsultarNeg()
        Dim iCarrera As New Datos.DatosCarrera
        Return iCarrera.ObtenerF
    End Function

    Public Function Funcionarios(ByVal CodigoCarrera As Integer) As Entidades.EntiCarrera

        Dim iCarrera As New Datos.DatosCarrera
        Dim dtCarrera As DataTable = iCarrera.PruebaF(CodigoCarrera)

        Dim iInfoCarrera As Entidades.EntiCarrera = Nothing

        If dtCarrera IsNot Nothing AndAlso dtCarrera.Rows.Count > 0 Then
            iInfoCarrera = New Entidades.EntiCarrera With {
            .Identificacion = CStr(dtCarrera.Rows(0)("CodigoCarrera")),
            .Nombre = CStr(dtCarrera.Rows(0)("Nombre")),
            .Estado = CStr(dtCarrera.Rows(0)("Estado"))
            }
        End If

        Return iInfoCarrera
    End Function

    Public Sub GrabarN(ByVal iCarrera As Entidades.EntiCarrera, ByVal accion As Entidades.EntiEnumeradores.Accion)
        Dim iInfoCarrera As New Datos.DatosCarrera
        iInfoCarrera.Grabar(iCarrera, accion)
    End Sub

End Class
