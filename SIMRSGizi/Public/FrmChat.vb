Imports WeifenLuo.WinFormsUI.Docking
Imports System.Net
Imports System.IO
Imports System.Net.Sockets
Public Class FrmChat
    Inherits DockContent
    Dim StatusKoneksi As String
    Public Delegate Sub _xUpdate(ByVal str As String)

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Public Sub xUpdate(ByVal str As String)
        Try
            If InvokeRequired Then
                Invoke(New _xUpdate(AddressOf xUpdate), str)
            Else
                txtChat.AppendText(str & vbNewLine)
            End If
        Catch __unusedObjectDisposedException1__ As ObjectDisposedException
        End Try
    End Sub
    Public Sub read(ByVal ar As IAsyncResult)
        Try
            xUpdate(New StreamReader(client.GetStream).ReadLine)
            client.GetStream.BeginRead(New Byte() {0}, 0, 0, AddressOf read, Nothing)
        Catch ex As Exception
            xUpdate("Anda telah terputus dari server")
            Exit Sub
        End Try
    End Sub
    Public Sub send(ByVal str As String)
        Try
            sWriter = New StreamWriter(client.GetStream)
            sWriter.WriteLine(str)
            sWriter.Flush()
        Catch ex As Exception
            xUpdate("Maaf, anda bukan server")
        End Try
    End Sub

    Public Sub TutupKoneksiChat()
        Try
            client.Client.Shutdown(SocketShutdown.Both)
            client.Client.Close()
            client.Close()
            Me.Close()
            MenuUtama.lblNamaKomputer.Text = Environment.MachineName & " [OS " & My.Computer.Info.OSFullName & " ] Framework " & Environment.Version.ToString
        Catch ex As Exception
            '  MsgBox("Anda membuka kembali form chat")
            client.Client.Close()
        End Try
    End Sub
    Public Sub BukaKoneksiChat()
        Try
            client = New TcpClient("192.168.200.136", 3818)
            client.GetStream.BeginRead(New Byte() {0}, 0, 0, New AsyncCallback(AddressOf read), Nothing)
            If client.Connected = True Then StatusKoneksi = "Online"
            MenuUtama.lblNamaKomputer.Text = Environment.MachineName & " [OS " & My.Computer.Info.OSFullName & " ] Status : " & StatusKoneksi & " Framework " & Environment.Version.ToString
        Catch ex As Exception
            xUpdate("tidak bisa terhubung dengan server!")
        End Try

    End Sub
    Private Sub TextBox4_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSend.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            send(NIckFrefix & " mengirimkan : " & txtSend.Text)
            txtSend.Clear()
        End If
    End Sub
    Private Sub btnMenu1_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        send(NIckFrefix & " mengirimkan : " & txtSend.Text)
        txtSend.Clear()
    End Sub

    Private Sub FrmChat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '  BukaKoneksiChat()
    End Sub

    Private Sub FrmChat_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        '  TutupKoneksiChat()
    End Sub
End Class