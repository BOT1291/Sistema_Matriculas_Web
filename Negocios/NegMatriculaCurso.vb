Imports Entidades

Public Class NegMatriculaCurso
    Public Sub Grabar(ByVal iMatriculaC As Entidades.EntiMatriculaCurso, ByVal accion As Entidades.EntiEnumeradores.Accion)
        Dim iInfoMatriculaCurso As New Datos.DatosMatriculaCurso
        iInfoMatriculaCurso.GrabarCursos(iMatriculaC, accion)
    End Sub
    Public Function NombreCurso(ByVal CodigoCarrera As Integer, ByVal fila As Integer) As Entidades.EntiMatriculaTabla
        Dim iCurso As New Datos.DatosMatriculaCurso
        Dim dtCurso As DataTable = iCurso.ObtenerCursos(CodigoCarrera)

        Dim iInfoCurso As Entidades.EntiMatriculaTabla = Nothing

        If dtCurso IsNot Nothing AndAlso dtCurso.Rows.Count > 0 Then
            iInfoCurso = New Entidades.EntiMatriculaTabla With {
        .Codigo = CShort(dtCurso.Rows(fila)("id_codigo")),
        .Nombre = CStr(dtCurso.Rows(fila)("nombre"))
        }
        End If

        Return iInfoCurso
    End Function


    Sub GrabarCurso(idMatricula As Integer, codigoCurso As String)
        Dim infoMatriculaCu As New EntiMatriculaCurso With {
        .CodigoMatricula = idMatricula,
        .CodigoCurso = codigoCurso
        }
        Dim iMatriculaCu As New NegMatriculaCurso
        iMatriculaCu.Grabar(infoMatriculaCu, 1)
    End Sub

End Class
