Imports Pein
Imports WeifenLuo.WinFormsUI.Docking
Imports MySql.Data.MySqlClient
Public Class frmAKP
    Inherits DockContent

    Private ops As New Pein.AKP
    Private bsData As New BindingSource
    Dim dtAKp As DataTable
    Dim Err As New Pein.BaseExceptionsHandler

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub frmAKP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtAKp = ops.DataAKP

        bsData.DataSource = dtAKp
        bsData.Sort = "KET"
        dgvAKP.DataSource = bsData
        dgvAKP.Columns("KET").HeaderText = "Keterangan"
        dgvAKP.Columns("DUMUR").HeaderText = "Dari"
        dgvAKP.Columns("TANDA").HeaderText = ""
        dgvAKP.Columns("SUMUR").HeaderText = "Sampai"
        dgvAKP.Columns("BB").HeaderText = "Berat Badan"

        dgvAKP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub
    Private Sub dgvAKP_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvAKP.CellFormatting
        For i As Integer = 0 To Me.dgvAKP.Rows.Count - 1
            Me.dgvAKP.Rows(i).Cells("DUMUR").Style.BackColor = Color.DeepSkyBlue
            Me.dgvAKP.Rows(i).Cells("TANDA").Style.BackColor = Color.DeepSkyBlue 'New Font("Calibri", 9, FontStyle.Bold)
            Me.dgvAKP.Rows(i).Cells("SUMUR").Style.BackColor = Color.DeepSkyBlue

            Me.dgvAKP.Rows(i).Cells("BB").Style.BackColor = Color.GreenYellow
        Next
    End Sub
    Private Sub TableLayoutPanel1_CellPaint(sender As Object, e As TableLayoutCellPaintEventArgs) Handles TableLayoutPanel1.CellPaint
        If e.Column = 1 Then
            e.Graphics.FillRectangle(Brushes.DeepSkyBlue, e.CellBounds)
            lblKet1.Text = "UMUR"
        ElseIf e.Column = 2 Then
            e.Graphics.FillRectangle(Brushes.GreenYellow, e.CellBounds)
            lblKet2.Text = "BB"
        End If
    End Sub
End Class