Imports Pein
Imports WeifenLuo.WinFormsUI.Docking
Imports MySql.Data.MySqlClient
Public Class frmStatusGiziBalita
    Inherits DockContent
    Private ops As New Pein.GiziBalita
    Private bsData As New BindingSource
    Dim dtgiziBalita As DataTable
    Dim Err As New Pein.BaseExceptionsHandler

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub frmStatusGiziBalita_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rbPria.Checked = True
    End Sub
    Private Sub rbPria_CheckedChanged(sender As Object, e As EventArgs) Handles rbPria.CheckedChanged
        dtgiziBalita = ops.LihatStatusGiziBalita(rbPria.Text)

        bsData.DataSource = dtgiziBalita
        dgvBalita.DataSource = bsData
        dgvBalita.Columns("SEXNAME").HeaderText = "Jenis Kelamin"
        dgvBalita.Columns("UMUR").HeaderText = "Bulan"
        dgvBalita.Columns("DBURUK").HeaderText = "< 3 SD"
        dgvBalita.Columns("KKURANG").HeaderText = "< 2 SD - > = 3 SD"
        dgvBalita.Columns("KBAIK").HeaderText = "> = 2 SD > 2 SD"
        dgvBalita.Columns("SLEBIH").HeaderText = "> = 2 SD"


        dgvBalita.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

    End Sub
    Private Sub rbWanita_CheckedChanged(sender As Object, e As EventArgs) Handles rbWanita.CheckedChanged
        dtgiziBalita = ops.LihatStatusGiziBalita(rbWanita.Text)

        bsData.DataSource = dtgiziBalita
        dgvBalita.DataSource = bsData
        dgvBalita.Columns("SEXNAME").HeaderText = "Jenis Kelamin"
        dgvBalita.Columns("UMUR").HeaderText = "Bulan"
        dgvBalita.Columns("DBURUK").HeaderText = "< 3 SD"
        dgvBalita.Columns("KKURANG").HeaderText = "< 2 SD - > = 3 SD"
        dgvBalita.Columns("KBAIK").HeaderText = "> = 2 SD > 2 SD"
        dgvBalita.Columns("SLEBIH").HeaderText = "> = 2 SD"


        dgvBalita.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

    End Sub
    Private Sub dgvBalita_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvBalita.CellFormatting
        For i As Integer = 0 To Me.dgvBalita.Rows.Count - 1
            Me.dgvBalita.Rows(i).Cells("UMUR").Style.BackColor = Color.SkyBlue

            Me.dgvBalita.Rows(i).Cells("DBURUK").Style.BackColor = Color.MediumPurple
            Me.dgvBalita.Rows(i).Cells("DBURUK").Style.ForeColor = Color.WhiteSmoke

            Me.dgvBalita.Rows(i).Cells("KKURANG").Style.BackColor = Color.LightGoldenrodYellow
            Me.dgvBalita.Rows(i).Cells("KBAIK").Style.BackColor = Color.LawnGreen

            Me.dgvBalita.Rows(i).Cells("SLEBIH").Style.BackColor = Color.OrangeRed
            Me.dgvBalita.Rows(i).Cells("SLEBIH").Style.ForeColor = Color.WhiteSmoke
        Next
    End Sub
    Private Sub TableLayoutPanel1_CellPaint(sender As Object, e As TableLayoutCellPaintEventArgs) Handles TableLayoutPanel1.CellPaint
        If e.Column = 1 Then
            e.Graphics.FillRectangle(Brushes.SkyBlue, e.CellBounds)
            lblKet1.Text = "UMUR"
        ElseIf e.Column = 2 Then
            e.Graphics.FillRectangle(Brushes.MediumPurple, e.CellBounds)
            lblKet2.Text = "Buruk [kg]"
            lblKet2.ForeColor = Color.White
        ElseIf e.Column = 3 Then
            e.Graphics.FillRectangle(Brushes.LightGoldenrodYellow, e.CellBounds)
            lblKet3.Text = "Kurang [Kg]"
        ElseIf e.Column = 4 Then
            e.Graphics.FillRectangle(Brushes.LawnGreen, e.CellBounds)
            lblket4.Text = "Baik [Kg]"
        ElseIf e.Column = 5 Then
            e.Graphics.FillRectangle(Brushes.OrangeRed, e.CellBounds)
            lblKet5.Text = "Lebih [Kg]"
            lblKet5.ForeColor = Color.White
        End If
    End Sub
End Class