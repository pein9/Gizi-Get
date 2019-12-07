Imports Pein
Imports WeifenLuo.WinFormsUI.Docking
Imports MySql.Data.MySqlClient
Public Class frmKecukupanEnergi
    Inherits DockContent

    Private ops As New Pein.CukupEnergi
    Private bsData As New BindingSource
    Dim dtCukupEnergi As DataTable
    Dim Err As New Pein.BaseExceptionsHandler

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub frmKecukupanEnergi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtCukupEnergi = ops.DataCukupEnergi

        If Not String.IsNullOrWhiteSpace(Pein.con) Then
            For Each col As DataColumn In dgvCukupEnergi.Columns
                col.[ReadOnly] = False
            Next


            bsData.DataSource = dtCukupEnergi

            dgvCukupEnergi.DataSource = bsData

            dgvCukupEnergi.Columns("SEXNAME").HeaderText = "JENIS KELAMIN"
            dgvCukupEnergi.Columns("BAKTIVITAS").HeaderText = "AKTIFITAS"



            dgvCukupEnergi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            ' dgvNutrisi.ReadOnly = True
        End If
    End Sub
    Private Sub dgvCukupEnergi_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvCukupEnergi.CellFormatting
        For i As Integer = 0 To Me.dgvCukupEnergi.Rows.Count - 1
            Me.dgvCukupEnergi.Rows(i).Cells("SEXNAME").Style.Font = New Font("Calibri", 9, FontStyle.Bold)
            Me.dgvCukupEnergi.Rows(i).Cells("FORMULA").Style.Font = New Font("Calibri", 9, FontStyle.Bold)
            Me.dgvCukupEnergi.Rows(i).Cells("SEXNAME").Style.BackColor = Color.LawnGreen
        Next
    End Sub
End Class