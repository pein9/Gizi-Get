Imports System.ComponentModel
Imports WeifenLuo.WinFormsUI.Docking
Public Class frmBahanMakananEditor
    Private jenisBahan As New Pein.JenisMakanan
    Private kelBahan As New Pein.KelompokBahanMakanan
    Private golBahan As New Pein.GolonganBahanMakanan
    Dim ops As New Pein.BahanMakan
    Private bsdata As New BindingSource
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
    Private Sub frmBahanMakananEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.EnableVSRenderer(VisualStudioToolStripExtender.VsVersion.Vs2015, VS2015LightTheme1)
        Panel2.BackColor = VS2015LightTheme1.ColorPalette.ToolWindowSeparator ',.Background
        If btnSimpan.Text = "Simpan" Then
            'Kelompok Bahan Makanan
            cboKelompokBahan.DisplayMember = "KELOMPOKBAHAN"
            cboKelompokBahan.ValueMember = "KDKELOMPOKBAHAN"
            cboKelompokBahan.DataSource = kelBahan.DataKelompokBahan

            'Jenis Makanan
            'dtJenisMakanan = jenisM.DataJenisMakanan
            cboNamaJenis.DisplayMember = "NamaJenis"
            cboNamaJenis.ValueMember = "kdJenisMakanan"
            cboNamaJenis.DataSource = jenisBahan.DataJenisMakanan

            'Golongan Bahan Makanan
            'dtJenisMakanan = jenisM.DataJenisMakanan
            cboGol.DisplayMember = "GOLBAHAN"
            cboGol.ValueMember = "KDGOLBAHAN"
            cboGol.DataSource = golBahan.DataGolonganBahan
        ElseIf btnSimpan.Text = "Edit" Then
            cboGol.DataSource = Nothing
            'Kelompok Bahan Makanan
            If kelBahan.AmbilKodeKelompok(txtKodeKelompok.Text) Then
                cboKelompokBahan.Text = kelBahan.NamaKelompok
            End If

            'Jenis Makanan
            If jenisBahan.AmbilKodeJenis(txtKodeJenis.Text) Then
                cboNamaJenis.Text = jenisBahan.NamaJenis
            End If

            'Golongan Bahan Makanan
            If golBahan.AmbilKodeGol(txtKodeGolongan.Text) Then
                cboGol.Text = golBahan.NamaGol
            End If
        End If


    End Sub
    Protected Sub CRUD()
        If btnSimpan.Text = "Edit" Then
            If String.IsNullOrEmpty(txtStok.Text.Trim) Then
                MsgBox("Nilai stok tidak boleh null /kosong", MsgBoxStyle.Critical, "Fatal Error")
                btnSimpan.DialogResult = DialogResult.None
                Exit Sub
            ElseIf Val(txtStok.Text = 0) Then
                MsgBox("Nilai stok tidak boleh 0", MsgBoxStyle.Critical, "Critical Error")
                btnSimpan.DialogResult = DialogResult.None
                Exit Sub
            ElseIf String.IsNullOrEmpty(txtReorder.Text.Trim) Then
                MsgBox("Nilai batas minimal stok tidak boleh null /kosong", MsgBoxStyle.Critical, "Fatal Error")
                btnSimpan.DialogResult = DialogResult.None
                Exit Sub
            ElseIf Val(txtReorder.Text = 0) Then
                MsgBox("Nilai batas minimal stok tidak boleh 0", MsgBoxStyle.Critical, "Critical Error")
                btnSimpan.DialogResult = DialogResult.None
                Exit Sub
            Else
                Dim p As String = MsgBox("Anda ingin mengubah data " & txtNamaBahan.Text & "?", MsgBoxStyle.YesNo, "Konfirmasi")
                If p = vbNo Then
                    btnSimpan.DialogResult = DialogResult.None
                    Exit Sub
                ElseIf p = vbYes Then
                    btnSimpan.DialogResult = DialogResult.OK
                End If
            End If
        ElseIf btnSimpan.Text = "Simpan" Then

            Dim p As String = MsgBox("Anda ingin menambah data " & txtNamaBahan.Text & " ?", MsgBoxStyle.YesNo, "Konfirmasi")
            If p = vbNo Then
                btnSimpan.DialogResult = DialogResult.None
                Exit Sub
            ElseIf p = vbYes Then
                If String.IsNullOrEmpty(txtStok.Text.Trim) Then
                    MsgBox("Nilai Stok tidak boleh Null /Kosong", MsgBoxStyle.Critical, "Fatal Error")
                    btnSimpan.DialogResult = DialogResult.None
                    Exit Sub
                ElseIf Val(txtStok.Text = 0) Then
                    MsgBox("Nilai Stok tidak boleh 0", MsgBoxStyle.Critical, "Critical Error")
                    btnSimpan.DialogResult = DialogResult.None
                    Exit Sub
                ElseIf String.IsNullOrEmpty(txtNamaBahan.Text.Trim) Then
                    MsgBox("Nama bahan harus diisi", MsgBoxStyle.Critical, "Critical Error")
                    btnSimpan.Enabled = False
                Else
                    btnSimpan.DialogResult = DialogResult.Yes
                End If
            End If
        End If
    End Sub
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If btnSimpan.Text = "Edit" Then
            If String.IsNullOrEmpty(txtNamaBahan.Text.Trim) Then
                MsgBox("Nama bahan tidak boleh kosong", MsgBoxStyle.Critical, "Fatal Error")
                Me.DialogResult = DialogResult.None
                Exit Sub
            ElseIf String.IsNullOrEmpty(txtStok.Text.Trim) Then
                MsgBox("Nilai stok tidak boleh null /kosong", MsgBoxStyle.Critical, "Fatal Error")
                Me.DialogResult = DialogResult.None
                Exit Sub
            ElseIf Val(txtStok.Text = 0) Then
                MsgBox("Nilai stok tidak boleh 0", MsgBoxStyle.Critical, "Critical Error")
                Me.DialogResult = DialogResult.None
                Exit Sub
            ElseIf String.IsNullOrEmpty(txtReorder.Text.Trim) Then
                MsgBox("Nilai batas minimal stok tidak boleh null /kosong", MsgBoxStyle.Critical, "Fatal Error")
                Me.DialogResult = DialogResult.None
                Exit Sub
            ElseIf Val(txtReorder.Text = 0) Then
                MsgBox("Nilai batas minimal stok tidak boleh 0", MsgBoxStyle.Critical, "Critical Error")
                Me.DialogResult = DialogResult.None
                Exit Sub
            Else
                Dim p As DialogResult = MsgBox("Anda ingin mengubah data " & txtNamaBahan.Text & "?", MsgBoxStyle.OkCancel, "Konfirmasi")
                If p = vbCancel Then
                    Me.DialogResult = DialogResult.None
                    Exit Sub
                ElseIf p = vbOK Then
                    Me.DialogResult = DialogResult.OK
                End If
            End If
        ElseIf btnSimpan.Text = "Simpan" Then

            Dim p As String = MsgBox("Anda ingin menambah data " & txtNamaBahan.Text & " ?", MsgBoxStyle.YesNo, "Konfirmasi")
            If p = vbNo Then
                Me.DialogResult = DialogResult.None
                Exit Sub
            ElseIf p = vbYes Then
                If String.IsNullOrEmpty(txtNamaBahan.Text.Trim) Then
                    MsgBox("Nama bahan harus diisi", MsgBoxStyle.Critical, "Critical Error")
                    Me.DialogResult = DialogResult.None
                ElseIf String.IsNullOrEmpty(txtStok.Text.Trim) Then
                    MsgBox("Nilai Stok tidak boleh Null /Kosong", MsgBoxStyle.Critical, "Fatal Error")
                    Me.DialogResult = DialogResult.None
                    Exit Sub
                ElseIf Val(txtStok.Text = 0) Then
                    MsgBox("Nilai Stok tidak boleh 0", MsgBoxStyle.Critical, "Critical Error")
                    Me.DialogResult = DialogResult.None
                    Exit Sub
                ElseIf (Val(txtReorder.Text = 0)) Or String.IsNullOrEmpty(txtReorder.Text.Trim) Then
                    MsgBox("Anda harus memasukkan batas minimal stok", MsgBoxStyle.Critical, "Critical Error")
                    Me.DialogResult = DialogResult.None
                    Exit Sub
                Else
                    Me.DialogResult = DialogResult.Yes
                End If
            End If
        End If
    End Sub
    Private Sub AllTextBoxes_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) _
    Handles _
        txtNamaBahan.KeyDown,
        txtKeterangan.KeyDown,
        txtStok.KeyDown,
        txtReorder.KeyDown,
        txtEnergi.KeyDown,
        txtHewani.KeyDown,
        txtNabati.KeyDown,
        txtLemak.KeyDown,
        txtHA.KeyDown,
        txtKalsium.KeyDown,
        txtFosfor.KeyDown,
        txtFE.KeyDown,
        txtNatrium.KeyDown,
        txtKalium.KeyDown,
        txtKholesterol.KeyDown,
        txtAIR.KeyDown,
        txtTiamin.KeyDown,
        txtRiboflavin.KeyDown,
        txtNiasin.KeyDown,
        txtFolat.KeyDown,
        txtPiridoksin.KeyDown,
        txtSeng.KeyDown,
        txtLodium.KeyDown,
        txtSelenium.KeyDown,
        txtBDD.KeyDown,
        txtVITA.KeyDown,
        txtVitB.KeyDown,
        txtVitC.KeyDown,
        txtVITD.KeyDown,
        txtVITE.KeyDown,
        txtVITK.KeyDown,
        txtB12.KeyDown,
        txtB1.KeyDown
        If e.KeyCode = Keys.Tab OrElse e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            Me.ProcessTabKey(True)
        End If
    End Sub
