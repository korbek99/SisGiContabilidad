Public Class TipoDocumento
    Public Property TipoDocID() As Integer
        Get
            Return m_TipoDocID
        End Get
        Set(value As Integer)
            m_TipoDocID = Value
        End Set
    End Property
    Private m_TipoDocID As Integer
    Public Property TipoDocumentoNombre() As [String]
        Get
            Return m_TipoDocumentoNombre
        End Get
        Set(value As [String])
            m_TipoDocumentoNombre = Value
        End Set
    End Property
    Private m_TipoDocumentoNombre As [String]
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
