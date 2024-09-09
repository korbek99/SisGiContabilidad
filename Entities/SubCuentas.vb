Public Class SubCuentas
    Public Property SubCuentaID() As Integer
        Get
            Return m_SubCuentaID
        End Get
        Set(value As Integer)
            m_SubCuentaID = Value
        End Set
    End Property
    Private m_SubCuentaID As Integer
    Public Property CuentaContaID() As Integer
        Get
            Return m_CuentaContaID
        End Get
        Set(value As Integer)
            m_CuentaContaID = Value
        End Set
    End Property
    Private m_CuentaContaID As Integer
    Public Property SubCuentaNumero() As Integer
        Get
            Return m_SubCuentaNumero
        End Get
        Set(value As Integer)
            m_SubCuentaNumero = Value
        End Set
    End Property
    Private m_SubCuentaNumero As Integer
    Public Property SubCuentaNombre() As [String]
        Get
            Return m_SubCuentaNombre
        End Get
        Set(value As [String])
            m_SubCuentaNombre = Value
        End Set
    End Property
    Private m_SubCuentaNombre As [String]
    Public Property SubCuentaDescripcion() As [String]
        Get
            Return m_SubCuentaDescripcion
        End Get
        Set(value As [String])
            m_SubCuentaDescripcion = Value
        End Set
    End Property
    Private m_SubCuentaDescripcion As [String]
    Public Property SubCuentaFechaIng() As Date
        Get
            Return m_SubCuentaFechaIng
        End Get
        Set(value As Date)
            m_SubCuentaFechaIng = Value
        End Set
    End Property
    Private m_SubCuentaFechaIng As Date
    Public Property ClienteID() As Integer
        Get
            Return m_ClienteID
        End Get
        Set(value As Integer)
            m_ClienteID = Value
        End Set
    End Property
    Private m_ClienteID As Integer
    Public Property SubCuentaOfertaRefID() As Integer
        Get
            Return m_SubCuentaOfertaRefID
        End Get
        Set(value As Integer)
            m_SubCuentaOfertaRefID = Value
        End Set
    End Property
    Private m_SubCuentaOfertaRefID As Integer
    Public Property SubCuentaEstado() As Integer
        Get
            Return m_SubCuentaEstado
        End Get
        Set(value As Integer)
            m_SubCuentaEstado = Value
        End Set
    End Property
    Private m_SubCuentaEstado As Integer
    Public Property SubCuentasGradoID() As Integer
        Get
            Return m_SubCuentasGradoID
        End Get
        Set(value As Integer)
            m_SubCuentasGradoID = Value
        End Set
    End Property
    Private m_SubCuentasGradoID As Integer
    Public Property UsuarioID() As Integer
        Get
            Return m_UsuarioID
        End Get
        Set(value As Integer)
            m_UsuarioID = Value
        End Set
    End Property
    Private m_UsuarioID As Integer
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
