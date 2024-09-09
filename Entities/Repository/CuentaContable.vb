Public Class CuentaContable
    Private m_CuentaContaID As Integer
    Private m_CuentaContaDescripcion As [String]
    Private m_Activo As Integer

    Public Property CuentaContaID() As Integer
        Get
            Return m_CuentaContaID
        End Get
        Set(value As Integer)
            m_CuentaContaID = Value
        End Set
    End Property

    Public Property CuentaContaDescripcion() As [String]
        Get
            Return m_CuentaContaDescripcion
        End Get
        Set(value As [String])
            m_CuentaContaDescripcion = Value
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
