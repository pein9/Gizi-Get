Imports Pein
Imports WeifenLuo.WinFormsUI.Docking
Imports MySql.Data.MySqlClient
Public Class frmSiklusMenu
    Inherits DockContent

    Protected ops As New Pein.SiklusMenu
    Private bsData As New BindingSource

    Dim dtSiklus As DataTable

    Dim tError As New BaseExceptionsHandler

    Dim SiklusPeriode As Byte
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub frmSiklusMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboSiklus.SelectedIndex = 11
    End Sub
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        TambahData()
    End Sub

#Region "Pilihan Select"
    Protected Sub PakaiServer()
        dtSiklus = ops.DataSiklusMenu


        bsData.DataSource = dtSiklus
        bsData.Sort = "WAKTU"

        dgvSiklusMenu.DataSource = bsData

        siklusNavigator.BindingSource = bsData

        dgvSiklusMenu.Columns("STATE").Visible = False
        dgvSiklusMenu.Columns("kdwaktu").Visible = False
        dgvSiklusMenu.Columns("kdMakanan").Visible = False

        dgvSiklusMenu.Columns("kdSiklus").HeaderText = "Siklus"
        dgvSiklusMenu.Columns("namaSiklus").HeaderText = "Keterangan"
        dgvSiklusMenu.Columns("WAKTU").HeaderText = "Waktu"
        dgvSiklusMenu.Columns("nmMakanan").HeaderText = "Nama Makanan"
        dgvSiklusMenu.Columns("extraDiet").HeaderText = "Keterangan Menu"

        dgvSiklusMenu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill


    End Sub
    Protected Sub PerSiklus()



        bsData.DataSource = dtSiklus
        bsData.Sort = "WAKTU"

        dgvSiklusMenu.DataSource = bsData

        siklusNavigator.BindingSource = bsData


        dgvSiklusMenu.Columns("kdwaktu").Visible = False
        dgvSiklusMenu.Columns("kdMakanan").Visible = False

        dgvSiklusMenu.Columns("kdSiklus").HeaderText = "Siklus"
        dgvSiklusMenu.Columns("namaSiklus").HeaderText = "Keterangan"
        dgvSiklusMenu.Columns("WAKTU").HeaderText = "Waktu"
        dgvSiklusMenu.Columns("nmMakanan").HeaderText = "Nama Makanan"
        dgvSiklusMenu.Columns("extraDiet").HeaderText = "Keterangan Menu"

        dgvSiklusMenu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill


    End Sub
    Protected Sub AllSiklus()
        dtSiklus = ops.DataAllSiklus


        bsData.DataSource = dtSiklus
        bsData.Sort = "WAKTU"

        dgvSiklusMenu.DataSource = bsData

        siklusNavigator.BindingSource = bsData


        dgvSiklusMenu.Columns("kdwaktu").Visible = False
        dgvSiklusMenu.Columns("kdMakanan").Visible = False

        dgvSiklusMenu.Columns("kdSiklus").HeaderText = "Siklus"
        dgvSiklusMenu.Columns("namaSiklus").HeaderText = "Keterangan"
        dgvSiklusMenu.Columns("WAKTU").HeaderText = "Waktu"
        dgvSiklusMenu.Columns("nmMakanan").HeaderText = "Nama Makanan"
        dgvSiklusMenu.Columns("extraDiet").HeaderText = "Keterangan Menu"

        dgvSiklusMenu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill


    End Sub
#End Region

