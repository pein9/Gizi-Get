<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInventarisEditor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInventarisEditor))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.VS2015LightTheme1 = New WeifenLuo.WinFormsUI.Docking.VS2015LightTheme()
        Me.epUser = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.vsRender = New WeifenLuo.WinFormsUI.Docking.VisualStudioToolStripExtender(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnBatal = New DevComponents.DotNetBar.ButtonX()
        Me.btnSimpan = New DevComponents.DotNetBar.ButtonX()
        Me.lblkodemakanan = New System.Windows.Forms.Label()
        Me.txtKodePermintaan = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Line3 = New DevComponents.DotNetBar.Controls.Line()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboKelas = New System.Windows.Forms.ComboBox()
        Me.txtKodeKelas = New System.Windows.Forms.TextBox()
        Me.txtJumlah = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSatuan = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Line1 = New DevComponents.DotNetBar.Controls.Line()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboKetInventaris = New System.Windows.Forms.ComboBox()
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
        Me.Panel1.Size = New System.Drawing.Size(339, 43)
        Me.Panel1.TabIndex = 20
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
        'epUser
        '
        Me.epUser.ContainerControl = Me
        '
        'vsRender
        '
        Me.vsRender.DefaultRenderer = Nothing
        '
        'StatusStrip1
        '
        Me.StatusStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 306)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(339, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 22
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnBatal)
        Me.Panel2.Controls.Add(Me.btnSimpan)
        Me.Panel2.Controls.Add(Me.lblkodemakanan)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 260)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(339, 46)
        Me.Panel2.TabIndex = 23
        '
        'btnBatal
        '
        Me.btnBatal.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnBatal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBatal.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnBatal.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnBatal.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBatal.Location = New System.Drawing.Point(267, 10)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(59, 24)
        Me.btnBatal.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnBatal.TabIndex = 205
        Me.btnBatal.Text = "Batal"
        '
        'btnSimpan
        '
        Me.btnSimpan.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSimpan.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSimpan.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSimpan.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnSimpan.Enabled = False
        Me.btnSimpan.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSimpan.Location = New System.Drawing.Point(202, 10)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(59, 24)
        Me.btnSimpan.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnSimpan.TabIndex = 204
        Me.btnSimpan.Text = "Simpan"
        '
        'lblkodemakanan
        '
        Me.lblkodemakanan.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblkodemakanan.Location = New System.Drawing.Point(11, 16)
        Me.lblkodemakanan.Name = "lblkodemakanan"
        Me.lblkodemakanan.Size = New System.Drawing.Size(124, 15)
        Me.lblkodemakanan.TabIndex = 36
        Me.lblkodemakanan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblkodemakanan.Visible = False
        '
        'txtKodePermintaan
        '
        Me.txtKodePermintaan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtKodePermintaan.Location = New System.Drawing.Point(107, 52)
        Me.txtKodePermintaan.MaxLength = 10
        Me.txtKodePermintaan.Name = "txtKodePermintaan"
        Me.txtKodePermintaan.ReadOnly = True
        Me.txtKodePermintaan.Size = New System.Drawing.Size(91, 20)
        Me.txtKodePermintaan.TabIndex = 24
        Me.txtKodePermintaan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(37, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 15)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Kode Alat :"
        '
        'Line3
        '
        Me.Line3.Location = New System.Drawing.Point(10, 75)
        Me.Line3.Name = "Line3"
        Me.Line3.Size = New System.Drawing.Size(320, 10)
        Me.Line3.TabIndex = 70
        Me.Line3.Text = "Line3"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(32, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 15)
        Me.Label2.TabIndex = 72
        Me.Label2.Text = "Nama Alat :"
        '
        'txtNama
        '
        Me.txtNama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNama.Location = New System.Drawing.Point(107, 90)
        Me.txtNama.MaxLength = 100
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(207, 20)
        Me.txtNama.TabIndex = 75
        Me.txtNama.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(59, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 15)
        Me.Label3.TabIndex = 78
        Me.Label3.Text = "Kelas :"
        '
        'cboKelas
        '
        Me.cboKelas.FormattingEnabled = True
        Me.cboKelas.Location = New System.Drawing.Point(107, 115)
        Me.cboKelas.Name = "cboKelas"
        Me.cboKelas.Size = New System.Drawing.Size(169, 21)
        Me.cboKelas.TabIndex = 76
        '
        'txtKodeKelas
        '
        Me.txtKodeKelas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtKodeKelas.Location = New System.Drawing.Point(15, 114)
        Me.txtKodeKelas.MaxLength = 10
        Me.txtKodeKelas.Name = "txtKodeKelas"
        Me.txtKodeKelas.ReadOnly = True
        Me.txtKodeKelas.Size = New System.Drawing.Size(33, 20)
        Me.txtKodeKelas.TabIndex = 77
        Me.txtKodeKelas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtKodeKelas.Visible = False
        '
        'txtJumlah
        '
        Me.txtJumlah.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtJumlah.Location = New System.Drawing.Point(107, 142)
        Me.txtJumlah.MaxLength = 10
        Me.txtJumlah.Name = "txtJumlah"
        Me.txtJumlah.Size = New System.Drawing.Size(65, 20)
        Me.txtJumlah.TabIndex = 80
        Me.txtJumlah.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(28, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 15)
        Me.Label4.TabIndex = 79
        Me.Label4.Text = "Jumlah Alat :"
        '
        'txtSatuan
        '
        Me.txtSatuan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSatuan.Location = New System.Drawing.Point(107, 168)
        Me.txtSatuan.MaxLength = 25
        Me.txtSatuan.Name = "txtSatuan"
        Me.txtSatuan.Size = New System.Drawing.Size(77, 20)
        Me.txtSatuan.TabIndex = 82
        Me.txtSatuan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(54, 170)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 15)
        Me.Label5.TabIndex = 81
        Me.Label5.Text = "Satuan :"
        '
        'Line1
        '
        Me.Line1.Location = New System.Drawing.Point(10, 230)
        Me.Line1.Name = "Line1"
        Me.Line1.Size = New System.Drawing.Size(320, 10)
        Me.Line1.TabIndex = 83
        Me.Line1.Text = "Line1"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(30, 197)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 15)
        Me.Label6.TabIndex = 85
        Me.Label6.Text = "Keterangan :"
        '
        'cboKetInventaris
        '
        Me.cboKetInventaris.FormattingEnabled = True
        Me.cboKetInventaris.Items.AddRange(New Object() {"Sekali Pakai", "Berulang Kali"})
        Me.cboKetInventaris.Location = New System.Drawing.Point(107, 194)
        Me.cboKetInventaris.Name = "cboKetInventaris"
        Me.cboKetInventaris.Size = New System.Drawing.Size(169, 21)
        Me.cboKetInventaris.TabIndex = 84
        '
        'frmInventarisEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(339, 328)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cboKetInventaris)
        Me.Controls.Add(Me.Line1)
        Me.Controls.Add(Me.txtSatuan)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtJumlah)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboKelas)
        Me.Controls.Add(Me.txtKodeKelas)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Line3)
        Me.Controls.Add(Me.txtKodePermintaan)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmInventarisEditor"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventaris Alat Makan Editor"
        Me.Panel1.ResumeLayout(False)
        CType(Me.epUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents VS2015LightTheme1 As WeifenLuo.WinFormsUI.Docking.VS2015LightTheme
    Friend WithEvents epUser As ErrorProvider
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents vsRender As WeifenLuo.WinFormsUI.Docking.VisualStudioToolStripExtender
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnBatal As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSimpan As DevComponents.DotNetBar.ButtonX
    Friend WithEvents lblkodemakanan As Label
    Friend WithEvents txtKodePermintaan As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Line3 As DevComponents.DotNetBar.Controls.Line
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cboKelas As ComboBox
    Friend WithEvents txtKodeKelas As TextBox
    Friend WithEvents txtSatuan As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtJumlah As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Line1 As DevComponents.DotNetBar.Controls.Line
    Friend WithEvents Label6 As Label
    Friend WithEvents cboKetInventaris As ComboBox
End Class
