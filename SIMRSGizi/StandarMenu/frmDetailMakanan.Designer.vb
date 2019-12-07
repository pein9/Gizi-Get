Imports WeifenLuo.WinFormsUI.Docking
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDetailMakanan
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetailMakanan))
        Me.dgvBahanMakanan = New Zuby.ADGV.AdvancedDataGridView()
        Me.Line2 = New DevComponents.DotNetBar.Controls.Line()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.txtCariNamaBahan = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Line1 = New DevComponents.DotNetBar.Controls.Line()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblDataOlahan = New System.Windows.Forms.Label()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.btnCariNamaOlahan = New DevComponents.DotNetBar.ButtonX()
        Me.txtCariNamaMakanan = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCariBahan = New DevComponents.DotNetBar.ButtonX()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label51 = New System.Windows.Forms.Label()
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
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
        Me.lblKodeNamaBahan = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cboTipeMakanan = New System.Windows.Forms.ComboBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.dgvBahanMakanan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupContractable1.SuspendLayout()
        Me.GroupContractable2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvBahanMakanan
        '
        Me.dgvBahanMakanan.AllowUserToAddRows = False
        Me.dgvBahanMakanan.AllowUserToDeleteRows = False
        Me.dgvBahanMakanan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvBahanMakanan.FilterAndSortEnabled = True
        Me.dgvBahanMakanan.Location = New System.Drawing.Point(524, 55)
        Me.dgvBahanMakanan.Name = "dgvBahanMakanan"
        Me.dgvBahanMakanan.RowHeadersVisible = False
        Me.dgvBahanMakanan.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgvBahanMakanan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvBahanMakanan.ShowCellToolTips = False
        Me.dgvBahanMakanan.Size = New System.Drawing.Size(481, 482)
        Me.dgvBahanMakanan.TabIndex = 56
        '
        'Line2
        '
        Me.Line2.Location = New System.Drawing.Point(144, 41)
        Me.Line2.Name = "Line2"
        Me.Line2.Size = New System.Drawing.Size(371, 23)
        Me.Line2.TabIndex = 57
        Me.Line2.Text = "Line2"
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label53.Location = New System.Drawing.Point(9, 44)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(159, 15)
        Me.Label53.TabIndex = 58
        Me.Label53.Text = "Pencarian makanan olahan"
        '
        'txtCariNamaBahan
        '
        Me.txtCariNamaBahan.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCariNamaBahan.Location = New System.Drawing.Point(160, 205)
        Me.txtCariNamaBahan.Name = "txtCariNamaBahan"
        Me.txtCariNamaBahan.Size = New System.Drawing.Size(215, 23)
        Me.txtCariNamaBahan.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(73, 208)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 15)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Nama Bahan :"
        '
        'Line1
        '
        Me.Line1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Line1.Location = New System.Drawing.Point(104, 180)
        Me.Line1.Name = "Line1"
        Me.Line1.Size = New System.Drawing.Size(414, 23)
        Me.Line1.TabIndex = 31
        Me.Line1.Text = "Line1"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(9, 183)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(155, 15)
        Me.Label13.TabIndex = 52
        Me.Label13.Text = "Pencarian bahan makanan"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lblDataOlahan)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(9, 96)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(509, 52)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Makanan Olahan "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 15)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "Makanan Olahan :"
        '
        'lblDataOlahan
        '
        Me.lblDataOlahan.AutoSize = True
        Me.lblDataOlahan.Location = New System.Drawing.Point(148, 24)
        Me.lblDataOlahan.Name = "lblDataOlahan"
        Me.lblDataOlahan.Size = New System.Drawing.Size(11, 15)
        Me.lblDataOlahan.TabIndex = 2
        Me.lblDataOlahan.Text = "-"
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Location = New System.Drawing.Point(66, 68)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(89, 13)
        Me.Label52.TabIndex = 52
        Me.Label52.Text = "Nama Makanan :"
        '
        'btnCariNamaOlahan
        '
        Me.btnCariNamaOlahan.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCariNamaOlahan.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCariNamaOlahan.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCariNamaOlahan.Location = New System.Drawing.Point(386, 63)
        Me.btnCariNamaOlahan.Name = "btnCariNamaOlahan"
        Me.btnCariNamaOlahan.Size = New System.Drawing.Size(66, 23)
        Me.btnCariNamaOlahan.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCariNamaOlahan.TabIndex = 29
        Me.btnCariNamaOlahan.Text = "Lihat"
        '
        'txtCariNamaMakanan
        '
        Me.txtCariNamaMakanan.Location = New System.Drawing.Point(160, 65)
        Me.txtCariNamaMakanan.Name = "txtCariNamaMakanan"
        Me.txtCariNamaMakanan.Size = New System.Drawing.Size(215, 20)
        Me.txtCariNamaMakanan.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(36, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Pilih Tipe Makanan :"
        '
        'btnCariBahan
        '
        Me.btnCariBahan.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCariBahan.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCariBahan.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCariBahan.Location = New System.Drawing.Point(386, 205)
        Me.btnCariBahan.Name = "btnCariBahan"
        Me.btnCariBahan.Size = New System.Drawing.Size(66, 23)
        Me.btnCariBahan.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCariBahan.TabIndex = 29
        Me.btnCariBahan.Text = "Lihat"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label51)
        Me.GroupBox2.Controls.Add(Me.GroupContractable1)
        Me.GroupBox2.Controls.Add(Me.GroupContractable2)
        Me.GroupBox2.Controls.Add(Me.lblKodeNamaBahan)
        Me.GroupBox2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(9, 234)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(509, 283)
        Me.GroupBox2.TabIndex = 56
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Data Bahan Makanan"
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Location = New System.Drawing.Point(99, 19)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(48, 15)
        Me.Label51.TabIndex = 57
        Me.Label51.Text = "Bahan :"
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
        Me.GroupContractable1.Controls.Add(Me.Label4)
        Me.GroupContractable1.Controls.Add(Me.Label6)
        Me.GroupContractable1.Controls.Add(Me.Label5)
        Me.GroupContractable1.Controls.Add(Me.Label7)
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
        Me.GroupContractable1.Location = New System.Drawing.Point(19, 46)
        Me.GroupContractable1.MinimumSize = New System.Drawing.Size(0, 16)
        Me.GroupContractable1.Name = "GroupContractable1"
        Me.GroupContractable1.Size = New System.Drawing.Size(484, 136)
        Me.GroupContractable1.TabIndex = 53
        Me.GroupContractable1.TitleAling = SIMRSGizi.GroupContractable.enTitleAling.Left
        Me.GroupContractable1.TitleForeColor = System.Drawing.Color.Black
        Me.GroupContractable1.TitleText = "Tingkat Kandungan"
        '
        'lblSeng
        '
        Me.lblSeng.AutoSize = True
        Me.lblSeng.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeng.Location = New System.Drawing.Point(328, 100)
        Me.lblSeng.Name = "lblSeng"
        Me.lblSeng.Size = New System.Drawing.Size(14, 15)
        Me.lblSeng.TabIndex = 61
        Me.lblSeng.Text = "0"
        '
        'lblHA
        '
        Me.lblHA.AutoSize = True
        Me.lblHA.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHA.Location = New System.Drawing.Point(217, 100)
        Me.lblHA.Name = "lblHA"
        Me.lblHA.Size = New System.Drawing.Size(14, 15)
        Me.lblHA.TabIndex = 60
        Me.lblHA.Text = "0"
        '
        'lblTiamin
        '
        Me.lblTiamin.AutoSize = True
        Me.lblTiamin.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTiamin.Location = New System.Drawing.Point(116, 102)
        Me.lblTiamin.Name = "lblTiamin"
        Me.lblTiamin.Size = New System.Drawing.Size(14, 15)
        Me.lblTiamin.TabIndex = 59
        Me.lblTiamin.Text = "0"
        '
        'lblBDD
        '
        Me.lblBDD.AutoSize = True
        Me.lblBDD.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBDD.Location = New System.Drawing.Point(437, 76)
        Me.lblBDD.Name = "lblBDD"
        Me.lblBDD.Size = New System.Drawing.Size(14, 15)
        Me.lblBDD.TabIndex = 58
        Me.lblBDD.Text = "0"
        '
        'lblPiridoksin
        '
        Me.lblPiridoksin.AutoSize = True
        Me.lblPiridoksin.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPiridoksin.Location = New System.Drawing.Point(328, 76)
        Me.lblPiridoksin.Name = "lblPiridoksin"
        Me.lblPiridoksin.Size = New System.Drawing.Size(14, 15)
        Me.lblPiridoksin.TabIndex = 57
        Me.lblPiridoksin.Text = "0"
        '
        'lblLemak
        '
        Me.lblLemak.AutoSize = True
        Me.lblLemak.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLemak.Location = New System.Drawing.Point(217, 76)
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
        Me.lblSelenium.Location = New System.Drawing.Point(437, 50)
        Me.lblSelenium.Name = "lblSelenium"
        Me.lblSelenium.Size = New System.Drawing.Size(14, 15)
        Me.lblSelenium.TabIndex = 54
        Me.lblSelenium.Text = "0"
        '
        'lblFolat
        '
        Me.lblFolat.AutoSize = True
        Me.lblFolat.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFolat.Location = New System.Drawing.Point(328, 50)
        Me.lblFolat.Name = "lblFolat"
        Me.lblFolat.Size = New System.Drawing.Size(14, 15)
        Me.lblFolat.TabIndex = 53
        Me.lblFolat.Text = "0"
        '
        'lblNiasin
        '
        Me.lblNiasin.AutoSize = True
        Me.lblNiasin.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNiasin.Location = New System.Drawing.Point(217, 50)
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
        Me.lblLodium.Location = New System.Drawing.Point(437, 25)
        Me.lblLodium.Name = "lblLodium"
        Me.lblLodium.Size = New System.Drawing.Size(14, 15)
        Me.lblLodium.TabIndex = 50
        Me.lblLodium.Text = "0"
        '
        'lblKalsium
        '
        Me.lblKalsium.AutoSize = True
        Me.lblKalsium.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKalsium.Location = New System.Drawing.Point(328, 25)
        Me.lblKalsium.Name = "lblKalsium"
        Me.lblKalsium.Size = New System.Drawing.Size(14, 15)
        Me.lblKalsium.TabIndex = 49
        Me.lblKalsium.Text = "0"
        '
        'lblRiboflavin
        '
        Me.lblRiboflavin.AutoSize = True
        Me.lblRiboflavin.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRiboflavin.Location = New System.Drawing.Point(217, 25)
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(61, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 15)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Energy :"
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(14, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 15)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Protein Hewani :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(164, 76)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 15)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Lemak :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(264, 25)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 15)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Kalsium :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(182, 100)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(28, 15)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "HA :"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(59, 101)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(51, 15)
        Me.Label26.TabIndex = 37
        Me.Label26.Text = "Tiamin :"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(142, 25)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(69, 15)
        Me.Label25.TabIndex = 38
        Me.Label25.Text = "Riboflavin :"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(162, 50)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(49, 15)
        Me.Label24.TabIndex = 39
        Me.Label24.Text = "Niasin :"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(248, 50)
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
        Me.Label22.Location = New System.Drawing.Point(252, 74)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(70, 15)
        Me.Label22.TabIndex = 41
        Me.Label22.Text = "Piridoksin :"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(284, 98)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(38, 15)
        Me.Label21.TabIndex = 42
        Me.Label21.Text = "Seng :"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(378, 25)
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
        Me.Label19.Location = New System.Drawing.Point(369, 50)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(63, 15)
        Me.Label19.TabIndex = 44
        Me.Label19.Text = "Selenium :"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(396, 75)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(36, 15)
        Me.Label17.TabIndex = 46
        Me.Label17.Text = "BDD :"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.GroupContractable2.Location = New System.Drawing.Point(18, 188)
        Me.GroupContractable2.MinimumSize = New System.Drawing.Size(0, 16)
        Me.GroupContractable2.Name = "GroupContractable2"
        Me.GroupContractable2.Size = New System.Drawing.Size(485, 89)
        Me.GroupContractable2.TabIndex = 55
        Me.GroupContractable2.TitleAling = SIMRSGizi.GroupContractable.enTitleAling.Left
        Me.GroupContractable2.TitleForeColor = System.Drawing.Color.Black
        Me.GroupContractable2.TitleText = "Kandungan Vitamin"
        '
        'lblB1
        '
        Me.lblB1.AutoSize = True
        Me.lblB1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblB1.Location = New System.Drawing.Point(437, 54)
        Me.lblB1.Name = "lblB1"
        Me.lblB1.Size = New System.Drawing.Size(14, 15)
        Me.lblB1.TabIndex = 69
        Me.lblB1.Text = "0"
        '
        'lblVITK
        '
        Me.lblVITK.AutoSize = True
        Me.lblVITK.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVITK.Location = New System.Drawing.Point(328, 54)
        Me.lblVITK.Name = "lblVITK"
        Me.lblVITK.Size = New System.Drawing.Size(14, 15)
        Me.lblVITK.TabIndex = 68
        Me.lblVITK.Text = "0"
        '
        'lblVITD
        '
        Me.lblVITD.AutoSize = True
        Me.lblVITD.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVITD.Location = New System.Drawing.Point(217, 54)
        Me.lblVITD.Name = "lblVITD"
        Me.lblVITD.Size = New System.Drawing.Size(14, 15)
        Me.lblVITD.TabIndex = 67
        Me.lblVITD.Text = "0"
        '
        'lblVITB
        '
        Me.lblVITB.AutoSize = True
        Me.lblVITB.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVITB.Location = New System.Drawing.Point(116, 54)
        Me.lblVITB.Name = "lblVITB"
        Me.lblVITB.Size = New System.Drawing.Size(14, 15)
        Me.lblVITB.TabIndex = 66
        Me.lblVITB.Text = "0"
        '
        'lblB12
        '
        Me.lblB12.AutoSize = True
        Me.lblB12.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblB12.Location = New System.Drawing.Point(437, 28)
        Me.lblB12.Name = "lblB12"
        Me.lblB12.Size = New System.Drawing.Size(14, 15)
        Me.lblB12.TabIndex = 65
        Me.lblB12.Text = "0"
        '
        'lblVITE
        '
        Me.lblVITE.AutoSize = True
        Me.lblVITE.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVITE.Location = New System.Drawing.Point(328, 28)
        Me.lblVITE.Name = "lblVITE"
        Me.lblVITE.Size = New System.Drawing.Size(14, 15)
        Me.lblVITE.TabIndex = 64
        Me.lblVITE.Text = "0"
        '
        'lblVITC
        '
        Me.lblVITC.AutoSize = True
        Me.lblVITC.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVITC.Location = New System.Drawing.Point(217, 28)
        Me.lblVITC.Name = "lblVITC"
        Me.lblVITC.Size = New System.Drawing.Size(14, 15)
        Me.lblVITC.TabIndex = 63
        Me.lblVITC.Text = "0"
        '
        'lblVITA
        '
        Me.lblVITA.AutoSize = True
        Me.lblVITA.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVITA.Location = New System.Drawing.Point(116, 28)
        Me.lblVITA.Name = "lblVITA"
        Me.lblVITA.Size = New System.Drawing.Size(14, 15)
        Me.lblVITA.TabIndex = 62
        Me.lblVITA.Text = "0"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(352, 28)
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
        Me.Label33.Location = New System.Drawing.Point(359, 54)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(73, 15)
        Me.Label33.TabIndex = 45
        Me.Label33.Text = "Vitamin B1 :"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(44, 28)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(66, 15)
        Me.Label36.TabIndex = 27
        Me.Label36.Text = "Vitamin A :"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(45, 52)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(66, 15)
        Me.Label37.TabIndex = 28
        Me.Label37.Text = "Vitamin B :"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(145, 28)
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
        Me.Label39.Location = New System.Drawing.Point(145, 54)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(67, 15)
        Me.Label39.TabIndex = 30
        Me.Label39.Text = "Vitamin D :"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.Location = New System.Drawing.Point(257, 28)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(65, 15)
        Me.Label40.TabIndex = 31
        Me.Label40.Text = "Vitamin E :"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(256, 52)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(66, 15)
        Me.Label41.TabIndex = 32
        Me.Label41.Text = "Vitamin K :"
        Me.Label41.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblKodeNamaBahan
        '
        Me.lblKodeNamaBahan.Location = New System.Drawing.Point(144, 19)
        Me.lblKodeNamaBahan.Name = "lblKodeNamaBahan"
        Me.lblKodeNamaBahan.Size = New System.Drawing.Size(359, 13)
        Me.lblKodeNamaBahan.TabIndex = 2
        Me.lblKodeNamaBahan.Text = "-"
        '
        'Panel2
        '
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.cboTipeMakanan)
        Me.Panel2.Controls.Add(Me.Label52)
        Me.Panel2.Controls.Add(Me.btnCariNamaOlahan)
        Me.Panel2.Controls.Add(Me.txtCariNamaMakanan)
        Me.Panel2.Controls.Add(Me.GroupBox2)
        Me.Panel2.Controls.Add(Me.btnCariBahan)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.Line1)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.txtCariNamaBahan)
        Me.Panel2.Controls.Add(Me.Label53)
        Me.Panel2.Controls.Add(Me.Line2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 55)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(524, 482)
        Me.Panel2.TabIndex = 53
        '
        'cboTipeMakanan
        '
        Me.cboTipeMakanan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipeMakanan.FormattingEnabled = True
        Me.cboTipeMakanan.Location = New System.Drawing.Point(160, 6)
        Me.cboTipeMakanan.Name = "cboTipeMakanan"
        Me.cboTipeMakanan.Size = New System.Drawing.Size(188, 21)
        Me.cboTipeMakanan.TabIndex = 59
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 537)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1005, 40)
        Me.Panel3.TabIndex = 58
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1005, 55)
        Me.Panel1.TabIndex = 57
        '
        'frmDetailMakanan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 577)
        Me.Controls.Add(Me.dgvBahanMakanan)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmDetailMakanan"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Makanan"
        CType(Me.dgvBahanMakanan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupContractable1.ResumeLayout(False)
        Me.GroupContractable1.PerformLayout()
        Me.GroupContractable2.ResumeLayout(False)
        Me.GroupContractable2.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvBahanMakanan As Zuby.ADGV.AdvancedDataGridView
    Friend WithEvents Line2 As DevComponents.DotNetBar.Controls.Line
    Friend WithEvents Label53 As Label
    Friend WithEvents txtCariNamaBahan As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Line1 As DevComponents.DotNetBar.Controls.Line
    Friend WithEvents Label13 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label52 As Label
    Friend WithEvents lblDataOlahan As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCariNamaMakanan As TextBox
    Friend WithEvents btnCariBahan As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnCariNamaOlahan As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label51 As Label
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
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
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
    Friend WithEvents lblKodeNamaBahan As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents cboTipeMakanan As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
End Class
