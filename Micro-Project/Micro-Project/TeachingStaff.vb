Public Class TeachingStaff

    Private Sub TeachingStaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        'TODO: This line of code loads data into the 'TeachingStaffDataSet4.TS' table. You can move, or remove it, as needed.
        Me.TSTableAdapter.Fill(Me.TeachingStaffDataSet4.TS)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TSBindingSource.MoveNext()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TSBindingSource.MovePrevious()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TSBindingSource.AddNew()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        On Error GoTo SaveError
        TSBindingSource.EndEdit()
        TSTableAdapter.Update(TeachingStaffDataSet4.TS)
        MsgBox("Data has been saved")
SaveError:
        Exit Sub
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TSBindingSource.RemoveCurrent()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If TextBox9.Text = "" Then
            Call notFound()
            Exit Sub
        Else
            TSBindingSource.Filter = "(Convert(SrNo, 'System.String') LIKE '" & TextBox9.Text & "')" & _
                "OR (Title LIKE '" & TextBox9.Text & "') OR (FName LIKE '" & TextBox9.Text & "')" & _
                "OR (Surname Like '" & TextBox9.Text & "') OR (Convert(PhoneNumber, 'System.String') LIKE '" & TextBox9.Text & "')" & _
            "OR (Designation LIKE '" & TextBox9.Text & "') OR (Subjects LIKE '" & TextBox9.Text & "')" & _
            "OR (Convert(Experience, 'System.String') LIKE '" & TextBox9.Text & "')"
        End If
    End Sub

    Private Sub notFound()
        MsgBox("Enter something. The Search bar is empty! ")
    End Sub
End Class