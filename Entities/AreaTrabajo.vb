Public Class AreaTrabajo
    Private m_AreaTrabID As Integer
    Private m_AreaTrabNombre As [String]
    Private m_Activo As Integer

    Public Property AreaTrabID() As Integer
        Get
            Return m_AreaTrabID
        End Get
        Set(value As Integer)
            m_AreaTrabID = Value
        End Set
    End Property

    Public Property AreaTrabNombre() As [String]
        Get
            Return m_AreaTrabNombre
        End Get
        Set(value As [String])
            m_AreaTrabNombre = Value
        End Set
    End Property

    Public Property Activo() As Integer
        Get
            Return m_Activo
        End Get
        Set(value As Integer)
            m_Activo = Value
        End Set
    End Property

End Class
