Public Class Banco

    Private m_BancoID As Integer
    Private m_Activo As Integer
    Private m_BancoNombre As [String]

    Public Property BancoID() As Integer
        Get
            Return m_BancoID
        End Get
        Set(value As Integer)
            m_BancoID = Value
        End Set
    End Property

    Public Property BancoNombre() As [String]
        Get
            Return m_BancoNombre
        End Get
        Set(value As [String])
            m_BancoNombre = Value
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
