Imports Pein
Imports WeifenLuo.WinFormsUI.Docking
Imports System.Data.Common
Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Imports System.Reflection
Imports System.Threading
Imports System.IO
Imports Excel = Microsoft.Office.Interop.Excel
Imports Microsoft.Office
Imports System.Runtime.InteropServices
Imports System.ComponentModel
Imports System.Linq
Imports System.Text


Public Class frmPelayananGizi
    Inherits DockContent
    Dim WithEvents HeaderChoice As DataGridViewCheckBoxHeaderCell
    Protected rinap As New Pein.RawatInap
    Private ops As New Pein.DetilRencanaDistribusi
    Protected classDahlia As New Pein.Kelas

    Dim tError As New BaseExceptionsHandler
    Dim bblinkKurus As Boolean = False
    Dim bblinkObesitas As Boolean = False
    Public ColumnCancel As New DataGridViewDisableButtonColumn

    Public ColumnDistribusi As New DataGridViewDisableButtonColumn


    Private go As Boolean = False
    Private count As Integer = 0

    Private NamaRuanganExcel As String
    Dim namaDietMenuKode As String

    Dim FileLocationExcel As String
    Dim SaveLocationPdf As String


    Private ListKodeDiet As New List(Of String)
    Private ListKetDiet As New List(Of DataRow)
    Dim MintaMenu As New PermintaanMenu
    Dim dtPermintaanMenu As DataTable

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        CreateUnboundButtonColumn(dgvPermintaan)
        CreateUnboundButtonColumnDistribusi(dgvDistribusi)

        If ColumnDistribusi.Visible <> False Then
            HeaderChoice = New DataGridViewCheckBoxHeaderCell
            dgvDistribusi.Columns(25).HeaderCell = HeaderChoice
        End If
    End Sub

#Region "TopMost Excel"
    <DllImport("user32.dll")>
    Private Shared Function SetForegroundWindow(ByVal hWnd As IntPtr) As <MarshalAs(UnmanagedType.Bool)> Boolean
    End Function
    <DllImport("user32.dll", SetLastError:=True)>
    Private Shared Function FindWindow(ByVal lpClassName As String, ByVal lpWindowName As String) As IntPtr
    End Function

#End Region
    Private Shared Sub SetDoubleBuffer(ByVal ctl As Control, ByVal DoubleBuffered As Boolean)
        GetType(Control).InvokeMember("DoubleBuffered", BindingFlags.NonPublic Or BindingFlags.Instance Or BindingFlags.SetProperty, Nothing, ctl, New Object() {DoubleBuffered})
    End Sub
    Private Sub frmPelayananGizi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SuperTabControl1.SelectedTabIndex = 1
        SuperTabControl1.SelectedTabIndex = 0

        If TabPermintaan.IsSelected Then
            PanelEx1.Text = "Permintaan Pelayanan Gizi"
            LoadPermintaan()
        Else
            PanelEx1.Text = "Distribusi Pelayanan Gizi"
            LoadDistribusi()
        End If

    End Sub
#Region "Permintaan"
    Protected Sub LoadPermintaan()
        dgvPermintaan.AutoGenerateColumns = False
        dtMinta = minta.NoPermintaan

        bsMinta.DataSource = dtMinta
        bsMinta.Sort = "tglPermintaan"
        permintaanNavigator.BindingSource = bsMinta
        dgvPermintaan.DataSource = bsMinta

        ColumnCancel.Visible = True
        nmStatus.Visible = False

        SetDoubleBuffer(dgvPermintaan, True)
        dgvPermintaan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        tmrDistribusi.Enabled = False
    End Sub
#Region "CRUD Permintaan"
    Public Function GetCurrentAge(ByVal dob As Date) As Integer
        Dim age As Integer
        age = Today.Year - dob.Year
        If (dob > Today.AddYears(-age)) Then age -= 1
        Return age
    End Function
    Protected Sub TambahRencana()
        Dim fRencana As New frmRencanaDistribusi
        Dim elap As TimeSpan
        Dim PermintaanRow As DataRow = CType(bsMinta.Current, DataRowView).Row

        fRencana.lblKdPermintaan.Text = PermintaanRow.Field(Of String)("kdPermintaan")
        fRencana.lblNoRM.Text = PermintaanRow.Field(Of String)("noRekamedis")
        fRencana.lblNoDaftarRawatInap.Text = PermintaanRow.Field(Of String)("noDaftarRawatInap")
        fRencana.lblTanggalPermintaan.Text = PermintaanRow.Field(Of DateTime)("tglPermintaan")
        fRencana.lblNamaPasien.Text = PermintaanRow.Field(Of String)("nmPasien")
        fRencana.lblTglMasuk.Text = PermintaanRow.Field(Of DateTime)("tglMasukRawatInap")
        fRencana.lblWaktu.Text = PermintaanRow.Field(Of String)("WAKTU")
        kodeWaktu = PermintaanRow.Field(Of String)("kdWaktu")

        fRencana.GroupContractable1.TitleText = "Data Pasien " & PermintaanRow.Field(Of String)("kelas") &
                                                ", No.Kamar " & PermintaanRow.Field(Of String)("noKamar") &
                                                ", No.Bed " & PermintaanRow.Field(Of String)("noBed")

        fRencana.lblBB.Text = PermintaanRow.Field(Of String)("BB") & " kg"
        fRencana.lblTB.Text = PermintaanRow.Field(Of String)("TB") & " cm"


        fRencana.lblIMT.Text = CDbl(PermintaanRow.Field(Of String)("BB")) / ((PermintaanRow.Field(Of String)("TB") / 100) ^ 2)


        fRencana.lblAlergi.Text = PermintaanRow.Field(Of String)("kdAlergi")

        fRencana.lblLK.Text = PermintaanRow.Field(Of String)("LK") & " cm"

        If PermintaanRow.Field(Of String)("LLApersen") = Nothing Then
            fRencana.lblLLA.Text = PermintaanRow.Field(Of String)("LLA") & " cm"
        Else
            fRencana.lblLLA.Text = PermintaanRow.Field(Of String)("LLA") & " cm / " & PermintaanRow.Field(Of String)("LLA") & "%"

        End If

        If rinap.AmbilRawatInap(PermintaanRow.Field(Of String)("kdRawatInap")) Then
            fRencana.lblkdRawatInap.Text = PermintaanRow.Field(Of String)("kdRawatInap") & " - " & rinap.NamaRawatInap
        End If

        elap = Today - PermintaanRow.Field(Of DateTime)("tglLahir")
        If Int(elap.Days / 365.25) > 1 And Int(elap.Days / 365.25) < 5 Then
            fRencana.lblTglLahir.Text = PermintaanRow.Field(Of DateTime)("tglLahir") & " - " & Int(elap.Days / 365.25) & " tahun [Anak Balita]"
        ElseIf Int(elap.Days / 365.25) > 5 And Int(elap.Days / 365.25) < 7 Then
            fRencana.lblTglLahir.Text = PermintaanRow.Field(Of DateTime)("tglLahir") & " - " & Int(elap.Days / 365.25) & " tahun [Anak Pra Sekolah]"
        ElseIf Int(elap.Days / 365.25) > 7 And Int(elap.Days / 365.25) < 12 Then
            fRencana.lblTglLahir.Text = PermintaanRow.Field(Of DateTime)("tglLahir") & " - " & Int(elap.Days / 365.25) & " tahun [Anak Sekolah (SD)]"
        ElseIf Int(elap.Days / 365.25) > 12 And Int(elap.Days / 365.25) < 18 Then
            fRencana.lblTglLahir.Text = PermintaanRow.Field(Of DateTime)("tglLahir") & " - " & Int(elap.Days / 365.25) & " tahun [Remaja]"
        ElseIf Int(elap.Days / 365.25) > 18 And Int(elap.Days / 365.25) < 55 Then
            fRencana.lblTglLahir.Text = PermintaanRow.Field(Of DateTime)("tglLahir") & " - " & Int(elap.Days / 365.25) & " tahun [Dewasa]"
        ElseIf Int(elap.Days / 365.25) >= 55 Then
            fRencana.lblTglLahir.Text = PermintaanRow.Field(Of DateTime)("tglLahir") & " - " & Int(elap.Days / 365.25) & " tahun [Usila]"
        End If


        If PermintaanRow.Field(Of String)("jenisKelamin") = "P" Then
            fRencana.lblJenisKelamin.Text = "Perempuan" 'PermintaanRow.Field(Of String)("jenisKelamin")
        ElseIf PermintaanRow.Field(Of String)("jenisKelamin") = "L" Then
            fRencana.lblJenisKelamin.Text = "Laki - laki"
        End If

        fRencana.GroupContractable3.TitleText = "Dokter Penanggung Jawab [ " & PermintaanRow.Field(Of String)("nmAhligizi") & " ]"
        fRencana.lblDiagnosaGizi.Text = PermintaanRow.Field(Of String)("diagnosaGizi")
        fRencana.lblBentukMakanan.Text = PermintaanRow.Field(Of String)("bentukMakanan")

        fRencana.lblExtraDiet.Text = PermintaanRow.Field(Of String)("extraDiet")
        fRencana.lblKetDiet.Text = PermintaanRow.Field(Of String)("keteranganDiet")

        dgvPermintaan.CurrentRow.Cells("kdMinta").ErrorText = ""
        dgvPermintaan.CurrentRow.Cells("kdMinta").Style.ForeColor = Color.Black
        dgvPermintaan.CurrentRow.Cells("kdMinta").Style.Font = New Font(dgvPermintaan.DefaultCellStyle.Font, FontStyle.Regular)


        If CountNotify <> 0 Then
            CountNotify = 0
            MenuUtama.btnMenu4.Number = Nothing
            MenuUtama.niPopupStatus.Icon = My.Resources.Nutri2
        End If


        MenuUtama.StopDependent()
        fRencana.ShowDialog()

    End Sub
