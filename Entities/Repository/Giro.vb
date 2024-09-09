Public Class Giro
    Public Property GiroID() As Integer
        Get
            Return m_GiroID
        End Get
        Set(value As Integer)
            m_GiroID = Value
        End Set
    End Property
    Private m_GiroID As Integer
    Public Property GiroNombre() As [String]
        Get
            Return m_GiroNombre
        End Get
        Set(value As [String])
            m_GiroNombre = Value
        End Set
    End Property
    Private m_GiroNombre As [String]
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
