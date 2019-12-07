Imports Pein
Imports WeifenLuo.WinFormsUI.Docking
Imports System.Data.Common
Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Imports System.Reflection
Imports System.Threading
Imports System.IO
'Imports Microsoft.Office.Interop
Imports Excel = Microsoft.Office.Interop.Excel
Imports Microsoft.Office
Imports System.Runtime.InteropServices
Imports System.ComponentModel
Imports System.Linq
Imports System.Text
Public Class frmSiklusStruck
    Private tSiklusStruck As New Pein.SiklusMenu
    Dim dtSiklusStruck As DataTable
    Private bsData As New BindingSource
    Dim FileLocationExcel As String

    Private NomorSiklus As String

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        KomponenSiklusParameter()
    End Sub
    Private Sub EnableVSRenderer(ByVal version As VisualStudioToolStripExtender.VsVersion, ByVal theme As ThemeBase)
        vsRender.SetStyle(StatusStrip1, version, theme)
    End Sub
    Private Sub frmSiklusStruck_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.EnableVSRenderer(VisualStudioToolStripExtender.VsVersion.Vs2015, VS2015LightTheme1)
        Panel2.BackColor = VS2015LightTheme1.ColorPalette.ToolWindowSeparator ',.Background
    End Sub
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        LaporanGizi()
        'MsgBox("Maaf, Masih Dalam pengembangan")
    End Sub
    Protected Sub KomponenSiklusParameter()
        TanggalDari.Value = Today.ToShortDateString
        If Today.Day = 1 Or Today.Day = 11 Or Today.Day = 21 Then
            cboSiklus.SelectedIndex = 0
        ElseIf Today.Day = 2 Or Today.Day = 12 Or Today.Day = 22 Then
            cboSiklus.SelectedIndex = 1
        ElseIf Today.Day = 3 Or Today.Day = 13 Or Today.Day = 23 Then
            cboSiklus.SelectedIndex = 2
        ElseIf Today.Day = 4 Or Today.Day = 14 Or Today.Day = 24 Then
            cboSiklus.SelectedIndex = 3
        ElseIf Today.Day = 5 Or Today.Day = 15 Or Today.Day = 25 Then
            cboSiklus.SelectedIndex = 4
        ElseIf Today.Day = 6 Or Today.Day = 16 Or Today.Day = 26 Then
            cboSiklus.SelectedIndex = 5
        ElseIf Today.Day = 7 Or Today.Day = 17 Or Today.Day = 27 Then
            cboSiklus.SelectedIndex = 6
        ElseIf Today.Day = 8 Or Today.Day = 18 Or Today.Day = 28 Then
            cboSiklus.SelectedIndex = 7
        ElseIf Today.Day = 9 Or Today.Day = 19 Or Today.Day = 29 Then
            cboSiklus.SelectedIndex = 8
        ElseIf Today.Day = 10 Or Today.Day = 20 Or Today.Day = 30 Then
            cboSiklus.SelectedIndex = 9
        ElseIf Today.Day = 31 Then
            cboSiklus.SelectedIndex = 10
        End If

        cboWaktu.SelectedIndex = 0
    End Sub
    Protected Sub LoadStruck()
        dtSiklusStruck = tSiklusStruck.DataNotaSiklusMenu(cboWaktu.Text, cboSiklus.Text, TanggalDari.Value)
        bsData.DataSource = dtSiklusStruck
        bsData.Sort = "nmMakanan"

        dgvRincian.DataSource = bsData
        dgvRincian.Columns("nmMakanan").HeaderText = "Makanan"
        dgvRincian.Columns("Selesai").HeaderText = "Terkirim"
        dgvRincian.Columns("Batal").HeaderText = "Dibatalkan"
        dgvRincian.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        HitungTotal()

        For i As Integer = 0 To Me.dgvRincian.Rows.Count - 1
            With dgvRincian.Rows(i)
                .Cells("Jumlah").Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Cells("Batal").Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Cells("Selesai").Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            End With
        Next
        SetGridViewSortState(Me.dgvRincian, DataGridViewColumnSortMode.NotSortable)
    End Sub
    Private Sub cboSiklus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSiklus.SelectedIndexChanged
        If cboSiklus.SelectedIndex = 0 Then
            NomorSiklus = "MENU I"
        ElseIf cboSiklus.SelectedIndex = 1 Then
            NomorSiklus = "MENU II"
        ElseIf cboSiklus.SelectedIndex = 2 Then
            NomorSiklus = "MENU III"
        ElseIf cboSiklus.SelectedIndex = 3 Then
            NomorSiklus = "MENU IV"
        ElseIf cboSiklus.SelectedIndex = 4 Then
            NomorSiklus = "MENU V"
        ElseIf cboSiklus.SelectedIndex = 5 Then
            NomorSiklus = "MENU VI"
        ElseIf cboSiklus.SelectedIndex = 6 Then
            NomorSiklus = "MENU VII"
        ElseIf cboSiklus.SelectedIndex = 7 Then
            NomorSiklus = "MENU VIII"
        ElseIf cboSiklus.SelectedIndex = 8 Then
            NomorSiklus = "MENU IX"
        ElseIf cboSiklus.SelectedIndex = 9 Then
            NomorSiklus = "MENU X"
        ElseIf cboSiklus.SelectedIndex = 10 Then
            NomorSiklus = "MENU XI"
        End If
    End Sub
    Private Sub TanggalDari_ValueChanged(sender As Object, e As EventArgs) Handles TanggalDari.ValueChanged
        Dim Siklus As String = TanggalDari.Value.Day.ToString
        If Siklus = 1 Or Siklus = 11 Or Siklus = 21 Then
            cboSiklus.SelectedIndex = 0
        ElseIf Siklus = 2 Or Siklus = 12 Or Siklus = 22 Then
            cboSiklus.SelectedIndex = 1
        ElseIf Siklus = 3 Or Siklus = 13 Or Siklus = 23 Then
            cboSiklus.SelectedIndex = 2
        ElseIf Siklus = 4 Or Siklus = 14 Or Siklus = 24 Then
            cboSiklus.SelectedIndex = 3
        ElseIf Siklus = 5 Or Siklus = 15 Or Siklus = 25 Then
            cboSiklus.SelectedIndex = 4
        ElseIf Siklus = 6 Or Siklus = 16 Or Siklus = 26 Then
            cboSiklus.SelectedIndex = 5
        ElseIf Siklus = 7 Or Siklus = 17 Or Siklus = 27 Then
            cboSiklus.SelectedIndex = 6
        ElseIf Siklus = 8 Or Siklus = 18 Or Siklus = 28 Then
            cboSiklus.SelectedIndex = 7
        ElseIf Siklus = 9 Or Siklus = 19 Or Siklus = 29 Then
            cboSiklus.SelectedIndex = 8
        ElseIf Siklus = 10 Or Siklus = 20 Or Siklus = 30 Then
            cboSiklus.SelectedIndex = 9
        ElseIf Siklus = 31 Then
            cboSiklus.SelectedIndex = 10
        End If
    End Sub
    Sub HitungTotal()
        Dim vRow As DataRow
        vRow = dtSiklusStruck.NewRow

        For i = 0 To dtSiklusStruck.Rows.Count - 1
            With dtSiklusStruck.Rows(i)
                vRow.Item(4) += .Item(4).ToString
                vRow.Item(5) += .Item(5).ToString
                vRow.Item(6) += .Item(6).ToString
            End With
        Next
        If dtSiklusStruck.Rows.Count <> 0 Then
            dtSiklusStruck.Rows.Add(Nothing, Nothing, Nothing, "xTotal :", vRow.Item(4).ToString, vRow.Item(5).ToString, vRow.Item(6).ToString)
            btnSimpan.Enabled = True
        Else
            btnSimpan.Enabled = False
        End If

        For y As Integer = 0 To dgvRincian.Rows.Count - 1
            For x As Integer = 0 To dgvRincian.Columns.Count - 1
                If dgvRincian.Rows(y).Cells(x).Value.ToString = "xTotal :" Then
                    dgvRincian.Rows(y).Cells(x).Style.Font = New Font("Arial", 10, FontStyle.Bold)
                    dgvRincian.Rows(y).Cells(x).Style.Alignment = DataGridViewContentAlignment.MiddleRight
                    dgvRincian.Rows(y).Cells(2).Style.Font = New Font("Arial", 9, FontStyle.Bold)
                    dgvRincian.Rows(y).Cells(3).Style.Font = New Font("Arial", 9, FontStyle.Bold)
                    If dgvRincian.Rows(y).Cells(2).Value >= dgvRincian.Rows(y).Cells(1).Value Then
                        dgvRincian.Rows(y).Cells(2).Style.Font = New Font("Arial", 11, FontStyle.Bold)
                        dgvRincian.Rows(y).Cells(2).Style.ForeColor = Color.Red
                    Else
                        dgvRincian.Rows(y).Cells(2).Style.ForeColor = Color.Black
                    End If
                    dgvRincian.Rows(y).Cells(3).Style.ForeColor = Color.Blue
                End If
            Next
        Next

    End Sub
    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        If cboSiklus.Text <> Nothing And cboWaktu.Text <> Nothing Then
            LoadStruck()
        Else
            dtSiklusStruck.Clear()
            bsData.DataSource = Nothing
            dgvRincian.DataSource = Nothing
            btnSimpan.Enabled = False
            MsgBox("Mohon masukkan kriteria pencarian dengan benar")
            Exit Sub
        End If
    End Sub
    Protected Overloads Overrides Sub WndProc(ByRef m As Message)
        'Define DoubleClick...
        Const WM_NCLBUTTONDBLCLK As Integer = &HA3


        If (m.Msg = WM_NCLBUTTONDBLCLK) Then
            Exit Sub
        End If
        MyBase.WndProc(m)
    End Sub
