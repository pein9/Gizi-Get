Imports Pein
Imports WeifenLuo.WinFormsUI.Docking
Imports MySql.Data.MySqlClient
Public Class frmEnergiBasal
    Inherits DockContent

    Private ops As New Pein.EnergiBasal
    Private bsData As New BindingSource
    Dim dtEnergiBasal As DataTable
    Dim Err As New Pein.BaseExceptionsHandler

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub frmEnergiBasal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtEnergiBasal = ops.DataFormulaEnergiBasak

        If Not String.IsNullOrWhiteSpace(Pein.con) Then
            For Each col As DataColumn In dgvEnergiBasal.Columns
                col.[ReadOnly] = False
            Next


            bsData.DataSource = dtEnergiBasal

            dgvEnergiBasal.DataSource = bsData

            dgvEnergiBasal.Columns("SEXNAME").HeaderText = "JENIS KELAMIN"



            dgvEnergiBasal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            ' dgvNutrisi.ReadOnly = True
        End If
    End Sub
    Private Sub dgvEnergiBasal_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvEnergiBasal.CellFormatting
        For i As Integer = 0 To Me.dgvEnergiBasal.Rows.Count - 1
            Me.dgvEnergiBasal.Rows(i).Cells("SEXNAME").Style.Font = New Font("Calibri", 9, FontStyle.Bold)
            Me.dgvEnergiBasal.Rows(i).Cells("FORMULA").Style.Font = New Font("Calibri", 9, FontStyle.Bold)
            Me.dgvEnergiBasal.Rows(i).Cells("SEXNAME").Style.BackColor = Color.LawnGreen
        Next
    End Sub


End Class