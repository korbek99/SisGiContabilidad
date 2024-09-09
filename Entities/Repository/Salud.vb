Public Class Salud
    Public Property SaludID() As Integer
        Get
            Return m_SaludID
        End Get
        Set(value As Integer)
            m_SaludID = Value
        End Set
    End Property
    Private m_SaludID As Integer
    Public Property SaludNombre() As [String]
        Get
            Return m_SaludNombre
        End Get
        Set(value As [String])
            m_SaludNombre = Value
        End Set
    End Property
    Private m_SaludNombre As [String]
    Public Property Activo() As Integer
        Get
            Return m_Activo
        End Get
        Set(value As Integer)
            m_Activo = Value
        End Set
    End Property
    Private m_Activo As Integer

End Class
