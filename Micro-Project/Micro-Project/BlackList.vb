Imports System.Data.OleDb

Public Class BlackList
    Dim cmd As OleDbCommand = New OleDbCommand
    Dim conn As OleDbConnection = New OleDbConnection(" Provider=Microsoft.Jet.OLEDB.4.0; Data Source= C:\Users\ARISHA\Documents\BL.mdb;")
    Dim adpt As OleDbDataAdapter = New OleDbDataAdapter
    Dim ds As New DataSet
    Dim str As String

    Private Sub BlackList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        conn.Open()
        str = "select * from  Std  where Standard ='" & TextBox1.Text & "'and   Attendance < " & 35 & " "
        cmd = New OleDbCommand(str, conn)
        adpt = New OleDbDataAdapter(cmd)
        adpt.Fill(ds, "Std")
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "Std"
        DataGridView1.Refresh()
        conn.Close()
    End Sub
End Class