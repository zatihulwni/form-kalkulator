Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim tombol1 As Button = DirectCast(sender, Button)
        TextBoxHasil.Text += tombol1.Text
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim tombol2 As Button = DirectCast(sender, Button)
        TextBoxHasil.Text += tombol2.Text
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim tombol3 As Button = DirectCast(sender, Button)
        TextBoxHasil.Text += tombol3.Text
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim tombol4 As Button = DirectCast(sender, Button)
        TextBoxHasil.Text += tombol4.Text
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim tombol5 As Button = DirectCast(sender, Button)
        TextBoxHasil.Text += tombol5.Text
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim tombol6 As Button = DirectCast(sender, Button)
        TextBoxHasil.Text += tombol6.Text
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim tombol7 As Button = DirectCast(sender, Button)
        TextBoxHasil.Text += tombol7.Text
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim tombol1 As Button = DirectCast(sender, Button)
        TextBoxHasil.Text += tombol1.Text
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim tombol1 As Button = DirectCast(sender, Button)
        TextBoxHasil.Text += tombol1.Text
    End Sub



    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Buttonbagi.Click
        Dim tombolBagi As Button = DirectCast(sender, Button)
        TextBoxHasil.Text += " " + tombolBagi.Text + " "
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Buttonkali.Click
        Dim tombolkali As Button = DirectCast(sender, Button)
        TextBoxHasil.Text += " " + tombolkali.Text + " "
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Buttonkurang.Click
        Dim tombolkurang As Button = DirectCast(sender, Button)
        TextBoxHasil.Text += " " + tombolkurang.Text + " "
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Buttontambah.Click
        Dim tomboltambah As Button = DirectCast(sender, Button)
        TextBoxHasil.Text += " " + tomboltambah.Text + " "
    End Sub

    Private Sub buttonhitung_Click(sender As Object, e As EventArgs) Handles buttonhitung.Click
        Dim hasil As Double = EvaluateException(TextBoxHasil.Text)
        TextBoxHasil.Text = hasil.ToString()
    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        TextBoxHasil.Clear()

    End Sub

    Private Function EvaluateException(ekspresi As String) As Double
        Dim dt As New DataTable()
        Dim nilai As Object
        Try
            nilai = dt.Compute(ekspresi, "")
        Catch ex As Exception
            MessageBox.Show("Ekspresi Matematika tidak valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return 0
        End Try
        Return Convert.ToDouble(nilai)
    End Function


End Class
