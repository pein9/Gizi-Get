Imports System.ComponentModel
Imports WeifenLuo.WinFormsUI.Docking
Public Class frmDietEditor
    Private tDiet As New Pein.Diet
    Private tKelDiet As New Pein.KelompokDiet
    Private dtDiet As DataTable
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Protected Overloads Overrides Sub WndProc(ByRef m As Message)
        'Define DoubleClick...
        Const WM_NCLBUTTONDBLCLK As Integer = &HA3


        If (m.Msg = WM_NCLBUTTONDBLCLK) Then
            Exit Sub
        End If
        MyBase.WndProc(m)
    End Sub
    Private Sub EnableVSRenderer(ByVal version As VisualStudioToolStripExtender.VsVersion, ByVal theme As ThemeBase)
        vsRender.SetStyle(StatusStrip1, version, theme)
    End Sub
    Private Sub frmDietEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.EnableVSRenderer(VisualStudioToolStripExtender.VsVersion.Vs2015, VS2015LightTheme1)
        Panel2.BackColor = VS2015LightTheme1.ColorPalette.ToolWindowSeparator ',.Background

        cboKelompokBahan.DisplayMember = "kelDiet"
        cboKelompokBahan.ValueMember = "kdKelDiet"
        cboKelompokBahan.DataSource = tKelDiet.DataKelompokDiet
    End Sub
    Private Sub cboLetter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboLetter.SelectedIndexChanged
        ' dtDiet = tDiet.DataKdDiet(cboLetter.Text)
        Me.lblKodeDiet.Text = FindMaxPlusDatatablewithNull(tDiet.DataKdDiet(cboLetter.Text), "KDDIET", cboLetter.Text, 3)
    End Sub
    Private Sub cboKelompokBahan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboKelompokBahan.SelectedIndexChanged
        If cboKelompokBahan.SelectedIndex = -1 Then
            Return
        Else
            txtKodeKelompok.Text = cboKelompokBahan.SelectedValue.ToString
        End If
    End Sub
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If cboLetter.Text = Nothing Then
            MsgBox("Anda harus memilih tipe huruf sebelum memasukkan kode no diet", MsgBoxStyle.Critical, "Akses Ditolak")
            Exit Sub
        ElseIf txtnmDiet.Text = Nothing Then
            MsgBox("Anda harus memasukkan nama diet", MsgBoxStyle.Critical, "Akses Ditolak")
            Exit Sub
        ElseIf cboKelompokBahan.Text = Nothing Then
            MsgBox("Anda harus memilih kelompok bahan", MsgBoxStyle.Critical, "Akses Ditolak")
            Exit Sub
        Else
            Dim p As DialogResult = MsgBox("Anda ingin menyimban data " & txtnmDiet.Text & " sebagai data baru ?", MsgBoxStyle.OkCancel, "Konfirmasi")
            If p = vbCancel Then
                Me.DialogResult = DialogResult.None
                Exit Sub
            ElseIf p = vbOK Then
                Me.DialogResult = DialogResult.Yes
            End If

        End If
    End Sub
    Private Sub txtnmDiet_Validating(sender As Object, e As CancelEventArgs) Handles txtnmDiet.Validating
        If String.IsNullOrEmpty(txtnmDiet.Text.Trim) Then
            epUser.SetError(txtnmDiet, "Nama diet harus diisi.")
            btnSimpan.Enabled = False
        Else
            epUser.SetError(txtnmDiet, String.Empty)
            btnSimpan.Enabled = True
        End If
    End Sub
    Private Sub txtnmDiet_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnmDiet.KeyPress
        e.Handled = Not (Char.IsLetter(e.KeyChar) Or e.KeyChar = Chr(Keys.Back))
    End Sub
    Private Sub txtKeterangan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKeterangan.KeyPress
        e.Handled = Not (Char.IsLetter(e.KeyChar) Or e.KeyChar = Chr(Keys.Back))
    End Sub
End Class