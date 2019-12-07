Imports System.Drawing
Imports System.IO
Imports System.Linq
Imports System.Reflection
Imports System.Windows.Forms
Imports System.Net
Imports WeifenLuo.WinFormsUI.Docking
Imports Pein
Imports System.Runtime.InteropServices
Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Controls
Imports Devart.Data.MySql
Imports System.ComponentModel
Imports System.Net.Sockets
Imports System.Drawing.Drawing2D
Imports Devart.Common
Imports System.Threading

Public Class MenuUtama
    Private connectionDevart As Devart.Data.MySql.MySqlConnection = New Devart.Data.MySql.MySqlConnection(con)

    'Standar Menu
    Private f_bahanMakanan As frmBahanMakanan
    Private f_olahJadi As frmMakananOlahanJadi
    Private f_detilMakanan As frmDetailMakanan
    Private f_layananGizi As frmPelayananGizi
    Private f_menudiet As frmDiet
    Private f_siklusmenu As frmSiklusMenu

    'Data Referensi
    Private f_ahligizi As frmDataAhliGizi
    Private f_nutrisi As frmNutrisiBahanMakanan
    Private f_jenisdiet As frmJenisDiet
    'Private f_penukar As frmBahanMakananPenukar
    Private f_inventaris As frmInventaris

    'Standar System
    Private f_imt As frmFormulaIMT
    Private f_tinggiLutut As frmTinggiLutut
    Private f_energiBasal As frmEnergiBasal
    Private f_cukupEnergi As frmKecukupanEnergi
    Private f_IMT220 As frmIMT220
    Private f_AKG As frmAKG
    Private f_AKP As frmAKP
    Private f_TebalLemak As frmKetebalanLemakTubuh
    Private f_katUmur As frmKategoryUmur
    Private f_giziBalita As frmStatusGiziBalita

    'formChat
    Private f_chat As FrmChat

    Dim SimpanLayout As Boolean = True
    Private deserial As DeserializeDockContent

    Dim attemptGUI As Integer
    Private ReadOnly RenderToolStrip As ToolStripRenderer = New ToolStripProfessionalRenderer()
    Public Sub New()
        ' Add any initialization after the InitializeComponent() call.
        InitializeComponent()
        AutoScaleMode = AutoScaleMode.Dpi

        BuatStandardControls()
        vsRender.DefaultRenderer = RenderToolStrip
        SetSchema(Me.mnu2015Light, Nothing)
        modTimer.Start()

    End Sub
    Private Sub MenuUtama_Load(sender As Object, e As EventArgs) Handles Me.Load
        SkinButtonKeluar()
        btnMenu1.Text = "   Standar Menu"
        btnMenu2.Text = "   Data Referensi"
        btnMenu3.Text = "   Standar System"
        btnMenu4.Text = "   Pelayanan Gizi"
        btnKeluarKembali.Text = "   Keluar"

        btnMenu7.Visible = False
        btnMenu8.Visible = False
        btnMenu9.Visible = False
        btnMenu10.Visible = False

        SQLDependencies()
    End Sub
    Private Sub TutupSemuaDokumen()
        If DockPanel.DocumentStyle = DocumentStyle.SystemMdi Then

            For Each form As Form In MdiChildren
                form.Close()
            Next
        Else

            For Each document As IDockContent In DockPanel.DocumentsToArray()
                document.DockHandler.DockPanel = Nothing
                document.DockHandler.Close()
            Next
        End If
    End Sub
    Private Sub BuatStandardControls()
        f_bahanMakanan = New frmBahanMakanan()
        f_olahJadi = New frmMakananOlahanJadi()
        f_detilMakanan = New frmDetailMakanan()
        f_layananGizi = New frmPelayananGizi
        f_menudiet = New frmDiet
        f_siklusmenu = New frmSiklusMenu
        'Data Referensi
        f_ahligizi = New frmDataAhliGizi
        f_nutrisi = New frmNutrisiBahanMakanan
        f_jenisdiet = New frmJenisDiet
        'f_penukar = New frmBahanMakananPenukar
        f_inventaris = New frmInventaris

        'Standar System
        f_imt = New frmFormulaIMT
        f_tinggiLutut = New frmTinggiLutut
        f_energiBasal = New frmEnergiBasal
        f_cukupEnergi = New frmKecukupanEnergi
        f_IMT220 = New frmIMT220
        f_AKG = New frmAKG
        f_AKP = New frmAKP
        f_TebalLemak = New frmKetebalanLemakTubuh
        f_katUmur = New frmKategoryUmur
        f_giziBalita = New frmStatusGiziBalita


        'Chat
        f_chat = New FrmChat
    End Sub
    Private Sub TutupSemuaContent()
        f_bahanMakanan.DockPanel = Nothing
        f_olahJadi.DockPanel = Nothing
        f_detilMakanan.DockPanel = Nothing
        f_layananGizi.DockPanel = Nothing
        'f_layananGizi.SuperTabControlPanel1.Dispose()
        ' f_layananGizi.SuperTabControlPanel2.Dispose()
        'f_layananGizi.SuperTabControl1.Dispose()
        f_menudiet.DockPanel = Nothing
        f_siklusmenu.DockPanel = Nothing
        'Data Referensi
        f_ahligizi.DockPanel = Nothing
        f_nutrisi.DockPanel = Nothing
        f_jenisdiet.DockPanel = Nothing
        'f_penukar.DockPanel = Nothing
        f_inventaris.DockPanel = Nothing

        'Standar System
        f_imt.DockPanel = Nothing
        f_tinggiLutut.DockPanel = Nothing
        f_energiBasal.DockPanel = Nothing
        f_cukupEnergi.DockPanel = Nothing
        f_IMT220.DockPanel = Nothing
        f_AKG.DockPanel = Nothing
        f_AKP.DockPanel = Nothing
        f_TebalLemak.DockPanel = Nothing
        f_katUmur.DockPanel = Nothing
        f_giziBalita.DockPanel = Nothing

        f_chat.DockPanel = Nothing

        TutupSemuaDokumen()

        For Each window In DockPanel.FloatWindows.ToList()
            window.Dispose()
        Next
    End Sub
    Protected Sub SkinButtonKeluar()
        ' Create custom color scheme for the button and register it globaly
        Dim table As DevComponents.DotNetBar.Rendering.Office2007ButtonItemColorTable = New DevComponents.DotNetBar.Rendering.Office2007ButtonItemColorTable()
        table.Name = "MyColorName" ' This is the color table name that we assigned to the CustomColorName property in designer

        ' Define standard colors when mouse is not over the button
        table.Default = New DevComponents.DotNetBar.Rendering.Office2007ButtonItemStateColorTable()
        table.Default.OuterBorder.Start = System.Drawing.Color.Maroon
        table.Default.OuterBorder.End = System.Drawing.Color.OrangeRed
        table.Default.TopBackground.Start = System.Drawing.Color.OrangeRed
        table.Default.TopBackground.End = System.Drawing.Color.OrangeRed
        table.Default.BottomBackground.Start = System.Drawing.Color.OrangeRed
        table.Default.BottomBackground.End = System.Drawing.Color.OrangeRed
        table.Default.BottomBackgroundHighlight.Start = System.Drawing.Color.OrangeRed
        table.Default.BottomBackgroundHighlight.End = System.Drawing.Color.OrangeRed
        table.Default.Text = System.Drawing.Color.OrangeRed

        ' Define colors when mouse is over the button
        table.MouseOver = New DevComponents.DotNetBar.Rendering.Office2007ButtonItemStateColorTable()
        table.MouseOver.OuterBorder.Start = System.Drawing.Color.Yellow
        table.MouseOver.OuterBorder.End = System.Drawing.Color.Orange
        table.MouseOver.TopBackground.Start = System.Drawing.Color.Orange
        table.MouseOver.TopBackground.End = System.Drawing.Color.Orange
        table.MouseOver.BottomBackground.Start = System.Drawing.Color.Orange
        table.MouseOver.BottomBackground.End = System.Drawing.Color.Orange
        table.MouseOver.BottomBackgroundHighlight.Start = System.Drawing.Color.Orange
        table.MouseOver.BottomBackgroundHighlight.End = System.Drawing.Color.Orange
        table.MouseOver.Text = System.Drawing.Color.Orange

        ' Define colors when mouse is pressed
        table.Pressed = New DevComponents.DotNetBar.Rendering.Office2007ButtonItemStateColorTable()
        table.Pressed.OuterBorder.Start = System.Drawing.Color.Maroon
        table.Pressed.OuterBorder.End = System.Drawing.Color.Black
        table.Pressed.TopBackground.Start = System.Drawing.Color.Yellow
        table.Pressed.TopBackground.End = System.Drawing.Color.OrangeRed
        table.Pressed.BottomBackground.Start = System.Drawing.Color.OrangeRed
        table.Pressed.BottomBackground.End = System.Drawing.Color.DarkOrange
        table.Pressed.BottomBackgroundHighlight.Start = System.Drawing.Color.Yellow
        table.Pressed.BottomBackgroundHighlight.End = System.Drawing.Color.Transparent
        table.Pressed.Text = System.Drawing.Color.Maroon

        If TypeOf (DevComponents.DotNetBar.Rendering.GlobalManager.Renderer) Is DevComponents.DotNetBar.Rendering.Office2007Renderer Then
            Dim r As DevComponents.DotNetBar.Rendering.Office2007Renderer = CType(DevComponents.DotNetBar.Rendering.GlobalManager.Renderer, DevComponents.DotNetBar.Rendering.Office2007Renderer)
            r.ColorTable.ButtonItemColors.Add(table)
        End If

        ' Start Button Pulse
        btnKeluarKembali.Pulse(11)
    End Sub
    Public Function GetComputerName() As String
        Dim ComputerName As String
        ComputerName = System.Net.Dns.GetHostName
        Return ComputerName
    End Function
