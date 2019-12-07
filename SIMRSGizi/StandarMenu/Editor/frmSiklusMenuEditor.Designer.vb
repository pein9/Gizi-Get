<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSiklusMenuEditor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSiklusMenuEditor))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.vsRender = New WeifenLuo.WinFormsUI.Docking.VisualStudioToolStripExtender(Me.components)
        Me.VS2015LightTheme1 = New WeifenLuo.WinFormsUI.Docking.VS2015LightTheme()
        Me.epUser = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnBatal = New DevComponents.DotNetBar.ButtonX()
        Me.btnSimpan = New DevComponents.DotNetBar.ButtonX()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtKeterangan = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Line3 = New DevComponents.DotNetBar.Controls.Line()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboWaktu = New System.Windows.Forms.ComboBox()
        Me.txtKdWaktu = New System.Windows.Forms.TextBox()
        Me.cboNamaMakanan = New System.Windows.Forms.ComboBox()
        Me.txtKodeMakanan = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtExtraDiet = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboKategory = New System.Windows.Forms.ComboBox()
        Me.txtKdKategory = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.epUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(483, 43)
        Me.Panel1.TabIndex = 53
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), System.Drawing.Image)
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(103, 43)
        Me.Panel3.TabIndex = 17
        '
        'StatusStrip1
        '
        Me.StatusStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 304)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(483, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 54
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'vsRender
        '
        Me.vsRender.DefaultRenderer = Nothing
        '
        'epUser
        '
        Me.epUser.ContainerControl = Me
        '
        'Panel2
        '
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnBatal)
        Me.Panel2.Controls.Add(Me.btnSimpan)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 235)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(483, 69)
        Me.Panel2.TabIndex = 55
        '
        'btnBatal
        '
        Me.btnBatal.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnBatal.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnBatal.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnBatal.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBatal.Location = New System.Drawing.Point(250, 13)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(87, 37)
        Me.btnBatal.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnBatal.TabIndex = 205
        Me.btnBatal.Text = "Batal"
        '
        'btnSimpan
        '
        Me.btnSimpan.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSimpan.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSimpan.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSimpan.Location = New System.Drawing.Point(152, 13)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(87, 37)
        Me.btnSimpan.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnSimpan.TabIndex = 204
        Me.btnSimpan.Text = "Simpan"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 15)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "Tipe Siklus :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtKeterangan
        '
        Me.txtKeterangan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtKeterangan.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKeterangan.Location = New System.Drawing.Point(153, 90)
        Me.txtKeterangan.MaxLength = 10
        Me.txtKeterangan.Name = "txtKeterangan"
        Me.txtKeterangan.ReadOnly = True
        Me.txtKeterangan.Size = New System.Drawing.Size(109, 21)
        Me.txtKeterangan.TabIndex = 58
        Me.txtKeterangan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 15)
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "Keterangan Siklus :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Line3
        '
        Me.Line3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Line3.Location = New System.Drawing.Point(12, 108)
        Me.Line3.Name = "Line3"
        Me.Line3.Size = New System.Drawing.Size(458, 23)
        Me.Line3.TabIndex = 60
        Me.Line3.Text = "Line3"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 15)
        Me.Label3.TabIndex = 61
        Me.Label3.Text = "Waktu :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cboWaktu
        '
        Me.cboWaktu.FormattingEnabled = True
        Me.cboWaktu.Location = New System.Drawing.Point(153, 128)
        Me.cboWaktu.Name = "cboWaktu"
        Me.cboWaktu.Size = New System.Drawing.Size(109, 21)
        Me.cboWaktu.TabIndex = 62
        '
        'txtKdWaktu
        '
        Me.txtKdWaktu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtKdWaktu.Location = New System.Drawing.Point(60, 125)
        Me.txtKdWaktu.MaxLength = 10
        Me.txtKdWaktu.Name = "txtKdWaktu"
        Me.txtKdWaktu.ReadOnly = True
        Me.txtKdWaktu.Size = New System.Drawing.Size(33, 20)
        Me.txtKdWaktu.TabIndex = 63
        Me.txtKdWaktu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtKdWaktu.Visible = False
        '
        'cboNamaMakanan
        '
        Me.cboNamaMakanan.FormattingEnabled = True
        Me.cboNamaMakanan.Location = New System.Drawing.Point(153, 181)
        Me.cboNamaMakanan.Name = "cboNamaMakanan"
        Me.cboNamaMakanan.Size = New System.Drawing.Size(294, 21)
        Me.cboNamaMakanan.TabIndex = 65
        '
        'txtKodeMakanan
        '
        Me.txtKodeMakanan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtKodeMakanan.Location = New System.Drawing.Point(297, 208)
        Me.txtKodeMakanan.MaxLength = 10
        Me.txtKodeMakanan.Name = "txtKodeMakanan"
        Me.txtKodeMakanan.ReadOnly = True
        Me.txtKodeMakanan.Size = New System.Drawing.Size(93, 20)
        Me.txtKodeMakanan.TabIndex = 66
        Me.txtKodeMakanan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtKodeMakanan.Visible = False
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(20, 183)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 15)
        Me.Label4.TabIndex = 64
        Me.Label4.Text = "Nama Makanan :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11"})
        Me.ComboBox1.Location = New System.Drawing.Point(153, 63)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(50, 21)
        Me.ComboBox1.TabIndex = 67
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(19, 209)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(127, 15)
        Me.Label5.TabIndex = 68
        Me.Label5.Text = "Keterangan :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtExtraDiet
        '
        Me.txtExtraDiet.Location = New System.Drawing.Point(153, 208)
        Me.txtExtraDiet.Name = "txtExtraDiet"
        Me.txtExtraDiet.Size = New System.Drawing.Size(138, 20)
        Me.txtExtraDiet.TabIndex = 69
        '
        'txtID
        '
        Me.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtID.Location = New System.Drawing.Point(12, 69)
        Me.txtID.MaxLength = 10
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(54, 20)
        Me.txtID.TabIndex = 70
        Me.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtID.Visible = False
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(20, 154)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(127, 15)
        Me.Label6.TabIndex = 71
        Me.Label6.Text = "Kategory :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cboKategory
        '
        Me.cboKategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboKategory.FormattingEnabled = True
        Me.cboKategory.Location = New System.Drawing.Point(153, 153)
        Me.cboKategory.Name = "cboKategory"
        Me.cboKategory.Size = New System.Drawing.Size(176, 21)
        Me.cboKategory.TabIndex = 72
        '
        'txtKdKategory
        '
        Me.txtKdKategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtKdKategory.Location = New System.Drawing.Point(335, 153)
        Me.txtKdKategory.MaxLength = 10
        Me.txtKdKategory.Name = "txtKdKategory"
        Me.txtKdKategory.ReadOnly = True
        Me.txtKdKategory.Size = New System.Drawing.Size(93, 20)
        Me.txtKdKategory.TabIndex = 73
        Me.txtKdKategory.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtKdKategory.Visible = False
        '
        'frmSiklusMenuEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(483, 326)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtKdKategory)
        Me.Controls.Add(Me.cboKategory)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.txtExtraDiet)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.cboNamaMakanan)
        Me.Controls.Add(Me.txtKodeMakanan)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cboWaktu)
        Me.Controls.Add(Me.txtKdWaktu)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtKeterangan)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Line3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmSiklusMenuEditor"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Siklus Editor"
        Me.Panel1.ResumeLayout(False)
        CType(Me.epUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents vsRender As WeifenLuo.WinFormsUI.Docking.VisualStudioToolStripExtender
    Friend WithEvents VS2015LightTheme1 As WeifenLuo.WinFormsUI.Docking.VS2015LightTheme
    Friend WithEvents epUser As ErrorProvider
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtKeterangan As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Line3 As DevComponents.DotNetBar.Controls.Line
    Friend WithEvents Label3 As Label
    Friend WithEvents cboWaktu As ComboBox
    Friend WithEvents txtKdWaktu As TextBox
    Friend WithEvents cboNamaMakanan As ComboBox
    Friend WithEvents txtKodeMakanan As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtExtraDiet As TextBox
    Friend WithEvents txtID As TextBox
    Private WithEvents btnBatal As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label6 As Label
    Friend WithEvents cboKategory As ComboBox
    Friend WithEvents btnSimpan As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtKdKategory As TextBox
End Class
