Imports Pein
Imports WeifenLuo.WinFormsUI.Docking
Imports MySql.Data.MySqlClient
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDiet
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDiet))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.dietNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.dgvDiet = New Zuby.ADGV.AdvancedDataGridView()
        Me.KodeDiet = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.namaDiet = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ketDiet = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KelompokDiet = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.dHeader = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.dMenuUtama = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.dExtraDiet = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.dSnackPagi = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.dSnackSore = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dietNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.dietNavigator.SuspendLayout()
        CType(Me.dgvDiet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 18)
        Me.Panel1.TabIndex = 0
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelEx1.Font = New System.Drawing.Font("Bauhaus 93", 12.0!)
        Me.PanelEx1.Location = New System.Drawing.Point(0, 18)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(800, 69)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 1
        Me.PanelEx1.Text = "Menu Diet"
        '
        'dietNavigator
        '
        Me.dietNavigator.AddNewItem = Nothing
        Me.dietNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.dietNavigator.CountItemFormat = "dari {0} data"
        Me.dietNavigator.DeleteItem = Nothing
        Me.dietNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.ToolStripLabel1, Me.BindingNavigatorAddNewItem})
        Me.dietNavigator.Location = New System.Drawing.Point(0, 87)
        Me.dietNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.dietNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.dietNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.dietNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.dietNavigator.Name = "dietNavigator"
        Me.dietNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.dietNavigator.Size = New System.Drawing.Size(800, 25)
        Me.dietNavigator.TabIndex = 28
        Me.dietNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(70, 22)
        Me.BindingNavigatorCountItem.Text = "dari {0} data"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
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
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.Red
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(364, 22)
        Me.ToolStripLabel1.Text = "**Ket : Anda bisa langsung melakukan update/edit data dalam tabel"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'dgvDiet
        '
        Me.dgvDiet.AllowUserToAddRows = False
        Me.dgvDiet.AllowUserToDeleteRows = False
        Me.dgvDiet.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvDiet.ColumnHeadersHeight = 24
        Me.dgvDiet.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KodeDiet, Me.namaDiet, Me.ketDiet, Me.KelompokDiet, Me.dHeader, Me.dMenuUtama, Me.dExtraDiet, Me.dSnackPagi, Me.dSnackSore})
        Me.dgvDiet.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDiet.FilterAndSortEnabled = True
        Me.dgvDiet.Location = New System.Drawing.Point(0, 112)
        Me.dgvDiet.Name = "dgvDiet"
        Me.dgvDiet.RowHeadersVisible = False
        Me.dgvDiet.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgvDiet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvDiet.ShowCellToolTips = False
        Me.dgvDiet.Size = New System.Drawing.Size(800, 318)
        Me.dgvDiet.TabIndex = 33
        '
        'KodeDiet
        '
        Me.KodeDiet.DataPropertyName = "KDDIET"
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KodeDiet.DefaultCellStyle = DataGridViewCellStyle1
        Me.KodeDiet.HeaderText = "Kode Diet"
        Me.KodeDiet.MinimumWidth = 22
        Me.KodeDiet.Name = "KodeDiet"
        Me.KodeDiet.ReadOnly = True
        Me.KodeDiet.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        '
        'namaDiet
        '
        Me.namaDiet.DataPropertyName = "NMDIET"
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.namaDiet.DefaultCellStyle = DataGridViewCellStyle2
        Me.namaDiet.HeaderText = "Diet"
        Me.namaDiet.MinimumWidth = 22
        Me.namaDiet.Name = "namaDiet"
        Me.namaDiet.ReadOnly = True
        Me.namaDiet.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        '
        'ketDiet
        '
        Me.ketDiet.DataPropertyName = "KETERANGANDIET"
        Me.ketDiet.HeaderText = "Keterangan"
        Me.ketDiet.MinimumWidth = 22
        Me.ketDiet.Name = "ketDiet"
        Me.ketDiet.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.ketDiet.Width = 400
        '
        'KelompokDiet
        '
        Me.KelompokDiet.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.KelompokDiet.HeaderText = "Kelompok Diet"
        Me.KelompokDiet.MinimumWidth = 22
        Me.KelompokDiet.Name = "KelompokDiet"
        Me.KelompokDiet.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.KelompokDiet.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        '
        'dHeader
        '
        Me.dHeader.DataPropertyName = "lHeader"
        Me.dHeader.FalseValue = "False"
        Me.dHeader.HeaderText = "Header"
        Me.dHeader.MinimumWidth = 22
        Me.dHeader.Name = "dHeader"
        Me.dHeader.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.dHeader.TrueValue = "True"
        '
        'dMenuUtama
        '
        Me.dMenuUtama.DataPropertyName = "lMENUUTAMA"
        Me.dMenuUtama.FalseValue = "False"
        Me.dMenuUtama.HeaderText = "Menu Utama"
        Me.dMenuUtama.MinimumWidth = 22
        Me.dMenuUtama.Name = "dMenuUtama"
        Me.dMenuUtama.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.dMenuUtama.TrueValue = "True"
        '
        'dExtraDiet
        '
        Me.dExtraDiet.DataPropertyName = "lEXTRADIET"
        Me.dExtraDiet.FalseValue = "False"
        Me.dExtraDiet.HeaderText = "Extra Diet"
        Me.dExtraDiet.MinimumWidth = 22
        Me.dExtraDiet.Name = "dExtraDiet"
        Me.dExtraDiet.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.dExtraDiet.TrueValue = "True"
        '
        'dSnackPagi
        '
        Me.dSnackPagi.DataPropertyName = "ISNACKPAGI"
        Me.dSnackPagi.FalseValue = "False"
        Me.dSnackPagi.HeaderText = "Snack Pagi"
        Me.dSnackPagi.MinimumWidth = 22
        Me.dSnackPagi.Name = "dSnackPagi"
        Me.dSnackPagi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.dSnackPagi.TrueValue = "True"
        '
        'dSnackSore
        '
        Me.dSnackSore.DataPropertyName = "ISNACKSORE"
        Me.dSnackSore.FalseValue = "False"
        Me.dSnackSore.HeaderText = "Snack Sore"
        Me.dSnackSore.MinimumWidth = 22
        Me.dSnackSore.Name = "dSnackSore"
        Me.dSnackSore.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.dSnackSore.TrueValue = "True"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.132666!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.13642!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.73091!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 430)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(800, 20)
        Me.TableLayoutPanel1.TabIndex = 48
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Location = New System.Drawing.Point(53, 1)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 18)
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
        Me.Label1.Size = New System.Drawing.Size(42, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "*Ket warna :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmDiet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.dgvDiet)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.dietNavigator)
        Me.Controls.Add(Me.PanelEx1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmDiet"
        Me.Text = "Standar Menu Makanan"
        CType(Me.dietNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.dietNavigator.ResumeLayout(False)
        Me.dietNavigator.PerformLayout()
        CType(Me.dgvDiet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents dietNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents dgvDiet As Zuby.ADGV.AdvancedDataGridView
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents KodeDiet As DataGridViewTextBoxColumn
    Friend WithEvents namaDiet As DataGridViewTextBoxColumn
    Friend WithEvents ketDiet As DataGridViewTextBoxColumn
    Friend WithEvents KelompokDiet As DataGridViewComboBoxColumn
    Friend WithEvents dHeader As DataGridViewCheckBoxColumn
    Friend WithEvents dMenuUtama As DataGridViewCheckBoxColumn
    Friend WithEvents dExtraDiet As DataGridViewCheckBoxColumn
    Friend WithEvents dSnackPagi As DataGridViewCheckBoxColumn
    Friend WithEvents dSnackSore As DataGridViewCheckBoxColumn
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
