Imports System.Data.SqlClient

Public Class DatosMatriculaCurso

    Public Sub GrabarCursos(ByVal iMatricula As Entidades.EntiMatriculaCurso, ByVal iAccion As Entidades.EntiEnumeradores.Accion)

        Dim spName As String = "RegistrarMatriculaCurso"

        Dim lstParametros As New List(Of SqlParameter) From {
        New SqlParameter("@Accion", CShort(iAccion)),
        New SqlParameter("@CodigoMatricula", iMatricula.CodigoMatricula),
        New SqlParameter("@CodigoCurso", iMatricula.CodigoCurso)
        }

        Dim iConexion As New DatosSQL.DatosSQL
        iConexion.ExecuteSP(spName, lstParametros)
    End Sub

    Public Function ObtenerCursos(ByVal Optional CodigoCarnet As Integer = -1) As DataTable
        'deben ir con los nombres de las columnas las cuales estan en la base de datos
        Dim strConsultaSQL As String = "select id_codigo,nombre from Carrera ca INNER JOIN Curso c ON ca.id = c.carrera_id inner join Estudiante e on e.carrera_id = c.carrera_id"

        If CodigoCarnet > -1 Then
            strConsultaSQL &= " where c.estado = 'Habilitado' and e.id_carnet = " & CodigoCarnet ' Agregamos un espacio antes de "WHERE"
        End If

        Dim iConexion As New DatosSQL.DatosSQL
        Return iConexion.QueryDBwithDT(strConsultaSQL)

    End Function

    Public Function ObtenerTotal(ByVal Optional CodigoCarnet As Integer = -1) As DataTable

        Dim strConsultaSQL As String = "select id_codigo,nombre from Carrera ca INNER JOIN Curso c ON ca.id = c.carrera_id inner join Estudiante e on e.carrera_id = c.carrera_id"

        If CodigoCarnet > -1 Then
            strConsultaSQL &= " where c.estado = 'Habilitado' and e.id_carnet = " & CodigoCarnet ' Agregamos un espacio antes de "WHERE"
        End If

        Dim iConexion As New DatosSQL.DatosSQL
        Return iConexion.QueryDBwithDT(strConsultaSQL)

    End Function



End Class