#Region "Combobox Golongan"
    Private Sub cboGol_DropDown(sender As Object, e As EventArgs) Handles cboGol.DropDown
        If btnSimpan.Text = "Edit" Then
            If cboGol.SelectedIndex = -1 Then
                cboGol.DisplayMember = "GOLBAHAN"
                cboGol.ValueMember = "KDGOLBAHAN"
                cboGol.DataSource = golBahan.DataGolonganBahan
            Else
                Return
            End If
        End If
    End Sub
    Private Sub cboGol_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboGol.SelectedIndexChanged
        If cboGol.SelectedIndex = -1 Then
            Return
        Else
            txtKodeGolongan.Text = cboGol.SelectedValue.ToString
        End If
    End Sub
    Private Sub cboGol_KeyDown(sender As Object, e As KeyEventArgs) Handles cboGol.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Not golBahan.isSame(cboGol.Text) Then
                epUser.SetError(cboGol, "Data golongan ini tidak di temukan.")
                btnSimpan.Enabled = False
                If golBahan.AmbilKodeGol(txtKodeGolongan.Text) Then
                    cboGol.Text = golBahan.NamaGol
                End If
            Else
                btnSimpan.Enabled = True
            End If
        End If
    End Sub
    Private Sub cboGol_LostFocus(sender As Object, e As EventArgs) Handles cboGol.LostFocus
        If Not golBahan.isSame(cboGol.Text) Then
            btnSimpan.Enabled = False
            epUser.SetError(cboGol, "Data golongan ini tidak di temukan.")
            If golBahan.AmbilKodeGol(txtKodeGolongan.Text) Then
                cboGol.Text = golBahan.NamaGol
                epUser.SetError(cboGol, Nothing)
                btnSimpan.Enabled = True
            End If
        Else
            btnSimpan.Enabled = True
        End If
    End Sub
