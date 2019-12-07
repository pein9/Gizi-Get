Imports Pein
Imports WeifenLuo.WinFormsUI.Docking
Imports MySql.Data.MySqlClient
Public Class frmFormulaIMT
    Inherits DockContent

    Private ops As New Pein.cIMT
    Private bsData As New BindingSource
    Dim dtIMT As DataTable
    Dim Err As New Pein.BaseExceptionsHandler
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub frmFormulaIMT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtIMT = ops.DataFormulaIMT

        If Not String.IsNullOrWhiteSpace(Pein.con) Then
            For Each col As DataColumn In dgvIMT.Columns
                col.[ReadOnly] = False
            Next


            bsData.DataSource = dtIMT

            dgvIMT.DataSource = bsData

            'dgvIMT.Columns("JENISDIETID").HeaderText = "JENIS DIET"
            'dgvIMT.Columns("KETDIET").HeaderText = "KETERANGAN"
            'dgvIMT.Columns("CATATAN").HeaderText = "CATATAN"


            dgvIMT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            ' dgvNutrisi.ReadOnly = True
        End If
    End Sub
    Private Sub dgvIMT_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvIMT.CellFormatting
        For i As Integer = 0 To Me.dgvIMT.Rows.Count - 1
            If Me.dgvIMT.Rows(i).Cells("Kondisi").Value = "< 17.00" Then
                Me.dgvIMT.Rows(i).Cells("Kondisi").Style.ForeColor = Color.White
                Me.dgvIMT.Rows(i).Cells("Kondisi").Style.BackColor = Color.Red
                Me.dgvIMT.Rows(i).Cells("Kondisi").Style.SelectionBackColor = Color.DarkRed
            ElseIf Me.dgvIMT.Rows(i).Cells("Kondisi").Value = "17.00 - 18.50" Then
                Me.dgvIMT.Rows(i).Cells("Kondisi").Style.ForeColor = Color.Black
                Me.dgvIMT.Rows(i).Cells("Kondisi").Style.SelectionForeColor = Color.DarkGray
                Me.dgvIMT.Rows(i).Cells("Kondisi").Style.BackColor = Color.Yellow
                Me.dgvIMT.Rows(i).Cells("Kondisi").Style.SelectionBackColor = Color.ForestGreen
            ElseIf Me.dgvIMT.Rows(i).Cells("Kondisi").Value = "22.10" Then
                Me.dgvIMT.Rows(i).Cells("Kondisi").Style.ForeColor = Color.Black
                Me.dgvIMT.Rows(i).Cells("Kondisi").Style.SelectionForeColor = Color.DarkGray
                Me.dgvIMT.Rows(i).Cells("Kondisi").Style.BackColor = Color.GreenYellow
                Me.dgvIMT.Rows(i).Cells("Kondisi").Style.SelectionBackColor = Color.ForestGreen
            ElseIf Me.dgvIMT.Rows(i).Cells("Kondisi").Value = "18.51 - 25.00" Then
                Me.dgvIMT.Rows(i).Cells("Kondisi").Style.ForeColor = Color.WhiteSmoke
                Me.dgvIMT.Rows(i).Cells("Kondisi").Style.SelectionForeColor = Color.White
                Me.dgvIMT.Rows(i).Cells("Kondisi").Style.BackColor = Color.Green
                Me.dgvIMT.Rows(i).Cells("Kondisi").Style.SelectionBackColor = Color.Blue
            ElseIf Me.dgvIMT.Rows(i).Cells("Kondisi").Value = "25.01 - 27.00" Then
                Me.dgvIMT.Rows(i).Cells("Kondisi").Style.ForeColor = Color.WhiteSmoke
                Me.dgvIMT.Rows(i).Cells("Kondisi").Style.SelectionForeColor = Color.White
                Me.dgvIMT.Rows(i).Cells("Kondisi").Style.BackColor = Color.FromArgb(1, 115, 199)
                Me.dgvIMT.Rows(i).Cells("Kondisi").Style.SelectionBackColor = Color.Blue
            ElseIf Me.dgvIMT.Rows(i).Cells("Kondisi").Value = "> 27.00" Then
                Me.dgvIMT.Rows(i).Cells("Kondisi").Style.ForeColor = Color.WhiteSmoke
                Me.dgvIMT.Rows(i).Cells("Kondisi").Style.SelectionForeColor = Color.White
                Me.dgvIMT.Rows(i).Cells("Kondisi").Style.BackColor = Color.Purple
                Me.dgvIMT.Rows(i).Cells("Kondisi").Style.SelectionBackColor = Color.DarkOrange
            End If
        Next
    End Sub
End Class