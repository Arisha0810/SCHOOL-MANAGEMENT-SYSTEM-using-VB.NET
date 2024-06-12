Public Class NonTS

    Private Sub NonTS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        'TODO: This line of code loads data into the 'NonTeachingStaffDataSet1.NTS' table. You can move, or remove it, as needed.
        Me.NTSTableAdapter.Fill(Me.NonTeachingStaffDataSet1.NTS)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        NTSBindingSource.MoveNext()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        NTSBindingSource.MovePrevious()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        NTSBindingSource.AddNew()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        NTSBindingSource.RemoveCurrent()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        On Error GoTo SaveError
        NTSBindingSource.EndEdit()
        NTSTableAdapter.Update(NonTeachingStaffDataSet1.NTS)
        MsgBox("Data has been saved")
SaveError:
        MsgBox("Please Enter all the Specific Values in the Text Box")
        Exit Sub
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        If TextBox9.Text = "" Then
            Call notFound()
            Exit Sub
        Else
            NTSBindingSource.Filter = "(Convert(SrNo, 'System.String') LIKE '" & TextBox9.Text & "')" & _
                "OR(Title LIKE '" & TextBox9.Text & "' ) OR (FName LIKE '" & TextBox9.Text & "')" & _
                "OR(Surname LIKE '" & TextBox9.Text & "' ) OR (Convert(PhoneNumber, 'System.String') LIKE '" & TextBox9.Text & "')" & _
                "OR (Designation LIKE '" & TextBox9.Text & "' )"
            If NTSBindingSource.Count <> 0 Then
                With DataGridView1
                    .DataSource = NTSBindingSource

                End With
            Else
                MsgBox(" The search item was not found")
                NTSBindingSource.Filter = Nothing
            End If
        End If
    End Sub

    Private Sub notFound()
        MsgBox("Enter something. The search bar is empty!")
    End Sub
End Class