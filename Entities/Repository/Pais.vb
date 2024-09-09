Public Class Pais
    Public Property PaisID() As Integer
        Get
            Return m_PaisID
        End Get
        Set(value As Integer)
            m_PaisID = Value
        End Set
    End Property
    Private m_PaisID As Integer
    Public Property PaisNombre() As [String]
        Get
            Return m_PaisNombre
        End Get
        Set(value As [String])
            m_PaisNombre = Value
        End Set
    End Property
    Private m_PaisNombre As [String]

End Class
