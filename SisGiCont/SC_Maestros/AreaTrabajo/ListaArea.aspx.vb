Imports Entities
Imports Business
Public Class ListaArea
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not IsPostBack Then
            LlenarGrillalistar()
        End If
    End Sub
    Private Sub LlenarGrillalistar()
        GrdArea.DataSource = Business.BFAreaTrabajo.ListAllActive()
        GrdArea.DataBind()
    End Sub
    Private Sub SetGridEmpty()

    End Sub

    Protected Sub Btnnuevo_Click(sender As Object, e As EventArgs) Handles Btnnuevo.Click
        Dim directionURL As String
        directionURL = "AgregarArea.aspx"
        Response.Redirect(directionURL)
    End Sub
    Protected Sub GrdArea_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GrdArea.RowCommand

        'Editar 
        '"Eliminar
        If e.CommandName = "Editar" Then

            Dim indice As Integer = Convert.ToInt32(e.CommandArgument)
            Dim gvRow As GridViewRow = GrdArea.Rows(indice)
            Dim valorfila = gvRow.Cells(2).Text


            'Ahora en id tenemos el id de nuestra tabla.
            'Podemos realizar cualquier acción con este valor.
            Response.Redirect("AgregarAFP.aspx?id=" + valorfila)
        Else
            If e.CommandName = "Eliminar" Then

                Dim indice As Integer = Convert.ToInt32(e.CommandArgument)
                Dim id As Integer = GrdArea.DataKeys(indice).Value
                Dim vari As AreaTrabajo
                vari.AreaTrabID = id
                If Business.BFAreaTrabajo.DeleteData(vari) = True Then
                    Response.Redirect("ListaArea.aspx")
                Else

                End If
            End If

        End If
    End Sub

    Protected Sub GrdArea_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GrdArea.SelectedIndexChanged

    End Sub

End Class