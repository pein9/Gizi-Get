Imports System.Net
Imports System.Runtime.InteropServices
Imports WeifenLuo.WinFormsUI.Docking
Imports Pein
Imports Devart.Data.MySql
Module modTimer
    Private WithEvents TmrCheck As New Timer

    Public dRemoteDate As Date
    Public ServerHidup As Boolean
    Public iRet As Integer
    Public GetStatusServer As String

    Public serverStatus As String
    Public dDate As Date

    Structure TIME_OF_DAY_INFO
        Dim tod_elapsedt As Integer
        Dim tod_msecs As Integer
        Dim tod_hours As Integer
        Dim tod_mins As Integer
        Dim tod_secs As Integer
        Dim tod_hunds As Integer
        Dim tod_timezone As Integer
        Dim tod_tinterval As Integer
        Dim tod_day As Integer
        Dim tod_month As Integer
        Dim tod_year As Integer
        Dim tod_weekday As Integer
    End Structure

    Public Function Start()
        TmrCheck = New Timer
        TmrCheck.Interval = 100
        TmrCheck.Start()
        Return 0
    End Function
    Private Sub TmrCheck_Tick(sender As Object, e As EventArgs) Handles TmrCheck.Tick
        IsConnectedToInternet()

        Dim strIPV4 = String.Empty
        Dim strHostName As String = System.Net.Dns.GetHostName()
        Dim iphe As System.Net.IPHostEntry = System.Net.Dns.GetHostEntry(strHostName)


        For Each ipheal As System.Net.IPAddress In iphe.AddressList
            If ipheal.AddressFamily = System.Net.Sockets.AddressFamily.InterNetwork Then
                strIPV4 = ipheal.ToString()
            End If
        Next

        If ServerHidup = True Then
            serverStatus = "Online"
            With MenuUtama
                .lblNamaKomputer.Text = Environment.MachineName & " [OS " & My.Computer.Info.OSFullName & " ] - Framework " & Environment.Version.ToString & ", IP Address : " & strIPV4
                .lblDate.Text = "Tanggal Server : " & dDate.ToShortDateString & " [Status Server : " & serverStatus & " ]"
                .DockPanel.Theme = .VS2015LightTheme1
                .EnableVSRenderer(VisualStudioToolStripExtender.VsVersion.Vs2015, MenuUtama.VS2015LightTheme1)
                .PanelMenu.BackColor = SystemColors.Control
                .DockPanel.BorderStyle = BorderStyle.None
                .Pemisah1.BackColor = .DockPanel.Theme.ColorPalette.ToolWindowTabUnselected.Background

                If .DockPanel.Theme.ColorPalette IsNot Nothing Then
                    .StatusStrip1.BackColor = .DockPanel.Theme.ColorPalette.MainWindowStatusBarDefault.Background
                End If
            End With
        Else
            serverStatus = "Offline"
            With MenuUtama
                .lblNamaKomputer.Text = Environment.MachineName & " [OS " & My.Computer.Info.OSFullName & " ] - Framework " & Environment.Version.ToString & ", IP Address : " & strIPV4
                .lblDate.Text = "Tanggal tidak terdeteksi [Server : " & serverStatus & " ]"
                .DockPanel.Theme = .VS2015DarkTheme1
                .EnableVSRenderer(VisualStudioToolStripExtender.VsVersion.Vs2015, .VS2015DarkTheme1)
                .PanelMenu.BackColor = .DockPanel.Theme.ColorPalette.MainWindowActive.Background
                .DockPanel.BorderStyle = BorderStyle.None
                .Pemisah1.BackColor = .DockPanel.Theme.ColorPalette.ToolWindowTabUnselected.Background


                If .DockPanel.Theme.ColorPalette IsNot Nothing Then
                    .StatusStrip1.BackColor = .DockPanel.Theme.ColorPalette.MainWindowStatusBarDefault.Background
                End If

            End With
        End If
    End Sub

#Region "Server Info"
#Region "Versi 1"
    Private Declare Unicode Function NetRemoteTOD Lib "netapi32" (
        <MarshalAs(UnmanagedType.LPWStr)> ByVal ServerName As String,
        ByRef BufferPtr As IntPtr) As Integer
    Private Declare Function NetApiBufferFree Lib "netapi32" (ByVal Buffer As IntPtr) As Integer

    Public Function GetNetRemoteTOD(ByVal strServerName As String) As Date
        Try
            Dim ptodi As IntPtr
            Dim todi As TIME_OF_DAY_INFO

            strServerName = strServerName & vbNullChar
            iRet = NetRemoteTOD(strServerName, ptodi)
            If iRet = 0 Then
                todi = CType(Marshal.PtrToStructure(ptodi, GetType(TIME_OF_DAY_INFO)), TIME_OF_DAY_INFO)
                NetApiBufferFree(ptodi)
                dDate = DateSerial(todi.tod_year, todi.tod_month, todi.tod_day) + " " +
                        TimeSerial(todi.tod_hours, todi.tod_mins - todi.tod_timezone, todi.tod_secs)
                GetNetRemoteTOD = dDate
            End If
        Catch
            MsgBox("Error Pendeteksian Waktu ke Server: " & Err.Description)
        End Try
        Return Today
    End Function
    Public Function Ping(ByVal server As String) As String
        Dim ElapseTime As New Stopwatch
        ElapseTime.Start()
        My.Computer.Network.Ping(server)
        ElapseTime.Stop()
        Return ElapseTime.Elapsed.TotalSeconds.ToString("N")
        'how to ping is  Ping("192.168.200.2") & " detik"
    End Function

#End Region

#Region "Versi 2"
    Public Function IsConnectedToInternet() As Boolean
        If My.Computer.Network.IsAvailable Then

            Try
                dRemoteDate = GetNetRemoteTOD("\\192.168.200.2")
                'Dim IPHost As IPHostEntry = Dns.GetHostEntry("192.168.200.2")
                ServerHidup = True
                Return True
            Catch
                ServerHidup = False
                Return False
            End Try
        Else
            Return False
        End If
    End Function
#End Region
#End Region
End Module
