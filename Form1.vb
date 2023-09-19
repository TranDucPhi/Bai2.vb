Public Class Form1
    Private Sub btnghi_Click(sender As Object, e As EventArgs) Handles btnghi.Click
        Dim tenfile As String
        tenfile = txtghiten.Text
        Dim noidung As String
        noidung = txtnoidung.Text
        Dim sw As System.IO.StreamWriter
        If rd1.Checked Then
            sw = New System.IO.StreamWriter(IO.File.Open("D\\" & tenfile, IO.FileMode.OpenOrCreate))
            sw.Write(noidung)
        Else
            sw = New IO.StreamWriter(IO.File.Open("D\\" & tenfile, IO.FileMode.Append))
            sw.Write(noidung)
        End If
        sw.Close()
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Close()
    End Sub
End Class
