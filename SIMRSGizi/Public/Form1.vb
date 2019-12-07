Imports Pein
Imports MySql.Data.MySqlClient
Imports HierarchicalGrid

Public Class Form1
    Public Tables As List(Of TableItem)
    Public con As String = "Server=192.168.200.2;Database=gizi;Uid=lis;Pwd='lis1234'"
    Dim dtResult1 As DataTable = New DataTable()
    Dim dtResult2 As DataTable = New DataTable()

    Dim displayColumns As List(Of String) = New List(Of String)()
    Dim groupColumns As List(Of GroupColumn) = New List(Of GroupColumn)()
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        displayColumns.Add("KDDISTRIBUSI")
        'displayColumns.Add("WAKTU")
        'displayColumns.Add("KDALATMAKAN")
        'displayColumns.Add("BoughtFrom")
        'displayColumns.Add("Date")
        groupColumns.Add(New GroupColumn("KDALATMAKAN", GroupTypeEnum.Max))
    End Sub
    Protected Sub testHierarky()
        Dim connection As MySqlConnection = New MySqlConnection(con)
        connection.Open()
        Dim dataAdapter As MySqlDataAdapter = New MySqlDataAdapter("SELECT t_distribusi.KDDISTRIBUSI, t_distribusi.WAKTU FROM t_distribusi ", connection)

        dataAdapter.Fill(dtResult1)
        dataAdapter = New MySqlDataAdapter("SELECT t_detildistribusi.KDDISTRIBUSI, t_detildistribusi.KDALATMAKAN FROM t_detildistribusi ", connection)

        dataAdapter.Fill(dtResult2)
        Dim dsResults As DataSet = New DataSet("Results")
        dsResults.Tables.Add(dtResult1)
        dsResults.Tables.Add(dtResult2)
        Dim relation1 As DataRelation = New DataRelation("relation1", dtResult1.Columns("KDDISTRIBUSI"), dtResult2.Columns("KDDISTRIBUSI"))
        dsResults.Relations.Add(relation1)

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        testHierarky()
        Dim newGridSource As DataGridSource = New DataGridSource(dtResult1.DataSet, displayColumns, groupColumns)
        HierarchicalGridView1.DataSource = newGridSource
        HierarchicalGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        HierarchicalGridView1.Columns("KDDISTRIBUSI").HeaderText = "Distribusi"
    End Sub
End Class