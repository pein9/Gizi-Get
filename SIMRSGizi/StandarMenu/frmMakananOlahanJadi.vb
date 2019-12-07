Imports Pein
Imports WeifenLuo.WinFormsUI.Docking
Imports MySql.Data.MySqlClient
Public Class frmMakananOlahanJadi
    Inherits DockContent

    Protected ops As New Pein.MakananOlahanJadi
    Protected saji As New Pein.SatuanSaji
    Protected kompos As New Pein.KomposisiBahan
    Private bsKomposisi As New BindingSource
    Private bsData As New BindingSource
    Private bsSaji As New BindingSource
    Dim dtOlahan As DataTable
    Dim dtSaji As DataTable
    Dim dtKomposisi As DataTable
    Dim tError As New BaseExceptionsHandler
    Dim KodeMakan, NamaMakan As String

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub
    Private Sub frmMakananOlahanJadi_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim dtOlahan As DataTable = ops.DataOlahanMakanan
        dtSaji = saji.DataSatuanSaji

        AddHandler dtOlahan.RowChanged, AddressOf RowChanged


        bsData.DataSource = dtOlahan
        bsData.Sort = "KDMAKANAN"

        bsSaji.DataSource = dtSaji
        bsSaji.Sort = "kdSatuanSaji"
        ' set customer DataTable to our DataGridView via bsData BindingSource component
        dgvMakananOlahan.DataSource = bsData


        dgvMakananOlahan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill


        'Satuan Saji
        dgvSatuanSaji.DataSource = bsSaji
        dgvSatuanSaji.Columns("kdSatuanSaji").HeaderText = "Kode"
        dgvSatuanSaji.Columns("satuanSaji").HeaderText = "Satuan Saji"

        dgvSatuanSaji.Columns("satuanSaji").HeaderText = "Satuan Saji"
        dgvSatuanSaji.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        txtCariOlahan.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        txtCariOlahan.AutoCompleteSource = AutoCompleteSource.CustomSource

    End Sub
    Private Sub RowChanged(sender As Object, e As DataRowChangeEventArgs)
        Dim rowOlahan As DataRow = CType(bsData.Current, DataRowView).Row

        If e.Action = DataRowAction.Change Then
            If Not ops.UpdateOlahanByIdentifier(e.Row) Then
                MsgBox("Update makanan gagal", MsgBoxStyle.Critical, "Fatal Error")
            End If
            txtCariOlahan.Text = Nothing
            txtCariOlahan.AutoCompleteCustomSource = ops.LoadAutoNamaWithoutHeader

        End If
    End Sub
    Private Sub dgvMakananOlahan_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvMakananOlahan.DataBindingComplete
        Dim DGV As DataGridView
        DGV = CType(sender, DataGridView)
        DGV.ClearSelection()
    End Sub
    Private Sub dgvSatuanSaji_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvSatuanSaji.DataBindingComplete
        Dim DGV As DataGridView
        DGV = CType(sender, DataGridView)
        DGV.ClearSelection()
    End Sub
    Private Sub TableLayoutPanel1_CellPaint(sender As Object, e As TableLayoutCellPaintEventArgs) Handles TableLayoutPanel1.CellPaint
        If e.Column = 1 Then 'AndAlso e.Row = 1 
            e.Graphics.FillRectangle(Brushes.DarkGray, e.CellBounds)
        End If
    End Sub
