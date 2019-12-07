Imports Pein
Imports WeifenLuo.WinFormsUI.Docking
Imports MySql.Data.MySqlClient
Public Class frmKategoryUmur
    Inherits DockContent

    Private ops As New Pein.KatUmur
    Private bsData As New BindingSource
    Dim dtKatUmur As DataTable
    Dim Err As New Pein.BaseExceptionsHandler

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub frmKategoryUmur_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtKatUmur = ops.DataKategoryUmur

        bsData.DataSource = dtKatUmur
        bsData.Sort = "KATEGORIID"
        dgvAKG.DataSource = bsData
        dgvAKG.Columns("KATEGORIID").HeaderText = "Kategori"
        dgvAKG.Columns("KET").HeaderText = "Keterangan"
        dgvAKG.Columns("DUMURTHN").HeaderText = "Tahun"
        dgvAKG.Columns("DUMURBLN").HeaderText = "Bulan"
        dgvAKG.Columns("SUMURTHN").HeaderText = "Tahun"
        dgvAKG.Columns("SUMURBLN").HeaderText = "Bulan"
        For j As Integer = 0 To Me.dgvAKG.ColumnCount - 1
            Me.dgvAKG.Columns(j).Width = 45
        Next
        dgvAKG.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        Me.dgvAKG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvAKG.ColumnHeadersHeight = Me.dgvAKG.ColumnHeadersHeight * 2
        Me.dgvAKG.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter

    End Sub
    Private Sub dgvAKG_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles dgvAKG.CellPainting
        If e.RowIndex = -1 AndAlso e.ColumnIndex > -1 Then
            Dim r2 As Rectangle = e.CellBounds
            r2.Y += e.CellBounds.Height / 2
            r2.Height = e.CellBounds.Height / 2
            e.PaintBackground(r2, True)
            e.PaintContent(r2)
            e.Handled = True
        End If
    End Sub

    Private Sub dgvAKG_ColumnWidthChanged(sender As Object, e As DataGridViewColumnEventArgs) Handles dgvAKG.ColumnWidthChanged
        Dim rtHeader As Rectangle = Me.dgvAKG.DisplayRectangle
        rtHeader.Height = Me.dgvAKG.ColumnHeadersHeight / 2
        Me.dgvAKG.Invalidate(rtHeader)
    End Sub

    Private Sub dgvAKG_Scroll(sender As Object, e As ScrollEventArgs) Handles dgvAKG.Scroll
        Dim rtHeader As Rectangle = Me.dgvAKG.DisplayRectangle
        rtHeader.Height = Me.dgvAKG.ColumnHeadersHeight / 2
        Me.dgvAKG.Invalidate(rtHeader)
    End Sub

    Private Sub dgvAKG_Paint(sender As Object, e As PaintEventArgs) Handles dgvAKG.Paint
        ' Data for the "merged" header cells 
        Dim monthes As String() = {"Kelompok Pasien", "Dari Umur", "Sampai"}
        For j As Integer = 0 To Me.dgvAKG.ColumnCount - 1 Step 2
            ' Get the column header cell bounds 
            Dim r1 As Rectangle = Me.dgvAKG.GetCellDisplayRectangle(j, -1, True)


            r1.X += 1
            r1.Y += 1
            r1.Width = r1.Width * 2 - 2
            r1.Height = r1.Height / 2 - 2


            Using br As SolidBrush = New SolidBrush(Color.OrangeRed)
                e.Graphics.FillRectangle(br, r1)
            End Using


            Using p As Pen = New Pen(SystemColors.InactiveBorder)
                e.Graphics.DrawLine(p, r1.X, r1.Bottom, r1.Right, r1.Bottom)
            End Using


            Using format As StringFormat = New StringFormat()
                Using br As SolidBrush = New SolidBrush(Color.White)
                    format.Alignment = StringAlignment.Center
                    format.LineAlignment = StringAlignment.Center
                    e.Graphics.DrawString(monthes(j / 2), Me.dgvAKG.ColumnHeadersDefaultCellStyle.Font,
                                             br, r1, format)
                End Using
            End Using
        Next
    End Sub

    Private Sub dgvAKG_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvAKG.CellFormatting
        For i As Integer = 0 To Me.dgvAKG.Rows.Count - 1
            Me.dgvAKG.Rows(i).Cells("KET").Style.BackColor = Color.Gold
            'Me.dgvAKG.Rows(i).Cells("KET").Style.ForeColor = Color.WhiteSmoke
        Next
    End Sub
End Class