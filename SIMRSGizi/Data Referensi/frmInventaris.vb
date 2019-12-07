Imports WeifenLuo.WinFormsUI.Docking
Public Class frmInventaris
    Inherits DockContent

    Private ops As New Pein.Inventaris
    Private tkelas As New Pein.Kelas
    Private bsData, bsKelas As New BindingSource
    Dim dtInventaris, dtKelas As DataTable
    Dim Err As New Pein.BaseExceptionsHandler
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub frmInventaris_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtInventaris = ops.DataInventaris

        bsData.DataSource = dtInventaris

        dgvInventaris.DataSource = bsData

        'inventarisNavigator.BindingSource = bsData

        dgvInventaris.Columns("KDALATMAKAN").HeaderText = "Kode"
        dgvInventaris.Columns("ALATMAKAN").HeaderText = "Nama Alat Makan"
        dgvInventaris.Columns("kelas").HeaderText = "Kelas"
        dgvInventaris.Columns("JUMLAHALAT").HeaderText = "Jumlah [Stok]"
        dgvInventaris.Columns("SATUANALAT").HeaderText = "Satuan"

        dgvInventaris.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        'kelas
        dtKelas = tkelas.DataKelas

        bsKelas.DataSource = dtKelas

        dgvKelas.DataSource = bsKelas

        'inventarisNavigator.BindingSource = bsData

        dgvKelas.Columns("kdkelas").HeaderText = "Kode"
        dgvKelas.Columns("kelas").HeaderText = "Nama Kelas"

        dgvKelas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill


    End Sub
#Region "Deteksi Keterangan Tabel"
    Protected Sub AktifasiKetTabelInventaris()
        allNavigator.BindingSource = bsData
        lblKeteranganData.Text = "Data inventaris ke-"
        naviTambah.Visible = True
        'btnTambah.Text = "Tambah data Makanan Olahan"
        'lblKetNavi.ForeColor = Color.Red
        'lblKetNavi.Text = "**Ket : Anda bisa langsung melakukan update/edit data dalam tabel"
        'lblKetNavi.Visible = True
        'separatorCari.Visible = True
        'txtCariOlahan.Visible = True
        'lblCariOlahan.Visible = True
        dgvKelas.CurrentCell.Selected = Nothing
        'txtCariOlahan.AutoCompleteCustomSource = ops.LoadAutoNamaWithoutHeader
        ' ToolTip1.Show("> Klik 2x data dalam tabel untuk update/edit data", dgvInventaris, 3000)

        'ExtractKeKomposisi()
    End Sub

    Protected Sub AktifasiKetTabelKelas()
        allNavigator.BindingSource = bsKelas
        lblKeteranganData.Text = "Data kelas ke-"
        naviTambah.Visible = True
        'btnTambah.Text = "Tambah data Makanan Olahan"
        'lblKetNavi.ForeColor = Color.Red
        'lblKetNavi.Text = "**Ket : Anda bisa langsung melakukan update/edit data dalam tabel"
        'lblKetNavi.Visible = True
        'separatorCari.Visible = True
        'txtCariOlahan.Visible = True
        'lblCariOlahan.Visible = True
        dgvInventaris.CurrentCell.Selected = Nothing
        'txtCariOlahan.AutoCompleteCustomSource = ops.LoadAutoNamaWithoutHeader
        ' ToolTip1.Show("> Klik 2x data dalam tabel untuk update/edit data", dgvKelas, 3000)

        'ExtractKeKomposisi()
    End Sub
