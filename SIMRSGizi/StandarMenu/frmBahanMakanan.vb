Imports Pein
Imports WeifenLuo.WinFormsUI.Docking
Imports MySql.Data.MySqlClient
Imports System.Reflection
Public Class frmBahanMakanan
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

    Private Shared Sub SetDoubleBuffer(ByVal ctl As Control, ByVal DoubleBuffered As Boolean)
        GetType(Control).InvokeMember("DoubleBuffered", BindingFlags.NonPublic Or BindingFlags.Instance Or BindingFlags.SetProperty, Nothing, ctl, New Object() {DoubleBuffered})
    End Sub
    Private Sub frmBahanMakanan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtBahanMakan = ops.DataBahanMakanan

        If Not String.IsNullOrWhiteSpace(Pein.con) Then
            For Each col As DataColumn In dgvBahanMakanan.Columns
                col.[ReadOnly] = False
            Next

            txtCariNama.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            txtCariNama.AutoCompleteSource = AutoCompleteSource.CustomSource
            txtCariNama.AutoCompleteCustomSource = ops.LoadAutoNama


            bsData.DataSource = dtBahanMakan
            bsData.Sort = "NAMABAHAN"

            dgvBahanMakanan.DataSource = bsData

            bmNavigator.BindingSource = bsData


            dgvBahanMakanan.Columns("NAMABAHAN").HeaderText = "Nama Bahan"
            dgvBahanMakanan.Columns("NamaJenis").HeaderText = "Jenis"
            dgvBahanMakanan.Columns("SATUANBELI").HeaderText = "Satuan Beli"
            dgvBahanMakanan.Columns("KETERANGAN").HeaderText = "Keterangan"
            dgvBahanMakanan.Columns("STOK").HeaderText = "Stok"
            dgvBahanMakanan.Columns("STOKMIN").HeaderText = "Batas Stock"

            dgvBahanMakanan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            SetDoubleBuffer(dgvBahanMakanan, True)
        End If
    End Sub
    Private Sub txtCariNama_TextChanged(sender As Object, e As EventArgs) Handles txtCariNama.TextChanged
        If txtCariNama.Text = Nothing Then bsData.Filter = Nothing
    End Sub
    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        If txtCariNama.Text <> Nothing Then bsData.Filter = "NAMABAHAN = '" & txtCariNama.Text & "'"
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        TambahData()
    End Sub
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        UpdateDataBahan()
    End Sub
