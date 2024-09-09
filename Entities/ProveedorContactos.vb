Public Class ProveedorContactos
    Public Property ProveContactoID() As Integer
        Get
            Return m_ProveContactoID
        End Get
        Set(value As Integer)
            m_ProveContactoID = Value
        End Set
    End Property
    Private m_ProveContactoID As Integer
    Public Property ProveedorID() As Integer
        Get
            Return m_ProveedorID
        End Get
        Set(value As Integer)
            m_ProveedorID = Value
        End Set
    End Property
    Private m_ProveedorID As Integer
    Public Property ProveedorContacto() As [String]
        Get
            Return m_ProveedorContacto
        End Get
        Set(value As [String])
            m_ProveedorContacto = Value
        End Set
    End Property
    Private m_ProveedorContacto As [String]
    Public Property ProveedorContactoCorreo() As [String]
        Get
            Return m_ProveedorContactoCorreo
        End Get
        Set(value As [String])
            m_ProveedorContactoCorreo = Value
        End Set
    End Property
    Private m_ProveedorContactoCorreo As [String]

End Class
