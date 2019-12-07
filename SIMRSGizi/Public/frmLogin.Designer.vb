<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
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
        Dim Animation2 As AnimatorNS.Animation = New AnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.Animator = New AnimatorNS.Animator(Me.components)
        Me.PeinUI_Container1 = New PeinUI.Controls.PeinUI_Container()
        Me.CustomControlBox = New PeinUI.Controls.PeinUI_ControlBox()
        Me.PeinPanelRight = New PeinUI.Controls.PeinUI_Panel()
        Me.txtUsername = New PeinUI.Controls.PeinUI_TextBox()
        Me.txtPassword = New PeinUI.Controls.PeinUI_TextBox()
        Me.btnLogin = New PeinUI.Controls.PeinUI_Button()
        Me.lblSigning = New PeinUI.Controls.PeinUI_Label()
        Me.TitelBarLogin = New PeinUI.Controls.PeinUI_TitleLabel()
        Me.lblLupaPassword = New PeinUI.Controls.PeinUI_LinkLabel()
        Me.lblSupport = New PeinUI.Controls.PeinUI_Label()
        Me.LinkAdmin = New PeinUI.Controls.PeinUI_LinkLabel()
        Me.lblKet = New PeinUI.Controls.PeinUI_Label()
        Me.PeinPanelLeft = New PeinUI.Controls.PeinUI_Panel()
        Me.TitelBarWelcome = New PeinUI.Controls.PeinUI_TitleLabel()
        Me.tmrFadeIn = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PeinUI_Container1.SuspendLayout()
        Me.PeinPanelRight.SuspendLayout()
        Me.PeinPanelLeft.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Animator
        '
        Me.Animator.AnimationType = AnimatorNS.AnimationType.VertSlide
        Me.Animator.Cursor = Nothing
        Animation2.AnimateOnlyDifferences = True
        Animation2.BlindCoeff = CType(resources.GetObject("Animation2.BlindCoeff"), System.Drawing.PointF)
        Animation2.LeafCoeff = 0!
        Animation2.MaxTime = 1.0!
        Animation2.MinTime = 0!
        Animation2.MosaicCoeff = CType(resources.GetObject("Animation2.MosaicCoeff"), System.Drawing.PointF)
        Animation2.MosaicShift = CType(resources.GetObject("Animation2.MosaicShift"), System.Drawing.PointF)
        Animation2.MosaicSize = 0
        Animation2.Padding = New System.Windows.Forms.Padding(0)
        Animation2.RotateCoeff = 0!
        Animation2.RotateLimit = 0!
        Animation2.ScaleCoeff = CType(resources.GetObject("Animation2.ScaleCoeff"), System.Drawing.PointF)
        Animation2.SlideCoeff = CType(resources.GetObject("Animation2.SlideCoeff"), System.Drawing.PointF)
        Animation2.TimeCoeff = 0!
        Animation2.TransparencyCoeff = 0!
        Me.Animator.DefaultAnimation = Animation2
        '
        'PeinUI_Container1
        '
        Me.PeinUI_Container1.Controls.Add(Me.CustomControlBox)
        Me.PeinUI_Container1.Controls.Add(Me.PeinPanelRight)
        Me.PeinUI_Container1.Controls.Add(Me.PeinPanelLeft)
        Me.PeinUI_Container1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Animator.SetDecoration(Me.PeinUI_Container1, AnimatorNS.DecorationType.None)
        Me.PeinUI_Container1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PeinUI_Container1.DrawIcon = False
        Me.PeinUI_Container1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.PeinUI_Container1.Location = New System.Drawing.Point(0, 0)
        Me.PeinUI_Container1.MinimumSize = New System.Drawing.Size(100, 42)
        Me.PeinUI_Container1.Name = "PeinUI_Container1"
        Me.PeinUI_Container1.Padding = New System.Windows.Forms.Padding(0, 31, 0, 0)
        Me.PeinUI_Container1.Size = New System.Drawing.Size(700, 515)
        Me.PeinUI_Container1.TabIndex = 0
        Me.PeinUI_Container1.Text = "Login"
        Me.PeinUI_Container1.TextAlignment = PeinUI.Controls.PeinUI_Container.Alignment.Left
        Me.PeinUI_Container1.TitleBarTextColor = System.Drawing.Color.Gray
        '
        'CustomControlBox
        '
        Me.CustomControlBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CustomControlBox.BackColor = System.Drawing.Color.Transparent
        Me.CustomControlBox.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Animator.SetDecoration(Me.CustomControlBox, AnimatorNS.DecorationType.None)
        Me.CustomControlBox.EnableMaximizeButton = False
        Me.CustomControlBox.EnableMinimizeButton = True
        Me.CustomControlBox.Location = New System.Drawing.Point(561, 0)
        Me.CustomControlBox.Name = "CustomControlBox"
        Me.CustomControlBox.Size = New System.Drawing.Size(139, 31)
        Me.CustomControlBox.TabIndex = 14
        '
        'PeinPanelRight
        '
        Me.PeinPanelRight.Controls.Add(Me.txtUsername)
        Me.PeinPanelRight.Controls.Add(Me.txtPassword)
        Me.PeinPanelRight.Controls.Add(Me.btnLogin)
        Me.PeinPanelRight.Controls.Add(Me.lblSigning)
        Me.PeinPanelRight.Controls.Add(Me.TitelBarLogin)
        Me.PeinPanelRight.Controls.Add(Me.lblLupaPassword)
        Me.PeinPanelRight.Controls.Add(Me.lblSupport)
        Me.PeinPanelRight.Controls.Add(Me.LinkAdmin)
        Me.PeinPanelRight.Controls.Add(Me.lblKet)
        Me.PeinPanelRight.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Animator.SetDecoration(Me.PeinPanelRight, AnimatorNS.DecorationType.None)
        Me.PeinPanelRight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PeinPanelRight.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.PeinPanelRight.Location = New System.Drawing.Point(350, 31)
        Me.PeinPanelRight.Name = "PeinPanelRight"
        Me.PeinPanelRight.Side = PeinUI.Controls.PeinUI_Panel.PanelSide.Right
        Me.PeinPanelRight.Size = New System.Drawing.Size(350, 484)
        Me.PeinPanelRight.TabIndex = 1
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.txtUsername.ColorBordersOnEnter = True
        Me.Animator.SetDecoration(Me.txtUsername, AnimatorNS.DecorationType.None)
        Me.txtUsername.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.txtUsername.Image = Nothing
        Me.txtUsername.Location = New System.Drawing.Point(0, 197)
        Me.txtUsername.MaxLength = 32767
        Me.txtUsername.Multiline = False
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.ReadOnly = False
        Me.txtUsername.ShortcutsEnabled = True
        Me.txtUsername.ShowBottomBorder = False
        Me.txtUsername.ShowTopBorder = True
        Me.txtUsername.Size = New System.Drawing.Size(350, 50)
        Me.txtUsername.TabIndex = 14
        Me.txtUsername.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtUsername.UseSystemPasswordChar = False
        Me.txtUsername.Watermark = "Username "
        Me.txtUsername.WatermarkColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(129, Byte), Integer))
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.txtPassword.ColorBordersOnEnter = True
        Me.Animator.SetDecoration(Me.txtPassword, AnimatorNS.DecorationType.None)
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.txtPassword.Image = Nothing
        Me.txtPassword.Location = New System.Drawing.Point(0, 247)
        Me.txtPassword.MaxLength = 32767
        Me.txtPassword.Multiline = False
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.ReadOnly = False
        Me.txtPassword.ShortcutsEnabled = True
        Me.txtPassword.ShowBottomBorder = True
        Me.txtPassword.ShowTopBorder = False
        Me.txtPassword.Size = New System.Drawing.Size(350, 50)
        Me.txtPassword.TabIndex = 15
        Me.txtPassword.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtPassword.UseSystemPasswordChar = True
        Me.txtPassword.Watermark = "Password"
        Me.txtPassword.WatermarkColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(129, Byte), Integer))
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.Transparent
        Me.Animator.SetDecoration(Me.btnLogin, AnimatorNS.DecorationType.None)
        Me.btnLogin.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnLogin.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnLogin.Location = New System.Drawing.Point(-7, 317)
        Me.btnLogin.MinimumSize = New System.Drawing.Size(144, 47)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Radius = 20
        Me.btnLogin.Size = New System.Drawing.Size(144, 47)
        Me.btnLogin.TabIndex = 16
        Me.btnLogin.Text = "LOGIN"
        '
        'lblSigning
        '
        Me.lblSigning.BackColor = System.Drawing.Color.Transparent
        Me.lblSigning.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Animator.SetDecoration(Me.lblSigning, AnimatorNS.DecorationType.None)
        Me.lblSigning.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblSigning.ForeColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.lblSigning.Image = CType(resources.GetObject("lblSigning.Image"), System.Drawing.Image)
        Me.lblSigning.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblSigning.Location = New System.Drawing.Point(17, 329)
        Me.lblSigning.Name = "lblSigning"
        Me.lblSigning.Size = New System.Drawing.Size(96, 22)
        Me.lblSigning.TabIndex = 12
        Me.lblSigning.Text = "Memasuki ..."
        Me.lblSigning.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblSigning.Visible = False
        '
        'TitelBarLogin
        '
        Me.TitelBarLogin.AutoSize = True
        Me.TitelBarLogin.BackColor = System.Drawing.Color.Transparent
        Me.TitelBarLogin.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Animator.SetDecoration(Me.TitelBarLogin, AnimatorNS.DecorationType.None)
        Me.TitelBarLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!)
        Me.TitelBarLogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.TitelBarLogin.Location = New System.Drawing.Point(54, 136)
        Me.TitelBarLogin.Name = "TitelBarLogin"
        Me.TitelBarLogin.Side = PeinUI.Controls.PeinUI_TitleLabel.PanelSide.RightPanel
        Me.TitelBarLogin.Size = New System.Drawing.Size(248, 40)
        Me.TitelBarLogin.TabIndex = 9
        Me.TitelBarLogin.Text = "Login SIMRS Gizi"
        Me.TitelBarLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.TitelBarLogin.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
        Me.TitelBarLogin.UseCompatibleTextRendering = True
        Me.TitelBarLogin.Visible = False
        '
        'lblLupaPassword
        '
        Me.lblLupaPassword.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.lblLupaPassword.AutoSize = True
        Me.lblLupaPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblLupaPassword.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Animator.SetDecoration(Me.lblLupaPassword, AnimatorNS.DecorationType.None)
        Me.lblLupaPassword.DisabledLinkColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.lblLupaPassword.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblLupaPassword.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.lblLupaPassword.LinkColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.lblLupaPassword.Location = New System.Drawing.Point(355, 332)
        Me.lblLupaPassword.Name = "lblLupaPassword"
        Me.lblLupaPassword.Size = New System.Drawing.Size(91, 15)
        Me.lblLupaPassword.TabIndex = 4
        Me.lblLupaPassword.TabStop = True
        Me.lblLupaPassword.Text = "Lupa password?"
        Me.lblLupaPassword.Visible = False
        Me.lblLupaPassword.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(84, Byte), Integer))
        '
        'lblSupport
        '
        Me.lblSupport.AutoSize = True
        Me.lblSupport.BackColor = System.Drawing.Color.Transparent
        Me.lblSupport.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Animator.SetDecoration(Me.lblSupport, AnimatorNS.DecorationType.None)
        Me.lblSupport.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSupport.ForeColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.lblSupport.Location = New System.Drawing.Point(51, 400)
        Me.lblSupport.Name = "lblSupport"
        Me.lblSupport.Size = New System.Drawing.Size(50, 15)
        Me.lblSupport.TabIndex = 3
        Me.lblSupport.Text = "Support"
        Me.lblSupport.Visible = False
        '
        'LinkAdmin
        '
        Me.LinkAdmin.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.LinkAdmin.AutoSize = True
        Me.LinkAdmin.BackColor = System.Drawing.Color.Transparent
        Me.LinkAdmin.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Animator.SetDecoration(Me.LinkAdmin, AnimatorNS.DecorationType.None)
        Me.LinkAdmin.DisabledLinkColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.LinkAdmin.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LinkAdmin.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkAdmin.LinkColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.LinkAdmin.Location = New System.Drawing.Point(160, 449)
        Me.LinkAdmin.Name = "LinkAdmin"
        Me.LinkAdmin.Size = New System.Drawing.Size(80, 21)
        Me.LinkAdmin.TabIndex = 1
        Me.LinkAdmin.TabStop = True
        Me.LinkAdmin.Text = "admin. SIMRS"
        Me.LinkAdmin.UseCompatibleTextRendering = True
        Me.LinkAdmin.Visible = False
        Me.LinkAdmin.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(84, Byte), Integer))
        '
        'lblKet
        '
        Me.lblKet.AutoSize = True
        Me.lblKet.BackColor = System.Drawing.Color.Transparent
        Me.lblKet.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Animator.SetDecoration(Me.lblKet, AnimatorNS.DecorationType.None)
        Me.lblKet.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblKet.ForeColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.lblKet.Location = New System.Drawing.Point(51, 420)
        Me.lblKet.Name = "lblKet"
        Me.lblKet.Size = New System.Drawing.Size(234, 45)
        Me.lblKet.TabIndex = 2
        Me.lblKet.Text = "Untuk mendapatkan akses ke aplikasi ini " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "maupun pertanyaan tentang penggunaan, " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "silahkan hubungi ke"
        Me.lblKet.Visible = False
        '
        'PeinPanelLeft
        '
        Me.PeinPanelLeft.Controls.Add(Me.PictureBox1)
        Me.PeinPanelLeft.Controls.Add(Me.TitelBarWelcome)
        Me.PeinPanelLeft.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Animator.SetDecoration(Me.PeinPanelLeft, AnimatorNS.DecorationType.None)
        Me.PeinPanelLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.PeinPanelLeft.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.PeinPanelLeft.Location = New System.Drawing.Point(0, 31)
        Me.PeinPanelLeft.Name = "PeinPanelLeft"
        Me.PeinPanelLeft.Side = PeinUI.Controls.PeinUI_Panel.PanelSide.Left
        Me.PeinPanelLeft.Size = New System.Drawing.Size(350, 484)
        Me.PeinPanelLeft.TabIndex = 0
        '
        'TitelBarWelcome
        '
        Me.TitelBarWelcome.AutoSize = True
        Me.TitelBarWelcome.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TitelBarWelcome.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Animator.SetDecoration(Me.TitelBarWelcome, AnimatorNS.DecorationType.None)
        Me.TitelBarWelcome.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!)
        Me.TitelBarWelcome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.TitelBarWelcome.Location = New System.Drawing.Point(33, 209)
        Me.TitelBarWelcome.Name = "TitelBarWelcome"
        Me.TitelBarWelcome.Side = PeinUI.Controls.PeinUI_TitleLabel.PanelSide.LeftPanel
        Me.TitelBarWelcome.Size = New System.Drawing.Size(275, 74)
        Me.TitelBarWelcome.TabIndex = 1
        Me.TitelBarWelcome.Text = "Selamat Datang di" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "SIMRS Gizi"
        Me.TitelBarWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.TitelBarWelcome.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
        Me.TitelBarWelcome.UseCompatibleTextRendering = True
        Me.TitelBarWelcome.Visible = False
        '
        'tmrFadeIn
        '
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Animator.SetDecoration(Me.PictureBox1, AnimatorNS.DecorationType.None)
        Me.PictureBox1.Location = New System.Drawing.Point(90, 41)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 150)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 515)
        Me.Controls.Add(Me.PeinUI_Container1)
        Me.Animator.SetDecoration(Me, AnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(1440, 860)
        Me.Name = "frmLogin"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmLogin"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.PeinUI_Container1.ResumeLayout(False)
        Me.PeinPanelRight.ResumeLayout(False)
        Me.PeinPanelRight.PerformLayout()
        Me.PeinPanelLeft.ResumeLayout(False)
        Me.PeinPanelLeft.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents Animator As AnimatorNS.Animator
    Friend WithEvents tmrFadeIn As Timer
    Friend WithEvents PeinUI_Container1 As PeinUI.Controls.PeinUI_Container
    Friend WithEvents PeinPanelLeft As PeinUI.Controls.PeinUI_Panel
    Friend WithEvents PeinPanelRight As PeinUI.Controls.PeinUI_Panel
    Private WithEvents LinkAdmin As PeinUI.Controls.PeinUI_LinkLabel
    Private WithEvents lblKet As PeinUI.Controls.PeinUI_Label
    Private WithEvents lblSupport As PeinUI.Controls.PeinUI_Label
    Private WithEvents TitelBarLogin As PeinUI.Controls.PeinUI_TitleLabel
    Private WithEvents lblLupaPassword As PeinUI.Controls.PeinUI_LinkLabel
    Private WithEvents TitelBarWelcome As PeinUI.Controls.PeinUI_TitleLabel
    Private WithEvents lblSigning As PeinUI.Controls.PeinUI_Label
    Friend WithEvents btnLogin As PeinUI.Controls.PeinUI_Button
    Friend WithEvents CustomControlBox As PeinUI.Controls.PeinUI_ControlBox
    Friend WithEvents txtUsername As PeinUI.Controls.PeinUI_TextBox
    Friend WithEvents txtPassword As PeinUI.Controls.PeinUI_TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
