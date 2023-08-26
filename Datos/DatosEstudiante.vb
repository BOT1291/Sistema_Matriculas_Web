Imports System.Data.SqlClient

Public Class DatosEstudiante
    Public Sub Grabar(ByVal iEstudiante As Entidades.EntiEstudiante, ByVal iAccion As Entidades.EntiEnumeradores.Accion)

        Dim spName As String = "RegistrarEstudiante"

        Dim lstParametros As New List(Of SqlParameter) From {
        New SqlParameter("@Accion", CShort(iAccion)),
        New SqlParameter("@CodigoCarnet", iEstudiante.intCarnet),
        New SqlParameter("@CodigoCarrera", iEstudiante.strCarrera),
        New SqlParameter("@Identificacion", iEstudiante.intId),
        New SqlParameter("@Nombre", iEstudiante.strNombre),
        New SqlParameter("@Apellidos", iEstudiante.strApellidos),
        New SqlParameter("@Telefono", iEstudiante.intTelefono),
        New SqlParameter("@Correo", iEstudiante.strCorreo),
        New SqlParameter("@FechaNacimiento", iEstudiante.dateFechaNacimiento),
        New SqlParameter("@Direccion", iEstudiante.strDireccionExacta),
        New SqlParameter("@PorcentajeBeca", iEstudiante.intPorcentajeBeca)
        }

        Dim iConexion As New DatosSQL.DatosSQL
        iConexion.ExecuteSP(spName, lstParametros)


    End Sub

    Public Function ObtenerF() As DataTable
        'deben ir con los nombres de las columnas las cuales estan en la base de datos
        Dim strConsultaSQL As String = "Select cod_funcionarios as ""CodigoFuncionarios"", nombre as ""NombreFun"", primer_apellido as ""PApellido"", segundo_apelldo as ""SApellido"", correo as ""CorreoFun"", clave as ""ClaveFun"", estado as ""EstadoFun"" From Funcionarios"

        Dim iConexion As New DatosSQL.DatosSQL
        Return iConexion.QueryDBwithDT(strConsultaSQL)

    End Function
End Class
