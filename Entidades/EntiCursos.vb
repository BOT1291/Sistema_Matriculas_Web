Public Class EntiCursos

    Private strCarrera As String
    Private intId As Integer
    Private strNombre As String
    Private intCreditos As Integer
    Private intnota_minima As Integer
    Private intestudiantes_min As Integer
    Private intestudiantes_max As Integer
    Private strgrado As String
    Private strestado As String
    Private intcosto As Integer

    Public Property Carrera() As String
        Get
            Return strCarrera
        End Get
        Set(ByVal value As String)
            strCarrera = value
        End Set
    End Property

    Public Property Id() As Integer
        Get
            Return intId
        End Get
        Set(ByVal value As Integer)
            intId = value
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

    Public Property Creditos() As Integer
        Get
            Return intCreditos
        End Get
        Set(ByVal value As Integer)
            intCreditos = value
        End Set
    End Property

    Public Property Nota_minima() As Integer
        Get
            Return intnota_minima
        End Get
        Set(ByVal value As Integer)
            intnota_minima = value
        End Set
    End Property

    Public Property Estudiantes_Min() As Integer
        Get
            Return intestudiantes_min
        End Get
        Set(ByVal value As Integer)
            intestudiantes_min = value
        End Set
    End Property

    Public Property Estudiantes_Max() As Integer
        Get
            Return intestudiantes_max
        End Get
        Set(ByVal value As Integer)
            intestudiantes_max = value
        End Set
    End Property

    Public Property Grado() As String
        Get
            Return strgrado
        End Get
        Set(ByVal value As String)
            strgrado = value
        End Set
    End Property

    Public Property Estado() As String
        Get
            Return strestado
        End Get
        Set(ByVal value As String)
            strestado = value
        End Set
    End Property

    Public Property Costo() As Integer
        Get
            Return intcosto
        End Get
        Set(ByVal value As Integer)
            intcosto = value
        End Set
    End Property


End Class
