Imports WeifenLuo.WinFormsUI.Docking
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAKG
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAKG))
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblKet5 = New System.Windows.Forms.Label()
        Me.lblket4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblKet3 = New System.Windows.Forms.Label()
        Me.lblKet2 = New System.Windows.Forms.Label()
        Me.lblKet1 = New System.Windows.Forms.Label()
        Me.lblKet6 = New System.Windows.Forms.Label()
        Me.lblKet7 = New System.Windows.Forms.Label()
        Me.lblKet8 = New System.Windows.Forms.Label()
        Me.dgvAKG = New SIMRSGizi.GroupByGrid()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.dgvAKG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
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
        Me.PanelEx1.Size = New System.Drawing.Size(902, 97)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackgroundImage = CType(resources.GetObject("PanelEx1.Style.BackgroundImage"), System.Drawing.Image)
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.Color = System.Drawing.Color.Black
        Me.PanelEx1.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.None
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 53
        Me.PanelEx1.Text = "Angka Kecukupan Gizi" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel1.ColumnCount = 10
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 173.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lblKet8, 8, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblKet7, 7, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblKet6, 6, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblKet5, 5, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblket4, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblKet3, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblKet2, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblKet1, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 97)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(902, 21)
        Me.TableLayoutPanel1.TabIndex = 60
        '
        'lblKet5
        '
        Me.lblKet5.AutoSize = True
        Me.lblKet5.BackColor = System.Drawing.Color.Transparent
        Me.lblKet5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblKet5.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKet5.Location = New System.Drawing.Point(409, 1)
        Me.lblKet5.Name = "lblKet5"
        Me.lblKet5.Size = New System.Drawing.Size(74, 19)
        Me.lblKet5.TabIndex = 9
        Me.lblKet5.Text = "?"
        Me.lblKet5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblket4
        '
        Me.lblket4.AutoSize = True
        Me.lblket4.BackColor = System.Drawing.Color.Transparent
        Me.lblket4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblket4.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblket4.Location = New System.Drawing.Point(328, 1)
        Me.lblket4.Name = "lblket4"
        Me.lblket4.Size = New System.Drawing.Size(74, 19)
        Me.lblket4.TabIndex = 8
        Me.lblket4.Text = "?"
        Me.lblket4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(4, 1)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 19)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "KET  :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblKet3
        '
        Me.lblKet3.AutoSize = True
        Me.lblKet3.BackColor = System.Drawing.Color.Transparent
        Me.lblKet3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblKet3.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKet3.Location = New System.Drawing.Point(247, 1)
        Me.lblKet3.Name = "lblKet3"
        Me.lblKet3.Size = New System.Drawing.Size(74, 19)
        Me.lblKet3.TabIndex = 5
        Me.lblKet3.Text = "?"
        Me.lblKet3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblKet2
        '
        Me.lblKet2.AutoSize = True
        Me.lblKet2.BackColor = System.Drawing.Color.Transparent
        Me.lblKet2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblKet2.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKet2.Location = New System.Drawing.Point(166, 1)
        Me.lblKet2.Name = "lblKet2"
        Me.lblKet2.Size = New System.Drawing.Size(74, 19)
        Me.lblKet2.TabIndex = 4
        Me.lblKet2.Text = "?"
        Me.lblKet2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblKet1
        '
        Me.lblKet1.AutoSize = True
        Me.lblKet1.BackColor = System.Drawing.Color.Transparent
        Me.lblKet1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblKet1.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKet1.Location = New System.Drawing.Point(85, 1)
        Me.lblKet1.Name = "lblKet1"
        Me.lblKet1.Size = New System.Drawing.Size(74, 19)
        Me.lblKet1.TabIndex = 3
        Me.lblKet1.Text = "?"
        Me.lblKet1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblKet6
        '
        Me.lblKet6.AutoSize = True
        Me.lblKet6.BackColor = System.Drawing.Color.Transparent
        Me.lblKet6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblKet6.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKet6.Location = New System.Drawing.Point(490, 1)
        Me.lblKet6.Name = "lblKet6"
        Me.lblKet6.Size = New System.Drawing.Size(74, 19)
        Me.lblKet6.TabIndex = 10
        Me.lblKet6.Text = "?"
        Me.lblKet6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblKet7
        '
        Me.lblKet7.AutoSize = True
        Me.lblKet7.BackColor = System.Drawing.Color.Transparent
        Me.lblKet7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblKet7.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKet7.Location = New System.Drawing.Point(571, 1)
        Me.lblKet7.Name = "lblKet7"
        Me.lblKet7.Size = New System.Drawing.Size(74, 19)
        Me.lblKet7.TabIndex = 11
        Me.lblKet7.Text = "?"
        Me.lblKet7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblKet8
        '
        Me.lblKet8.AutoSize = True
        Me.lblKet8.BackColor = System.Drawing.Color.Transparent
        Me.lblKet8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblKet8.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKet8.Location = New System.Drawing.Point(652, 1)
        Me.lblKet8.Name = "lblKet8"
        Me.lblKet8.Size = New System.Drawing.Size(74, 19)
        Me.lblKet8.TabIndex = 12
        Me.lblKet8.Text = "?"
        Me.lblKet8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvAKG
        '
        Me.dgvAKG.AllowUserToAddRows = False
        Me.dgvAKG.AllowUserToDeleteRows = False
        Me.dgvAKG.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvAKG.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvAKG.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvAKG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvAKG.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgvAKG.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvAKG.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvAKG.GridColor = System.Drawing.SystemColors.Control
        Me.dgvAKG.Location = New System.Drawing.Point(0, 118)
        Me.dgvAKG.Name = "dgvAKG"
        Me.dgvAKG.RowHeadersVisible = False
        Me.dgvAKG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAKG.Size = New System.Drawing.Size(902, 317)
        Me.dgvAKG.TabIndex = 61
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 173.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel2.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 435)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(902, 15)
        Me.TableLayoutPanel2.TabIndex = 65
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(4, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(894, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "*Angka kecukupan rata-rata gizi yang di anjurkan (Per Orang / hari)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'frmAKG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(902, 450)
        Me.Controls.Add(Me.dgvAKG)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.PanelEx1)
        Me.Name = "frmAKG"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Angka Kecukupan Gizi"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.dgvAKG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lblKet5 As Label
    Friend WithEvents lblket4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblKet3 As Label
    Friend WithEvents lblKet2 As Label
    Friend WithEvents lblKet1 As Label
    Friend WithEvents dgvAKG As GroupByGrid
    Friend WithEvents lblKet8 As Label
    Friend WithEvents lblKet7 As Label
    Friend WithEvents lblKet6 As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label1 As Label
End Class
