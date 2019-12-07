Imports Pein
Imports WeifenLuo.WinFormsUI.Docking
Imports MySql.Data.MySqlClient
Public Class frmIMT220
    Inherits DockContent

    Private ops As New Pein.cIMT
    Private bsData As New BindingSource
    Dim dtIMT As DataTable
    Dim Err As New Pein.BaseExceptionsHandler
    Private Sub frmIMT220_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rbPria.Checked = True
    End Sub
    Private Sub rbPria_CheckedChanged(sender As Object, e As EventArgs) Handles rbPria.CheckedChanged
        dtIMT = ops.LihatIMT220(rbPria.Text)

        bsData.DataSource = dtIMT
        dgvIMT220.DataSource = bsData

        dgvIMT220.Columns("DUMUR").HeaderText = "DARI"
        dgvIMT220.Columns("SUmur").HeaderText = "SAMPAI"
        dgvIMT220.Columns("KNormal").HeaderText = "P5 - < P85"
        dgvIMT220.Columns("KKurang").HeaderText = "< P5"
        dgvIMT220.Columns("KGemuk").HeaderText = "> = P85 - P < 95"
        dgvIMT220.Columns("KKGemuk").HeaderText = "> = P95"

        dgvIMT220.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

    End Sub
    Private Sub rbWanita_CheckedChanged(sender As Object, e As EventArgs) Handles rbWanita.CheckedChanged
        dtIMT = ops.LihatIMT220(rbWanita.Text)

        bsData.DataSource = dtIMT
        dgvIMT220.DataSource = bsData
        dgvIMT220.Columns("DUMUR").HeaderText = "DARI"
        dgvIMT220.Columns("SUmur").HeaderText = "SAMPAI"
        dgvIMT220.Columns("KNormal").HeaderText = "P5 - < P85"
        dgvIMT220.Columns("KKurang").HeaderText = "< P5"
        dgvIMT220.Columns("KGemuk").HeaderText = "> = P85 - P < 95"
        dgvIMT220.Columns("KKGemuk").HeaderText = "> = P95"
        dgvIMT220.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

    End Sub
    Private Sub dgvIMT220_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvIMT220.CellFormatting
        For i As Integer = 0 To Me.dgvIMT220.Rows.Count - 1
            Me.dgvIMT220.Rows(i).Cells("DUMUR").Style.BackColor = Color.SkyBlue
            Me.dgvIMT220.Rows(i).Cells("SUmur").Style.BackColor = Color.SkyBlue
            Me.dgvIMT220.Rows(i).Cells("KNormal").Style.BackColor = Color.LawnGreen
            Me.dgvIMT220.Rows(i).Cells("KKurang").Style.BackColor = Color.LightGoldenrodYellow
            Me.dgvIMT220.Rows(i).Cells("KGemuk").Style.BackColor = Color.Lavender
            Me.dgvIMT220.Rows(i).Cells("KKGemuk").Style.BackColor = Color.Red
            Me.dgvIMT220.Rows(i).Cells("KKGemuk").Style.ForeColor = Color.White

        Next
    End Sub
    Private Sub TableLayoutPanel1_CellPaint(sender As Object, e As TableLayoutCellPaintEventArgs) Handles TableLayoutPanel1.CellPaint
        If e.Column = 1 Then
            e.Graphics.FillRectangle(Brushes.SkyBlue, e.CellBounds)
            lblKet1.Text = "UMUR"
        ElseIf e.Column = 2 Then
            e.Graphics.FillRectangle(Brushes.LawnGreen, e.CellBounds)
            lblKet2.Text = "NORMAL"
        ElseIf e.Column = 3 Then
            e.Graphics.FillRectangle(Brushes.LightGoldenrodYellow, e.CellBounds)
            lblKet3.Text = "KURANG"
        ElseIf e.Column = 4 Then
            e.Graphics.FillRectangle(Brushes.Lavender, e.CellBounds)
            lblket4.Text = "GEMUK"
        ElseIf e.Column = 5 Then
            e.Graphics.FillRectangle(Brushes.Red, e.CellBounds)
            lblKet5.Text = "KEGEMUKAN"
            lblKet5.ForeColor = Color.White
        End If
    End Sub
End Class