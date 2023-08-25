Public Class EntiFuncionario

#Region "Variables"
    Private intCodigo As Integer
    Private strNombre As String
    Private strPrimerApellido As String
    Private strSegundoApellido As String
    Private strCorreo As String
    Private strClave As String
    Private strEstado As String
#End Region

#Region "Propiedades"
    Public Property Codigo() As Integer
        Get
            Return intCodigo
        End Get
        Set(ByVal value As Integer)
            intCodigo = value
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

    Public Property Primer_Apellido() As String
        Get
            Return strPrimerApellido
        End Get
        Set(ByVal value As String)
            strPrimerApellido = value
        End Set
    End Property

    Public Property Segundo_Apellido() As String
        Get
            Return strSegundoApellido
        End Get
        Set(ByVal value As String)
            strSegundoApellido = value
        End Set
    End Property

    Public Property Correo() As String
        Get
            Return strCorreo
        End Get
        Set(ByVal value As String)
            strCorreo = value
        End Set
    End Property

    Public Property Clave() As String
        Get
            Return strClave
        End Get
        Set(ByVal value As String)
            strClave = value
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
