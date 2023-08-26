Public Class NegEstudiante

    Public Sub Grabar(ByVal iEstudinate As Entidades.EntiEstudiante, ByVal accion As Entidades.EntiEnumeradores.Accion)
        Dim iInfoEstudiante As New Datos.DatosEstudiante
        iInfoEstudiante.Grabar(iEstudinate, accion)
    End Sub

End Class
