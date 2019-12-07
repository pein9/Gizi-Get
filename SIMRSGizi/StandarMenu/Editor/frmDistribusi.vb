Imports Pein
Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Imports WeifenLuo.WinFormsUI.Docking
Imports System.Reflection
Public Class frmDistribusi
    Dim WithEvents HeaderChoice As DataGridViewCheckBoxHeaderCell
    Dim tError As New BaseExceptionsHandler
    Private mEditRow As Integer = -1
    Private ops As New Pein.DetilRencanaDistribusi

    Protected DistribusiSaving As Boolean

    Public namaWaktu As String
    Public nomorKamar As String
    Public nomorBed As String
    ' Public nomorDiet As String

    Private JumlahInvent As Int32

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        HeaderChoice = New DataGridViewCheckBoxHeaderCell
        dgvInventaris.Columns(0).HeaderCell = HeaderChoice
    End Sub
#Region "CRUD Distribusi"
    Protected Sub SiapKirim()
        Try
            DistribusiSaving = False
            Dim IdDetailDistribusi As Int64 = 0
            Dim IdDistribusi As String = lblDistribusi.Text

            'Simpan ke tabel Rencana Distribusi
            Try
                If ops.TambahDistribusi(Me.lblRencanaDistribusi.Text, Now,
                                            kodeWaktu, namaWaktu,
                                            Me.lblNoRM.Text, Me.lblNamaPasien.Text,
                                            nomorKamar, nomorBed, JumlahInvent,
                                             Me.lblDistribusi.Text) Then
                    DistribusiSaving = True
                Else
                    'MsgBox($"Failed to save data into table order: {Err.LastExceptionMessage}", "Warning")
                    MsgBox("Gagal simpan data", MsgBoxStyle.Critical, "Error simpan rencana distribusi")
                End If

            Catch ex As Exception
                MsgBox("Gagal Simpan Data ke Distribusi")
            End Try

            Try
                If DistribusiSaving = True Then
                    For Each dr As DataGridViewRow In dgvInventaris.Rows
                        If Not (dr.Cells(0).Value) Is DBNull.Value Then
                            If (dr.Cells(0).Value <> False) Then
                                Invent.sIDItem = dr.Cells("kdeAlat").Value '= 
                                Dim stockAngkas As Int32 '= 'dgvInventaris.Rows(i).Cells("nTest").Value
                                If Not IsDBNull(dr.Cells("nTest").Value) Then
                                    stockAngkas = dr.Cells("nTest").Value
                                Else
                                    stockAngkas = 0
                                End If

                                If ops.TambahDetilDistribusi(IdDistribusi,
                                                    dr.Cells("kdeAlat").Value,
                                                     IdDetailDistribusi) Then
                                    Try
                                        If Invent.UpdateStockInventaris(stockAngkas) Then minta.UpdateStatusPermintaan("SELESAI", Me.lblKdPermintaan.Text)
                                    Catch ex As Exception
                                        MsgBox("Gagal Update Stok Distribusi")
                                    End Try
                                End If
                            End If
                        End If
                    Next


                End If
            Catch ex As Exception
                MsgBox("Gagal Simpan Data ke Detail Distribusi")
            End Try
        Finally
            MenuUtama.SQLDependencies()
            Me.DialogResult = DialogResult.OK
        End Try
    End Sub
