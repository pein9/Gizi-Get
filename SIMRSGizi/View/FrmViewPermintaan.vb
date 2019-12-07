Imports System.ComponentModel
Imports WeifenLuo.WinFormsUI.Docking
Public Class FrmViewPermintaan
    Private tRInap As New Pein.RawatInap
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub EnableVSRenderer(ByVal version As VisualStudioToolStripExtender.VsVersion, ByVal theme As ThemeBase)
        vsRender.SetStyle(StatusStrip1, version, theme)
    End Sub
    Private Sub FrmViewPermintaan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TanggalDari.Value = Today
        TanggalSampai.Value = Now
        Me.EnableVSRenderer(VisualStudioToolStripExtender.VsVersion.Vs2015, VS2015LightTheme1)
        Panel2.BackColor = VS2015LightTheme1.ColorPalette.ToolWindowSeparator ',.Background

        cboRuang.DisplayMember = "rawatInap"
        'cboRuang.ValueMember = "kdKelDiet"
        cboRuang.DataSource = tRInap.PencarianNamaRuang

    End Sub
    Private Sub cboRuang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboRuang.SelectedIndexChanged
        If cboRuang.SelectedIndex = -1 Then
            Return
        Else
            btnSimpan.Enabled = True
            btnSimpan.DialogResult = DialogResult.Yes
        End If
    End Sub
End Class