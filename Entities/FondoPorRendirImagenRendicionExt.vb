Public Class FondoPorRendirImagenRendicionExt
    Public Property FPRImgExtID() As Integer
        Get
            Return m_FPRImgExtID
        End Get
        Set(value As Integer)
            m_FPRImgExtID = Value
        End Set
    End Property
    Private m_FPRImgExtID As Integer
    Public Property FPRID() As Integer
        Get
            Return m_FPRID
        End Get
        Set(value As Integer)
            m_FPRID = Value
        End Set
    End Property
    Private m_FPRID As Integer
    Public Property FPRImagenRendicion() As Byte()
        Get
            Return m_FPRImagenRendicion
        End Get
        Set(value As Byte())
            m_FPRImagenRendicion = Value
        End Set
    End Property
    Private m_FPRImagenRendicion As Byte()
    Public Property FPRFechaIngreso() As Date
        Get
            Return m_FPRFechaIngreso
        End Get
        Set(value As Date)
            m_FPRFechaIngreso = Value
        End Set
    End Property
    Private m_FPRFechaIngreso As Date
End Class
