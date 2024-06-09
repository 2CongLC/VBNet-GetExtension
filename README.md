# VBNet GetExtension
* Thư viện dùng đề xác định kiểu dữ liệu trong byte ( kiểu txt, json, xml, zlib, gzip, ...)
* Dùng trong các trường hợp giải mã dữ liệu khi không xác định được kiểu
* Cách dùng :
```VBNet
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
```
* Email : 2conglc.vn@gmail.com	
* © 2008 - 2024 . By 2conglc
 