#Region "Thema"
    Private Sub SetSchema(ByVal sender As Object, ByVal e As System.EventArgs)
        ' Dim configFile As String = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "DockPanel.temp.config")
        'DockPanel.SaveAsXml(configFile)
        TutupSemuaContent()

        Dim btn As ToolStripMenuItem = CType(sender, ToolStripMenuItem)


        If btn.Equals(Me.mnu2015Light) Then
            Me.DockPanel.Theme = VS2015LightTheme1

            Me.EnableVSRenderer(VisualStudioToolStripExtender.VsVersion.Vs2015, VS2015LightTheme1)
            'Me.MenuStrip.BackColor = DockPanel.Theme.ColorPalette.MainWindowStatusBarDefault.Background

            'Me.toolBar.BackColor = DockPanel.Theme.ColorPalette.MainWindowStatusBarDefault.Background
            Me.PanelMenu.BackColor = SystemColors.Control 'DockPanel.Theme.ColorPalette.MainWindowStatusBarDefault.Background
            Me.DockPanel.BorderStyle = BorderStyle.None
            Me.Pemisah1.BackColor = DockPanel.Theme.ColorPalette.ToolWindowTabUnselected.Background
        ElseIf btn.Equals(Me.mnu2015Biru) Then
            Me.DockPanel.Theme = VS2015BlueTheme1
            Me.EnableVSRenderer(VisualStudioToolStripExtender.VsVersion.Vs2015, VS2015BlueTheme1)
            Me.PanelMenu.BackColor = DockPanel.Theme.ColorPalette.MainWindowActive.Background
            Me.Pemisah1.BackColor = DockPanel.Theme.ColorPalette.ToolWindowTabUnselected.Background
            Me.DockPanel.BorderStyle = BorderStyle.Fixed3D
        ElseIf btn.Equals(Me.mnu2015Hitam) Then
            Me.DockPanel.Theme = VS2015DarkTheme1
            Me.EnableVSRenderer(VisualStudioToolStripExtender.VsVersion.Vs2015, VS2015DarkTheme1)
            Me.PanelMenu.BackColor = DockPanel.Theme.ColorPalette.MainWindowActive.Background
            Me.DockPanel.BorderStyle = BorderStyle.None
            Me.Pemisah1.BackColor = DockPanel.Theme.ColorPalette.ToolWindowTabUnselected.Background
        End If


        mnu2015Light.Checked = btn.Equals(Me.mnu2015Light)
        mnu2015Hitam.Checked = btn.Equals(Me.mnu2015Hitam)
        mnu2015Biru.Checked = btn.Equals(Me.mnu2015Biru)

        If DockPanel.Theme.ColorPalette IsNot Nothing Then
            StatusStrip1.BackColor = DockPanel.Theme.ColorPalette.MainWindowStatusBarDefault.Background
        End If

        ' If File.Exists(configFile) Then DockPanel.LoadFromXml(configFile, deserial)
    End Sub
    Public Sub EnableVSRenderer(ByVal version As VisualStudioToolStripExtender.VsVersion, ByVal theme As ThemeBase)
        vsRender.SetStyle(MenuStrip, version, theme)
        'vsRender.SetStyle(toolBar, version, theme)
        vsRender.SetStyle(StatusStrip1, version, theme)
    End Sub
    Private Sub mnu2015Light_Click(sender As Object, e As EventArgs) Handles mnu2015Light.Click
        SetSchema(Me.mnu2015Light, Nothing)
    End Sub
    Private Sub mnu2015Biru_Click(sender As Object, e As EventArgs) Handles mnu2015Biru.Click
        SetSchema(Me.mnu2015Biru, Nothing)
    End Sub
    Private Sub mnu2015Hitam_Click(sender As Object, e As EventArgs) Handles mnu2015Hitam.Click
        SetSchema(Me.mnu2015Hitam, Nothing)
    End Sub
