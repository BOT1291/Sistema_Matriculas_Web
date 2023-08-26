Imports System.Data.SqlClient

Public Class DatosMatricula

    Public Sub Grabar(ByVal iMatricula As Entidades.EntiMatricula, ByVal iAccion As Entidades.EntiEnumeradores.Accion)

        Dim spName As String = "RegistrarMatricula"

        Dim lstParametros As New List(Of SqlParameter) From {
        New SqlParameter("@Accion", CShort(iAccion)),
        New SqlParameter("@Codigo", iMatricula.Codigo),
        New SqlParameter("@Carnet", iMatricula.CodigoEstudiante),
        New SqlParameter("@Cuatrimestre", iMatricula.Cuatrimestre),
        New SqlParameter("@Porcentaje", iMatricula.PorcentajeBeca)
        }

        Dim iConexion As New DatosSQL.DatosSQL
        iConexion.ExecuteSP(spName, lstParametros)
    End Sub

End Class
