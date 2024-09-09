Public Class SubCuentasGradoSatisfaccion
    Public Property SubCuentasGradoID() As Integer
        Get
            Return m_SubCuentasGradoID
        End Get
        Set(value As Integer)
            m_SubCuentasGradoID = Value
        End Set
    End Property
    Private m_SubCuentasGradoID As Integer
    Public Property SubCuentasGradoSatisfDescrip() As [String]
        Get
            Return m_SubCuentasGradoSatisfDescrip
        End Get
        Set(value As [String])
            m_SubCuentasGradoSatisfDescrip = Value
        End Set
    End Property
    Private m_SubCuentasGradoSatisfDescrip As [String]

End Class
