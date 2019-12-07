Imports Pein
Imports WeifenLuo.WinFormsUI.Docking
Imports MySql.Data.MySqlClient
Public Class frmNutrisiBahanMakanan
    Inherits DockContent
    Private ops As New Pein.BahanMakan
    Private bsData As New BindingSource
    Dim dtBahanMakan As DataTable
    Dim Err As New Pein.BaseExceptionsHandler

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub frmNutrisiBahanMakanan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtBahanMakan = ops.DataNutrisi

        If Not String.IsNullOrWhiteSpace(Pein.con) Then
            For Each col As DataColumn In dgvNutrisi.Columns
                col.[ReadOnly] = False
            Next


            bsData.DataSource = dtBahanMakan

            dgvNutrisi.DataSource = bsData

            dgvNutrisi.Columns("NAMABAHAN").HeaderText = "NAMA BAHAN MAKANAN"
            dgvNutrisi.Columns("KELOMPOKBAHAN").HeaderText = "KELOMPOK"
            dgvNutrisi.Columns("GOLBAHAN").HeaderText = "GOLONGAN"
            dgvNutrisi.Columns("ENERGI").HeaderText = "ENERGI"
            dgvNutrisi.Columns("PROTEINHEWANI").HeaderText = "PROTEIN HEWANI"
            dgvNutrisi.Columns("PROTEINNABATI").HeaderText = "PROTEIN NABATI"
            dgvNutrisi.Columns("LEMAK").HeaderText = "LEMAK"
            dgvNutrisi.Columns("HA").HeaderText = "HA"
            dgvNutrisi.Columns("KALSIUM").HeaderText = "KALSIUM"
            dgvNutrisi.Columns("FOSFOR").HeaderText = "FOSFOR"
            dgvNutrisi.Columns("FE").HeaderText = "FE"
            dgvNutrisi.Columns("NATRIUM").HeaderText = "NATRIUM"
            dgvNutrisi.Columns("KALIUM").HeaderText = "KALIUM"
            dgvNutrisi.Columns("KHOLESTEROL").HeaderText = "KHOLESTEROL"
            dgvNutrisi.Columns("AIR").HeaderText = "AIR"
            dgvNutrisi.Columns("TIAMIN").HeaderText = "TIAMIN"
            dgvNutrisi.Columns("RIBOFLAVIN").HeaderText = "RIBOFLAVIN"
            dgvNutrisi.Columns("NIASIN").HeaderText = "NIASIN"
            dgvNutrisi.Columns("ASAMFOLAT").HeaderText = "ASAMFOLAT"
            dgvNutrisi.Columns("PIRIDOKSIN").HeaderText = "PIRIDOKSIN"
            dgvNutrisi.Columns("SENG").HeaderText = "SENG"
            dgvNutrisi.Columns("LODIUM").HeaderText = "LODIUM"
            dgvNutrisi.Columns("SELENIUM").HeaderText = "SELENIUM"
            dgvNutrisi.Columns("BDD").HeaderText = "BDD"
            dgvNutrisi.Columns("VITA").HeaderText = "VITA"
            dgvNutrisi.Columns("VITB").HeaderText = "VITB"
            dgvNutrisi.Columns("VITC").HeaderText = "VITC"
            dgvNutrisi.Columns("VITD").HeaderText = "VITD"
            dgvNutrisi.Columns("VITE").HeaderText = "VITE"
            dgvNutrisi.Columns("VITK").HeaderText = "VITK"
            dgvNutrisi.Columns("VITB12").HeaderText = "VITB12"
            dgvNutrisi.Columns("VITB1").HeaderText = "VITB1"


            dgvNutrisi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            ' dgvNutrisi.ReadOnly = True
        End If
    End Sub
End Class