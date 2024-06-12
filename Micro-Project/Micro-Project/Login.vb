Public Class Login
    Dim str As String

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Panel1.Location = New System.Drawing.Point((Me.Width / 2) - (Panel1.Width / 2), (Me.Height / 2) - (Panel1.Height / 2))
        Label6.Location = New Point(630, 600)
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        If TextBox1.Text = "Anonymous@gmail.com" And TextBox2.Text = "I KNOW I M AWESOME" Then
            ProgressBar1.Show()
            ProgressBar1.Minimum = 0
            ProgressBar1.Maximum = 200
            ProgressBar1.Value = 0
            ProgressBar1.Step = 10
            Dim i As Integer
            For i = 0 To 200
                ProgressBar1.Value += ProgressBar1.Step
                If ProgressBar1.Value = 200 Then
                    MsgBox("Sign in successfully", 0, "Sign in Status")
                    Home.Show()
                    Exit For
                End If
            Next
        Else
            MsgBox("Invalid Username or Password", 0, "Sign in Status")
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

        If TextBox2.Text = "" Then
            ErrorProvider1.SetError(TextBox2, "Please Enter Password")
        ElseIf TextBox2.TextLength < 5 Then
            ErrorProvider1.SetError(TextBox2, "Password Should have more than 4 Characters")
        ElseIf TextBox2.TextLength > 20 Then
            ErrorProvider1.SetError(TextBox2, "Password Should have Less than 20 Characters")
        End If
        ' e.cancel = True
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = "" Then
            ErrorProvider1.SetError(TextBox1, "Please Enter Email")
        End If
        Dim EXPRESSION As New System.Text.RegularExpressions.Regex("\S+@\S+.\S")
        If EXPRESSION.IsMatch(TextBox1.Text) Then
            ErrorProvider1.SetError(TextBox1, "")
        Else
            ErrorProvider1.SetError(TextBox1, "Invalid Gmail")
        End If
    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub
End Class