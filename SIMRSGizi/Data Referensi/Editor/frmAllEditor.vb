Imports System.ComponentModel
Imports WeifenLuo.WinFormsUI.Docking
Public Class frmAllEditor
    Private ahli As New Pein.AhliGizi
    Private jadi As New Pein.MakananOlahanJadi
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub
    Private Sub EnableVSRenderer(ByVal version As VisualStudioToolStripExtender.VsVersion, ByVal theme As ThemeBase)
        vsRender.SetStyle(StatusStrip1, version, theme)
    End Sub
    Private Sub frmAllEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.EnableVSRenderer(VisualStudioToolStripExtender.VsVersion.Vs2015, VS2015LightTheme1)
        Panel2.BackColor = VS2015LightTheme1.ColorPalette.ToolWindowSeparator ',.Background

        If Me.Text = "Ahli Gizi Editor" Then
            cboNama.DisplayMember = "namapetugasMedis"
            cboNama.DataSource = ahli.DataTenagaMedis
            cboNama.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            cboNama.AutoCompleteSource = AutoCompleteSource.CustomSource
            cboNama.AutoCompleteCustomSource = ahli.LoadAutoNamaPetugas
        ElseIf Me.Text = "Edit Ahli Gizi" Then
            cboNama.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            cboNama.AutoCompleteSource = AutoCompleteSource.CustomSource
            cboNama.AutoCompleteCustomSource = ahli.LoadAutoNamaPetugas
        End If
    End Sub
#Region "CRUD GIZI"
    Protected Sub SimpanGizi()
        If btnSimpan.Text = "Simpan" Then
            Dim p As DialogResult = MsgBox("Anda ingin menyimpan data " & cboNama.Text & "?", MsgBoxStyle.OkCancel, "Konfirmasi")
            If p = vbCancel Then
                Me.DialogResult = DialogResult.None
                Exit Sub
            ElseIf p = vbOK Then
                Me.DialogResult = DialogResult.OK
            End If
        End If
    End Sub
    Protected Sub EditGizi()
        If btnSimpan.Text = "Edit" Then
            Dim p As DialogResult = MsgBox("Anda ingin merubah/meng-edit data " & cboNama.Text & "?", MsgBoxStyle.OkCancel, "Konfirmasi")
            If p = vbCancel Then
                Me.DialogResult = DialogResult.None
                Exit Sub
            ElseIf p = vbOK Then
                Me.DialogResult = DialogResult.OK
            End If
        End If
    End Sub
#End Region

#Region "CRUD MAKANAN OLAHAN"
    Protected Sub SimpanMakananOlahan()
        If btnSimpan.Text = "Simpan" Then
            If txtNama.Text = Nothing Then
                MsgBox("Nama Makanan tidak boleh kosong!!")
                txtNama.Focus()
                Exit Sub
            Else
                Dim p As DialogResult = MsgBox("Anda ingin menyimpan data makanan " & txtNama.Text & "?", MsgBoxStyle.OkCancel, "Konfirmasi")
                If p = vbCancel Then
                    Me.DialogResult = DialogResult.None
                    Exit Sub
                ElseIf p = vbOK Then
                    Me.DialogResult = DialogResult.OK
                End If
            End If
        End If
    End Sub
#End Region

#Region "CRUD Satuan Saji"
    Protected Sub SimpanSatuanSaji()
        If btnSimpan.Text = "Simpan" Then
            If txtNama.Text = Nothing Then
                MsgBox("Nama satuan saji tidak boleh kosong!!")
                txtNama.Focus()
                Exit Sub
            Else
                Dim p As DialogResult = MsgBox("Anda ingin menyimpan data satuan saji " & txtNama.Text & "?", MsgBoxStyle.OkCancel, "Konfirmasi")
                If p = vbCancel Then
                    Me.DialogResult = DialogResult.None
                    Exit Sub
                ElseIf p = vbOK Then
                    Me.DialogResult = DialogResult.OK
                End If
            End If
        End If
    End Sub
    Protected Sub EditSatuanSaji()
        If btnSimpan.Text = "Edit" Then
            If txtNama.Text = Nothing Then
                MsgBox("Nama satuan saji tidak boleh kosong!!")
                txtNama.Focus()
                Exit Sub
            Else
                Dim p As DialogResult = MsgBox("Anda ingin merubah/meng-edit data " & txtNama.Text & "?", MsgBoxStyle.OkCancel, "Konfirmasi")
                If p = vbCancel Then
                    Me.DialogResult = DialogResult.None
                    Exit Sub
                ElseIf p = vbOK Then
                    Me.DialogResult = DialogResult.OK
                End If
            End If
        End If
    End Sub