#End Region

#Region "Navigasi"
    Protected Sub BukaChat()
        If (f_chat.IsDisposed = True) Then
            f_chat = New FrmChat()
            f_chat.Show(DockPanel, DockState.DockBottomAutoHide)
        Else
            f_chat.Show(DockPanel, DockState.DockBottomAutoHide)
        End If
    End Sub
    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Dim p As String
        p = MsgBox("Apakah anda ingin keluar dari aplikasi?", MsgBoxStyle.YesNo, "Konfimasi")
        If p = vbYes Then
            niPopupStatus.Visible = False
            niPopupStatus.Icon = Nothing
            niPopupStatus.Dispose()
            Application.Exit()
        End If
    End Sub
    Private Sub btnKeluarKembali_Click(sender As Object, e As EventArgs) Handles btnKeluarKembali.Click

        TutupSemuaContent()
        TutupSemuaDokumen()

        If CountNotify <> 0 Then btnMenu4.Number = CountNotify

        If (btnKeluarKembali.Text = "   Kembali") And (btnMenu1.Text = "   Bahan Makanan") Then
            btnMenu1.Text = "   Standar Menu"
            btnMenu2.Text = "   Data Referensi"
            btnMenu3.Text = "   Standar System"
            btnMenu4.Text = "   Pelayanan Gizi"
            btnKeluarKembali.Text = "   Keluar"
        ElseIf (btnKeluarKembali.Text = "   Kembali") And (btnMenu1.Text = "   Siklus Menu Harian") Then
            btnMenu3.Visible = True
            btnMenu4.Visible = True
            btnMenu1.Text = "   Bahan Makanan"
            btnMenu2.Text = "   Makanan Olahan Jadi"
            btnMenu3.Text = "   Menu Diet"
            btnMenu4.Text = "   Siklus Menu"
            btnKeluarKembali.Text = "   Kembali"
        ElseIf (btnKeluarKembali.Text = "   Kembali") And (btnMenu1.Text = "   Data Ahli Gizi / Dokter") Then
            btnMenu3.Visible = True
            btnMenu4.Visible = True
            btnMenu1.Font = New Font("Bauhaus 93", 12)
            btnMenu2.Font = New Font("Bauhaus 93", 12)
            btnMenu3.Font = New Font("Bauhaus 93", 12)
            btnMenu4.Font = New Font("Bauhaus 93", 12)
            btnMenu1.Text = "   Standar Menu"
            btnMenu2.Text = "   Data Referensi"
            btnMenu3.Text = "   Standar System"
            btnMenu4.Text = "   Pelayanan Gizi"
            btnKeluarKembali.Text = "   Keluar"
        ElseIf (btnKeluarKembali.Text = "   Kembali") And (btnMenu1.Text = "   Konversi Tinggi Lutut") Then
            btnMenu1.Font = New Font("Bauhaus 93", 12)
            btnMenu2.Font = New Font("Bauhaus 93", 12)
            btnMenu3.Font = New Font("Bauhaus 93", 12)
            btnMenu4.Font = New Font("Bauhaus 93", 12)
            btnMenu1.Text = "   Standar Menu"
            btnMenu2.Text = "   Data Referensi"
            btnMenu3.Text = "   Standar System"
            btnMenu4.Text = "   Pelayanan Gizi"
            btnMenu5.Visible = False
            btnMenu6.Visible = False
            btnMenu7.Visible = False
            btnMenu8.Visible = False
            btnMenu9.Visible = False
            btnMenu10.Visible = False
            btnKeluarKembali.Text = "   Keluar"
        ElseIf btnKeluarKembali.Text = "   Keluar" Then
            Dim p As String
            p = MsgBox("Apakah anda ingin keluar dari aplikasi?", MsgBoxStyle.YesNo, "Konfimasi")
            If p = vbYes Then
                If client.Client.Connected = True Then
                    client.Client.Shutdown(SocketShutdown.Both)
                    'client.GetStream.Close()

                    client.Client.Close()
                    client.Close()
                    Application.ExitThread()
                Else
                    Application.Exit()
                End If

            End If
        End If

    End Sub
    Private Sub btnMenu1_Click(sender As Object, e As EventArgs) Handles btnMenu1.Click
        btnMenu4.Number = 0
        If btnMenu1.Text = "   Standar Menu" Then
            btnMenu1.Text = "   Bahan Makanan"
            btnMenu2.Text = "   Makanan Olahan Jadi"
            btnMenu3.Text = "   Menu Diet"
            btnMenu4.Text = "   Siklus Menu"
            btnKeluarKembali.Text = "   Kembali"
        ElseIf btnMenu1.Text = "   Siklus Menu Harian" Then
            MsgBox("Open Siklus Menu Harian")
            btnKeluarKembali.Text = "   Kembali"
        ElseIf btnMenu1.Text = "   Data Ahli Gizi / Dokter" Then
            If (f_ahligizi.IsDisposed = True) Then
                f_ahligizi = New frmDataAhliGizi()
                f_ahligizi.Show(DockPanel)
            Else
                f_ahligizi.Show(DockPanel)
            End If
            btnKeluarKembali.Text = "   Kembali"
        ElseIf btnMenu1.Text = "   Bahan Makanan" Then
            If (f_bahanMakanan.IsDisposed = True) Then
                f_bahanMakanan = New frmBahanMakanan()
                f_bahanMakanan.Show(DockPanel)
            Else
                f_bahanMakanan.Show(DockPanel)
            End If
        ElseIf btnMenu1.Text = "   Konversi Tinggi Lutut" Then
            If (f_tinggiLutut.IsDisposed = True) Then
                f_tinggiLutut = New frmTinggiLutut()
                f_tinggiLutut.Show(DockPanel)
            Else
                f_tinggiLutut.Show(DockPanel)
            End If
            btnKeluarKembali.Text = "   Kembali"
        End If
    End Sub
    Private Sub btnMenu2_Click(sender As Object, e As EventArgs) Handles btnMenu2.Click
        btnMenu4.Number = 0
        If btnMenu2.Text = "   Makanan Olahan Jadi" Then
            If (f_olahJadi.IsDisposed = True) Then
                f_olahJadi = New frmMakananOlahanJadi()
                f_olahJadi.Show(DockPanel)
            Else
                f_olahJadi.Show(DockPanel)
            End If
        ElseIf btnMenu2.Text = "   Data Referensi" Then
            btnMenu1.Font = New Font("Bauhaus 93", 9)
            btnMenu2.Font = New Font("Bauhaus 93", 9)
            btnMenu3.Font = New Font("Bauhaus 93", 9)
            btnMenu4.Font = New Font("Bauhaus 93", 9)
            btnMenu1.Text = "   Data Ahli Gizi / Dokter"
            btnMenu2.Text = "   Data Nutrisi Bahan Makanan"
            btnMenu3.Text = "   Data Jenis Diet"
            btnMenu4.Text = "   Data Inventaris"
            btnKeluarKembali.Text = "   Kembali"
        ElseIf btnMenu2.Text = "   Siklus Menu Diet Harian" Then
            MsgBox("Open Siklus Menu Diet Harian")
            btnKeluarKembali.Text = "   Kembali"
        ElseIf btnMenu2.Text = "   Data Nutrisi Bahan Makanan" Then
            If (f_nutrisi.IsDisposed = True) Then
                f_nutrisi = New frmNutrisiBahanMakanan()
                f_nutrisi.Show(DockPanel)
            Else
                f_nutrisi.Show(DockPanel)
            End If
            btnKeluarKembali.Text = "   Kembali"
        ElseIf btnMenu2.Text = "   Formula IMT" Then
            If (f_imt.IsDisposed = True) Then
                f_imt = New frmFormulaIMT()
                f_imt.Show(DockPanel)
            Else
                f_imt.Show(DockPanel)
            End If
            btnKeluarKembali.Text = "   Kembali"

        End If
    End Sub
    Private Sub btnMenu3_Click(sender As Object, e As EventArgs) Handles btnMenu3.Click
        btnMenu4.Number = 0
        If btnMenu3.Text = "   Menu Diet" Then
            If (f_menudiet.IsDisposed = True) Then
                f_menudiet = New frmDiet()
                f_menudiet.Show(DockPanel)
            Else
                f_menudiet.Show(DockPanel)
            End If
            btnKeluarKembali.Text = "   Kembali"

        ElseIf btnMenu3.Text = "   Standar System" Then
            btnMenu1.Font = New Font("Bauhaus 93", 9)
            btnMenu2.Font = New Font("Bauhaus 93", 9)
            btnMenu3.Font = New Font("Bauhaus 93", 9)
            btnMenu4.Font = New Font("Bauhaus 93", 9)
            btnMenu1.Text = "   Konversi Tinggi Lutut"
            btnMenu2.Text = "   Formula IMT"
            btnMenu3.Text = "   Formula IMT 2-20 Tahun"
            btnMenu4.Text = "   Formula Kebutuhan Energi Basal"
            btnMenu5.Visible = True
            btnMenu6.Visible = True
            btnMenu7.Visible = True
            btnMenu8.Visible = True
            btnMenu9.Visible = True
            btnMenu10.Visible = True
            btnKeluarKembali.Text = "   Kembali"
        ElseIf btnMenu3.Text = "   Data Jenis Diet" Then
            If (f_jenisdiet.IsDisposed = True) Then
                f_jenisdiet = New frmJenisDiet()
                f_jenisdiet.Show(DockPanel)
            Else
                f_jenisdiet.Show(DockPanel)
            End If
            btnKeluarKembali.Text = "   Kembali"
        ElseIf btnMenu3.Text = "   Formula IMT 2-20 Tahun" Then
            If (f_IMT220.IsDisposed = True) Then
                f_IMT220 = New frmIMT220()
                f_IMT220.Show(DockPanel)
            Else
                f_IMT220.Show(DockPanel)
            End If
            btnKeluarKembali.Text = "   Kembali"
        End If

    End Sub
    Private Sub btnMenu4_Click(sender As Object, e As EventArgs) Handles btnMenu4.Click

        If btnMenu4.Text = "   Pelayanan Gizi" Then
            If (f_layananGizi.IsDisposed = True) Then
                f_layananGizi = New frmPelayananGizi()
                f_layananGizi.Show(DockPanel)
                ResetCountNotifikasi()
                f_layananGizi.btnRefresh.PerformClick()
            Else
                f_layananGizi.Show(DockPanel)
                ResetCountNotifikasi()
                f_layananGizi.btnRefresh.PerformClick()
            End If
            btnKeluarKembali.Text = "   Keluar"
        ElseIf btnMenu4.Text = "   Formula Kebutuhan Energi Basal" Then
            If (f_energiBasal.IsDisposed = True) Then
                f_energiBasal = New frmEnergiBasal()
                f_energiBasal.Show(DockPanel)
                btnMenu4.Number = 0
            Else
                f_energiBasal.Show(DockPanel)
                btnMenu4.Number = 0
            End If
            btnKeluarKembali.Text = "   Kembali"

        ElseIf btnMenu4.Text = "   Siklus Menu" Then
            'btnMenu1.Text = "   Siklus Menu Harian"
            'btnMenu2.Text = "   Siklus Menu Diet Harian"
            ' btnMenu3.Visible = False
            'btnMenu4.Visible = False
            If (f_siklusmenu.IsDisposed = True) Then
                f_siklusmenu = New frmSiklusMenu()
                f_siklusmenu.Show(DockPanel)
                btnMenu4.Number = 0
            Else
                f_siklusmenu.Show(DockPanel)
                btnMenu4.Number = 0
            End If
            btnKeluarKembali.Text = "   Kembali"

        ElseIf btnMenu4.Text = "   Data Inventaris" Then
            If (f_inventaris.IsDisposed = True) Then
                f_inventaris = New frmInventaris()
                f_inventaris.Show(DockPanel)
                btnMenu4.Number = 0
            Else
                f_inventaris.Show(DockPanel)
                btnMenu4.Number = 0
            End If
            btnKeluarKembali.Text = "   Kembali"
        End If
    End Sub
    Private Sub btnMenu5_Click(sender As Object, e As EventArgs) Handles btnMenu5.Click
        btnMenu4.Number = 0
        If btnMenu5.Text = "   Formula Angka Kecukupan Energi" Then
            If (f_cukupEnergi.IsDisposed = True) Then
                f_cukupEnergi = New frmKecukupanEnergi()
                f_cukupEnergi.Show(DockPanel)
            Else
                f_cukupEnergi.Show(DockPanel)
            End If

            btnKeluarKembali.Text = "   Kembali"
        End If
    End Sub
    Private Sub btnMenu6_Click(sender As Object, e As EventArgs) Handles btnMenu6.Click
        btnMenu4.Number = 0
        '  If btnMenu6.Text = "   Angka Kecukupan Gizi" Then
        If (f_AKG.IsDisposed = True) Then
            f_AKG = New frmAKG()
            f_AKG.Show(DockPanel)
        Else
            f_AKG.Show(DockPanel)
        End If

        btnKeluarKembali.Text = "   Kembali"
        'End If
    End Sub
    Private Sub btnMenu7_Click(sender As Object, e As EventArgs) Handles btnMenu7.Click
        btnMenu4.Number = 0
        'If btnMenu7.Text = "   Angka Kebutuhan Protein" Then
        If (f_AKP.IsDisposed = True) Then
            f_AKP = New frmAKP()
            f_AKP.Show(DockPanel)
        Else
            f_AKP.Show(DockPanel)
        End If

        btnKeluarKembali.Text = "   Kembali"
        'End If
    End Sub
    Private Sub btnMenu8_Click(sender As Object, e As EventArgs) Handles btnMenu8.Click
        btnMenu4.Number = 0
        If (f_TebalLemak.IsDisposed = True) Then
            f_TebalLemak = New frmKetebalanLemakTubuh()
            f_TebalLemak.Show(DockPanel)
        Else
            f_TebalLemak.Show(DockPanel)
        End If

        btnKeluarKembali.Text = "   Kembali"
    End Sub
    Private Sub btnMenu9_Click(sender As Object, e As EventArgs) Handles btnMenu9.Click
        btnMenu4.Number = 0
        If (f_katUmur.IsDisposed = True) Then
            f_katUmur = New frmKategoryUmur()
            f_katUmur.Show(DockPanel)
        Else
            f_katUmur.Show(DockPanel)
        End If

        btnKeluarKembali.Text = "   Kembali"
    End Sub
    Private Sub btnMenu10_Click(sender As Object, e As EventArgs) Handles btnMenu10.Click
        btnMenu4.Number = 0
        If (f_giziBalita.IsDisposed = True) Then
            f_giziBalita = New frmStatusGiziBalita()
            f_giziBalita.Show(DockPanel)
        Else
            f_giziBalita.Show(DockPanel)
        End If

        btnKeluarKembali.Text = "   Kembali"
    End Sub