#End Region
#Region "CRUD"
#Region "Inventaris"
    Protected Sub TambahDataInventaris()
        Dim f As New frmInventarisEditor


        f.btnSimpan.Text = "Simpan"
        f.txtKodePermintaan.Text = FindMaxPlusDatatable(ops.DataInventaris, "KDALATMAKAN", "AM", 5)

        Try
            If f.ShowDialog = DialogResult.OK Then
                Dim Identifier As String = f.txtKodePermintaan.Text
                f.txtKodePermintaan.Text = Identifier

                If ops.TambahInventaris(f.txtNama.Text, f.txtKodeKelas.Text,
                                        Val(f.txtJumlah.Text), f.txtSatuan.Text, f.cboKetInventaris.Text, Identifier) Then
                    'bsUser.ResetItem()
                    bsData.DataTable.Rows.Add(New Object() {Identifier, f.txtNama.Text, f.txtKodeKelas.Text,
                                        Val(f.txtJumlah.Text), f.txtSatuan.Text, f.cboKetInventaris.Text})
                    bsData.Locate("KDALATMAKAN", Identifier.ToString)
                    dtInventaris = ops.DataInventaris
                    bsData.DataSource = dtInventaris
                    bsData.Sort = "KDALATMAKAN"
                    dgvInventaris.DataSource = bsData

                    allNavigator.BindingSource = bsData


                Else
                    MsgBox($"Failed to save data: {Err.LastExceptionMessage}", "Peringatan")
                End If
            End If
        Finally
            f.Dispose()
        End Try
    End Sub
    Protected Sub EditInventaris()
        Dim f As New frmInventarisEditor
        Dim InventarisRow As DataRow = CType(bsData.Current, DataRowView).Row


        f.btnSimpan.Text = "Edit"
        f.txtKodePermintaan.Text = InventarisRow.Field(Of String)("KDALATMAKAN")
        f.txtNama.Text = InventarisRow.Field(Of String)("ALATMAKAN")
        f.txtKodeKelas.Text = InventarisRow.Field(Of String)("KDKELAS")
        f.cboKelas.Text = InventarisRow.Field(Of String)("kelas")
        f.txtJumlah.Text = InventarisRow.Field(Of Integer)("JUMLAHALAT")
        f.txtSatuan.Text = InventarisRow.Field(Of String)("SATUANALAT")
        f.cboKetInventaris.Text = InventarisRow.Field(Of String)("KETINVENTARIS")
        Try
            If f.ShowDialog = DialogResult.OK Then
                InventarisRow.SetField(Of String)("KDALATMAKAN", f.txtKodePermintaan.Text)
                InventarisRow.SetField(Of String)("ALATMAKAN", f.txtNama.Text)
                InventarisRow.SetField(Of String)("KDKELAS", f.txtKodeKelas.Text)
                InventarisRow.SetField(Of String)("kelas", f.cboKelas.Text)

                InventarisRow.SetField(Of String)("JUMLAHALAT", f.txtJumlah.Text)
                InventarisRow.SetField(Of String)("SATUANALAT", f.txtSatuan.Text)
                InventarisRow.SetField(Of String)("KETINVENTARIS", f.cboKetInventaris.Text)


                If ops.UpdateInventaris(bsData.CurrentRow) Then
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
#End Region
#Region "Kelas"
    Protected Sub TambahDataKelas()
        Dim f As New frmAllEditor

        f.Text = "Simpan Kelas"
        f.txtNama.Visible = True
        f.cboNama.Visible = False
        'f.txtKode.ReadOnly = False
        f.lblNama.Text = "Nama Kelas Gizi :"
        f.btnSimpan.Text = "Simpan"

        f.txtKode.Text = FindMaxPlusDatatable(tkelas.DataKelas, "kdKelas", "K", 2)

        Try
            If f.ShowDialog = DialogResult.OK Then
                Dim Identifier As String = f.txtKode.Text
                f.txtKode.Text = Identifier

                If tkelas.TambahKelas(f.txtNama.Text, Identifier) Then
                    'bsUser.ResetItem()
                    bsKelas.DataTable.Rows.Add(New Object() {Identifier, f.txtNama.Text})
                    bsKelas.Locate("kdKelas", Identifier.ToString)
                    dtKelas = tkelas.DataKelas
                    bsKelas.DataSource = dtKelas
                    bsKelas.Sort = "kdKelas"
                    dgvKelas.DataSource = bsKelas

                    allNavigator.BindingSource = bsKelas


                Else
                    MsgBox($"Failed to save data: {Err.LastExceptionMessage}", "Peringatan")
                End If
            End If
        Finally
            f.Dispose()
        End Try
    End Sub

    Protected Sub EditDataKelas()
        Dim f As New frmAllEditor
        Dim KelasRow As DataRow = CType(bsKelas.Current, DataRowView).Row

        f.Text = "Edit Kelas"
        f.txtNama.Visible = True
        f.cboNama.Visible = False

        f.lblNama.Text = "Nama Kelas Gizi :"
        f.btnSimpan.Text = "Edit"
        f.txtKode.Text = KelasRow.Field(Of String)("kdKelas")
        f.txtNama.Text = KelasRow.Field(Of String)("kelas")
        Try
            If f.ShowDialog = DialogResult.OK Then
                KelasRow.SetField(Of String)("kdKelas", f.txtKode.Text)
                KelasRow.SetField(Of String)("kelas", f.txtNama.Text)

                If tkelas.UpdateKelas(bsKelas.CurrentRow) Then
                    bsKelas.DataTable.AcceptChanges()
                Else
                    If Not Err.IsSuccessFul Then
                        MsgBox($"Update Data Gagal: {Err.LastExceptionMessage}", "Fatal Error")
                    End If

                End If
            Else
                bsKelas.CancelEdit()
            End If
        Finally
            f.Dispose()
        End Try
    End Sub
#End Region
    Private Sub dgvInventaris_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvInventaris.CellContentClick

    End Sub
#End Region
    Private Sub naviTambah_Click(sender As Object, e As EventArgs) Handles naviTambah.Click
        If lblKeteranganData.Text = "Data inventaris ke-" Then
            TambahDataInventaris()
        Else
            TambahDataKelas()
        End If
    End Sub
#Region "Clear Selection Datagridview"
#Region "Datagridview Method"
    Private Sub dgvKelas_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvKelas.DataBindingComplete
        Dim DGV As DataGridView
        DGV = CType(sender, DataGridView)
        DGV.ClearSelection()
    End Sub
    Private Sub dgvKelas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvKelas.CellClick
        If e.RowIndex <> -1 Then
            AktifasiKetTabelKelas()
        End If
    End Sub
    Private Sub dgvKelas_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvKelas.CellContentDoubleClick
        If e.RowIndex <> -1 Then
            EditDataKelas()
        End If
    End Sub
    Private Sub dgvKelas_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvKelas.CellDoubleClick
        If e.RowIndex <> -1 Then
            EditDataKelas()
        End If
    End Sub
    Private Sub dgvInventaris_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvInventaris.DataBindingComplete
        Dim DGV As DataGridView
        DGV = CType(sender, DataGridView)
        DGV.ClearSelection()
    End Sub
    Private Sub dgvInventaris_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvInventaris.CellClick
        If e.RowIndex <> -1 Then
            AktifasiKetTabelInventaris()
        End If
    End Sub
    Private Sub dgvInventaris_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvInventaris.CellDoubleClick
        If e.RowIndex <> -1 Then
            EditInventaris()
        End If
    End Sub
    Private Sub dgvInventaris_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvInventaris.CellContentDoubleClick
        If e.RowIndex <> -1 Then
            EditInventaris()
        End If
    End Sub
#End Region
#End Region
End Class