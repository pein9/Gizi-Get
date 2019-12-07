<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDietEditor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDietEditor))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblKodeDiet = New System.Windows.Forms.Label()
        Me.cboLetter = New System.Windows.Forms.ComboBox()
        Me.cboKelompokBahan = New System.Windows.Forms.ComboBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.txtKodeKelompok = New System.Windows.Forms.TextBox()
        Me.Line1 = New DevComponents.DotNetBar.Controls.Line()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtnmDiet = New System.Windows.Forms.TextBox()
        Me.txtKeterangan = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Line2 = New DevComponents.DotNetBar.Controls.Line()
        Me.chkMenuUtama = New System.Windows.Forms.CheckBox()
        Me.chkExtra = New System.Windows.Forms.CheckBox()
        Me.chkSnackPagi = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Line3 = New DevComponents.DotNetBar.Controls.Line()
        Me.chkSnackSore = New System.Windows.Forms.CheckBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnBatal = New DevComponents.DotNetBar.ButtonX()
        Me.btnSimpan = New DevComponents.DotNetBar.ButtonX()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.vsRender = New WeifenLuo.WinFormsUI.Docking.VisualStudioToolStripExtender(Me.components)
        Me.VS2015LightTheme1 = New WeifenLuo.WinFormsUI.Docking.VS2015LightTheme()
        Me.epUser = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.epUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lblKodeDiet)
        Me.GroupBox1.Controls.Add(Me.cboLetter)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 51)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(249, 46)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Kode Diet"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 14)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Tipe :"
        '
        'lblKodeDiet
        '
        Me.lblKodeDiet.AutoSize = True
        Me.lblKodeDiet.Location = New System.Drawing.Point(129, 20)
        Me.lblKodeDiet.Name = "lblKodeDiet"
        Me.lblKodeDiet.Size = New System.Drawing.Size(11, 14)
        Me.lblKodeDiet.TabIndex = 9
        Me.lblKodeDiet.Text = "-"
        '
        'cboLetter
        '
        Me.cboLetter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLetter.FormattingEnabled = True
        Me.cboLetter.Items.AddRange(New Object() {"A", "B", "C", "D", "E", "F", "G", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"})
        Me.cboLetter.Location = New System.Drawing.Point(87, 16)
        Me.cboLetter.Name = "cboLetter"
        Me.cboLetter.Size = New System.Drawing.Size(36, 22)
        Me.cboLetter.TabIndex = 8
        '
        'cboKelompokBahan
        '
        Me.cboKelompokBahan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboKelompokBahan.FormattingEnabled = True
        Me.cboKelompokBahan.Location = New System.Drawing.Point(99, 130)
        Me.cboKelompokBahan.Name = "cboKelompokBahan"
        Me.cboKelompokBahan.Size = New System.Drawing.Size(162, 21)
        Me.cboKelompokBahan.TabIndex = 32
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.Location = New System.Drawing.Point(22, 109)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(86, 15)
        Me.Label42.TabIndex = 33
        Me.Label42.Text = "Kelompok Diet"
        '
        'txtKodeKelompok
        '
        Me.txtKodeKelompok.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtKodeKelompok.Location = New System.Drawing.Point(129, 108)
        Me.txtKodeKelompok.MaxLength = 10
        Me.txtKodeKelompok.Name = "txtKodeKelompok"
        Me.txtKodeKelompok.ReadOnly = True
        Me.txtKodeKelompok.Size = New System.Drawing.Size(33, 20)
        Me.txtKodeKelompok.TabIndex = 34
        Me.txtKodeKelompok.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Line1
        '
        Me.Line1.Location = New System.Drawing.Point(12, 112)
        Me.Line1.Name = "Line1"
        Me.Line1.Size = New System.Drawing.Size(249, 12)
        Me.Line1.TabIndex = 35
        Me.Line1.Text = "Line1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(68, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 15)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Kel :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(28, 159)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 15)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Nama Diet :"
        '
        'txtnmDiet
        '
        Me.txtnmDiet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnmDiet.Location = New System.Drawing.Point(99, 157)
        Me.txtnmDiet.MaxLength = 10
        Me.txtnmDiet.Name = "txtnmDiet"
        Me.txtnmDiet.Size = New System.Drawing.Size(139, 20)
        Me.txtnmDiet.TabIndex = 38
        Me.txtnmDiet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtKeterangan
        '
        Me.txtKeterangan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtKeterangan.Location = New System.Drawing.Point(99, 183)
        Me.txtKeterangan.MaxLength = 10
        Me.txtKeterangan.Name = "txtKeterangan"
        Me.txtKeterangan.Size = New System.Drawing.Size(162, 20)
        Me.txtKeterangan.TabIndex = 40
        Me.txtKeterangan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(22, 186)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 15)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Keterangan :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(22, 225)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 15)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Menu Diet"
        '
        'Line2
        '
        Me.Line2.Location = New System.Drawing.Point(12, 228)
        Me.Line2.Name = "Line2"
        Me.Line2.Size = New System.Drawing.Size(249, 12)
        Me.Line2.TabIndex = 42
        Me.Line2.Text = "Line2"
        '
        'chkMenuUtama
        '
        Me.chkMenuUtama.AutoSize = True
        Me.chkMenuUtama.Location = New System.Drawing.Point(25, 247)
        Me.chkMenuUtama.Name = "chkMenuUtama"
        Me.chkMenuUtama.Size = New System.Drawing.Size(87, 17)
        Me.chkMenuUtama.TabIndex = 44
        Me.chkMenuUtama.Text = "Menu Utama"
        Me.chkMenuUtama.UseVisualStyleBackColor = True
        '
        'chkExtra
        '
        Me.chkExtra.AutoSize = True
        Me.chkExtra.Location = New System.Drawing.Point(99, 209)
        Me.chkExtra.Name = "chkExtra"
        Me.chkExtra.Size = New System.Drawing.Size(72, 17)
        Me.chkExtra.TabIndex = 45
        Me.chkExtra.Text = "Extra Diet"
        Me.chkExtra.UseVisualStyleBackColor = True
        '
        'chkSnackPagi
        '
        Me.chkSnackPagi.AutoSize = True
        Me.chkSnackPagi.Location = New System.Drawing.Point(25, 289)
        Me.chkSnackPagi.Name = "chkSnackPagi"
        Me.chkSnackPagi.Size = New System.Drawing.Size(81, 17)
        Me.chkSnackPagi.TabIndex = 46
        Me.chkSnackPagi.Text = "Snack Pagi"
        Me.chkSnackPagi.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(22, 267)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 15)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "Pilihan Snack"
        '
        'Line3
        '
        Me.Line3.Location = New System.Drawing.Point(12, 270)
        Me.Line3.Name = "Line3"
        Me.Line3.Size = New System.Drawing.Size(249, 12)
        Me.Line3.TabIndex = 48
        Me.Line3.Text = "Line3"
        '
        'chkSnackSore
        '
        Me.chkSnackSore.AutoSize = True
        Me.chkSnackSore.Location = New System.Drawing.Point(144, 289)
        Me.chkSnackSore.Name = "chkSnackSore"
        Me.chkSnackSore.Size = New System.Drawing.Size(82, 17)
        Me.chkSnackSore.TabIndex = 49
        Me.chkSnackSore.Text = "Snack Sore"
        Me.chkSnackSore.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnBatal)
        Me.Panel2.Controls.Add(Me.btnSimpan)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 311)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(280, 55)
        Me.Panel2.TabIndex = 51
        '
        'btnBatal
        '
        Me.btnBatal.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnBatal.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnBatal.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnBatal.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBatal.Location = New System.Drawing.Point(174, 8)
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
        Me.btnSimpan.Location = New System.Drawing.Point(76, 8)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(87, 37)
        Me.btnSimpan.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnSimpan.TabIndex = 204
        Me.btnSimpan.Text = "Simpan"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 366)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(280, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 50
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(280, 43)
        Me.Panel1.TabIndex = 52
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
        'vsRender
        '
        Me.vsRender.DefaultRenderer = Nothing
        '
        'epUser
        '
        Me.epUser.ContainerControl = Me
        '
        'frmDietEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(280, 388)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.chkSnackSore)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Line3)
        Me.Controls.Add(Me.chkSnackPagi)
        Me.Controls.Add(Me.chkExtra)
        Me.Controls.Add(Me.chkMenuUtama)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Line2)
        Me.Controls.Add(Me.txtKeterangan)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtnmDiet)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboKelompokBahan)
        Me.Controls.Add(Me.Label42)
        Me.Controls.Add(Me.txtKodeKelompok)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Line1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmDietEditor"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Diet Editor"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.epUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cboLetter As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblKodeDiet As Label
    Friend WithEvents cboKelompokBahan As ComboBox
    Friend WithEvents Label42 As Label
    Friend WithEvents txtKodeKelompok As TextBox
    Friend WithEvents Line1 As DevComponents.DotNetBar.Controls.Line
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtnmDiet As TextBox
    Friend WithEvents txtKeterangan As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Line2 As DevComponents.DotNetBar.Controls.Line
    Friend WithEvents chkMenuUtama As CheckBox
    Friend WithEvents chkExtra As CheckBox
    Friend WithEvents chkSnackPagi As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Line3 As DevComponents.DotNetBar.Controls.Line
    Friend WithEvents chkSnackSore As CheckBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents btnBatal As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSimpan As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents vsRender As WeifenLuo.WinFormsUI.Docking.VisualStudioToolStripExtender
    Friend WithEvents VS2015LightTheme1 As WeifenLuo.WinFormsUI.Docking.VS2015LightTheme
    Friend WithEvents epUser As ErrorProvider
End Class
