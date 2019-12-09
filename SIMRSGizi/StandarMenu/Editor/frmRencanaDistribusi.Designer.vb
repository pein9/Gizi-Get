<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRencanaDistribusi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRencanaDistribusi))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnBatal = New DevComponents.DotNetBar.ButtonX()
        Me.btnSimpan = New DevComponents.DotNetBar.ButtonX()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.VS2015LightTheme1 = New WeifenLuo.WinFormsUI.Docking.VS2015LightTheme()
        Me.vsRender = New WeifenLuo.WinFormsUI.Docking.VisualStudioToolStripExtender(Me.components)
        Me.epUser = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblKdPermintaan = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTanggalPermintaan = New System.Windows.Forms.Label()
        Me.lblWaktu = New System.Windows.Forms.Label()
        Me.tmrBlink = New System.Windows.Forms.Timer(Me.components)
        Me.Line2 = New DevComponents.DotNetBar.Controls.Line()
        Me.lblRencanaDistribusi = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.lblIDSnack = New System.Windows.Forms.Label()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.cboSnack = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.dgvRencanaMenu = New System.Windows.Forms.DataGridView()
        Me.Choices = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Line3 = New DevComponents.DotNetBar.Controls.Line()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Line4 = New DevComponents.DotNetBar.Controls.Line()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.dgvPermintaanMenu = New System.Windows.Forms.DataGridView()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idSiklus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nmMenuMakanan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nmExtra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupContractable3 = New SIMRSGizi.GroupContractable(Me.components)
        Me.lblBentukMakanan = New System.Windows.Forms.Label()
        Me.lblNamaDiet = New System.Windows.Forms.Label()
        Me.lblDiagnosaGizi = New System.Windows.Forms.Label()
        Me.lblKetDiet = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.lblExtraDiet = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GroupContractable2 = New SIMRSGizi.GroupContractable(Me.components)
        Me.lblIMT = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblLLA = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblLK = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblTB = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblBB = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupContractable1 = New SIMRSGizi.GroupContractable(Me.components)
        Me.lblAlergi = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblTglMasuk = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblJenisKelamin = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblTglLahir = New System.Windows.Forms.Label()
        Me.Line1 = New DevComponents.DotNetBar.Controls.Line()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblNamaPasien = New System.Windows.Forms.Label()
        Me.lblkdRawatInap = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblNoDaftarRawatInap = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblNoRM = New System.Windows.Forms.Label()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2.SuspendLayout()
        CType(Me.epUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvRencanaMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.dgvPermintaanMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupContractable3.SuspendLayout()
        Me.GroupContractable2.SuspendLayout()
        Me.GroupContractable1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnBatal)
        Me.Panel2.Controls.Add(Me.btnSimpan)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 830)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(945, 55)
        Me.Panel2.TabIndex = 58
        '
        'btnBatal
        '
        Me.btnBatal.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnBatal.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnBatal.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnBatal.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBatal.Location = New System.Drawing.Point(837, 8)
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
        Me.btnSimpan.Location = New System.Drawing.Point(735, 8)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(87, 37)
        Me.btnSimpan.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnSimpan.TabIndex = 204
        Me.btnSimpan.Text = "Simpan"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 885)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(945, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 57
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
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(945, 52)
        Me.Panel1.TabIndex = 59
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(50, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 14)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "No. Permintaan :"
        '
        'lblKdPermintaan
        '
        Me.lblKdPermintaan.AutoSize = True
        Me.lblKdPermintaan.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKdPermintaan.Location = New System.Drawing.Point(147, 66)
        Me.lblKdPermintaan.Name = "lblKdPermintaan"
        Me.lblKdPermintaan.Size = New System.Drawing.Size(11, 14)
        Me.lblKdPermintaan.TabIndex = 61
        Me.lblKdPermintaan.Text = "-"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(627, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 14)
        Me.Label3.TabIndex = 67
        Me.Label3.Text = "Tanggal Permintaan :"
        '
        'lblTanggalPermintaan
        '
        Me.lblTanggalPermintaan.AutoSize = True
        Me.lblTanggalPermintaan.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTanggalPermintaan.Location = New System.Drawing.Point(752, 67)
        Me.lblTanggalPermintaan.Name = "lblTanggalPermintaan"
        Me.lblTanggalPermintaan.Size = New System.Drawing.Size(11, 14)
        Me.lblTanggalPermintaan.TabIndex = 68
        Me.lblTanggalPermintaan.Text = "-"
        '
        'lblWaktu
        '
        Me.lblWaktu.AutoSize = True
        Me.lblWaktu.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWaktu.Location = New System.Drawing.Point(752, 84)
        Me.lblWaktu.Name = "lblWaktu"
        Me.lblWaktu.Size = New System.Drawing.Size(11, 14)
        Me.lblWaktu.TabIndex = 75
        Me.lblWaktu.Text = "-"
        '
        'tmrBlink
        '
        Me.tmrBlink.Interval = 500
        '
        'Line2
        '
        Me.Line2.Location = New System.Drawing.Point(3, 101)
        Me.Line2.Name = "Line2"
        Me.Line2.Size = New System.Drawing.Size(938, 8)
        Me.Line2.TabIndex = 79
        Me.Line2.Text = "Line2"
        '
        'lblRencanaDistribusi
        '
        Me.lblRencanaDistribusi.AutoSize = True
        Me.lblRencanaDistribusi.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRencanaDistribusi.Location = New System.Drawing.Point(147, 84)
        Me.lblRencanaDistribusi.Name = "lblRencanaDistribusi"
        Me.lblRencanaDistribusi.Size = New System.Drawing.Size(11, 14)
        Me.lblRencanaDistribusi.TabIndex = 210
        Me.lblRencanaDistribusi.Text = "-"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(9, 84)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(138, 14)
        Me.Label23.TabIndex = 209
        Me.Label23.Text = "No. Rencana Distribusi :"
        '
        'lblIDSnack
        '
        Me.lblIDSnack.AutoSize = True
        Me.lblIDSnack.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDSnack.Location = New System.Drawing.Point(404, 562)
        Me.lblIDSnack.Name = "lblIDSnack"
        Me.lblIDSnack.Size = New System.Drawing.Size(12, 14)
        Me.lblIDSnack.TabIndex = 83
        Me.lblIDSnack.Text = "-"
        Me.lblIDSnack.Visible = False
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX1.Location = New System.Drawing.Point(348, 558)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(50, 21)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.TabIndex = 205
        Me.ButtonX1.Text = "+"
        Me.ButtonX1.Visible = False
        '
        'cboSnack
        '
        Me.cboSnack.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSnack.FormattingEnabled = True
        Me.cboSnack.Location = New System.Drawing.Point(135, 558)
        Me.cboSnack.Name = "cboSnack"
        Me.cboSnack.Size = New System.Drawing.Size(207, 21)
        Me.cboSnack.TabIndex = 87
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(58, 562)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(78, 13)
        Me.Label19.TabIndex = 86
        Me.Label19.Text = "Pilihan Snack :"
        '
        'dgvRencanaMenu
        '
        Me.dgvRencanaMenu.AllowUserToAddRows = False
        Me.dgvRencanaMenu.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.dgvRencanaMenu.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvRencanaMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRencanaMenu.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Choices, Me.idSiklus, Me.nmMenuMakanan, Me.nmExtra})
        Me.dgvRencanaMenu.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvRencanaMenu.Location = New System.Drawing.Point(0, 585)
        Me.dgvRencanaMenu.Name = "dgvRencanaMenu"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRencanaMenu.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvRencanaMenu.RowHeadersVisible = False
        Me.dgvRencanaMenu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvRencanaMenu.Size = New System.Drawing.Size(945, 245)
        Me.dgvRencanaMenu.TabIndex = 88
        '
        'Choices
        '
        Me.Choices.HeaderText = "Pilih"
        Me.Choices.Name = "Choices"
        Me.Choices.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'Line3
        '
        Me.Line3.Location = New System.Drawing.Point(-1, 542)
        Me.Line3.Name = "Line3"
        Me.Line3.Size = New System.Drawing.Size(954, 8)
        Me.Line3.TabIndex = 89
        Me.Line3.Text = "Line3"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(12, 539)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(269, 14)
        Me.Label22.TabIndex = 90
        Me.Label22.Text = "Daftar Rencana Menu yang akan didistribusikan"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(12, 372)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(140, 14)
        Me.Label24.TabIndex = 212
        Me.Label24.Text = "Rincian Permintaan Diet"
        '
        'Line4
        '
        Me.Line4.Location = New System.Drawing.Point(-1, 375)
        Me.Line4.Name = "Line4"
        Me.Line4.Size = New System.Drawing.Size(954, 8)
        Me.Line4.TabIndex = 211
        Me.Line4.Text = "Line4"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.dgvPermintaanMenu)
        Me.Panel3.Location = New System.Drawing.Point(0, 389)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(957, 146)
        Me.Panel3.TabIndex = 213
        '
        'dgvPermintaanMenu
        '
        Me.dgvPermintaanMenu.AllowUserToAddRows = False
        Me.dgvPermintaanMenu.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.dgvPermintaanMenu.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvPermintaanMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPermintaanMenu.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvPermintaanMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvPermintaanMenu.Location = New System.Drawing.Point(0, 0)
        Me.dgvPermintaanMenu.Name = "dgvPermintaanMenu"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPermintaanMenu.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvPermintaanMenu.RowHeadersVisible = False
        Me.dgvPermintaanMenu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvPermintaanMenu.Size = New System.Drawing.Size(957, 146)
        Me.dgvPermintaanMenu.TabIndex = 89
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Pilih"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID Siklus"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nmMakanan"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Kode Makanan"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "extraDiet"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Nama Menu"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'idSiklus
        '
        Me.idSiklus.DataPropertyName = "id"
        Me.idSiklus.HeaderText = "ID Siklus"
        Me.idSiklus.Name = "idSiklus"
        Me.idSiklus.Visible = False
        '
        'nmMenuMakanan
        '
        Me.nmMenuMakanan.DataPropertyName = "nmMakanan"
        Me.nmMenuMakanan.HeaderText = "Nama Menu"
        Me.nmMenuMakanan.Name = "nmMenuMakanan"
        '
        'nmExtra
        '
        Me.nmExtra.DataPropertyName = "extraDiet"
        Me.nmExtra.HeaderText = "Keterangan"
        Me.nmExtra.Name = "nmExtra"
        Me.nmExtra.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'GroupContractable3
        '
        Me.GroupContractable3.Controls.Add(Me.lblBentukMakanan)
        Me.GroupContractable3.Controls.Add(Me.lblNamaDiet)
        Me.GroupContractable3.Controls.Add(Me.lblDiagnosaGizi)
        Me.GroupContractable3.Controls.Add(Me.lblKetDiet)
        Me.GroupContractable3.Controls.Add(Me.Label21)
        Me.GroupContractable3.Controls.Add(Me.Label20)
        Me.GroupContractable3.Controls.Add(Me.lblExtraDiet)
        Me.GroupContractable3.Controls.Add(Me.Label18)
        Me.GroupContractable3.Controls.Add(Me.Label17)
        Me.GroupContractable3.Controls.Add(Me.Label16)
        Me.GroupContractable3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupContractable3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupContractable3.Location = New System.Drawing.Point(414, 265)
        Me.GroupContractable3.MinimumSize = New System.Drawing.Size(0, 16)
        Me.GroupContractable3.Name = "GroupContractable3"
        Me.GroupContractable3.Size = New System.Drawing.Size(527, 104)
        Me.GroupContractable3.TabIndex = 77
        Me.GroupContractable3.TitleAling = SIMRSGizi.GroupContractable.enTitleAling.Left
        Me.GroupContractable3.TitleForeColor = System.Drawing.Color.Black
        Me.GroupContractable3.TitleText = "Dokter Penganggung Jawab"
        '
        'lblBentukMakanan
        '
        Me.lblBentukMakanan.AutoSize = True
        Me.lblBentukMakanan.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBentukMakanan.Location = New System.Drawing.Point(106, 49)
        Me.lblBentukMakanan.Name = "lblBentukMakanan"
        Me.lblBentukMakanan.Size = New System.Drawing.Size(11, 14)
        Me.lblBentukMakanan.TabIndex = 79
        Me.lblBentukMakanan.Text = "-"
        '
        'lblNamaDiet
        '
        Me.lblNamaDiet.AutoSize = True
        Me.lblNamaDiet.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNamaDiet.Location = New System.Drawing.Point(106, 73)
        Me.lblNamaDiet.Name = "lblNamaDiet"
        Me.lblNamaDiet.Size = New System.Drawing.Size(11, 14)
        Me.lblNamaDiet.TabIndex = 80
        Me.lblNamaDiet.Text = "-"
        '
        'lblDiagnosaGizi
        '
        Me.lblDiagnosaGizi.AutoSize = True
        Me.lblDiagnosaGizi.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiagnosaGizi.Location = New System.Drawing.Point(106, 25)
        Me.lblDiagnosaGizi.Name = "lblDiagnosaGizi"
        Me.lblDiagnosaGizi.Size = New System.Drawing.Size(11, 14)
        Me.lblDiagnosaGizi.TabIndex = 76
        Me.lblDiagnosaGizi.Text = "-"
        '
        'lblKetDiet
        '
        Me.lblKetDiet.AutoSize = True
        Me.lblKetDiet.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKetDiet.Location = New System.Drawing.Point(340, 74)
        Me.lblKetDiet.Name = "lblKetDiet"
        Me.lblKetDiet.Size = New System.Drawing.Size(11, 14)
        Me.lblKetDiet.TabIndex = 85
        Me.lblKetDiet.Text = "-"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(224, 73)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(113, 13)
        Me.Label21.TabIndex = 84
        Me.Label21.Text = "Ket. Permintaan Diet :"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(42, 73)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(69, 13)
        Me.Label20.TabIndex = 81
        Me.Label20.Text = "Jumlah Diet :"
        '
        'lblExtraDiet
        '
        Me.lblExtraDiet.AutoSize = True
        Me.lblExtraDiet.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExtraDiet.Location = New System.Drawing.Point(340, 52)
        Me.lblExtraDiet.Name = "lblExtraDiet"
        Me.lblExtraDiet.Size = New System.Drawing.Size(11, 14)
        Me.lblExtraDiet.TabIndex = 83
        Me.lblExtraDiet.Text = "-"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(275, 51)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(62, 13)
        Me.Label18.TabIndex = 82
        Me.Label18.Text = "Extra Diet :"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(34, 24)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(77, 13)
        Me.Label17.TabIndex = 78
        Me.Label17.Text = "Diagnosa Gizi :"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(18, 49)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(93, 13)
        Me.Label16.TabIndex = 77
        Me.Label16.Text = "Bentuk Makanan :"
        '
        'GroupContractable2
        '
        Me.GroupContractable2.Controls.Add(Me.lblIMT)
        Me.GroupContractable2.Controls.Add(Me.Label15)
        Me.GroupContractable2.Controls.Add(Me.lblLLA)
        Me.GroupContractable2.Controls.Add(Me.Label14)
        Me.GroupContractable2.Controls.Add(Me.lblLK)
        Me.GroupContractable2.Controls.Add(Me.Label13)
        Me.GroupContractable2.Controls.Add(Me.lblTB)
        Me.GroupContractable2.Controls.Add(Me.Label11)
        Me.GroupContractable2.Controls.Add(Me.lblBB)
        Me.GroupContractable2.Controls.Add(Me.Label10)
        Me.GroupContractable2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupContractable2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupContractable2.Location = New System.Drawing.Point(4, 263)
        Me.GroupContractable2.MinimumSize = New System.Drawing.Size(0, 16)
        Me.GroupContractable2.Name = "GroupContractable2"
        Me.GroupContractable2.Size = New System.Drawing.Size(408, 106)
        Me.GroupContractable2.TabIndex = 76
        Me.GroupContractable2.TitleAling = SIMRSGizi.GroupContractable.enTitleAling.Left
        Me.GroupContractable2.TitleForeColor = System.Drawing.Color.Black
        Me.GroupContractable2.TitleText = "Indeks Masa Tubuh"
        '
        'lblIMT
        '
        Me.lblIMT.AutoSize = True
        Me.lblIMT.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIMT.Location = New System.Drawing.Point(143, 75)
        Me.lblIMT.Name = "lblIMT"
        Me.lblIMT.Size = New System.Drawing.Size(12, 14)
        Me.lblIMT.TabIndex = 81
        Me.lblIMT.Text = "-"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(111, 75)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(32, 13)
        Me.Label15.TabIndex = 82
        Me.Label15.Text = "IMT :"
        '
        'lblLLA
        '
        Me.lblLLA.AutoSize = True
        Me.lblLLA.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLLA.Location = New System.Drawing.Point(327, 52)
        Me.lblLLA.Name = "lblLLA"
        Me.lblLLA.Size = New System.Drawing.Size(11, 14)
        Me.lblLLA.TabIndex = 80
        Me.lblLLA.Text = "-"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(221, 52)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(111, 13)
        Me.Label14.TabIndex = 79
        Me.Label14.Text = "Lingkar Lengan Atas :"
        '
        'lblLK
        '
        Me.lblLK.AutoSize = True
        Me.lblLK.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLK.Location = New System.Drawing.Point(327, 26)
        Me.lblLK.Name = "lblLK"
        Me.lblLK.Size = New System.Drawing.Size(11, 14)
        Me.lblLK.TabIndex = 77
        Me.lblLK.Text = "-"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(249, 26)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(83, 13)
        Me.Label13.TabIndex = 78
        Me.Label13.Text = "Lingkar Kepala :"
        '
        'lblTB
        '
        Me.lblTB.AutoSize = True
        Me.lblTB.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTB.Location = New System.Drawing.Point(143, 52)
        Me.lblTB.Name = "lblTB"
        Me.lblTB.Size = New System.Drawing.Size(11, 14)
        Me.lblTB.TabIndex = 76
        Me.lblTB.Text = "-"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(68, 51)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(75, 13)
        Me.Label11.TabIndex = 76
        Me.Label11.Text = "Tinggi Badan :"
        '
        'lblBB
        '
        Me.lblBB.AutoSize = True
        Me.lblBB.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBB.Location = New System.Drawing.Point(143, 26)
        Me.lblBB.Name = "lblBB"
        Me.lblBB.Size = New System.Drawing.Size(11, 14)
        Me.lblBB.TabIndex = 75
        Me.lblBB.Text = "-"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(70, 26)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(73, 13)
        Me.Label10.TabIndex = 75
        Me.Label10.Text = "Berat Badan :"
        '
        'GroupContractable1
        '
        Me.GroupContractable1.Controls.Add(Me.lblAlergi)
        Me.GroupContractable1.Controls.Add(Me.Label12)
        Me.GroupContractable1.Controls.Add(Me.Label9)
        Me.GroupContractable1.Controls.Add(Me.lblTglMasuk)
        Me.GroupContractable1.Controls.Add(Me.Label7)
        Me.GroupContractable1.Controls.Add(Me.lblJenisKelamin)
        Me.GroupContractable1.Controls.Add(Me.Label8)
        Me.GroupContractable1.Controls.Add(Me.lblTglLahir)
        Me.GroupContractable1.Controls.Add(Me.Line1)
        Me.GroupContractable1.Controls.Add(Me.Label6)
        Me.GroupContractable1.Controls.Add(Me.lblNamaPasien)
        Me.GroupContractable1.Controls.Add(Me.lblkdRawatInap)
        Me.GroupContractable1.Controls.Add(Me.Label5)
        Me.GroupContractable1.Controls.Add(Me.lblNoDaftarRawatInap)
        Me.GroupContractable1.Controls.Add(Me.Label4)
        Me.GroupContractable1.Controls.Add(Me.Label2)
        Me.GroupContractable1.Controls.Add(Me.lblNoRM)
        Me.GroupContractable1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupContractable1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupContractable1.Location = New System.Drawing.Point(4, 107)
        Me.GroupContractable1.MinimumSize = New System.Drawing.Size(0, 16)
        Me.GroupContractable1.Name = "GroupContractable1"
        Me.GroupContractable1.Size = New System.Drawing.Size(937, 163)
        Me.GroupContractable1.TabIndex = 66
        Me.GroupContractable1.TitleAling = SIMRSGizi.GroupContractable.enTitleAling.Left
        Me.GroupContractable1.TitleForeColor = System.Drawing.Color.Black
        Me.GroupContractable1.TitleText = "Data Pasien"
        '
        'lblAlergi
        '
        Me.lblAlergi.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAlergi.AutoSize = True
        Me.lblAlergi.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlergi.Location = New System.Drawing.Point(750, 132)
        Me.lblAlergi.Name = "lblAlergi"
        Me.lblAlergi.Size = New System.Drawing.Size(11, 14)
        Me.lblAlergi.TabIndex = 81
        Me.lblAlergi.Text = "-"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(706, 133)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(41, 13)
        Me.Label12.TabIndex = 80
        Me.Label12.Text = "Alergi :"
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(588, 75)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(159, 14)
        Me.Label9.TabIndex = 69
        Me.Label9.Text = "Tanggal Masuk Rawat Inap :"
        '
        'lblTglMasuk
        '
        Me.lblTglMasuk.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTglMasuk.AutoSize = True
        Me.lblTglMasuk.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTglMasuk.Location = New System.Drawing.Point(750, 77)
        Me.lblTglMasuk.Name = "lblTglMasuk"
        Me.lblTglMasuk.Size = New System.Drawing.Size(11, 14)
        Me.lblTglMasuk.TabIndex = 70
        Me.lblTglMasuk.Text = "-"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(66, 133)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 13)
        Me.Label7.TabIndex = 73
        Me.Label7.Text = "Jenis Kelamin :"
        '
        'lblJenisKelamin
        '
        Me.lblJenisKelamin.AutoSize = True
        Me.lblJenisKelamin.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJenisKelamin.Location = New System.Drawing.Point(142, 133)
        Me.lblJenisKelamin.Name = "lblJenisKelamin"
        Me.lblJenisKelamin.Size = New System.Drawing.Size(11, 14)
        Me.lblJenisKelamin.TabIndex = 74
        Me.lblJenisKelamin.Text = "-"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(65, 107)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 13)
        Me.Label8.TabIndex = 71
        Me.Label8.Text = "Tanggal Lahir :"
        '
        'lblTglLahir
        '
        Me.lblTglLahir.AutoSize = True
        Me.lblTglLahir.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTglLahir.Location = New System.Drawing.Point(142, 107)
        Me.lblTglLahir.Name = "lblTglLahir"
        Me.lblTglLahir.Size = New System.Drawing.Size(11, 14)
        Me.lblTglLahir.TabIndex = 72
        Me.lblTglLahir.Text = "-"
        '
        'Line1
        '
        Me.Line1.Location = New System.Drawing.Point(13, 94)
        Me.Line1.Name = "Line1"
        Me.Line1.Size = New System.Drawing.Size(916, 8)
        Me.Line1.TabIndex = 70
        Me.Line1.Text = "Line1"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(68, 77)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 13)
        Me.Label6.TabIndex = 68
        Me.Label6.Text = "Nama Pasien :"
        '
        'lblNamaPasien
        '
        Me.lblNamaPasien.AutoSize = True
        Me.lblNamaPasien.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNamaPasien.Location = New System.Drawing.Point(142, 77)
        Me.lblNamaPasien.Name = "lblNamaPasien"
        Me.lblNamaPasien.Size = New System.Drawing.Size(11, 14)
        Me.lblNamaPasien.TabIndex = 69
        Me.lblNamaPasien.Text = "-"
        '
        'lblkdRawatInap
        '
        Me.lblkdRawatInap.AutoSize = True
        Me.lblkdRawatInap.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblkdRawatInap.Location = New System.Drawing.Point(750, 51)
        Me.lblkdRawatInap.Name = "lblkdRawatInap"
        Me.lblkdRawatInap.Size = New System.Drawing.Size(11, 14)
        Me.lblkdRawatInap.TabIndex = 67
        Me.lblkdRawatInap.Text = "-"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(702, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 66
        Me.Label5.Text = "Ruang :"
        '
        'lblNoDaftarRawatInap
        '
        Me.lblNoDaftarRawatInap.AutoSize = True
        Me.lblNoDaftarRawatInap.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoDaftarRawatInap.Location = New System.Drawing.Point(750, 26)
        Me.lblNoDaftarRawatInap.Name = "lblNoDaftarRawatInap"
        Me.lblNoDaftarRawatInap.Size = New System.Drawing.Size(11, 14)
        Me.lblNoDaftarRawatInap.TabIndex = 65
        Me.lblNoDaftarRawatInap.Text = "-"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(623, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 13)
        Me.Label4.TabIndex = 64
        Me.Label4.Text = "No. Daftar Rawat Inap :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(94, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 62
        Me.Label2.Text = "No. RM :"
        '
        'lblNoRM
        '
        Me.lblNoRM.AutoSize = True
        Me.lblNoRM.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoRM.Location = New System.Drawing.Point(143, 26)
        Me.lblNoRM.Name = "lblNoRM"
        Me.lblNoRM.Size = New System.Drawing.Size(11, 14)
        Me.lblNoRM.TabIndex = 63
        Me.lblNoRM.Text = "-"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Extra Menu"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'frmRencanaDistribusi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(945, 907)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Line4)
        Me.Controls.Add(Me.lblRencanaDistribusi)
        Me.Controls.Add(Me.dgvRencanaMenu)
        Me.Controls.Add(Me.lblIDSnack)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.ButtonX1)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.cboSnack)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Line3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Line2)
        Me.Controls.Add(Me.GroupContractable3)
        Me.Controls.Add(Me.GroupContractable2)
        Me.Controls.Add(Me.lblWaktu)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblTanggalPermintaan)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblKdPermintaan)
        Me.Controls.Add(Me.GroupContractable1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmRencanaDistribusi"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rencana Distribusi"
        Me.Panel2.ResumeLayout(False)
        CType(Me.epUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvRencanaMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.dgvPermintaanMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupContractable3.ResumeLayout(False)
        Me.GroupContractable3.PerformLayout()
        Me.GroupContractable2.ResumeLayout(False)
        Me.GroupContractable2.PerformLayout()
        Me.GroupContractable1.ResumeLayout(False)
        Me.GroupContractable1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnBatal As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSimpan As DevComponents.DotNetBar.ButtonX
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents VS2015LightTheme1 As WeifenLuo.WinFormsUI.Docking.VS2015LightTheme
    Friend WithEvents vsRender As WeifenLuo.WinFormsUI.Docking.VisualStudioToolStripExtender
    Friend WithEvents epUser As ErrorProvider
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblKdPermintaan As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblNoRM As Label
    Friend WithEvents lblNoDaftarRawatInap As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupContractable1 As GroupContractable
    Friend WithEvents lblkdRawatInap As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblTanggalPermintaan As Label
    Friend WithEvents Line1 As DevComponents.DotNetBar.Controls.Line
    Friend WithEvents Label6 As Label
    Friend WithEvents lblNamaPasien As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblTglLahir As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblJenisKelamin As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblTglMasuk As Label
    Friend WithEvents lblWaktu As Label
    Friend WithEvents GroupContractable2 As GroupContractable
    Friend WithEvents lblTB As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lblBB As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblLK As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lblLLA As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents lblIMT As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents tmrBlink As Timer
    Friend WithEvents GroupContractable3 As GroupContractable
    Friend WithEvents lblDiagnosaGizi As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents lblBentukMakanan As Label
    Friend WithEvents lblKetDiet As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents lblExtraDiet As Label
    Friend WithEvents lblNamaDiet As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Line2 As DevComponents.DotNetBar.Controls.Line
    Friend WithEvents lblAlergi As Label
    Friend WithEvents cboSnack As ComboBox
    Friend WithEvents Label19 As Label
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents lblRencanaDistribusi As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents lblIDSnack As Label
    Friend WithEvents dgvRencanaMenu As DataGridView
    Friend WithEvents Label22 As Label
    Friend WithEvents Line3 As DevComponents.DotNetBar.Controls.Line
    Friend WithEvents Choices As DataGridViewCheckBoxColumn
    Friend WithEvents idSiklus As DataGridViewTextBoxColumn
    Friend WithEvents nmMenuMakanan As DataGridViewTextBoxColumn
    Friend WithEvents nmExtra As DataGridViewTextBoxColumn
    Friend WithEvents Panel3 As Panel
    Friend WithEvents dgvPermintaanMenu As DataGridView
    Friend WithEvents Label24 As Label
    Friend WithEvents Line4 As DevComponents.DotNetBar.Controls.Line
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
End Class
