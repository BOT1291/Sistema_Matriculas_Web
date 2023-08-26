Imports System.Data.SqlClient

Public Class DatosCursos

    Public Sub Grabar(ByVal iCarrera As Entidades.EntiCursos, ByVal iAccion As Entidades.EntiEnumeradores.Accion)

        Dim spName As String = "SP_MantenimientoCurso"

        Dim lstParametros As New List(Of SqlParameter) From {
        New SqlParameter("@Accion", CShort(iAccion)),
        New SqlParameter("@Carrera", iCarrera.Carrera),
        New SqlParameter("@Identificacion", iCarrera.Id),
        New SqlParameter("@Nombre", iCarrera.Nombre),
        New SqlParameter("@Creditos", iCarrera.Creditos),
        New SqlParameter("@Nota_min", iCarrera.Nota_minima),
        New SqlParameter("@Estudiantes_min", iCarrera.Estudiantes_Min),
        New SqlParameter("@Estudiantes_max", iCarrera.Estudiantes_Max),
        New SqlParameter("@Grado", iCarrera.Grado),
        New SqlParameter("@Estado", iCarrera.Estado),
        New SqlParameter("@Costo", iCarrera.Costo)
        }

        Dim iConexion As New DatosSQL.DatosSQL
        iConexion.ExecuteSP(spName, lstParametros)

    End Sub


    Public Function ObtenerC() As DataTable

        Dim strConsultaSQL As String = "select Carrera_id as ""Carrera"", id_codigo As ""Identificacion"", c.nombre As ""Nombre"", creditos As ""Creditos"", nota_min As ""Nota_min"", estudiantes_min As
""Estudiantes_min"", estudiantes_max as ""Estudiantes_max"", g.nombre as ""Grado"", estado as ""Estado"", costo as ""Costo"" 
From Curso c inner Join Grado g on c.grado_carrera = g.id"
        Dim iConexion As New DatosSQL.DatosSQL
        Return iConexion.QueryDBwithDT(strConsultaSQL)

    End Function

    'esta es la que tengo duda
    Public Function PruebaC(ByVal Optional CodigoCarrera As Integer = -1) As DataTable
        Dim strConsultaSQL As String = "select carrera_id as ""Carrera"", id_codigo as ""Identificacion"", nombre as ""Nombre"", creditos as ""Creditos"", nota_min as ""Nota_min"", estudiantes_min as ""Estudiantes_min"", estudiantes_max as ""Estudiantes_max"", grado_carrera as ""Grado"", estado as ""Estado"", costo as ""Costo"" From Curso"

        If CodigoCarrera > -1 Then
            strConsultaSQL &= " Where id_codigo = " & CodigoCarrera
        End If

        Dim iConexion As New DatosSQL.DatosSQL
        Return iConexion.QueryDBwithDT(strConsultaSQL)
    End Function

End Class
