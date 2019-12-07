Imports System.ComponentModel
Imports WeifenLuo.WinFormsUI.Docking
Public Class frmKomposisiEditor
    Private BAHAN As New Pein.BahanMakan
    Private komposisi As New Pein.KomposisiBahan
    Private olahan As New Pein.MakananOlahanJadi
    Dim pKdBahan, pKdOlahan As String
    Dim dtOlahan As DataTable
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
    Protected Sub SimpanKomposisi()
        If btnSimpan.Text = "Simpan" Then
            Dim p As DialogResult = MsgBox("Anda ingin menyimpan komposisi bahan " & txtNamaBahan.Text & "?", MsgBoxStyle.OkCancel, "Konfirmasi")
            If p = vbCancel Then
                Me.DialogResult = DialogResult.None
                Exit Sub
            ElseIf p = vbOK Then
                Me.DialogResult = DialogResult.OK
            End If
        End If
    End Sub
    Protected Sub EditKomposisi()
        If btnSimpan.Text = "Edit" Then
            Dim p As DialogResult = MsgBox("Anda ingin merubah/update data komposisi bahan " & txtNamaBahan.Text & "?", MsgBoxStyle.OkCancel, "Konfirmasi")
            If p = vbCancel Then
                Me.DialogResult = DialogResult.None
                Exit Sub
            ElseIf p = vbOK Then
                Me.DialogResult = DialogResult.OK
            End If
        End If
    End Sub
    Private Sub EnableVSRenderer(ByVal version As VisualStudioToolStripExtender.VsVersion, ByVal theme As ThemeBase)
        vsRender.SetStyle(StatusStrip1, version, theme)
    End Sub
    Private Sub frmKomposisiEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.EnableVSRenderer(VisualStudioToolStripExtender.VsVersion.Vs2015, VS2015LightTheme1)
        Panel2.BackColor = VS2015LightTheme1.ColorPalette.ToolWindowSeparator ',.Background
        txtNamaBahan.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        txtNamaBahan.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtNamaBahan.AutoCompleteCustomSource = BAHAN.LoadAutoNama

        If btnSimpan.Text = "Simpan" Then
            GroupContractable1.SetCollapsed(True)
            GroupContractable2.SetCollapsed(True)
        ElseIf btnSimpan.Text = "Edit" Then
            GroupContractable1.SetCollapsed(False)
            GroupContractable2.SetCollapsed(False)
        End If
    End Sub
    Private Sub txtNamaBahan_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNamaBahan.KeyDown
        If e.KeyCode = Keys.Enter Then
            BAHAN.bNAMABAHAN = txtNamaBahan.Text
            If BAHAN.isSame(BAHAN.bNAMABAHAN) Then
                CariNamaBahan()
            Else
                epUser.SetError(txtNamaBahan, "Data bahan ini tidak ada.")
                DataKosong()
            End If
        ElseIf e.KeyCode = Keys.Back Then
            DataKosong()
        End If
    End Sub
    Private Sub AllTextBoxes_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) _
    Handles _
        txtNamaBahan.KeyDown,
        txtKomposisi.KeyDown,
        txtSatuanPakai.KeyDown,
        txtKeterangan.KeyDown
        If e.KeyCode = Keys.Tab OrElse e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            Me.ProcessTabKey(True)
        End If
    End Sub
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If btnSimpan.Text = "Simpan" Then
            SimpanKomposisi()
        ElseIf btnSimpan.Text = "Edit" Then
            EditKomposisi()
        End If
    End Sub
    Protected Sub DataKosong()
        pKdBahan = Nothing
        lblKdBahan.Text = Nothing
        lblEnergi.Text = 0
        lblHewani.Text = 0
        lblNabati.Text = 0
        lblTiamin.Text = 0
        lblRiboflavin.Text = 0
        lblNiasin.Text = 0
        lblLemak.Text = 0
        lblHA.Text = 0
        lblKalsium.Text = 0
        lblFolat.Text = 0
        lblPiridoksin.Text = 0
        lblSeng.Text = 0
        lblLodium.Text = 0
        lblSelenium.Text = 0
        lblBDD.Text = 0
        lblVITA.Text = 0
        lblVITB.Text = 0
        lblVITC.Text = 0
        lblVITD.Text = 0
        lblVITE.Text = 0
        lblVITK.Text = 0
        lblB12.Text = 0
        lblB1.Text = 0
        GroupContractable1.SetCollapsed(True)
        GroupContractable2.SetCollapsed(True)
        btnSimpan.Enabled = False
    End Sub