#Region "Deteksi Keterangan Tabel"
    Protected Sub AktivasiMakananOlahan()
        olahanNavigator.BindingSource = bsData
        lblKeteranganData.Text = "Data makanan olahan ke-"
        btnTambah.Visible = True
        btnTambah.Text = "Tambah data Makanan Olahan"
        lblKetNavi.ForeColor = Color.Red
        lblKetNavi.Text = "**Ket : Anda bisa langsung melakukan update/edit data dalam tabel"
        lblKetNavi.Visible = True
        separatorCari.Visible = True
        txtCariOlahan.Visible = True
        lblCariOlahan.Visible = True
        dgvSatuanSaji.CurrentCell.Selected = Nothing
        txtCariOlahan.AutoCompleteCustomSource = ops.LoadAutoNamaWithoutHeader
        ToolTip1.Show("> Klik 2x data dalam tabel untuk update/edit data" & vbNewLine & "> Tekan Enter setelah melakukan edit data", dgvMakananOlahan, 3000)

        ExtractKeKomposisi()
    End Sub
    Protected Sub AktifasiSatuanSaji()
        olahanNavigator.BindingSource = bsSaji
        lblKeteranganData.Text = "Data satuan saji ke -"
        btnTambah.Visible = True
        btnTambah.Text = "Tambah data Satuan Saji"
        lblKetNavi.ForeColor = Color.DarkOrange
        lblKetNavi.Text = "*Ket : Klik 2x dalam tabel ini untuk update/edit data - membuka editor data"
        lblKetNavi.Visible = True
        separatorCari.Visible = False
        txtCariOlahan.Visible = False
        lblCariOlahan.Visible = False
        pnlKomposisi.Text = "Komposisi Makanan"
        'bsKomposisi.DataSource = Nothing
        komposisiNavi.Visible = False
        dgvKomposisi.DataSource = Nothing
        komposisiNavi.BindingSource = Nothing
        txtCariOlahan.Text = Nothing
        bsData.Filter = Nothing
        dgvMakananOlahan.CurrentCell.Selected = Nothing
    End Sub
    Private Sub dgvMakananOlahan_SelectionChanged(sender As Object, e As EventArgs) Handles dgvMakananOlahan.SelectionChanged
        Dim dgvMakananOlahan As DataGridView = sender
        If (Not dgvMakananOlahan.CurrentCell Is Nothing) Then
            If lblKeteranganData.Text = "Data makanan olahan ke-" Then
                If (dgvMakananOlahan.CurrentCell.ColumnIndex > 0) Then
                    ' dgvMakananOlahan.CurrentCell = dgvMakananOlahan.Rows(dgvMakananOlahan.CurrentRow.Index).Cells(1)
                    ExtractKeKomposisi()
                End If
            End If
        End If
    End Sub
    Private Sub dgvMakananOlahan_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMakananOlahan.CellContentClick
        If e.RowIndex <> -1 Then
            AktivasiMakananOlahan()
        End If
    End Sub
    Private Sub dgvSatuanSaji_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSatuanSaji.CellContentClick
        If e.RowIndex <> -1 Then
            AktifasiSatuanSaji()
        End If
    End Sub
    Private Sub dgvMakananOlahan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMakananOlahan.CellClick
        If e.RowIndex <> -1 Then
            AktivasiMakananOlahan()
        End If
    End Sub
    Private Sub dgvSatuanSaji_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSatuanSaji.CellClick
        If e.RowIndex <> -1 Then
            AktifasiSatuanSaji()
        End If
    End Sub
#End Region
#Region "CRUD Makanan Olahan"
    Protected Sub TambahDataMakananOlahan()
        Dim f As New frmAllEditor

        f.Text = "Makanan Olahan Editor"
        f.txtKode.ReadOnly = False
        f.txtKode.Text = FindMaxPlusDatatable(ops.DataOlahanMakanan, "kdMakanan", "0", 4)

        f.txtNama.Visible = True
        f.cboNama.Visible = False
        f.lblNama.Text = "Nama Makanan :"
        f.btnSimpan.Text = "Simpan"

        Try
            If f.ShowDialog = DialogResult.OK Then
                Dim Identifier As String = f.txtKode.Text
                f.txtKode.Text = Identifier

                If ops.TambahMakananOlahanJadi(f.txtNama.Text, False, Identifier) Then
                    'bsUser.ResetItem()
                    bsData.DataTable.Rows.Add(New Object() {Identifier, f.txtNama.Text})
                    bsData.Locate("kdMakanan", Identifier.ToString)
                    dtOlahan = ops.DataOlahanMakanan
                    bsData.DataSource = dtOlahan
                    bsData.Sort = "kdMakanan"
                    dgvMakananOlahan.DataSource = bsData

                    olahanNavigator.BindingSource = bsData


                Else
                    MsgBox($"Failed to save data: {tError.LastExceptionMessage}", "Peringatan")
                End If
            End If
        Finally
            f.Dispose()
        End Try
    End Sub
#End Region
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If btnTambah.Text = "Tambah data Makanan Olahan" Then
            TambahDataMakananOlahan()
        ElseIf btnTambah.Text = "Tambah data Satuan Saji" Then
            TambahDataSatuanSaji()
        End If
    End Sub
    Private Sub dgvSatuanSaji_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSatuanSaji.CellContentDoubleClick
        If e.RowIndex <> -1 Then
            EditDataSatuanSaji()
        End If
    End Sub
    Private Sub dgvSatuanSaji_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSatuanSaji.CellDoubleClick
        If e.RowIndex <> -1 Then
            EditDataSatuanSaji()
        End If
    End Sub
