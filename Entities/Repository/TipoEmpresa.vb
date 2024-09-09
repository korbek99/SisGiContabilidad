Public Class TipoEmpresa
    Public Property TipoEmpID() As Integer
        Get
            Return m_TipoEmpID
        End Get
        Set(value As Integer)
            m_TipoEmpID = Value
        End Set
    End Property
    Private m_TipoEmpID As Integer
    Public Property TipoEmpresaNombre() As [String]
        Get
            Return m_TipoEmpresaNombre
        End Get
        Set(value As [String])
            m_TipoEmpresaNombre = Value
        End Set
    End Property
    Private m_TipoEmpresaNombre As [String]
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
