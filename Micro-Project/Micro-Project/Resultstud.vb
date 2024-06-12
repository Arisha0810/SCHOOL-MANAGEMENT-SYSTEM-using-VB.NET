Imports System.Data.OleDb

Public Class Resultstud
    Dim cmd As OleDbCommand = New OleDbCommand
    Dim reader As OleDbDataReader
    Dim conn As OleDbConnection = New OleDbConnection
    Dim adpt As OleDbDataAdapter = New OleDbDataAdapter
    Dim ds As New DataSet
    Dim str As String
    Dim Max As Integer

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        conn = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source= C:\Users\ARISHA\Documents\Res.mdb")
        conn.Open()
        str = "select * from results"
        cmd = New OleDbCommand(str, conn)
        adpt = New OleDbDataAdapter(cmd)
        adpt.Fill(ds, "results")
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "results"
        Max = ds.Tables("results").Rows.Count
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ErrorProvider1.Clear()
        ErrorProvider2.Clear()
        If TextBox3.Text = "" Then
            ErrorProvider1.SetError(TextBox3, "Please Enter Roll No")
        ElseIf Not IsNumeric(TextBox3.Text) Then
            ErrorProvider2.SetError(TextBox3, "Please Enter Only numberic Values")
        Else
            DataGridView1.Hide()
            GroupBox3.Hide()
            GroupBox1.Show()
            PictureBox3.Show()
            Label1.Show()
            Label13.Show()
            Label16.Show()
            Label18.Show()
            Label19.Show()
            Label2.Show()
            Label20.Show()
            Label21.Show()
            Label22.Show()
            Label23.Show()
            Label24.Show()
            Label3.Show()
            Label4.Show()
            Label5.Show()
            TextBox24.Show()
            TextBox23.Show()
            TextBox22.Show()
            TextBox1.Show()
            TextBox18.Show()
            TextBox19.Show()
            TextBox20.Show()
            TextBox21.Show()
            TextBox2.Show()
            TextBox16.Show()
            Dim a, inc As Integer
            inc = 0
A:          If inc <> Max Then
                a = ds.Tables("results").Rows(inc).Item(1)
                If a = Val(TextBox3.Text) Then
                    TextBox24.Text = ds.Tables("results").Rows(inc).Item(0)
                    TextBox23.Text = ds.Tables("results").Rows(inc).Item(1)
                    TextBox22.Text = ds.Tables("results").Rows(inc).Item(2)
                    TextBox1.Text = ds.Tables("results").Rows(inc).Item(6)
                    TextBox18.Text = ds.Tables("results").Rows(inc).Item(10)
                    TextBox19.Text = ds.Tables("results").Rows(inc).Item(9)
                    TextBox20.Text = ds.Tables("results").Rows(inc).Item(8)
                    TextBox21.Text = ds.Tables("results").Rows(inc).Item(7)
                    TextBox2.Text = ds.Tables("results").Rows(inc).Item(12)
                    TextBox16.Text = ds.Tables("results").Rows(inc).Item(11)
                    'MsgBox(" Search Succesfull")
                    GoTo B
                End If
                inc = inc + 1
                GoTo A
            End If
B:
            conn.Close()
        End If
    End Sub
End Class