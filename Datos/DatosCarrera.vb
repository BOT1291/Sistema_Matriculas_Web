Imports System.Data.SqlClient

Public Class DatosCarrera


    Public Sub Grabar(ByVal iCarrera As Entidades.EntiCarrera, ByVal iAccion As Entidades.EntiEnumeradores.Accion)

        Dim spName As String = "SP_MantenimientoCarrera"

        Dim lstParametros As New List(Of SqlParameter) From {
        New SqlParameter("@Accion", CShort(iAccion)),
        New SqlParameter("@CodigoCarrera", iCarrera.Identificacion),
        New SqlParameter("@Nombre", iCarrera.Nombre),
        New SqlParameter("@Estado", iCarrera.Estado)
        }

        Dim iConexion As New DatosSQL.DatosSQL
        iConexion.ExecuteSP(spName, lstParametros)


    End Sub

    Public Function ObtenerF() As DataTable
        'deben ir con los nombres de las columnas las cuales estan en la base de datos
        Dim strConsultaSQL As String = "Select id as ""CodigoCarrera"", nombre_c as ""Nombre"", estado as ""Estado"" From Carrera"

        Dim iConexion As New DatosSQL.DatosSQL
        Return iConexion.QueryDBwithDT(strConsultaSQL)

    End Function


    Public Function PruebaF(ByVal Optional CodigoCarrera As Integer = -1) As DataTable
        'deben ir con los nombres de las columnas las cuales estan en la base de datos
        Dim strConsultaSQL As String = "Select id as ""CodigoCarrera"", nombre_c as ""Nombre"", estado as ""Estado"" From Carrera"

        If CodigoCarrera > -1 Then
            strConsultaSQL &= " WHERE id = " & CodigoCarrera ' Agregamos un espacio antes de "WHERE"
        End If



        Dim iConexion As New DatosSQL.DatosSQL
        Return iConexion.QueryDBwithDT(strConsultaSQL)

    End Function

End Class