#End Region
    Dim hitungMundur As Date ' As New TimeSpan()
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim waktuTersisa As TimeSpan = hitungMundur.Subtract(Now)
        waktuTersisa = New TimeSpan(0, waktuTersisa.Minutes, waktuTersisa.Seconds)

        'ButtonX1.Text = waktuTersisa.ToString
        'ButtonX1.Font = New Font("Bauhaus 93", 25)

        If waktuTersisa.TotalSeconds < 0 Then waktuTersisa = TimeSpan.Zero


        If waktuTersisa.TotalSeconds < 10 And waktuTersisa.TotalSeconds >= 1 Then
            FlashWindow.Flash(Me, 5)
            mnu2015Hitam.PerformClick()
        ElseIf waktuTersisa.TotalSeconds < 1 Or waktuTersisa.TotalSeconds = 0 Then

            FlashWindow.Stop(Me)
            mnu2015Light.PerformClick()
            'ButtonX1.Text = "Waktu Menunggu Permintaan Habis"
            'ButtonX1.Font = New Font("Bauhaus 93", 11)
            ' SQLDependencies()
        End If
    End Sub
    Private Sub niPopupStatus_BalloonTipClicked(sender As Object, e As EventArgs) Handles niPopupStatus.BalloonTipClicked
        Me.tmrAutoRefresh.Enabled = False
        ResetCountNotifikasi()
        TutupSemuaContent()
        TutupSemuaDokumen()

        If Not btnMenu4.Text = "   Pelayanan Gizi" Then
            btnMenu1.Text = "   Standar Menu"
            btnMenu2.Text = "   Data Referensi"
            btnMenu3.Text = "   Standar System"
            btnMenu4.Text = "   Pelayanan Gizi"
            btnKeluarKembali.Text = "   Keluar"
            btnMenu5.Visible = False
            btnMenu6.Visible = False
            btnMenu7.Visible = False
            btnMenu8.Visible = False
            btnMenu9.Visible = False
            btnMenu10.Visible = False
            If (f_layananGizi.IsDisposed = True) Then
                f_layananGizi = New frmPelayananGizi()
                f_layananGizi.Show(DockPanel)
                dtMinta = minta.NoPermintaan
                bsMinta.DataSource = dtMinta
                bsMinta.Sort = "tglPermintaan"
                f_layananGizi.permintaanNavigator.BindingSource = bsMinta
                f_layananGizi.dgvPermintaan.DataSource = bsMinta
                'f_layananGizi.dgvPermintaan.AutoGenerateColumns = False

            Else
                f_layananGizi.Show(DockPanel)
                dtMinta = minta.NoPermintaan
                bsMinta.DataSource = dtMinta
                bsMinta.Sort = "tglPermintaan"
                f_layananGizi.permintaanNavigator.BindingSource = bsMinta
                f_layananGizi.dgvPermintaan.DataSource = bsMinta
                'f_layananGizi.dgvPermintaan.AutoGenerateColumns = False
            End If
        Else
            If (f_layananGizi.IsDisposed = True) Then
                f_layananGizi = New frmPelayananGizi()
                f_layananGizi.Show(DockPanel)
                dtMinta = minta.NoPermintaan
                bsMinta.DataSource = dtMinta
                bsMinta.Sort = "tglPermintaan"
                f_layananGizi.permintaanNavigator.BindingSource = bsMinta
                f_layananGizi.dgvPermintaan.DataSource = bsMinta
                ' f_layananGizi.dgvPermintaan.AutoGenerateColumns = False
            Else
                f_layananGizi.Show(DockPanel)
                dtMinta = minta.NoPermintaan
                bsMinta.DataSource = dtMinta
                bsMinta.Sort = "tglPermintaan"
                f_layananGizi.permintaanNavigator.BindingSource = bsMinta
                f_layananGizi.dgvPermintaan.DataSource = bsMinta
                'f_layananGizi.SuperTabControl1.SelectedTab = f_layananGizi.TabPermintaan
                ' f_layananGizi.dgvPermintaan.AutoGenerateColumns = False
            End If
        End If
    End Sub
    Private Sub tmrAutoRefresh_Tick(sender As Object, e As EventArgs) Handles tmrAutoRefresh.Tick

        If f_layananGizi.IsActivated = True Then
            dtMinta = minta.NoPermintaan
            bsMinta.DataSource = dtMinta
            bsMinta.Sort = "tglPermintaan"
            f_layananGizi.permintaanNavigator.BindingSource = bsMinta
            f_layananGizi.dgvPermintaan.DataSource = bsMinta
            'MsgBox("0")
        ElseIf f_layananGizi.Focus = True Then
            dtMinta = minta.NoPermintaan
            bsMinta.DataSource = dtMinta
            bsMinta.Sort = "tglPermintaan"
            f_layananGizi.permintaanNavigator.BindingSource = bsMinta
            f_layananGizi.dgvPermintaan.DataSource = bsMinta
            'f_layananGizi.SuperTabControl1.SelectedTabIndex = 0
            btnMenu4.Number = Nothing
            UnfocusTabPelayananGizi()

        ElseIf f_layananGizi.Focus = False Then
            UnfocusTabPelayananGizi()
        End If
    End Sub
    Private Sub niPopupStatus_BalloonTipClosed(sender As Object, e As EventArgs) Handles niPopupStatus.BalloonTipClosed
        Me.tmrAutoRefresh.Enabled = False
    End Sub
    Private Sub niPopupStatus_BalloonTipShown(sender As Object, e As EventArgs) Handles niPopupStatus.BalloonTipShown
        Me.tmrAutoRefresh.Enabled = True
    End Sub
    Protected Overloads Overrides Sub WndProc(ByRef m As Message)
        'Define DoubleClick...
        Const WM_NCLBUTTONDBLCLK As Integer = &HA3


        If (m.Msg = WM_NCLBUTTONDBLCLK) Then
            Exit Sub
        End If
        MyBase.WndProc(m)
    End Sub
    Private Sub MenuUtama_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        niPopupStatus.Visible = False
        niPopupStatus.Icon = Nothing
        niPopupStatus.Dispose()
        Application.Exit()
    End Sub
