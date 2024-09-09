Public Class FormaDePagoProveedor
    Public Property FormaDePagoProvID() As Integer
        Get
            Return m_FormaDePagoProvID
        End Get
        Set(value As Integer)
            m_FormaDePagoProvID = Value
        End Set
    End Property
    Private m_FormaDePagoProvID As Integer
    Public Property FormaDePagoDesc() As [String]
        Get
            Return m_FormaDePagoDesc
        End Get
        Set(value As [String])
            m_FormaDePagoDesc = Value
        End Set
    End Property
    Private m_FormaDePagoDesc As [String]
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
