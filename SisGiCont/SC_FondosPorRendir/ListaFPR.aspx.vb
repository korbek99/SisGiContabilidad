Imports Entities
Imports Business
Public Class ListaFPR
    Inherits System.Web.UI.Page
    Dim Codigo As Integer

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Codigo = 0
        If Not IsPostBack Then
            LlenarGrillalistar()
        End If
    End Sub
    Private Sub LlenarGrillalistar()
        Grdfpr.DataSource = Business.BFAfp.ListAllActive()
        Grdfpr.DataBind()
    End Sub
    Private Sub SetGridEmpty()

    End Sub

    Protected Sub Btnnuevo_Click(sender As Object, e As EventArgs) Handles Btnnuevo.Click
        Dim directionURL As String
        directionURL = "AgregarFPR.aspx"
        Response.Redirect(directionURL)
    End Sub
    Protected Sub Grdfpr_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles Grdfpr.RowCommand

        'Editar 
        '"Eliminar
        If e.CommandName = "Editar" Then

            Dim indice As Integer = Convert.ToInt32(e.CommandArgument)
            Dim gvRow As GridViewRow = Grdfpr.Rows(indice)
            Dim valorfila = gvRow.Cells(2).Text


            'Ahora en id tenemos el id de nuestra tabla.
            'Podemos realizar cualquier acción con este valor.
            Response.Redirect("AgregarFPR.aspx?id=" + valorfila)
        Else
            If e.CommandName = "Eliminar" Then

                Dim indice As Integer = Convert.ToInt32(e.CommandArgument)
                Dim id As Integer = Grdfpr.DataKeys(indice).Value
                Dim afps As FondoPorRendir
                afps.FPRID = id
                If Business.BFFondoPorRendir.DeleteData(afps) = True Then
                    Response.Redirect("ListaFPR.aspx")
                Else

                End If
            End If

        End If
    End Sub

    Protected Sub Grdfpr_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Grdfpr.SelectedIndexChanged

    End Sub
End Class