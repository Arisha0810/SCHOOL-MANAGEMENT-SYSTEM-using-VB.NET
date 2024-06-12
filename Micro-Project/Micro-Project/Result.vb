Public Class Result
    Private Sub R1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If RadioButton1.Checked Then
            R1.Show()
        End If
        If RadioButton2.Checked Then
            R2.Show()
        End If
        If RadioButton3.Checked Then
            R3.Show()
        End If
        If RadioButton4.Checked Then
            R4.Show()
        End If
        If RadioButton5.Checked Then
            R5.Show()
        End If
        If RadioButton6.Checked Then
            Resultstud.Show()
        End If
    End Sub
End Class

   