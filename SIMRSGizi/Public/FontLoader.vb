Imports System.Drawing.Text
Imports System.Drawing
Imports System.Runtime.InteropServices
Imports System


Friend NotInheritable Class FontLoader
        Private Shared fontCollection As PrivateFontCollection

        Private Shared Sub LoadFontIntoMemory()
            Try
                fontCollection = New PrivateFontCollection()
                Dim fontLength = My.Resources.Raleway_Light.Length
                Dim fontData = My.Resources.Raleway_Light
                Dim memoryPointer = Marshal.AllocCoTaskMem(fontLength)
                Marshal.Copy(fontData, 0, memoryPointer, fontLength)
                fontCollection.AddMemoryFont(memoryPointer, fontLength)
                Marshal.FreeCoTaskMem(memoryPointer)
            Catch up As Exception
                up = New Exception(up.Message)
                Throw up
            End Try
        End Sub

        Public Shared Function SetFont(ByVal size As Single, ByVal style As FontStyle, ByVal unit As GraphicsUnit, ByVal gdiCharSet As Byte) As Font
            If fontCollection Is Nothing Then LoadFontIntoMemory()
            Return New Font(fontCollection.Families(0), size, style, unit, gdiCharSet)
        End Function
    End Class

