Public Class EntiCarrera

#Region "Variables"
    Private strIdentificacion As String
    Private strNombre As String
    Private strEstado As String
#End Region

#Region "Propiedades"
    Public Property Identificacion() As String
        Get
            Return strIdentificacion
        End Get
        Set(ByVal value As String)
            strIdentificacion = value
        End Set
    End Property

    Public Property Nombre() As String
        Get
            Return strNombre
        End Get
        Set(ByVal value As String)
            strNombre = value
        End Set
    End Property

    Public Property Estado() As String
        Get
            Return strEstado
        End Get
        Set(ByVal value As String)
            strEstado = value
        End Set
    End Property
#End Region

End Class
