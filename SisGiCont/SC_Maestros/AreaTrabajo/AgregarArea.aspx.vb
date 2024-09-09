Imports Entities
Imports Business
Public Class AgregarArea
    Inherits System.Web.UI.Page
    Public ActionRecord As Integer

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ActionRecord = 0
        ActionRecord = Request.QueryString("id")
        If ActionRecord > 0 Then
            'EnableRecord()
            DisableRecordMod()
            loadData()
        Else

        End If


    End Sub
    Protected Sub loadData()
        Dim AreaTrabajo As New GIC_AreaTrabajo
        AreaTrabajo = Business.BFAreaTrabajo.GetById(ActionRecord)
        Txtarea.Text = AreaTrabajo.AreaTrabNombre
        Checkactivo.Checked = AreaTrabajo.Activo
    End Sub

    Protected Sub Redireccionar()
        Dim directionURL As String
        directionURL = "ListaArea.aspx"
        Response.Redirect(directionURL)
    End Sub

    Protected Sub Limpiar()
        Txtarea.Text = ""
        Checkactivo.Checked = False
    End Sub

    Protected Sub Btnnuevo_Click(sender As Object, e As EventArgs) Handles Btnnuevo.Click
        Limpiar()
    End Sub
    Function Validarcampos() As Boolean
        Validarcampos = False

        If String.IsNullOrEmpty(Txtarea.Text) Then
            Validarcampos = True
        Else
            Validarcampos = False
        End If
    End Function
    Protected Sub Deshabilitar()

    End Sub
    Protected Sub SaveRecord()
        If Validarcampos() = False Then
            Dim var As New AreaTrabajo
            var.AreaTrabNombre = Txtarea.Text
            var.Activo = True
            If Business.BFAreaTrabajo.AddData(var) = True Then
                Redireccionar()
            Else

            End If
        Else

        End If
        Limpiar()
        Redireccionar()
    End Sub
    Protected Sub UpdateRecord()
        Dim IdRecord As Integer
        IdRecord = ActionRecord

        If Validarcampos() = False Then
            If IdRecord > 0 Then
                Dim var As New AreaTrabajo
                var.AreaTrabID = IdRecord
                var.AreaTrabNombre = Txtarea.Text
                var.Activo = Checkactivo.Checked
                If Business.BFAreaTrabajo.ModData(var) = True Then
                    Redireccionar()
                Else
                    DisableRecordMod()
                End If
            Else

            End If
        Else



        End If
        Limpiar()
        Redireccionar()
    End Sub
    Protected Sub DeleteRecord()
        Dim IdRecord As Integer
        IdRecord = 0
        If IdRecord > 0 Then
            Dim var As New AreaTrabajo
            var.AreaTrabNombre = IdRecord
            If Business.BFAreaTrabajo.DeleteData(var) = True Then

            Else

            End If
        Else

        End If

        Redireccionar()
    End Sub
    Protected Sub EnableRecord()
        Txtarea.Enabled = True
        Btnnuevo.Enabled = True
        Btngrabar.Enabled = True
        BtnMod.Enabled = False
        Btnnuevo.Visible = True
        Btngrabar.Visible = True
        BtnMod.Visible = False
        BtnEliminar.Visible = False
        BtnEliminar.Enabled = False
    End Sub
    Protected Sub DisableRecordMod()
        Txtarea.Enabled = True
        Btnnuevo.Enabled = False
        Btngrabar.Enabled = False
        BtnMod.Enabled = True
        Btnnuevo.Visible = False
        Btngrabar.Visible = False
        BtnMod.Visible = True
        BtnEliminar.Visible = False
        BtnEliminar.Enabled = False
    End Sub
    Protected Sub DisableRecordDelete()
        Txtarea.Enabled = False
        Btnnuevo.Enabled = False
        Btngrabar.Enabled = False
        BtnMod.Enabled = True
        Btnnuevo.Visible = False
        Btngrabar.Visible = False
        BtnMod.Visible = False
        BtnEliminar.Visible = True
        BtnEliminar.Enabled = True
    End Sub

    Protected Sub Btngrabar_Click(sender As Object, e As EventArgs) Handles Btngrabar.Click
        SaveRecord()
        'System.Threading.Thread.Sleep(Convert.ToInt32(5000))
    End Sub

    Protected Sub BtnMod_Click(sender As Object, e As EventArgs) Handles BtnMod.Click
        UpdateRecord()
    End Sub

    Protected Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        DeleteRecord()
    End Sub
End Class