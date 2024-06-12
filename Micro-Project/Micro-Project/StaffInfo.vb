Public Class StaffInfo

    Private Sub StaffInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked Then
            TeachingStaff.Show()
        End If

        If RadioButton2.Checked Then
            NonTS.Show()
        End If

        If RadioButton3.Checked Then
            Me.Close()
            Home.Show()
        End If
    End Sub
End Class