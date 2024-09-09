Public Class Comuna
    Private m_ComunaID As Integer
    Private m_ProvinciaID As Integer
    Private m_ComunaNombre As [String]
    Private m_Activo As Integer

    Public Property ComunaID() As Integer
        Get
            Return m_ComunaID
        End Get
        Set(value As Integer)
            m_ComunaID = Value
        End Set
    End Property

    Public Property ProvinciaID() As Integer
        Get
            Return m_ProvinciaID
        End Get
        Set(value As Integer)
            m_ProvinciaID = Value
        End Set
    End Property

    Public Property ComunaNombre() As [String]
        Get
            Return m_ComunaNombre
        End Get
        Set(value As [String])
            m_ComunaNombre = Value
        End Set
    End Property

    Public Property Activo() As Integer
        Get
            Return m_Activo
        End Get
        Set(value As Integer)
            m_Activo = Value
        End Set
    End Property


End Class
