Imports Entities
Public Class DALFichaPersonalHistorico
    Public dc As New GICont2015Entities2()
    'Public Function GetById(id As Integer) As GIC_FichaPersonal_Documentos

    '    Try

    '        Return dc.GIC_FichaPersonal_Documentos.FirstOrDefault(Function(o) o.FichaPersonalDoc.Equals(id))
    '    Catch ex As Exception
    '        Throw ex
    '    Finally
    '        dc.Database.Connection.Close()
    '        dc = Nothing
    '    End Try
    'End Function
    Public Function ListData() As DataSet
        Dim Dst As DataSet




        Return Dst
    End Function

    Public Function ListDataById() As DataSet
        Dim Dst As DataSet


        Return Dst
    End Function

    Public Function AddData() As Boolean



        Return False
    End Function
    Public Function ModData() As Boolean



        Return False
    End Function
    Public Function DeleteData() As Boolean



        Return False
    End Function
End Class
