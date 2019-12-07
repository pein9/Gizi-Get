<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPermintaanMakananEditor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPermintaanMakananEditor))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtKodePermintaan = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupContractable1 = New SIMRSGizi.GroupContractable(Me.components)
        Me.lblNoBed = New System.Windows.Forms.Label()
        Me.lblNoKamar = New System.Windows.Forms.Label()
        Me.lblTanggalMasuk = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Line1 = New DevComponents.DotNetBar.Controls.Line()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblNoRekamMedis = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblNamaPasien = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNoRegist = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Line2 = New DevComponents.DotNetBar.Controls.Line()
        Me.cboKelas = New System.Windows.Forms.ComboBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.lblNoKelas = New System.Windows.Forms.Label()
        Me.Line3 = New DevComponents.DotNetBar.Controls.Line()
        Me.GroupContractable2 = New SIMRSGizi.GroupContractable(Me.components)
        Me.GroupContractable1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(810, 55)
        Me.Panel1.TabIndex = 16
        '
        'txtKodePermintaan
        '
        Me.txtKodePermintaan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtKodePermintaan.Location = New System.Drawing.Point(175, 62)
        Me.txtKodePermintaan.MaxLength = 10
        Me.txtKodePermintaan.Name = "txtKodePermintaan"
        Me.txtKodePermintaan.ReadOnly = True
        Me.txtKodePermintaan.Size = New System.Drawing.Size(162, 20)
        Me.txtKodePermintaan.TabIndex = 17
        Me.txtKodePermintaan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(66, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 15)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Kode Permintaan :"
        '
        'GroupContractable1
        '
        Me.GroupContractable1.Controls.Add(Me.Label42)
        Me.GroupContractable1.Controls.Add(Me.lblNoBed)
        Me.GroupContractable1.Controls.Add(Me.lblNoKelas)
        Me.GroupContractable1.Controls.Add(Me.lblNoKamar)
        Me.GroupContractable1.Controls.Add(Me.lblTanggalMasuk)
        Me.GroupContractable1.Controls.Add(Me.cboKelas)
        Me.GroupContractable1.Controls.Add(Me.Label7)
        Me.GroupContractable1.Controls.Add(Me.Label6)
        Me.GroupContractable1.Controls.Add(Me.Line1)
        Me.GroupContractable1.Controls.Add(Me.Label4)
        Me.GroupContractable1.Controls.Add(Me.lblNoRekamMedis)
        Me.GroupContractable1.Controls.Add(Me.Label5)
        Me.GroupContractable1.Controls.Add(Me.lblNamaPasien)
        Me.GroupContractable1.Controls.Add(Me.Label3)
        Me.GroupContractable1.Controls.Add(Me.txtNoRegist)
        Me.GroupContractable1.Controls.Add(Me.Label2)
        Me.GroupContractable1.Controls.Add(Me.Line2)
        Me.GroupContractable1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupContractable1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupContractable1.Location = New System.Drawing.Point(8, 96)
        Me.GroupContractable1.MinimumSize = New System.Drawing.Size(0, 16)
        Me.GroupContractable1.Name = "GroupContractable1"
        Me.GroupContractable1.Size = New System.Drawing.Size(429, 347)
        Me.GroupContractable1.TabIndex = 19
        Me.GroupContractable1.TitleAling = SIMRSGizi.GroupContractable.enTitleAling.Left
        Me.GroupContractable1.TitleForeColor = System.Drawing.Color.Black
        Me.GroupContractable1.TitleText = "Data Pasien"
        '
        'lblNoBed
        '
        Me.lblNoBed.AutoSize = True
        Me.lblNoBed.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoBed.Location = New System.Drawing.Point(334, 134)
        Me.lblNoBed.Name = "lblNoBed"
        Me.lblNoBed.Size = New System.Drawing.Size(13, 15)
        Me.lblNoBed.TabIndex = 68
        Me.lblNoBed.Text = "?"
        '
        'lblNoKamar
        '
        Me.lblNoKamar.AutoSize = True
        Me.lblNoKamar.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoKamar.Location = New System.Drawing.Point(173, 134)
        Me.lblNoKamar.Name = "lblNoKamar"
        Me.lblNoKamar.Size = New System.Drawing.Size(13, 15)
        Me.lblNoKamar.TabIndex = 67
        Me.lblNoKamar.Text = "?"
        '
        'lblTanggalMasuk
        '
        Me.lblTanggalMasuk.AutoSize = True
        Me.lblTanggalMasuk.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTanggalMasuk.Location = New System.Drawing.Point(173, 111)
        Me.lblTanggalMasuk.Name = "lblTanggalMasuk"
        Me.lblTanggalMasuk.Size = New System.Drawing.Size(13, 15)
        Me.lblTanggalMasuk.TabIndex = 66
        Me.lblTanggalMasuk.Text = "?"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(277, 134)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 15)
        Me.Label7.TabIndex = 65
        Me.Label7.Text = "No Bed :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(100, 133)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 15)
        Me.Label6.TabIndex = 62
        Me.Label6.Text = "No Kamar :"
        '
        'Line1
        '
        Me.Line1.Location = New System.Drawing.Point(61, 97)
        Me.Line1.Name = "Line1"
        Me.Line1.Size = New System.Drawing.Size(353, 10)
        Me.Line1.TabIndex = 64
        Me.Line1.Text = "Line1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(72, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 15)
        Me.Label4.TabIndex = 63
        Me.Label4.Text = "Tanggal Masuk :"
        '
        'lblNoRekamMedis
        '
        Me.lblNoRekamMedis.AutoSize = True
        Me.lblNoRekamMedis.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoRekamMedis.Location = New System.Drawing.Point(173, 58)
        Me.lblNoRekamMedis.Name = "lblNoRekamMedis"
        Me.lblNoRekamMedis.Size = New System.Drawing.Size(13, 15)
        Me.lblNoRekamMedis.TabIndex = 61
        Me.lblNoRekamMedis.Text = "?"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(60, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 15)
        Me.Label5.TabIndex = 60
        Me.Label5.Text = "No. Rekam Medis :"
        '
        'lblNamaPasien
        '
        Me.lblNamaPasien.AutoSize = True
        Me.lblNamaPasien.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNamaPasien.Location = New System.Drawing.Point(173, 79)
        Me.lblNamaPasien.Name = "lblNamaPasien"
        Me.lblNamaPasien.Size = New System.Drawing.Size(13, 15)
        Me.lblNamaPasien.TabIndex = 59
        Me.lblNamaPasien.Text = "?"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(82, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 15)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Nama Pasien :"
        '
        'txtNoRegist
        '
        Me.txtNoRegist.Location = New System.Drawing.Point(167, 18)
        Me.txtNoRegist.MaxLength = 10
        Me.txtNoRegist.Name = "txtNoRegist"
        Me.txtNoRegist.Size = New System.Drawing.Size(225, 21)
        Me.txtNoRegist.TabIndex = 21
        Me.txtNoRegist.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(154, 15)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "No. Registrasi Rawat Inap :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Line2
        '
        Me.Line2.Location = New System.Drawing.Point(16, 42)
        Me.Line2.Name = "Line2"
        Me.Line2.Size = New System.Drawing.Size(398, 10)
        Me.Line2.TabIndex = 58
        Me.Line2.Text = "Line2"
        '
        'cboKelas
        '
        Me.cboKelas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboKelas.FormattingEnabled = True
        Me.cboKelas.Location = New System.Drawing.Point(167, 156)
        Me.cboKelas.Name = "cboKelas"
        Me.cboKelas.Size = New System.Drawing.Size(226, 21)
        Me.cboKelas.TabIndex = 20
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.Location = New System.Drawing.Point(124, 158)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(43, 15)
        Me.Label42.TabIndex = 21
        Me.Label42.Text = "Kelas :"
        '
        'lblNoKelas
        '
        Me.lblNoKelas.AutoSize = True
        Me.lblNoKelas.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoKelas.Location = New System.Drawing.Point(107, 158)
        Me.lblNoKelas.Name = "lblNoKelas"
        Me.lblNoKelas.Size = New System.Drawing.Size(11, 15)
        Me.lblNoKelas.TabIndex = 22
        Me.lblNoKelas.Text = "-"
        '
        'Line3
        '
        Me.Line3.Location = New System.Drawing.Point(8, 85)
        Me.Line3.Name = "Line3"
        Me.Line3.Size = New System.Drawing.Size(792, 10)
        Me.Line3.TabIndex = 69
        Me.Line3.Text = "Line3"
        '
        'GroupContractable2
        '
        Me.GroupContractable2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupContractable2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupContractable2.Location = New System.Drawing.Point(443, 96)
        Me.GroupContractable2.MinimumSize = New System.Drawing.Size(0, 16)
        Me.GroupContractable2.Name = "GroupContractable2"
        Me.GroupContractable2.Size = New System.Drawing.Size(357, 168)
        Me.GroupContractable2.TabIndex = 70
        Me.GroupContractable2.TitleAling = SIMRSGizi.GroupContractable.enTitleAling.Left
        Me.GroupContractable2.TitleForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupContractable2.TitleText = "Data Gizi"
        '
        'frmPermintaanMakananEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(810, 623)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupContractable2)
        Me.Controls.Add(Me.Line3)
        Me.Controls.Add(Me.txtKodePermintaan)
        Me.Controls.Add(Me.GroupContractable1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmPermintaanMakananEditor"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Permintaan Makanan dari Ruang Inap"
        Me.GroupContractable1.ResumeLayout(False)
        Me.GroupContractable1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtKodePermintaan As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupContractable1 As GroupContractable
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNoRegist As TextBox
    Friend WithEvents lblNamaPasien As Label
    Friend WithEvents Line2 As DevComponents.DotNetBar.Controls.Line
    Friend WithEvents lblNoRekamMedis As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Line1 As DevComponents.DotNetBar.Controls.Line
    Friend WithEvents Label4 As Label
    Friend WithEvents lblNoBed As Label
    Friend WithEvents lblNoKamar As Label
    Friend WithEvents lblTanggalMasuk As Label
    Friend WithEvents cboKelas As ComboBox
    Friend WithEvents Label42 As Label
    Friend WithEvents lblNoKelas As Label
    Friend WithEvents Line3 As DevComponents.DotNetBar.Controls.Line
    Friend WithEvents GroupContractable2 As GroupContractable
End Class
