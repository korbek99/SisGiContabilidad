Public Class FichaPersonalDocumentos
    Public Property FichaPersonalDoc() As Integer
        Get
            Return m_FichaPersonalDoc
        End Get
        Set(value As Integer)
            m_FichaPersonalDoc = Value
        End Set
    End Property
    Private m_FichaPersonalDoc As Integer
    Public Property FichaPersonalID() As Integer
        Get
            Return m_FichaPersonalID
        End Get
        Set(value As Integer)
            m_FichaPersonalID = Value
        End Set
    End Property
    Private m_FichaPersonalID As Integer
    Public Property FichaPersonalDocumento() As Byte()
        Get
            Return m_FichaPersonalDocumento
        End Get
        Set(value As Byte())
            m_FichaPersonalDocumento = Value
        End Set
    End Property
    Private m_FichaPersonalDocumento As Byte()
    Public Property FichaPersonalDescripcion() As [String]
        Get
            Return m_FichaPersonalDescripcion
        End Get
        Set(value As [String])
            m_FichaPersonalDescripcion = Value
        End Set
    End Property
    Private m_FichaPersonalDescripcion As [String]

End Class
