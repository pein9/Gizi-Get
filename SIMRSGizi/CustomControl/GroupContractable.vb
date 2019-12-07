Imports System.Windows.Forms
Imports System.Drawing
Public Class GroupContractable
    Inherits System.Windows.Forms.Panel

    Public Enum enTitleAling
        Left = 1
        Right = 0
    End Enum

    Private WithEvents __Label As Label
    Private __GroupBox As GroupBox
    Private __IsContracted As Boolean
    Private __MinHeight As Integer
    Private __SizeHeight As Integer
    Private __TitleAling As enTitleAling = enTitleAling.Left

    Public Event OnCollapsed(ByVal sender As System.Object, ByVal IsContracted As Boolean)

    ''' <summary>
    ''' Inicializate the control propertys
    ''' </summary>
    ''' <remarks></remarks>
    ''' 
    Private Sub Ini()
        Me.__Label = New Label
        Me.__Label.Text = "GroupContractable"
        Me.__Label.Font = MyBase.Font
        Me.__Label.BackColor = Color.Transparent
        Me.__Label.ForeColor = ColorTranslator.FromWin32(RGB(0, 0, 210))
        Me.__Label.AutoSize = True

        Me.__GroupBox = New GroupBox
        Me.__GroupBox.Text = ""
        Me.__GroupBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                                     Or System.Windows.Forms.AnchorStyles.Left) _
                                     Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)

        MyBase.Controls.Add(Me.__GroupBox)
        MyBase.Controls.Add(Me.__Label)
        MyBase.Controls.Add(Me.picConEx)

        Me.picConEx.Top = 4
        Me.picConEx.Left = 0

        Me.__Label.Top = 0
        Me.__Label.Left = 9

        __SizeHeight = MyBase.Height
        __MinHeight = MyBase.MinimumSize.Height
    End Sub

    ''' <summary>
    ''' Info about the author of this control
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property About() As String
        Get
            Return "Copyright © 2008 by fLaSh - Carlos.DF" & vbNewLine & _
                   "Email: carlosferreiracarlos@hotmail.com"
        End Get
    End Property

    '''<summary>
    ''' Sets the fore color property of the control
    '''</summary>
    Public Property TitleAling() As enTitleAling
        Get
            Return Me.__TitleAling
        End Get
        Set(ByVal value As enTitleAling)
            Me.__TitleAling = value
            Call GroupContractable_Resize(Nothing, Nothing)
        End Set
    End Property

    '''<summary>
    ''' Sets the fore color property of the control
    '''</summary>
    Public Property TitleForeColor() As Color
        Get
            Return Me.__Label.ForeColor
        End Get
        Set(ByVal value As Color)
            Me.__Label.ForeColor = value
        End Set
    End Property

    '''<summary>
    ''' Sets the text property of the control
    '''</summary>
    Public Property TitleText() As String
        Get
            Return __Label.Text
        End Get
        Set(ByVal value As String)
            __Label.Text = value
            Call GroupContractable_Resize(Nothing, Nothing)
        End Set
    End Property

    ''' <summary>
    ''' Gets the border style property of the control (Ready only)
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shadows Property BorderStyle() As BorderStyle
        Get
            Return MyBase.BorderStyle
        End Get
        Set(ByVal value As BorderStyle)
            'egnore
        End Set
    End Property

    ''' <summary>
    ''' Gets the control collapse status.
    ''' </summary>
    Public ReadOnly Property HasCollapsed() As Boolean
        Get
            Return __IsContracted
        End Get
        'Set(ByVal value As Boolean)
        '    If Not __IsContracted = value Then
        '        Call OnClick_Click(Nothing, Nothing)
        '    Else
        '        If Not value Then _
        '            __SizeHeight = MyBase.Height
        '    End If
        'End Set
    End Property

    ''' <summary>
    ''' Private events called when new control added 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub GroupContractable_ControlAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.ControlEventArgs) Handles Me.ControlAdded
        Me.__GroupBox.SendToBack()
    End Sub

    ''' <summary>
    ''' Private events called when Painting 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub GroupContractable_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Me.__GroupBox.SendToBack()
    End Sub

    ''' <summary>
    ''' Private events called when resizing this control
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub GroupContractable_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        On Error Resume Next
        Me.__GroupBox.Width = MyBase.Width
        Me.__GroupBox.Height = MyBase.Height - 8
        Me.__GroupBox.Left = 0
        '
        If Not __IsContracted Then
            __SizeHeight = Me.Height
            Me.__GroupBox.Top = 1
        Else
            Me.Height = __MinHeight
            Me.__GroupBox.Top = 2
        End If
        '
        If Me.__TitleAling = enTitleAling.Left Then
            Me.picConEx.Left = 0
            Me.__Label.Left = 9
        Else
            Me.picConEx.Left = Me.Width - picConEx.Width
            Me.__Label.Left = Me.Width - picConEx.Width - __Label.Width
        End If
    End Sub

    ''' <summary>
    ''' Private events called when clicking on label title or picture box
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub OnClick_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
                Handles picConEx.Click, __Label.Click
        If Not __IsContracted Then
            __IsContracted = True
            Me.Height = __MinHeight
            Me.picConEx.Image = picPlus.Image
            '
            SetObjectsState(Not __IsContracted)
            RaiseEvent OnCollapsed(Me, __IsContracted)
        Else
            __IsContracted = False
            Me.Height = __SizeHeight
            Me.picConEx.Image = picMinus.Image
            '
            SetObjectsState(Not __IsContracted)
            RaiseEvent OnCollapsed(Me, __IsContracted)
        End If
        Me.Invalidate()
    End Sub

    ''' <summary>
    ''' Set the objects state (visible/invisible)
    ''' </summary>
    ''' <param name="b">visible value</param>
    ''' <remarks></remarks>
    Private Sub SetObjectsState(ByVal b As Boolean)
        For Each o As Control In MyBase.Controls
            Select Case o.Name
                Case __Label.Name, "picConEx", __GroupBox.Name
                Case Else : o.Visible = b
            End Select
        Next
    End Sub

    ''' <summary>
    ''' Sub called by parent win; eg: Call me_name.SetCollapsed(True)
    ''' </summary>
    ''' <param name="b"></param>
    ''' <remarks></remarks>
    Public Sub SetCollapsed(ByVal b As Boolean)
        If Not __IsContracted = b Then
            Call OnClick_Click(Nothing, Nothing)
        End If
    End Sub

End Class
