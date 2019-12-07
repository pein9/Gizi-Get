Imports Pein
Public Class frmPermintaanMakananEditor
    Private ops As New Pein.RegistrasiRawatInap
    Private klas As New Pein.Kelas
    Private minta As New Pein.Permintaan
    Private bsData As New BindingSource
    Dim dtRegistrasiRawatInap As DataTable
    Dim Err As New Pein.BaseExceptionsHandler
    Private Sub frmPermintaanMakananEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtKodePermintaan.Text = FindMaxPlusDatatable(minta.NoPermintaan, "KDPERMINTAAN", "P", 10)
        txtNoRegist.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        txtNoRegist.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtNoRegist.AutoCompleteCustomSource = ops.LoadAutoNama

        cboKelas.DisplayMember = "kelas"
        cboKelas.ValueMember = "kdKelas"
        cboKelas.DataSource = klas.DataKelas
    End Sub
    Protected Sub CariNoRegist()
        ops.kdRawatInap = txtNoRegist.Text

        If ops.AmbilNoRawatInap(ops.kdRawatInap) Then
            lblNoRekamMedis.Text = ops.kdRekamMedis
            lblNamaPasien.Text = ops.namaPasien
            lblTanggalMasuk.Text = ops.bTanggalMasukRawatInap
            lblNoKamar.Text = ops.nomorKamar
            lblNoBed.Text = ops.noBed
        End If

    End Sub
    Private Sub txtNoRegist_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNoRegist.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtNoRegist.Text <> Nothing Then
                CariNoRegist()
            Else
                lblNoRekamMedis.Text = "?"
                lblNamaPasien.Text = "?"
                lblTanggalMasuk.Text = "?"
                lblNoKamar.Text = "?"
                lblNoBed.Text = "?"
            End If
        End If
    End Sub
    Private Sub cboKelas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboKelas.SelectedIndexChanged
        If cboKelas.SelectedIndex = -1 Then
            Return
        Else
            lblNoKelas.Text = cboKelas.SelectedValue.ToString
        End If
    End Sub
End Class