#Region "Dependencies"
    Public Sub SQLDependencies()
        'Dim commandDeptEmp As MySqlCommand = New MySqlCommand("SELECT t_permintaan.KDPERMINTAAN FROM t_permintaan", connection)
        connectionDevart.LocalFailover = True
        connectionDevart.Open()
        Dim cmd As MySqlCommand = New MySqlCommand("SELECT t_permintaan.KDPERMINTAAN FROM t_permintaan", connectionDevart)
        Dim depend As MySqlDependency = New MySqlDependency(cmd, 100)
        'depend.OnChange += New Devart.Data.MySql.OnChangeEventHandler(AddressOf depend_OnChange)
        AddHandler depend.OnChange, New OnChangeEventHandler(AddressOf dependency_OnChange)
        MySqlDependency.Start(connectionDevart)

    End Sub
    Private Sub dependency_OnChange(ByVal sender As Object, ByVal e As Devart.Data.MySql.MySqlTableChangeEventArgs)
        CountNotify += 1
        btnMenu4.Number = CountNotify
        CreateTextIcon(CountNotify)
        niPopupStatus.BalloonTipText = "Ada " & CountNotify & " permintaan baru untuk di lihat."
        niPopupStatus.BalloonTipTitle = niPopupStatus.Text ' & batteryCharge.ToString() & "% " & status.PowerLineStatus.ToString()
        niPopupStatus.ShowBalloonTip(100)
    End Sub
    Public Sub StopDependent()
        MySqlDependency.Stop(con)
    End Sub
    Public Sub StartDependent()
        Dim Durasi As TimeSpan = TimeSpan.FromMinutes(1)
        hitungMundur = Now.Add(Durasi)
        Timer1.Start()
    End Sub
    Private Sub ctxExit_Click(sender As Object, e As EventArgs) Handles ctxExit.Click
        End
    End Sub
