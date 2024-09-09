Imports Entities
Imports Business
Public Class AgregarTipoDoc
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
        Dim var As New GIC_TipoDocumento
        var = Business.BFTipoDocumento.GetById(ActionRecord)
        Txttipodoc.Text = var.TipoDocumentoNombre
        'Checkactivo.Checked = Banco.Activo
    End Sub

    Protected Sub Redireccionar()
        Dim directionURL As String
        directionURL = "ListaTipoDoc.aspx"
        Response.Redirect(directionURL)
    End Sub

    Protected Sub Limpiar()
        Txttipodoc.Text = ""
        Checkactivo.Checked = False
    End Sub

    Protected Sub Btnnuevo_Click(sender As Object, e As EventArgs) Handles Btnnuevo.Click
        Limpiar()
    End Sub
    Function Validarcampos() As Boolean
        Validarcampos = False

        If String.IsNullOrEmpty(Txttipodoc.Text) Then
            Validarcampos = True
        Else
            Validarcampos = False
        End If
    End Function
    Protected Sub Deshabilitar()

    End Sub
    Protected Sub SaveRecord()
        If Validarcampos() = False Then
            Dim var As New TipoDocumento
            var.TipoDocumentoNombre = Txttipodoc.Text
            var.Activo = True
            If Business.BFTipoDocumento.AddData(var) = True Then
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
                Dim var As New Banco
                var.BancoID = IdRecord
                var.BancoNombre = Txttipodoc.Text
                var.Activo = Checkactivo.Checked
                If Business.BFBanco.ModData(var) = True Then
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
            Dim var As New Banco
            var.BancoID = IdRecord
            If Business.BFBanco.DeleteData(var) = True Then

            Else

            End If
        Else

        End If

        Redireccionar()
    End Sub
    Protected Sub EnableRecord()
        Txttipodoc.Enabled = True
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
        Txttipodoc.Enabled = True
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
        Txttipodoc.Enabled = False
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