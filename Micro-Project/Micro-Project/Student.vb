Public Class Student

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked Then
            Std1.Show()
        End If
        If RadioButton2.Checked Then
            Std2.Show()
        End If
        If RadioButton3.Checked Then
            Std3.Show()
        End If
        If RadioButton4.Checked Then
            Std4.Show()
        End If
        If RadioButton5.Checked Then
            Std5.Show()
        End If
        If RadioButton11.Checked Then
            Std10.Show()
        End If
        If RadioButton12.Checked Then
            Std9.Show()
        End If
        If RadioButton13.Checked Then
            Std8.Show()
        End If
        If RadioButton14.Checked Then
            Std7.Show()
        End If
        If RadioButton15.Checked Then
            Std6.Show()
        End If
    End Sub
End Class