#Region "CRUD Satuan Saji"
    Protected Sub TambahDataSatuanSaji()
        Dim f As New frmAllEditor

        f.Text = "Satuan Saji Editor"
        f.txtKode.ReadOnly = True
        f.txtKode.Text = FindMaxPlusDatatable(saji.DataSatuanSaji, "kdSatuanSaji", "SS", 4)

        f.txtNama.Visible = True
        f.cboNama.Visible = False
        f.lblNama.Text = "Nama Satuan Saji :"
        f.btnSimpan.Text = "Simpan"

        Try
            If f.ShowDialog = DialogResult.OK Then
                Dim Identifier As String = f.txtKode.Text
                f.txtKode.Text = Identifier

                If saji.TambahSatuanSaji(f.txtNama.Text, Identifier) Then
                    'bsUser.ResetItem()
                    bsSaji.DataTable.Rows.Add(New Object() {Identifier, f.txtNama.Text})
                    bsSaji.Locate("kdSatuanSaji", Identifier.ToString)
                    dtOlahan = saji.DataSatuanSaji
                    bsSaji.DataSource = dtOlahan
                    bsSaji.Sort = "kdSatuanSaji"
                    dgvSatuanSaji.DataSource = bsSaji

                    olahanNavigator.BindingSource = bsSaji


                Else
                    MsgBox($"Failed to save data: {tError.LastExceptionMessage}", "Peringatan")
                End If
            End If
        Finally
            f.Dispose()
        End Try
    End Sub
    Protected Sub EditDataSatuanSaji()
        Dim f As New frmAllEditor
        Dim SajiRow As DataRow = CType(bsSaji.Current, DataRowView).Row

        f.Text = "Edit Satuan Saji"
        f.txtNama.Visible = True
        f.cboNama.Visible = False
        f.lblNama.Text = "Nama Satuan Saji :"
        f.btnSimpan.Text = "Edit"
        f.txtKode.Text = SajiRow.Field(Of String)("kdSatuanSaji")
        f.txtNama.Text = SajiRow.Field(Of String)("satuanSaji")
        Try
            If f.ShowDialog = DialogResult.OK Then
                SajiRow.SetField(Of String)("kdSatuanSaji", f.txtKode.Text)
                SajiRow.SetField(Of String)("satuanSaji", f.txtNama.Text)

                If saji.UpdateSatuanSaji(bsSaji.CurrentRow) Then
                    bsSaji.DataTable.AcceptChanges()
                Else
                    If Not tError.IsSuccessFul Then
                        MsgBox($"Update Data Gagal: {tError.LastExceptionMessage}", "Fatal Error")
                    End If

                End If
            Else
                bsSaji.CancelEdit()
            End If
        Finally
            f.Dispose()
        End Try
    End Sub
