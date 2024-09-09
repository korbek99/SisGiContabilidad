Public Class FondoPorRendir
    Public Property FPRID() As Integer
        Get
            Return m_FPRID
        End Get
        Set(value As Integer)
            m_FPRID = Value
        End Set
    End Property
    Private m_FPRID As Integer
    Public Property FichaPersonalID() As Integer
        Get
            Return m_FichaPersonalID
        End Get
        Set(value As Integer)
            m_FichaPersonalID = Value
        End Set
    End Property
    Private m_FichaPersonalID As Integer
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
    Public Property FPRMontoAsignado() As Decimal
        Get
            Return m_FPRMontoAsignado
        End Get
        Set(value As Decimal)
            m_FPRMontoAsignado = Value
        End Set
    End Property
    Private m_FPRMontoAsignado As Decimal
    Public Property FPRDescripcion() As Decimal
        Get
            Return m_FPRDescripcion
        End Get
        Set(value As Decimal)
            m_FPRDescripcion = Value
        End Set
    End Property
    Private m_FPRDescripcion As Decimal
    Public Property FPRMontoGastado() As Decimal
        Get
            Return m_FPRMontoGastado
        End Get
        Set(value As Decimal)
            m_FPRMontoGastado = Value
        End Set
    End Property
    Private m_FPRMontoGastado As Decimal
    Public Property FPRSaldoActual() As Decimal
        Get
            Return m_FPRSaldoActual
        End Get
        Set(value As Decimal)
            m_FPRSaldoActual = Value
        End Set
    End Property
    Private m_FPRSaldoActual As Decimal
    Public Property FPRFechaIngreso() As Date
        Get
            Return m_FPRFechaIngreso
        End Get
        Set(value As Date)
            m_FPRFechaIngreso = Value
        End Set
    End Property
    Private m_FPRFechaIngreso As Date
    Public Property FPRImagenSolicitud() As Byte()
        Get
            Return m_FPRImagenSolicitud
        End Get
        Set(value As Byte())
            m_FPRImagenSolicitud = Value
        End Set
    End Property
    Private m_FPRImagenSolicitud As Byte()
    Public Property FPRImagenTransDestinatario() As Byte()
        Get
            Return m_FPRImagenTransDestinatario
        End Get
        Set(value As Byte())
            m_FPRImagenTransDestinatario = Value
        End Set
    End Property
    Private m_FPRImagenTransDestinatario As Byte()
    Public Property FPRImagenRendicion() As Byte()
        Get
            Return m_FPRImagenRendicion
        End Get
        Set(value As Byte())
            m_FPRImagenRendicion = Value
        End Set
    End Property
    Private m_FPRImagenRendicion As Byte()
    Public Property FPRImagenTransSaldo() As Byte()
        Get
            Return m_FPRImagenTransSaldo
        End Get
        Set(value As Byte())
            m_FPRImagenTransSaldo = Value
        End Set
    End Property
    Private m_FPRImagenTransSaldo As Byte()
    Public Property EstadoFPRID() As Integer
        Get
            Return m_EstadoFPRID
        End Get
        Set(value As Integer)
            m_EstadoFPRID = Value
        End Set
    End Property
    Private m_EstadoFPRID As Integer
    Public Property FPRSubTotal() As Decimal
        Get
            Return m_FPRSubTotal
        End Get
        Set(value As Decimal)
            m_FPRSubTotal = Value
        End Set
    End Property
    Private m_FPRSubTotal As Decimal
    Public Property FPRTotal() As Decimal
        Get
            Return m_FPRTotal
        End Get
        Set(value As Decimal)
            m_FPRTotal = Value
        End Set
    End Property
    Private m_FPRTotal As Decimal
    Public Property UsuarioID() As Integer
        Get
            Return m_UsuarioID
        End Get
        Set(value As Integer)
            m_UsuarioID = Value
        End Set
    End Property
    Private m_UsuarioID As Integer


End Class