#Region "Cari Nutrisi"
    Protected Sub CariNamaBahan()
        BAHAN.bNAMABAHAN = txtNamaBahan.Text


        If BAHAN.AmbilBahanMakanan(BAHAN.bNAMABAHAN) Then
            'pKdBahan = BAHAN.bkdBahan
            lblKdBahan.Text = BAHAN.bkdBahan
            lblEnergi.Text = BAHAN.bENERGI
            lblHewani.Text = BAHAN.bPROTEINHEWANI
            lblNabati.Text = BAHAN.bPROTEINNABATI
            lblTiamin.Text = BAHAN.bTIAMIN
            lblRiboflavin.Text = BAHAN.bRIBOFLAVIN
            lblNiasin.Text = BAHAN.bNIASIN
            lblLemak.Text = BAHAN.bLEMAK
            lblHA.Text = BAHAN.bHA
            lblKalsium.Text = BAHAN.bKALSIUM
            lblFolat.Text = BAHAN.bASAMFOLAT
            lblPiridoksin.Text = BAHAN.bPIRIDOKSIN
            lblSeng.Text = BAHAN.bSENG
            lblLodium.Text = BAHAN.bLODIUM
            lblSelenium.Text = BAHAN.bSELENIUM
            lblBDD.Text = BAHAN.bBDD
            lblVITA.Text = BAHAN.bVITA
            lblVITB.Text = BAHAN.bVITB
            lblVITC.Text = BAHAN.bVITC
            lblVITD.Text = BAHAN.bVITD
            lblVITE.Text = BAHAN.bVITE
            lblVITK.Text = BAHAN.bVITK
            lblB12.Text = BAHAN.bVITB12
            lblB1.Text = BAHAN.bVITB1
            GroupContractable1.SetCollapsed(False)
            GroupContractable2.SetCollapsed(False)
        End If
    End Sub
#End Region
    Private Sub txtKomposisi_Validating(sender As Object, e As CancelEventArgs) Handles txtKomposisi.Validating
        If String.IsNullOrEmpty(txtKomposisi.Text.Trim) Then
            epUser.SetError(txtKomposisi, "Komposisi bahan harus di isi.")
            btnSimpan.Enabled = False
        Else
            epUser.SetError(txtKomposisi, String.Empty)
            btnSimpan.Enabled = True
        End If
    End Sub
    Private Sub txtSatuanPakai_Validating(sender As Object, e As CancelEventArgs) Handles txtSatuanPakai.Validating
        If String.IsNullOrEmpty(txtSatuanPakai.Text.Trim) Then
            epUser.SetError(txtSatuanPakai, "satuan komposisi harus di isi.")
            btnSimpan.Enabled = False
        Else
            epUser.SetError(txtSatuanPakai, String.Empty)
            btnSimpan.Enabled = True
        End If
    End Sub
    Private Sub txtKeterangan_Validating(sender As Object, e As CancelEventArgs) Handles txtKeterangan.Validating
        If String.IsNullOrEmpty(txtKeterangan.Text.Trim) Then
            errorKet.SetError(txtKeterangan, "keterangan komposisi harus di isi.")
            btnSimpan.Enabled = False
        Else
            errorKet.SetError(txtKeterangan, String.Empty)
            btnSimpan.Enabled = True
        End If
    End Sub
    Private Sub txtNamaBahan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNamaBahan.KeyPress
        e.Handled = Not (Char.IsLetter(e.KeyChar) Or Char.IsWhiteSpace(e.KeyChar) Or e.KeyChar = Chr(Keys.Back))
    End Sub
    Private Sub txtNamaBahan_LostFocus(sender As Object, e As EventArgs) Handles txtNamaBahan.LostFocus
        BAHAN.bNAMABAHAN = txtNamaBahan.Text
        If String.IsNullOrEmpty(txtNamaBahan.Text.Trim) Then
            epUser.SetError(txtNamaBahan, "Nama bahan harus di isi.")
            btnSimpan.Enabled = False
        ElseIf BAHAN.isSame(BAHAN.bNAMABAHAN) Then
            CariNamaBahan()
        Else
            epUser.SetError(txtNamaBahan, "Data bahan ini tidak ada.")
            DataKosong()
        End If
    End Sub
    Private Sub txtSatuanPakai_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSatuanPakai.KeyPress
        e.Handled = Not (Char.IsLetter(e.KeyChar) Or e.KeyChar = Chr(Keys.Back))
    End Sub
End Class