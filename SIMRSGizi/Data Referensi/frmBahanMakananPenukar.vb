Imports Pein
Imports WeifenLuo.WinFormsUI.Docking
Imports MySql.Data.MySqlClient
Public Class frmBahanMakananPenukar
    Inherits DockContent

    Protected gol As New Pein.GolonganBahanMakanan
    Private bsGol As New BindingSource
    Dim dtGol As DataTable
    Dim tError As New BaseExceptionsHandler

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub frmBahanMakananPenukar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvGol.AutoGenerateColumns = False
        dtGol = gol.DataGolonganBahan

        bsGol.DataSource = dtGol

        dgvGol.DataSource = bsGol
        'dgvGol.Columns("KDGOLBAHAN").HeaderText = "Kode"
        'dgvGol.Columns("GOLBAHAN").HeaderText = "Golongan Bahan Makanan"


        'dgvGol.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub
End Class