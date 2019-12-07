<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmViewPermintaan
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmViewPermintaan))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnSimpan = New DevComponents.DotNetBar.ButtonX()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.vsRender = New WeifenLuo.WinFormsUI.Docking.VisualStudioToolStripExtender(Me.components)
        Me.VS2015LightTheme1 = New WeifenLuo.WinFormsUI.Docking.VS2015LightTheme()
        Me.TanggalDari = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TanggalSampai = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboRuang = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(364, 43)
        Me.Panel1.TabIndex = 53
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), System.Drawing.Image)
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(103, 41)
        Me.Panel3.TabIndex = 17
        '
        'Panel2
        '
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnSimpan)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 129)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(364, 41)
        Me.Panel2.TabIndex = 55
        '
        'btnSimpan
        '
        Me.btnSimpan.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSimpan.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSimpan.Enabled = False
        Me.btnSimpan.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSimpan.Location = New System.Drawing.Point(284, 6)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(67, 27)
        Me.btnSimpan.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnSimpan.TabIndex = 204
        Me.btnSimpan.Text = "Ok"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 170)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(364, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 54
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'vsRender
        '
        Me.vsRender.DefaultRenderer = Nothing
        '
        'TanggalDari
        '
        Me.TanggalDari.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TanggalDari.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.TanggalDari.Location = New System.Drawing.Point(155, 53)
        Me.TanggalDari.Name = "TanggalDari"
        Me.TanggalDari.Size = New System.Drawing.Size(82, 22)
        Me.TanggalDari.TabIndex = 177
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 14)
        Me.Label1.TabIndex = 178
        Me.Label1.Text = "Tanggal Penerimaan:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(243, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 14)
        Me.Label2.TabIndex = 180
        Me.Label2.Text = "s/d"
        '
        'TanggalSampai
        '
        Me.TanggalSampai.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TanggalSampai.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.TanggalSampai.Location = New System.Drawing.Point(274, 53)
        Me.TanggalSampai.Name = "TanggalSampai"
        Me.TanggalSampai.Size = New System.Drawing.Size(82, 22)
        Me.TanggalSampai.TabIndex = 179
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(67, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 14)
        Me.Label3.TabIndex = 181
        Me.Label3.Text = "Nama Ruang :"
        '
        'cboRuang
        '
        Me.cboRuang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRuang.FormattingEnabled = True
        Me.cboRuang.Location = New System.Drawing.Point(155, 87)
        Me.cboRuang.Name = "cboRuang"
        Me.cboRuang.Size = New System.Drawing.Size(201, 21)
        Me.cboRuang.TabIndex = 182
        '
        'FrmViewPermintaan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(364, 192)
        Me.Controls.Add(Me.cboRuang)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TanggalSampai)
        Me.Controls.Add(Me.TanggalDari)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmViewPermintaan"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lihat Permintaan"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnSimpan As DevComponents.DotNetBar.ButtonX
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents vsRender As WeifenLuo.WinFormsUI.Docking.VisualStudioToolStripExtender
    Friend WithEvents VS2015LightTheme1 As WeifenLuo.WinFormsUI.Docking.VS2015LightTheme
    Friend WithEvents TanggalDari As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TanggalSampai As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents cboRuang As ComboBox
End Class