#End Region
    Private Shared Sub SetDoubleBuffer(ByVal ctl As Control, ByVal DoubleBuffered As Boolean)
        GetType(Control).InvokeMember("DoubleBuffered", BindingFlags.NonPublic Or BindingFlags.Instance Or BindingFlags.SetProperty, Nothing, ctl, New Object() {DoubleBuffered})
    End Sub
    Private Sub EnableVSRenderer(ByVal version As VisualStudioToolStripExtender.VsVersion, ByVal theme As ThemeBase)
        vsRender.SetStyle(StatusStrip1, version, theme)
    End Sub
    Private Sub frmDistribusi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.EnableVSRenderer(VisualStudioToolStripExtender.VsVersion.Vs2015, VS2015LightTheme1)
        Panel2.BackColor = VS2015LightTheme1.ColorPalette.ToolWindowSeparator ',.Background
        lblDistribusi.Text = FindMaxPlusDatatable(distribute.DataNoDistribusi, "KDDISTRIBUSI", "DIS", 10)
        'Rencana Menu
        dgvRencanaMenu.AutoGenerateColumns = False
        dgvRencanaMenu.DataSource = distribute.LookingForRencanaSiklus(Me.lblRencanaDistribusi.Text)
        'inventaris
        dgvRencanaMenu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        LoadInvetaris()
    End Sub
    Protected Overloads Overrides Sub WndProc(ByRef m As Message)
        'Define DoubleClick...
        Const WM_NCLBUTTONDBLCLK As Integer = &HA3
        'Define LeftButtonDown event...
        Const WM_NCLBUTTONDOWN As Integer = 161
        'Define MOVE action...
        Const WM_SYSCOMMAND As Integer = 274
        'Define that the WM_NCLBUTTONDOWN is at TitleBar...
        Const HTCAPTION As Integer = 2
        'Trap MOVE action...
        Const SC_MOVE As Integer = 61456
        'Disable moving TitleBar...
        If (m.Msg = WM_SYSCOMMAND) AndAlso (m.WParam.ToInt32() = SC_MOVE) Then
            Exit Sub
        End If
        'Track whether clicked on TitleBar...
        If (m.Msg = WM_NCLBUTTONDOWN) AndAlso (m.WParam.ToInt32() = HTCAPTION) Then
            Exit Sub
        End If
        'Disable double click on TitleBar...
        If (m.Msg = WM_NCLBUTTONDBLCLK) Then
            Exit Sub
        End If
        MyBase.WndProc(m)
    End Sub
    Private Sub dgvInventaris_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles dgvInventaris.EditingControlShowing
        mEditRow = dgvInventaris.CurrentRow.Index
    End Sub
    Private Sub dgvInventaris_SelectionChanged(sender As Object, e As EventArgs) Handles dgvInventaris.SelectionChanged
        If mEditRow >= 0 Then
            Dim NewRow As Integer = mEditRow
            mEditRow = -1

            dgvInventaris.CurrentCell = dgvInventaris.Rows(NewRow) _
                .Cells(dgvInventaris.CurrentCell.ColumnIndex)
            HitungSelisihInventaris()
        End If
    End Sub
    Private Sub dgvInventaris_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvInventaris.KeyDown
        If e.Modifiers = Keys.Control AndAlso e.KeyCode = Keys.Return Then
            dgvInventaris.CurrentRow.Cells(dgvInventaris.CurrentCell.ColumnIndex).Value = Now.ToShortTimeString
            e.Handled = True
            Exit Sub
        End If

        If e.KeyCode = Keys.Enter Then
            HitungSelisihInventaris()
        End If

        ' If e.KeyCode = Keys.Tab Then

        ' dgvInventaris.CurrentRow.Index < dgvInventaris.RowCount - 1 AndAlso dgvInventaris.CurrentCell.ColumnIndex = dgvInventaris.ColumnCount - 1 Then
        'dgvInventaris.CurrentCell = dgvInventaris(0, dgvInventaris.CurrentRow.Index + 1)

        'e.Handled = True
        'HitungSelisihInventaris()
        'Else
        'Dim CurrentCell As DataGridViewCell = dgvInventaris.CurrentCell
        'Dim col As Integer = CurrentCell.ColumnIndex

        'ol + 1) Mod dgvInventaris.Columns.Count
        'CurrentCell = dgvInventaris.CurrentRow.Cells(col)
        'dgvInventaris.CurrentCell = CurrentCell
        'End If
        'End If
    End Sub
    Protected Sub HitungSelisihInventaris()
        If dgvInventaris.RowCount > 0 Then
            Dim row As DataGridViewRow = dgvInventaris.CurrentRow
            Dim Checked As Boolean = CType(dgvInventaris.CurrentRow.Cells(0).Value, Boolean)
            Dim CheckedRows =
                        (
                          From Rows In dgvInventaris.Rows.Cast(Of DataGridViewRow)()
                          Where CBool(Rows.Cells(0).Value) = True
                        ).ToList

            If Checked = True Then
                If (row.Cells("nTest").Value) >= row.Cells("jmAlat").Value Then
                    row.Cells("nTest").Value = row.Cells("jmAlat").Value
                    row.Cells("nTest").ErrorText = "Input melebihi jumlah yang ada!"
                    btnSimpan.Enabled = False
                ElseIf row.Cells("nTest").Value = 0 Then
                    row.Cells("nTest").ErrorText = "Input tidak boleh 0!"
                    btnSimpan.Enabled = False
                ElseIf row.Cells("nTest").Value.ToString = Nothing Then
                    row.Cells("nTest").ErrorText = "Data tidak boleh kosong / null!!"
                    btnSimpan.Enabled = False
                ElseIf (row.Cells("nTest").Value) < row.Cells("jmAlat").Value Then
                    row.Cells("nmSisa").Value = row.Cells("jmAlat").Value - row.Cells("nTest").Value
                    row.Cells("nTest").ErrorText = Nothing
                    btnSimpan.Enabled = True
                    CountTotalDiambil()
                Else
                    For Each rw As DataGridViewRow In dgvInventaris.Rows
                        If rw.Cells("nTest").ErrorText <> Nothing Then
                            btnSimpan.Enabled = False
                        Else
                            row.Cells("nmSisa").Value = row.Cells("jmAlat").Value - row.Cells("nTest").Value
                            row.Cells("nTest").ErrorText = Nothing
                            btnSimpan.Enabled = True
                            CountTotalDiambil()
                        End If
                    Next
                End If
            Else
                MsgBox("Maaf, anda mencoba mengakses data sebelum memilih daftar inventaris")
                Exit Sub
            End If
        End If

    End Sub
    Private Sub CountTotalDiambil()
        If dgvInventaris.RowCount > 0 Then

            Dim iTotalDiambil As Integer = 0

            For index As Integer = 0 To dgvInventaris.RowCount - 1
                iTotalDiambil += Convert.ToDecimal(dgvInventaris.Rows(index).Cells("nTest").Value)
            Next
            JumlahInvent = iTotalDiambil
        Else
            JumlahInvent = Nothing

        End If
    End Sub
    Private Sub dgvInventaris_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles dgvInventaris.CurrentCellDirtyStateChanged
        RemoveHandler dgvInventaris.CurrentCellDirtyStateChanged,
            AddressOf dgvInventaris_CurrentCellDirtyStateChanged
        'Dim NumUpDownCell As DatagridviewNumUpDown.NumericUpDownRightCell = New DatagridviewNumUpDown.NumericUpDownRightCell()
        'Dim DefaultCellText As DataGridViewTextBoxCell = New DataGridViewTextBoxCell


        If TypeOf dgvInventaris.CurrentCell Is DataGridViewCheckBoxCell Then
            dgvInventaris.EndEdit()
            Dim Checked As Boolean = CType(dgvInventaris.CurrentCell.Value, Boolean)
            If Checked Then
                'dgvInventaris.CurrentRow.Cells("nTest").Value = NumUpDownCell
                ' dgvInventaris.CurrentRow.Cells("nTest").MAX = 1
                'NumUpDownCell.Maximum = dgvInventaris.CurrentRow.Cells("jmAlat").Value
                dgvInventaris.CurrentRow.Cells("nTest").ReadOnly = False
                dgvInventaris.CurrentRow.Cells("nTest").Style.BackColor = Color.WhiteSmoke
                dgvInventaris.CurrentRow.Cells("nTest").Style.ForeColor = Color.Black
                dgvInventaris.CurrentRow.Cells("nTest").Style.SelectionBackColor = Color.WhiteSmoke
                dgvInventaris.CurrentRow.Cells("nTest").Style.SelectionForeColor = Color.Blue
                dgvInventaris.CurrentRow.Cells("nTest").Value = 1
                'Dim cell As DataGridViewCell = dgvInventaris.CurrentRow.Cells("nTest")
                dgvInventaris.BeginEdit(True)

            Else
                'dgvInventaris.CurrentRow.Cells("nTest") = DefaultCellText
                'dgvInventaris.CurrentCell = DefaultCellText
                dgvInventaris.CurrentRow.Cells("nTest").ReadOnly = True
                dgvInventaris.CurrentRow.Cells("nTest").Style.BackColor = SystemColors.InactiveCaption
                dgvInventaris.CurrentRow.Cells("nTest").Style.ForeColor = Color.Black
                dgvInventaris.CurrentRow.Cells("nTest").Style.SelectionBackColor = SystemColors.InactiveCaption
                dgvInventaris.CurrentRow.Cells("nTest").Style.SelectionForeColor = Color.Black
                dgvInventaris.CurrentRow.Cells("nTest").ErrorText = Nothing
                dgvInventaris.CurrentRow.Cells("nTest").Value = Nothing
                dgvInventaris.CurrentRow.Cells("nmSisa").Value = Nothing
            End If
        End If

        AddHandler dgvInventaris.CurrentCellDirtyStateChanged,
        AddressOf dgvInventaris_CurrentCellDirtyStateChanged
    End Sub
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Try
            Dim CheckedRows =
                (
                    From Rows In dgvInventaris.Rows.Cast(Of DataGridViewRow)()
                    Where CBool(Rows.Cells(0).Value) = True
                ).ToList
            If CheckedRows.Count = 0 Then
                MessageBox.Show("Tidak ada Menu item yang di pilih")
            Else
                Dim P As DialogResult = MsgBox("Pengiriman menu distribusi untuk pasien " & lblNamaPasien.Text & " untuk ruang rawat inap " &
                             lblkdRawatInap.Text & " pada tanggal " & Now &
                             " sebanyak " & CheckedRows.Count & " barang inventaris dengan total " & JumlahInvent & "-item inventaris." & vbNewLine & vbNewLine &
                             "Catatan: Mohon diperhatikan, setelah anda melanjutkan proses ini, data distribusi tidak bisa di batalkan. Terima Kasih." & vbNewLine & vbNewLine &
                             "Apakah anda setuju ?", MsgBoxStyle.OkCancel, "Konfirmasi Pengiriman Menu Distribusi")
                If P = DialogResult.OK Then
                    SiapKirim()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub dgvInventaris_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvInventaris.CellValueChanged
        If e.RowIndex > -1 Then
            Dim Checked As Boolean = CType(dgvInventaris.CurrentRow.Cells("Choices").Value, Boolean)
            If Checked Then
                HitungSelisihInventaris()
            End If
        End If
    End Sub
    Protected Sub LoadInvetaris()
        dgvInventaris.AutoGenerateColumns = False

        dtInvent = Invent.DatasetInventaris(KodeKelasTemp)
        bsInvent.ResetBindings(False)
        bsInvent.DataSource = dtInvent
        dgvInventaris.DataSource = bsInvent 'bsInvent 

        ' CheckMaksDiambil()
        'dgvInventaris.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub
    Private Sub dgvInventaris_TextChanged(sender As Object, e As EventArgs) Handles dgvInventaris.TextChanged
        Dim CheckedRows =
            (
                From Rows In dgvInventaris.Rows.Cast(Of DataGridViewRow)()
                Where CBool(Rows.Cells(0).Value) = True
            ).ToList

        For Each rw As DataGridViewRow In dgvInventaris.Rows
            If rw.Cells("nTest").ErrorText <> Nothing Then
                btnSimpan.Enabled = False
            Else
                btnSimpan.Enabled = True
            End If
        Next
    End Sub
    Private Sub HeaderChoice_CheckBoxClicked(sender As Object, e As DataGridViewCheckBoxHeaderCellEventArgs) Handles HeaderChoice.CheckBoxClicked
        HeaderChoice.CheckUncheckEntireColumn(e.Checked)
        Dim NumUpDownCell As DatagridviewNumUpDown.NumericUpDownRightCell = New DatagridviewNumUpDown.NumericUpDownRightCell()
        Dim DefaultCellText As DataGridViewTextBoxCell = New DataGridViewTextBoxCell

        If HeaderChoice.Checked = True And HeaderChoice.CheckState = CheckState.Checked Then
            For Each rw As DataGridViewRow In dgvInventaris.Rows
                If rw.Cells("nTest").ReadOnly = False Then
                    'rw.Cells("nTest").Style = DefaultCellText
                    rw.Cells("nTest").ReadOnly = True
                    rw.Cells("nTest").Style.BackColor = SystemColors.InactiveCaption
                    rw.Cells("nTest").Style.ForeColor = Color.Black
                    rw.Cells("nTest").Style.SelectionBackColor = SystemColors.InactiveCaption
                    rw.Cells("nTest").Style.SelectionForeColor = Color.Black
                    rw.Cells("nTest").ErrorText = Nothing
                    rw.Cells("nTest").Value = Nothing
                    rw.Cells("nmSisa").Value = Nothing
                End If
            Next
        ElseIf HeaderChoice.Checked = False And HeaderChoice.CheckState = CheckState.Unchecked Then
            For Each rw As DataGridViewRow In dgvInventaris.Rows
                If rw.Cells("nTest").ReadOnly = True Then
                    rw.Cells("nTest").ReadOnly = False
                    rw.Cells("nTest").Style.BackColor = Color.WhiteSmoke
                    rw.Cells("nTest").Style.ForeColor = Color.Black
                    rw.Cells("nTest").Style.SelectionBackColor = Color.WhiteSmoke
                    rw.Cells("nTest").Style.SelectionForeColor = Color.Blue
                    rw.Cells("nTest").Value = 1
                    'Dim cell As DataGridViewCell = dgvInventaris.CurrentRow.Cells("nTest")
                    dgvInventaris.BeginEdit(True)
                End If
            Next
        End If
    End Sub
    Private Sub dgvInventaris_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvInventaris.CellContentClick
        If e.ColumnIndex = HeaderChoice.ColumnIndex Then HeaderChoice.RefreshCheckState()
        If HeaderChoice.CheckState = CheckState.Checked Then
            'ElseIf HeaderChoice.Checked = True And HeaderChoice.CheckState = CheckState.Unchecked Then
            For Each rw As DataGridViewRow In dgvInventaris.Rows
                If rw.Cells("nTest").ReadOnly = True Then
                    rw.Cells("nTest").ReadOnly = False
                    rw.Cells("nTest").Style.BackColor = Color.WhiteSmoke
                    rw.Cells("nTest").Style.ForeColor = Color.Black
                    rw.Cells("nTest").Style.SelectionBackColor = Color.WhiteSmoke
                    rw.Cells("nTest").Style.SelectionForeColor = Color.Blue
                    rw.Cells("nTest").Value = 1
                    'Dim cell As DataGridViewCell = dgvInventaris.CurrentRow.Cells("nTest")
                    dgvInventaris.BeginEdit(True)
                End If
            Next
        ElseIf HeaderChoice.CheckState = CheckState.Unchecked Then
            For Each rw As DataGridViewRow In dgvInventaris.Rows
                rw.Cells("nTest").ReadOnly = True
                rw.Cells("nTest").Style.BackColor = SystemColors.InactiveCaption
                rw.Cells("nTest").Style.ForeColor = Color.Black
                rw.Cells("nTest").Style.SelectionBackColor = SystemColors.InactiveCaption
                rw.Cells("nTest").Style.SelectionForeColor = Color.Black
                rw.Cells("nTest").ErrorText = Nothing
                rw.Cells("nTest").Value = Nothing
                rw.Cells("nmSisa").Value = Nothing
                btnSimpan.Enabled = False
            Next
        ElseIf HeaderChoice.CheckState = CheckState.Indeterminate Then
            Exit Sub
        End If

    End Sub
End Class