#End Region

#Region "CRUD Kelas"
    Protected Sub SimpanKelas()
        If btnSimpan.Text = "Simpan" Then
            If txtNama.Text = Nothing Then
                MsgBox("Nama kelas gizi tidak boleh kosong!!")
                txtNama.Focus()
                Exit Sub
            Else
                Dim p As DialogResult = MsgBox("Anda ingin menyimpan data kelas " & txtNama.Text & "?", MsgBoxStyle.OkCancel, "Konfirmasi")
                If p = vbCancel Then
                    Me.DialogResult = DialogResult.None
                    Exit Sub
                ElseIf p = vbOK Then
                    Me.DialogResult = DialogResult.OK
                End If
            End If
        End If
    End Sub
    Protected Sub EditKelas()
        If btnSimpan.Text = "Edit" Then
            If txtNama.Text = Nothing Then
                MsgBox("Nama kelas gizi tidak boleh kosong!!")
                txtNama.Focus()
                Exit Sub
            Else
                Dim p As DialogResult = MsgBox("Anda ingin merubah/meng-edit data " & cboNama.Text & "?", MsgBoxStyle.OkCancel, "Konfirmasi")
                If p = vbCancel Then
                    Me.DialogResult = DialogResult.None
                    Exit Sub
                ElseIf p = vbOK Then
                    Me.DialogResult = DialogResult.OK
                End If
            End If
        End If
    End Sub
#End Region
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If Me.Text = "Ahli Gizi Editor" Then
            SimpanGizi()
        ElseIf Me.Text = "Edit Ahli Gizi" Then
            EditGizi()
        ElseIf Me.Text = "Makanan Olahan Editor" Then
            SimpanMakananOlahan()
        ElseIf Me.Text = "Satuan Saji Editor" Then
            SimpanSatuanSaji()
        ElseIf Me.Text = "Edit Satuan Saji" Then
            EditSatuanSaji()
        ElseIf Me.Text = "Simpan Kelas" Then
            SimpanKelas()
        ElseIf Me.Text = "Edit Kelas" Then
            EditKelas()
        End If
    End Sub
    Private Sub txtKode_TextChanged(sender As Object, e As EventArgs) Handles txtKode.TextChanged
        If Me.Text = "Makanan Olahan Editor" Then
            If jadi.isSame(txtKode.Text) Then
                epUser.SetError(txtKode, "Kode ini sudah ada.")

                btnSimpan.Enabled = False

            Else
                btnSimpan.Enabled = True
            End If
        Else

        End If
    End Sub
    Private Sub txtKode_KeyDown(sender As Object, e As KeyEventArgs) Handles txtKode.KeyDown
        If e.KeyCode = Keys.Back Then
            epUser.SetError(txtKode, String.Empty)
            btnSimpan.Enabled = True
        End If
    End Sub
    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        e.Handled = Not (Char.IsLetter(e.KeyChar) Or e.KeyChar = Chr(Keys.Back))
    End Sub
    Private Sub cboNama_DropDown(sender As Object, e As EventArgs) Handles cboNama.DropDown
        If Me.Text = "Edit Ahli Gizi" Then
            cboNama.DisplayMember = "namapetugasMedis"
            cboNama.DataSource = ahli.DataTenagaMedis
        End If
    End Sub
    Private Sub cboNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboNama.KeyPress
        Dim Allow As String
        Allow = "+-*:=`~!@#$%^&()_{}[]|\/?><.,;""'"
        'e.Handled = Not (Allow.Contains(e.KeyChar) Or e.KeyChar = Chr(Keys.Back))


        e.Handled = Char.IsLetterOrDigit(e.KeyChar) Or Char.IsWhiteSpace(e.KeyChar) Or e.KeyChar = Chr(Keys.Back) Or Allow.Contains(e.KeyChar)

    End Sub
End Class