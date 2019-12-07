<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmKomposisiEditor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmKomposisiEditor))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnBatal = New DevComponents.DotNetBar.ButtonX()
        Me.btnSimpan = New DevComponents.DotNetBar.ButtonX()
        Me.lblkodemakanan = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.vsRender = New WeifenLuo.WinFormsUI.Docking.VisualStudioToolStripExtender(Me.components)
        Me.VS2015LightTheme1 = New WeifenLuo.WinFormsUI.Docking.VS2015LightTheme()
        Me.epUser = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.txtKode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNamaBahan = New System.Windows.Forms.TextBox()
        Me.txtKomposisi = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Line1 = New DevComponents.DotNetBar.Controls.Line()
        Me.Line2 = New DevComponents.DotNetBar.Controls.Line()
        Me.txtSatuanPakai = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtKeterangan = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblKdBahan = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Line3 = New DevComponents.DotNetBar.Controls.Line()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.errorKet = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupContractable2 = New SIMRSGizi.GroupContractable(Me.components)
        Me.lblB1 = New System.Windows.Forms.Label()
        Me.lblVITK = New System.Windows.Forms.Label()
        Me.lblVITD = New System.Windows.Forms.Label()
        Me.lblVITB = New System.Windows.Forms.Label()
        Me.lblB12 = New System.Windows.Forms.Label()
        Me.lblVITE = New System.Windows.Forms.Label()
        Me.lblVITC = New System.Windows.Forms.Label()
        Me.lblVITA = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.GroupContractable1 = New SIMRSGizi.GroupContractable(Me.components)
        Me.lblSeng = New System.Windows.Forms.Label()
        Me.lblHA = New System.Windows.Forms.Label()
        Me.lblTiamin = New System.Windows.Forms.Label()
        Me.lblBDD = New System.Windows.Forms.Label()
        Me.lblPiridoksin = New System.Windows.Forms.Label()
        Me.lblLemak = New System.Windows.Forms.Label()
        Me.lblNabati = New System.Windows.Forms.Label()
        Me.lblSelenium = New System.Windows.Forms.Label()
        Me.lblFolat = New System.Windows.Forms.Label()
        Me.lblNiasin = New System.Windows.Forms.Label()
        Me.lblHewani = New System.Windows.Forms.Label()
        Me.lblLodium = New System.Windows.Forms.Label()
        Me.lblKalsium = New System.Windows.Forms.Label()
        Me.lblRiboflavin = New System.Windows.Forms.Label()
        Me.lblEnergi = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.epUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errorKet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupContractable2.SuspendLayout()
        Me.GroupContractable1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnBatal)
        Me.Panel2.Controls.Add(Me.btnSimpan)
        Me.Panel2.Controls.Add(Me.lblkodemakanan)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 441)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(750, 53)
        Me.Panel2.TabIndex = 20
        '
        'btnBatal
        '
        Me.btnBatal.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnBatal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBatal.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnBatal.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnBatal.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBatal.Location = New System.Drawing.Point(650, 7)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(87, 37)
        Me.btnBatal.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnBatal.TabIndex = 205
        Me.btnBatal.Text = "Batal"
        '
        'btnSimpan
        '
        Me.btnSimpan.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSimpan.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSimpan.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSimpan.Enabled = False
        Me.btnSimpan.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSimpan.Location = New System.Drawing.Point(551, 7)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(87, 37)
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
        'Panel1
        '
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(750, 43)
        Me.Panel1.TabIndex = 19
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
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 494)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(750, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 21
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
        'txtKode
        '
        Me.txtKode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtKode.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKode.Location = New System.Drawing.Point(192, 52)
        Me.txtKode.MaxLength = 10
        Me.txtKode.Name = "txtKode"
        Me.txtKode.ReadOnly = True
        Me.txtKode.Size = New System.Drawing.Size(83, 21)
        Me.txtKode.TabIndex = 22
        Me.txtKode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(55, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 15)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Kode :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNamaBahan
        '
        Me.txtNamaBahan.Location = New System.Drawing.Point(192, 102)
        Me.txtNamaBahan.MaxLength = 10
        Me.txtNamaBahan.Name = "txtNamaBahan"
        Me.txtNamaBahan.Size = New System.Drawing.Size(188, 20)
        Me.txtNamaBahan.TabIndex = 1
        Me.txtNamaBahan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtKomposisi
        '
        Me.txtKomposisi.Location = New System.Drawing.Point(192, 360)
        Me.txtKomposisi.MaxLength = 9
        Me.txtKomposisi.Name = "txtKomposisi"
        Me.txtKomposisi.Size = New System.Drawing.Size(132, 20)
        Me.txtKomposisi.TabIndex = 2
        Me.txtKomposisi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(76, 339)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 15)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Input Komposisi "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Line1
        '
        Me.Line1.Location = New System.Drawing.Point(20, 342)
        Me.Line1.Name = "Line1"
        Me.Line1.Size = New System.Drawing.Size(711, 12)
        Me.Line1.TabIndex = 29
        Me.Line1.Text = "Line1"
        '
        'Line2
        '
        Me.Line2.Location = New System.Drawing.Point(20, 127)
        Me.Line2.Name = "Line2"
        Me.Line2.Size = New System.Drawing.Size(711, 12)
        Me.Line2.TabIndex = 30
        Me.Line2.Text = "Line2"
        '
        'txtSatuanPakai
        '
        Me.txtSatuanPakai.Location = New System.Drawing.Point(192, 385)
        Me.txtSatuanPakai.MaxLength = 8
        Me.txtSatuanPakai.Name = "txtSatuanPakai"
        Me.txtSatuanPakai.Size = New System.Drawing.Size(64, 20)
        Me.txtSatuanPakai.TabIndex = 3
        Me.txtSatuanPakai.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(58, 386)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 15)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Satuan Pakai :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtKeterangan
        '
        Me.txtKeterangan.Location = New System.Drawing.Point(192, 411)
        Me.txtKeterangan.MaxLength = 200
        Me.txtKeterangan.Multiline = True
        Me.txtKeterangan.Name = "txtKeterangan"
        Me.txtKeterangan.Size = New System.Drawing.Size(538, 20)
        Me.txtKeterangan.TabIndex = 4
        Me.txtKeterangan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(58, 412)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 15)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Keterangan :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblKdBahan
        '
        Me.lblKdBahan.AutoSize = True
        Me.lblKdBahan.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKdBahan.Location = New System.Drawing.Point(189, 79)
        Me.lblKdBahan.Name = "lblKdBahan"
        Me.lblKdBahan.Size = New System.Drawing.Size(0, 15)
        Me.lblKdBahan.TabIndex = 35
        Me.lblKdBahan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(17, 79)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(155, 15)
        Me.Label13.TabIndex = 60
        Me.Label13.Text = "Pencarian bahan makanan"
        '
        'Line3
        '
        Me.Line3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Line3.Location = New System.Drawing.Point(112, 76)
        Me.Line3.Name = "Line3"
        Me.Line3.Size = New System.Drawing.Size(619, 23)
        Me.Line3.TabIndex = 59
        Me.Line3.Text = "Line3"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(102, 104)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(83, 15)
        Me.Label11.TabIndex = 58
        Me.Label11.Text = "Nama Bahan :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(93, 125)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(45, 15)
        Me.Label12.TabIndex = 61
        Me.Label12.Text = "Nutrisi"
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(58, 360)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(124, 15)
        Me.Label14.TabIndex = 62
        Me.Label14.Text = "Nama Komposisi :"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'errorKet
        '
        Me.errorKet.ContainerControl = Me
        Me.errorKet.RightToLeft = True
        '
        'GroupContractable2
        '
        Me.GroupContractable2.Controls.Add(Me.lblB1)
        Me.GroupContractable2.Controls.Add(Me.lblVITK)
        Me.GroupContractable2.Controls.Add(Me.lblVITD)
        Me.GroupContractable2.Controls.Add(Me.lblVITB)
        Me.GroupContractable2.Controls.Add(Me.lblB12)
        Me.GroupContractable2.Controls.Add(Me.lblVITE)
        Me.GroupContractable2.Controls.Add(Me.lblVITC)
        Me.GroupContractable2.Controls.Add(Me.lblVITA)
        Me.GroupContractable2.Controls.Add(Me.Label32)
        Me.GroupContractable2.Controls.Add(Me.Label33)
        Me.GroupContractable2.Controls.Add(Me.Label36)
        Me.GroupContractable2.Controls.Add(Me.Label37)
        Me.GroupContractable2.Controls.Add(Me.Label38)
        Me.GroupContractable2.Controls.Add(Me.Label39)
        Me.GroupContractable2.Controls.Add(Me.Label40)
        Me.GroupContractable2.Controls.Add(Me.Label41)
        Me.GroupContractable2.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupContractable2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupContractable2.Location = New System.Drawing.Point(109, 255)
        Me.GroupContractable2.MinimumSize = New System.Drawing.Size(0, 16)
        Me.GroupContractable2.Name = "GroupContractable2"
        Me.GroupContractable2.Size = New System.Drawing.Size(622, 85)
        Me.GroupContractable2.TabIndex = 57
        Me.GroupContractable2.TitleAling = SIMRSGizi.GroupContractable.enTitleAling.Right
        Me.GroupContractable2.TitleForeColor = System.Drawing.Color.Black
        Me.GroupContractable2.TitleText = "Kandungan Vitamin"
        '
        'lblB1
        '
        Me.lblB1.AutoSize = True
        Me.lblB1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblB1.Location = New System.Drawing.Point(232, 50)
        Me.lblB1.Name = "lblB1"
        Me.lblB1.Size = New System.Drawing.Size(14, 15)
        Me.lblB1.TabIndex = 69
        Me.lblB1.Text = "0"
        '
        'lblVITK
        '
        Me.lblVITK.AutoSize = True
        Me.lblVITK.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVITK.Location = New System.Drawing.Point(117, 50)
        Me.lblVITK.Name = "lblVITK"
        Me.lblVITK.Size = New System.Drawing.Size(14, 15)
        Me.lblVITK.TabIndex = 68
        Me.lblVITK.Text = "0"
        '
        'lblVITD
        '
        Me.lblVITD.AutoSize = True
        Me.lblVITD.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVITD.Location = New System.Drawing.Point(465, 23)
        Me.lblVITD.Name = "lblVITD"
        Me.lblVITD.Size = New System.Drawing.Size(14, 15)
        Me.lblVITD.TabIndex = 67
        Me.lblVITD.Text = "0"
        '
        'lblVITB
        '
        Me.lblVITB.AutoSize = True
        Me.lblVITB.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVITB.Location = New System.Drawing.Point(233, 23)
        Me.lblVITB.Name = "lblVITB"
        Me.lblVITB.Size = New System.Drawing.Size(14, 15)
        Me.lblVITB.TabIndex = 66
        Me.lblVITB.Text = "0"
        '
        'lblB12
        '
        Me.lblB12.AutoSize = True
        Me.lblB12.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblB12.Location = New System.Drawing.Point(342, 50)
        Me.lblB12.Name = "lblB12"
        Me.lblB12.Size = New System.Drawing.Size(14, 15)
        Me.lblB12.TabIndex = 65
        Me.lblB12.Text = "0"
        '
        'lblVITE
        '
        Me.lblVITE.AutoSize = True
        Me.lblVITE.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVITE.Location = New System.Drawing.Point(576, 23)
        Me.lblVITE.Name = "lblVITE"
        Me.lblVITE.Size = New System.Drawing.Size(14, 15)
        Me.lblVITE.TabIndex = 64
        Me.lblVITE.Text = "0"
        '
        'lblVITC
        '
        Me.lblVITC.AutoSize = True
        Me.lblVITC.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVITC.Location = New System.Drawing.Point(343, 23)
        Me.lblVITC.Name = "lblVITC"
        Me.lblVITC.Size = New System.Drawing.Size(14, 15)
        Me.lblVITC.TabIndex = 63
        Me.lblVITC.Text = "0"
        '
        'lblVITA
        '
        Me.lblVITA.AutoSize = True
        Me.lblVITA.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVITA.Location = New System.Drawing.Point(116, 23)
        Me.lblVITA.Name = "lblVITA"
        Me.lblVITA.Size = New System.Drawing.Size(14, 15)
        Me.lblVITA.TabIndex = 62
        Me.lblVITA.Text = "0"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(257, 50)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(80, 15)
        Me.Label32.TabIndex = 47
        Me.Label32.Text = "Vitamin B12 :"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(154, 50)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(73, 15)
        Me.Label33.TabIndex = 45
        Me.Label33.Text = "Vitamin B1 :"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(44, 23)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(66, 15)
        Me.Label36.TabIndex = 27
        Me.Label36.Text = "Vitamin A :"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(161, 23)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(66, 15)
        Me.Label37.TabIndex = 28
        Me.Label37.Text = "Vitamin B :"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(271, 23)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(66, 15)
        Me.Label38.TabIndex = 29
        Me.Label38.Text = "Vitamin C :"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(393, 23)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(67, 15)
        Me.Label39.TabIndex = 30
        Me.Label39.Text = "Vitamin D :"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.Location = New System.Drawing.Point(505, 23)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(65, 15)
        Me.Label40.TabIndex = 31
        Me.Label40.Text = "Vitamin E :"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(45, 48)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(66, 15)
        Me.Label41.TabIndex = 32
        Me.Label41.Text = "Vitamin K :"
        Me.Label41.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupContractable1
        '
        Me.GroupContractable1.Controls.Add(Me.lblSeng)
        Me.GroupContractable1.Controls.Add(Me.lblHA)
        Me.GroupContractable1.Controls.Add(Me.lblTiamin)
        Me.GroupContractable1.Controls.Add(Me.lblBDD)
        Me.GroupContractable1.Controls.Add(Me.lblPiridoksin)
        Me.GroupContractable1.Controls.Add(Me.lblLemak)
        Me.GroupContractable1.Controls.Add(Me.lblNabati)
        Me.GroupContractable1.Controls.Add(Me.lblSelenium)
        Me.GroupContractable1.Controls.Add(Me.lblFolat)
        Me.GroupContractable1.Controls.Add(Me.lblNiasin)
        Me.GroupContractable1.Controls.Add(Me.lblHewani)
        Me.GroupContractable1.Controls.Add(Me.lblLodium)
        Me.GroupContractable1.Controls.Add(Me.lblKalsium)
        Me.GroupContractable1.Controls.Add(Me.lblRiboflavin)
        Me.GroupContractable1.Controls.Add(Me.lblEnergi)
        Me.GroupContractable1.Controls.Add(Me.Label5)
        Me.GroupContractable1.Controls.Add(Me.Label6)
        Me.GroupContractable1.Controls.Add(Me.Label7)
        Me.GroupContractable1.Controls.Add(Me.Label8)
        Me.GroupContractable1.Controls.Add(Me.Label9)
        Me.GroupContractable1.Controls.Add(Me.Label10)
        Me.GroupContractable1.Controls.Add(Me.Label26)
        Me.GroupContractable1.Controls.Add(Me.Label25)
        Me.GroupContractable1.Controls.Add(Me.Label24)
        Me.GroupContractable1.Controls.Add(Me.Label23)
        Me.GroupContractable1.Controls.Add(Me.Label22)
        Me.GroupContractable1.Controls.Add(Me.Label21)
        Me.GroupContractable1.Controls.Add(Me.Label20)
        Me.GroupContractable1.Controls.Add(Me.Label19)
        Me.GroupContractable1.Controls.Add(Me.Label17)
        Me.GroupContractable1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupContractable1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupContractable1.Location = New System.Drawing.Point(109, 141)
        Me.GroupContractable1.MinimumSize = New System.Drawing.Size(0, 16)
        Me.GroupContractable1.Name = "GroupContractable1"
        Me.GroupContractable1.Size = New System.Drawing.Size(621, 117)
        Me.GroupContractable1.TabIndex = 56
        Me.GroupContractable1.TitleAling = SIMRSGizi.GroupContractable.enTitleAling.Right
        Me.GroupContractable1.TitleForeColor = System.Drawing.Color.Black
        Me.GroupContractable1.TitleText = "Tingkat Kandungan"
        '
        'lblSeng
        '
        Me.lblSeng.AutoSize = True
        Me.lblSeng.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeng.Location = New System.Drawing.Point(466, 75)
        Me.lblSeng.Name = "lblSeng"
        Me.lblSeng.Size = New System.Drawing.Size(14, 15)
        Me.lblSeng.TabIndex = 61
        Me.lblSeng.Text = "0"
        '
        'lblHA
        '
        Me.lblHA.AutoSize = True
        Me.lblHA.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHA.Location = New System.Drawing.Point(343, 49)
        Me.lblHA.Name = "lblHA"
        Me.lblHA.Size = New System.Drawing.Size(14, 15)
        Me.lblHA.TabIndex = 60
        Me.lblHA.Text = "0"
        '
        'lblTiamin
        '
        Me.lblTiamin.AutoSize = True
        Me.lblTiamin.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTiamin.Location = New System.Drawing.Point(233, 26)
        Me.lblTiamin.Name = "lblTiamin"
        Me.lblTiamin.Size = New System.Drawing.Size(14, 15)
        Me.lblTiamin.TabIndex = 59
        Me.lblTiamin.Text = "0"
        '
        'lblBDD
        '
        Me.lblBDD.AutoSize = True
        Me.lblBDD.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBDD.Location = New System.Drawing.Point(576, 77)
        Me.lblBDD.Name = "lblBDD"
        Me.lblBDD.Size = New System.Drawing.Size(14, 15)
        Me.lblBDD.TabIndex = 58
        Me.lblBDD.Text = "0"
        '
        'lblPiridoksin
        '
        Me.lblPiridoksin.AutoSize = True
        Me.lblPiridoksin.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPiridoksin.Location = New System.Drawing.Point(466, 51)
        Me.lblPiridoksin.Name = "lblPiridoksin"
        Me.lblPiridoksin.Size = New System.Drawing.Size(14, 15)
        Me.lblPiridoksin.TabIndex = 57
        Me.lblPiridoksin.Text = "0"
        '
        'lblLemak
        '
        Me.lblLemak.AutoSize = True
        Me.lblLemak.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLemak.Location = New System.Drawing.Point(343, 25)
        Me.lblLemak.Name = "lblLemak"
        Me.lblLemak.Size = New System.Drawing.Size(14, 15)
        Me.lblLemak.TabIndex = 56
        Me.lblLemak.Text = "0"
        '
        'lblNabati
        '
        Me.lblNabati.AutoSize = True
        Me.lblNabati.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNabati.Location = New System.Drawing.Point(116, 76)
        Me.lblNabati.Name = "lblNabati"
        Me.lblNabati.Size = New System.Drawing.Size(14, 15)
        Me.lblNabati.TabIndex = 55
        Me.lblNabati.Text = "0"
        '
        'lblSelenium
        '
        Me.lblSelenium.AutoSize = True
        Me.lblSelenium.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelenium.Location = New System.Drawing.Point(576, 51)
        Me.lblSelenium.Name = "lblSelenium"
        Me.lblSelenium.Size = New System.Drawing.Size(14, 15)
        Me.lblSelenium.TabIndex = 54
        Me.lblSelenium.Text = "0"
        '
        'lblFolat
        '
        Me.lblFolat.AutoSize = True
        Me.lblFolat.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFolat.Location = New System.Drawing.Point(466, 25)
        Me.lblFolat.Name = "lblFolat"
        Me.lblFolat.Size = New System.Drawing.Size(14, 15)
        Me.lblFolat.TabIndex = 53
        Me.lblFolat.Text = "0"
        '
        'lblNiasin
        '
        Me.lblNiasin.AutoSize = True
        Me.lblNiasin.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNiasin.Location = New System.Drawing.Point(233, 77)
        Me.lblNiasin.Name = "lblNiasin"
        Me.lblNiasin.Size = New System.Drawing.Size(14, 15)
        Me.lblNiasin.TabIndex = 52
        Me.lblNiasin.Text = "0"
        '
        'lblHewani
        '
        Me.lblHewani.AutoSize = True
        Me.lblHewani.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHewani.Location = New System.Drawing.Point(116, 50)
        Me.lblHewani.Name = "lblHewani"
        Me.lblHewani.Size = New System.Drawing.Size(14, 15)
        Me.lblHewani.TabIndex = 51
        Me.lblHewani.Text = "0"
        '
        'lblLodium
        '
        Me.lblLodium.AutoSize = True
        Me.lblLodium.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLodium.Location = New System.Drawing.Point(576, 26)
        Me.lblLodium.Name = "lblLodium"
        Me.lblLodium.Size = New System.Drawing.Size(14, 15)
        Me.lblLodium.TabIndex = 50
        Me.lblLodium.Text = "0"
        '
        'lblKalsium
        '
        Me.lblKalsium.AutoSize = True
        Me.lblKalsium.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKalsium.Location = New System.Drawing.Point(343, 77)
        Me.lblKalsium.Name = "lblKalsium"
        Me.lblKalsium.Size = New System.Drawing.Size(14, 15)
        Me.lblKalsium.TabIndex = 49
        Me.lblKalsium.Text = "0"
        '
        'lblRiboflavin
        '
        Me.lblRiboflavin.AutoSize = True
        Me.lblRiboflavin.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRiboflavin.Location = New System.Drawing.Point(233, 52)
        Me.lblRiboflavin.Name = "lblRiboflavin"
        Me.lblRiboflavin.Size = New System.Drawing.Size(14, 15)
        Me.lblRiboflavin.TabIndex = 48
        Me.lblRiboflavin.Text = "0"
        '
        'lblEnergi
        '
        Me.lblEnergi.AutoSize = True
        Me.lblEnergi.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnergi.Location = New System.Drawing.Point(116, 25)
        Me.lblEnergi.Name = "lblEnergi"
        Me.lblEnergi.Size = New System.Drawing.Size(14, 15)
        Me.lblEnergi.TabIndex = 47
        Me.lblEnergi.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(61, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 15)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Energy :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(20, 76)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 15)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Protein Nabati :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(14, 50)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 15)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Protein Hewani :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(290, 25)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 15)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Lemak :"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(279, 77)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 15)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Kalsium :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(308, 49)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(28, 15)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "HA :"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(176, 25)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(51, 15)
        Me.Label26.TabIndex = 37
        Me.Label26.Text = "Tiamin :"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(158, 52)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(69, 15)
        Me.Label25.TabIndex = 38
        Me.Label25.Text = "Riboflavin :"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(178, 77)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(49, 15)
        Me.Label24.TabIndex = 39
        Me.Label24.Text = "Niasin :"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(386, 25)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(74, 15)
        Me.Label23.TabIndex = 40
        Me.Label23.Text = "Asam Folat :"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(390, 49)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(70, 15)
        Me.Label22.TabIndex = 41
        Me.Label22.Text = "Piridoksin :"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(422, 73)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(38, 15)
        Me.Label21.TabIndex = 42
        Me.Label21.Text = "Seng :"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(517, 26)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(53, 15)
        Me.Label20.TabIndex = 43
        Me.Label20.Text = "Lodium :"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(508, 51)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(63, 15)
        Me.Label19.TabIndex = 44
        Me.Label19.Text = "Selenium :"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(535, 76)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(36, 15)
        Me.Label17.TabIndex = 46
        Me.Label17.Text = "BDD :"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmKomposisiEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(750, 516)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtNamaBahan)
        Me.Controls.Add(Me.txtKode)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.GroupContractable2)
        Me.Controls.Add(Me.GroupContractable1)
        Me.Controls.Add(Me.lblKdBahan)
        Me.Controls.Add(Me.txtKeterangan)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtSatuanPakai)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Line2)
        Me.Controls.Add(Me.txtKomposisi)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Line1)
        Me.Controls.Add(Me.Line3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmKomposisiEditor"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Komposisi Editor"
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.epUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errorKet, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents vsRender As WeifenLuo.WinFormsUI.Docking.VisualStudioToolStripExtender
    Friend WithEvents VS2015LightTheme1 As WeifenLuo.WinFormsUI.Docking.VS2015LightTheme
    Friend WithEvents epUser As ErrorProvider
    Friend WithEvents txtKode As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNamaBahan As TextBox
    Friend WithEvents txtKeterangan As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSatuanPakai As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Line2 As DevComponents.DotNetBar.Controls.Line
    Friend WithEvents txtKomposisi As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Line1 As DevComponents.DotNetBar.Controls.Line
    Friend WithEvents lblKdBahan As Label
    Friend WithEvents lblkodemakanan As Label
    Friend WithEvents GroupContractable2 As GroupContractable
    Friend WithEvents lblB1 As Label
    Friend WithEvents lblVITK As Label
    Friend WithEvents lblVITD As Label
    Friend WithEvents lblVITB As Label
    Friend WithEvents lblB12 As Label
    Friend WithEvents lblVITE As Label
    Friend WithEvents lblVITC As Label
    Friend WithEvents lblVITA As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents Label41 As Label
    Friend WithEvents GroupContractable1 As GroupContractable
    Friend WithEvents lblSeng As Label
    Friend WithEvents lblHA As Label
    Friend WithEvents lblTiamin As Label
    Friend WithEvents lblBDD As Label
    Friend WithEvents lblPiridoksin As Label
    Friend WithEvents lblLemak As Label
    Friend WithEvents lblNabati As Label
    Friend WithEvents lblSelenium As Label
    Friend WithEvents lblFolat As Label
    Friend WithEvents lblNiasin As Label
    Friend WithEvents lblHewani As Label
    Friend WithEvents lblLodium As Label
    Friend WithEvents lblKalsium As Label
    Friend WithEvents lblRiboflavin As Label
    Friend WithEvents lblEnergi As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Line3 As DevComponents.DotNetBar.Controls.Line
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents errorKet As ErrorProvider
End Class
