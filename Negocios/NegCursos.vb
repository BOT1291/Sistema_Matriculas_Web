Public Class NegCursos

    Public Function ConsultarCurso()
        Dim iCarrera As New Datos.DatosCursos
        Return iCarrera.ObtenerC
    End Function

    Public Function Cursos(ByVal CodigoCarrera As Integer) As Entidades.EntiCursos

        Dim iCarrera As New Datos.DatosCursos
        Dim dtCarrera As DataTable = iCarrera.PruebaC(CodigoCarrera)

        Dim iInfoCarrera As Entidades.EntiCursos = Nothing

        If dtCarrera IsNot Nothing AndAlso dtCarrera.Rows.Count > 0 Then
            iInfoCarrera = New Entidades.EntiCursos With {
            .Carrera = CStr(dtCarrera.Rows(0)("Carrera")),
            .Id = CInt(dtCarrera.Rows(0)("Identificacion")),
            .Nombre = CStr(dtCarrera.Rows(0)("Nombre")),
            .Creditos = CInt(dtCarrera.Rows(0)("Creditos")),
            .Nota_minima = CInt(dtCarrera.Rows(0)("Nota_min")),
            .Estudiantes_Min = CInt(dtCarrera.Rows(0)("Estudiantes_min")),
            .Estudiantes_Max = CInt(dtCarrera.Rows(0)("Estudiantes_max")),
            .Grado = CStr(dtCarrera.Rows(0)("Grado")),
            .Estado = CStr(dtCarrera.Rows(0)("Estado")),
            .Costo = CInt(dtCarrera.Rows(0)("Costo"))
            }
        End If

        Return iInfoCarrera
    End Function

    Public Sub GrabarNEg(ByVal iCarrera As Entidades.EntiCursos, ByVal accion As Entidades.EntiEnumeradores.Accion)
        Dim iInfoCarrera As New Datos.DatosCursos
        iInfoCarrera.Grabar(iCarrera, accion)
    End Sub

End Class
