<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmViewMakananOlahan
    Inherits System.Windows.Forms.Form

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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnCariNamaOlahan = New DevComponents.DotNetBar.ButtonX()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.dgvMakananOlahan = New Zuby.ADGV.AdvancedDataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.dgvMakananOlahan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(327, 45)
        Me.Panel1.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox1.Location = New System.Drawing.Point(3, 3)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(245, 20)
        Me.TextBox1.TabIndex = 1
        '
        'btnCariNamaOlahan
        '
        Me.btnCariNamaOlahan.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCariNamaOlahan.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCariNamaOlahan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCariNamaOlahan.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCariNamaOlahan.Location = New System.Drawing.Point(254, 3)
        Me.btnCariNamaOlahan.Name = "btnCariNamaOlahan"
        Me.btnCariNamaOlahan.Size = New System.Drawing.Size(70, 21)
        Me.btnCariNamaOlahan.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCariNamaOlahan.TabIndex = 30
        Me.btnCariNamaOlahan.Text = "Lihat"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.76057!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.23944!))
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnCariNamaOlahan, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 45)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(327, 27)
        Me.TableLayoutPanel1.TabIndex = 31
        '
        'dgvMakananOlahan
        '
        Me.dgvMakananOlahan.AllowUserToAddRows = False
        Me.dgvMakananOlahan.AllowUserToDeleteRows = False
        Me.dgvMakananOlahan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvMakananOlahan.FilterAndSortEnabled = True
        Me.dgvMakananOlahan.Location = New System.Drawing.Point(0, 72)
        Me.dgvMakananOlahan.Name = "dgvMakananOlahan"
        Me.dgvMakananOlahan.RowHeadersVisible = False
        Me.dgvMakananOlahan.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgvMakananOlahan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvMakananOlahan.ShowCellToolTips = False
        Me.dgvMakananOlahan.Size = New System.Drawing.Size(327, 371)
        Me.dgvMakananOlahan.TabIndex = 57
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 443)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(327, 23)
        Me.Panel2.TabIndex = 58
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label1.Location = New System.Drawing.Point(0, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(243, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "*Klik 2x dalam tabel untuk mengambil/extract data"
        '
        'frmViewMakananOlahan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(327, 466)
        Me.ControlBox = False
        Me.Controls.Add(Me.dgvMakananOlahan)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmViewMakananOlahan"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Makanan Olahan"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.dgvMakananOlahan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnCariNamaOlahan As DevComponents.DotNetBar.ButtonX
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents dgvMakananOlahan As Zuby.ADGV.AdvancedDataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
End Class
