Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

        Dim A As Double
        Dim pi As Double = 3.14
        Dim r As Double
        r = Val(TextBox1.Text)
        A = pi * r ^ 2
        TextBox2.Text = A

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class
