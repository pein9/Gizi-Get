Imports Pein
Imports WeifenLuo.WinFormsUI.Docking
Imports MySql.Data.MySqlClient
Public Class frmKetebalanLemakTubuh
    Inherits DockContent

    Private ops As New Pein.KetLemakTubuh
    Private bsData As New BindingSource
    Dim dtLemakTubuh As DataTable
    Dim Err As New Pein.BaseExceptionsHandler
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub frmKetebalanLemakTubuh_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtLemakTubuh = ops.DataKetebalanLemakTubuh

        bsData.DataSource = dtLemakTubuh
        bsData.Sort = "SEXNAME"
        dgvTebalLemak.DataSource = bsData
        dgvTebalLemak.Columns("SEXNAME").HeaderText = "Jenis Kelamin"
        dgvTebalLemak.Columns("KUMUR").HeaderText = "Umur (Tahun)"
        dgvTebalLemak.Columns("KRENDAH").HeaderText = "Rendah"
        dgvTebalLemak.Columns("KSEDANG").HeaderText = "Sedang"
        dgvTebalLemak.Columns("KTINGGI").HeaderText = "Tinggi"
        dgvTebalLemak.Columns("KSTINGGI").HeaderText = "Sangat Tinggi"


        dgvTebalLemak.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

    End Sub
    Private Sub dgvTebalLemak_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvTebalLemak.CellFormatting
        For i As Integer = 0 To Me.dgvTebalLemak.Rows.Count - 1
            Me.dgvTebalLemak.Rows(i).Cells("KRENDAH").Style.BackColor = Color.GreenYellow
            Me.dgvTebalLemak.Rows(i).Cells("KSEDANG").Style.BackColor = Color.Yellow 'New Font("Calibri", 9, FontStyle.Bold)
            Me.dgvTebalLemak.Rows(i).Cells("KTINGGI").Style.BackColor = Color.BurlyWood

            Me.dgvTebalLemak.Rows(i).Cells("KSTINGGI").Style.BackColor = Color.Salmon
            Me.dgvTebalLemak.Rows(i).Cells("KSTINGGI").Style.ForeColor = Color.White
        Next
    End Sub
End Class