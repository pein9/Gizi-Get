Imports Pein
Public Class frmViewMakananOlahan
    Private ops As New Pein.MakananOlahanJadi
    Private bsData As New BindingSource
    Dim dtMakananOlahan As DataTable
    Dim Err As New Pein.BaseExceptionsHandler

    Public kdMakananStr, nmMakananStr As String

    Public CariNama As String

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub btnCariNamaOlahan_Click(sender As Object, e As EventArgs) Handles btnCariNamaOlahan.Click
        If TextBox1.Text <> Nothing Then
            bsData.Filter = "nmMakanan Like '" & TextBox1.Text & "%'"
        Else
            bsData.Filter = Nothing
        End If
    End Sub
    Private Sub frmViewMakananOlahan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtMakananOlahan = ops.LihatDataOlahan(kdMakananStr, nmMakananStr)

        bsData.DataSource = dtMakananOlahan

        dgvMakananOlahan.DataSource = bsData

        dgvMakananOlahan.Columns("kdMakanan").HeaderText = "Kode"
        dgvMakananOlahan.Columns("nmMakanan").HeaderText = "Makanan"
        dgvMakananOlahan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

    End Sub
    Protected Sub ExtractNamaOlahan()
        Try

            Dim OlahanRow As DataRow = CType(bsData.Current, DataRowView).Row
            CariNama = OlahanRow.Field(Of String)("nmMakanan")
            If CariNama <> Nothing Then Me.DialogResult = DialogResult.OK
        Finally
            Me.Dispose()

        End Try
    End Sub
    Private Sub dgvMakananOlahan_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMakananOlahan.CellContentDoubleClick
        If e.RowIndex <> -1 Then
            ExtractNamaOlahan()
        End If
    End Sub
    Private Sub dgvMakananOlahan_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMakananOlahan.CellDoubleClick
        If e.RowIndex <> -1 Then
            ExtractNamaOlahan()
        End If
    End Sub
End Class