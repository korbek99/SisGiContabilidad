Imports Entities
Imports Business
Public Class ListaBase
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not IsPostBack Then
            LlenarGrillalistar()
        End If
    End Sub
    Private Sub LlenarGrillalistar()
        GrdBase.DataSource = Business.BFAfp.ListAllActive()
        GrdBase.DataBind()
    End Sub
    Private Sub SetGridEmpty()

    End Sub

    Protected Sub Btnnuevo_Click(sender As Object, e As EventArgs) Handles Btnnuevo.Click
        Dim directionURL As String
        directionURL = "AgregarArea.aspx"
        Response.Redirect(directionURL)
    End Sub
    Protected Sub GrdBase_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GrdBase.RowCommand

        'Editar 
        '"Eliminar
        If e.CommandName = "Editar" Then

            Dim indice As Integer = Convert.ToInt32(e.CommandArgument)
            Dim gvRow As GridViewRow = GrdBase.Rows(indice)
            Dim valorfila = gvRow.Cells(2).Text


            'Ahora en id tenemos el id de nuestra tabla.
            'Podemos realizar cualquier acción con este valor.
            Response.Redirect("AgregarBase.aspx?id=" + valorfila)
        Else
            If e.CommandName = "Eliminar" Then

                Dim indice As Integer = Convert.ToInt32(e.CommandArgument)
                Dim gvRow As GridViewRow = GrdBase.Rows(indice)
                Dim valorfila = gvRow.Cells(2).Text
                'Dim vari As BaseC
                'vari.BancoID = valorfila
                'If Business.BFBanco.DeleteData(vari) = True Then
                '    Response.Redirect("ListaBanco.aspx")
                'Else

                'End If
            End If

        End If
    End Sub

    Protected Sub GrdBase_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GrdBase.SelectedIndexChanged

    End Sub
End Class