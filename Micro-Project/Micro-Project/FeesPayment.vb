Imports System.Data.OleDb

Public Class FeesPayment
    Dim conn As OleDbConnection = New OleDbConnection
    Dim cmd As OleDbCommand = New OleDbCommand

    Private Sub FeesPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        conn = New OleDbConnection("provider=Microsoft.Jet.Oledb.4.0;data source=C:\Users\ARISHA\Documents\feespayment.mdb")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Then
            If TextBox1.Text = "" Then
                ErrorProvider1.SetError(TextBox1, "enter your name")
                TextBox1.Focus()
            End If
            If TextBox2.Text = "" Then
                ErrorProvider2.SetError(TextBox2, "enter your GR.NO")
                TextBox2.Focus()
            End If
            If TextBox3.Text = "" Then
                ErrorProvider3.SetError(TextBox3, "enter your Roll.no")
                TextBox2.Focus()
            End If
        End If
        If IsNumeric(TextBox1.Text) Or Not IsNumeric(TextBox2.Text) Or Not IsNumeric(TextBox3.Text) Then
            If IsNumeric(TextBox1.Text) Then
                ErrorProvider1.SetError(TextBox1, "Input alphabets")
            End If
            If Not IsNumeric(TextBox2.Text) Then
                ErrorProvider2.SetError(TextBox2, "Input numbers")
            End If
            If Not IsNumeric(TextBox3.Text) Then
                ErrorProvider3.SetError(TextBox2, "Input numbers")
            End If
        Else
            conn.Open()
            Dim str As String
            Dim count As Integer
            str = "insert into Table1 values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & ComboBox1.Text & "','" & TextBox4.Text & "')"
            cmd = New OleDbCommand(str, conn)
            count = cmd.ExecuteNonQuery()
            MsgBox("PAYEMENT IS SUCCESSFULLY DONE")
            conn.Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        MsgBox("OTP has been Send to Your Registered Mobile Number With Your Respective Bank")
    End Sub
End Class