#Region "Excel"
#Region "TopMost Excel"
    <DllImport("user32.dll")>
    Private Shared Function SetForegroundWindow(ByVal hWnd As IntPtr) As <MarshalAs(UnmanagedType.Bool)> Boolean
    End Function
    <DllImport("user32.dll", SetLastError:=True)>
    Private Shared Function FindWindow(ByVal lpClassName As String, ByVal lpWindowName As String) As IntPtr
    End Function

#End Region
    Private Function FindSheet(ByVal workbook As Excel.Workbook, ByVal sheet_name As String) As Excel.Worksheet
        For Each sheet As Excel.Worksheet In workbook.Sheets
            If (sheet.Name = sheet_name) Then Return sheet
        Next sheet

        Return Nothing
    End Function
    Protected Sub LaporanGizi()
        FileLocationExcel = Application.StartupPath + "\template\SiklusLaporan.xlsx"
        ' Dim i As Integer

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
        Dim sheet_name As String = NomorSiklus

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
            For y As Integer = 0 To dgvRincian.Rows.Count - 1
                For x As Integer = 0 To dgvRincian.Columns.Count - 1
                    If NomorSiklus = "MENU I" Then
                        If cboWaktu.SelectedIndex = 0 Then
                            .Range("C3").Value = TanggalDari.Value.ToShortDateString
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Nasi" Then .Range("E7").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Nasi Tim" Then .Range("E8").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Bubur Kasar" Then .Range("E9").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Bubur Halus" Then .Range("E10").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()

                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Rawon daging (B/L)" Then .Range("E13").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Rawon daging (RG/DM)" Then .Range("E14").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()

                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Tempe goreng (DM/RG)" Then .Range("E16").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Oseng tempe (DL/DJ/DH/RS)" Then .Range("E17").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Oseng tempe (DM/RG)+(DL/DJ/DH/RS)" Then .Range("E18").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()

                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Labu Putih" Then .Range("E20").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Kecambah" Then .Range("E21").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            ' If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Bening Manisah (RP/RPUR)" Then .Range("E22").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            ' If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Bening Manisah  (DM/RG) + (RP/RPUR)" Then .Range("E23").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()

                            'If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Bening Manisah  (DM/RG) + (RP/RPUR)" Then .Range("E27").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()

                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Cair RG" Then .Range("E29").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Cair DM" Then .Range("E30").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            'If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Bening Manisah  (DM/RG) + (RP/RPUR)" Then .Range("E31").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                        End If
                        If cboWaktu.SelectedIndex = 1 Then
                            .Range("C47").Value = TanggalDari.Value.ToShortDateString
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Nasi" Then .Range("E50").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Nasi Tim" Then .Range("E51").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Bubur Kasar" Then .Range("E52").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Bubur Halus" Then .Range("E53").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()

                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Steam Telur With Capsicem (B/L)" Then .Range("E56").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Steam Telur With Capsicem  (DM/RG)" Then .Range("E57").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()

                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Pangsit Tahu Goreng (B)" Then .Range("E60").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Pangsit Tahu (L)" Then .Range("E61").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Pangsit Tahu  (DM/RG)" Then .Range("E62").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()

                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Sup Rusia (Wortel, Kentang) (B/L)" Then .Range("E64").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Sup Rusia (Wortel )  (DM/RG)" Then .Range("E65").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()

                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Sup Rusia (Wortel, Kentang) (B/L)" Then .Range("E68").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Sup Rusia (Wortel )  (DM/RG)" Then .Range("E69").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()

                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Sup Rusia (Wortel, Kentang) (B/L)" Then .Range("E72").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Sup Rusia (Wortel )  (DM/RG)" Then .Range("E73").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Sup Rusia (Wortel )  (DM/RG)" Then .Range("E74").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                        End If
                        If cboWaktu.SelectedIndex = 2 Then
                            .Range("C90").Value = TanggalDari.Value.ToShortDateString
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Nasi" Then .Range("E93").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Nasi Tim" Then .Range("E94").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Bubur Kasar" Then .Range("E95").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Bubur Halus" Then .Range("E96").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Pepes Ayam (B/L)" Then .Range("E99").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Pepes Ayam  (DM/RG)" Then .Range("E100").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Tempe Bacem (B)" Then .Range("E102").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Tempe Bacem (L)" Then .Range("E103").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Sayur Asem Jakarta (B/L)" Then .Range("E106").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Sayur Asem Jakarta  (DM/RG)" Then .Range("E107").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Sayur Bening Labu Siam (DH/DL/RS/RPUR)" Then .Range("E108").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Sayur Bening Labu Siam (DM/RG/DJ/DH/DL/RS/RP/RPUR)" Then .Range("E109").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()

                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Sayur Bening Labu Siam (DH/DL/RS/RPUR)" Then .Range("E111").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Sayur Bening Labu Siam (DM/RG/DJ/DH/DL/RS/RP/RPUR)" Then .Range("E112").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Sayur Bening Labu Siam (DH/DL/RS/RPUR)" Then .Range("E115").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Sayur Bening Labu Siam (DM/RG/DJ/DH/DL/RS/RP/RPUR)" Then .Range("E116").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Sayur Bening Labu Siam (DM/RG/DJ/DH/DL/RS/RP/RPUR)" Then .Range("E117").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                        End If
                    End If

                    If NomorSiklus = "MENU II" Then
                        If cboWaktu.SelectedIndex = 0 Then

                        End If
                        If cboWaktu.SelectedIndex = 1 Then

                        End If
                        If cboWaktu.SelectedIndex = 2 Then

                        End If
                    End If
                    If NomorSiklus = "MENU III" Then
                        If cboWaktu.SelectedIndex = 0 Then

                        End If
                        If cboWaktu.SelectedIndex = 1 Then

                        End If
                        If cboWaktu.SelectedIndex = 2 Then

                        End If
                    End If
                    If NomorSiklus = "MENU IV" Then
                        If cboWaktu.SelectedIndex = 0 Then

                        End If
                        If cboWaktu.SelectedIndex = 1 Then

                        End If
                        If cboWaktu.SelectedIndex = 2 Then

                        End If
                    End If
                    If NomorSiklus = "MENU V" Then
                        If cboWaktu.SelectedIndex = 0 Then

                        End If
                        If cboWaktu.SelectedIndex = 1 Then

                        End If
                        If cboWaktu.SelectedIndex = 2 Then

                        End If
                    End If
                    If NomorSiklus = "MENU VI" Then
                        If cboWaktu.SelectedIndex = 0 Then

                        End If
                        If cboWaktu.SelectedIndex = 1 Then

                        End If
                        If cboWaktu.SelectedIndex = 2 Then

                        End If
                    End If
                    If NomorSiklus = "MENU VII" Then
                        If cboWaktu.SelectedIndex = 0 Then

                        End If
                        If cboWaktu.SelectedIndex = 1 Then

                        End If
                        If cboWaktu.SelectedIndex = 2 Then

                        End If
                    End If
                    If NomorSiklus = "MENU VIII" Then
                        If cboWaktu.SelectedIndex = 0 Then
                            .Range("C3").Value = TanggalDari.Value.ToShortDateString
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Nasi" Then .Range("E7").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Nasi Tim" Then .Range("E8").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Bubur Kasar" Then .Range("E9").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Bubur Halus" Then .Range("E10").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()

                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Ayam Goreng Laos (B)" Then .Range("E13").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Ayam Laos (L)" Then .Range("E14").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Ayam Goreng Laos (B)" Then .Range("E15").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()

                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Ayam Laos (L)" Then .Range("E17").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Ayam Laos (L)" Then .Range("E18").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Ayam Laos (L)" Then .Range("E19").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()

                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Bening Kacang Panjang (B/L)" Then .Range("E22").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Bening Kacang Panjang (B/L)" Then .Range("E23").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Bening Manisah (RP/RPUR)" Then .Range("E24").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Bening Manisah  (DM/RG) + (RP/RPUR)" Then .Range("E25").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()

                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Bening Manisah  (DM/RG) + (RP/RPUR)" Then .Range("E27").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()

                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Bening Manisah  (DM/RG) + (RP/RPUR)" Then .Range("E30").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Bening Manisah  (DM/RG) + (RP/RPUR)" Then .Range("E31").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Bening Manisah  (DM/RG) + (RP/RPUR)" Then .Range("E32").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                        End If
                        If cboWaktu.SelectedIndex = 1 Then
                            .Range("C47").Value = TanggalDari.Value.ToShortDateString
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Nasi" Then .Range("E50").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Nasi Tim" Then .Range("E51").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Bubur Kasar" Then .Range("E52").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Bubur Halus" Then .Range("E53").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()

                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Steam Telur With Capsicem (B/L)" Then .Range("E56").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Steam Telur With Capsicem  (DM/RG)" Then .Range("E57").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()

                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Pangsit Tahu Goreng (B)" Then .Range("E60").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Pangsit Tahu (L)" Then .Range("E61").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Pangsit Tahu  (DM/RG)" Then .Range("E62").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()

                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Sup Rusia (Wortel, Kentang) (B/L)" Then .Range("E64").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Sup Rusia (Wortel )  (DM/RG)" Then .Range("E65").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()

                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Sup Rusia (Wortel, Kentang) (B/L)" Then .Range("E68").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Sup Rusia (Wortel )  (DM/RG)" Then .Range("E69").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()

                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Sup Rusia (Wortel, Kentang) (B/L)" Then .Range("E72").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Sup Rusia (Wortel )  (DM/RG)" Then .Range("E73").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Sup Rusia (Wortel )  (DM/RG)" Then .Range("E74").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                        End If
                        If cboWaktu.SelectedIndex = 2 Then
                            .Range("C90").Value = TanggalDari.Value.ToShortDateString
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Nasi" Then .Range("E93").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Nasi Tim" Then .Range("E94").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Bubur Kasar" Then .Range("E95").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Bubur Halus" Then .Range("E96").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Pepes Ayam (B/L)" Then .Range("E99").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Pepes Ayam  (DM/RG)" Then .Range("E100").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Tempe Bacem (B)" Then .Range("E102").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Tempe Bacem (L)" Then .Range("E103").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Sayur Asem Jakarta (B/L)" Then .Range("E106").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Sayur Asem Jakarta  (DM/RG)" Then .Range("E107").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Sayur Bening Labu Siam (DH/DL/RS/RPUR)" Then .Range("E108").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Sayur Bening Labu Siam (DM/RG/DJ/DH/DL/RS/RP/RPUR)" Then .Range("E109").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()

                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Sayur Bening Labu Siam (DH/DL/RS/RPUR)" Then .Range("E111").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Sayur Bening Labu Siam (DM/RG/DJ/DH/DL/RS/RP/RPUR)" Then .Range("E112").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Sayur Bening Labu Siam (DH/DL/RS/RPUR)" Then .Range("E115").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Sayur Bening Labu Siam (DM/RG/DJ/DH/DL/RS/RP/RPUR)" Then .Range("E116").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Sayur Bening Labu Siam (DM/RG/DJ/DH/DL/RS/RP/RPUR)" Then .Range("E117").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                        End If
                    End If
                    If NomorSiklus = "MENU IX" Then
                        If cboWaktu.SelectedIndex = 0 Then
                            .Range("C3").Value = TanggalDari.Value.ToShortDateString
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Nasi" Then .Range("E7").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Nasi Tim" Then .Range("E8").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Bubur Kasar" Then .Range("E9").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Bubur Halus" Then .Range("E10").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()

                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Ayam Goreng Laos (B)" Then .Range("E13").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Ayam Laos (L)" Then .Range("E14").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Ayam Goreng Laos (B)" Then .Range("E15").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()

                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Ayam Laos (L)" Then .Range("E17").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Ayam Laos (L)" Then .Range("E18").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Ayam Laos (L)" Then .Range("E19").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()

                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Bening Kacang Panjang (B/L)" Then .Range("E22").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Bening Kacang Panjang (B/L)" Then .Range("E23").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Bening Manisah (RP/RPUR)" Then .Range("E24").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Bening Manisah  (DM/RG) + (RP/RPUR)" Then .Range("E25").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()

                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Bening Manisah  (DM/RG) + (RP/RPUR)" Then .Range("E27").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()

                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Bening Manisah  (DM/RG) + (RP/RPUR)" Then .Range("E30").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Bening Manisah  (DM/RG) + (RP/RPUR)" Then .Range("E31").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Bening Manisah  (DM/RG) + (RP/RPUR)" Then .Range("E32").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                        End If
                        If cboWaktu.SelectedIndex = 1 Then
                            .Range("C47").Value = TanggalDari.Value.ToShortDateString
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Nasi" Then .Range("E50").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Nasi Tim" Then .Range("E51").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Bubur Kasar" Then .Range("E52").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Bubur Halus" Then .Range("E53").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()

                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Steam Telur With Capsicem (B/L)" Then .Range("E56").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Steam Telur With Capsicem  (DM/RG)" Then .Range("E57").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()

                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Besengek Tempe (B/L)" Then .Range("E60").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Besengek Tempe  (DM/RG)" Then .Range("E61").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Pangsit Tahu  (DM/RG)" Then .Range("E62").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()

                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Sup Rusia (Wortel, Kentang) (B/L)" Then .Range("E64").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Sup Rusia (Wortel )  (DM/RG)" Then .Range("E65").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()

                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Sup Rusia (Wortel, Kentang) (B/L)" Then .Range("E68").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Sup Rusia (Wortel )  (DM/RG)" Then .Range("E69").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()

                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Sup Rusia (Wortel, Kentang) (B/L)" Then .Range("E72").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Sup Rusia (Wortel )  (DM/RG)" Then .Range("E73").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Sup Rusia (Wortel )  (DM/RG)" Then .Range("E74").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                        End If
                        If cboWaktu.SelectedIndex = 2 Then
                            .Range("C90").Value = TanggalDari.Value.ToShortDateString
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Nasi" Then .Range("E93").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Nasi Tim" Then .Range("E94").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Bubur Kasar" Then .Range("E95").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Bubur Halus" Then .Range("E96").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Pepes Ayam (B/L)" Then .Range("E99").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Pepes Ayam  (DM/RG)" Then .Range("E100").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Tempe Bacem (B)" Then .Range("E102").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Tempe Bacem (L)" Then .Range("E103").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Sayur Asem Jakarta (B/L)" Then .Range("E106").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Sayur Asem Jakarta  (DM/RG)" Then .Range("E107").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Sayur Bening Labu Siam (DH/DL/RS/RPUR)" Then .Range("E108").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Sayur Bening Labu Siam (DM/RG/DJ/DH/DL/RS/RP/RPUR)" Then .Range("E109").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()

                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Sayur Bening Labu Siam (DH/DL/RS/RPUR)" Then .Range("E111").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Sayur Bening Labu Siam (DM/RG/DJ/DH/DL/RS/RP/RPUR)" Then .Range("E112").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Sayur Bening Labu Siam (DH/DL/RS/RPUR)" Then .Range("E115").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Sayur Bening Labu Siam (DM/RG/DJ/DH/DL/RS/RP/RPUR)" Then .Range("E116").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Sayur Bening Labu Siam (DM/RG/DJ/DH/DL/RS/RP/RPUR)" Then .Range("E117").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                        End If
                    End If
                    If NomorSiklus = "MENU X" Then
                        If cboWaktu.SelectedIndex = 0 Then
                            .Range("C3").Value = TanggalDari.Value.ToShortDateString
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Nasi" Then .Range("E7").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Nasi Tim" Then .Range("E8").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Bubur Kasar" Then .Range("E9").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Bubur Halus" Then .Range("E10").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()

                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Ayam Goreng Laos (B)" Then .Range("E13").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Ayam Laos (L)" Then .Range("E14").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Ayam Goreng Laos (B)" Then .Range("E15").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()

                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Ayam Laos (L)" Then .Range("E17").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Ayam Laos (L)" Then .Range("E18").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Ayam Laos (L)" Then .Range("E19").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()

                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Bening Kacang Panjang (B/L)" Then .Range("E22").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Bening Kacang Panjang (B/L)" Then .Range("E23").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Bening Manisah (RP/RPUR)" Then .Range("E24").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Bening Manisah  (DM/RG) + (RP/RPUR)" Then .Range("E25").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()

                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Bening Manisah  (DM/RG) + (RP/RPUR)" Then .Range("E27").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()

                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Bening Manisah  (DM/RG) + (RP/RPUR)" Then .Range("E30").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Bening Manisah  (DM/RG) + (RP/RPUR)" Then .Range("E31").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Bening Manisah  (DM/RG) + (RP/RPUR)" Then .Range("E32").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                        End If
                        If cboWaktu.SelectedIndex = 1 Then
                            .Range("C47").Value = TanggalDari.Value.ToShortDateString
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Nasi" Then .Range("E50").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Nasi Tim" Then .Range("E51").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Bubur Kasar" Then .Range("E52").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Bubur Halus" Then .Range("E53").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()

                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Steam Telur With Capsicem (B/L)" Then .Range("E56").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Steam Telur With Capsicem  (DM/RG)" Then .Range("E57").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()

                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Besengek Tempe (B/L)" Then .Range("E60").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Besengek Tempe (DM/RG)" Then .Range("E61").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Pangsit Tahu  (DM/RG)" Then .Range("E62").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()

                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Sup Rusia (Wortel, Kentang) (B/L)" Then .Range("E64").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Sup Rusia (Wortel )  (DM/RG)" Then .Range("E65").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()

                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Sup Rusia (Wortel, Kentang) (B/L)" Then .Range("E68").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Sup Rusia (Wortel )  (DM/RG)" Then .Range("E69").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()

                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Sup Rusia (Wortel, Kentang) (B/L)" Then .Range("E72").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Sup Rusia (Wortel )  (DM/RG)" Then .Range("E73").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Sup Rusia (Wortel )  (DM/RG)" Then .Range("E74").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                        End If
                        If cboWaktu.SelectedIndex = 2 Then
                            .Range("C90").Value = TanggalDari.Value.ToShortDateString
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Nasi" Then .Range("E93").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Nasi Tim" Then .Range("E94").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Bubur Kasar" Then .Range("E95").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Bubur Halus" Then .Range("E96").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Pepes Ayam (B/L)" Then .Range("E99").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Pepes Ayam  (DM/RG)" Then .Range("E100").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Tempe Bacem (B)" Then .Range("E102").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Tempe Bacem (L)" Then .Range("E103").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Sayur Asem Jakarta (B/L)" Then .Range("E106").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Sayur Asem Jakarta  (DM/RG)" Then .Range("E107").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Sayur Bening Labu Siam (DH/DL/RS/RPUR)" Then .Range("E108").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Sayur Bening Labu Siam (DM/RG/DJ/DH/DL/RS/RP/RPUR)" Then .Range("E109").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()

                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Sayur Bening Labu Siam (DH/DL/RS/RPUR)" Then .Range("E111").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Sayur Bening Labu Siam (DM/RG/DJ/DH/DL/RS/RP/RPUR)" Then .Range("E112").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Sayur Bening Labu Siam (DH/DL/RS/RPUR)" Then .Range("E115").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Sayur Bening Labu Siam (DM/RG/DJ/DH/DL/RS/RP/RPUR)" Then .Range("E116").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                            If dgvRincian.Rows(y).Cells(x).Value.ToString.Trim = "Sayur Bening Labu Siam (DM/RG/DJ/DH/DL/RS/RP/RPUR)" Then .Range("E117").Value = dgvRincian.Rows(y).Cells(1).Value.ToString()
                        End If
                    End If
                    If NomorSiklus = "MENU XI" Then
                        If cboWaktu.SelectedIndex = 0 Then

                        End If
                        If cboWaktu.SelectedIndex = 1 Then

                        End If
                        If cboWaktu.SelectedIndex = 2 Then

                        End If
                    End If
                Next
            Next
        End With

        excel_app.Interactive = True
        excel_app.ActiveWindow.Activate()
    End Sub
#End Region
End Class