#End Region
#Region "Combobox Kelompok"
    Private Sub cboKelompokBahan_LostFocus(sender As Object, e As EventArgs) Handles cboKelompokBahan.LostFocus
        If Not kelBahan.isSame(cboKelompokBahan.Text) Then
            btnSimpan.Enabled = False
            epUser.SetError(cboKelompokBahan, "Data kelompok ini tidak di temukan.")
            If kelBahan.AmbilKodeKelompok(txtKodeKelompok.Text) Then
                cboKelompokBahan.Text = kelBahan.NamaKelompok
                epUser.SetError(cboKelompokBahan, Nothing)
                btnSimpan.Enabled = True
            End If
        Else
            btnSimpan.Enabled = True
        End If
    End Sub
    Private Sub cboKelompokBahan_KeyDown(sender As Object, e As KeyEventArgs) Handles cboKelompokBahan.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Not kelBahan.isSame(cboKelompokBahan.Text) Then
                btnSimpan.Enabled = False
                epUser.SetError(cboKelompokBahan, "Data kelompok ini tidak di temukan.")

                If kelBahan.AmbilKodeKelompok(txtKodeKelompok.Text) Then
                    cboKelompokBahan.Text = kelBahan.NamaKelompok
                End If
            Else
                btnSimpan.Enabled = True
            End If
        End If
    End Sub
    Private Sub cboKelompokBahan_DropDown(sender As Object, e As EventArgs) Handles cboKelompokBahan.DropDown
        If btnSimpan.Text = "Edit" Then
            If cboKelompokBahan.SelectedIndex = -1 Then
                cboKelompokBahan.DisplayMember = "KELOMPOKBAHAN"
                cboKelompokBahan.ValueMember = "KDKELOMPOKBAHAN"
                cboKelompokBahan.DataSource = kelBahan.DataKelompokBahan
            Else
                Return
            End If
        End If
    End Sub
    Private Sub cboKelompokBahan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboKelompokBahan.SelectedIndexChanged
        If cboKelompokBahan.SelectedIndex = -1 Then
            Return
        Else
            txtKodeKelompok.Text = cboKelompokBahan.SelectedValue.ToString
        End If
    End Sub
