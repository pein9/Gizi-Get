Imports Pein
Imports WeifenLuo.WinFormsUI.Docking
Imports MySql.Data.MySqlClient
Public Class frmDataAhliGizi
    Inherits DockContent

    Private ops As New Pein.AhliGizi
    Private bsData As New BindingSource
    Dim dtAhliGizi As DataTable
    Dim Err As New Pein.BaseExceptionsHandler
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub frmDataAhliGizi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtAhliGizi = ops.DataAhliGizi

        bsData.DataSource = dtAhliGizi

        dgvAhliGizi.DataSource = bsData

        ahliGiziNavigator.BindingSource = bsData

        dgvAhliGizi.Columns("KDAHLIGIZI").HeaderText = "Kode"
        dgvAhliGizi.Columns("NMAHLIGIZI").HeaderText = "Nama Ahli Gizi"

        dgvAhliGizi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

    End Sub
    Protected Sub TambahDataAhli()
        Dim f As New frmAllEditor

        f.Text = "Ahli Gizi Editor"
        f.txtNama.Visible = False
        f.cboNama.Visible = True
        f.lblNama.Text = "Nama Ahli Gizi :"
        f.btnSimpan.Text = "Simpan"
        f.txtKode.Text = FindMaxPlusDatatable(ops.DataAhliGizi, "KDAHLIGIZI", "G", 4)

        Try
            If f.ShowDialog = DialogResult.OK Then
                Dim Identifier As String = f.txtKode.Text
                f.txtKode.Text = Identifier

                If ops.TambahAhliGizi(f.cboNama.Text, Identifier) Then
                    'bsUser.ResetItem()
                    bsData.DataTable.Rows.Add(New Object() {Identifier, f.txtNama.Text})
                    bsData.Locate("KDAHLIGIZI", Identifier.ToString)
                    dtAhliGizi = ops.DataAhliGizi
                    bsData.DataSource = dtAhliGizi
                    bsData.Sort = "KDAHLIGIZI"
                    dgvAhliGizi.DataSource = bsData

                    ahliGiziNavigator.BindingSource = bsData


                Else
                    MsgBox($"Failed to save data: {Err.LastExceptionMessage}", "Peringatan")
                End If
            End If
        Finally
            f.Dispose()
        End Try
    End Sub
    Protected Sub EditDataAhli()
        Dim f As New frmAllEditor
        Dim GiziRow As DataRow = CType(bsData.Current, DataRowView).Row

        f.Text = "Edit Ahli Gizi"
        f.txtNama.Visible = False
        f.cboNama.Visible = True
        f.lblNama.Text = "Nama Ahli Gizi :"
        f.btnSimpan.Text = "Edit"
        f.txtKode.Text = GiziRow.Field(Of String)("KDAHLIGIZI")
        f.cboNama.Text = GiziRow.Field(Of String)("NMAHLIGIZI")
        Try
            If f.ShowDialog = DialogResult.OK Then
                GiziRow.SetField(Of String)("KDAHLIGIZI", f.txtKode.Text)
                GiziRow.SetField(Of String)("NMAHLIGIZI", f.cboNama.Text)

                If ops.UpdateAhliGizi(bsData.CurrentRow) Then
                    bsData.DataTable.AcceptChanges()
                Else
                    If Not Err.IsSuccessFul Then
                        MsgBox($"Update Data Gagal: {Err.LastExceptionMessage}", "Fatal Error")
                    End If

                End If
            Else
                bsData.CancelEdit()
            End If
        Finally
            f.Dispose()
        End Try
    End Sub
    Private Sub naviTambah_Click(sender As Object, e As EventArgs) Handles naviTambah.Click
        TambahDataAhli()
    End Sub
    Private Sub dgvAhliGizi_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAhliGizi.CellContentDoubleClick
        If e.RowIndex <> -1 Then
            EditDataAhli()
        End If
    End Sub
    Private Sub dgvAhliGizi_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAhliGizi.CellDoubleClick
        If e.RowIndex <> -1 Then
            EditDataAhli()
        End If
    End Sub
End Class