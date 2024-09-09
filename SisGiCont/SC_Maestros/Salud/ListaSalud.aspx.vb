Imports Entities
Imports Business
Public Class ListaSalud
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            LlenarGrillalistar()
        End If
    End Sub
    Private Sub LlenarGrillalistar()
        GrdTiposalud.DataSource = Business.BFSalud.ListAllActive()
        GrdTiposalud.DataBind()
    End Sub
    Private Sub SetGridEmpty()

    End Sub

    Protected Sub Btnnuevo_Click(sender As Object, e As EventArgs) Handles Btnnuevo.Click
        Dim directionURL As String
        directionURL = "AgregarSalud.aspx"
        Response.Redirect(directionURL)
    End Sub
    Protected Sub GrdTiposalud_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GrdTiposalud.RowCommand

        'Editar 
        '"Eliminar
        If e.CommandName = "Editar" Then

            Dim indice As Integer = Convert.ToInt32(e.CommandArgument)
            Dim gvRow As GridViewRow = GrdTiposalud.Rows(indice)
            Dim valorfila = gvRow.Cells(2).Text


            'Ahora en id tenemos el id de nuestra tabla.
            'Podemos realizar cualquier acción con este valor.
            Response.Redirect("AgregarSalud.aspx?id=" + valorfila)
        Else
            If e.CommandName = "Eliminar" Then

                Dim indice As Integer = Convert.ToInt32(e.CommandArgument)
                Dim gvRow As GridViewRow = GrdTiposalud.Rows(indice)
                Dim valorfila = gvRow.Cells(2).Text
                Dim vari As Salud
                vari.SaludNombre = valorfila
                If Business.BFSalud.DeleteData(vari) = True Then
                    Response.Redirect("ListaSalud.aspx")
                Else

                End If
            End If

        End If
    End Sub

    Protected Sub GrdTiposalud_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GrdTiposalud.SelectedIndexChanged

    End Sub
End Class