#End Region

#Region "Datagridview Permintaan Button"
    Sub ShowNameFromButton(ByVal GridView As DataGridView, ByVal e As DataGridViewCellEventArgs)
        If DirectCast(GridView.Item("Details", e.RowIndex), DataGridViewDisableButtonCell).Enabled Then
            TambahRencana()
        End If
    End Sub
    Private Sub CreateUnboundButtonColumn(ByVal sender As DataGridView)

        '  Dim ColumnCancel As New DataGridViewDisableButtonColumn

        With ColumnCancel
            .HeaderText = "Editor"
            .Name = "Details"
            .Text = "Proses"
            .ToolTipText = "Rencana Distribusi"
            .UseColumnTextForButtonValue = True
        End With
        sender.Columns.Insert(16, ColumnCancel)
        dgvPermintaan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

    End Sub
    Private Sub dgvPermintaan_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPermintaan.CellContentClick
        If CountNotify <> 0 Then
            CountNotify = 0
            MenuUtama.btnMenu4.Number = Nothing
            MenuUtama.niPopupStatus.Icon = My.Resources.Nutri2
        End If

        If IsHeaderButtonCell(dgvPermintaan, e) Then
            ShowNameFromButton(dgvPermintaan, e)
        End If
    End Sub
    <System.Diagnostics.DebuggerStepThrough()>
    Function IsHeaderButtonCell(ByVal GridView As DataGridView, ByVal e As DataGridViewCellEventArgs) As Boolean
        Return TypeOf GridView.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso Not e.RowIndex = -1
    End Function