#End Region
#Region "Combobox Jenis"
    Private Sub cboNamaJenis_DropDown(sender As Object, e As EventArgs) Handles cboNamaJenis.DropDown
        If btnSimpan.Text = "Edit" Then
            If cboNamaJenis.SelectedIndex = -1 Then
                cboNamaJenis.DisplayMember = "NamaJenis"
                cboNamaJenis.ValueMember = "kdJenisMakanan"
                cboNamaJenis.DataSource = jenisBahan.DataJenisMakanan
            Else
                Return
            End If
        End If
    End Sub
    Private Sub cboNamaJenis_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboNamaJenis.SelectedIndexChanged
        If cboNamaJenis.SelectedIndex = -1 Then
            Return
        Else
            txtKodeJenis.Text = cboNamaJenis.SelectedValue.ToString
        End If
    End Sub
    Private Sub cboNamaJenis_KeyDown(sender As Object, e As KeyEventArgs) Handles cboNamaJenis.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Not jenisBahan.isSame(cboNamaJenis.Text) Then
                btnSimpan.Enabled = False
                epUser.SetError(cboNamaJenis, "Data jenis makanan ini tidak di temukan.")
                If jenisBahan.AmbilKodeJenis(txtKodeJenis.Text) Then
                    cboNamaJenis.Text = jenisBahan.NamaJenis
                End If
            Else
                btnSimpan.Enabled = True
            End If
        End If
    End Sub
    Private Sub cboNamaJenis_LostFocus(sender As Object, e As EventArgs) Handles cboNamaJenis.LostFocus
        If Not jenisBahan.isSame(cboNamaJenis.Text) Then
            btnSimpan.Enabled = False
            epUser.SetError(cboNamaJenis, "Data jenis makanan ini tidak di temukan.")
            If jenisBahan.AmbilKodeJenis(txtKodeJenis.Text) Then
                cboNamaJenis.Text = jenisBahan.NamaJenis
                epUser.SetError(cboNamaJenis, Nothing)
                btnSimpan.Enabled = True
            End If
        Else
            btnSimpan.Enabled = True
        End If
    End Sub
