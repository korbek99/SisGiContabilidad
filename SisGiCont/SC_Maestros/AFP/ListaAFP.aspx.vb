
Imports Entities
Imports Business
Imports System.Data.Common.CommandTrees.ExpressionBuilder

Public Class ListaAFP
    Inherits System.Web.UI.Page
    Dim Codigo As Integer
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Codigo = 0
        If Not IsPostBack Then
            LlenarGrillalistar()
        End If
    End Sub
    Private Sub LlenarGrillalistar()
        GrdAfp.DataSource = Business.BFAfp.ListAllActive()
        GrdAfp.DataBind()
    End Sub
    Private Sub SetGridEmpty()

    End Sub

    Protected Sub Btnnuevo_Click(sender As Object, e As EventArgs) Handles Btnnuevo.Click
        Dim directionURL As String
        directionURL = "AgregarAFP.aspx"
        Response.Redirect(directionURL)
    End Sub
    Protected Sub GrdAfp_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GrdAfp.RowCommand

        'Editar 
        '"Eliminar
        If e.CommandName = "Editar" Then

            Dim indice As Integer = Convert.ToInt32(e.CommandArgument)
            Dim gvRow As GridViewRow = GrdAfp.Rows(indice)
            Dim valorfila = gvRow.Cells(2).Text


            'Ahora en id tenemos el id de nuestra tabla.
            'Podemos realizar cualquier acción con este valor.
            Response.Redirect("AgregarAFP.aspx?id=" + valorfila)
        Else
            If e.CommandName = "Eliminar" Then

                Dim indice As Integer = Convert.ToInt32(e.CommandArgument)
                Dim id As Integer = GrdAfp.DataKeys(indice).Value
                Dim afps As AFP
                afps.AfpID = id
                If Business.BFAfp.DeleteData(afps) = True Then
                    Response.Redirect("ListaAFP.aspx")
                Else

                End If
            End If

        End If
    End Sub

    Protected Sub GrdAfp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GrdAfp.SelectedIndexChanged

    End Sub
End Class