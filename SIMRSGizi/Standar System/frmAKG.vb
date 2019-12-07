Imports Pein
Imports WeifenLuo.WinFormsUI.Docking
Imports MySql.Data.MySqlClient
Public Class frmAKG
    Inherits DockContent

    Private ops As New Pein.AKG
    Private bsData As New BindingSource
    Dim dtAKG As DataTable
    Dim Err As New Pein.BaseExceptionsHandler
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub frmAKG_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtAKG = ops.DataAKG

        bsData.DataSource = dtAKG
        bsData.Sort = "KET"
        dgvAKG.DataSource = bsData
        dgvAKG.Columns("KET").HeaderText = "Keterangan"
        dgvAKG.Columns("DUMUR").HeaderText = "Dari"
        dgvAKG.Columns("TANDA").HeaderText = ""
        dgvAKG.Columns("SUMUR").HeaderText = "Sampai"
        dgvAKG.Columns("BB").HeaderText = "Berat Badan"
        dgvAKG.Columns("TB").HeaderText = "Tinggi Badan"
        dgvAKG.Columns("ENERGI").HeaderText = "Energi"
        dgvAKG.Columns("PROTEIN").HeaderText = "Protein"
        dgvAKG.Columns("VITA").HeaderText = "Vitamin A"
        dgvAKG.Columns("VITD").HeaderText = "Vitamin D"
        dgvAKG.Columns("VITE").HeaderText = "Vitamin E"
        dgvAKG.Columns("VITK").HeaderText = "Vitamin K"
        dgvAKG.Columns("TIAMIN").HeaderText = "Tiamin"
        dgvAKG.Columns("RIBOFLAVIN").HeaderText = "Riboflavin"
        dgvAKG.Columns("NIASIN").HeaderText = "Niasin"
        dgvAKG.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub
    Private Sub dgvAKG_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvAKG.CellFormatting
        For i As Integer = 0 To Me.dgvAKG.Rows.Count - 1
            Me.dgvAKG.Rows(i).Cells("DUMUR").Style.BackColor = Color.DeepSkyBlue
            Me.dgvAKG.Rows(i).Cells("TANDA").Style.BackColor = Color.DeepSkyBlue 'New Font("Calibri", 9, FontStyle.Bold)
            Me.dgvAKG.Rows(i).Cells("SUMUR").Style.BackColor = Color.DeepSkyBlue

            Me.dgvAKG.Rows(i).Cells("BB").Style.BackColor = Color.GreenYellow
            Me.dgvAKG.Rows(i).Cells("TB").Style.BackColor = Color.LightYellow 'New Font("Calibri", 9, FontStyle.Bold)
            Me.dgvAKG.Rows(i).Cells("ENERGI").Style.BackColor = Color.LavenderBlush
            Me.dgvAKG.Rows(i).Cells("PROTEIN").Style.BackColor = Color.Salmon

            Me.dgvAKG.Rows(i).Cells("VITA").Style.BackColor = Color.BurlyWood
            Me.dgvAKG.Rows(i).Cells("VITD").Style.BackColor = Color.CadetBlue


            Me.dgvAKG.Rows(i).Cells("VITE").Style.BackColor = Color.Turquoise
            Me.dgvAKG.Rows(i).Cells("VITK").Style.BackColor = Color.Turquoise
            Me.dgvAKG.Rows(i).Cells("TIAMIN").Style.BackColor = Color.Turquoise
            Me.dgvAKG.Rows(i).Cells("RIBOFLAVIN").Style.BackColor = Color.Turquoise
            Me.dgvAKG.Rows(i).Cells("NIASIN").Style.BackColor = Color.Turquoise
        Next
    End Sub
    Private Sub TableLayoutPanel1_CellPaint(sender As Object, e As TableLayoutCellPaintEventArgs) Handles TableLayoutPanel1.CellPaint
        If e.Column = 1 Then
            e.Graphics.FillRectangle(Brushes.DeepSkyBlue, e.CellBounds)
            lblKet1.Text = "UMUR"
        ElseIf e.Column = 2 Then
            e.Graphics.FillRectangle(Brushes.GreenYellow, e.CellBounds)
            lblKet2.Text = "BB"
        ElseIf e.Column = 3 Then
            e.Graphics.FillRectangle(Brushes.LightYellow, e.CellBounds)
            lblKet3.Text = "cm"
        ElseIf e.Column = 4 Then
            e.Graphics.FillRectangle(Brushes.LavenderBlush, e.CellBounds)
            lblket4.Text = "kkal"
        ElseIf e.Column = 5 Then
            e.Graphics.FillRectangle(Brushes.Salmon, e.CellBounds)
            lblKet5.Text = "gr"
        ElseIf e.Column = 6 Then
            e.Graphics.FillRectangle(Brushes.BurlyWood, e.CellBounds)
            lblKet6.Text = "RE"
        ElseIf e.Column = 7 Then
            e.Graphics.FillRectangle(Brushes.CadetBlue, e.CellBounds)
            lblKet7.Text = "ug"
        ElseIf e.Column = 8 Then
            e.Graphics.FillRectangle(Brushes.Turquoise, e.CellBounds)
            lblKet8.Text = "mg"
        End If
    End Sub
End Class