#End Region
#Region "Notif Text"
    Protected Sub ResetCountNotifikasi()
        CountNotify = 0
        btnMenu4.Number = Nothing
        niPopupStatus.Icon = My.Resources.Nutri2
    End Sub
    Public Sub CreateTextIcon(ByVal str As String)
        'Dim rnd As New Random
        'Dim random_Color As New Color
        'random_Color = Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255))

        Dim fontToUse As Font = New Font("Tahoma", 16, FontStyle.Regular, GraphicsUnit.Pixel)
        Dim brushToUse As Brush = New SolidBrush(Color.White)
        Dim bitmapText As Bitmap = New Bitmap(16, 16)
        Dim g As Graphics = System.Drawing.Graphics.FromImage(bitmapText)
        Dim hIcon As IntPtr

        g.Clear(Color.Transparent)
        g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit
        g.DrawString(str, fontToUse, brushToUse, -4, -2)
        hIcon = (bitmapText.GetHicon())
        niPopupStatus.Icon = System.Drawing.Icon.FromHandle(hIcon)

        'Win32.DestroyIcon(hIcon.ToInt32)
    End Sub
#End Region
#Region "Notification Focus"
    Private Sub UnfocusTabPelayananGizi()
        f_bahanMakanan.Dispose()
        f_olahJadi.Dispose()
        f_detilMakanan.Dispose()
        f_menudiet.Dispose()
        f_siklusmenu.Dispose()
        f_ahligizi.Dispose()
        f_nutrisi.Dispose()
        f_jenisdiet.Dispose()
        f_inventaris.Dispose()
        f_imt.Dispose()
        f_tinggiLutut.Dispose()
        f_energiBasal.Dispose()
        f_cukupEnergi.Dispose()
        f_IMT220.Dispose()
        f_AKG.Dispose()
        f_AKP.Dispose()
        f_TebalLemak.Dispose()
        f_katUmur.Dispose()
        f_giziBalita.Dispose()

        If btnMenu5.Visible = True Then
            btnMenu5.Visible = False
            btnMenu6.Visible = False
            btnMenu7.Visible = False
            btnMenu8.Visible = False
            btnMenu9.Visible = False
            btnMenu10.Visible = False
        End If

        btnMenu1.Font = New Font("Bauhaus 93", 12)
        btnMenu2.Font = New Font("Bauhaus 93", 12)
        btnMenu3.Font = New Font("Bauhaus 93", 12)
        btnMenu4.Font = New Font("Bauhaus 93", 12)
        btnMenu1.Text = "   Standar Menu"
        btnMenu2.Text = "   Data Referensi"
        btnMenu3.Text = "   Standar System"
        btnMenu4.Text = "   Pelayanan Gizi"
        btnKeluarKembali.Text = "   Keluar"
    End Sub
    Private Sub MenuUtama_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        niPopupStatus.Visible = False
        niPopupStatus.Icon = Nothing
        niPopupStatus.Dispose()
        Application.Exit()
    End Sub
