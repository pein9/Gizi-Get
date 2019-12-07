Imports Pein
Imports WeifenLuo.WinFormsUI.Docking
Imports MySql.Data.MySqlClient
Public Class frmDetailMakanan
    Inherits DockContent
    Dim bahan As New Pein.BahanMakan
    Dim olahan As New Pein.MakananOlahanJadi
    Dim pKdBahan, pKdOlahan As String
    Dim dtOlahan As DataTable

    Dim bsOlahan As New BindingSource
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub frmDetailMakanan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtOlahan = olahan.DataHeaderOlahan
        txtCariNamaBahan.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        txtCariNamaBahan.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtCariNamaBahan.AutoCompleteCustomSource = bahan.LoadAutoNama

        cboTipeMakanan.DataSource = dtOlahan
        cboTipeMakanan.DisplayMember = "nmMakanan"
        cboTipeMakanan.ValueMember = "kdMakanan"
        cboTipeMakanan.Text = Nothing
        txtCariNamaMakanan.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        txtCariNamaMakanan.AutoCompleteSource = AutoCompleteSource.CustomSource

        'kdOlahanJadi.Text = cboTipeMakanan.SelectedIndex.ToString
        GroupContractable1.SetCollapsed(True)
        GroupContractable2.SetCollapsed(True)
    End Sub
    Protected Sub CariNamaOlahan()
        If olahan.AmbilOlahanMakanan(txtCariNamaMakanan.Text) Then
            pKdOlahan = olahan.OlahKdMakanan
            lblDataOlahan.Text = pKdOlahan & " - " & txtCariNamaMakanan.Text

        End If
    End Sub
    Protected Sub CariNamaBahan()
        bahan.bNAMABAHAN = txtCariNamaBahan.Text

        If bahan.AmbilBahanMakanan(bahan.bNAMABAHAN) Then
            pKdBahan = bahan.bkdBahan
            lblKodeNamaBahan.Text = pKdBahan & " - " & bahan.bNAMABAHAN
            lblEnergi.Text = bahan.bENERGI
            lblHewani.Text = bahan.bPROTEINHEWANI
            lblNabati.Text = bahan.bPROTEINNABATI
            lblTiamin.Text = bahan.bTIAMIN
            lblRiboflavin.Text = bahan.bRIBOFLAVIN
            lblNiasin.Text = bahan.bNIASIN
            lblLemak.Text = bahan.bLEMAK
            lblHA.Text = bahan.bHA
            lblKalsium.Text = bahan.bKALSIUM
            lblFolat.Text = bahan.bASAMFOLAT
            lblPiridoksin.Text = bahan.bPIRIDOKSIN
            lblSeng.Text = bahan.bSENG
            lblLodium.Text = bahan.bLODIUM
            lblSelenium.Text = bahan.bSELENIUM
            lblBDD.Text = bahan.bBDD
            lblVITA.Text = bahan.bVITA
            lblVITB.Text = bahan.bVITB
            lblVITC.Text = bahan.bVITC
            lblVITD.Text = bahan.bVITD
            lblVITE.Text = bahan.bVITE
            lblVITK.Text = bahan.bVITK
            lblB12.Text = bahan.bVITB12
            lblB1.Text = bahan.bVITB1
        End If

    End Sub
    Private Sub txtCariNamaBahan_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCariNamaBahan.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtCariNamaBahan.Text <> Nothing Then
                CariNamaBahan()
                GroupContractable1.SetCollapsed(False)
                GroupContractable2.SetCollapsed(False)
            Else
                pKdBahan = Nothing
                lblKodeNamaBahan.Text = Nothing
                lblEnergi.Text = Nothing
                lblHewani.Text = Nothing
                lblNabati.Text = Nothing
                lblTiamin.Text = Nothing
                lblRiboflavin.Text = Nothing
                lblNiasin.Text = Nothing
                lblLemak.Text = Nothing
                lblHA.Text = Nothing
                lblKalsium.Text = Nothing
                lblFolat.Text = Nothing
                lblPiridoksin.Text = Nothing
                lblSeng.Text = Nothing
                lblLodium.Text = Nothing
                lblSelenium.Text = Nothing
                lblBDD.Text = Nothing
                lblVITA.Text = Nothing
                lblVITB.Text = Nothing
                lblVITC.Text = Nothing
                lblVITD.Text = Nothing
                lblVITE.Text = Nothing
                lblVITK.Text = Nothing
                lblB12.Text = Nothing
                lblB1.Text = Nothing
                GroupContractable1.SetCollapsed(True)
                GroupContractable2.SetCollapsed(True)
            End If
        End If
    End Sub
    Private Sub cboTipeMakanan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipeMakanan.SelectedIndexChanged

        If cboTipeMakanan.SelectedIndex = -1 Then
            Return
        Else
            'kdOlahanJadi.Text = cboTipeMakanan.SelectedValue.ToString
            txtCariNamaMakanan.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            txtCariNamaMakanan.AutoCompleteSource = AutoCompleteSource.CustomSource
            txtCariNamaMakanan.AutoCompleteCustomSource = olahan.LoadAutoNamaSubstring((cboTipeMakanan.SelectedValue.ToString).Trim)

        End If

    End Sub
    Private Sub btnCariNamaOlahan_Click(sender As Object, e As EventArgs) Handles btnCariNamaOlahan.Click
        If cboTipeMakanan.Text <> Nothing Then
            Dim f As New frmViewMakananOlahan
            f.kdMakananStr = Me.cboTipeMakanan.SelectedValue.ToString.Trim
            f.nmMakananStr = Me.cboTipeMakanan.Text.Trim

            Try
                If f.ShowDialog = DialogResult.OK Then
                    txtCariNamaMakanan.Text = f.CariNama
                    If txtCariNamaMakanan.Text <> Nothing Then
                        CariNamaOlahan()
                    Else
                        lblDataOlahan.Text = Nothing
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        Else
            Exit Sub
        End If

    End Sub
    Private Sub txtCariNamaMakanan_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCariNamaMakanan.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtCariNamaMakanan.Text <> Nothing Then
                CariNamaOlahan()
            Else
                lblDataOlahan.Text = Nothing
            End If
        End If
    End Sub
End Class