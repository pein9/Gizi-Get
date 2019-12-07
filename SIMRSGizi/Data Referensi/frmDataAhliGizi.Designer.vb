Imports WeifenLuo.WinFormsUI.Docking
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDataAhliGizi
    'Inherits System.Windows.Forms.Form
    Inherits DockContent
    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDataAhliGizi))
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.dgvAhliGizi = New System.Windows.Forms.DataGridView()
        Me.ahliGiziNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.naviTambah = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        CType(Me.dgvAhliGizi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ahliGiziNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ahliGiziNavigator.SuspendLayout()
        Me.SuspendLayout()
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
        Me.PanelEx1.Size = New System.Drawing.Size(800, 34)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 33
        Me.PanelEx1.Text = "Ahli Gizi / Dokter"
        '
        'dgvAhliGizi
        '
        Me.dgvAhliGizi.AllowUserToAddRows = False
        Me.dgvAhliGizi.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvAhliGizi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAhliGizi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvAhliGizi.Location = New System.Drawing.Point(0, 59)
        Me.dgvAhliGizi.Name = "dgvAhliGizi"
        Me.dgvAhliGizi.RowHeadersVisible = False
        Me.dgvAhliGizi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvAhliGizi.Size = New System.Drawing.Size(800, 391)
        Me.dgvAhliGizi.TabIndex = 35
        '
        'ahliGiziNavigator
        '
        Me.ahliGiziNavigator.AddNewItem = Nothing
        Me.ahliGiziNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ahliGiziNavigator.DeleteItem = Nothing
        Me.ahliGiziNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.naviTambah, Me.ToolStripLabel1})
        Me.ahliGiziNavigator.Location = New System.Drawing.Point(0, 34)
        Me.ahliGiziNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ahliGiziNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ahliGiziNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ahliGiziNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ahliGiziNavigator.Name = "ahliGiziNavigator"
        Me.ahliGiziNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ahliGiziNavigator.Size = New System.Drawing.Size(800, 25)
        Me.ahliGiziNavigator.TabIndex = 40
        Me.ahliGiziNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
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
        'naviTambah
        '
        Me.naviTambah.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.naviTambah.Image = CType(resources.GetObject("naviTambah.Image"), System.Drawing.Image)
        Me.naviTambah.Name = "naviTambah"
        Me.naviTambah.RightToLeftAutoMirrorImage = True
        Me.naviTambah.Size = New System.Drawing.Size(23, 22)
        Me.naviTambah.Text = "Tambah Data"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.DarkRed
        Me.ToolStripLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.ToolStripLabel1.LinkColor = System.Drawing.Color.Red
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(418, 22)
        Me.ToolStripLabel1.Text = "*Tekan (+) untuk membah data, Klik 2x tabel untuk merubah data/extract data"
        Me.ToolStripLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(199, Byte), Integer))
        '
        'frmDataAhliGizi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.dgvAhliGizi)
        Me.Controls.Add(Me.ahliGiziNavigator)
        Me.Controls.Add(Me.PanelEx1)
        Me.Name = "frmDataAhliGizi"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Ahli Gizi"
        CType(Me.dgvAhliGizi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ahliGiziNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ahliGiziNavigator.ResumeLayout(False)
        Me.ahliGiziNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents dgvAhliGizi As DataGridView
    Friend WithEvents ahliGiziNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents naviTambah As ToolStripButton
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
End Class
