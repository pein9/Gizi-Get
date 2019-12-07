Imports Pein
Imports WeifenLuo.WinFormsUI.Docking
Imports MySql.Data.MySqlClient
Public Class frmDiet
    Inherits DockContent

    Protected ops As New Pein.Diet
    Protected kelDiet As New Pein.KelompokDiet

    Private bsData, bsKelDiet As New BindingSource

    Dim dtDiet, dtKelDiet As DataTable

    Dim tError As New BaseExceptionsHandler
    Dim intSeconds As Int64

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub frmMenuDiet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvDiet.AutoGenerateColumns = False

        dtDiet = ops.DataDiet
        dtKelDiet = kelDiet.DataKelompokDiet

        'Combo Kelompok Diet

        KelompokDiet.DisplayMember = "kelDiet"
        KelompokDiet.DataSource = dtKelDiet
        KelompokDiet.DataPropertyName = "kdKelDiet"
        KelompokDiet.ValueMember = "kdKelDiet"

        AddHandler dtDiet.RowChanged, AddressOf RowChanged


        bsData.DataSource = dtDiet
        bsData.Sort = "kdDiet"

        dgvDiet.DataSource = bsData

        dietNavigator.BindingSource = bsData

        dgvDiet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill



    End Sub
    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        TambahData()
    End Sub
    Private Sub TableLayoutPanel1_CellPaint(sender As Object, e As TableLayoutCellPaintEventArgs) Handles TableLayoutPanel1.CellPaint
        If e.Column = 1 Then 'AndAlso e.Row = 1 
            e.Graphics.FillRectangle(Brushes.DarkGray, e.CellBounds)
        End If
    End Sub
    Private Sub RowChanged(sender As Object, e As DataRowChangeEventArgs)
        Dim rowOlahan As DataRow = CType(bsData.Current, DataRowView).Row

        If e.Action = DataRowAction.Change Then

            If Not ops.UpdateDietByIdentifier(e.Row) Then
                MsgBox("Update data diet gagal", MsgBoxStyle.Critical, "Fatal Error")
            End If
        End If
    End Sub

#Region "CRUD"
    Protected Sub TambahData()
        Dim f As New frmDietEditor
        Try
            If f.ShowDialog = DialogResult.Yes Then
                Dim Identifier As String = f.lblKodeDiet.Text
                f.lblKodeDiet.Text = Identifier

                If ops.TambahDiet(f.txtKodeKelompok.Text, UCase(f.txtnmDiet.Text), f.txtKeterangan.Text, False,
                                  Convert.ToBoolean(f.chkMenuUtama.Checked), Convert.ToBoolean(f.chkExtra.Checked),
                                  Convert.ToBoolean(f.chkSnackSore.Checked), Convert.ToBoolean(f.chkSnackPagi.Checked),
                                  Identifier) Then
                    'bsUser.ResetItem()
                    bsData.DataTable.Rows.Add(New Object() {Identifier, f.txtnmDiet.Text, f.txtKeterangan.Text, f.txtKodeKelompok.Text, False,
                                                            Convert.ToBoolean(f.chkMenuUtama.Checked), Convert.ToBoolean(f.chkExtra.Checked),
                                                            Convert.ToBoolean(f.chkSnackSore.Checked), Convert.ToBoolean(f.chkSnackPagi.Checked)})
                    bsData.Locate("KDDIET", Identifier.ToString)
                    dtDiet = ops.DataDiet
                    bsData.DataSource = dtDiet
                    'bsData.Sort = "NAMABAHAN"
                    dgvDiet.DataSource = bsData

                    dietNavigator.BindingSource = bsData

                    ' txtCariNama.AutoCompleteCustomSource = ops.LoadAutoNama
                Else
                    MsgBox($"Failed to save data: {tError.LastExceptionMessage}", "Peringatan")
                End If
            End If
        Finally
            f.Dispose()
        End Try
    End Sub
#End Region
End Class