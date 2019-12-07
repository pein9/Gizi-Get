Imports WeifenLuo.WinFormsUI.Docking
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMakananOlahanJadi
    Inherits DockContent
    'Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMakananOlahanJadi))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mvSesudah = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.mvSebelum = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.olahanNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.lblKeteranganData = New System.Windows.Forms.ToolStripLabel()
        Me.lblCariOlahan = New System.Windows.Forms.ToolStripLabel()
        Me.txtCariOlahan = New System.Windows.Forms.ToolStripTextBox()
        Me.lblKetNavi = New System.Windows.Forms.ToolStripLabel()
        Me.separatorCari = New System.Windows.Forms.ToolStripSeparator()
        Me.btnTambah = New System.Windows.Forms.ToolStripButton()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.dgvMakananOlahan = New System.Windows.Forms.DataGridView()
        Me.kodeMakanan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.namaMakanan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nmHeader = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.pnlSatuanSaji = New System.Windows.Forms.Panel()
        Me.dgvSatuanSaji = New System.Windows.Forms.DataGridView()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.ExpandableSplitter1 = New DevComponents.DotNetBar.ExpandableSplitter()
        Me.ExpandableSplitter2 = New DevComponents.DotNetBar.ExpandableSplitter()
        Me.panelDown = New System.Windows.Forms.Panel()
        Me.dgvKomposisi = New System.Windows.Forms.DataGridView()
        Me.pnlKomposisi = New DevComponents.DotNetBar.PanelEx()
        Me.komposisiNavi = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.btnAddKomposisi = New System.Windows.Forms.ToolStripButton()
        Me.btnDeleteKomposisi = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.PanelEx3 = New DevComponents.DotNetBar.PanelEx()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.olahanNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.olahanNavigator.SuspendLayout()
        CType(Me.dgvMakananOlahan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSatuanSaji.SuspendLayout()
        CType(Me.dgvSatuanSaji, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelDown.SuspendLayout()
        CType(Me.dgvKomposisi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.komposisiNavi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.komposisiNavi.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Data pertama"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(25, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(70, 22)
        Me.BindingNavigatorCountItem.Text = "dari {0} data"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'mvSesudah
        '
        Me.mvSesudah.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.mvSesudah.Image = CType(resources.GetObject("mvSesudah.Image"), System.Drawing.Image)
        Me.mvSesudah.Name = "mvSesudah"
        Me.mvSesudah.RightToLeftAutoMirrorImage = True
        Me.mvSesudah.Size = New System.Drawing.Size(23, 22)
        Me.mvSesudah.Text = "Selanjutnya"
        Me.mvSesudah.ToolTipText = "Selanjutnya"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Data terakhir"
        '
        'mvSebelum
        '
        Me.mvSebelum.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.mvSebelum.Image = CType(resources.GetObject("mvSebelum.Image"), System.Drawing.Image)
        Me.mvSebelum.Name = "mvSebelum"
        Me.mvSebelum.RightToLeftAutoMirrorImage = True
        Me.mvSebelum.Size = New System.Drawing.Size(23, 22)
        Me.mvSebelum.Text = "Sebelumnya"
        Me.mvSebelum.ToolTipText = "Sebelumnya"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'olahanNavigator
        '
        Me.olahanNavigator.AddNewItem = Nothing
        Me.olahanNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.olahanNavigator.CountItemFormat = "dari {0} data"
        Me.olahanNavigator.DeleteItem = Nothing
        Me.olahanNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.mvSebelum, Me.BindingNavigatorSeparator, Me.lblKeteranganData, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.mvSesudah, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.lblCariOlahan, Me.txtCariOlahan, Me.lblKetNavi, Me.separatorCari, Me.btnTambah})
        Me.olahanNavigator.Location = New System.Drawing.Point(0, 0)
        Me.olahanNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.olahanNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.olahanNavigator.MoveNextItem = Me.mvSesudah
        Me.olahanNavigator.MovePreviousItem = Me.mvSebelum
        Me.olahanNavigator.Name = "olahanNavigator"
        Me.olahanNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.olahanNavigator.Size = New System.Drawing.Size(1370, 25)
        Me.olahanNavigator.TabIndex = 26
        Me.olahanNavigator.Text = "BindingNavigator1"
        '
        'lblKeteranganData
        '
        Me.lblKeteranganData.Name = "lblKeteranganData"
        Me.lblKeteranganData.Size = New System.Drawing.Size(341, 22)
        Me.lblKeteranganData.Text = "*Klik tabel makanan olahan atau satuan saji untuk navigasi data"
        '
        'lblCariOlahan
        '
        Me.lblCariOlahan.Name = "lblCariOlahan"
        Me.lblCariOlahan.Size = New System.Drawing.Size(152, 22)
        Me.lblCariOlahan.Text = "Pencarian Makanan Olahan"
        Me.lblCariOlahan.Visible = False
        '
        'txtCariOlahan
        '
        Me.txtCariOlahan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCariOlahan.Name = "txtCariOlahan"
        Me.txtCariOlahan.Size = New System.Drawing.Size(200, 25)
        Me.txtCariOlahan.Visible = False
        '
        'lblKetNavi
        '
        Me.lblKetNavi.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.lblKetNavi.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKetNavi.ForeColor = System.Drawing.Color.Red
        Me.lblKetNavi.Name = "lblKetNavi"
        Me.lblKetNavi.Size = New System.Drawing.Size(0, 22)
        Me.lblKetNavi.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblKetNavi.Visible = False
        '
        'separatorCari
        '
        Me.separatorCari.Name = "separatorCari"
        Me.separatorCari.Size = New System.Drawing.Size(6, 25)
        Me.separatorCari.Visible = False
        '
        'btnTambah
        '
        Me.btnTambah.Image = CType(resources.GetObject("btnTambah.Image"), System.Drawing.Image)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.RightToLeftAutoMirrorImage = True
        Me.btnTambah.Size = New System.Drawing.Size(96, 22)
        Me.btnTambah.Text = "Tambah Data"
        Me.btnTambah.Visible = False
        '
        'dgvMakananOlahan
        '
        Me.dgvMakananOlahan.AllowUserToAddRows = False
        Me.dgvMakananOlahan.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvMakananOlahan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMakananOlahan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.kodeMakanan, Me.namaMakanan, Me.nmHeader})
        Me.dgvMakananOlahan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvMakananOlahan.Location = New System.Drawing.Point(0, 48)
        Me.dgvMakananOlahan.Name = "dgvMakananOlahan"
        Me.dgvMakananOlahan.RowHeadersVisible = False
        Me.dgvMakananOlahan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvMakananOlahan.ShowCellToolTips = False
        Me.dgvMakananOlahan.Size = New System.Drawing.Size(982, 149)
        Me.dgvMakananOlahan.TabIndex = 27
        '
        'kodeMakanan
        '
        Me.kodeMakanan.DataPropertyName = "kdMakanan"
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.kodeMakanan.DefaultCellStyle = DataGridViewCellStyle1
        Me.kodeMakanan.HeaderText = "Kode Olahan"
        Me.kodeMakanan.MaxInputLength = 10
        Me.kodeMakanan.Name = "kodeMakanan"
        Me.kodeMakanan.ReadOnly = True
        Me.kodeMakanan.ToolTipText = "Maaf, field ini tidak bisa di ubah/edit"
        Me.kodeMakanan.Width = 200
        '
        'namaMakanan
        '
        Me.namaMakanan.DataPropertyName = "nmMakanan"
        Me.namaMakanan.HeaderText = "Nama Makanan Olahan"
        Me.namaMakanan.MaxInputLength = 150
        Me.namaMakanan.Name = "namaMakanan"
        Me.namaMakanan.Width = 450
        '
        'nmHeader
        '
        Me.nmHeader.DataPropertyName = "lHeader"
        Me.nmHeader.FalseValue = "False"
        Me.nmHeader.HeaderText = "lHeader"
        Me.nmHeader.IndeterminateValue = ""
        Me.nmHeader.Name = "nmHeader"
        Me.nmHeader.TrueValue = "True"
        Me.nmHeader.Width = 75
        '
        'pnlSatuanSaji
        '
        Me.pnlSatuanSaji.Controls.Add(Me.dgvSatuanSaji)
        Me.pnlSatuanSaji.Controls.Add(Me.PanelEx1)
        Me.pnlSatuanSaji.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlSatuanSaji.Location = New System.Drawing.Point(988, 25)
        Me.pnlSatuanSaji.Name = "pnlSatuanSaji"
        Me.pnlSatuanSaji.Size = New System.Drawing.Size(382, 192)
        Me.pnlSatuanSaji.TabIndex = 28
        '
        'dgvSatuanSaji
        '
        Me.dgvSatuanSaji.AllowUserToAddRows = False
        Me.dgvSatuanSaji.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvSatuanSaji.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSatuanSaji.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvSatuanSaji.Location = New System.Drawing.Point(0, 23)
        Me.dgvSatuanSaji.Name = "dgvSatuanSaji"
        Me.dgvSatuanSaji.ReadOnly = True
        Me.dgvSatuanSaji.RowHeadersVisible = False
        Me.dgvSatuanSaji.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvSatuanSaji.ShowCellToolTips = False
        Me.dgvSatuanSaji.Size = New System.Drawing.Size(382, 169)
        Me.dgvSatuanSaji.TabIndex = 28
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelEx1.Font = New System.Drawing.Font("Bauhaus 93", 12.0!)
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(382, 23)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.Color = System.Drawing.Color.Black
        Me.PanelEx1.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.Top
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        Me.PanelEx1.Text = "Daftar Satuan Saji"
        '
        'ExpandableSplitter1
        '
        Me.ExpandableSplitter1.AnimationTime = 500
        Me.ExpandableSplitter1.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.ExpandableSplitter1.BackColor2 = System.Drawing.Color.Empty
        Me.ExpandableSplitter1.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.None
        Me.ExpandableSplitter1.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.None
        Me.ExpandableSplitter1.Dock = System.Windows.Forms.DockStyle.Right
        Me.ExpandableSplitter1.ExpandableControl = Me.pnlSatuanSaji
        Me.ExpandableSplitter1.ExpandFillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.ExpandableSplitter1.ExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground
        Me.ExpandableSplitter1.ExpandLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ExpandableSplitter1.ExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBorder
        Me.ExpandableSplitter1.ForeColor = System.Drawing.Color.White
        Me.ExpandableSplitter1.GripDarkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ExpandableSplitter1.GripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBorder
        Me.ExpandableSplitter1.GripLightColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.ExpandableSplitter1.GripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.MenuBackground
        Me.ExpandableSplitter1.HotBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.ExpandableSplitter1.HotBackColor2 = System.Drawing.Color.Empty
        Me.ExpandableSplitter1.HotBackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.None
        Me.ExpandableSplitter1.HotBackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemCheckedBackground
        Me.ExpandableSplitter1.HotExpandFillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.ExpandableSplitter1.HotExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground
        Me.ExpandableSplitter1.HotExpandLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ExpandableSplitter1.HotExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBorder
        Me.ExpandableSplitter1.HotGripDarkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ExpandableSplitter1.HotGripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBorder
        Me.ExpandableSplitter1.HotGripLightColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.ExpandableSplitter1.HotGripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.MenuBackground
        Me.ExpandableSplitter1.Location = New System.Drawing.Point(982, 25)
        Me.ExpandableSplitter1.Name = "ExpandableSplitter1"
        Me.ExpandableSplitter1.Size = New System.Drawing.Size(6, 192)
        Me.ExpandableSplitter1.Style = DevComponents.DotNetBar.eSplitterStyle.Mozilla
        Me.ExpandableSplitter1.TabIndex = 29
        Me.ExpandableSplitter1.TabStop = False
        '
        'ExpandableSplitter2
        '
        Me.ExpandableSplitter2.AnimationTime = 500
        Me.ExpandableSplitter2.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.ExpandableSplitter2.BackColor2 = System.Drawing.Color.Empty
        Me.ExpandableSplitter2.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.None
        Me.ExpandableSplitter2.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.None
        Me.ExpandableSplitter2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ExpandableSplitter2.ExpandableControl = Me.panelDown
        Me.ExpandableSplitter2.ExpandFillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.ExpandableSplitter2.ExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground
        Me.ExpandableSplitter2.ExpandLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ExpandableSplitter2.ExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBorder
        Me.ExpandableSplitter2.ForeColor = System.Drawing.Color.White
        Me.ExpandableSplitter2.GripDarkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ExpandableSplitter2.GripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBorder
        Me.ExpandableSplitter2.GripLightColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.ExpandableSplitter2.GripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.MenuBackground
        Me.ExpandableSplitter2.HotBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.ExpandableSplitter2.HotBackColor2 = System.Drawing.Color.Empty
        Me.ExpandableSplitter2.HotBackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.None
        Me.ExpandableSplitter2.HotBackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemCheckedBackground
        Me.ExpandableSplitter2.HotExpandFillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.ExpandableSplitter2.HotExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground
        Me.ExpandableSplitter2.HotExpandLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ExpandableSplitter2.HotExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBorder
        Me.ExpandableSplitter2.HotGripDarkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ExpandableSplitter2.HotGripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBorder
        Me.ExpandableSplitter2.HotGripLightColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.ExpandableSplitter2.HotGripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.MenuBackground
        Me.ExpandableSplitter2.Location = New System.Drawing.Point(0, 217)
        Me.ExpandableSplitter2.Name = "ExpandableSplitter2"
        Me.ExpandableSplitter2.Size = New System.Drawing.Size(1370, 6)
        Me.ExpandableSplitter2.Style = DevComponents.DotNetBar.eSplitterStyle.Mozilla
        Me.ExpandableSplitter2.TabIndex = 34
        Me.ExpandableSplitter2.TabStop = False
        '
        'panelDown
        '
        Me.panelDown.Controls.Add(Me.dgvKomposisi)
        Me.panelDown.Controls.Add(Me.pnlKomposisi)
        Me.panelDown.Controls.Add(Me.komposisiNavi)
        Me.panelDown.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelDown.Location = New System.Drawing.Point(0, 223)
        Me.panelDown.Name = "panelDown"
        Me.panelDown.Size = New System.Drawing.Size(1370, 216)
        Me.panelDown.TabIndex = 35
        '
        'dgvKomposisi
        '
        Me.dgvKomposisi.AllowUserToAddRows = False
        Me.dgvKomposisi.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvKomposisi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvKomposisi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvKomposisi.Location = New System.Drawing.Point(0, 23)
        Me.dgvKomposisi.Name = "dgvKomposisi"
        Me.dgvKomposisi.RowHeadersVisible = False
        Me.dgvKomposisi.Size = New System.Drawing.Size(1370, 193)
        Me.dgvKomposisi.TabIndex = 29
        '
        'pnlKomposisi
        '
        Me.pnlKomposisi.CanvasColor = System.Drawing.SystemColors.Control
        Me.pnlKomposisi.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.pnlKomposisi.DisabledBackColor = System.Drawing.Color.Empty
        Me.pnlKomposisi.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlKomposisi.Font = New System.Drawing.Font("Bauhaus 93", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlKomposisi.Location = New System.Drawing.Point(0, 0)
        Me.pnlKomposisi.Name = "pnlKomposisi"
        Me.pnlKomposisi.Size = New System.Drawing.Size(1370, 23)
        Me.pnlKomposisi.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.pnlKomposisi.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.pnlKomposisi.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.pnlKomposisi.Style.BorderColor.Color = System.Drawing.Color.Black
        Me.pnlKomposisi.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.Top
        Me.pnlKomposisi.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.pnlKomposisi.Style.GradientAngle = 90
        Me.pnlKomposisi.TabIndex = 4
        Me.pnlKomposisi.Text = "Komposisi Makanan"
        '
        'komposisiNavi
        '
        Me.komposisiNavi.AddNewItem = Nothing
        Me.komposisiNavi.CountItem = Nothing
        Me.komposisiNavi.CountItemFormat = "dari {0} data"
        Me.komposisiNavi.DeleteItem = Nothing
        Me.komposisiNavi.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel3, Me.ToolStripLabel2, Me.btnAddKomposisi, Me.btnDeleteKomposisi, Me.ToolStripSeparator1, Me.ToolStripLabel1})
        Me.komposisiNavi.Location = New System.Drawing.Point(0, 0)
        Me.komposisiNavi.MoveFirstItem = Nothing
        Me.komposisiNavi.MoveLastItem = Nothing
        Me.komposisiNavi.MoveNextItem = Nothing
        Me.komposisiNavi.MovePreviousItem = Nothing
        Me.komposisiNavi.Name = "komposisiNavi"
        Me.komposisiNavi.PositionItem = Nothing
        Me.komposisiNavi.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.komposisiNavi.Size = New System.Drawing.Size(1370, 25)
        Me.komposisiNavi.TabIndex = 33
        Me.komposisiNavi.Text = "BindingNavigator1"
        Me.komposisiNavi.Visible = False
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel3.ForeColor = System.Drawing.Color.Red
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(0, 22)
        Me.ToolStripLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolStripLabel3.Visible = False
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(132, 22)
        Me.ToolStripLabel2.Text = "Tambahkan Komposisi :"
        '
        'btnAddKomposisi
        '
        Me.btnAddKomposisi.Image = CType(resources.GetObject("btnAddKomposisi.Image"), System.Drawing.Image)
        Me.btnAddKomposisi.Name = "btnAddKomposisi"
        Me.btnAddKomposisi.RightToLeftAutoMirrorImage = True
        Me.btnAddKomposisi.Size = New System.Drawing.Size(23, 22)
        Me.btnAddKomposisi.ToolTipText = "Tambah Komposisi"
        '
        'btnDeleteKomposisi
        '
        Me.btnDeleteKomposisi.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnDeleteKomposisi.Image = CType(resources.GetObject("btnDeleteKomposisi.Image"), System.Drawing.Image)
        Me.btnDeleteKomposisi.Name = "btnDeleteKomposisi"
        Me.btnDeleteKomposisi.RightToLeftAutoMirrorImage = True
        Me.btnDeleteKomposisi.Size = New System.Drawing.Size(23, 22)
        Me.btnDeleteKomposisi.Text = "Hapus Data Komposisi"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.Red
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(403, 22)
        Me.ToolStripLabel1.Text = "*Ket : Klik 2x dalam tabel ini untuk update/edit data - membuka editor data"
        '
        'PanelEx3
        '
        Me.PanelEx3.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx3.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx3.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelEx3.Font = New System.Drawing.Font("Bauhaus 93", 12.0!)
        Me.PanelEx3.Location = New System.Drawing.Point(0, 25)
        Me.PanelEx3.Name = "PanelEx3"
        Me.PanelEx3.Size = New System.Drawing.Size(982, 23)
        Me.PanelEx3.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx3.Style.BorderColor.Color = System.Drawing.Color.Black
        Me.PanelEx3.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.Top
        Me.PanelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx3.Style.GradientAngle = 90
        Me.PanelEx3.TabIndex = 39
        Me.PanelEx3.Text = "Daftar Makanan Olahan"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 197)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(982, 20)
        Me.TableLayoutPanel1.TabIndex = 47
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.DarkGray
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Location = New System.Drawing.Point(80, 1)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Tidak Bisa di Edit"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "*Ket warna :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmMakananOlahanJadi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 439)
        Me.Controls.Add(Me.dgvMakananOlahan)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.PanelEx3)
        Me.Controls.Add(Me.ExpandableSplitter1)
        Me.Controls.Add(Me.pnlSatuanSaji)
        Me.Controls.Add(Me.olahanNavigator)
        Me.Controls.Add(Me.ExpandableSplitter2)
        Me.Controls.Add(Me.panelDown)
        Me.Name = "frmMakananOlahanJadi"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Makanan Olahan Jadi"
        CType(Me.olahanNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.olahanNavigator.ResumeLayout(False)
        Me.olahanNavigator.PerformLayout()
        CType(Me.dgvMakananOlahan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSatuanSaji.ResumeLayout(False)
        CType(Me.dgvSatuanSaji, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelDown.ResumeLayout(False)
        Me.panelDown.PerformLayout()
        CType(Me.dgvKomposisi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.komposisiNavi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.komposisiNavi.ResumeLayout(False)
        Me.komposisiNavi.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents mvSesudah As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents mvSebelum As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents olahanNavigator As BindingNavigator
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents dgvMakananOlahan As DataGridView
    Friend WithEvents pnlSatuanSaji As Panel
    Friend WithEvents panelDown As Panel
    Friend WithEvents dgvSatuanSaji As DataGridView
    Friend WithEvents dgvKomposisi As DataGridView
    Friend WithEvents lblKeteranganData As ToolStripLabel
    Friend WithEvents btnTambah As ToolStripButton
    Friend WithEvents lblKetNavi As ToolStripLabel
    Friend WithEvents komposisiNavi As BindingNavigator
    Friend WithEvents btnAddKomposisi As ToolStripButton
    Friend WithEvents ToolStripLabel3 As ToolStripLabel
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents lblCariOlahan As ToolStripLabel
    Friend WithEvents txtCariOlahan As ToolStripTextBox
    Friend WithEvents separatorCari As ToolStripSeparator
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents kodeMakanan As DataGridViewTextBoxColumn
    Friend WithEvents namaMakanan As DataGridViewTextBoxColumn
    Friend WithEvents nmHeader As DataGridViewCheckBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents btnDeleteKomposisi As ToolStripButton
    Private WithEvents ExpandableSplitter1 As DevComponents.DotNetBar.ExpandableSplitter
    Private WithEvents ExpandableSplitter2 As DevComponents.DotNetBar.ExpandableSplitter
    Private WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Private WithEvents pnlKomposisi As DevComponents.DotNetBar.PanelEx
    Private WithEvents PanelEx3 As DevComponents.DotNetBar.PanelEx
End Class
