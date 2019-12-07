Imports Pein
Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Imports WeifenLuo.WinFormsUI.Docking
Public Class frmRencanaDistribusi
    Dim WithEvents HeaderChoice As DataGridViewCheckBoxHeaderCell
    Dim bblinkKurus As Boolean = False
    Dim bblinkObesitas As Boolean = False
    Protected RecanaSaving As Boolean
    Protected IDRencana As String

    Protected rencana As New RencanaDistribusi
    Protected jajan As New Snack


    Dim MintaMenu As New PermintaanMenu
    Dim dtPermintaanMenu As DataTable

    ' Private snack As New Pein.snack
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        HeaderChoice = New DataGridViewCheckBoxHeaderCell
        dgvRencanaMenu.Columns(0).HeaderCell = HeaderChoice
    End Sub
    Private Sub EnableVSRenderer(ByVal version As VisualStudioToolStripExtender.VsVersion, ByVal theme As ThemeBase)
        vsRender.SetStyle(StatusStrip1, version, theme)
    End Sub
    Private Sub frmRencanaDistribusi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.EnableVSRenderer(VisualStudioToolStripExtender.VsVersion.Vs2015, VS2015LightTheme1)
        Panel2.BackColor = VS2015LightTheme1.ColorPalette.ToolWindowSeparator ',.Background
        'HitungIMT()
        WarnaIMT()

        dgvRencanaMenu.AutoGenerateColumns = False
        cboSnack.DisplayMember = "SNACK"
        cboSnack.ValueMember = "KDSNACK"
        cboSnack.DataSource = jajan.DataSnack

        dgvRencanaMenu.DataSource = minta.DataPerSiklus(kodeWaktu)

        dgvRencanaMenu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        lblRencanaDistribusi.Text = FindMaxPlusDatatable(rencana.DataNoRencanaDistribusi, "KDRENCANADISTRIBUSI", "RD", 5)
        dgvRencanaMenu.Sort(dgvRencanaMenu.Columns(2), ListSortDirection.Ascending)

        dtPermintaanMenu = MintaMenu.DataPermintaanDiet(Me.lblKdPermintaan.Text)
        dgvPermintaanMenu.DataSource = dtPermintaanMenu

        dgvPermintaanMenu.Columns("KDDIET").HeaderText = "KODE DIET"
        dgvPermintaanMenu.Columns("KETERANGANDIET").HeaderText = "NAMA DIET"
        dgvPermintaanMenu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvPermintaanMenu.ReadOnly = True
        Me.lblNamaDiet.Text = dgvPermintaanMenu.Rows.Count.ToString & " jenis"
    End Sub
    Protected Sub WarnaIMT()
        With lblIMT
            If .Text = "NAN" Or .Text = "NaN" Then
                .Text = "TIDAK DIKETAHUI"
                .ForeColor = Color.Black
                tmrBlink.Enabled = False
            ElseIf Val(.Text = 0) Then
                .Text = "TIDAK DIKETAHUI"
                .ForeColor = Color.Black
                tmrBlink.Enabled = False
            ElseIf Val(.Text < 17) Then
                .Text = "SANGAT KURUS"
                .ForeColor = Color.Red
                tmrBlink.Enabled = True
            ElseIf Val(.Text >= 17) And Val(.Text <= 18.5) Then
                .Text = "KURUS"
                .ForeColor = Color.RosyBrown
                tmrBlink.Enabled = False
            ElseIf Val(.Text >= 18.51) And Val(.Text < 25) Then
                .Text = "NORMAL"
                .ForeColor = Color.Green
                tmrBlink.Enabled = False
            ElseIf Val(.Text >= 25) And Val(.Text < 27) Then
                .Text = "OVERWEIGHT"
                .ForeColor = Color.FromArgb(1, 115, 199)
                tmrBlink.Enabled = False
            ElseIf Val(.Text >= 27.0) Then
                .Text = "OBESITAS"
                .ForeColor = Color.Purple
                tmrBlink.Enabled = True
            ElseIf Val(.Text = 22.1) Then
                .Text = "IDEAL"
                .ForeColor = Color.GreenYellow
                tmrBlink.Enabled = False
            End If
        End With
    End Sub
    Protected Sub BlinkingText()
        'Kurus
        If bblinkKurus = True Then
            If lblIMT.Text = "SANGAT KURUS" Then
                lblIMT.ForeColor = Color.Red
                lblNamaPasien.ForeColor = Color.Black
            End If

            bblinkKurus = False
        ElseIf bblinkKurus = False Then

            If lblIMT.Text = "SANGAT KURUS" Then
                lblIMT.ForeColor = Color.Black
                lblNamaPasien.ForeColor = Color.Red
            End If
            bblinkKurus = True
        End If

        'Obesitas
        If bblinkObesitas = True Then
            If lblIMT.Text = "OBESITAS" Then
                lblIMT.ForeColor = Color.Purple
                lblNamaPasien.ForeColor = Color.Black
            End If

            bblinkObesitas = False
        ElseIf bblinkObesitas = False Then

            If lblIMT.Text = "OBESITAS" Then
                lblIMT.ForeColor = Color.Black
                lblNamaPasien.ForeColor = Color.Purple
            End If
            bblinkObesitas = True
        End If
    End Sub
    Private Sub tmrBlink_Tick(sender As Object, e As EventArgs) Handles tmrBlink.Tick
        BlinkingText()
    End Sub
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Try
            Dim CheckedRows =
                (
                    From Rows In dgvRencanaMenu.Rows.Cast(Of DataGridViewRow)()
                    Where CBool(Rows.Cells(0).Value) = True
                ).ToList
            If CheckedRows.Count = 0 Then
                MessageBox.Show("Tidak ada Menu item yang di pilih")
            Else
                Dim P As String = MsgBox("Rencana distribusi untuk pasien " & lblNamaPasien.Text & " dari ruang rawat inap " &
                             lblkdRawatInap.Text & " pada tanggal " & Today &
                             " sebanyak " & CheckedRows.Count & " menu item " & vbNewLine & vbNewLine &
                             "Apakah anda setuju ?", MsgBoxStyle.OkCancel, "Konfirmasi Rencana Distribusi")
                If P = vbOK Then
                    SimpanRencana()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Protected Sub SimpanRencana()
        RecanaSaving = False
        Dim IdODetail As Int64 = 0
        Dim IDRencana As String = lblRencanaDistribusi.Text

        'Simpan ke tabel Rencana Distribusi
        Try
            If rencana.TambahRencana(Me.lblKdPermintaan.Text, kodeWaktu, Me.lblIDSnack.Text,
                                     Now, Me.lblWaktu.Text, lblRencanaDistribusi.Text) Then
                RecanaSaving = True
            Else
                'MsgBox($"Failed to save data into table order: {Err.LastExceptionMessage}", "Warning")
                MsgBox("Gagal simpan data", MsgBoxStyle.Critical, "Error simpan rencana distribusi")
            End If


            If RecanaSaving = True Then

                'Simpan ke tabel Rencana Detil Distribusi
                ' For i As Integer = 0 To (dgvRencanaMenu.Rows.Count - 1)
                For Each dr As DataGridViewRow In dgvRencanaMenu.Rows
                    If Not (dr.Cells(0).Value) Is DBNull.Value Then
                        If (dr.Cells(0).Value <> False) Then
                            If rencana.TambahDetilRencana(IDRencana,
                                                      dr.Cells("idSiklus").Value,
                                                      IdODetail) Then
                                minta.UpdateStatusPermintaan("TERIMA", Me.lblKdPermintaan.Text)
                            End If
                        End If
                    End If
                Next
                'Next
            End If
        Finally
            CountNotify = 0
            dtMinta = minta.NoPermintaan
            bsMinta.DataSource = dtMinta
            frmPelayananGizi.dgvPermintaan.DataSource = bsMinta
            frmPelayananGizi.ColumnCancel.Visible = True
            frmPelayananGizi.permintaanNavigator.BindingSource = bsMinta

            MenuUtama.SQLDependencies()
            Me.Dispose()

        End Try
    End Sub
    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        Try
            With dgvRencanaMenu.Rows
                btnSimpan.Enabled = True
                btnBatal.Enabled = False
                Dim ItemDuplicate As Boolean = False
                For Each row In dgvRencanaMenu.Rows
                    If cboSnack.Text = row.Cells("nmMenuMakanan").Value Then
                        ItemDuplicate = True
                        Exit For
                    End If
                Next

                If ItemDuplicate = False Then
                    Dim idtest As Integer = 0
                    idtest += 1
                    If minta.ExtractMenuDietPermintaan(cboSnack.Text) Then
                        .Add(minta.idSiklus, cboSnack.Text, minta.namaExtraMenu)
                    End If
                Else
                    MsgBox("Menu ini sudah di tambahkan", MsgBoxStyle.Information, "Akses Ditolak")
                End If
            End With
        Catch

        End Try
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
    Private Sub cboSnack_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSnack.SelectedIndexChanged
        If cboSnack.SelectedIndex = -1 Then
            Return
        Else
            lblIDSnack.Text = cboSnack.SelectedValue.ToString
        End If
    End Sub
    Private Sub HeaderChoice_CheckBoxClicked(sender As Object, e As DataGridViewCheckBoxHeaderCellEventArgs) Handles HeaderChoice.CheckBoxClicked
        HeaderChoice.CheckUncheckEntireColumn(e.Checked)
    End Sub
    Private Sub dgvRencanaMenu_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRencanaMenu.CellContentClick
        If e.ColumnIndex = HeaderChoice.ColumnIndex Then HeaderChoice.RefreshCheckState()
    End Sub
    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        CountNotify = 0
        MenuUtama.SQLDependencies()
    End Sub
End Class