Imports Pein
Imports System.ComponentModel
Imports WeifenLuo.WinFormsUI.Docking
Public Class frmSiklusMenuEditor

    Private tWaktu As New Pein.Waktu
    Private tOlahanJadi As New Pein.MakananOlahanJadi
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
    Private Sub frmSiklusMenuEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.EnableVSRenderer(VisualStudioToolStripExtender.VsVersion.Vs2015, VS2015LightTheme1)
        Panel2.BackColor = VS2015LightTheme1.ColorPalette.ToolWindowSeparator ',.Background
        cboWaktu.DisplayMember = "WAKTU"
        cboWaktu.ValueMember = "KDWAKTU"
        cboWaktu.DataSource = tWaktu.DataWaktu
        If btnSimpan.Text = "Simpan" Then
            cboKategory.DisplayMember = "nmMakanan"
            cboKategory.ValueMember = "kdMakanan"
            cboKategory.DataSource = tOlahanJadi.AmbilDataKategory

            cboNamaMakanan.DisplayMember = "nmMakanan"
            cboNamaMakanan.ValueMember = "kdMakanan"
            cboNamaMakanan.DataSource = tOlahanJadi.LihatDataOlahan(txtKdKategory.Text.Substring(0, 2), cboKategory.Text)

            epUser.SetError(cboNamaMakanan, Nothing)
            ' cboNamaMakanan.DisplayMember = "nmMakanan"
            'cboNamaMakanan.ValueMember = "kdMakanan"
            'cboNamaMakanan.DataSource = tOlahanJadi.AmbilDataMakanan
        ElseIf btnSimpan.Text = "Edit" Then
            txtKdKategory.Text = txtKodeMakanan.Text
            cboKategory.DisplayMember = "nmMakanan"
            cboKategory.ValueMember = "kdMakanan"
            cboKategory.DataSource = tOlahanJadi.LihatDataOlahanWithHeader(txtKdKategory.Text.Substring(0, 2))
        End If
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = 0 Then
            txtKeterangan.Text = "tanggal 1,11,21"
        ElseIf ComboBox1.SelectedIndex = 1 Then
            txtKeterangan.Text = "tanggal 2,12,22"
        ElseIf ComboBox1.SelectedIndex = 2 Then
            txtKeterangan.Text = "tanggal 3,13,23"
        ElseIf ComboBox1.SelectedIndex = 3 Then
            txtKeterangan.Text = "tanggal 4,14,24"
        ElseIf ComboBox1.SelectedIndex = 4 Then
            txtKeterangan.Text = "tanggal 5,15,25"
        ElseIf ComboBox1.SelectedIndex = 5 Then
            txtKeterangan.Text = "tanggal 6,16,26"
        ElseIf ComboBox1.SelectedIndex = 6 Then
            txtKeterangan.Text = "tanggal 7,17,27"
        ElseIf ComboBox1.SelectedIndex = 7 Then
            txtKeterangan.Text = "tanggal 8,18,28"
        ElseIf ComboBox1.SelectedIndex = 8 Then
            txtKeterangan.Text = "tanggal 9,19,29"
        ElseIf ComboBox1.SelectedIndex = 9 Then
            txtKeterangan.Text = "tanggal 10,20,30"
        ElseIf ComboBox1.SelectedIndex = 10 Then
            txtKeterangan.Text = "tanggal 31"
        End If
    End Sub
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If btnSimpan.Text = "Simpan" Then
            If ComboBox1.Text = Nothing Then
                MsgBox("Anda harus memilih tipe siklus terlebih dahulu!!")
                Exit Sub
            Else
                Dim p As DialogResult = MsgBox("Anda ingin menyimpan data makanan " & cboNamaMakanan.Text & " pada siklus ke -" & ComboBox1.Text & " ?", MsgBoxStyle.OkCancel, "Konfirmasi")
                If p = vbCancel Then
                    Me.DialogResult = DialogResult.None
                    Exit Sub
                ElseIf p = vbOK Then
                    Me.DialogResult = DialogResult.OK
                End If
            End If
        ElseIf btnSimpan.Text = "Edit" Then
            Dim p As DialogResult = MsgBox("Anda ingin mengubah data makanan " & cboNamaMakanan.Text & " untuk siklus ke -" & ComboBox1.Text & " ?", MsgBoxStyle.OkCancel, "Konfirmasi")
            If p = vbCancel Then
                Me.DialogResult = DialogResult.None
                Exit Sub
            ElseIf p = vbOK Then
                Me.DialogResult = DialogResult.OK
            End If
        End If
    End Sub
    Private Sub ComboBox1_Validating(sender As Object, e As CancelEventArgs) Handles ComboBox1.Validating
        If String.IsNullOrEmpty(ComboBox1.Text.Trim) Then
            epUser.SetError(ComboBox1, "Tipe siklus harus di pilih.")
            btnSimpan.Enabled = False
        Else
            epUser.SetError(ComboBox1, String.Empty)
            btnSimpan.Enabled = True
        End If
    End Sub

