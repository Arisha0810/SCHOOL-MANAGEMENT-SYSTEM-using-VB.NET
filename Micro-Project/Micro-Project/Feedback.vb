Imports System.Data.OleDb
Public Class Feedback
    Dim conn As OleDbConnection = New OleDbConnection
    Dim cmd As OleDbCommand = New OleDbCommand

    Private Sub Feedback_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        conn = New OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;data source= C:\Users\ARISHA\Documents\feedback.mdb")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            If TextBox1.Text = "" Then
                ErrorProvider1.SetError(TextBox1, "enter your name")
                TextBox1.Focus()
            ElseIf TextBox2.Text = "" Then
                ErrorProvider2.SetError(TextBox2, "enter your roll.no")
                TextBox2.Focus()
            End If
        End If
        If IsNumeric(TextBox1.Text) Or Not IsNumeric(TextBox2.Text) Then
            If IsNumeric(TextBox1.Text) Then
                ErrorProvider3.SetError(TextBox1, "Input alphabets")
            ElseIf Not IsNumeric(TextBox2) Then
                ErrorProvider4.SetError(TextBox2, "Input numbers")
            End If
        Else
            conn.Open()
            Dim str As String
            Dim count As Integer
            str = "insert into feedback values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & ComboBox1.Text & "','" & ComboBox2.Text & "','" & ComboBox3.Text & "','" & ComboBox4.Text & "','" & ComboBox5.Text & "','" & ComboBox6.Text & "','" & ComboBox7.Text & "','" & ComboBox8.Text & "','" & TextBox3.Text & "')"
            cmd = New OleDbCommand(str, conn)
            count = cmd.ExecuteNonQuery()
            MsgBox("THANK YOU FOR YOUR FEEDBACK")
            Home.Show()
            conn.Close()
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class