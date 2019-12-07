Imports Pein
Imports System.ComponentModel
Imports WeifenLuo.WinFormsUI.Docking
Public Class frmInventarisEditor
    Private klas As New Pein.Kelas
    'Private komposisi As New Pein.KomposisiBahan
    ' Private olahan As New Pein.MakananOlahanJadi
    ' Dim pKdBahan, pKdOlahan As String
    Dim dtkelas As DataTable
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub frmInventarisEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.EnableVSRenderer(VisualStudioToolStripExtender.VsVersion.Vs2015, VS2015LightTheme1)
        Panel2.BackColor = VS2015LightTheme1.ColorPalette.ToolWindowSeparator ',.Background

        If btnSimpan.Text = "Simpan" Then
            cboKelas.DisplayMember = "kelas"
            cboKelas.ValueMember = "kdKelas"
            cboKelas.DataSource = klas.DataKelas
        End If
    End Sub
    Private Sub EnableVSRenderer(ByVal version As VisualStudioToolStripExtender.VsVersion, ByVal theme As ThemeBase)
        vsRender.SetStyle(StatusStrip1, version, theme)
    End Sub
    Private Sub AllTextBoxes_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) _
        Handles _
            txtNama.KeyDown,
            txtJumlah.KeyDown,
            txtSatuan.KeyDown
        If e.KeyCode = Keys.Tab OrElse e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            Me.ProcessTabKey(True)
        End If
    End Sub
    Private Sub txtJumlah_Validating(sender As Object, e As CancelEventArgs) Handles txtJumlah.Validating
        If String.IsNullOrEmpty(txtJumlah.Text.Trim) Then
            epUser.SetError(txtJumlah, "Jumlah alat tidak boleh 0.")
            btnSimpan.Enabled = False
        Else
            epUser.SetError(txtJumlah, String.Empty)
            btnSimpan.Enabled = True
        End If
    End Sub
    Private Sub txtNama_Validating(sender As Object, e As CancelEventArgs) Handles txtNama.Validating
        If String.IsNullOrEmpty(txtNama.Text.Trim) Then
            epUser.SetError(txtNama, "Nama alat harus terisi.")
            btnSimpan.Enabled = False
        Else
            epUser.SetError(txtNama, String.Empty)
            btnSimpan.Enabled = True
        End If
    End Sub
    Private Sub cboKelas_Click(sender As Object, e As EventArgs) Handles cboKelas.Click
        If btnSimpan.Text = "Edit" Then
            cboKelas.DisplayMember = "kelas"
            cboKelas.ValueMember = "kdKelas"
            cboKelas.DataSource = klas.DataKelas
        End If
    End Sub
#Region "Combobox Kelas"
    Private Sub cboKelas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboKelas.SelectedIndexChanged

        If cboKelas.SelectedIndex = -1 Then
            Return
        Else
            txtKodeKelas.Text = cboKelas.SelectedValue.ToString
        End If

    End Sub
    Private Sub cboKelas_DragDrop(sender As Object, e As DragEventArgs) Handles cboKelas.DragDrop
        If btnSimpan.Text = "Edit" Then
            If cboKelas.SelectedIndex = -1 Then
                cboKelas.DisplayMember = "kelas"
                cboKelas.ValueMember = "kdKelas"
                cboKelas.DataSource = klas.DataKelas
            Else
                Return
            End If
        End If
    End Sub
    Private Sub cboKelas_KeyDown(sender As Object, e As KeyEventArgs) Handles cboKelas.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Not klas.isSame(cboKelas.Text) Then
                'MsgBox("Data makanan ini tidak ada")
                epUser.SetError(cboKelas, "Data kelas ini tidak ada.")
                btnSimpan.Enabled = False
                If klas.AmbilKodeKelas(txtKodeKelas.Text) Then
                    cboKelas.Text = klas.NmKelas
                    ' epUser.SetError(cboNamaMakanan, Nothing)
                    btnSimpan.Enabled = True
                End If
            Else
                'epUser.SetError(cboNamaMakanan, Nothing)
                btnSimpan.Enabled = True
            End If
        End If
    End Sub
    Private Sub cboKelas_LostFocus(sender As Object, e As EventArgs) Handles cboKelas.LostFocus
        If Not klas.isSame(cboKelas.Text) Then
            'MsgBox("Data makanan ini tidak ada")
            epUser.SetError(cboKelas, "Data kelas ini tidak ada.")
            btnSimpan.Enabled = False
            If klas.AmbilKodeKelas(txtKodeKelas.Text) Then
                cboKelas.Text = klas.NmKelas
                ' epUser.SetError(cboNamaMakanan, Nothing)
                btnSimpan.Enabled = True
            End If
        Else
            'epUser.SetError(cboNamaMakanan, Nothing)
            btnSimpan.Enabled = True
        End If
    End Sub
    Private Sub cboKelas_TextChanged(sender As Object, e As EventArgs) Handles cboKelas.TextChanged
        If Not klas.isSame(cboKelas.Text) Then
            'MsgBox("Data makanan ini tidak ada")
            epUser.SetError(cboKelas, "Data kelas ini tidak ada.")
            btnSimpan.Enabled = False
        Else
            epUser.SetError(cboKelas, Nothing)
            btnSimpan.Enabled = True
        End If
    End Sub
    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        e.Handled = Not (Char.IsLetter(e.KeyChar) Or e.KeyChar = Chr(Keys.Back))
    End Sub
    Private Sub txtSatuan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSatuan.KeyPress
        e.Handled = Not (Char.IsLetter(e.KeyChar) Or e.KeyChar = Chr(Keys.Back))
    End Sub
    Private Sub txtJumlah_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtJumlah.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(Keys.Back))
    End Sub

    Private Sub cboKetInventaris_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboKetInventaris.KeyPress
        e.Handled = True
    End Sub
#End Region
End Class