#End Region
#Region "Event Keypress"
    Private Sub txtEnergi_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEnergi.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(Keys.Back))
    End Sub
    Private Sub txtHewani_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHewani.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(Keys.Back))
    End Sub
    Private Sub txtNabati_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNabati.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(Keys.Back))
    End Sub
    Private Sub txtLemak_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLemak.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(Keys.Back))
    End Sub
    Private Sub txtHA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHA.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(Keys.Back))
    End Sub
    Private Sub txtKalsium_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKalsium.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(Keys.Back))
    End Sub
    Private Sub txtFosfor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFosfor.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(Keys.Back))
    End Sub
    Private Sub txtFE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFE.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(Keys.Back))
    End Sub
    Private Sub txtNatrium_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNatrium.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(Keys.Back))
    End Sub
    Private Sub txtKalium_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKalium.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(Keys.Back))
    End Sub
    Private Sub txtKholesterol_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKholesterol.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(Keys.Back))
    End Sub
    Private Sub txtAIR_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAIR.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(Keys.Back))
    End Sub
    Private Sub txtTiamin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTiamin.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(Keys.Back))
    End Sub
    Private Sub txtRiboflavin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRiboflavin.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(Keys.Back))
    End Sub
    Private Sub txtNiasin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNiasin.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(Keys.Back))
    End Sub
    Private Sub txtFolat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFolat.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(Keys.Back))
    End Sub
    Private Sub txtPiridoksin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPiridoksin.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(Keys.Back))
    End Sub
    Private Sub txtSeng_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSeng.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(Keys.Back))
    End Sub
    Private Sub txtLodium_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLodium.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(Keys.Back))
    End Sub
    Private Sub txtSelenium_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSelenium.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(Keys.Back))
    End Sub
    Private Sub txtBDD_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBDD.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(Keys.Back))
    End Sub
    Private Sub txtVITA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtVITA.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(Keys.Back))
    End Sub
    Private Sub txtVitB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtVitB.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(Keys.Back))
    End Sub
    Private Sub txtVitC_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtVitC.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(Keys.Back))
    End Sub
    Private Sub txtVITD_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtVITD.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(Keys.Back))
    End Sub
    Private Sub txtVITE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtVITE.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(Keys.Back))
    End Sub
    Private Sub txtVITK_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtVITK.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(Keys.Back))
    End Sub
    Private Sub txtB12_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtB12.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(Keys.Back))
    End Sub
    Private Sub txtB1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtB1.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(Keys.Back))
    End Sub
    Private Sub txtStok_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtStok.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(Keys.Back))
    End Sub
    Private Sub txtReorder_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtReorder.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(Keys.Back))
    End Sub
#End Region
#Region "Text Validating"
    Private Sub txtNamaBahan_Validating(sender As Object, e As CancelEventArgs) Handles txtNamaBahan.Validating
        If String.IsNullOrEmpty(txtNamaBahan.Text.Trim) Then
            epUser.SetError(txtNamaBahan, "Nama bahan harus diisi.")
            btnSimpan.Enabled = False
        Else
            epUser.SetError(txtNamaBahan, String.Empty)
            btnSimpan.Enabled = True
        End If
    End Sub
    Private Sub txtStok_Validating(sender As Object, e As CancelEventArgs) Handles txtStok.Validating
        If String.IsNullOrEmpty(txtStok.Text.Trim) Then
            epUser.SetError(txtStok, "Stok harus diisi.")
            btnSimpan.Enabled = False
        ElseIf Val(txtStok.Text) = 0 Then
            epUser.SetError(txtStok, "Stok tidak boleh 0")
            btnSimpan.Enabled = False
        ElseIf Val(txtStok.Text) <= Val(txtReorder.Text) Then
            epUser.SetError(txtStok, "Stok tidak boleh lebih kecil dari batas minimal stok")
            btnSimpan.Enabled = False
        Else
            epUser.SetError(txtStok, String.Empty)
            btnSimpan.Enabled = True
        End If
    End Sub
    Private Sub txtReorder_Validating(sender As Object, e As CancelEventArgs) Handles txtReorder.Validating
        If String.IsNullOrEmpty(txtStok.Text.Trim) Then
            epUser.SetError(txtStok, "Batas Stok harus diisi")
            btnSimpan.Enabled = False
        ElseIf Val(txtReorder.Text) >= Val(txtStok.Text) Then
            epUser.SetError(txtStok, "Batas minimum stok tidak boleh sama / lebih tinggi dari input stok")
            btnSimpan.Enabled = False
        Else
            epUser.SetError(txtStok, String.Empty)
            btnSimpan.Enabled = True
        End If
    End Sub