#End Region
    Protected Sub HitungDeteksiPermintaan()
        Dim usia As String
        Dim intAge As Integer

        For index As Integer = 0 To dgvPermintaan.RowCount - 1
            usia = dgvPermintaan.Rows(index).Cells("tglLahir").Value '.ToString
            intAge = Math.Floor(DateDiff(DateInterval.Month, DateValue(usia), Now()) / 12)
            'dgvPermintaan.Rows(index).Cells("kdUsia").Value = intAge
            'MsgBox(dgvPermintaan.Rows(index).Cells("kdUsia").Value.ToString)
            intAge = dgvPermintaan.Item(3, index).Value
        Next
    End Sub
    Private Sub dgvPermintaan_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvPermintaan.CellFormatting
        For i As Integer = 0 To Me.dgvPermintaan.Rows.Count - 1
            With dgvPermintaan.Rows(i)
                If Not IsDBNull(.Cells("nIMT").Value) Then
                    If .Cells("nIMT").Value <= 0 Then
                        .Cells("nIMT").Style.BackColor = Color.Black
                    ElseIf .Cells("nIMT").Value < 17 Then
                        .Cells("nIMT").Style.BackColor = Color.Red
                        tmrBlinkKurus.Enabled = True
                    ElseIf .Cells("nIMT").Value >= 17 And .Cells("nIMT").Value <= 18.5 Then
                        .Cells("nIMT").Style.ForeColor = Color.Black
                        .Cells("nIMT").Style.SelectionForeColor = Color.DarkGray
                        .Cells("nIMT").Style.BackColor = Color.Yellow
                        .Cells("nIMT").Style.SelectionBackColor = Color.ForestGreen
                    ElseIf .Cells("nIMT").Value >= 18.51 And .Cells("nIMT").Value < 25 Then
                        .Cells("nIMT").Style.ForeColor = Color.WhiteSmoke
                        .Cells("nIMT").Style.SelectionForeColor = Color.White
                        .Cells("nIMT").Style.BackColor = Color.Green
                        .Cells("nIMT").Style.SelectionBackColor = Color.Blue
                    ElseIf .Cells("nIMT").Value >= 25 And .Cells("nIMT").Value < 27 Then
                        .Cells("nIMT").Style.ForeColor = Color.White
                        .Cells("nIMT").Style.SelectionForeColor = Color.White
                        .Cells("nIMT").Style.BackColor = Color.FromArgb(1, 115, 199)
                        .Cells("nIMT").Style.SelectionBackColor = Color.Blue
                    ElseIf .Cells("nIMT").Value >= 27.0 Then
                        tmrBlinkObesitas.Enabled = True
                    ElseIf .Cells("nIMT").Value = 22.1 Then
                        .DefaultCellStyle.BackColor = Color.GreenYellow
                        .DefaultCellStyle.ForeColor = Color.Black
                        .DefaultCellStyle.SelectionForeColor = Color.DarkGray
                        .DefaultCellStyle.SelectionBackColor = Color.ForestGreen
                    End If
                Else
                    .Cells("nIMT").Style.BackColor = Color.Black
                    .Cells("nIMT").Style.ForeColor = Color.White
                    .Cells("nIMT").Style.SelectionForeColor = Color.White
                    .Cells("nIMT").Style.SelectionBackColor = Color.Black
                End If
            End With
        Next
    End Sub
    Private Sub TableLayoutPanel1_CellPaint(sender As Object, e As TableLayoutCellPaintEventArgs) Handles TableLayoutPanel1.CellPaint
        If e.Column = 1 Then
            e.Graphics.FillRectangle(Brushes.Red, e.CellBounds)
            lblKet1.Text = "SANGAT KURUS"
            lblKet1.ForeColor = Color.White
        ElseIf e.Column = 2 Then
            e.Graphics.FillRectangle(Brushes.Yellow, e.CellBounds)
            lblKet2.Text = "KURUS"
        ElseIf e.Column = 3 Then
            e.Graphics.FillRectangle(Brushes.Green, e.CellBounds)
            lblKet3.Text = "NORMAL"
            lblKet3.ForeColor = Color.White
        ElseIf e.Column = 4 Then
            e.Graphics.FillRectangle(Brushes.DeepSkyBlue, e.CellBounds)
            lblket4.Text = "OVERWEIGHT"
        ElseIf e.Column = 5 Then
            e.Graphics.FillRectangle(Brushes.Purple, e.CellBounds)
            lblKet5.Text = "OBESITAS"
            lblKet5.ForeColor = Color.White
        ElseIf e.Column = 6 Then
            e.Graphics.FillRectangle(Brushes.GreenYellow, e.CellBounds)
            lblKet6.Text = "IDEAL"
        End If
    End Sub
    Private Sub dgvPermintaan_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvPermintaan.DataBindingComplete
        Dim DGV As DataGridView
        DGV = CType(sender, DataGridView)
        DGV.ClearSelection()
    End Sub
    Private Sub tmrBlinkKurus_Tick(sender As Object, e As EventArgs) Handles tmrBlinkKurus.Tick
        KurusTanda()
    End Sub
    Private Sub tmrBlinkObesitas_Tick(sender As Object, e As EventArgs) Handles tmrBlinkObesitas.Tick
        ObesitasTanda()
    End Sub
    Protected Sub KurusTanda()
        If bblinkKurus = True Then
            For Each row As DataGridViewRow In dgvPermintaan.Rows
                If Not IsDBNull(row.Cells("nIMT").Value) Then
                    If row.Cells("nIMT").Value < 17 Then
                        row.Cells("nIMT").Style.ForeColor = Color.White
                    End If
                End If
            Next
            bblinkKurus = False
        ElseIf bblinkKurus = False Then
            For Each row As DataGridViewRow In dgvPermintaan.Rows
                If Not IsDBNull(row.Cells("nIMT").Value) Then
                    If row.Cells("nIMT").Value < 17 Then
                        row.Cells("nIMT").Style.ForeColor = Color.Black
                    End If
                End If
            Next
            bblinkKurus = True
        End If

    End Sub
    Protected Sub ObesitasTanda()
        If bblinkObesitas = True Then
            For Each row As DataGridViewRow In dgvPermintaan.Rows
                If Not IsDBNull(row.Cells("nIMT").Value) Then
                    If row.Cells("nIMT").Value >= 27.0 Then
                        row.Cells("nIMT").Style.BackColor = Color.Purple
                        row.Cells("nIMT").Style.ForeColor = Color.White
                    End If
                End If
            Next
            bblinkObesitas = False
        ElseIf bblinkObesitas = False Then

            For Each row As DataGridViewRow In dgvPermintaan.Rows
                If Not IsDBNull(row.Cells("nIMT").Value) Then
                    If (row.Cells("nIMT").Value >= 27.0) Then
                        row.Cells("nIMT").Style.BackColor = Color.SandyBrown
                        row.Cells("nIMT").Style.ForeColor = Color.White
                    End If
                End If
            Next
            bblinkObesitas = True
        End If

    End Sub
    Protected Sub BlinkingCell()
        'Kurus
        If bblinkKurus = True Then
            For Each row As DataGridViewRow In dgvDistribusi.Rows
                If Not IsDBNull(row.Cells("dIMT").Value) Then
                    If row.Cells("dIMT").Value < 17 Then
                        'row.DefaultCellStyle.BackColor = Color.HotPink
                        row.Cells("dIMT").Style.ForeColor = Color.White
                    End If
                End If
            Next
            bblinkKurus = False
        ElseIf bblinkKurus = False Then

            For Each row As DataGridViewRow In dgvDistribusi.Rows
                If Not IsDBNull(row.Cells("dIMT").Value) Then
                    If row.Cells("dIMT").Value < 17 Then
                        'row.DefaultCellStyle.BackColor = Color.LightPink
                        row.Cells("dIMT").Style.ForeColor = Color.Black
                    End If
                End If
            Next
            bblinkKurus = True
        End If

        'Obesitas
        If bblinkObesitas = True Then
            For Each row As DataGridViewRow In dgvDistribusi.Rows
                If Not IsDBNull(row.Cells("dIMT").Value) Then
                    If row.Cells("dIMT").Value >= 27.0 Then
                        row.Cells("dIMT").Style.BackColor = Color.Purple
                        row.Cells("dIMT").Style.ForeColor = Color.White
                    End If
                End If
            Next
            bblinkObesitas = False
        ElseIf bblinkObesitas = False Then

            For Each row As DataGridViewRow In dgvDistribusi.Rows
                If Not IsDBNull(row.Cells("dIMT").Value) Then
                    If row.Cells("dIMT").Value >= 27.0 Then
                        row.Cells("dIMT").Style.BackColor = Color.SandyBrown
                        row.Cells("dIMT").Style.ForeColor = Color.White
                    End If
                End If
            Next
            bblinkObesitas = True
        End If
    End Sub
    Private Sub Blink()
        While count > 0

            While Not go

                For Each row As DataGridViewRow In dgvPermintaan.Rows

                    If row.Cells("nIMT").Value >= 27.0 Then
                        row.Cells("nIMT").Style.BackColor = Color.Red
                    End If
                Next

                go = True
                ' Thread.Sleep(500)
            End While

            While go

                For Each row As DataGridViewRow In dgvPermintaan.Rows

                    If row.Cells(11).Value >= 27.0 Then
                        row.Cells("nIMT").Style.BackColor = Color.Green
                    End If
                Next

                go = False
                'Thread.Sleep(500)
            End While
        End While
    End Sub
    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        bsMinta.Filter = Nothing

        LoadPermintaan()

        Dim fcari As New FrmViewPermintaan
        Try
            If fcari.ShowDialog = DialogResult.Yes Then
                dgvPermintaan.AutoGenerateColumns = False
                dtMinta = minta.LookingForPermintaan(fcari.cboRuang.Text, fcari.TanggalDari.Value, fcari.TanggalSampai.Value)


                bsMinta.DataSource = dtMinta
                permintaanNavigator.BindingSource = bsMinta

                dgvPermintaan.DataSource = bsMinta
                tglMinta.Visible = True
                ColumnCancel.Visible = False
                nmStatus.Visible = True

                If nmStatus.Visible = True Then
                    For i As Integer = 0 To Me.dgvPermintaan.Rows.Count - 1
                        With dgvPermintaan.Rows(i)
                            If .Cells("nmStatus").Value.ToString = "PERMINTAAN" Then
                                '
                                ' .Cells("nmStatus").S
                                .Cells("nmStatus").Style.ForeColor = Color.Black
                                .Cells("nmStatus").Style.BackColor = Color.WhiteSmoke
                            ElseIf .Cells("nmStatus").Value.ToString = "TERIMA" Then
                                .Cells("nmStatus").Style.ForeColor = Color.Black
                                .Cells("nmStatus").Style.BackColor = Color.WhiteSmoke
                            ElseIf .Cells("nmStatus").Value.ToString = "SELESAI" Then
                                .Cells("nmStatus").Style.ForeColor = Color.Black
                                .Cells("nmStatus").Style.BackColor = Color.WhiteSmoke
                            End If
                        End With
                    Next
                End If

                SetDoubleBuffer(dgvPermintaan, True)
                dgvPermintaan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                'bsMinta.Filter = "tglPermintaan >='" & fcari.TanggalDari.Value & "'AND tglPermintaan <=" & fcari.TanggalSampai.Value & "'"

            End If
        Catch ex As Exception
            MsgBox(ex.Message, "Error Cari")
        End Try
    End Sub
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        bsMinta.Filter = Nothing
        LoadPermintaan()
    End Sub
    Private Sub dgvPermintaan_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles dgvPermintaan.DataError
    End Sub
