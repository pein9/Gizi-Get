Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Drawing
Imports System.Drawing.Drawing2D


Public Class NotiButton
    Inherits DevComponents.DotNetBar.ButtonX 'System.Windows.Forms.Button
    'MustInherit 
    Public Sub New()
        End Sub
    Private _number As Integer
    Public Property Number As Integer
        Get
            Return _number
        End Get
        Set(ByVal value As Integer)
            If _number = value Then Return
            _number = value
            Invalidate()
        End Set
    End Property
    Protected Overrides Sub OnPaint(ByVal pevent As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaint(pevent)
        Dim graphics As Graphics = pevent.Graphics
        graphics.SmoothingMode = SmoothingMode.AntiAlias
        If Number = 0 Then Return
        Dim height As Integer = 25
        Dim rect = New Rectangle(Me.Width - (height), (Me.Height - height) / 2, height, height)
        graphics.FillEllipse(Brushes.OrangeRed, rect)
        graphics.DrawEllipse(New Pen(Color.Orange, 2), rect)
        Dim text As String = Number.ToString()
        Dim textsize As SizeF = graphics.MeasureString(text, Font)
        graphics.DrawString(text, Font, Brushes.White, rect.X + ((height - textsize.Width) / 2), rect.Y + ((height - textsize.Height) / 1.5))
    End Sub
End Class
