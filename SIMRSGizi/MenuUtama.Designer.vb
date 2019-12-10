<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuUtama
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuUtama))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTheme = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu2015Light = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu2015Biru = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu2015Hitam = New System.Windows.Forms.ToolStripMenuItem()
        Me.vsRender = New WeifenLuo.WinFormsUI.Docking.VisualStudioToolStripExtender(Me.components)
        Me.VS2015LightTheme1 = New WeifenLuo.WinFormsUI.Docking.VS2015LightTheme()
        Me.VS2015DarkTheme1 = New WeifenLuo.WinFormsUI.Docking.VS2015DarkTheme()
        Me.VS2015BlueTheme1 = New WeifenLuo.WinFormsUI.Docking.VS2015BlueTheme()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblNamaKomputer = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblDate = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Pemisah1 = New NJFLib.Controls.CollapsibleSplitter()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.btnMenu4 = New SIMRSGizi.NotiButton()
        Me.btnMenu10 = New DevComponents.DotNetBar.ButtonX()
        Me.btnMenu9 = New DevComponents.DotNetBar.ButtonX()
        Me.btnMenu8 = New DevComponents.DotNetBar.ButtonX()
        Me.btnMenu7 = New DevComponents.DotNetBar.ButtonX()
        Me.btnMenu6 = New DevComponents.DotNetBar.ButtonX()
        Me.btnMenu5 = New DevComponents.DotNetBar.ButtonX()
        Me.btnMenu3 = New DevComponents.DotNetBar.ButtonX()
        Me.btnMenu2 = New DevComponents.DotNetBar.ButtonX()
        Me.btnMenu1 = New DevComponents.DotNetBar.ButtonX()
        Me.DockPanel = New WeifenLuo.WinFormsUI.Docking.DockPanel()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnKeluarKembali = New DevComponents.DotNetBar.ButtonX()
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.niPopupStatus = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ctxNotify = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ctxExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmrAutoRefresh = New System.Windows.Forms.Timer(Me.components)
        Me.toolBar = New System.Windows.Forms.ToolBar()
        Me.toolBarButtonToggle1 = New System.Windows.Forms.ToolBarButton()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.PanelMenu.SuspendLayout()
        Me.PanelEx1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.ctxNotify.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KeluarToolStripMenuItem, Me.mnuTheme})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip.Size = New System.Drawing.Size(746, 24)
        Me.MenuStrip.TabIndex = 12
        Me.MenuStrip.Visible = False
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.KeluarToolStripMenuItem.Text = "Keluar"
        '
        'mnuTheme
        '
        Me.mnuTheme.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu2015Light, Me.mnu2015Biru, Me.mnu2015Hitam})
        Me.mnuTheme.Name = "mnuTheme"
        Me.mnuTheme.Size = New System.Drawing.Size(42, 20)
        Me.mnuTheme.Text = "Skin"
        '
        'mnu2015Light
        '
        Me.mnu2015Light.Name = "mnu2015Light"
        Me.mnu2015Light.Size = New System.Drawing.Size(126, 22)
        Me.mnu2015Light.Text = "Abu - Abu"
        '
        'mnu2015Biru
        '
        Me.mnu2015Biru.Name = "mnu2015Biru"
        Me.mnu2015Biru.Size = New System.Drawing.Size(126, 22)
        Me.mnu2015Biru.Text = "Biru"
        '
        'mnu2015Hitam
        '
        Me.mnu2015Hitam.Name = "mnu2015Hitam"
        Me.mnu2015Hitam.Size = New System.Drawing.Size(126, 22)
        Me.mnu2015Hitam.Text = "Hitam"
        '
        'vsRender
        '
        Me.vsRender.DefaultRenderer = Nothing
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblNamaKomputer, Me.lblDate})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 727)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(746, 22)
        Me.StatusStrip1.TabIndex = 13
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblNamaKomputer
        '
        Me.lblNamaKomputer.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNamaKomputer.Name = "lblNamaKomputer"
        Me.lblNamaKomputer.Size = New System.Drawing.Size(100, 17)
        Me.lblNamaKomputer.Text = "Nama Komputer :"
        '
        'lblDate
        '
        Me.lblDate.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner
        Me.lblDate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.lblDate.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(631, 17)
        Me.lblDate.Spring = True
        Me.lblDate.Text = "ToolStripStatusLabel1"
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Pemisah1
        '
        Me.Pemisah1.AnimationDelay = 500
        Me.Pemisah1.AnimationStep = 50
        Me.Pemisah1.BorderStyle3D = System.Windows.Forms.Border3DStyle.Flat
        Me.Pemisah1.ControlToHide = Me.PanelMenu
        Me.Pemisah1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Pemisah1.ExpandParentForm = True
        Me.Pemisah1.Location = New System.Drawing.Point(537, 71)
        Me.Pemisah1.MinExtra = 20
        Me.Pemisah1.MinSize = 20
        Me.Pemisah1.Name = "CollapsibleSplitter1"
        Me.Pemisah1.TabIndex = 19
        Me.Pemisah1.TabStop = False
        Me.Pemisah1.UseAnimations = True
        Me.Pemisah1.VisualStyle = NJFLib.Controls.VisualStyles.Mozilla
        '
        'PanelMenu
        '
        Me.PanelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelMenu.Controls.Add(Me.btnMenu4)
        Me.PanelMenu.Controls.Add(Me.btnMenu10)
        Me.PanelMenu.Controls.Add(Me.btnMenu9)
        Me.PanelMenu.Controls.Add(Me.btnMenu8)
        Me.PanelMenu.Controls.Add(Me.btnMenu7)
        Me.PanelMenu.Controls.Add(Me.btnMenu6)
        Me.PanelMenu.Controls.Add(Me.btnMenu5)
        Me.PanelMenu.Controls.Add(Me.btnMenu3)
        Me.PanelMenu.Controls.Add(Me.btnMenu2)
        Me.PanelMenu.Controls.Add(Me.btnMenu1)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelMenu.Location = New System.Drawing.Point(545, 71)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(201, 656)
        Me.PanelMenu.TabIndex = 18
        '
        'btnMenu4
        '
        Me.btnMenu4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnMenu4.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnMenu4.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnMenu4.Font = New System.Drawing.Font("Bauhaus 93", 12.0!)
        Me.btnMenu4.Location = New System.Drawing.Point(0, 522)
        Me.btnMenu4.Name = "btnMenu4"
        Me.btnMenu4.Number = 0
        Me.btnMenu4.Size = New System.Drawing.Size(199, 58)
        Me.btnMenu4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnMenu4.TabIndex = 0
        Me.btnMenu4.Text = "   Pelayanan Gizi"
        Me.btnMenu4.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left
        '
        'btnMenu10
        '
        Me.btnMenu10.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnMenu10.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnMenu10.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnMenu10.Font = New System.Drawing.Font("Bauhaus 93", 9.0!)
        Me.btnMenu10.Location = New System.Drawing.Point(0, 464)
        Me.btnMenu10.Name = "btnMenu10"
        Me.btnMenu10.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor()
        Me.btnMenu10.Size = New System.Drawing.Size(199, 58)
        Me.btnMenu10.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnMenu10.TabIndex = 52
        Me.btnMenu10.Text = "   Status Gizi Balita"
        Me.btnMenu10.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left
        Me.btnMenu10.Visible = False
        '
        'btnMenu9
        '
        Me.btnMenu9.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnMenu9.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnMenu9.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnMenu9.Font = New System.Drawing.Font("Bauhaus 93", 9.0!)
        Me.btnMenu9.Location = New System.Drawing.Point(0, 406)
        Me.btnMenu9.Name = "btnMenu9"
        Me.btnMenu9.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor()
        Me.btnMenu9.Size = New System.Drawing.Size(199, 58)
        Me.btnMenu9.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnMenu9.TabIndex = 51
        Me.btnMenu9.Text = "   Kategori Umur"
        Me.btnMenu9.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left
        Me.btnMenu9.Visible = False
        '
        'btnMenu8
        '
        Me.btnMenu8.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnMenu8.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnMenu8.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnMenu8.Font = New System.Drawing.Font("Bauhaus 93", 9.0!)
        Me.btnMenu8.Location = New System.Drawing.Point(0, 348)
        Me.btnMenu8.Name = "btnMenu8"
        Me.btnMenu8.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor()
        Me.btnMenu8.Size = New System.Drawing.Size(199, 58)
        Me.btnMenu8.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnMenu8.TabIndex = 50
        Me.btnMenu8.Text = "   Ketebalan Lemak Tubuh"
        Me.btnMenu8.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left
        Me.btnMenu8.Visible = False
        '
        'btnMenu7
        '
        Me.btnMenu7.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnMenu7.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnMenu7.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnMenu7.Font = New System.Drawing.Font("Bauhaus 93", 9.0!)
        Me.btnMenu7.Location = New System.Drawing.Point(0, 290)
        Me.btnMenu7.Name = "btnMenu7"
        Me.btnMenu7.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor()
        Me.btnMenu7.Size = New System.Drawing.Size(199, 58)
        Me.btnMenu7.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnMenu7.TabIndex = 49
        Me.btnMenu7.Text = "   Angka Kebutuhan Protein" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnMenu7.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left
        Me.btnMenu7.Visible = False
        '
        'btnMenu6
        '
        Me.btnMenu6.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnMenu6.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnMenu6.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnMenu6.Font = New System.Drawing.Font("Bauhaus 93", 9.0!)
        Me.btnMenu6.Location = New System.Drawing.Point(0, 232)
        Me.btnMenu6.Name = "btnMenu6"
        Me.btnMenu6.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor()
        Me.btnMenu6.Size = New System.Drawing.Size(199, 58)
        Me.btnMenu6.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnMenu6.TabIndex = 48
        Me.btnMenu6.Text = "   Angka Kecukupan Gizi"
        Me.btnMenu6.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left
        Me.btnMenu6.Visible = False
        '
        'btnMenu5
        '
        Me.btnMenu5.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnMenu5.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnMenu5.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnMenu5.Font = New System.Drawing.Font("Bauhaus 93", 9.0!)
        Me.btnMenu5.Location = New System.Drawing.Point(0, 174)
        Me.btnMenu5.Name = "btnMenu5"
        Me.btnMenu5.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor()
        Me.btnMenu5.Size = New System.Drawing.Size(199, 58)
        Me.btnMenu5.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnMenu5.TabIndex = 41
        Me.btnMenu5.Text = "   Formula Angka Kecukupan Energi"
        Me.btnMenu5.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left
        Me.btnMenu5.Visible = False
        '
        'btnMenu3
        '
        Me.btnMenu3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnMenu3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnMenu3.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnMenu3.Font = New System.Drawing.Font("Bauhaus 93", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenu3.Location = New System.Drawing.Point(0, 116)
        Me.btnMenu3.Name = "btnMenu3"
        Me.btnMenu3.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor()
        Me.btnMenu3.Size = New System.Drawing.Size(199, 58)
        Me.btnMenu3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnMenu3.TabIndex = 39
        Me.btnMenu3.Text = "   Standar System"
        Me.btnMenu3.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left
        '
        'btnMenu2
        '
        Me.btnMenu2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnMenu2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnMenu2.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnMenu2.Font = New System.Drawing.Font("Bauhaus 93", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenu2.Location = New System.Drawing.Point(0, 58)
        Me.btnMenu2.Name = "btnMenu2"
        Me.btnMenu2.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor()
        Me.btnMenu2.Size = New System.Drawing.Size(199, 58)
        Me.btnMenu2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnMenu2.TabIndex = 38
        Me.btnMenu2.Text = "   Data Referensi"
        Me.btnMenu2.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left
        '
        'btnMenu1
        '
        Me.btnMenu1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnMenu1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnMenu1.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnMenu1.FadeEffect = False
        Me.btnMenu1.Font = New System.Drawing.Font("Bauhaus 93", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenu1.Location = New System.Drawing.Point(0, 0)
        Me.btnMenu1.Name = "btnMenu1"
        Me.btnMenu1.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor()
        Me.btnMenu1.Size = New System.Drawing.Size(199, 58)
        Me.btnMenu1.TabIndex = 37
        Me.btnMenu1.Text = "   Bahan Makanan"
        Me.btnMenu1.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left
        '
        'DockPanel
        '
        Me.DockPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DockPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DockPanel.DockBackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.DockPanel.Location = New System.Drawing.Point(0, 71)
        Me.DockPanel.Name = "DockPanel"
        Me.DockPanel.Padding = New System.Windows.Forms.Padding(6)
        Me.DockPanel.RightToLeftLayout = True
        Me.DockPanel.ShowAutoHideContentOnHover = False
        Me.DockPanel.Size = New System.Drawing.Size(545, 656)
        Me.DockPanel.SupportDeeplyNestedContent = True
        Me.DockPanel.TabIndex = 17
        Me.DockPanel.Theme = Me.VS2015BlueTheme1
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.Panel2)
        Me.PanelEx1.Controls.Add(Me.btnKeluarKembali)
        Me.PanelEx1.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(746, 71)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 7
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(546, 71)
        Me.Panel2.TabIndex = 30
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(293, 32)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnKeluarKembali
        '
        Me.btnKeluarKembali.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnKeluarKembali.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnKeluarKembali.CustomColorName = "MyColorName"
        Me.btnKeluarKembali.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnKeluarKembali.Font = New System.Drawing.Font("Bauhaus 93", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKeluarKembali.Location = New System.Drawing.Point(546, 0)
        Me.btnKeluarKembali.Name = "btnKeluarKembali"
        Me.btnKeluarKembali.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor()
        Me.btnKeluarKembali.Size = New System.Drawing.Size(200, 71)
        Me.btnKeluarKembali.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnKeluarKembali.TabIndex = 29
        Me.btnKeluarKembali.Text = "ButtonX1"
        Me.btnKeluarKembali.TextColor = System.Drawing.Color.White
        Me.btnKeluarKembali.ThemeAware = True
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2016
        Me.StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(199, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer)))
        '
        'Timer1
        '
        '
        'niPopupStatus
        '
        Me.niPopupStatus.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.niPopupStatus.Icon = CType(resources.GetObject("niPopupStatus.Icon"), System.Drawing.Icon)
        Me.niPopupStatus.Text = "SIMRSGizi"
        Me.niPopupStatus.Visible = True
        '
        'ctxNotify
        '
        Me.ctxNotify.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ctxExit})
        Me.ctxNotify.Name = "ctxNotify"
        Me.ctxNotify.Size = New System.Drawing.Size(94, 26)
        '
        'ctxExit
        '
        Me.ctxExit.Name = "ctxExit"
        Me.ctxExit.Size = New System.Drawing.Size(93, 22)
        Me.ctxExit.Text = "E&xit"
        '
        'tmrAutoRefresh
        '
        Me.tmrAutoRefresh.Interval = 1000
        '
        'toolBar
        '
        Me.toolBar.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.toolBarButtonToggle1})
        Me.toolBar.DropDownArrows = True
        Me.toolBar.Location = New System.Drawing.Point(0, 71)
        Me.toolBar.Name = "toolBar"
        Me.toolBar.ShowToolTips = True
        Me.toolBar.Size = New System.Drawing.Size(537, 28)
        Me.toolBar.TabIndex = 25
        Me.toolBar.Visible = False
        '
        'toolBarButtonToggle1
        '
        Me.toolBarButtonToggle1.ImageIndex = 0
        Me.toolBarButtonToggle1.Name = "toolBarButtonToggle1"
        Me.toolBarButtonToggle1.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton
        Me.toolBarButtonToggle1.ToolTipText = "Toggle the first CollapsibleSplitter"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(171, 11)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 1
        '
        'MenuUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(746, 749)
        Me.ControlBox = False
        Me.Controls.Add(Me.toolBar)
        Me.Controls.Add(Me.Pemisah1)
        Me.Controls.Add(Me.DockPanel)
        Me.Controls.Add(Me.PanelMenu)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.PanelEx1)
        Me.Controls.Add(Me.MenuStrip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "MenuUtama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu Utama"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelEx1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ctxNotify.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents mnuTheme As ToolStripMenuItem
    Friend WithEvents vsRender As WeifenLuo.WinFormsUI.Docking.VisualStudioToolStripExtender
    Friend WithEvents VS2015LightTheme1 As WeifenLuo.WinFormsUI.Docking.VS2015LightTheme
    Friend WithEvents VS2015DarkTheme1 As WeifenLuo.WinFormsUI.Docking.VS2015DarkTheme
    Friend WithEvents VS2015BlueTheme1 As WeifenLuo.WinFormsUI.Docking.VS2015BlueTheme
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents Pemisah1 As NJFLib.Controls.CollapsibleSplitter
    Friend WithEvents DockPanel As WeifenLuo.WinFormsUI.Docking.DockPanel
    Friend WithEvents mnu2015Biru As ToolStripMenuItem
    Friend WithEvents mnu2015Hitam As ToolStripMenuItem
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnMenu1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnKeluarKembali As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnMenu2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents btnMenu3 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnMenu5 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents lblNamaKomputer As ToolStripStatusLabel
    Friend WithEvents lblDate As ToolStripStatusLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnMenu6 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnMenu7 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnMenu8 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnMenu9 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnMenu10 As DevComponents.DotNetBar.ButtonX
    Private WithEvents ctxNotify As ContextMenuStrip
    Private WithEvents ctxExit As ToolStripMenuItem
    Friend WithEvents tmrAutoRefresh As Timer
    Friend WithEvents btnMenu4 As NotiButton
    Friend WithEvents mnu2015Light As ToolStripMenuItem
    Private WithEvents toolBar As ToolBar
    Private WithEvents toolBarButtonToggle1 As ToolBarButton
    Friend WithEvents niPopupStatus As NotifyIcon
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
End Class