#End Region
    Private Sub TabPermintaan_Click(sender As Object, e As EventArgs) Handles TabPermintaan.Click
        PanelEx1.Text = "Permintaan Pelayanan Gizi"
        LoadPermintaan()
    End Sub
    Private Sub TabDistribusi_Click(sender As Object, e As EventArgs) Handles TabDistribusi.Click
        PanelEx1.Text = "Distribusi Pelayanan Gizi"
        LoadDistribusi()
    End Sub
#Region "Distribusi"
#Region "CRUD Distribusi"
    Protected Sub ExtractRencana()
        Dim fcari As New frmDistribusi
        Dim elap As TimeSpan
        Dim RencanaRow As DataRow = CType(bsDistribusi.Current, DataRowView).Row

        fcari.lblRencanaDistribusi.Text = RencanaRow.Field(Of String)("KDRENCANADISTRIBUSI")
        fcari.lblKdPermintaan.Text = RencanaRow.Field(Of String)("kdPermintaan")
        fcari.lblNoRM.Text = RencanaRow.Field(Of String)("noRekamedis")
        fcari.lblNoDaftarRawatInap.Text = RencanaRow.Field(Of String)("noDaftarRawatInap")
        fcari.lblTanggalPermintaan.Text = RencanaRow.Field(Of DateTime)("tglPermintaan")
        fcari.lblNamaPasien.Text = RencanaRow.Field(Of String)("nmPasien")
        fcari.lblTglMasuk.Text = RencanaRow.Field(Of DateTime)("tglMasukRawatInap")
        fcari.namaWaktu = RencanaRow.Field(Of String)("WAKTU")
        kodeWaktu = RencanaRow.Field(Of String)("kdWaktu")
        fcari.GroupContractable1.TitleText = "Data Pasien " & RencanaRow.Field(Of String)("kelas") &
                                                ", No.Kamar " & RencanaRow.Field(Of String)("noKamar") &
                                                ", No.Bed " & RencanaRow.Field(Of String)("noBed")

        fcari.nomorKamar = RencanaRow.Field(Of String)("noKamar")
        fcari.nomorBed = RencanaRow.Field(Of String)("noBed")


        ' If Not rinap.isSame(PermintaanRow.Field(Of String)("kdRawatInap")) Then
        'fRencana.lblkdRawatInap.Text = PermintaanRow.Field(Of String)("kdRawatInap") & " - " & "Tidak Diketahui"
        'Else
        KodeKelasTemp = RencanaRow.Field(Of String)("KDKELAS")

        If rinap.AmbilRawatInap(RencanaRow.Field(Of String)("kdRawatInap")) Then
            fcari.lblkdRawatInap.Text = RencanaRow.Field(Of String)("kdRawatInap") & " - " & rinap.NamaRawatInap
        End If

        If rinap.NamaRawatInap = "Dahlia" And RencanaRow.Field(Of String)("KDKELAS") = "K14" Then
            If classDahlia.AmbilDahliaKelas("DAHLIA1") Then
                KodeKelasTemp = classDahlia.TipeDahlia
            End If
        ElseIf rinap.NamaRawatInap = "Dahlia" And KodeKelasTemp = "K12" Then
            If classDahlia.AmbilDahliaKelas("DAHLIA2") Then
                KodeKelasTemp = classDahlia.TipeDahlia
            End If
        ElseIf rinap.NamaRawatInap = "Dahlia" And KodeKelasTemp = "K02" Then
            If classDahlia.AmbilDahliaKelas("DAHLIA3") Then
                KodeKelasTemp = classDahlia.TipeDahlia
            End If
            'MsgBox(RencanaRow.Field(Of String)("KDKELAS"))
        End If

        elap = Today - RencanaRow.Field(Of DateTime)("tglLahir")
        fcari.lblTglLahir.Text = RencanaRow.Field(Of DateTime)("tglLahir") & " - " & Int(elap.Days / 365.25) & " tahun"
        If RencanaRow.Field(Of String)("jenisKelamin") = "P" Then
            fcari.lblJenisKelamin.Text = "Perempuan" 'PermintaanRow.Field(Of String)("jenisKelamin")
        ElseIf RencanaRow.Field(Of String)("jenisKelamin") = "L" Then
            fcari.lblJenisKelamin.Text = "Laki - laki"
        End If

        MenuUtama.StopDependent()

        If fcari.ShowDialog() = DialogResult.OK Then
            Try
                LoadDistribusi()
            Finally
                fcari.Dispose()
            End Try
        End If

    End Sub
    Protected Sub DeleteDetail()

        Dim DetilR As New DetilRencanaDistribusi
        Dim dtDetilRencana As DataTable

        Dim row As DataRow = CType(bsDistribusi.Current, DataRowView).Row

        Dim KodePermintaanRencana As String = row.Field(Of String)("kdPermintaan")
        Dim TanggalRencana As DateTime = row.Field(Of DateTime)("TANGGAL") 'dgvDistribusi.CurrentRow.Cells("tglDMinta").Value.ToString

        dtDetilRencana = DetilR.DataDetilRencana(KodePermintaanRencana, TanggalRencana)
        'bsDistribusi
        If dtDetilRencana.Rows.Count > 0 Then
            Try
                For i As Integer = 0 To dtDetilRencana.Rows.Count - 1
                    ops.RemoveCurrentDetilRencana(dtDetilRencana.Rows(i)("KDRENCANADISTRIBUSI").ToString,
                                                  dtDetilRencana.Rows(i)("id").ToString)
                Next
            Finally
                minta.UpdateStatusPermintaan("BATAL", dgvDistribusi.CurrentRow.Cells("kdDMinta").Value.ToString)
            End Try
        End If
    End Sub
