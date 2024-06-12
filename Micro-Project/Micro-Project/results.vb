Imports System.Data.OleDb
Public Class results
    Dim cmd As OleDbCommand = New OleDbCommand
    Dim reader As OleDbDataReader
    Dim conn As OleDbConnection = New OleDbConnection
    Dim adpt As OleDbDataAdapter = New OleDbDataAdapter
    Dim ds As New DataSet
    Dim str As String

    Private Sub Stud_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        'TODO: This line of code loads data into the 'RESULTDataSet1.results' table. You can move, or remove it, as needed.
        Me.ResultsTableAdapter1.Fill(Me.RESULTDataSet1.results)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        conn = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source= C:\Users\ARISHA\OneDrive\Documents\RESULT.mdb;")
        conn.Open()
        If RadioButton1.Checked Then
            str = "select * from results where (Percentage < 35)"
        End If
        If RadioButton2.Checked Then
            str = "select * from results where (Percentage between 35 and 50)"
        End If
        If RadioButton3.Checked Then
            str = "select * from results where (Percentage between 50 and 70)"
        End If
        If RadioButton4.Checked Then
            str = "select * from results where (Percentage between 70 and 90)"
        End If
        If RadioButton5.Checked Then
            str = "select * from results where (Percentage between 90 and 99)"
        End If
        cmd = New OleDbCommand(str, conn)
        adpt = New OleDbDataAdapter(cmd)
        adpt.Fill(ds, "results")
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "results"
    End Sub
End Class
