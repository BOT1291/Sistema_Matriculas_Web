Public Class EntiMatriculaTabla

    Public shtCodigo As Short = 1
    Public Property Codigo() As Short
        Get
            Return shtCodigo
        End Get
        Set(ByVal value As Short)
            shtCodigo = value
        End Set
    End Property

    Public strNombre As String = String.Empty
    Public Property Nombre() As String
        Get
            Return strNombre
        End Get
        Set(ByVal value As String)
            strNombre = value
        End Set
    End Property

End Class