#End Region
    Private Sub lblDate_TextChanged(sender As Object, e As EventArgs) Handles lblDate.TextChanged
        ResetCountNotifikasi()
        If serverStatus = "Online" Then
            EnableWhenOnline()
        ElseIf serverStatus = "Offline" Then
            DisableWhenOffline()
        End If
    End Sub
    Protected Sub DisableWhenOffline()
        btnMenu1.Enabled = False
        btnMenu2.Enabled = False
        btnMenu3.Enabled = False
        btnMenu4.Enabled = False
        btnMenu4.Number = Nothing
        btnMenu5.Enabled = False
        btnMenu6.Enabled = False
        btnMenu7.Enabled = False
        btnMenu8.Enabled = False
        btnMenu9.Enabled = False
        btnMenu10.Enabled = False
        Me.Pemisah1.ToggleState()
        Me.toolBarButtonToggle1.Pushed = Me.Pemisah1.IsCollapsed
    End Sub
    Protected Sub EnableWhenOnline()
        btnMenu1.Enabled = True
        btnMenu2.Enabled = True
        btnMenu3.Enabled = True
        btnMenu4.Enabled = True
        btnMenu5.Enabled = True
        btnMenu6.Enabled = True
        btnMenu7.Enabled = True
        btnMenu8.Enabled = True
        btnMenu9.Enabled = True
        btnMenu10.Enabled = True

        If Pemisah1.IsCollapsed Then
            Me.Pemisah1.ToggleState()
            Me.toolBarButtonToggle1.Pushed = Me.Pemisah1.IsCollapsed
        Else
            Exit Sub
        End If
    End Sub
#Region "Collapsed"
    Private Sub Pemisah1_Click(sender As Object, e As EventArgs) Handles Pemisah1.Click
        serverStatus = Pemisah1.IsCollapsed
    End Sub
    Private Sub toolBar_ButtonClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles toolBar.ButtonClick
        Select Case toolBar.Buttons.IndexOf(e.Button)
            Case 0
                Me.Pemisah1.ToggleState()
                Me.toolBarButtonToggle1.Pushed = Me.Pemisah1.IsCollapsed
        End Select
    End Sub
#End Region
    Private Sub MenuUtama_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        niPopupStatus.Visible = False
        niPopupStatus.Dispose()
        niPopupStatus.Icon = Nothing
        Application.Exit()
    End Sub
    Private Sub MenuUtama_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        niPopupStatus.Visible = False
        niPopupStatus.Dispose()
        niPopupStatus.Icon = Nothing
        Application.Exit()
    End Sub
    Private Sub MenuUtama_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        niPopupStatus.Visible = False
        niPopupStatus.Dispose()
        niPopupStatus.Icon = Nothing
        Application.Exit()
    End Sub
End Class