Imports Pein
Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Imports WeifenLuo.WinFormsUI.Docking
Public Class frmPerubahan
    Protected ops As New Pein.Diet
    Protected kelDiet As New Pein.KelompokDiet

    Private bsDiet As New BindingSource

    Dim dtDiet, dtKelDiet As DataTable

    Private Sub EnableVSRenderer(ByVal version As VisualStudioToolStripExtender.VsVersion, ByVal theme As ThemeBase)
        vsRender.SetStyle(StatusStrip1, version, theme)
    End Sub
    Private Sub cboNama_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboNama.SelectedIndexChanged
        If cboNama.SelectedIndex = -1 Then
            Return
        Else
            txtKode.Text = cboNama.SelectedValue.ToString
        End If
    End Sub
    Private Sub frmPerubahan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.EnableVSRenderer(VisualStudioToolStripExtender.VsVersion.Vs2015, VS2015LightTheme1)
        Panel2.BackColor = VS2015LightTheme1.ColorPalette.ToolWindowSeparator ',.Background
    End Sub
    Private Sub cboNama_DropDown(sender As Object, e As EventArgs) Handles cboNama.DropDown

        dtDiet = ops.DataDiet

        cboNama.DisplayMember = "KETERANGANDIET"
        cboNama.ValueMember = "KDDIET"
        cboNama.DataSource = dtDiet
    End Sub
End Class