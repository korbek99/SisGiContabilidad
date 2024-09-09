Public Class ProveedorTipo
    Public Property TipoProveID() As Integer
        Get
            Return m_TipoProveID
        End Get
        Set(value As Integer)
            m_TipoProveID = Value
        End Set
    End Property
    Private m_TipoProveID As Integer
    Public Property TipoProveedorNombre() As [String]
        Get
            Return m_TipoProveedorNombre
        End Get
        Set(value As [String])
            m_TipoProveedorNombre = Value
        End Set
    End Property
    Private m_TipoProveedorNombre As [String]
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