#Region "Combobox Kategory"
    Private Sub cboKategory_MouseWheel(sender As Object, e As MouseEventArgs) Handles cboKategory.MouseWheel
        Dim mwe As HandledMouseEventArgs = DirectCast(e, HandledMouseEventArgs)
        mwe.Handled = True
    End Sub
    Private Sub cboKategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboKategory.SelectedIndexChanged
        If cboKategory.SelectedIndex = -1 Then
            Return
        Else
            txtKdKategory.Text = cboKategory.SelectedValue.ToString
            epUser.SetError(cboNamaMakanan, Nothing)
        End If
    End Sub
    Private Sub cboKategory_DropDown(sender As Object, e As EventArgs) Handles cboKategory.DropDown
        cboKategory.DisplayMember = "nmMakanan"
        cboKategory.ValueMember = "kdMakanan"
        cboKategory.DataSource = tOlahanJadi.AmbilDataKategory
        cboNamaMakanan.Text = Nothing
        txtKodeMakanan.Text = Nothing
    End Sub
#End Region

#Region "Combobox Nama Makanan"
    Private Sub cboNamaMakanan_MouseWheel(sender As Object, e As MouseEventArgs) Handles cboNamaMakanan.MouseWheel
        Dim mwe As HandledMouseEventArgs = DirectCast(e, HandledMouseEventArgs)
        mwe.Handled = True
    End Sub
    Private Sub cboNamaMakanan_DropDown(sender As Object, e As EventArgs) Handles cboNamaMakanan.DropDown
        '  If btnSimpan.Text = "Edit" Then
        If cboNamaMakanan.SelectedIndex = -1 Then
            cboNamaMakanan.DisplayMember = "nmMakanan"
            cboNamaMakanan.ValueMember = "kdMakanan"
            cboNamaMakanan.DataSource = tOlahanJadi.LihatDataOlahan(txtKdKategory.Text.Substring(0, 2), cboKategory.Text)
        Else
            Return
        End If
        'End If
    End Sub
    Private Sub cboNamaMakanan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboNamaMakanan.SelectedIndexChanged
        ' If btnSimpan.Text = "Simpan" Then
        If cboNamaMakanan.SelectedIndex = -1 Then
            Return
        Else
            txtKodeMakanan.Text = cboNamaMakanan.SelectedValue.ToString
        End If
        ' End If
    End Sub
    Private Sub cboNamaMakanan_KeyDown(sender As Object, e As KeyEventArgs) Handles cboNamaMakanan.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtKodeMakanan.Text = Nothing Then
                epUser.SetError(cboNamaMakanan, "Data makanan ini tidak ada.")
                cboNamaMakanan.Text = Nothing
                btnSimpan.Enabled = False
            ElseIf Not tOlahanJadi.NmMakananisSame(cboNamaMakanan.Text) Then
                'MsgBox("Data makanan ini tidak ada")
                epUser.SetError(cboNamaMakanan, "Data makanan ini tidak ada.")
                btnSimpan.Enabled = False
                If tOlahanJadi.AmbilKodeMakanan(txtKodeMakanan.Text) Then
                    cboNamaMakanan.Text = tOlahanJadi.OlahNmMakanan
                    epUser.SetError(cboNamaMakanan, Nothing)
                    btnSimpan.Enabled = True
                End If
                ' Else
                ' epUser.SetError(cboNamaMakanan, Nothing)
                ' btnSimpan.Enabled = True
            End If
        End If

    End Sub
    Private Sub cboNamaMakanan_TextChanged(sender As Object, e As EventArgs) Handles cboNamaMakanan.TextChanged
        If Not tOlahanJadi.NmMakananisSame(cboNamaMakanan.Text) Then
            'MsgBox("Data makanan ini tidak ada")
            epUser.SetError(cboNamaMakanan, "Data makanan ini tidak ada.")
            btnSimpan.Enabled = False
        ElseIf txtKodeMakanan.Text = Nothing Then
            epUser.SetError(cboNamaMakanan, "Data makanan ini tidak ada.")
            btnSimpan.Enabled = False
        Else
            epUser.SetError(cboNamaMakanan, Nothing)
            btnSimpan.Enabled = True
        End If
    End Sub
