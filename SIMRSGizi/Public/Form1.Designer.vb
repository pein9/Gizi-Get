<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.HierarchicalGridView1 = New HierarchicalGrid.HierarchicalGridView()
        CType(Me.HierarchicalGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button1.Location = New System.Drawing.Point(0, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(710, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "View Master Detail Datagridview"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'HierarchicalGridView1
        '
        Me.HierarchicalGridView1.AllowUserToAddRows = False
        Me.HierarchicalGridView1.AllowUserToDeleteRows = False
        Me.HierarchicalGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HierarchicalGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.HierarchicalGridView1.ImageList = Nothing
        Me.HierarchicalGridView1.Location = New System.Drawing.Point(0, 23)
        Me.HierarchicalGridView1.Name = "HierarchicalGridView1"
        Me.HierarchicalGridView1.RowHeadersVisible = False
        Me.HierarchicalGridView1.Size = New System.Drawing.Size(710, 330)
        Me.HierarchicalGridView1.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(710, 353)
        Me.Controls.Add(Me.HierarchicalGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.HierarchicalGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents HierarchicalGridView1 As HierarchicalGrid.HierarchicalGridView
End Class
