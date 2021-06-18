Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim file As New OpenFileDialog()
        If (file.ShowDialog() = DialogResult.OK) Then
            PictureBox1.Image = Image.FromFile(file.FileName)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim bmp As Bitmap = New Bitmap(PictureBox1.Image)
        Dim x As Integer
        Dim y As Integer
        For x = 0 To bmp.Size.Width - 1
            For y = 0 To bmp.Size.Height - 1
                If (x Mod 2 = 0) Then
                    bmp.SetPixel(x, y, Color.Transparent)
                    PictureBox2.Image = bmp
                End If
            Next
        Next


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim kaydet As New SaveFileDialog()
        If (kaydet.ShowDialog() = DialogResult.OK) Then
            Dim bmp As Bitmap = New Bitmap(PictureBox2.Image)
            bmp.Save(kaydet.FileName)
        End If
    End Sub
End Class
