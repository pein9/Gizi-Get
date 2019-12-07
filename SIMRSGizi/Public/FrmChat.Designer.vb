Imports WeifenLuo.WinFormsUI.Docking
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmChat
    Inherits DockContent
    'Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmChat))
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.txtSend = New System.Windows.Forms.TextBox()
        Me.txtChat = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnSend = New DevComponents.DotNetBar.ButtonX()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelEx1.Font = New System.Drawing.Font("Bauhaus 93", 12.0!)
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(800, 29)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackgroundImage = CType(resources.GetObject("PanelEx1.Style.BackgroundImage"), System.Drawing.Image)
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.Color = System.Drawing.Color.Black
        Me.PanelEx1.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.None
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 53
        '
        'txtSend
        '
        Me.txtSend.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtSend.Location = New System.Drawing.Point(3, 3)
        Me.txtSend.Name = "txtSend"
        Me.txtSend.Size = New System.Drawing.Size(754, 20)
        Me.txtSend.TabIndex = 55
        '
        'txtChat
        '
        Me.txtChat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtChat.Location = New System.Drawing.Point(0, 29)
        Me.txtChat.Multiline = True
        Me.txtChat.Name = "txtChat"
        Me.txtChat.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtChat.Size = New System.Drawing.Size(800, 395)
        Me.txtChat.TabIndex = 54
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 95.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnSend, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtSend, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 424)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(800, 26)
        Me.TableLayoutPanel1.TabIndex = 56
        '
        'btnSend
        '
        Me.btnSend.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSend.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSend.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSend.FadeEffect = False
        Me.btnSend.Font = New System.Drawing.Font("Bauhaus 93", 9.0!)
        Me.btnSend.Location = New System.Drawing.Point(763, 3)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor()
        Me.btnSend.Size = New System.Drawing.Size(34, 20)
        Me.btnSend.TabIndex = 56
        Me.btnSend.Text = "Kirim"
        Me.btnSend.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left
        '
        'FrmChat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtChat)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.PanelEx1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmChat"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Jendela Chat"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents txtSend As TextBox
    Friend WithEvents txtChat As TextBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnSend As DevComponents.DotNetBar.ButtonX
End Class