#End Region
#Region "Komposisi"
    Private Function DeleteCurrentRow(ByVal isBindingSource As Boolean) As Boolean

        Dim success As Boolean = False
        Dim row As DataRow = CType(bsKomposisi.Current, DataRowView).Row
        Dim p As String = MsgBox($"Anda ingin menghapus komposisi {row.Field(Of String)("KOMPOSISI")} dari bahan makanan {row.Field(Of String)("NAMABAHAN")}?", MsgBoxStyle.OkCancel, "Konfirmasi")
        If p = vbOK Then
            If bsKomposisi.Current IsNot Nothing Then
                ' My.Dialogs.Question($"Remove {row.Field(Of String)("CompanyName")}?")


                If Not kompos.DeleteKomposisiByIdentifier(row.Field(Of String)("KDKOMPOSISI")) Then
                    success = False
                    MsgBox("Gagal hapus data komposisi", "Fatal Error")
                Else
                    '
                    ' If we don't execute this the row is deleted but still shows in the DataGridView
                    ' This is only required if deleting from the BindingNavigator's delete button
                    '
                    If isBindingSource Then
                        bsKomposisi.RemoveCurrent()
                    End If

                    success = True
                End If

                Return success

            End If
        ElseIf vbCancel Then
            success = False

            Return success
            Exit Function
        End If

        Return success

    End Function
    Protected Sub ExtractKeKomposisi()
        Dim KomposisiRow As DataRow = CType(bsData.Current, DataRowView).Row
        KodeMakan = KomposisiRow.Field(Of String)("KDMAKANAN")
        NamaMakan = KomposisiRow.Field(Of String)("NMMAKANAN")
        pnlKomposisi.Text = "Komposisi Makanan " & "- [ " & KodeMakan & " - " & NamaMakan & " ]"
        komposisiNavi.Visible = True

        dtKomposisi = kompos.LihatNamaKomposisi(KodeMakan, NamaMakan)
        bsKomposisi.DataSource = dtKomposisi
        bsKomposisi.Sort = "NAMABAHAN"

        dgvKomposisi.DataSource = bsKomposisi
        dgvKomposisi.Columns("KDKOMPOSISI").HeaderText = "Kode Komposisi"
        dgvKomposisi.Columns("NAMABAHAN").HeaderText = "Bahan Makanan"
        dgvKomposisi.Columns("KOMPOSISI").HeaderText = "Komposisi"
        dgvKomposisi.Columns("SATUANPAKAI").HeaderText = "Satuan Pakai"
        dgvKomposisi.Columns("KETERANGAN").HeaderText = "Keterangan"
        dgvKomposisi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        komposisiNavi.BindingSource = bsKomposisi
    End Sub
    Private Sub btnAddKomposisi_Click(sender As Object, e As EventArgs) Handles btnAddKomposisi.Click
        TambahKomposisi()
    End Sub
    Protected Sub TambahKomposisi()
        Dim f As New frmKomposisiEditor
        f.txtKode.Text = FindMaxPlusDatatable(kompos.CekKodeKomposisi, "KDKOMPOSISI", "KS", 4)
        f.lblkodemakanan.Text = KodeMakan
        f.btnSimpan.Text = "Simpan"

        Try
            If f.ShowDialog = DialogResult.OK Then
                Dim Identifier As String = f.txtKode.Text
                f.txtKode.Text = Identifier

                If kompos.TambahKomposisi(f.lblKdBahan.Text, f.lblkodemakanan.Text, f.txtKomposisi.Text.Trim,
                                          f.txtSatuanPakai.Text.Trim, f.txtKeterangan.Text.Trim,
                                          Identifier) Then
                    'bsUser.ResetItem()
                    'bsKomposisi.DataTable.Rows.Add(New Object() {Identifier, f.lblKdBahan.Text, f.lblkodemakanan.Text, f.txtKomposisi.Text.Trim,
                    'f.txtKeterangan.Text.Trim})
                    bsKomposisi.Locate("NAMABAHAN", Identifier.ToString)

                    dtKomposisi = kompos.LihatNamaKomposisi(KodeMakan, NamaMakan)
                    bsKomposisi.DataSource = dtKomposisi
                    bsKomposisi.Sort = "NAMABAHAN"
                    dgvKomposisi.DataSource = bsKomposisi

                    komposisiNavi.BindingSource = bsKomposisi


                Else
                    MsgBox($"Failed to save data: {tError.LastExceptionMessage}", "Peringatan")
                End If
            End If
        Finally
            f.Dispose()
        End Try
    End Sub
    Protected Sub EditKomposisi()
        Dim f As New frmKomposisiEditor
        Dim KomposisiRow As DataRow = CType(bsKomposisi.Current, DataRowView).Row

        f.txtKode.Text = KomposisiRow.Field(Of String)("KDKOMPOSISI")
        f.lblKdBahan.Text = KomposisiRow.Field(Of String)("KDBAHAN")
        f.txtNamaBahan.Text = KomposisiRow.Field(Of String)("NAMABAHAN")
        f.lblkodemakanan.Text = KomposisiRow.Field(Of String)("kdMakanan")
        f.txtKomposisi.Text = KomposisiRow.Field(Of String)("KOMPOSISI")
        f.txtSatuanPakai.Text = KomposisiRow.Field(Of String)("SATUANPAKAI")
        f.txtKeterangan.Text = KomposisiRow.Field(Of String)("KETERANGAN")
        f.btnSimpan.Text = "Edit"

        Try
            If f.ShowDialog = DialogResult.OK Then
                KomposisiRow.SetField(Of String)("KDKOMPOSISI", f.txtKode.Text)
                KomposisiRow.SetField(Of String)("KDBAHAN", f.lblKdBahan.Text)
                KomposisiRow.SetField(Of String)("NAMABAHAN", f.txtNamaBahan.Text)
                KomposisiRow.SetField(Of String)("kdMakanan", f.lblkodemakanan.Text)
                KomposisiRow.SetField(Of String)("KOMPOSISI", f.txtKomposisi.Text)
                KomposisiRow.SetField(Of String)("SATUANPAKAI", f.txtSatuanPakai.Text)
                KomposisiRow.SetField(Of String)("KETERANGAN", f.txtKeterangan.Text)

                If kompos.UpdateKomposisi(bsKomposisi.CurrentRow) Then
                    bsKomposisi.DataTable.AcceptChanges()
                Else
                    If Not tError.IsSuccessFul Then
                        MsgBox($"Update Data Gagal: {tError.LastExceptionMessage}", "Fatal Error")
                    End If
                End If
            Else
                bsKomposisi.CancelEdit()
            End If
        Finally
            f.Dispose()
        End Try
    End Sub