#End Region
    Public Sub LoadDistribusi()
        dgvDistribusi.AutoGenerateColumns = False
        dtDistribusi = distribute.DataRencanaDistribusi

        bsDistribusi.DataSource = dtDistribusi
        bsDistribusi.Sort = "TANGGAL"
        DistribusiNavigator.BindingSource = bsDistribusi
        dgvDistribusi.DataSource = bsDistribusi
        ColumnDistribusi.Visible = True


        For i As Integer = 0 To Me.dgvDistribusi.Rows.Count - 1
            With dgvDistribusi.Rows(i)
                Dim buttonCell As DataGridViewDisableButtonCell = CType(.Cells("DetailDistribusi"), DataGridViewDisableButtonCell)
                Dim linkCetakCell As DataGridViewLinkCell = CType(.Cells("eCetak"), DataGridViewLinkCell)

                If .Cells("dKet").Value.ToString = "TERIMA" Then
                    .Cells("dKet").Style.ForeColor = Color.Black
                    .Cells("dKet").Style.BackColor = Color.White
                    .Cells("ColblBatal").Style.BackColor = Color.White
                    .Cells("eCetak").Style.BackColor = SystemColors.InactiveBorder

                    buttonCell.Enabled = True
                    .Cells("ColblBatal").Value = "Batal"

                ElseIf .Cells("dKet").Value.ToString = "SELESAI" Then
                    .Cells("dKet").Style.ForeColor = Color.Black
                    .Cells("dKet").Style.BackColor = Color.White
                    .Cells("ColblBatal").Style.BackColor = SystemColors.InactiveBorder

                    buttonCell.Enabled = False
                    .Cells("eCetak").Value = "eTicket"
                    .Cells("eCetak").Style.BackColor = Color.White
                    .Cells("DetailDistribusi").Style.BackColor = SystemColors.InactiveBorder
                End If
            End With
        Next

        SetDoubleBuffer(dgvDistribusi, True)
        dgvDistribusi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        tmrBlinkKurus.Enabled = False
        tmrBlinkObesitas.Enabled = False

        lblExportExcel.Visible = False
        btnExportExcel.Visible = False
        sepExport.Visible = False
    End Sub
    Private Sub LayoutPanelDistribusi_CellPaint(sender As Object, e As TableLayoutCellPaintEventArgs) Handles LayoutPanelDistribusi.CellPaint
        If e.Column = 1 Then
            e.Graphics.FillRectangle(Brushes.Red, e.CellBounds)
            lblKetDist1.Text = "SANGAT KURUS"
            lblKetDist1.ForeColor = Color.White
        ElseIf e.Column = 2 Then
            e.Graphics.FillRectangle(Brushes.Yellow, e.CellBounds)
            lblKetDist2.Text = "KURUS"
        ElseIf e.Column = 3 Then
            e.Graphics.FillRectangle(Brushes.Green, e.CellBounds)
            lblKetDist3.Text = "NORMAL"
            lblKetDist3.ForeColor = Color.White
        ElseIf e.Column = 4 Then
            e.Graphics.FillRectangle(Brushes.DeepSkyBlue, e.CellBounds)
            lblKetDist4.Text = "OVERWEIGHT"
        ElseIf e.Column = 5 Then
            e.Graphics.FillRectangle(Brushes.Purple, e.CellBounds)
            lblKetDist5.Text = "OBESITAS"
            lblKetDist5.ForeColor = Color.White
        ElseIf e.Column = 6 Then
            e.Graphics.FillRectangle(Brushes.GreenYellow, e.CellBounds)
            lblKetDist6.Text = "IDEAL"
        End If
    End Sub
    Private Sub dgvDistribusi_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvDistribusi.CellFormatting
        For i As Integer = 0 To Me.dgvDistribusi.Rows.Count - 1
            With dgvDistribusi.Rows(i)
                If Not IsDBNull(.Cells("dIMT").Value) Then
                    If .Cells("dIMT").Value < 17 Then
                        tmrDistribusi.Enabled = True
                        .DefaultCellStyle.BackColor = Color.Red
                    ElseIf .Cells("dIMT").Value >= 17 And .Cells("dIMT").Value <= 18.5 Then
                        .Cells("dIMT").Style.ForeColor = Color.Black
                        .Cells("dIMT").Style.SelectionForeColor = Color.DarkGray
                        .Cells("dIMT").Style.BackColor = Color.Yellow
                        .Cells("dIMT").Style.SelectionBackColor = Color.ForestGreen
                    ElseIf .Cells("dIMT").Value >= 18.51 And .Cells("dIMT").Value < 25 Then
                        .Cells("dIMT").Style.ForeColor = Color.WhiteSmoke
                        .Cells("dIMT").Style.SelectionForeColor = Color.White
                        .Cells("dIMT").Style.BackColor = Color.Green
                        .Cells("dIMT").Style.SelectionBackColor = Color.Blue
                    ElseIf .Cells("dIMT").Value >= 25 And .Cells("dIMT").Value < 27 Then
                        .Cells("dIMT").Style.ForeColor = Color.Black
                        .Cells("dIMT").Style.SelectionForeColor = Color.White
                        .Cells("dIMT").Style.BackColor = Color.FromArgb(1, 115, 199)
                        .Cells("dIMT").Style.SelectionBackColor = Color.Blue
                    ElseIf .Cells("dIMT").Value >= 27.0 Then
                        tmrDistribusi.Enabled = True
                    ElseIf .Cells("dIMT").Value = 22.1 Then
                        .DefaultCellStyle.BackColor = Color.GreenYellow
                        .DefaultCellStyle.ForeColor = Color.Black
                        .DefaultCellStyle.SelectionForeColor = Color.DarkGray
                        .DefaultCellStyle.SelectionBackColor = Color.ForestGreen
                    End If
                Else
                    .Cells("dIMT").Style.BackColor = Color.Black
                    .Cells("dIMT").Style.ForeColor = Color.White
                    .Cells("dIMT").Style.SelectionForeColor = Color.White
                    .Cells("dIMT").Style.SelectionBackColor = Color.Black
                End If
            End With
        Next
    End Sub
    Private Sub tmrDistribusi_Tick(sender As Object, e As EventArgs) Handles tmrDistribusi.Tick
        BlinkingCell()
    End Sub
    Private Sub btnCariDistribusi_Click(sender As Object, e As EventArgs) Handles btnCariDistribusi.Click
        Dim fcari As New frmViewDistribusi
        Try
            If fcari.ShowDialog = DialogResult.Yes Then
                dgvDistribusi.AutoGenerateColumns = False
                dtDistribusi = distribute.LookingForDistribusi(fcari.cboRuang.Text, fcari.TanggalDari.Value, fcari.TanggalSampai.Value, fcari.cboStatus.Text)


                bsDistribusi.DataSource = dtDistribusi
                DistribusiNavigator.BindingSource = bsDistribusi

                dgvDistribusi.DataSource = bsDistribusi

                ColumnDistribusi.Visible = False


                ' HeaderChoice = Nothing
                '  dgvDistribusi.Columns(25).HeaderCell = HeaderChoice

                For i As Integer = 0 To Me.dgvDistribusi.Rows.Count - 1
                    With dgvDistribusi.Rows(i)

                        If .Cells("dKet").Value.ToString = "TERIMA" Then
                            .Cells("dKet").Style.ForeColor = Color.Black
                            .Cells("dKet").Style.BackColor = Color.WhiteSmoke
                            .Cells("eCetak").Value = Nothing
                        ElseIf .Cells("dKet").Value.ToString = "SELESAI" Then
                            .Cells("dKet").Style.ForeColor = Color.Black
                            .Cells("dKet").Style.BackColor = Color.WhiteSmoke
                            .Cells("eCetak").Value = "eTicket"
                        End If
                    End With
                Next


                SetDoubleBuffer(dgvDistribusi, True)
                dgvDistribusi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                If dgvDistribusi.RowCount <> 0 Then
                    sepExport.Visible = True
                    lblExportExcel.Visible = True
                    btnExportExcel.Visible = True
                    NamaRuanganExcel = fcari.cboRuang.Text
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnRefreshDistribusi_Click(sender As Object, e As EventArgs) Handles btnRefreshDistribusi.Click
        LoadDistribusi()
    End Sub