#Region "CRUD"
    Protected Sub TambahData()
        Dim f As New frmSiklusMenuEditor
        Try
            If f.ShowDialog = DialogResult.OK Then

                Dim Identifier As Int64 = 0
                ' f.ComboBox1.Text = Identifier

                If ops.TambahSiklus(f.ComboBox1.Text, f.txtKeterangan.Text, f.txtKdWaktu.Text,
                                  f.txtKodeMakanan.Text, f.cboNamaMakanan.Text,
                                  f.txtExtraDiet.Text, Identifier) Then
                    'bsUser.ResetItem()
                    ' bsData.DataTable.Rows.Add(New Object() {Identifier, f.ComboBox1.Text, f.txtKeterangan.Text,
                    'f.txtKdWaktu.Text, f.txtKodeMakanan.Text,
                    'f.cboNamaMakanan.Text, f.txtExtraDiet.Text})

                    'bsData.Locate("id", Identifier.ToString)
                    dtSiklus = ops.DataSiklusMenu
                    bsData.DataSource = dtSiklus
                    'bsData.Sort = "NAMABAHAN"
                    dgvSiklusMenu.DataSource = bsData

                    siklusNavigator.BindingSource = bsData
                    cboSiklus.SelectedIndex = 11
                    ' txtCariNama.AutoCompleteCustomSource = ops.LoadAutoNama
                Else
                    MsgBox($"Gagal menyimpan data: {tError.LastExceptionMessage}", "Peringatan")
                End If
            End If
        Finally
            f.Dispose()
        End Try
    End Sub
    Protected Sub EditDataSiklus()
        Dim f As New frmSiklusMenuEditor
        Dim SiklusRow As DataRow = CType(bsData.Current, DataRowView).Row

        f.txtID.Text = SiklusRow.Field(Of Integer)("id")
        f.ComboBox1.Text = SiklusRow.Field(Of String)("kdSiklus")
        f.txtKeterangan.Text = SiklusRow.Field(Of String)("namaSiklus")
        f.txtKdWaktu.Text = SiklusRow.Field(Of Int64)("kdwaktu")

        f.cboWaktu.Text = SiklusRow.Field(Of String)("WAKTU")
        f.txtKodeMakanan.Text = SiklusRow.Field(Of String)("kdMakanan")
        f.cboNamaMakanan.Text = SiklusRow.Field(Of String)("nmMakanan")
        f.txtExtraDiet.Text = SiklusRow.Field(Of String)("extraDiet")
        f.btnSimpan.Text = "Edit"
        Try
            If f.ShowDialog = DialogResult.OK Then
                SiklusRow.SetField(Of String)("id", f.txtID.Text)
                SiklusRow.SetField(Of String)("kdSiklus", f.ComboBox1.Text)
                SiklusRow.SetField(Of String)("namaSiklus", f.txtKeterangan.Text)
                SiklusRow.SetField(Of String)("kdwaktu", f.txtKdWaktu.Text)
                SiklusRow.SetField(Of String)("WAKTU", f.cboWaktu.Text)
                SiklusRow.SetField(Of String)("kdMakanan", f.txtKodeMakanan.Text)
                SiklusRow.SetField(Of String)("nmMakanan", f.cboNamaMakanan.Text)
                SiklusRow.SetField(Of String)("extraDiet", f.txtExtraDiet.Text)


                If ops.UpdateSiklusMenu(bsData.CurrentRow) Then
                    bsData.DataTable.AcceptChanges()
                    dtSiklus = ops.DataSiklusMenu
                    bsData.DataSource = dtSiklus
                Else
                    If Not tError.IsSuccessFul Then
                        MsgBox($"Update Data Gagal: {tError.LastExceptionMessage}", "Fatal Error")
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
    Private Sub dgvSiklusMenu_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSiklusMenu.CellContentDoubleClick
        If e.RowIndex <> -1 Then
            EditDataSiklus()
        End If
    End Sub
    Private Sub dgvSiklusMenu_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSiklusMenu.CellDoubleClick
        If e.RowIndex <> -1 Then
            EditDataSiklus()
        End If
    End Sub
    Private Sub cboSiklus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSiklus.SelectedIndexChanged
        If cboSiklus.SelectedIndex = 11 Then
            PakaiServer()
        ElseIf cboSiklus.SelectedIndex = 12 Then
            AllSiklus()
        ElseIf cboSiklus.SelectedIndex = 0 Then
            SiklusPeriode = 1
            dtSiklus = ops.DataPerSiklus(SiklusPeriode)
            PerSiklus()
        ElseIf cboSiklus.SelectedIndex = 1 Then
            SiklusPeriode = 2
            dtSiklus = ops.DataPerSiklus(SiklusPeriode)
            PerSiklus()
        ElseIf cboSiklus.SelectedIndex = 2 Then
            SiklusPeriode = 3
            dtSiklus = ops.DataPerSiklus(SiklusPeriode)
            PerSiklus()
        ElseIf cboSiklus.SelectedIndex = 3 Then
            SiklusPeriode = 4
            dtSiklus = ops.DataPerSiklus(SiklusPeriode)
            PerSiklus()
        ElseIf cboSiklus.SelectedIndex = 4 Then
            SiklusPeriode = 5
            dtSiklus = ops.DataPerSiklus(SiklusPeriode)
            PerSiklus()
        ElseIf cboSiklus.SelectedIndex = 5 Then
            SiklusPeriode = 6
            dtSiklus = ops.DataPerSiklus(SiklusPeriode)
            PerSiklus()
        ElseIf cboSiklus.SelectedIndex = 6 Then
            SiklusPeriode = 7
            dtSiklus = ops.DataPerSiklus(SiklusPeriode)
            PerSiklus()
        ElseIf cboSiklus.SelectedIndex = 7 Then
            SiklusPeriode = 8
            dtSiklus = ops.DataPerSiklus(SiklusPeriode)
            PerSiklus()
        ElseIf cboSiklus.SelectedIndex = 8 Then
            SiklusPeriode = 9
            dtSiklus = ops.DataPerSiklus(SiklusPeriode)
            PerSiklus()
        ElseIf cboSiklus.SelectedIndex = 9 Then
            SiklusPeriode = 10
            dtSiklus = ops.DataPerSiklus(SiklusPeriode)
            PerSiklus()
        ElseIf cboSiklus.SelectedIndex = 10 Then
            SiklusPeriode = 11
            dtSiklus = ops.DataPerSiklus(SiklusPeriode)
            PerSiklus()
        End If
    End Sub
    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        Dim fcari As New frmSiklusStruck
        fcari.ShowDialog()
        'MsgBox("Maaf masih pengembangan")
    End Sub
End Class