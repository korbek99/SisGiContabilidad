Public Class Region
    Public Property RegionID() As Integer
        Get
            Return m_RegionID
        End Get
        Set(value As Integer)
            m_RegionID = Value
        End Set
    End Property
    Private m_RegionID As Integer
    Public Property Region_numero_romano() As [String]
        Get
            Return m_Region_numero_romano
        End Get
        Set(value As [String])
            m_Region_numero_romano = Value
        End Set
    End Property
    Private m_Region_numero_romano As [String]
    Public Property RegionNombre() As [String]
        Get
            Return m_RegionNombre
        End Get
        Set(value As [String])
            m_RegionNombre = Value
        End Set
    End Property
    Private m_RegionNombre As [String]
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
    Public Property PaisID() As Integer
        Get
            Return m_PaisID
        End Get
        Set(value As Integer)
            m_PaisID = Value
        End Set
    End Property
    Private m_PaisID As Integer

End Class
