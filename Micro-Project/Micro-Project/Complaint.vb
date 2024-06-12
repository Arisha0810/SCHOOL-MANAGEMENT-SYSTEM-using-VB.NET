Public Class Complaint
    Dim com As String
    Dim gmail As String
    Dim pass As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        Panel1.Location = New Point(200, 140)
        Label6.Location = New Point(870, 130)
        Label7.Location = New Point(850, 170)
        Label7.Visible = False
        Label6.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox2.Text = "" Then
            MsgBox("Plz enter something", 0, "Exception e")
        Else
            MsgBox("Your complaint Registered Successfully", 0, "Complaint form")
        End If
        com = TextBox2.Text
        Label7.Text = com
        TextBox2.Text = ""
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        gmail = InputBox("Plz enter your Gmail for verification")
        pass = InputBox("Plz enter your password for verification")
        If gmail = "Anonymous@gmail.com" And pass = "I KNOW I M AWESOME" Then
            Label7.Visible = True
            Label6.Visible = True
        Else
            MsgBox("Invalid username or password", 0, "Verification process")
        End If
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
End Class
