Imports Entities
Imports Business
Public Class ListaFicha
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            LlenarGrillalistar()
        End If
    End Sub
    Private Sub LlenarGrillalistar()
        Grdfich.DataSource = Business.BFFichaPersonal.ListAllActive()
        Grdfich.DataBind()
    End Sub
    Private Sub SetGridEmpty()

    End Sub

    Protected Sub Btnnuevo_Click(sender As Object, e As EventArgs) Handles Btnnuevo.Click
        Dim directionURL As String
        directionURL = "AgregarFicha.aspx"
        Response.Redirect(directionURL)
    End Sub
    Protected Sub Grdfich_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles Grdfich.RowCommand

        'Editar 
        '"Eliminar
        If e.CommandName = "Editar" Then

            Dim indice As Integer = Convert.ToInt32(e.CommandArgument)
            Dim gvRow As GridViewRow = Grdfich.Rows(indice)
            Dim valorfila = gvRow.Cells(2).Text


            'Ahora en id tenemos el id de nuestra tabla.
            'Podemos realizar cualquier acción con este valor.
            Response.Redirect("AgregarFicha.aspx?id=" + valorfila)
        Else
            If e.CommandName = "Eliminar" Then

                Dim indice As Integer = Convert.ToInt32(e.CommandArgument)
                Dim gvRow As GridViewRow = Grdfich.Rows(indice)
                Dim valorfila = gvRow.Cells(2).Text
                Dim vari As FichaPersonal
                vari.FichaPersonalID = valorfila
                If Business.BFFichaPersonal.DeleteData(vari) = True Then
                    Response.Redirect("ListaFicha.aspx")
                Else

                End If
            End If

        End If
    End Sub

    Protected Sub Grdfich_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Grdfich.SelectedIndexChanged

    End Sub
End Class