#End Region

#Region "Combobox Waktu"
    Private Sub cboWaktu_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboWaktu.SelectedIndexChanged
        ' If btnSimpan.Text = "Simpan" Then
        If cboWaktu.SelectedIndex = -1 Then
            Return
        Else
            txtKdWaktu.Text = cboWaktu.SelectedValue.ToString
        End If
        '  End If
    End Sub
    Private Sub cboWaktu_DropDown(sender As Object, e As EventArgs) Handles cboWaktu.DropDown
        If btnSimpan.Text = "Edit" Then
            If cboWaktu.SelectedIndex = -1 Then
                cboWaktu.DisplayMember = "WAKTU"
                cboWaktu.ValueMember = "KDWAKTU"
                cboWaktu.DataSource = tWaktu.DataWaktu
            Else
                Return
            End If
        End If
    End Sub
    Private Sub cboWaktu_KeyDown(sender As Object, e As KeyEventArgs) Handles cboWaktu.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Not tWaktu.isSame(cboWaktu.Text) Then
                'MsgBox("Data makanan ini tidak ada")
                epUser.SetError(cboWaktu, "Data waktu ini tidak ada.")
                btnSimpan.Enabled = False
                If tWaktu.AmbilKodeWaktu(txtKdWaktu.Text) Then
                    cboWaktu.Text = tWaktu.NmWaktu
                    ' epUser.SetError(cboNamaMakanan, Nothing)
                    btnSimpan.Enabled = True
                End If
            Else
                'epUser.SetError(cboNamaMakanan, Nothing)
                btnSimpan.Enabled = True
            End If
        End If
    End Sub
    Private Sub cboWaktu_LostFocus(sender As Object, e As EventArgs) Handles cboWaktu.LostFocus
        If Not tWaktu.isSame(cboWaktu.Text) Then
            'MsgBox("Data makanan ini tidak ada")
            epUser.SetError(cboWaktu, "Data waktu ini tidak ada.")
            btnSimpan.Enabled = False
            If tWaktu.AmbilKodeWaktu(txtKdWaktu.Text) Then
                cboWaktu.Text = tWaktu.NmWaktu
                ' epUser.SetError(cboNamaMakanan, Nothing)
                btnSimpan.Enabled = True
            End If
        Else
            'epUser.SetError(cboNamaMakanan, Nothing)
            btnSimpan.Enabled = True
        End If
    End Sub
    Private Sub cboWaktu_TextChanged(sender As Object, e As EventArgs) Handles cboWaktu.TextChanged
        If Not tWaktu.isSame(cboWaktu.Text) Then
            'MsgBox("Data makanan ini tidak ada")
            epUser.SetError(cboWaktu, "Data waktu ini tidak ada.")
            btnSimpan.Enabled = False
        Else
            epUser.SetError(cboWaktu, Nothing)
            btnSimpan.Enabled = True
        End If
    End Sub
    Private Sub cboWaktu_MouseWheel(sender As Object, e As MouseEventArgs) Handles cboWaktu.MouseWheel
        Dim mwe As HandledMouseEventArgs = DirectCast(e, HandledMouseEventArgs)
        mwe.Handled = True
    End Sub
#End Region
End Class