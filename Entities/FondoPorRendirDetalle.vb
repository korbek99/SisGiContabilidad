Public Class FondoPorRendirDetalle
    Public Property FPRDetalleID() As Integer
        Get
            Return m_FPRDetalleID
        End Get
        Set(value As Integer)
            m_FPRDetalleID = Value
        End Set
    End Property
    Private m_FPRDetalleID As Integer
    Public Property FPRID() As Integer
        Get
            Return m_FPRID
        End Get
        Set(value As Integer)
            m_FPRID = Value
        End Set
    End Property
    Private m_FPRID As Integer
    Public Property FPRFechaIngresoDetalle() As Date
        Get
            Return m_FPRFechaIngresoDetalle
        End Get
        Set(value As Date)
            m_FPRFechaIngresoDetalle = Value
        End Set
    End Property
    Private m_FPRFechaIngresoDetalle As Date
    Public Property FPRDescripcionDetalle() As [String]
        Get
            Return m_FPRDescripcionDetalle
        End Get
        Set(value As [String])
            m_FPRDescripcionDetalle = Value
        End Set
    End Property
    Private m_FPRDescripcionDetalle As [String]
    Public Property FPRNumeroDocumento() As Integer
        Get
            Return m_FPRNumeroDocumento
        End Get
        Set(value As Integer)
            m_FPRNumeroDocumento = Value
        End Set
    End Property
    Private m_FPRNumeroDocumento As Integer
    Public Property FPRTareasID() As Integer
        Get
            Return m_FPRTareasID
        End Get
        Set(value As Integer)
            m_FPRTareasID = Value
        End Set
    End Property
    Private m_FPRTareasID As Integer
    Public Property Tasa() As Decimal
        Get
            Return m_Tasa
        End Get
        Set(value As Decimal)
            m_Tasa = Value
        End Set
    End Property
    Private m_Tasa As Decimal
    Public Property Total() As Decimal
        Get
            Return m_Total
        End Get
        Set(value As Decimal)
            m_Total = Value
        End Set
    End Property
    Private m_Total As Decimal

End Class
