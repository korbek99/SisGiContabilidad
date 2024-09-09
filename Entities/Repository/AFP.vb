
Public Class AFP
    Private m_AfpID As Integer
    Private m_AfpNombre As [String]
    Private m_Activo As Integer

    Public Property AfpID() As Integer
        Get
            Return m_AfpID
        End Get
        Set(value As Integer)
            m_AfpID = Value
        End Set
    End Property

    Public Property AfpNombre() As [String]
        Get
            Return m_AfpNombre
        End Get
        Set(value As [String])
            m_AfpNombre = Value
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