#End Region
#Region "Text Cari"
    Private Sub txtCariOlahan_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCariOlahan.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtCariOlahan.Text <> Nothing Then
                bsData.Filter = "nmMakanan ='" & txtCariOlahan.Text & "'"
            Else
                bsData.Filter = Nothing
            End If
        End If
    End Sub
    Private Sub txtCariOlahan_TextChanged(sender As Object, e As EventArgs) Handles txtCariOlahan.TextChanged
        If txtCariOlahan.Text = Nothing Then bsData.Filter = Nothing
    End Sub
#End Region
    Private Sub dgvKomposisi_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvKomposisi.CellContentDoubleClick
        If e.RowIndex <> -1 Then
            EditKomposisi()
        End If
    End Sub
    Private Sub dgvKomposisi_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvKomposisi.CellDoubleClick
        If e.RowIndex <> -1 Then
            EditKomposisi()
        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs)
        Dim counter As Integer = dgvMakananOlahan.CurrentRow.Index + 1

        Dim nextRow As DataGridViewRow
        If counter = dgvMakananOlahan.RowCount Then
            nextRow = dgvMakananOlahan.Rows(1)
        Else
            nextRow = dgvMakananOlahan.Rows(counter)
        End If
        dgvMakananOlahan.CurrentCell = nextRow.Cells(1)
        nextRow.Selected = True
    End Sub
    Protected Sub BawahAtas()
        If dgvMakananOlahan.Rows.Count > 0 Then
            Dim counter As Integer = dgvMakananOlahan.CurrentRow.Index - 1
            Dim nextRow As DataGridViewRow
            If counter < dgvMakananOlahan.Rows(0).Index Then
                nextRow = dgvMakananOlahan.Rows(dgvMakananOlahan.Rows.Count - 1)
            Else
                nextRow = dgvMakananOlahan.Rows(counter)
            End If
            dgvMakananOlahan.CurrentCell = nextRow.Cells(0)
            nextRow.Selected = True
        End If
    End Sub
    Protected Sub AtasBawah()
        Dim nextRow As DataGridViewRow

        If dgvMakananOlahan.CurrentRow.Index = dgvMakananOlahan.Rows.Count - 1 Then
            dgvMakananOlahan.Rows(1).Selected = True
        Else
            nextRow = dgvMakananOlahan.Rows(dgvMakananOlahan.CurrentRow.Index + 1)
            dgvMakananOlahan.CurrentCell = nextRow.Cells(1)
            nextRow.Selected = True
        End If
        If dgvMakananOlahan.Rows(dgvMakananOlahan.RowCount - 1).Selected = True Then
            'Timer1.Stop()
        End If
    End Sub
    Private Sub DgvLoopUpDown()
        Dim counter As Integer = dgvMakananOlahan.CurrentRow.Index + 1

        Dim nextRow As DataGridViewRow
        If counter = dgvMakananOlahan.RowCount Then
            nextRow = dgvMakananOlahan.Rows(0)
        Else
            nextRow = dgvMakananOlahan.Rows(counter)
        End If
        dgvMakananOlahan.CurrentCell = nextRow.Cells(1)
        nextRow.Selected = True
    End Sub
    Private Sub btnDeleteKomposisi_Click(sender As Object, e As EventArgs) Handles btnDeleteKomposisi.Click
        If bsKomposisi.Count > 0 Then
            DeleteCurrentRow(True)
        Else
            'DeleteCurrentRow(False)
            MsgBox("Maaf anda tidak bisa menghapus data kosong", MsgBoxStyle.Exclamation, "Akses Ditolak")
        End If
    End Sub
End Class