#End Region
#Region "Event TextChange"
    Private Sub txtNamaBahan_TextChanged(sender As Object, e As EventArgs) Handles txtNamaBahan.TextChanged
        If String.IsNullOrEmpty(txtNamaBahan.Text.Trim) Then
            epUser.SetError(txtNamaBahan, "Nama bahan harus diisi.")
            btnSimpan.Enabled = False
        Else
            epUser.SetError(txtNamaBahan, String.Empty)
            btnSimpan.Enabled = True
        End If
    End Sub
    Private Sub txtStok_TextChanged(sender As Object, e As EventArgs) Handles txtStok.TextChanged
        If String.IsNullOrEmpty(txtStok.Text.Trim) Then
            epUser.SetError(txtStok, "Stok harus diisi.")
            btnSimpan.Enabled = False
        ElseIf Val(txtStok.Text) = 0 Then
            epUser.SetError(txtStok, "Stok tidak boleh 0")
            btnSimpan.Enabled = False
        ElseIf Val(txtStok.Text) <= Val(txtReorder.Text) Then
            epUser.SetError(txtStok, "Stok tidak boleh lebih kecil dari batas minimal stok")
            btnSimpan.Enabled = False
        Else
            epUser.SetError(txtStok, String.Empty)
            btnSimpan.Enabled = True
        End If
    End Sub
    Private Sub txtReorder_TextChanged(sender As Object, e As EventArgs) Handles txtReorder.TextChanged
        If String.IsNullOrEmpty(txtStok.Text.Trim) Then
            epUser.SetError(txtStok, "Batas Stok harus diisi")
            btnSimpan.Enabled = False
        ElseIf Val(txtReorder.Text) >= Val(txtStok.Text) Then
            epUser.SetError(txtStok, "Batas minimum stok tidak boleh sama / lebih tinggi dari input stok")
            btnSimpan.Enabled = False
        Else
            epUser.SetError(txtStok, String.Empty)
            btnSimpan.Enabled = True
        End If
    End Sub
    Private Sub cboGol_TextChanged(sender As Object, e As EventArgs) Handles cboGol.TextChanged
        If Not golBahan.isSame(cboGol.Text) Then
            btnSimpan.Enabled = False
            epUser.SetError(cboGol, "Data golongan ini tidak di temukan.")
        Else
            btnSimpan.Enabled = True
        End If
    End Sub
    Private Sub cboKelompokBahan_TextChanged(sender As Object, e As EventArgs) Handles cboKelompokBahan.TextChanged
        If Not kelBahan.isSame(cboKelompokBahan.Text) Then
            btnSimpan.Enabled = False
            epUser.SetError(cboKelompokBahan, "Data kelompok ini tidak di temukan.")
        Else
            btnSimpan.Enabled = True
        End If
    End Sub
    Private Sub cboNamaJenis_TextChanged(sender As Object, e As EventArgs) Handles cboNamaJenis.TextChanged
        If Not jenisBahan.isSame(cboNamaJenis.Text) Then
            btnSimpan.Enabled = False
            epUser.SetError(cboNamaJenis, "Data jenis makanan ini tidak di temukan.")
        Else
            btnSimpan.Enabled = True
        End If
    End Sub
#End Region
End Class