Public Class Std9

    Private Sub Std9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'STUDENTDataSet14.std_IX' table. You can move, or remove it, as needed.
        Me.Std_IXTableAdapter.Fill(Me.STUDENTDataSet14.std_IX)
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        StdIXBindingSource.MoveNext()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        StdIXBindingSource.RemoveCurrent()
        MessageBox.Show("RECORD IS DELETED")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox13.Text = "" Or TextBox14.Text = "" Or TextBox15.Text = "" Or TextBox16.Text = "" Or TextBox17.Text = "" Or TextBox18.Text = "" Or TextBox19.Text = "" Or TextBox20.Text = "" Or TextBox21.Text = "" Or TextBox22.Text = "" Or TextBox23.Text = "" Or TextBox24.Text = "" Then
            Call notFound()
        Else
            StdIXBindingSource.EndEdit()
            Std_IXTableAdapter.Update(STUDENTDataSet14.std_IX)
            MessageBox.Show("RECORD IS SAVE")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        StdIXBindingSource.AddNew()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        StdIXBindingSource.MovePrevious()
    End Sub

    Private Sub notFound()
        MsgBox("Please Enter Correct Details!!!!! ")
    End Sub
End Class