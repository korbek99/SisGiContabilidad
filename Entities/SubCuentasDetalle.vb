Public Class SubCuentasDetalle
    Public Property SubCuentaDetalleID() As Integer
        Get
            Return m_SubCuentaDetalleID
        End Get
        Set(value As Integer)
            m_SubCuentaDetalleID = Value
        End Set
    End Property
    Private m_SubCuentaDetalleID As Integer
    Public Property SubCuentaID() As Integer
        Get
            Return m_SubCuentaID
        End Get
        Set(value As Integer)
            m_SubCuentaID = Value
        End Set
    End Property
    Private m_SubCuentaID As Integer
    Public Property NumeroEEPP() As Integer
        Get
            Return m_NumeroEEPP
        End Get
        Set(value As Integer)
            m_NumeroEEPP = Value
        End Set
    End Property
    Private m_NumeroEEPP As Integer
    Public Property DescripcionEstadoPago() As [String]
        Get
            Return m_DescripcionEstadoPago
        End Get
        Set(value As [String])
            m_DescripcionEstadoPago = Value
        End Set
    End Property
    Private m_DescripcionEstadoPago As [String]
    Public Property FechaEEPP() As Date
        Get
            Return m_FechaEEPP
        End Get
        Set(value As Date)
            m_FechaEEPP = Value
        End Set
    End Property
    Private m_FechaEEPP As Date
    Public Property MonedaEEPP() As Decimal
        Get
            Return m_MonedaEEPP
        End Get
        Set(value As Decimal)
            m_MonedaEEPP = Value
        End Set
    End Property
    Private m_MonedaEEPP As Decimal
    Public Property MontoEEPP() As Decimal
        Get
            Return m_MontoEEPP
        End Get
        Set(value As Decimal)
            m_MontoEEPP = Value
        End Set
    End Property
    Private m_MontoEEPP As Decimal
    Public Property ImpuestoEEPP() As Decimal
        Get
            Return m_ImpuestoEEPP
        End Get
        Set(value As Decimal)
            m_ImpuestoEEPP = Value
        End Set
    End Property
    Private m_ImpuestoEEPP As Decimal
    Public Property TotalEEPP() As Decimal
        Get
            Return m_TotalEEPP
        End Get
        Set(value As Decimal)
            m_TotalEEPP = Value
        End Set
    End Property
    Private m_TotalEEPP As Decimal
End Class
