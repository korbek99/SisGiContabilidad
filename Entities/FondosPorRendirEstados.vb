Public Class FondosPorRendirEstados

    Private m_EstadoFPRID As Integer
    Private m_EstadosFondoPorRendir As [String]
    Private m_EstadosFondoObservacion As [String]

    Public Property EstadoFPRID() As Integer
        Get
            Return m_EstadoFPRID
        End Get
        Set(value As Integer)
            m_EstadoFPRID = value
        End Set
    End Property

    Public Property EstadosFondoPorRendir() As [String]
        Get
            Return m_EstadosFondoPorRendir
        End Get
        Set(value As [String])
            m_EstadosFondoPorRendir = value
        End Set
    End Property

    Public Property EstadosFondoObservacion() As [String]
        Get
            Return m_EstadosFondoObservacion
        End Get
        Set(value As [String])
            m_EstadosFondoObservacion = value
        End Set
    End Property

End Class