#Region "Excel"
    Private Function FindSheet(ByVal workbook As Excel.Workbook, ByVal sheet_name As String) As Excel.Worksheet
        For Each sheet As Excel.Worksheet In workbook.Sheets
            If (sheet.Name = sheet_name) Then Return sheet
        Next sheet

        Return Nothing
    End Function
    Protected Sub CetakStruk()
        dtPermintaanMenu = MintaMenu.DataPermintaanMenu(dgvDistribusi.CurrentRow.Cells("kdDMinta").Value.ToString)
        ListKodeDiet = (From r In dtPermintaanMenu.AsEnumerable() Select r.Field(Of String)(1)).ToList()
        Dim messageKodeDiet = String.Join(Environment.NewLine, ListKodeDiet.ToArray())

        FileLocationExcel = Application.StartupPath + "\template\TemplateGizi.xlsm"
        ' Dim i As Integer
        ' Dim j As Integer
        Dim rowIndex As Integer = 1
        Dim excel_app As New Excel.ApplicationClass

        Dim caption As String = excel_app.Caption
        Dim handler As IntPtr = FindWindow(Nothing, caption)
        SetForegroundWindow(handler)

        excel_app.Visible = True
        excel_app.DisplayAlerts = False
        excel_app.Interactive = False

        Dim workbook As Excel.Workbook =
            excel_app.Workbooks.Open(Filename:=FileLocationExcel)


        Dim sheet_name As String = "E-TICKET"

        Dim sheet As Excel.Worksheet = FindSheet(workbook, sheet_name)
        If (sheet Is Nothing) Then

            sheet = DirectCast(workbook.Sheets.Add(
                After:=workbook.Sheets(workbook.Sheets.Count),
                Count:=1,
                Type:=Excel.XlSheetType.xlWorksheet), Excel.Worksheet)
            sheet.Name = sheet_name
        ElseIf sheet IsNot Nothing Then
            sheet.Name = sheet_name
            sheet.Activate()
        End If

        With sheet

            .Range("B2").Value = UCase(dgvDistribusi.Rows(0).Cells("dRuang").Value.ToString.Trim)
            .Range("B2").Font.Bold = True
            .Range("B2").Font.Underline = True

            .Range("B3:C3").Merge()
            .Range("B3").Value = dgvDistribusi.CurrentRow.Cells("dWaktu").Value.ToString.Trim & " / " &
                                 "Snack : " & UCase(dgvDistribusi.CurrentRow.Cells("nmSnack").Value.ToString.Trim)
            .Range("B3:C3").HorizontalAlignment = Excel.Constants.xlCenter

            .Range("B4").Value = "Nama :"
            .Range("C4").Value = dgvDistribusi.CurrentRow.Cells("nmPasienD").Value.ToString.Trim

            .Range("B5").Value = "TL :"
            .Range("C5").Value = CDate(dgvDistribusi.CurrentRow.Cells("DtglLahir").Value.ToString.Trim)

            .Range("B6").Value = "No RM :"
            .Range("C6").Value = dgvDistribusi.CurrentRow.Cells("NodRM").Value.ToString.Trim


            .Range("B7").Value = "Diet :"

            .Range("C5").HorizontalAlignment = Excel.Constants.xlLeft
            .Range("C6").HorizontalAlignment = Excel.Constants.xlLeft
            .Range("B4").HorizontalAlignment = Excel.Constants.xlRight
            .Range("B5").HorizontalAlignment = Excel.Constants.xlRight
            .Range("B6").HorizontalAlignment = Excel.Constants.xlRight
            .Range("B7").HorizontalAlignment = Excel.Constants.xlRight

            Dim counter As Integer = 3
            Dim CountNormal As Integer = 7
            Dim CountWith As Integer = 2
            For Each row In dtPermintaanMenu.AsEnumerable()
                If dtPermintaanMenu.Rows.Count <> 0 Then
                    .Range("E" + counter.ToString(), "E" + counter.ToString()).Value = row("KDDIET")
                    .Range("F" + counter.ToString(), "H" + counter.ToString()).Value = row("KETERANGANDIET")
                    .Range("F" + counter.ToString(), "H" + counter.ToString()).Merge()
                    counter += 1

                    CountWith += 1

                End If
                .Range("C" + CountNormal.ToString(), "C" + CountNormal.ToString()).Value = row("KETERANGANDIET")
                CountNormal += 1
            Next

            .Range("B" + CountNormal.ToString()).Value = "Alergi :"
            .Range("B" + CountNormal.ToString()).HorizontalAlignment = Excel.Constants.xlRight
            .Range("C" + CountNormal.ToString()).Value = dgvDistribusi.CurrentRow.Cells("dAlergi").Value.ToString.Trim

            CountNormal += 1

            .Range("B" + CountNormal.ToString()).Value = "Keterangan :"
            .Range("B" + CountNormal.ToString()).HorizontalAlignment = Excel.Constants.xlRight
            .Range("C" + CountNormal.ToString()).Value = dgvDistribusi.CurrentRow.Cells("ketDietNama").Value.ToString.Trim


            CountNormal += 1
            .Range("B" + CountNormal.ToString(), "C" + CountNormal.ToString()).Merge()
            .Range("B" + CountNormal.ToString()).Value = "PENGAMBILAN ALAT MAKAN " 'SETELAH 1 JAM DISTRIBUSI"
            .Range("B" + CountNormal.ToString(), "C" + CountNormal.ToString()).Font.Bold = True
            .Range("B" + CountNormal.ToString(), "C" + CountNormal.ToString()).HorizontalAlignment = Excel.Constants.xlCenter
            '.Range("B" + CountNormal.ToString(), "C" + CountNormal.ToString()).BorderAround2(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin)
            '.Range("B" + CountNormal.ToString(), "C" + CountNormal.ToString()).Borders.LineStyle = Excel.XlLineStyle.xlDouble
            .Range("B" + CountNormal.ToString(), "C" + CountNormal.ToString()).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous



            CountNormal += 1
            .Range("B" + CountNormal.ToString(), "C" + CountNormal.ToString()).Merge()
            .Range("B" + CountNormal.ToString()).Value = "SETELAH 1 JAM DISTRIBUSI" 'SETELAH 1 JAM DISTRIBUSI"
            .Range("B" + CountNormal.ToString(), "C" + CountNormal.ToString()).Font.Bold = True
            .Range("B" + CountNormal.ToString(), "C" + CountNormal.ToString()).HorizontalAlignment = Excel.Constants.xlCenter
            '.Range("B" + CountNormal.ToString(), "C" + CountNormal.ToString()).BorderAround2(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin)
            .Range("B2", "C" + CountNormal.ToString()).BorderAround()
            .Range("B2", "C" + CountNormal.ToString()).EntireColumn.AutoFit()

            If dtPermintaanMenu.Rows.Count <> 0 Then
                .Range("E2").Value = "KETERANGAN DIET"
                .Range("E2").Font.Bold = True
                .Range("E2").Font.Underline = True
                .Range("E2", "H" + CountWith.ToString()).BorderAround2(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin)
            End If
        End With

        '  FileLocationExcel = FileLocationExcel.Replace(".xlsx", ".pdf")
        ' Const xlQualityStandard As Integer = 0
        'sheet.ExportAsFixedFormat(Excel.XlFixedFormatType.xlTypePDF, FileLocationExcel, xlQualityStandard, True, False, Type.Missing, Type.Missing, True, Type.Missing)


        excel_app.Interactive = True
        excel_app.ActiveWindow.Activate()

        'workbook.Close(True, Type.Missing, Type.Missing)
    End Sub
    Protected Sub CetakSemua()
        dtPermintaanMenu = MintaMenu.DataPermintaanMenu(dgvDistribusi.CurrentRow.Cells("kdDMinta").Value.ToString)
        ListKodeDiet = (From r In dtPermintaanMenu.AsEnumerable() Select r.Field(Of String)(1)).ToList()
        Dim messageKodeDiet = String.Join(Environment.NewLine, ListKodeDiet.ToArray())

        FileLocationExcel = Application.StartupPath + "\template\TemplateGizi.xlsm"
        ' Dim i As Integer
        ' Dim j As Integer
        Dim rowIndex As Integer = 1
        Dim excel_app As New Excel.ApplicationClass

        Dim caption As String = excel_app.Caption
        Dim handler As IntPtr = FindWindow(Nothing, caption)
        SetForegroundWindow(handler)

        excel_app.Visible = True
        excel_app.DisplayAlerts = False
        excel_app.Interactive = False

        Dim workbook As Excel.Workbook =
            excel_app.Workbooks.Open(Filename:=FileLocationExcel)


        Dim sheet_name As String = "E-TICKET"

        Dim sheet As Excel.Worksheet = FindSheet(workbook, sheet_name)
        If (sheet Is Nothing) Then

            sheet = DirectCast(workbook.Sheets.Add(
                After:=workbook.Sheets(workbook.Sheets.Count),
                Count:=1,
                Type:=Excel.XlSheetType.xlWorksheet), Excel.Worksheet)
            sheet.Name = sheet_name
        ElseIf sheet IsNot Nothing Then
            sheet.Name = sheet_name
            sheet.Activate()
        End If

        With sheet
            rowIndex += 1
            For i = 0 To Me.dgvDistribusi.RowCount - 1
                If Me.dgvDistribusi.Rows(i).Cells("dKet").Value.ToString = "SELESAI" Then
                    .Cells(rowIndex, 2).Font.Bold = True
                    .Cells(rowIndex, 2).Font.Underline = True
                    .Cells(rowIndex, 2) = Me.dgvDistribusi.Rows(i).Cells("dRuang").Value.TRIM



                    .Cells(rowIndex + 1, 3) = Me.dgvDistribusi.Rows(i).Cells("dWaktu").Value.ToString.Trim & " / " &
                                 "Snack : " & UCase(Me.dgvDistribusi.Rows(i).Cells("nmSnack").Value.ToString.Trim)
                    .Range(.Cells(rowIndex + 1, 3), .Cells(rowIndex + 1, 3)).HorizontalAlignment = Excel.Constants.xlCenter

                    .Cells(rowIndex + 2, 2) = "Nama :"
                    .Cells(rowIndex + 2, 3) = Me.dgvDistribusi.Rows(i).Cells("nmPasienD").Value.ToString.Trim

                    .Cells(rowIndex + 3, 2) = "TL :"
                    .Cells(rowIndex + 3, 3) = CDate(Me.dgvDistribusi.Rows(i).Cells("DtglLahir").Value.ToString)

                    .Cells(rowIndex + 4, 2) = "No RM :"
                    .Cells(rowIndex + 4, 3) = Me.dgvDistribusi.Rows(i).Cells("NodRM").Value.ToString.Trim


                    '.Range(.Cells(rowIndex, 2), .Cells(rowIndex + 5, 3)).EntireColumn.AutoFit()

                    .Range(.Cells(rowIndex + 1, 2), .Cells(rowIndex + 1, 3)).Merge()
                    ' .Range(.Cells(rowIndex, 2), .Cells(rowIndex + 5, 3)).BorderAround()
                    rowIndex += 7
                End If
            Next
        End With
        '  FileLocationExcel = FileLocationExcel.Replace(".xlsx", ".pdf")
        ' Const xlQualityStandard As Integer = 0
        'sheet.ExportAsFixedFormat(Excel.XlFixedFormatType.xlTypePDF, FileLocationExcel, xlQualityStandard, True, False, Type.Missing, Type.Missing, True, Type.Missing)


        excel_app.Interactive = True
        excel_app.ActiveWindow.Activate()

        'workbook.Close(True, Type.Missing, Type.Missing)
    End Sub
    Protected Sub MutuGizi()
        FileLocationExcel = Application.StartupPath + "\template\TemplateGizi.xlsm"
        Dim i As Integer

        Dim rowIndex As Integer = 1
        Dim excel_app As New Excel.ApplicationClass

        Dim caption As String = excel_app.Caption
        Dim handler As IntPtr = FindWindow(Nothing, caption)
        SetForegroundWindow(handler)

        excel_app.Visible = True
        excel_app.DisplayAlerts = False
        excel_app.Interactive = False

        ' Open the workbook.
        Dim workbook As Excel.Workbook =
            excel_app.Workbooks.Open(Filename:=FileLocationExcel)

        ' See if the worksheet already exists.
        Dim sheet_name As String = UCase(NamaRuanganExcel)

        Dim sheet As Excel.Worksheet = FindSheet(workbook, sheet_name)
        If (sheet Is Nothing) Then
            ' Add the worksheet at the end.
            sheet = DirectCast(workbook.Sheets.Add(
                After:=workbook.Sheets(workbook.Sheets.Count),
                Count:=1,
                Type:=Excel.XlSheetType.xlWorksheet), Excel.Worksheet)
            sheet.Name = sheet_name
        ElseIf sheet IsNot Nothing Then
            sheet.Name = sheet_name
            sheet.Activate()
        End If

        With sheet
            .Range("D6").Value = NamaRuanganExcel
            .Range("D7").Value = MonthName(Today.Month) & " " & Today.Year
            rowIndex += 10
            For i = 0 To Me.dgvDistribusi.RowCount - 1
                .Cells(rowIndex, 2) = Me.dgvDistribusi.Rows(i).Cells("NodRM").Value.TRIM
                .Cells(rowIndex, 3) = Me.dgvDistribusi.Rows(i).Cells("nmPasienD").Value.TRIM
                .Cells(rowIndex, 4) = Me.dgvDistribusi.Rows(i).Cells("tglMasukRInap").Value
                .Cells(rowIndex, 8) = Me.dgvDistribusi.Rows(i).Cells("DtglLahir").Value
                .Cells(rowIndex, 9) = Me.dgvDistribusi.Rows(i).Cells("dBB").Value.TRIM
                .Cells(rowIndex, 10) = Me.dgvDistribusi.Rows(i).Cells("dTB").Value.TRIM '& " [" & Me.dgvItem.Rows(i).Cells("VATCat").Value & "% VAT]"
                .Cells(rowIndex, 11) = Me.dgvDistribusi.Rows(i).Cells("dLK").Value.TRIM
                If UCase(NamaRuanganExcel) = "DAHLIA" Or
                   UCase(NamaRuanganExcel) = "MAWAR" Or
                   UCase(NamaRuanganExcel) = "KEMUNING" Or
                   UCase(NamaRuanganExcel) = "TERATAI" Or
                   UCase(NamaRuanganExcel) = "ICU" Then
                    .Cells(rowIndex, 16) = Me.dgvDistribusi.Rows(i).Cells("dDiagnosaGizi").Value.TRIM
                ElseIf UCase(NamaRuanganExcel) = "MATAHARI" Then
                    .Cells(rowIndex, 17) = Me.dgvDistribusi.Rows(i).Cells("dDiagnosaGizi").Value.TRIM
                End If
                rowIndex += 1
            Next
        End With
        excel_app.Interactive = True
        excel_app.ActiveWindow.Activate()
    End Sub
