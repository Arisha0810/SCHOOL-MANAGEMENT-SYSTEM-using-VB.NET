Imports System.Data.OleDb
Public Class R5
    Dim cmd As OleDbCommand = New OleDbCommand
    Dim reader As OleDbDataReader
    Dim conn As OleDbConnection = New OleDbConnection
    Dim adpt As OleDbDataAdapter = New OleDbDataAdapter
    Dim ds As New DataSet
    Dim str As String
    Private Sub R5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        conn = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source= C:\Users\ARISHA\OneDrive\Documents\RESULT.mdb;")
        conn.Open()
        str = "select * from results where (Percentage between 90 and 99)"
        cmd = New OleDbCommand(str, conn)
        adpt = New OleDbDataAdapter(cmd)
        adpt.Fill(ds, "results")
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "results"
    End Sub
End Class