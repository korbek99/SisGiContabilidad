Public Class FormaDePago
    Public Property FormaDePagoID() As Integer
        Get
            Return m_FormaDePagoID
        End Get
        Set(value As Integer)
            m_FormaDePagoID = Value
        End Set
    End Property
    Private m_FormaDePagoID As Integer
    Public Property FormaDePagoDesc() As [String]
        Get
            Return m_FormaDePagoDesc
        End Get
        Set(value As [String])
            m_FormaDePagoDesc = Value
        End Set
    End Property
    Private m_FormaDePagoDesc As [String]
    Public Property Orden() As Integer
        Get
            Return m_Orden
        End Get
        Set(value As Integer)
            m_Orden = Value
        End Set
    End Property
    Private m_Orden As Integer
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
