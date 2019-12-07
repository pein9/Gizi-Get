Imports Pein
Imports WeifenLuo.WinFormsUI.Docking
Imports MySql.Data.MySqlClient
Public Class frmJenisDiet
    Inherits DockContent

    Private ops As New Pein.JenisDiet
    Private bsData As New BindingSource
    Dim dtJenisDiet As DataTable
    Dim Err As New Pein.BaseExceptionsHandler

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub frmJenisDiet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtJenisDiet = ops.DataJenisDiet

        If Not String.IsNullOrWhiteSpace(Pein.con) Then
            For Each col As DataColumn In dgvJenisDiet.Columns
                col.[ReadOnly] = False
            Next


            bsData.DataSource = dtJenisDiet

            dgvJenisDiet.DataSource = bsData

            dgvJenisDiet.Columns("JENISDIETID").HeaderText = "JENIS DIET"
            dgvJenisDiet.Columns("KETDIET").HeaderText = "KETERANGAN"
            dgvJenisDiet.Columns("CATATAN").HeaderText = "CATATAN"


            dgvJenisDiet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            ' dgvNutrisi.ReadOnly = True
        End If
    End Sub
End Class