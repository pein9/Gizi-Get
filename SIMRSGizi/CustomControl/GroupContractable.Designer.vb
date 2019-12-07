Partial Class GroupContractable
    Inherits System.Windows.Forms.Panel

    <System.Diagnostics.DebuggerNonUserCode()> _
    Public Sub New(ByVal container As System.ComponentModel.IContainer)
        MyClass.New()

        'Required for Windows.Forms Class Composition Designer support
        If (container IsNot Nothing) Then
            container.Add(Me)
        End If

    End Sub

    <System.Diagnostics.DebuggerNonUserCode()> _
    Public Sub New()
        MyBase.New()

        'This call is required by the Component Designer.
        InitializeComponent()

        Call Me.Ini()

    End Sub

    'Component overrides dispose to clean up the component list.
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

    'Required by the Component Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Component Designer
    'It can be modified using the Component Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GroupContractable))
        Me.picPlus = New System.Windows.Forms.PictureBox
        Me.picMinus = New System.Windows.Forms.PictureBox
        Me.picConEx = New System.Windows.Forms.PictureBox
        CType(Me.picPlus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMinus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picConEx, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picPlus
        '
        Me.picPlus.BackColor = System.Drawing.SystemColors.ControlText
        Me.picPlus.Image = CType(resources.GetObject("picPlus.Image"), System.Drawing.Image)
        Me.picPlus.Location = New System.Drawing.Point(3, 32)
        Me.picPlus.Name = "picPlus"
        Me.picPlus.Size = New System.Drawing.Size(9, 9)
        Me.picPlus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picPlus.TabIndex = 5
        Me.picPlus.TabStop = False
        Me.picPlus.Visible = False
        '
        'picMinus
        '
        Me.picMinus.BackColor = System.Drawing.SystemColors.ControlText
        Me.picMinus.Image = CType(resources.GetObject("picMinus.Image"), System.Drawing.Image)
        Me.picMinus.Location = New System.Drawing.Point(14, 32)
        Me.picMinus.Name = "picMinus"
        Me.picMinus.Size = New System.Drawing.Size(9, 9)
        Me.picMinus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picMinus.TabIndex = 4
        Me.picMinus.TabStop = False
        Me.picMinus.Visible = False
        '
        'picConEx
        '
        Me.picConEx.BackColor = System.Drawing.SystemColors.ControlText
        Me.picConEx.Image = CType(resources.GetObject("picConEx.Image"), System.Drawing.Image)
        Me.picConEx.Location = New System.Drawing.Point(2, 6)
        Me.picConEx.Name = "picConEx"
        Me.picConEx.Size = New System.Drawing.Size(9, 9)
        Me.picConEx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picConEx.TabIndex = 6
        Me.picConEx.TabStop = False
        '
        'GroupContractable
        '
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MinimumSize = New System.Drawing.Size(0, 16)
        CType(Me.picPlus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMinus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picConEx, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents picPlus As System.Windows.Forms.PictureBox
    Private WithEvents picMinus As System.Windows.Forms.PictureBox
    Private WithEvents picConEx As System.Windows.Forms.PictureBox

End Class
