Public Class NegMatricula

    Public Property RandomGenerator As Object

    Public Sub Grabar(ByVal iMatricula As Entidades.EntiMatricula, ByVal accion As Entidades.EntiEnumeradores.Accion)
        Dim iInfoMatricula As New Datos.DatosMatricula
        iInfoMatricula.Grabar(iMatricula, accion)
    End Sub

End Class