#End Region
#Region "Datagridview Distribusi Button"
    Private Sub HeaderChoice_CheckBoxClicked(sender As Object, e As DataGridViewCheckBoxHeaderCellEventArgs) Handles HeaderChoice.CheckBoxClicked
        HeaderChoice.CheckUncheckEntireColumn(e.Checked)
    End Sub
    Sub ShowNameFromButtonDistribusi(ByVal GridView As DataGridView, ByVal e As DataGridViewCellEventArgs)
        If DirectCast(GridView.Item("DetailDistribusi", e.RowIndex), DataGridViewDisableButtonCell).Enabled Then
            ExtractRencana()
        End If
    End Sub
    Private Sub CreateUnboundButtonColumnDistribusi(ByVal sender As DataGridView)
        With ColumnDistribusi
            .HeaderText = "Editor"
            .Name = "DetailDistribusi"
            .Text = "Distribusi"
            .ToolTipText = "Distribusi"
            .UseColumnTextForButtonValue = True
        End With
        sender.Columns.Insert(18, ColumnDistribusi)
    End Sub
    Private Sub dgvDistribusi_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDistribusi.CellContentClick

        If IsHeaderButtonCell(dgvDistribusi, e) Then
            ShowNameFromButtonDistribusi(dgvDistribusi, e)
            ' HeaderChoice.RefreshCheckState()
        End If

        If e.ColumnIndex = dgvDistribusi.Columns("ColblBatal").Index And e.RowIndex <> -1 Then
            Dim P As String = MsgBox("Apakah anda ingin membatalkan rencana distribusi untuk pasien " & dgvDistribusi.CurrentRow.Cells("nmPasienD").Value.ToString & " dari ruang rawat inap " &
                             dgvDistribusi.CurrentRow.Cells("dRuang").Value.ToString & " [ " & dgvDistribusi.CurrentRow.Cells("dWaktu").Value.ToString & " ]" &
                             " dengan menu diet " & dgvDistribusi.CurrentRow.Cells("dKelas").Value.ToString & "-" & dgvDistribusi.CurrentRow.Cells("dDiet").Value.ToString & " pada tanggal " & Today & "." & vbNewLine & vbNewLine &
                             "Apakah anda setuju ?", MsgBoxStyle.OkCancel, "Pembatalan Rencana Distribusi")
            If P = vbOK Then
                Try
                    MenuUtama.StopDependent()
                    minta.UpdateStatusPermintaan("BATAL", dgvDistribusi.CurrentRow.Cells("kdDMinta").Value.ToString)
                Finally
                    MenuUtama.SQLDependencies()
                    LoadDistribusi()
                End Try
            End If
        End If

        If e.ColumnIndex = dgvDistribusi.Columns("eCetak").Index And e.RowIndex <> -1 Then
            If dgvDistribusi.Rows(e.RowIndex).Cells("eCetak").Value = "eTicket" Then
                CetakStruk()
            ElseIf dgvDistribusi.Rows(e.RowIndex).Cells("eCetak").Value = "Semua" Then
                CetakSemua()
                '  MsgBox("Semua")
            End If
        End If

        If e.ColumnIndex = HeaderChoice.ColumnIndex Then

            For i As Integer = 0 To Me.dgvDistribusi.Rows.Count - 1
                If HeaderChoice.Checked = True Then
                    With dgvDistribusi.Rows(i)
                        If .Cells("dKet").Value.ToString = "TERIMA" Then
                            .Cells("dKet").Style.ForeColor = Color.Black
                            .Cells("dKet").Style.BackColor = Color.WhiteSmoke
                            .Cells("eCetak").Value = Nothing
                        ElseIf .Cells("dKet").Value.ToString = "SELESAI" Then
                            .Cells("dKet").Style.ForeColor = Color.Black
                            .Cells("dKet").Style.BackColor = Color.WhiteSmoke
                            .Cells("eCetak").Value = "Semua"
                        End If
                    End With
                ElseIf HeaderChoice.Checked = False Then
                    With dgvDistribusi.Rows(i)
                        If .Cells("dKet").Value.ToString = "TERIMA" Then
                            .Cells("dKet").Style.ForeColor = Color.Black
                            .Cells("dKet").Style.BackColor = Color.WhiteSmoke
                            .Cells("eCetak").Value = Nothing
                        ElseIf .Cells("dKet").Value.ToString = "SELESAI" Then
                            .Cells("dKet").Style.ForeColor = Color.Black
                            .Cells("dKet").Style.BackColor = Color.WhiteSmoke
                            .Cells("eCetak").Value = "eTicket"
                        End If
                    End With
                End If
            Next
        End If
    End Sub
    Private Sub dgvDistribusi_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles dgvDistribusi.DataError
    End Sub
    Private Sub btnExportExcel_Click(sender As Object, e As EventArgs) Handles btnExportExcel.Click
        MutuGizi()
    End Sub
