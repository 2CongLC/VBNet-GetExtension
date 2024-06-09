Public Class Form1

    <Obsolete>
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If OpenFileDialog1.ShowDialog = DialogResult.OK Then

                Dim temp As String = GetExtension(IO.File.ReadAllBytes(OpenFileDialog1.FileName))
                TextBox1.Text = temp

            End If
        Catch ex As Exception

        End Try
    End Sub
End Class
