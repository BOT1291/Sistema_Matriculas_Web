Imports System.Data.SqlClient

Public Class DatosFuncionarios


    Public Sub Grabar(ByVal iCarrera As Entidades.EntiFuncionario, ByVal iAccion As Entidades.EntiEnumeradores.Accion)

        Dim spName As String = "RegistrarFuncionario"

        Dim lstParametros As New List(Of SqlParameter) From {
        New SqlParameter("@Accion", CShort(iAccion)),
        New SqlParameter("@CodigoFuncionario", iCarrera.Codigo),
        New SqlParameter("@Nombre", iCarrera.Nombre),
        New SqlParameter("@PrimerApellido", iCarrera.Primer_Apellido),
        New SqlParameter("@SegundoApellido", iCarrera.Segundo_Apellido),
        New SqlParameter("@Correo", iCarrera.Correo),
        New SqlParameter("@Clave", iCarrera.Clave),
        New SqlParameter("@Estado", iCarrera.Estado)
        }

        Dim iConexion As New DatosSQL.DatosSQL
        iConexion.ExecuteSP(spName, lstParametros)


    End Sub

    Public Function ObtenerF() As DataTable
        'deben ir con los nombres de las columnas las cuales estan en la base de datos
        Dim strConsultaSQL As String = "Select id as ""CodigoFuncionario"", nombre as ""Nombre"", primer_apellido as ""PrimerApellido"", segundo_apellido as ""SegundoApellido"", correo as ""Correo"", clave as ""Clave"", estado as ""Estado"" From Funcionario"

        Dim iConexion As New DatosSQL.DatosSQL
        Return iConexion.QueryDBwithDT(strConsultaSQL)

    End Function


    Public Function PruebaF(ByVal Optional CodigoCarrera As Integer = -1) As DataTable
        'deben ir con los nombres de las columnas las cuales estan en la base de datos
        Dim strConsultaSQL As String = "Select id as ""CodigoFuncionario"", nombre as ""Nombre"", primer_apellido as ""PrimerApellido"", segundo_apellido as ""SegundoApellido"", correo as ""Correo"", clave as ""Clave"", estado as ""Estado"" From Funcionario"

        If CodigoCarrera > -1 Then
            strConsultaSQL &= " WHERE id = " & CodigoCarrera ' Agregamos un espacio antes de "WHERE"
        End If



        Dim iConexion As New DatosSQL.DatosSQL
        Return iConexion.QueryDBwithDT(strConsultaSQL)

    End Function


End Class
