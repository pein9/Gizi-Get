Imports System.Net
Imports System.IO
Imports System.Net.Sockets

Module modNum
    Public client As New TcpClient
    Public sWriter As StreamWriter
    Public NIckFrefix As String = Environment.MachineName
    Public CountNotify As Byte
    'Permintaan
    Public minta As New Pein.Permintaan
    Public bsMinta As New BindingSource
    Public dtMinta As DataTable

    'Distribusi 
    Public distribute As New Pein.Distribusi
    Public bsDistribusi As New BindingSource
    Public dtDistribusi As DataTable

    Public KodeKelasTemp As String
    Public kodeWaktu As String

    'Inventaris
    Public Invent As New Pein.Inventaris
    Public dtInvent As DataTable
    Public bsInvent As New BindingSource

    Public hitungMundur As Date ' As New TimeSpan()
    Public NumberNotif As Integer


    Public TestErrorIcon As Boolean

    'Unsort Datagridview
    Public Sub SetGridViewSortState(ByVal dgv As DataGridView, ByVal sortMode As DataGridViewColumnSortMode)
        For Each col As DataGridViewColumn In dgv.Columns
            col.SortMode = sortMode
        Next
    End Sub
    <System.Diagnostics.DebuggerStepThrough()>
    <Runtime.CompilerServices.Extension()>
    Public Function GetCheckedRows1(
        ByVal GridView As DataGridView,
        ByVal ColumnName As String) As List(Of DataGridViewRow)
        Return _
            (
                From SubRows In
                    (
                        From Rows In GridView.Rows.Cast(Of DataGridViewRow)()
                        Where Not Rows.IsNewRow
                    ).ToList
                Where CBool(SubRows.Cells(ColumnName).Value) = True
            ).ToList
    End Function
    Public Function FindMaxPlusDatatable(ByVal table As DataTable, ByVal field As String, ByVal Left_Format As String, ByVal lenght As Byte) As String
        Dim tmp As String
        Try
            tmp = table.Compute("MAX(" & field & ")", field & "<>''")
            tmp = tmp.Substring(Left_Format.Length)
            tmp = Val(tmp) + 1
        Catch ex As Exception
            tmp = 1
        End Try
        lenght = lenght - Left_Format.Length
        For i = 1 To lenght - tmp.Length
            tmp = tmp.Insert(0, "0")
        Next
        tmp = tmp.Insert(0, Left_Format)
        Return tmp
    End Function
    Public Function FindMaxPlusDatatablewithNull(ByVal table As DataTable, ByVal field As String, ByVal Left_Format As String, ByVal lenght As Byte) As String
        Dim tmp As String
        Try
            tmp = table.Compute("MAX(" & field & ")", field & "<>''")
            tmp = tmp.Substring(Left_Format.Length)
            tmp = Val(tmp) + 1
        Catch ex As Exception
            tmp = 0
        End Try
        lenght = lenght - Left_Format.Length
        For i = 1 To lenght - tmp.Length
            tmp = tmp.Insert(0, "0")
        Next
        tmp = tmp.Insert(0, Left_Format)
        Return tmp
    End Function
End Module