#Region "CALL CRU QUERY"
    Protected Sub UpdateDataBahan()
        Dim f As New frmBahanMakananEditor
        Dim BahanRow As DataRow = CType(bsData.Current, DataRowView).Row
        f.txtKodeBahan.Text = BahanRow.Field(Of String)("KDBAHAN")
        f.txtKodeKelompok.Text = BahanRow.Field(Of String)("KDKELOMPOKBAHAN")
        f.cboGol.Text = BahanRow.Field(Of String)("GOLBAHAN")
        f.txtKodeGolongan.Text = BahanRow.Field(Of String)("KDGOLBAHAN")
        f.txtKodeJenis.Text = BahanRow.Field(Of Int64)("kdJenisMakanan")
        f.cboNamaJenis.Text = BahanRow.Field(Of String)("NamaJenis")
        f.txtNamaBahan.Text = BahanRow.Field(Of String)("NAMABAHAN")
        f.txtSatuanBeli.Text = BahanRow.Field(Of String)("SATUANBELI")
        f.txtKeterangan.Text = BahanRow.Field(Of String)("KETERANGAN")
        f.txtStok.Text = BahanRow.Field(Of Integer)("STOK")
        f.txtReorder.Text = BahanRow.Field(Of Integer)("STOKMIN")
        f.txtEnergi.Text = Convert.ToString(BahanRow.Field(Of Integer)("ENERGI"))
        f.txtHewani.Text = Convert.ToString(BahanRow.Field(Of Integer)("PROTEINHEWANI"))
        f.txtNabati.Text = Convert.ToString(BahanRow.Field(Of Integer)("PROTEINNABATI"))
        f.txtLemak.Text = Convert.ToString(BahanRow.Field(Of Integer)("LEMAK"))
        f.txtHA.Text = Convert.ToString(BahanRow.Field(Of Integer)("HA"))
        f.txtKalium.Text = Convert.ToString(BahanRow.Field(Of Integer)("KALSIUM"))
        f.txtFosfor.Text = Convert.ToString(BahanRow.Field(Of Integer)("FOSFOR"))
        f.txtFE.Text = Convert.ToString(BahanRow.Field(Of Integer)("FE"))
        f.txtVITA.Text = Convert.ToString(BahanRow.Field(Of Integer)("VITA"))
        f.txtVitB.Text = Convert.ToString(BahanRow.Field(Of Integer)("VITB"))
        f.txtVitC.Text = Convert.ToString(BahanRow.Field(Of Integer)("VITC"))
        f.txtNatrium.Text = Convert.ToString(BahanRow.Field(Of Integer)("NATRIUM"))
        f.txtKalium.Text = Convert.ToString(BahanRow.Field(Of Integer)("KALIUM"))
        f.txtKholesterol.Text = Convert.ToString(BahanRow.Field(Of Integer)("KHOLESTEROL"))
        f.txtAIR.Text = Convert.ToString(BahanRow.Field(Of Integer)("AIR"))
        f.txtVITD.Text = Convert.ToString(BahanRow.Field(Of Integer)("VITD"))
        f.txtVITE.Text = Convert.ToString(BahanRow.Field(Of Integer)("VITE"))
        f.txtVITK.Text = Convert.ToString(BahanRow.Field(Of Integer)("VITK"))
        f.txtTiamin.Text = Convert.ToString(BahanRow.Field(Of Integer)("TIAMIN"))
        f.txtRiboflavin.Text = Convert.ToString(BahanRow.Field(Of Integer)("RIBOFLAVIN"))
        f.txtNiasin.Text = Convert.ToString(BahanRow.Field(Of Integer)("NIASIN"))
        f.txtB12.Text = Convert.ToString(BahanRow.Field(Of Integer)("VITB12"))
        f.txtFolat.Text = Convert.ToString(BahanRow.Field(Of Integer)("ASAMFOLAT"))
        f.txtPiridoksin.Text = Convert.ToString(BahanRow.Field(Of Integer)("PIRIDOKSIN"))
        f.txtSeng.Text = Convert.ToString(BahanRow.Field(Of Integer)("SENG"))
        f.txtLodium.Text = Convert.ToString(BahanRow.Field(Of Integer)("LODIUM"))
        f.txtSelenium.Text = Convert.ToString(BahanRow.Field(Of Integer)("SELENIUM"))
        f.txtB1.Text = Convert.ToString(BahanRow.Field(Of Integer)("VITB1"))
        f.txtBDD.Text = Convert.ToString(BahanRow.Field(Of Integer)("BDD"))
        f.btnSimpan.Text = "Edit"

        Try
            If f.ShowDialog = DialogResult.OK Then
                BahanRow.SetField(Of String)("KDKELOMPOKBAHAN", f.txtKodeKelompok.Text)
                'BahanRow.SetField(Of String)("KELOMPOKBAHAN", f.cboKelompokBahan.Text)
                BahanRow.SetField(Of String)("KDGOLBAHAN", f.txtKodeGolongan.Text)
                BahanRow.SetField(Of String)("kdJenisMakanan", f.txtKodeJenis.Text)
                'BahanRow.SetField(Of String)("NamaJenis", f.cboNamaJenis.Text)
                BahanRow.SetField(Of String)("NAMABAHAN", f.txtNamaBahan.Text)
                BahanRow.SetField(Of String)("SATUANBELI", f.txtSatuanBeli.Text)
                BahanRow.SetField(Of String)("KETERANGAN", f.txtKeterangan.Text)
                BahanRow.SetField(Of String)("STOK", f.txtStok.Text)
                BahanRow.SetField(Of String)("STOKMIN", f.txtReorder.Text)
                BahanRow.SetField(Of String)("ENERGI", f.txtEnergi.Text)
                BahanRow.SetField(Of String)("PROTEINHEWANI", f.txtHewani.Text)
                BahanRow.SetField(Of String)("PROTEINNABATI", f.txtNabati.Text)
                BahanRow.SetField(Of String)("LEMAK", f.txtLemak.Text)
                BahanRow.SetField(Of String)("HA", f.txtHA.Text)
                BahanRow.SetField(Of String)("KALSIUM", f.txtKalsium.Text)
                BahanRow.SetField(Of String)("FOSFOR", f.txtFosfor.Text)
                BahanRow.SetField(Of String)("FE", f.txtFE.Text)
                BahanRow.SetField(Of String)("VITA", f.txtVITA.Text)
                BahanRow.SetField(Of String)("VITB", f.txtVitB.Text)
                BahanRow.SetField(Of String)("VITC", f.txtVitC.Text)
                BahanRow.SetField(Of String)("NATRIUM", f.txtNatrium.Text)
                BahanRow.SetField(Of String)("KALIUM", f.txtKalium.Text)
                BahanRow.SetField(Of String)("KHOLESTEROL", f.txtKholesterol.Text)
                BahanRow.SetField(Of String)("AIR", f.txtAIR.Text)
                BahanRow.SetField(Of String)("VITD", f.txtVITD.Text)
                BahanRow.SetField(Of String)("VITE", f.txtVITE.Text)
                BahanRow.SetField(Of String)("VITK", f.txtVITK.Text)
                BahanRow.SetField(Of String)("TIAMIN", f.txtTiamin.Text)
                BahanRow.SetField(Of String)("RIBOFLAVIN", f.txtRiboflavin.Text)
                BahanRow.SetField(Of String)("NIASIN", f.txtNiasin.Text)
                BahanRow.SetField(Of String)("VITB12", f.txtB12.Text)
                BahanRow.SetField(Of String)("ASAMFOLAT", f.txtFolat.Text)
                BahanRow.SetField(Of String)("PIRIDOKSIN", f.txtPiridoksin.Text)
                BahanRow.SetField(Of String)("SENG", f.txtSeng.Text)
                BahanRow.SetField(Of String)("LODIUM", f.txtLodium.Text)
                BahanRow.SetField(Of String)("SELENIUM", f.txtSelenium.Text)
                BahanRow.SetField(Of String)("VITB1", f.txtB1.Text)
                BahanRow.SetField(Of String)("BDD", f.txtBDD.Text)
                If ops.UpdateBahanMakanan(bsData.CurrentRow) Then
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
    Protected Sub TambahData()
        Dim f As New frmBahanMakananEditor
        f.txtKodeBahan.Text = FindMaxPlusDatatable(ops.DataBahanMakanan, "KDBAHAN", "M", 5)
        f.btnSimpan.Text = "Simpan"

        Try
            If f.ShowDialog = DialogResult.Yes Then
                Dim Identifier As String = f.txtKodeBahan.Text
                f.txtKodeBahan.Text = Identifier

                If ops.TambahBahanMakanan(f.txtKodeKelompok.Text, f.txtKodeGolongan.Text, f.txtKodeJenis.Text,
                                          f.txtNamaBahan.Text, Val(f.txtEnergi.Text),
                                          Val(f.txtHewani.Text), Val(f.txtNabati.Text),
                                          Val(f.txtLemak.Text), Val(f.txtHA.Text),
                                          Val(f.txtKalsium.Text), Val(f.txtFosfor.Text),
                                          Val(f.txtFE.Text), Val(f.txtVITA.Text),
                                          Val(f.txtVitB.Text), Val(f.txtVitC.Text),
                                          Val(f.txtNatrium.Text), Val(f.txtKalium.Text),
                                          Val(f.txtKholesterol.Text), Val(f.txtAIR.Text),
                                          Val(f.txtVITD.Text), Val(f.txtVITE.Text),
                                          Val(f.txtVITK.Text), Val(f.txtTiamin.Text),
                                          Val(f.txtRiboflavin.Text), Val(f.txtNiasin.Text),
                                          Val(f.txtB12.Text), Val(f.txtFolat.Text),
                                          Val(f.txtPiridoksin.Text), Val(f.txtSeng.Text),
                                          Val(f.txtLodium.Text), Val(f.txtSelenium.Text),
                                          Val(f.txtB1.Text), Val(f.txtBDD.Text),
                                          f.txtSatuanBeli.Text, f.txtKeterangan.Text, Val(f.txtStok.Text),
                                          Val(f.txtReorder.Text), Identifier) Then
                    'bsUser.ResetItem()
                    bsData.DataTable.Rows.Add(New Object() {Identifier, f.txtKodeKelompok.Text, f.txtKodeGolongan.Text,
                    f.txtKodeJenis.Text, f.txtNamaBahan.Text,
                      f.txtKeterangan.Text, Val(f.txtStok.Text), Val(f.txtReorder.Text)})
                    bsData.Locate("KDBAHAN", Identifier.ToString)
                    dtBahanMakan = ops.DataBahanMakanan
                    bsData.DataSource = dtBahanMakan
                    bsData.Sort = "NAMABAHAN"
                    dgvBahanMakanan.DataSource = bsData

                    bmNavigator.BindingSource = bsData

                    txtCariNama.AutoCompleteCustomSource = ops.LoadAutoNama
                Else
                    MsgBox($"Failed to save data: {Err.LastExceptionMessage}", "Peringatan")
                End If
            End If
        Finally
            f.Dispose()
        End Try
    End Sub
#End Region
    Private Sub dgvBahanMakanan_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBahanMakanan.CellContentDoubleClick
        If e.RowIndex <> -1 Then
            UpdateDataBahan()
        End If
    End Sub

    Private Sub dgvBahanMakanan_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBahanMakanan.CellDoubleClick
        If e.RowIndex <> -1 Then
            UpdateDataBahan()
        End If
    End Sub

End Class