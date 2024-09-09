Public Class Provincia
    Public Property ProvinciaID() As Integer
        Get
            Return m_ProvinciaID
        End Get
        Set(value As Integer)
            m_ProvinciaID = Value
        End Set
    End Property
    Private m_ProvinciaID As Integer
    Public Property RegionID() As Integer
        Get
            Return m_RegionID
        End Get
        Set(value As Integer)
            m_RegionID = Value
        End Set
    End Property
    Private m_RegionID As Integer
    Public Property ProvinciaNombre() As [String]
        Get
            Return m_ProvinciaNombre
        End Get
        Set(value As [String])
            m_ProvinciaNombre = Value
        End Set
    End Property
    Private m_ProvinciaNombre As [String]
    Public Property Capital() As [String]
        Get
            Return m_Capital
        End Get
        Set(value As [String])
            m_Capital = Value
        End Set
    End Property
    Private m_Capital As [String]
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
