Imports WeifenLuo.WinFormsUI.Docking

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStatusGiziBalita
    Inherits DockContent
    ' Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStatusGiziBalita))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rbWanita = New System.Windows.Forms.RadioButton()
        Me.rbPria = New System.Windows.Forms.RadioButton()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblKet5 = New System.Windows.Forms.Label()
        Me.lblket4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblKet3 = New System.Windows.Forms.Label()
        Me.lblKet2 = New System.Windows.Forms.Label()
        Me.lblKet1 = New System.Windows.Forms.Label()
        Me.dgvBalita = New SIMRSGizi.GroupByGrid()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.dgvBalita, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.rbWanita)
        Me.Panel1.Controls.Add(Me.rbPria)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 97)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 18)
        Me.Panel1.TabIndex = 61
        '
        'rbWanita
        '
        Me.rbWanita.AutoSize = True
        Me.rbWanita.Dock = System.Windows.Forms.DockStyle.Left
        Me.rbWanita.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbWanita.Location = New System.Drawing.Point(46, 0)
        Me.rbWanita.Name = "rbWanita"
        Me.rbWanita.Size = New System.Drawing.Size(65, 16)
        Me.rbWanita.TabIndex = 4
        Me.rbWanita.Text = "Wanita"
        Me.rbWanita.UseVisualStyleBackColor = True
        '
        'rbPria
        '
        Me.rbPria.AutoSize = True
        Me.rbPria.Dock = System.Windows.Forms.DockStyle.Left
        Me.rbPria.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbPria.Location = New System.Drawing.Point(0, 0)
        Me.rbPria.Name = "rbPria"
        Me.rbPria.Size = New System.Drawing.Size(46, 16)
        Me.rbPria.TabIndex = 3
        Me.rbPria.Text = "Pria"
        Me.rbPria.UseVisualStyleBackColor = True
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
        Me.PanelEx1.Size = New System.Drawing.Size(800, 97)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackgroundImage = CType(resources.GetObject("PanelEx1.Style.BackgroundImage"), System.Drawing.Image)
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.Color = System.Drawing.Color.Black
        Me.PanelEx1.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.None
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 60
        Me.PanelEx1.Text = "Status Gizi Balita"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel1.ColumnCount = 7
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 321.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lblKet5, 5, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblket4, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblKet3, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblKet2, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblKet1, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 429)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(800, 21)
        Me.TableLayoutPanel1.TabIndex = 63
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
        'dgvBalita
        '
        Me.dgvBalita.AllowUserToAddRows = False
        Me.dgvBalita.AllowUserToDeleteRows = False
        Me.dgvBalita.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvBalita.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvBalita.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvBalita.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvBalita.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvBalita.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvBalita.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvBalita.GridColor = System.Drawing.SystemColors.Control
        Me.dgvBalita.Location = New System.Drawing.Point(0, 115)
        Me.dgvBalita.Name = "dgvBalita"
        Me.dgvBalita.RowHeadersVisible = False
        Me.dgvBalita.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBalita.Size = New System.Drawing.Size(800, 314)
        Me.dgvBalita.TabIndex = 62
        '
        'frmStatusGiziBalita
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.dgvBalita)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelEx1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "frmStatusGiziBalita"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Status Gizi Balita"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.dgvBalita, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents rbPria As RadioButton
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents dgvBalita As GroupByGrid
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lblKet5 As Label
    Friend WithEvents lblket4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblKet3 As Label
    Friend WithEvents lblKet2 As Label
    Friend WithEvents lblKet1 As Label
    Friend WithEvents rbWanita As RadioButton
End Class