#End Region
#Region "Test Timer"
    Private Sub tmrRefreshDistribusi_Tick(sender As Object, e As EventArgs) Handles tmrRefreshDistribusi.Tick
        Dim waktuTersisa As TimeSpan = hitungMundur.Subtract(Now)
        waktuTersisa = New TimeSpan(0, waktuTersisa.Minutes, waktuTersisa.Seconds)
        If waktuTersisa.TotalSeconds < 0 Then waktuTersisa = TimeSpan.Zero

        If waktuTersisa.TotalSeconds < 1 Or waktuTersisa.TotalSeconds = 0 Then
            tmrRefreshDistribusi.Stop()
            LoadDistribusi()
        End If
    End Sub
#End Region
#End Region
#Region "Cancel"
    Protected Sub CancelRencana()
        Dim fRencana As New frmRencanaDistribusi
        Dim elap As TimeSpan
        Dim CancelRencanaRow As DataRow = CType(bsDistribusi.Current, DataRowView).Row

        fRencana.lblKdPermintaan.Text = CancelRencanaRow.Field(Of String)("kdPermintaan")
        fRencana.lblNoRM.Text = CancelRencanaRow.Field(Of String)("noRekamedis")
        fRencana.lblNoDaftarRawatInap.Text = CancelRencanaRow.Field(Of String)("noDaftarRawatInap")
        fRencana.lblTanggalPermintaan.Text = CancelRencanaRow.Field(Of DateTime)("tglPermintaan")
        fRencana.lblNamaPasien.Text = CancelRencanaRow.Field(Of String)("nmPasien")
        fRencana.lblTglMasuk.Text = CancelRencanaRow.Field(Of DateTime)("tglMasukRawatInap")
        fRencana.lblWaktu.Text = CancelRencanaRow.Field(Of String)("WAKTU")
        kodeWaktu = CancelRencanaRow.Field(Of String)("kdWaktu")

        fRencana.GroupContractable1.TitleText = "Data Pasien " & CancelRencanaRow.Field(Of String)("kelas") &
                                                ", No.Kamar " & CancelRencanaRow.Field(Of String)("noKamar") &
                                                ", No.Bed " & CancelRencanaRow.Field(Of String)("noBed")

        fRencana.lblBB.Text = CancelRencanaRow.Field(Of String)("BB") & " kg"
        fRencana.lblTB.Text = CancelRencanaRow.Field(Of String)("TB") & " cm"
        fRencana.lblIMT.Text = CancelRencanaRow.Field(Of String)("IMT")
        fRencana.lblAlergi.Text = CancelRencanaRow.Field(Of String)("kdAlergi")

        fRencana.lblLK.Text = CancelRencanaRow.Field(Of String)("LK") & " cm"

        If CancelRencanaRow.Field(Of String)("LLApersen") = Nothing Then
            fRencana.lblLLA.Text = CancelRencanaRow.Field(Of String)("LLA") & " cm"
        Else
            fRencana.lblLLA.Text = CancelRencanaRow.Field(Of String)("LLA") & " cm / " & CancelRencanaRow.Field(Of String)("LLA") & "%"

        End If

        If rinap.AmbilRawatInap(CancelRencanaRow.Field(Of String)("kdRawatInap")) Then
            fRencana.lblkdRawatInap.Text = CancelRencanaRow.Field(Of String)("kdRawatInap") & " - " & rinap.NamaRawatInap
        End If

        elap = Today - CancelRencanaRow.Field(Of DateTime)("tglLahir")

        fRencana.lblTglLahir.Text = CancelRencanaRow.Field(Of DateTime)("tglLahir") & " - " & Int(elap.Days / 365.25) & " tahun"
        If CancelRencanaRow.Field(Of String)("jenisKelamin") = "P" Then
            fRencana.lblJenisKelamin.Text = "Perempuan"
        ElseIf CancelRencanaRow.Field(Of String)("jenisKelamin") = "L" Then
            fRencana.lblJenisKelamin.Text = "Laki - laki"
        End If

        fRencana.GroupContractable3.TitleText = "Dokter Penanggung Jawab [ " & CancelRencanaRow.Field(Of String)("nmAhligizi") & " ]"
        fRencana.lblDiagnosaGizi.Text = CancelRencanaRow.Field(Of String)("diagnosaGizi")
        fRencana.lblBentukMakanan.Text = CancelRencanaRow.Field(Of String)("bentukMakanan")
        fRencana.lblNamaDiet.Text = CancelRencanaRow.Field(Of String)("NamaDiet")
        fRencana.lblExtraDiet.Text = CancelRencanaRow.Field(Of String)("extraDiet")
        fRencana.lblKetDiet.Text = CancelRencanaRow.Field(Of String)("keteranganDiet")
        MenuUtama.StopDependent()
        fRencana.ShowDialog()
    End Sub
#End Region

End Class