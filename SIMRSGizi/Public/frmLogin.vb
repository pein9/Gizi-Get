Imports System.Drawing
Imports System.Security.Permissions
Imports System.Windows.Forms
Imports System.Runtime.InteropServices
Imports System
Public Class frmLogin
#Region "Fields"
    'Private ReadOnly tmrFadeIn As Timer
    Private aeroShadow As Boolean
#End Region
#Region "Constant"
    Private Const WS_MINIMIZEBOX As Integer = &H20000
    Private Const WS_EX_COMPOSITED As Integer = &H2000000
#End Region
#Region "API"
    Private aeroEnabled As Boolean
    Private Shared Function IsDwmCompositionEnabled() As Boolean
        If Environment.OSVersion.Version.Major < 6 Then Return False
        Dim isEnabled As Boolean
        NativeMethods.DwmIsCompositionEnabled(isEnabled)
        Return isEnabled
    End Function
    Private Sub ValidateInput(ByVal sender As Object, ByVal e As EventArgs)
        btnLogin.Enabled = Not (txtUsername.Text = String.Empty OrElse txtPassword.Text = String.Empty)
    End Sub
    Private Sub Wait(ByVal seconds As Integer)
        If seconds < 1 Then Return
        Dim timeToWait = DateTime.Now.AddSeconds(seconds)

        While DateTime.Now < timeToWait
            System.Windows.Forms.Application.DoEvents()
        End While
    End Sub
    Private Sub CheckAeroEnabled()
        If Environment.OSVersion.Version.Major >= 6 Then
            Dim enabled As Integer = 0
            Dim response As Integer = NativeMethods.DwmIsCompositionEnabled(enabled)
            aeroEnabled = (enabled = 1)
        Else
            aeroEnabled = False
        End If
    End Sub
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            CheckAeroEnabled()
            Dim cp As CreateParams = MyBase.CreateParams
            If Not aeroEnabled Then
                cp.ClassStyle = cp.ClassStyle Or NativeMethods.WindowsMessages.CS_DROPSHADOW
                Return cp
            Else
                Return cp
            End If
        End Get
    End Property
    Protected Overrides Sub WndProc(ByRef m As Message)
        Select Case CType(m.Msg, NativeMethods.WindowsMessages)
            Case NativeMethods.WindowsMessages.WM_NCPAINT

                If aeroShadow Then
                    Dim ncAttr = NativeMethods.DWMWINDOWATTRIBUTE.DWMWA_NCRENDERING_POLICY
                    Dim dwAttrPntr = 2
                    NativeMethods.DwmSetWindowAttribute(Handle, ncAttr, dwAttrPntr, 4)
                    Dim margins = New NativeMethods.MARGINS() With {
                        .cyBottomHeight = 1,
                        .cxLeftWidth = 1,
                        .cxRightWidth = 1,
                        .cyTopHeight = 1
                    }
                    NativeMethods.DwmExtendFrameIntoClientArea(Handle, margins)
                End If

            Case NativeMethods.WindowsMessages.WM_NCACTIVATE

                If m.WParam = IntPtr.Zero Then
                    PeinUI_Container1.TitleBarTextColor = Color.DarkGray
                Else
                    PeinUI_Container1.TitleBarTextColor = Color.Gainsboro
                End If
        End Select

        MyBase.WndProc(m)
    End Sub
#End Region
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Animator.AnimationType = AnimatorNS.AnimationType.Transparent
        Animator.Interval = 8
        Animator.MaxAnimationTime = 1000
        Animator.TimeStep = 0.02F
        btnLogin.Enabled = False
        AddHandler txtUsername.TextChanged, AddressOf ValidateInput
        AddHandler txtPassword.TextChanged, AddressOf ValidateInput

        Dim customFont = FontLoader.SetFont(22, FontStyle.Regular, GraphicsUnit.Point, 1)
        TitelBarWelcome.Font = customFont
        TitelBarLogin.Font = customFont
        Opacity = 0
        tmrFadeIn.Interval = 1
        tmrFadeIn.Enabled = True
    End Sub
    Private Sub tmrFadeIn_Tick(sender As Object, e As EventArgs) Handles tmrFadeIn.Tick
        Opacity += 0.05

        If Opacity = 1 Then
            tmrFadeIn.Stop()
            tmrFadeIn.Enabled = False
            'tmrFadeIn.Tick -= AddressOf FadeIn_Tick
            RemoveHandler tmrFadeIn.Tick, AddressOf tmrFadeIn_Tick
        End If
    End Sub
    Private Sub frmLogin_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        For Each item As Control In PeinPanelRight.Controls
            If item.Visible <> True Then Animator.Show(item)
        Next

        For Each item As Control In PeinPanelLeft.Controls
            If item.Visible <> True Then Animator.Show(item)
        Next
    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        txtUsername.Enabled = False
        txtPassword.Enabled = False
        btnLogin.Enabled = False
        Animator.Hide(btnLogin, True, AnimatorNS.Animation.HorizSlide)
        Animator.Hide(lblLupaPassword, True, AnimatorNS.Animation.Transparent)
        Animator.Show(lblSigning)
        Wait(4)
        Animator.Hide(lblSigning, True)
        Animator.Show(btnLogin, True, AnimatorNS.Animation.HorizSlide)
        Animator.Show(lblLupaPassword, True, AnimatorNS.Animation.Transparent)
        txtUsername.Enabled = True
        txtPassword.Enabled = True
        btnLogin.Enabled = True
        If txtUsername.Text = "adm" And txtPassword.Text = "adminsimrs" Then
            ' Me.Visible = False

            MenuUtama.Show()
            Me.Visible = False
        Else
            MsgBox("Maaf username/password anda salah")
        End If
    End Sub
    Private Sub frmLogin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        RemoveHandler tmrFadeIn.Tick, AddressOf tmrFadeIn_Tick
        RemoveHandler txtUsername.TextChanged, AddressOf ValidateInput
        RemoveHandler txtPassword.TextChanged, AddressOf ValidateInput
    End Sub
    Private Sub AllTextBoxes_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) _
    Handles _
        txtUsername.KeyDown,
        txtPassword.KeyDown,
        btnLogin.KeyDown
        If e.KeyCode = Keys.Tab OrElse e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            Me.ProcessTabKey(True)
        End If
    End Sub
End Class