Imports Pein
Imports WeifenLuo.WinFormsUI.Docking
Imports MySql.Data.MySqlClient
Public Class frmTinggiLutut
    Inherits DockContent

    Private ops As New Pein.TinggiLutut
    Private bsData As New BindingSource
    Dim dtTinggiLutut As DataTable
    Dim Err As New Pein.BaseExceptionsHandler

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub frmTinggiLutut_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtTinggiLutut = ops.DataTinggiLutut

        If Not String.IsNullOrWhiteSpace(Pein.con) Then
            For Each col As DataColumn In dgvTinggiLutut.Columns
                col.[ReadOnly] = False
            Next


            bsData.DataSource = dtTinggiLutut

            dgvTinggiLutut.DataSource = bsData

            dgvTinggiLutut.Columns("SEXNAME").HeaderText = "JENIS KELAMIN"



            dgvTinggiLutut.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            ' dgvNutrisi.ReadOnly = True
        End If
    End Sub

    Private Sub dgvTinggiLutut_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvTinggiLutut.CellFormatting
        For i As Integer = 0 To Me.dgvTinggiLutut.Rows.Count - 1
            Me.dgvTinggiLutut.Rows(i).Cells("SEXNAME").Style.Font = New Font("Calibri", 9, FontStyle.Bold)
            Me.dgvTinggiLutut.Rows(i).Cells("FORMULA").Style.Font = New Font("Calibri", 9, FontStyle.Bold)
            Me.dgvTinggiLutut.Rows(i).Cells("SEXNAME").Style.BackColor = Color.LawnGreen
        Next
    End Sub
End Class