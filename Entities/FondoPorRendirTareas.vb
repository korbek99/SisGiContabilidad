Public Class FondoPorRendirTareas
    Public Property FPRTareasID() As Integer
        Get
            Return m_FPRTareasID
        End Get
        Set(value As Integer)
            m_FPRTareasID = Value
        End Set
    End Property
    Private m_FPRTareasID As Integer
    Public Property FPRTareasDescripcion() As [String]
        Get
            Return m_FPRTareasDescripcion
        End Get
        Set(value As [String])
            m_FPRTareasDescripcion = Value
        End Set
    End Property
    Private m_FPRTareasDescripcion As [String]

End Class
