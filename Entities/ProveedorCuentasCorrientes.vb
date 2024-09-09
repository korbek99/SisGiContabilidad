Public Class ProveedorCuentasCorrientes
    Public Property ProveCuCoID() As Integer
        Get
            Return m_ProveCuCoID
        End Get
        Set(value As Integer)
            m_ProveCuCoID = Value
        End Set
    End Property
    Private m_ProveCuCoID As Integer
    Public Property ProveedorID() As Integer
        Get
            Return m_ProveedorID
        End Get
        Set(value As Integer)
            m_ProveedorID = Value
        End Set
    End Property
    Private m_ProveedorID As Integer
    Public Property BancoID() As Integer
        Get
            Return m_BancoID
        End Get
        Set(value As Integer)
            m_BancoID = Value
        End Set
    End Property
    Private m_BancoID As Integer
    Public Property ProveedorCuentasCorrientes() As [String]
        Get
            Return m_ProveedorCuentasCorrientes
        End Get
        Set(value As [String])
            m_ProveedorCuentasCorrientes = Value
        End Set
    End Property
    Private m_ProveedorCuentasCorrientes As [String]

End Class
