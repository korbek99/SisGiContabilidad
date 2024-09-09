Public Class FichaPersonalCuentasCorrientes

    Public Property PersonalCuCoID() As Integer
        Get
            Return m_PersonalCuCoID
        End Get
        Set(value As Integer)
            m_PersonalCuCoID = Value
        End Set
    End Property
    Private m_PersonalCuCoID As Integer
    Public Property FichaPersonalID() As Integer
        Get
            Return m_FichaPersonalID
        End Get
        Set(value As Integer)
            m_FichaPersonalID = Value
        End Set
    End Property
    Private m_FichaPersonalID As Integer
    Public Property BancoID() As Integer
        Get
            Return m_BancoID
        End Get
        Set(value As Integer)
            m_BancoID = Value
        End Set
    End Property
    Private m_BancoID As Integer
    Public Property PersonalCuentasCorrientes() As [String]
        Get
            Return m_PersonalCuentasCorrientes
        End Get
        Set(value As [String])
            m_PersonalCuentasCorrientes = Value
        End Set
    End Property
    Private m_PersonalCuentasCorrientes As [String]
End Class
